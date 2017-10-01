using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace UnitTests
{
	[TestClass]
	public class DataReverseTests
	{
		[TestMethod]
		public void DataReverse1()
		{
			DataReverseChallenge c = new DataReverseChallenge();

			int[] data1 = new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };
			int[] data2 = new int[32] { 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
			int[] returned = c.DataReverse(data1);
			Assert.AreEqual(data2[0], returned[0]);
			Assert.AreEqual(data2[1], returned[1]);
			Assert.AreEqual(data2[2], returned[2]);
			Assert.AreEqual(data2[3], returned[3]);
			Assert.AreEqual(data2[4], returned[4]);
			Assert.AreEqual(data2[5], returned[5]);
			Assert.AreEqual(data2[6], returned[6]);
			Assert.AreEqual(data2[7], returned[7]);
			Assert.AreEqual(data2[8], returned[8]);
			Assert.AreEqual(data2[9], returned[9]);
			Assert.AreEqual(data2[10], returned[10]);
			Assert.AreEqual(data2[11], returned[11]);
			Assert.AreEqual(data2[12], returned[12]);
			Assert.AreEqual(data2[13], returned[13]);
			Assert.AreEqual(data2[14], returned[14]);
			Assert.AreEqual(data2[15], returned[15]);
			Assert.AreEqual(data2[16], returned[16]);
			Assert.AreEqual(data2[17], returned[17]);
			Assert.AreEqual(data2[18], returned[18]);
			Assert.AreEqual(data2[19], returned[19]);
			Assert.AreEqual(data2[20], returned[20]);
			Assert.AreEqual(data2[21], returned[21]);
			Assert.AreEqual(data2[22], returned[22]);
			Assert.AreEqual(data2[23], returned[23]);
			Assert.AreEqual(data2[24], returned[24]);
			Assert.AreEqual(data2[25], returned[25]);
			Assert.AreEqual(data2[26], returned[26]);
			Assert.AreEqual(data2[27], returned[27]);
			Assert.AreEqual(data2[28], returned[28]);
			Assert.AreEqual(data2[29], returned[29]);
			Assert.AreEqual(data2[30], returned[30]);
			Assert.AreEqual(data2[31], returned[31]);
		}

		[TestMethod]
		public void DataReverse2()
		{
			DataReverseChallenge c = new DataReverseChallenge();

			int[] data1 = new int[16] { 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1 };
			int[] data2 = new int[16] { 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0 };
			int[] returned = c.DataReverse(data1);
			Assert.AreEqual(data2[0], returned[0]);
			Assert.AreEqual(data2[1], returned[1]);
			Assert.AreEqual(data2[2], returned[2]);
			Assert.AreEqual(data2[3], returned[3]);
			Assert.AreEqual(data2[4], returned[4]);
			Assert.AreEqual(data2[5], returned[5]);
			Assert.AreEqual(data2[6], returned[6]);
			Assert.AreEqual(data2[7], returned[7]);
			Assert.AreEqual(data2[8], returned[8]);
			Assert.AreEqual(data2[9], returned[9]);
			Assert.AreEqual(data2[10], returned[10]);
			Assert.AreEqual(data2[11], returned[11]);
			Assert.AreEqual(data2[12], returned[12]);
			Assert.AreEqual(data2[13], returned[13]);
			Assert.AreEqual(data2[14], returned[14]);
			Assert.AreEqual(data2[15], returned[15]);
		}

		[TestMethod]
		public void DataReverseBest1()
		{
			DataReverseChallenge c = new DataReverseChallenge();

			int[] data1 = new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };
			int[] data2 = new int[32] { 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
			int[] returned = c.DataReverseBest(data1);

			Assert.AreEqual(data2[0], returned[0]);
			Assert.AreEqual(data2[1], returned[1]);
			Assert.AreEqual(data2[2], returned[2]);
			Assert.AreEqual(data2[3], returned[3]);
			Assert.AreEqual(data2[4], returned[4]);
			Assert.AreEqual(data2[5], returned[5]);
			Assert.AreEqual(data2[6], returned[6]);
			Assert.AreEqual(data2[7], returned[7]);
			Assert.AreEqual(data2[8], returned[8]);
			Assert.AreEqual(data2[9], returned[9]);
			Assert.AreEqual(data2[10], returned[10]);
			Assert.AreEqual(data2[11], returned[11]);
			Assert.AreEqual(data2[12], returned[12]);
			Assert.AreEqual(data2[13], returned[13]);
			Assert.AreEqual(data2[14], returned[14]);
			Assert.AreEqual(data2[15], returned[15]);
			Assert.AreEqual(data2[16], returned[16]);
			Assert.AreEqual(data2[17], returned[17]);
			Assert.AreEqual(data2[18], returned[18]);
			Assert.AreEqual(data2[19], returned[19]);
			Assert.AreEqual(data2[20], returned[20]);
			Assert.AreEqual(data2[21], returned[21]);
			Assert.AreEqual(data2[22], returned[22]);
			Assert.AreEqual(data2[23], returned[23]);
			Assert.AreEqual(data2[24], returned[24]);
			Assert.AreEqual(data2[25], returned[25]);
			Assert.AreEqual(data2[26], returned[26]);
			Assert.AreEqual(data2[27], returned[27]);
			Assert.AreEqual(data2[28], returned[28]);
			Assert.AreEqual(data2[29], returned[29]);
			Assert.AreEqual(data2[30], returned[30]);
			Assert.AreEqual(data2[31], returned[31]);
		}

		[TestMethod]
		public void DataReverseBest2()
		{
			DataReverseChallenge c = new DataReverseChallenge();

			int[] data1 = new int[16] { 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1 };
			int[] data2 = new int[16] { 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0 };
			int[] returned = c.DataReverseBest(data1);

			Assert.AreEqual(data2[0], returned[0]);
			Assert.AreEqual(data2[1], returned[1]);
			Assert.AreEqual(data2[2], returned[2]);
			Assert.AreEqual(data2[3], returned[3]);
			Assert.AreEqual(data2[4], returned[4]);
			Assert.AreEqual(data2[5], returned[5]);
			Assert.AreEqual(data2[6], returned[6]);
			Assert.AreEqual(data2[7], returned[7]);
			Assert.AreEqual(data2[8], returned[8]);
			Assert.AreEqual(data2[9], returned[9]);
			Assert.AreEqual(data2[10], returned[10]);
			Assert.AreEqual(data2[11], returned[11]);
			Assert.AreEqual(data2[12], returned[12]);
			Assert.AreEqual(data2[13], returned[13]);
			Assert.AreEqual(data2[14], returned[14]);
			Assert.AreEqual(data2[15], returned[15]);
		}
	}
}
