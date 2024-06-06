// Ignore Spelling: Github dma

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
	using Skyline.DataMiner.Core.InterAppCalls.Common.Shared;
	using Skyline.DataMiner.Net;
	using Skyline.DataMiner.Net.Messages;


	/// <summary>
	/// Represents a DataMiner element using the 'Skyline Example InterAppCalls' connector, that can handle InterApp Messages.
	/// </summary>
	public class GithubRepositories
	{
		private TimeSpan defaultTimeout = TimeSpan.FromSeconds(60);

		#region Constructors
		/// <summary>
		/// Initialize a new instance of the <see cref="GithubRepositories"/> class.
		/// </summary>
		/// <param name="connection">The connection interface.</param>
		/// <param name="elementName">The name of the element in DataMiner.</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public GithubRepositories(IConnection connection, string elementName)
		{
			if (String.IsNullOrEmpty(elementName))
			{
				throw new ArgumentException("Please provide a valid Element name.", nameof(elementName));
			}

			SLNetConnection = connection ?? throw new ArgumentNullException(nameof(connection));

			ElementInfoEventMessage elementInfo;
			try
			{
				elementInfo = (ElementInfoEventMessage)SLNetConnection.HandleSingleResponseMessage(new GetElementByNameMessage
				{
					ElementName = elementName,
				});
			}
			catch (Exception)
			{
				throw new ArgumentException($"The element does not exists with name '{elementName}'", nameof(elementName));
			}

			if (elementInfo.Protocol != Constants.ProtocolName)
			{
				throw new ArgumentException($"The element is not running protocol '{Constants.ProtocolName}'", nameof(elementName));
			}

			AgentId = elementInfo.DataMinerID;
			ElementId = elementInfo.ElementID;

			ProtocolVersion = new ProtocolVersion(elementInfo.ProtocolVersion);
		}

		/// <summary>
		/// Initialize a new instance of the <see cref="GithubRepositories"/> class.
		/// </summary>
		/// <param name="connection">The connection interface.</param>
		/// <param name="dmaId">The id of the DataMiner that is hosting the element.</param>
		/// <param name="elementId">The id of the element in DataMiner.</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public GithubRepositories(IConnection connection, int dmaId, int elementId)
		{
			if (dmaId == default)
			{
				throw new ArgumentException("Please provide a valid DMA ID.", nameof(dmaId));
			}

			if (elementId == default)
			{
				throw new ArgumentException("Please provide a valid Element ID.", nameof(elementId));
			}

			SLNetConnection = connection ?? throw new ArgumentNullException(nameof(connection));
			AgentId = dmaId;
			ElementId = elementId;

			ElementInfoEventMessage elementInfo;
			try
			{
				elementInfo = (ElementInfoEventMessage)SLNetConnection.HandleSingleResponseMessage(new GetElementByIDMessage
				{
					DataMinerID = dmaId,
					ElementID = elementId,
				});
			}
			catch
			{
				throw new ArgumentException($"The element does not exists with id '{dmaId}/{elementId}'", nameof(elementId));
			}

			if (elementInfo.Protocol != Constants.ProtocolName)
			{
				throw new ArgumentException($"The element is not running protocol '{Constants.ProtocolName}'", nameof(elementId));
			}

			ProtocolVersion = new ProtocolVersion(elementInfo.ProtocolVersion);
		}
		#endregion

		/// <summary>
		/// DataMiner Element Interface.
		/// </summary>
		public IConnection SLNetConnection { get; set; }

		/// <summary>
		/// The id of the DataMiner that is hosting the element.
		/// </summary>
		public int AgentId { get; }

		/// <summary>
		/// The id of the element in DataMiner.
		/// </summary>
		public int ElementId { get; }

		/// <summary>
		/// The protocol version of the element.
		/// </summary>
		public ProtocolVersion ProtocolVersion { get; }

		/// <summary>
		/// Sends the specified messages to the element using InterApp and do not wait for a response.
		/// </summary>
		/// <param name="messages">The messages that need to be send.</param>
		public void SendMessageNoResponse(params IGithubRequest[] messages)
		{
			if(!CheckVersion(out var description))
			{
				throw new InvalidVersionException(description);
			}

			IInterAppCall myCommands = InterAppCallFactory.CreateNew();
			myCommands.ReturnAddress = new ReturnAddress(AgentId, ElementId, Constants.InterAppResponsePID);
			myCommands.Messages.AddMessage(messages.Select(Types.ToMessage).ToArray());
			myCommands.Send(SLNetConnection, AgentId, ElementId, Constants.InterAppReceiverPID, Types.KnownTypes);
		}

		/// <summary>
		/// Sends the specified messages to the element using InterApp and wait for the responses.
		/// </summary>
		/// <param name="messages">The messages that need to be send.</param>
		/// <param name="timeout">The time the method needs to wait for a response.</param>
		/// <returns>The response coming from the device</returns>
		public IEnumerable<IGithubResponse> SendMessages(IGithubRequest[] messages, TimeSpan timeout = default)
		{
			if (!CheckVersion(out var description))
			{
				var returnMessages = new List<IGithubResponse>();
				foreach(var message in messages)
				{
					var responseType = Types.KnownTypeMapping[message.GetType()];
					var response = Activator.CreateInstance(responseType);
					responseType.GetProperty(nameof(IGithubResponse.Request)).SetValue(response, message);
					responseType.GetProperty(nameof(IGithubResponse.Description)).SetValue(response, description);
					responseType.GetProperty(nameof(IGithubResponse.Success)).SetValue(response, false);
					returnMessages.Add((IGithubResponse)response);
				}
				
				return returnMessages;
			}

			var interAppCallTimeout = timeout;
			if (timeout == default)
			{
				interAppCallTimeout = defaultTimeout;
			}

			IInterAppCall myCommands = InterAppCallFactory.CreateNew();
			myCommands.ReturnAddress = new ReturnAddress(AgentId, ElementId, Constants.InterAppResponsePID);
			myCommands.Messages.AddMessage(messages.Select(Types.ToMessage).ToArray());
			var internalResult = myCommands.Send(SLNetConnection, AgentId, ElementId, Constants.InterAppReceiverPID, interAppCallTimeout, Types.KnownTypes);
			return internalResult.Select(result => Types.FromMessage(result));
		}

		/// <summary>
		/// Sends the specified message to the element using InterApp and wait for the responses.
		/// </summary>
		/// <param name="message">The message that needs to be send.</param>
		/// <param name="timeout">The time the method needs to wait for a response.</param>
		/// <returns>The response coming from the device</returns>
		public IGithubResponse SendSingleResponseMessage(IGithubRequest message, TimeSpan timeout = default)
		{
			if (!CheckVersion(out var description))
			{
				var responseType = Types.KnownTypeMapping[message.GetType()];
				var response = Activator.CreateInstance(responseType);
				responseType.GetProperty(nameof(IGithubResponse.Request)).SetValue(response, message);
				responseType.GetProperty(nameof(IGithubResponse.Description)).SetValue(response, description);
				responseType.GetProperty(nameof(IGithubResponse.Success)).SetValue(response, false);
				return (IGithubResponse)response;
			}

			var interAppCallTimeout = timeout;
			if (timeout == default)
			{
				interAppCallTimeout = defaultTimeout;
			}

			IInterAppCall myCommand = InterAppCallFactory.CreateNew();
			myCommand.ReturnAddress = new ReturnAddress(AgentId, ElementId, Constants.InterAppResponsePID);
			myCommand.Messages.AddMessage(Types.ToMessage(message));
			var internalResult = myCommand.Send(SLNetConnection, AgentId, ElementId, Constants.InterAppReceiverPID, interAppCallTimeout, Types.KnownTypes).First();
			return Types.FromMessage(internalResult);
		}

		/// <summary>
		/// Sends the specified message to the element using InterApp and wait for the responses.
		/// </summary>
		/// <param name="message">The message that needs to be send.</param>
		/// <param name="timeout">The time the method needs to wait for a response.</param>
		/// <returns>The response coming from the device</returns>
		public T SendSingleResponseMessage<T>(IGithubRequest message, TimeSpan timeout = default)
			where T : IGithubResponse
		{
			if (!CheckVersion(out var description))
			{
				var responseType = typeof(T);
				var response = Activator.CreateInstance(typeof(T));
				responseType.GetProperty(nameof(IGithubResponse.Request)).SetValue(response, message);
				responseType.GetProperty(nameof(IGithubResponse.Description)).SetValue(response, description);
				responseType.GetProperty(nameof(IGithubResponse.Success)).SetValue(response, false);
				return (T)response;
			}

			var interAppCallTimeout = timeout;
			if (timeout == default)
			{
				interAppCallTimeout = defaultTimeout;
			}

			IInterAppCall myCommand = InterAppCallFactory.CreateNew();
			myCommand.ReturnAddress = new ReturnAddress(AgentId, ElementId, Constants.InterAppResponsePID);
			myCommand.Messages.AddMessage(Types.ToMessage(message));
			var internalResult = myCommand.Send(SLNetConnection, AgentId, ElementId, Constants.InterAppReceiverPID, interAppCallTimeout, Types.KnownTypes).First();
			return (T)Types.FromMessage(internalResult);
		}

		internal bool CheckVersion(out string description)
		{
			description = String.Empty;
			var versionCheck = ProtocolVersion.Seq >= 9;
			if (!versionCheck)
			{
				description = $"The element should be running at least version 1.0.0.9 or higher, to use this nuget package.";
			}

			return versionCheck;
		}
	}
}
