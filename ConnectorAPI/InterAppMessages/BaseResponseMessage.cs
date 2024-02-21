// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages
{
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Base class that hold default properties that every response has.
	/// </summary>
	/// <typeparam name="T">The type of the request message.</typeparam>
	public abstract class BaseResponseMessage<T> : Message where T : Message
	{
		/// <summary>
		/// Indicates if the InterApp Call was successful or not
		/// </summary>
		public bool Success { get; set; }

		/// <summary>
		/// A human readable text representing the response of the InterApp Call.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The InterApp Message that triggered this response.
		/// </summary>
		public T Request { get; set; }
	}
}
