// Ignore Spelling: Github

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories
{
	using System;
	using System.Runtime.Serialization;

	/// <summary>
	/// A class representing an exception when a wrong version is used.
	/// </summary>
	[Serializable]
	public class InvalidVersionException : Exception
	{
		/// <summary>
		/// Instantiates a new instance of the <see cref="InvalidVersionException"/> class.
		/// </summary>
		public InvalidVersionException() { }

		/// <summary>
		/// Instantiates a new instance of the <see cref="InvalidVersionException"/> class.
		/// </summary>
		/// <param name="message">The error message.</param>
		public InvalidVersionException(string message) : base(message) { }

		/// <summary>
		/// Instantiates a new instance of the <see cref="InvalidVersionException"/> class.
		/// </summary>
		/// <param name="message">The error message.</param>
		/// <param name="innerException">The inner exception.</param>
		public InvalidVersionException(string message, Exception innerException) : base(message, innerException) { }

		/// <summary>
		/// Instantiates a new instance of the <see cref="InvalidVersionException"/> class.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected InvalidVersionException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
