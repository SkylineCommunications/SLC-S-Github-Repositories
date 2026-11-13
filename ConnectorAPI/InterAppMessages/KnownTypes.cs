// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories;
	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Static class holding the types of the InterApp Messages.
	/// </summary>
	public static class Types
	{
		/// <summary>
		/// Gets a mapping between the supported InterApp Message requests and their response types.
		/// </summary>
		public static Dictionary<Type, Type> KnownTypeMapping { get; } = new Dictionary<Type, Type>
		{
			{ typeof(AddRepositoryRequest),                         typeof(AddRepositoryResponse) },
			{ typeof(CreateRepositoryRequest),                      typeof(CreateRepositoryResponse) },
			{ typeof(CreateRepositoryContentRequest),               typeof(CreateRepositoryContentResponse) },
			{ typeof(AddRepositoryCollaboratorRequest),             typeof(AddRepositoryCollaboratorResponse) },
			{ typeof(RemoveRepositoryRequest),                      typeof(RemoveRepositoryResponse) },
			{ typeof(AddRepositoryTopicsRequest),                   typeof(AddRepositoryTopicsResponse) },
			{ typeof(RemoveRepositoryTopicsRequest),                typeof(RemoveRepositoryTopicsResponse) },

#pragma warning disable CS0618 // Deprecated workflow requests must stay registered while the connector still supports them.
			{ typeof(AddWorkflowRequest),                           typeof(AddWorkflowResponse) },
			{ typeof(AddAutomationScriptCIWorkflowRequest),         typeof(AddWorkflowResponse) },
			{ typeof(AddAutomationScriptCICDWorkflowRequest),       typeof(AddWorkflowResponse) },
			{ typeof(AddConnectorCIWorkflowRequest),                typeof(AddWorkflowResponse) },
			{ typeof(AddNugetCICDWorkflowRequest),                  typeof(AddWorkflowResponse) },
			{ typeof(AddInternalNugetCICDWorkflowRequest),          typeof(AddWorkflowResponse) },
			{ typeof(AddCustomWorkflowRequest),                     typeof(AddWorkflowResponse) },
#pragma warning restore CS0618
			{ typeof(ExecuteWorkflowRequest),                       typeof(ExecuteWorkflowResponse) },
		};

		/// <summary>
		/// Gets a list of all the supported InterApp Message Types.
		/// </summary>
		public static List<Type> KnownTypes { get; } = KnownTypeMapping.Keys
			.Concat(KnownTypeMapping.Values)
			.Distinct()
			.Select(type => typeof(GenericInterAppMessage<>).MakeGenericType(type))
			.ToList();

		internal static Message ToMessage(IGithubMessage message)
		{
			var messageType = message?.GetType();
			if (messageType == null || !KnownTypeMapping.ContainsKey(messageType))
			{
				throw new InvalidOperationException($"No InterApp mapping is registered for request type '{messageType?.FullName ?? "null"}'.");
			}

			return (Message)Activator.CreateInstance(typeof(GenericInterAppMessage<>).MakeGenericType(messageType), message);
		}

		internal static IGithubResponse FromMessage(Message message)
		{
			var messageType = message?.GetType();
			if (messageType == null || !KnownTypes.Contains(messageType)
				|| !(messageType.GetProperty(nameof(GenericInterAppMessage<IGithubMessage>.Data)).GetValue(message) is IGithubResponse response))
			{
				throw new InvalidOperationException($"No InterApp response mapping is registered for message type '{messageType?.FullName ?? "null"}'.");
			}

			return response;
		}
	}
}