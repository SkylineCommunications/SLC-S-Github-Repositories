// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories
{
	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories.Data;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// InterApp Message that represents a request to add a collaborator to a repository.
	/// </summary>
	public class AddRepositoryCollaboratorRequest : IGithubRequest
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }

		/// <summary>
		/// Gets or sets the data required to add the collaborator.
		/// </summary>
		public AddCollaboratorData Data { get; set; } = new AddCollaboratorData();
	}

	/// <summary>
	/// InterApp Response Message that represents a response for adding a collaborator to a repository.
	/// </summary>
	public class AddRepositoryCollaboratorResponse : IGithubResponse
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }

		/// <inheritdoc/>
		public bool Success { get; set; }

		/// <inheritdoc/>
		public string Description { get; set; }

		/// <inheritdoc/>
		public IGithubRequest Request { get; set; }
	}
}
