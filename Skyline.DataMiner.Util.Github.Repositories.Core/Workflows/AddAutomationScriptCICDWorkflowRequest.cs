// Ignore Spelling: Utils Github Workflows Workflow dataminer

namespace Skyline.DataMiner.Utils.Github.Repositories.Core.Workflows
{
	using System;

	/// <summary>
	/// A request to add a single DataMiner Automation Script CICD workflow to a repository.
	/// </summary>
	[Serializable]
#pragma warning disable S101 // Types should be named in PascalCase
	public class AddAutomationScriptCICDWorkflowRequest : BaseWorkflowRequest
#pragma warning restore S101 // Types should be named in PascalCase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddAutomationScriptCICDWorkflowRequest"/> class.
		/// </summary>
		/// <param name="repositoryId">The full ID of the repository in the following format: {owner}/{name}</param>
		/// <param name="sonarCloudProjectId">The Sonar Cloud Project ID retrieved from <see href="https://sonarcloud.io/"/>.</param>
		/// <param name="dataminerKey">The DataMiner Deploy key retrieved from <see href="https://admin.dataminer.services/"/>.</param>
		public AddAutomationScriptCICDWorkflowRequest(string repositoryId, string sonarCloudProjectId, string dataminerKey)
			: base(repositoryId, WorkflowType.AutomationScriptCICD, WorkflowAction.Add)
		{
			SonarCloudProjectID = sonarCloudProjectId;
			DataMinerKey = dataminerKey;
		}

		/// <summary>
		/// The Sonar Cloud Project ID retrieved from <see href="https://sonarcloud.io/"/>. 
		/// </summary>
		public string SonarCloudProjectID { get; private set; }

		/// <summary>
		/// The DataMiner Deploy key retrieved from <see href="https://admin.dataminer.services/"/>.
		/// </summary>
		public string DataMinerKey { get; private set; }
	}
}
