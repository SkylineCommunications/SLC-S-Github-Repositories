// Ignore Spelling: Github App Workflows

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows.Attributes
{
	using System;

	/// <summary>
	/// An Attribute to indicate this property should be handled as a workflow secret, and therefore added to the secrets of the repository.
	/// </summary>
	[Serializable]
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public sealed class WorkflowFilePropertyAttribute : Attribute
	{
	}
}
