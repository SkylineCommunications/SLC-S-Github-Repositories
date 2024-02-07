// Ignore Spelling: Utils Github Workflows Workflow

namespace Skyline.DataMiner.Utils.Github.Repositories.Core.Workflows
{
	using System.ComponentModel;

	/// <summary>
	/// The type of workflow.
	/// </summary>
	public enum WorkflowType
	{
		/// <summary>
		/// A DataMiner Automation Script CI Workflow.
		/// </summary>
		[Description("Automation Script CI")]
		AutomationScriptCI = 0,

		/// <summary>
		/// A DataMiner Automation Script CICD Workflow.
		/// </summary>
		[Description("Automation Script CICD")]
		AutomationScriptCICD = 1,

		/// <summary>
		/// A DataMiner Connector CI Workflow.
		/// </summary>
		[Description("Connector CI")]
		ConnectorCI = 2,

		/// <summary>
		/// A DataMiner Nuget Solution CICD Workflow.
		/// </summary>
		[Description("Nuget Solution CICD")]
		NugetSolutionCICD = 2,
	}

	/// <summary>
	/// The type of action that needs to be performed.
	/// </summary>
	public enum WorkflowAction
	{
		/// <summary>
		/// Action to add a new workflow to a repository.
		/// </summary>
		Add = 0,
	}

	/// <summary>
	/// A request object for the workflows table, that contains all the information to handle request.
	/// </summary>
	public interface IWorkflowsTableRequest
	{
		/// <summary>
		/// The full id of the repository in the following format: {owner}/{name}.
		/// </summary>
		string RepositoryId { get; }

		/// <summary>
		/// The action that needs to be performed on the table.
		/// </summary>
		WorkflowAction Action { get; }

		/// <summary>
		/// The type of workflow that needs to be added to the repository.
		/// </summary>
		WorkflowType WorkflowType { get; }
	}
}
