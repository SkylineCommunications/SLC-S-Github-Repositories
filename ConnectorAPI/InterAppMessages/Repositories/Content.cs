// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories
{
	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories.Data;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// InterApp Message that will add a new repository to the tracked repositories.
	/// </summary>
	public class CreateRepositoryContentRequest : IGithubRequest
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }

		/// <summary>
		/// The relative path of the file in the repository.
		/// </summary>
		/// <example>
		/// For example if you want to update the readme that is located in the root of the repository:
		/// https://github.com/SkylineCommunications/SLC-C-Github-Repositories/README.md
		/// then the RepositoryPath property needs to be 'README.md'.
		/// </example>
		public string RepositoryPath { get; set; }

		/// <summary>
		/// [Optional]
		/// A commit message for the content.
		/// </summary>
		public string CommitMessage { get; set; }

		/// <summary>
		/// The file data needed to create or update the file.
		/// </summary>
		public CreateContentData Data { get; set; } = new CreateContentData();
	}

	/// <summary>
	/// InterApp Response Message that will add a new repository to the tracked repositories.
	/// </summary>
	public class CreateRepositoryContentResponse : IGithubResponse
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }

		/// <summary>
		/// The relative path of the file in the repository.
		/// </summary>
		/// <example>
		/// For example if you want to update the readme that is located in the root of the repository:
		/// https://github.com/SkylineCommunications/SLC-C-Github-Repositories/README.md
		/// then the RepositoryPath property needs to be 'README.md'.
		/// </example>
		public string RepositoryPath { get; set; }

		/// <inheritdoc/>
		public bool Success { get; set; }

		/// <inheritdoc/>
		public string Description { get; set; }

		/// <inheritdoc/>
		public IGithubRequest Request { get; set; }
	}
}
