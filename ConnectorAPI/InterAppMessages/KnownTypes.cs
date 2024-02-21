// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages
{
	using System;
	using System.Collections.Generic;

	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories;
	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows;

	/// <summary>
	/// Static class holding the types of the InterApp Messages.
	/// </summary>
	public static class Types
	{
		/// <summary>
		/// Gets a list of all the supported InterApp Message Types.
		/// </summary>
		public static List<Type> KnownTypes { get; } = new List<Type>
		{
			// Repositories
			typeof(AddRepositoryRequest),
			typeof(AddRepositoryResponse),
			typeof(RemoveRepositoryRequest),
			typeof(RemoveRepositoryResponse),

			// Workflows
			typeof(AddWorkflowRequest),
			typeof(AddAutomationScriptCIWorkflowRequest),
			typeof(AddAutomationScriptCICDWorkflowRequest),
			typeof(AddConnectorCIWorkflowRequest),
			typeof(AddNugetCICDWorkflowRequest),
			typeof(AddInternalNugetCICDWorkflowRequest),
			typeof(AddWorkflowResponse),
		};
	}
}
