namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.Tests
{
	using System;

	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class ProtocolVersionTests
	{
		[TestMethod]
		public void Parses_AllParts()
		{
			var version = new ProtocolVersion("1.2.3.4_B5");

			Assert.AreEqual(1, version.Branch);
			Assert.AreEqual(2, version.FW);
			Assert.AreEqual(3, version.Major);
			Assert.AreEqual(4, version.Seq);
			Assert.AreEqual("_B5", version.Suffix);
		}

		[TestMethod]
		[DataRow("")]
		[DataRow("1.0.0")]
		[DataRow("abc")]
		[DataRow("1x0y0z9")]
		public void Throws_OnInvalidVersion(string version)
		{
			Assert.ThrowsExactly<ArgumentException>(() => new ProtocolVersion(version));
		}

		[TestMethod]
		[DataRow("0.0.0.9", false)]
		[DataRow("0.1.0.0", false)]
		[DataRow("1.0.0.8", false)]
		[DataRow("1.0.0.9", true)]
		[DataRow("1.0.1.0", true)]
		[DataRow("2.0.0.0", true)]
		public void CheckVersion_ComparesInOrder(string version, bool expected)
		{
			var result = GithubRepositories.CheckVersion(new ProtocolVersion(version), out var description);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(expected, description.Length == 0);
		}
	}
}
