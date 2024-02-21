// Ignore Spelling: Github App Workflows Nuget

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows
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
		NugetSolutionCICD = 3,

		/// <summary>
		/// A DataMiner Internal Nuget Solution CICD Workflow.
		/// </summary>
		[Description("Internal Nuget Solution CICD")]
		InternalNugetSolutionCICD = 4,
	}
}
