// Ignore Spelling: Utils Github Workflows Workflow

namespace Skyline.DataMiner.Utils.Github.Repositories.Core.Workflows
{
	using System;

	/// <summary>
	/// A request to add a single workflow to a repository.
	/// </summary>
	[Serializable]
	public class BaseWorkflowRequest : IWorkflowsTableRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BaseWorkflowRequest"/> class.
		/// </summary>
		/// <param name="repositoryId">The full ID of the repository in the following format: {owner}/{name}</param>
		/// <param name="type">The type of workflow that needs to be added.</param>
		/// <param name="action">The action that needs to be performed.</param>
		public BaseWorkflowRequest(string repositoryId, WorkflowType type, WorkflowAction action)
		{
			RepositoryId = repositoryId;
			WorkflowType = type;
			Action = action;
		}

		/// <inheritdoc/>
		public string RepositoryId { get; set; }

		/// <inheritdoc/>
		public WorkflowAction Action { get; set; }

		/// <inheritdoc/>
		public WorkflowType WorkflowType { get; set; }
	}
}
