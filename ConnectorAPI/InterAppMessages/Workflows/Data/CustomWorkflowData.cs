// Ignore Spelling: Github App Workflows Nuget Api

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows.Data
{
	using System;
	using System.Collections.Generic;

	[Serializable]
	public class CustomWorkflowData
	{
		public string WorkflowName { get; set; }

		public string WorkflowYaml { get; set; }

		public Dictionary<string, string> Secrets { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Variables { get; set; } = new Dictionary<string, string>();
	}
}
