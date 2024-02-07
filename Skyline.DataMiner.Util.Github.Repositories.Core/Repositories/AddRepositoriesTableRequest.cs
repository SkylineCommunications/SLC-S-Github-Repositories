// Ignore Spelling: Utils Github dataminer

namespace Skyline.DataMiner.Utils.Github.Repositories.Core.Repositories
{
	/// <summary>
	/// A request to add a single repository, or all the repositories from an organization to the table.
	/// </summary>
	public class AddRepositoriesTableRequest : IRepositoriesTableRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddRepositoriesTableRequest"/> class.
		/// </summary>
		/// <param name="owner">The owner of the repository.</param>
		/// <param name="name">The name of the repository.</param>
		public AddRepositoriesTableRequest(string owner, string name)
		{
			Action = RepositoryTableAction.Add;
			Organization = IndividualOrOrganization.Individual;
			Data = new[] { owner, name };
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AddRepositoriesTableRequest"/> class.
		/// </summary>
		/// <param name="organization">The name of the organization of which you want to add all the repositories.</param>
		public AddRepositoriesTableRequest(string organization)
		{
			Action = RepositoryTableAction.Add;
			Organization = IndividualOrOrganization.Organization;
			Data = new[] { organization };
		}

		/// <inheritdoc/>
		public RepositoryTableAction Action { get; }

		/// <inheritdoc/>
		public IndividualOrOrganization Organization { get; }

		/// <inheritdoc/>
		public string[] Data { get; }
	}
}
