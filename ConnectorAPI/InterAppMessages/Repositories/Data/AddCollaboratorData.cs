// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories.Data
{
	using System;

	/// <summary>
	/// Represents data required to add a collaborator to a GitHub repository.
	/// </summary>
	[Serializable]
	public class AddCollaboratorData
	{
		/// <summary>
		/// Gets or sets the type of collaborator (e.g., user, team).
		/// </summary>
		public CollaboratorType CollaboratorType { get; set; }

		/// <summary>
		/// Gets or sets the organization to which the repository belongs.
		/// </summary>
		public string RepositoryOrganization { get; set; }

		/// <summary>
		/// Gets or sets the slug (username or team name) of the collaborator.
		/// </summary>
		public string CollaboratorSlug { get; set; }

		/// <summary>
		/// Gets or sets the permission type that can be granted to a collaborator on a GitHub repository.
		/// </summary>
		public PermissionType Permission { get; set; }
	}
}
