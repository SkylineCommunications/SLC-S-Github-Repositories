// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories
{
	/// <summary>
	/// Represents the method used for updating.
	/// </summary>
	public enum UpdateMethod
	{
		/// <summary>
		/// Indicates that the update will be performed with raw data.
		/// </summary>
		Raw,

		/// <summary>
		/// Indicates that the update will be performed using a file.
		/// </summary>
		File,
	}

	/// <summary>
	/// Represents the type of collaborator used when adding a new one.
	/// </summary>
	public enum CollaboratorType
	{
		/// <summary>
		/// Indicates that the collaborator is an individual user.
		/// </summary>
		User,

		/// <summary>
		/// Indicates that the collaborator is a team.
		/// </summary>
		Team,
	}

	/// <summary>
	/// Represents the permission types that can be granted to a collaborator on a GitHub repository.
	/// </summary>
	public enum PermissionType
	{
		/// <summary>
		/// Grants read-only access to the repository.
		/// </summary>
		Read,

		/// <summary>
		/// Grants the ability to triage issues and pull requests.
		/// </summary>
		Triage,

		/// <summary>
		/// Grants write access to the repository, allowing the collaborator to push to the repository.
		/// </summary>
		Write,

		/// <summary>
		/// Grants maintain access to the repository, allowing the collaborator to push, merge, and manage releases.
		/// </summary>
		Maintain,

		/// <summary>
		/// Grants full administrative access to the repository, allowing the collaborator to manage repository settings and permissions.
		/// </summary>
		Admin
	}
}
