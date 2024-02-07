// Ignore Spelling: Utils Github dataminer

namespace Skyline.DataMiner.Utils.Github.Repositories.Core.Repositories
{
	/// <summary>
	/// A request to remove a single repository, or all the repositories from an organization to the table,
	/// </summary>
	public class RemoveRepositoriesTableRequest : IRepositoriesTableRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RemoveRepositoriesTableRequest"/> class.
		/// </summary>
		/// <param name="owner">The owner of the repository.</param>
		/// <param name="name">The name of the repository.</param>
		public RemoveRepositoriesTableRequest(string owner, string name)
		{
			Action = RepositoryTableAction.Remove;
			Organization = IndividualOrOrganization.Individual;
			Data = new[] { $"{owner}/{name}" };
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RemoveRepositoriesTableRequest"/> class.
		/// </summary>
		/// <param name="organization">The name of the organization.</param>
		public RemoveRepositoriesTableRequest(string organization)
		{
			Action = RepositoryTableAction.Remove;
			Organization = IndividualOrOrganization.Organization;
			Data = new[] { organization };
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RemoveRepositoriesTableRequest"/> class.
		/// </summary>
		/// <param name="organization">Indicates if the given keys are individual repositories or organizations.</param>
		/// <param name="keys">The primary keys of the repositories or the names of the organizations, depending on the first argument.</param>
		public RemoveRepositoriesTableRequest(IndividualOrOrganization organization, params string[] keys)
		{
			Action = RepositoryTableAction.Remove;
			Organization = organization;
			Data = keys;
		}

		/// <inheritdoc/>
		public RepositoryTableAction Action { get; }

		/// <inheritdoc/>
		public IndividualOrOrganization Organization { get; }

		/// <inheritdoc/>
		public string[] Data { get; }
	}
}
