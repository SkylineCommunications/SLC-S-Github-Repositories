namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.Tests
{
	using System;

	using Microsoft.VisualStudio.TestTools.UnitTesting;

	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	[TestClass]
	public class KnownTypesTests
	{
		[TestMethod]
		public void EveryMappedRequestAndResponse_RoundTrips()
		{
			foreach (var mapping in Types.KnownTypeMapping)
			{
				var request = (IGithubRequest)Activator.CreateInstance(mapping.Key);
				var requestMessage = Types.ToMessage(request);
				CollectionAssert.Contains(Types.KnownTypes, requestMessage.GetType(), mapping.Key.Name);

				var response = (IGithubResponse)Activator.CreateInstance(mapping.Value);
				var wrapperType = typeof(GenericInterAppMessage<>).MakeGenericType(mapping.Value);
				CollectionAssert.Contains(Types.KnownTypes, wrapperType, mapping.Value.Name);

				var responseMessage = (Message)Activator.CreateInstance(wrapperType, response);
				Assert.AreSame(response, Types.FromMessage(responseMessage), mapping.Value.Name);
			}
		}
	}
}
