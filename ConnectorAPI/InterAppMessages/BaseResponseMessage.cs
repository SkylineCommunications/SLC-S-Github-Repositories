// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages
{
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Represents an InterApp Message that a GitHub Repositories element can receive.
	/// </summary>
	public interface IGithubMessage
	{
	}

	/// <summary>
	/// Represents a generic inter-application message that contains data of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of the data contained in the message, which must implement <see cref="IGithubMessage"/>.</typeparam>
	public class GenericInterAppMessage<T> : Message
		where T : IGithubMessage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GenericInterAppMessage{T}"/> class with the specified data.
		/// </summary>
		/// <param name="data">The data contained in the message.</param>
		public GenericInterAppMessage(T data)
		{
			Data = data;
		}

		/// <summary>
		/// Gets the data contained in the message.
		/// </summary>
		public T Data { get; }
	}

	/// <summary>
	/// Base class that hold default properties that every request has.
	/// </summary>
	public interface IGithubRequest : IGithubMessage
	{
	}

	/// <summary>
	/// Machine-readable classification of the outcome of an InterApp Call.
	/// </summary>
	public enum GithubResponseStatus
	{
		/// <summary>
		/// The outcome was not classified, for example because the connector does not support this field yet.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The request was handled successfully.
		/// </summary>
		Success,

		/// <summary>
		/// The requested resource does not exist.
		/// </summary>
		NotFound,

		/// <summary>
		/// The resource that should be created already exists.
		/// </summary>
		AlreadyExists,

		/// <summary>
		/// The configured credentials lack the permissions required for the request.
		/// </summary>
		PermissionDenied,

		/// <summary>
		/// The GitHub API rate limit was hit. The request can be retried later.
		/// </summary>
		RateLimited,

		/// <summary>
		/// The request contains invalid or missing data.
		/// </summary>
		InvalidRequest,

		/// <summary>
		/// The connector failed to handle the request.
		/// </summary>
		ConnectorError,

		/// <summary>
		/// The element runs a connector version that is not supported by this NuGet package.
		/// </summary>
		UnsupportedConnectorVersion,
	}

	/// <summary>
	/// Base class that hold default properties that every response has.
	/// </summary>
	public interface IGithubResponse : IGithubMessage
	{
		/// <summary>
		/// Indicates if the InterApp Call was successful or not
		/// </summary>
		bool Success { get; set; }

		/// <summary>
		/// A machine-readable classification of the outcome of the InterApp Call.
		/// </summary>
		GithubResponseStatus Status { get; set; }

		/// <summary>
		/// A human readable text representing the response of the InterApp Call.
		/// </summary>
		string Description { get; set; }

		/// <summary>
		/// The InterApp Message that triggered this response.
		/// </summary>
		IGithubRequest Request { get; set; }
	}
}
