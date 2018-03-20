using System;
using CodeWars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class BuildTowerTests
	{
		BuildTower bt = new BuildTower();

		[TestMethod]
		public void BasicBuildTowerTests()
		{
			Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", bt.TowerBuilder(1)));
			Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", bt.TowerBuilder(2)));
			Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", bt.TowerBuilder(3)));
		}
	}
}
