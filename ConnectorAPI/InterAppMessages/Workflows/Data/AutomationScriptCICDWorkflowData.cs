// Ignore Spelling: Github App Workflows

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows.Data
{
    using System;

    using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows.Attributes;

    /// <summary>
    /// A request to add a single DataMiner Automation Script CICD workflow to a repository.
    /// </summary>
    [Serializable]
#pragma warning disable S101 // Types should be named in PascalCase
	public class AutomationScriptCICDWorkflowData
#pragma warning restore S101 // Types should be named in PascalCase
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
    }
}
