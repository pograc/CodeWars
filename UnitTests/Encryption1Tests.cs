using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace UnitTests
{
	[TestClass]
	public class Encryption1Tests
	{
		Encryption1Challenge ec1 = new Encryption1Challenge();

		#region Mine

		[TestMethod]
		public void EncryptionTests()
		{
			Assert.AreEqual("This is a test!", ec1.Encrypt("This is a test!", 0));
			Assert.AreEqual("hsi  etTi sats!", ec1.Encrypt("This is a test!", 1));
			Assert.AreEqual("s eT ashi tist!", ec1.Encrypt("This is a test!", 2));
			Assert.AreEqual(" Tah itse sits!", ec1.Encrypt("This is a test!", 3));
			Assert.AreEqual("This is a test!", ec1.Encrypt("This is a test!", 4));
			Assert.AreEqual("This is a test!", ec1.Encrypt("This is a test!", -1));
			Assert.AreEqual("hskt svr neetn!Ti aai eyitrsig", ec1.Encrypt("This kata is very interesting!", 1));
		}

		[TestMethod]
		public void DecryptionTests()
		{
			Assert.AreEqual("This is a test!", ec1.Decrypt("This is a test!", 0));
			Assert.AreEqual("This is a test!", ec1.Decrypt("hsi  etTi sats!", 1));
			Assert.AreEqual("This is a test!", ec1.Decrypt("s eT ashi tist!", 2));
			Assert.AreEqual("This is a test!", ec1.Decrypt(" Tah itse sits!", 3));
			Assert.AreEqual("This is a test!", ec1.Decrypt("This is a test!", 4));
			Assert.AreEqual("This is a test!", ec1.Decrypt("This is a test!", -1));
			Assert.AreEqual("This kata is very interesting!", ec1.Decrypt("hskt svr neetn!Ti aai eyitrsig", 1));
		}

		[TestMethod]
		public void EmptyTests()
		{
			Assert.AreEqual("", ec1.Encrypt("", 0));
			Assert.AreEqual("", ec1.Decrypt("", 0));
		}

		[TestMethod]
		public void NullTests()
		{
			Assert.AreEqual(null, ec1.Encrypt(null, 0));
			Assert.AreEqual(null, ec1.Decrypt(null, 0));
		}

		#endregion

		#region Best

		[TestMethod]
		public void EncryptionBestTests()
		{
			Assert.AreEqual("This is a test!", ec1.EncryptBest("This is a test!", 0));
			Assert.AreEqual("hsi  etTi sats!", ec1.EncryptBest("This is a test!", 1));
			Assert.AreEqual("s eT ashi tist!", ec1.EncryptBest("This is a test!", 2));
			Assert.AreEqual(" Tah itse sits!", ec1.EncryptBest("This is a test!", 3));
			Assert.AreEqual("This is a test!", ec1.EncryptBest("This is a test!", 4));
			Assert.AreEqual("This is a test!", ec1.EncryptBest("This is a test!", -1));
			Assert.AreEqual("hskt svr neetn!Ti aai eyitrsig", ec1.EncryptBest("This kata is very interesting!", 1));
		}

		[TestMethod]
		public void DecryptionBestTests()
		{
			Assert.AreEqual("This is a test!", ec1.DecryptBest("This is a test!", 0));
			Assert.AreEqual("This is a test!", ec1.DecryptBest("hsi  etTi sats!", 1));
			Assert.AreEqual("This is a test!", ec1.DecryptBest("s eT ashi tist!", 2));
			Assert.AreEqual("This is a test!", ec1.DecryptBest(" Tah itse sits!", 3));
			Assert.AreEqual("This is a test!", ec1.DecryptBest("This is a test!", 4));
			Assert.AreEqual("This is a test!", ec1.DecryptBest("This is a test!", -1));
			Assert.AreEqual("This kata is very interesting!", ec1.DecryptBest("hskt svr neetn!Ti aai eyitrsig", 1));
		}

		[TestMethod]
		public void EmptyBestTests()
		{
			Assert.AreEqual("", ec1.EncryptBest("", 0));
			Assert.AreEqual("", ec1.DecryptBest("", 0));
		}

		[TestMethod]
		public void NullBestTests()
		{
			Assert.AreEqual(null, ec1.EncryptBest(null, 0));
			Assert.AreEqual(null, ec1.DecryptBest(null, 0));
		}

		#endregion
	}
}
