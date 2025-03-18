// Ignore Spelling: Github App Workflows Nuget deserialize

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows
{
	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows.Data;
    using System.Collections.Generic;

    /// <summary>
    /// A request object for the workflows table, that contains all the information to handle request.
    /// </summary>
    public interface IWorkflowData
	{
		/// <summary>
		/// The full id of the repository.
		/// </summary>
		RepositoryId RepositoryId { get; }

		/// <summary>
		/// The type of workflow that needs to be added to the repository.
		/// </summary>
		WorkflowType WorkflowType { get; }
	}

	/// <summary>
	/// InterApp Message that will add a new repository workflow with no input data.
	/// </summary>
	public class AddWorkflowRequest : IGithubRequest, IWorkflowData
	{
		/// <inheritdoc/>
		public RepositoryId RepositoryId { get; set; }

		/// <inheritdoc/>
		public WorkflowType WorkflowType { get; protected set; }
	}

	/// <summary>
	/// InterApp Message that will add a new repository Automation Script CI Workflow to the tracked repositories.
	/// </summary>
	public class AddAutomationScriptCIWorkflowRequest : AddWorkflowRequest
	{
		/// <summary>
		/// Instantiates a new instance of the <see cref="AddAutomationScriptCIWorkflowRequest"/> class.
		/// </summary>
		public AddAutomationScriptCIWorkflowRequest()
		{
			WorkflowType = WorkflowType.AutomationScriptCI;
		}

		/// <summary>
		/// The data needed to create an Automation Script CI Workflow.
		/// </summary>
		public AutomationScriptCIWorkflowData Data { get; set; } = new AutomationScriptCIWorkflowData();
	}

	/// <summary>
	/// InterApp Message that will add a new repository Automation Script CICD Workflow to the tracked repositories.
	/// </summary>
#pragma warning disable S101 // Types should be named in PascalCase
	public class AddAutomationScriptCICDWorkflowRequest : AddWorkflowRequest
#pragma warning restore S101 // Types should be named in PascalCase
	{
		/// <summary>
		/// Instantiates a new instance of the <see cref="AddAutomationScriptCICDWorkflowRequest"/> class.
		/// </summary>
		public AddAutomationScriptCICDWorkflowRequest()
		{
			WorkflowType = WorkflowType.AutomationScriptCICD;
		}

		/// <summary>
		/// The data needed to create an Automation Script CICD Workflow.
		/// </summary>
		public AutomationScriptCICDWorkflowData Data { get; set; } = new AutomationScriptCICDWorkflowData();
	}

	/// <summary>
	/// InterApp Message that will add a new repository Connector CI Workflow to the tracked repositories.
	/// </summary>
	public class AddConnectorCIWorkflowRequest : AddWorkflowRequest
	{
		/// <summary>
		/// Instantiates a new instance of the <see cref="AddConnectorCIWorkflowRequest"/> class.
		/// </summary>
		public AddConnectorCIWorkflowRequest()
		{
			WorkflowType = WorkflowType.ConnectorCI;
		}

		/// <summary>
		/// The data needed to create an Connector CI Workflow.
		/// </summary>
		public ConnectorCIWorkflowData Data { get; set; } = new ConnectorCIWorkflowData();
	}

	/// <summary>
	/// InterApp Message that will add a new repository Automation Script CICD Workflow to the tracked repositories.
	/// </summary>
#pragma warning disable S101 // Types should be named in PascalCase
	public class AddNugetCICDWorkflowRequest : AddWorkflowRequest
#pragma warning restore S101 // Types should be named in PascalCase
	{
		/// <summary>
		/// Instantiates a new instance of the <see cref="AddNugetCICDWorkflowRequest"/> class.
		/// </summary>
		public AddNugetCICDWorkflowRequest()
		{
			WorkflowType = WorkflowType.NugetSolutionCICD;
		}

		/// <summary>
		/// The data needed to create an Nuget Solution CICD Workflow.
		/// </summary>
		public NugetCICDWorkflowData Data { get; set; } = new NugetCICDWorkflowData();
	}

	/// <summary>
	/// InterApp Message that will add a new repository Internal Nuget CICD Workflow to the tracked repositories.
	/// </summary>
#pragma warning disable S101 // Types should be named in PascalCase
	public class AddInternalNugetCICDWorkflowRequest : AddWorkflowRequest
#pragma warning restore S101 // Types should be named in PascalCase
	{
		/// <summary>
		/// Instantiates a new instance of the <see cref="AddInternalNugetCICDWorkflowRequest"/> class.
		/// </summary>
		public AddInternalNugetCICDWorkflowRequest()
		{
			WorkflowType = WorkflowType.InternalNugetSolutionCICD;
		}

		/// <summary>
		/// The data needed to create an Nuget Solution CICD Workflow.
		/// </summary>
		public InternalNugetCICDWorkflowData Data { get; set; } = new InternalNugetCICDWorkflowData();
	}

	/// <summary>
	/// InterApp Response Message that will hold the result of the workflow creation.
	/// </summary>
	public class AddWorkflowResponse : IGithubResponse
	{
		/// <inheritdoc/>
		public bool Success { get; set; }

		/// <inheritdoc/>
		public string Description { get; set; }

		/// <inheritdoc/>
		public IGithubRequest Request { get; set; }
	}

    /// <summary>
    /// InterApp Message that will execute a workflow.
    /// </summary>
    public class ExecuteWorkflowRequest : IGithubRequest, IWorkflowData
    {
        /// <summary>
        /// Instantiates a new instance of the <see cref="ExecuteWorkflowRequest"/> class.
        /// </summary>
        public ExecuteWorkflowRequest()
        {
            WorkflowType = WorkflowType.Generic;
        }

        /// <inheritdoc/>
        public RepositoryId RepositoryId { get; set; }

        /// <summary>
		/// The id of the workflow to be executed.
		/// </summary>
        public string WorkflowId { get; set; }

        /// <summary>
        /// The branch or tag name to execute the workflow on
        /// </summary>
        public string WorkflowReference { get; set; }

        /// <summary>
		/// Any inputs required by the workflow in order for it to be executed.
		/// </summary>
        public Dictionary<string, string> WorkflowInputs { get; set; }

        /// <inheritdoc/>
        public WorkflowType WorkflowType { get; protected set; }
    }

    /// <summary>
    /// InterApp Response Message that will hold the result of the workflow execution.
    /// </summary>
    public class ExecuteWorkflowResponse : IGithubResponse
    {
        /// <inheritdoc/>
        public bool Success { get; set; }

        /// <inheritdoc/>
        public string Description { get; set; }

        /// <inheritdoc/>
        public IGithubRequest Request { get; set; }
    }
}
