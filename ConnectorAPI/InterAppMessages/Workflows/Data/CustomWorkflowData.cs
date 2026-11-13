// Ignore Spelling: Github App Workflows Nuget Api

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows.Data
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Data used to add a custom GitHub Actions workflow to a repository.
	/// </summary>
	[Serializable]
	public class CustomWorkflowData
	{
		/// <summary>
		/// The name of the workflow, used as the file name in <c>.github/workflows</c>.
		/// </summary>
		public string WorkflowName { get; set; }

		/// <summary>
		/// The full YAML content of the workflow file.
		/// </summary>
		public string WorkflowYaml { get; set; }

		/// <summary>
		/// GitHub Actions secrets to add to the repository. The key is the secret name, the value is the plaintext secret value.
		/// </summary>
		public Dictionary<string, string> Secrets { get; set; } = new Dictionary<string, string>();

		/// <summary>
		/// GitHub Actions variables to add to the repository. The key is the variable name, the value is the variable value.
		/// </summary>
		public Dictionary<string, string> Variables { get; set; } = new Dictionary<string, string>();
	}
}
