// Ignore Spelling: Utils Github Workflows Workflow dataminer Nuget Api

namespace Skyline.DataMiner.Utils.Github.Repositories.Core.Workflows
{
	using System;

	/// <summary>
	/// A request to add a single DataMiner Nuget Soluction CICD workflow to a repository.
	/// </summary>
	[Serializable]
#pragma warning disable S101 // Types should be named in PascalCase
	public class AddNugetCICDWorkflowRequest : BaseWorkflowRequest
#pragma warning restore S101 // Types should be named in PascalCase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddNugetCICDWorkflowRequest"/> class.
		/// </summary>
		/// <param name="repositoryId">The full ID of the repository in the following format: {owner}/{name}</param>
		/// <param name="sonarCloudProjectId">The Sonar Cloud Project ID retrieved from <see href="https://sonarcloud.io/"/>.</param>
		/// <param name="nugetApiKey">The Nuget API key retrieved after the Principal+ group approved the nuget request.</param>
		public AddNugetCICDWorkflowRequest(string repositoryId, string sonarCloudProjectId, string nugetApiKey)
			: base(repositoryId, WorkflowType.NugetSolutionCICD, WorkflowAction.Add)
		{
			SonarCloudProjectID = sonarCloudProjectId;
			NugetApiKey = nugetApiKey;
		}

		/// <summary>
		/// The Sonar Cloud Project ID retrieved from <see href="https://sonarcloud.io/"/>. 
		/// </summary>
		[WorkflowFileProperty]
		public string SonarCloudProjectID { get; private set; }

		/// <summary>
		/// The DataMiner Deploy key retrieved from <see href="https://admin.dataminer.services/"/>.
		/// </summary>
		[WorkflowSecret]
		public string NugetApiKey { get; private set; }
	}

}
