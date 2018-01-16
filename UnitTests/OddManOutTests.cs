using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace UnitTests
{
	/// <summary>
	/// Summary description for OddManOutTests
	/// </summary>
	[TestClass]
	public class OddManOutTests
	{
		OddManOutChallenge omo = new OddManOutChallenge();

		[TestMethod]
		public void OmoTest1()
		{
			int[] exampleTest1 = { 2, 6, 8, -10, 3 };
			Assert.AreEqual(3, omo.OddManOut(exampleTest1));
			Assert.AreEqual(3, omo.OddManOutBest(exampleTest1));
			Assert.AreEqual(3, omo.OddManOutBest2(exampleTest1));
		}

		[TestMethod]
		public void OmoTest2()
		{
			int[] exampleTest2 = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
			Assert.AreEqual(206847684, omo.OddManOut(exampleTest2));
			Assert.AreEqual(206847684, omo.OddManOutBest(exampleTest2));
			Assert.AreEqual(206847684, omo.OddManOutBest2(exampleTest2));
		}

		[TestMethod]
		public void OmoTest3()
		{
			int[] exampleTest3 = { int.MaxValue, 0, 1 };
			Assert.AreEqual(0, omo.OddManOut(exampleTest3));
			Assert.AreEqual(0, omo.OddManOutBest(exampleTest3));
			Assert.AreEqual(0, omo.OddManOutBest2(exampleTest3));
		}

		[TestMethod]
		public void OmoTest4()
		{
			int[] exampleTest4 = { 2, 4, 0, 100, 4, 11, 2602, 36 };
			Assert.AreEqual(11, omo.OddManOut(exampleTest4));
			Assert.AreEqual(11, omo.OddManOutBest(exampleTest4));
			Assert.AreEqual(11, omo.OddManOutBest2(exampleTest4));
		}

		[TestMethod]
		public void OmoTest5()
		{
			int[] exampleTest5 = { 160, 3, 1719, 19, 11, 13, -21 };
			Assert.AreEqual(160, omo.OddManOut(exampleTest5));
			Assert.AreEqual(160, omo.OddManOutBest(exampleTest5));
			Assert.AreEqual(160, omo.OddManOutBest2(exampleTest5));
		}
	}
}
