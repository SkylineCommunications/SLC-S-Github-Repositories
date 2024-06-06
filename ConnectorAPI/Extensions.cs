// Ignore Spelling: Github

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Linq;
	using System.Reflection;
	using System.Text;
	using System.Threading.Tasks;

	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.Attributes;
	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories;

	/// <summary>
	/// Provides extension methods for various types.
	/// </summary>
	public static class Extensions
	{
		/// <summary>
		/// Return the string representation for a given topic.
		/// </summary>
		/// <param name="topic">The repository topic.</param>
		/// <returns>The topic's string representation.</returns>
		public static string TopicString(this RepositoryTopic topic)
		{
			var description = FriendlyDescription(topic);
			return description;
		}

		/// <summary>
		/// Return the initials for a given repository type.
		/// <para>For Example:</para>
		/// <see cref="RepositoryType.Automation_Script"/>'s initials are 'AS'.
		/// </summary>
		/// <param name="type">The repository type.</param>
		/// <returns>The initials.</returns>
		public static string GetTypesInitials(this RepositoryType type)
		{
			var description = ShortDescription(type);
			return description;
		}

		/// <summary>
		/// Returns a human-readable description for the given type.
		/// </summary>
		/// <param name="type">The repository type.</param>
		/// <returns>A string representing the human-readable description of repository type.</returns>
		public static string GetTypesFriendlyDescription(this RepositoryType type)
		{
			var description = FriendlyDescription(type);
			return description;
		}

		internal static string FriendlyDescription<T>(this T requestType) where T : Enum
		{
			var name = requestType.ToString();
			FieldInfo field = typeof(T).GetField(name);
			object[] attribs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
			if (attribs.Length > 0)
			{
				return ((DescriptionAttribute)attribs[0]).Description;
			}

			return name;
		}

		internal static string ShortDescription<T>(this T requestType) where T : Enum
		{
			var name = requestType.ToString();
			FieldInfo field = typeof(T).GetField(name);
			object[] attribs = field.GetCustomAttributes(typeof(ShortDescriptionAttribute), false);
			if (attribs.Length > 0)
			{
				return ((ShortDescriptionAttribute)attribs[0]).Description;
			}

			return name;
		}
	}
}
