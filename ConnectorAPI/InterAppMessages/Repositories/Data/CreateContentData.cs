// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories.Data
{
	using System;

	/// <summary>
	/// A class that holds the data needed to create or update a file in the repository.
	/// </summary>
	[Serializable]
	public class CreateContentData
	{
		/// <summary>
		/// [Required]
		/// Indicates wheter to use the Path property or the Content property.
		/// </summary>
		public UpdateMethod Method { get; set; }

		/// <summary>
		/// [Optional]
		/// The path of the file that needs to be used to create or update the repository.
		/// </summary>
		public string Path { get; set; }

		/// <summary>
		/// [Optional]
		/// The raw content of the file to be used to create or update the repository.
		/// </summary>
		public string Content { get; set; }
	}
}
