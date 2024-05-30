// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories.Data
{
	using System;

	/// <summary>
	/// A class that holds the data needed to create a repository.
	/// </summary>
	[Serializable]
	public class CreateRepositoryData
	{
		/// <summary>
		/// [Required]
		/// The primary key of the organization the repository needs to be created under.
		/// </summary>
		public string OrganizationId { get; set; }

		/// <summary>
		/// [Required]
		/// The name of the repository.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// [Optional]
		/// A short description of the repository.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// [Optional: default false]
		/// Whether the repository is public.
		/// </summary>
		public bool Public { get; set; } = false;
	}
}
