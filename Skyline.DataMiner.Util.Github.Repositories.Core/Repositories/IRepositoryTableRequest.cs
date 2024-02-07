// Ignore Spelling: Utils Github dataminer

namespace Skyline.DataMiner.Utils.Github.Repositories.Core.Repositories
{
	/// <summary>
	/// Enum of different action that can be performed on the repositories table of an element.
	/// </summary>
	public enum RepositoryTableAction
	{
		/// <summary>
		/// Action to add a new repository to an element.
		/// </summary>
		Add,

		/// <summary>
		/// Action to remove a repository from an element.
		/// </summary>
		Remove,
	}

	/// <summary>
	/// Enum to indicate whether or not the request needs to be performed organizational wide, or repository wide.
	/// </summary>
	public enum IndividualOrOrganization
	{
		/// <summary>
		/// Indicates that the request should be considered repository wide.
		/// </summary>
		Individual,

		/// <summary>
		/// Indicates that the request should be considered organizational wide.
		/// </summary>
		Organization,
	}

	/// <summary>
	/// A request object for the repositories table, that contains all the information to handle request.
	/// </summary>
	public interface IRepositoriesTableRequest
	{
		/// <summary>
		/// The action that needs to be performed on the table.
		/// </summary>
		RepositoryTableAction Action { get; }

		/// <summary>
		/// The scope of the request.
		/// </summary>
		IndividualOrOrganization Organization { get; }

		/// <summary>
		/// The data needed to execute the request.
		/// </summary>
		string[] Data { get; }
	}
}
