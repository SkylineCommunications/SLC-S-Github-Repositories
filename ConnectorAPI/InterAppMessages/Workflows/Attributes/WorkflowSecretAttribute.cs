// Ignore Spelling: Github App Workflows

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows.Attributes
{
	using System;

	/// <summary>
	/// An Attribute to indicate this property should be handled as a workflow secret, and therefore added to the secrets of the repository.
	/// </summary>
	[Serializable]
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public sealed class WorkflowSecretAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkflowSecretAttribute"/> class.
		/// </summary>
		/// <param name="name">The name of the secret</param>
		public WorkflowSecretAttribute(string name)
		{
			Name = name;
		}

		/// <summary>
		/// The name of the secret.
		/// </summary>
		public string Name { get; set; }
	}
}
