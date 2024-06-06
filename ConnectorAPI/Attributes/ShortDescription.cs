// Ignore Spelling: Github

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.Attributes
{
	using System;

	[AttributeUsage(AttributeTargets.Field)]
	internal class ShortDescriptionAttribute : Attribute
	{
		public ShortDescriptionAttribute()
		{
			Description = String.Empty;
		}

		public ShortDescriptionAttribute(string description)
		{
			Description = description;
		}

		public string Description { get; }
	}
}
