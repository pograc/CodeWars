using System;
using CodeWars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class PlayPassTests
	{
		PlayPass pp = new PlayPass();

		[TestMethod]
		public void PlayPass1()
		{
			string actual = pp.playPass("I LOVE YOU!!!", 1);
			Assert.AreEqual("!!!vPz fWpM J", actual);
		}

		[TestMethod]
		public void PlayPass2()
		{
			string actual = pp.playPass("MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015", 2);
			Assert.AreEqual("4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO", actual);
		}

		[TestMethod]
		public void PlayPassBest1()
		{
			string actual = pp.playPassBest("I LOVE YOU!!!", 1);
			Assert.AreEqual("!!!vPz fWpM J", actual);
		}

		[TestMethod]
		public void PlayPassBest2()
		{
			string actual = pp.playPassBest("MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015", 2);
			Assert.AreEqual("4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO", actual);
		}
	}
}
