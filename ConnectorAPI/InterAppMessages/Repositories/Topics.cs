// Ignore Spelling: Github

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// InterApp Message that represents a request to add a list of topics to a repository.
	/// </summary>
	public class AddRepositoryTopicsRequest : IGithubRequest
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }

		/// <summary>
		/// Gets or sets the topics to be added.
		/// </summary>
		public IEnumerable<string> Topics { get; set; } = new List<string>();
	}

	/// <summary>
	/// InterApp Response Message that represents a response for adding a list of topics to a repository.
	/// </summary>
	public class AddRepositoryTopicsResponse : IGithubResponse
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
	/// InterApp Message that represents a request to remove a list of topics to a repository.
	/// </summary>
	public class RemoveRepositoryTopicsRequest : IGithubRequest
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }

		/// <summary>
		/// Gets or sets the topics to be removed.
		/// </summary>
		public IEnumerable<string> Topics { get; set; } = new List<string>();
	}

	/// <summary>
	/// InterApp Response Message that represents a response for removing a list of topics to a repository.
	/// </summary>
	public class RemoveRepositoryTopicsResponse : IGithubResponse
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
