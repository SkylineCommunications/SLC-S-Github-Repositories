// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories
{
    using Skyline.DataMiner.ConnectorAPI.Github.Repositories;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// InterApp Message that will add a new repository to the tracked repositories.
    /// </summary>
    public class AddRepositoryRequest : Message
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }
	}

	/// <summary>
	/// InterApp Response Message that will add a new repository to the tracked repositories.
	/// </summary>
	public class AddRepositoryResponse : BaseResponseMessage<AddRepositoryRequest>
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }
	}

	/// <summary>
	/// InterApp Message that will remove a repository from the tracked repositories.
	/// </summary>
	public class RemoveRepositoryRequest : Message
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }
	}

	/// <summary>
	/// InterApp Response Message that will remove a repository from the tracked repositories.
	/// </summary>
	public class RemoveRepositoryResponse : BaseResponseMessage<RemoveRepositoryRequest>
	{
		/// <summary>
		/// The ID of the repository.
		/// </summary>
		public RepositoryId RepositoryId { get; set; }
	}
}
