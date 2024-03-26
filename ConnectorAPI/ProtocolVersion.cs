namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Threading.Tasks;

	public class ProtocolVersion
	{
		private readonly string[] versioning = new string[5];
		private const string Pattern = @"^(?<branch>\d+).(?<fw>\d+).(?<major>\d+).(?<seq>\d+)(?<suffix>.*)$";

		public ProtocolVersion(string version)
		{
			var match = Regex.Match(version, Pattern);
			if (!match.Success)
			{
				throw new ArgumentException($"Can't parse protocol version {version}");
			}

			versioning[0] = match.Groups["branch"].Value;
			versioning[1] = match.Groups["fw"].Value;
			versioning[2] = match.Groups["major"].Value;
			versioning[3] = match.Groups["seq"].Value;
			versioning[4] = match.Groups["suffix"].Value;
		}

		/// <summary>
		/// Gets the branch of the version ([Branch].[FW].[Major].[Seq][Suffix]).
		/// </summary>
		public int Branch
		{
			get
			{
				return Convert.ToInt32(versioning[0]);
			}
		}

		/// <summary>
		/// Gets the firmware of the version ([Branch].[FW].[Major].[Seq][Suffix]).
		/// </summary>
		public int FW
		{
			get
			{
				return Convert.ToInt32(versioning[1]);
			}
		}

		/// <summary>
		/// Gets the major of the version ([Branch].[FW].[Major].[Seq][Suffix]).
		/// </summary>
		public int Major
		{
			get
			{
				return Convert.ToInt32(versioning[2]);
			}
		}

		/// <summary>
		/// Gets the sequence of the version ([Branch].[FW].[Major].[Seq][Suffix]).
		/// </summary>
		public int Seq
		{
			get
			{
				return Convert.ToInt32(versioning[3]);
			}
		}

		/// <summary>
		/// Gets the Suffix of the version ([Branch].[FW].[Major].[Seq][Suffix]).
		/// </summary>
		public string Suffix
		{
			get
			{
				return versioning[4];
			}
		}
	}
}
