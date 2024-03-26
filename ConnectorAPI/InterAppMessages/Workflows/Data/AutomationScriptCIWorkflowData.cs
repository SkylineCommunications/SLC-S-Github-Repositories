// Ignore Spelling: Github App Workflows

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows.Data
{
	using System;

	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows.Attributes;

	/// <summary>
	/// Class that contains all the information to create a new Automation Script CI workflow.
	/// </summary>
	[Serializable]
	public class AutomationScriptCIWorkflowData
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
