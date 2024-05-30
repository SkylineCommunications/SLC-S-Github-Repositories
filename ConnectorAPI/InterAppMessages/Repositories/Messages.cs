// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories
{
	using Skyline.DataMiner.ConnectorAPI.Github.Repositories;
	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories.Data;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// InterApp Message that will add a new repository to the tracked repositories.
	/// </summary>
	public class AddRepositoryRequest : IGithubRequest
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }
	}

	/// <summary>
	/// InterApp Response Message that will add a new repository to the tracked repositories.
	/// </summary>
	public class AddRepositoryResponse : IGithubResponse
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

	/// <summary>
	/// InterApp Message that will create a new repository and add it to the tracked repositories.
	/// </summary>
	public class CreateRepositoryRequest : IGithubRequest
	{
		/// <summary>
		/// The content needed to create a repository.
		/// </summary>
		public CreateRepositoryData Data { get; set; } = new CreateRepositoryData();
	}

	/// <summary>
	/// InterApp Response Message that will create a new repository and add it to the tracked repositories.
	/// </summary>
	public class CreateRepositoryResponse : IGithubResponse
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

	/// <summary>
	/// InterApp Message that will remove a repository from the tracked repositories.
	/// </summary>
	public class RemoveRepositoryRequest : IGithubRequest
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }
	}

	/// <summary>
	/// InterApp Response Message that will remove a repository from the tracked repositories.
	/// </summary>
	public class RemoveRepositoryResponse : IGithubResponse
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
