// Ignore Spelling: Github App Workflows

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows.Data
{
	using System;

	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows.Attributes;

	/// <summary>
	/// A request to add a single DataMiner Connector CI workflow to a repository.
	/// </summary>
	[Serializable]
	public class ConnectorCIWorkflowData
	{
		/// <summary>
		/// The Sonar Cloud Project ID retrieved from <see href="https://sonarcloud.io/"/>. 
		/// </summary>
		[WorkflowFileProperty]
		public string SonarCloudProjectID { get; set; }

		/// <summary>
		/// The DataMiner Deploy key retrieved from <see href="https://admin.dataminer.services/"/>.
		/// </summary>
		[WorkflowSecret("DATAMINER_DEPLOY_KEY")]
		public string DataMinerKey { get; set; }

		/// <summary>
		/// Optional Sonar Token secret to be used in case the repository is private.
		/// </summary>
		[WorkflowSecret("SONAR_TOKEN")]
		public string SonarToken { get; set; }
	}
}
