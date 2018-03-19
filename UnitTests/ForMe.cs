using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTests
{
	/// <summary>
	/// Summary description for ForMe
	/// </summary>
	[TestClass]
	public class ForMe
	{
		[TestMethod]
		public void ShiftLetters()
		{
			// shifting 2
			string abc = "abcdefghijklmnopqrstuvwxyz";
			string shifted = string.Empty;
			foreach(char c in abc.ToUpper())
			{
				char outChar = (char)(Convert.ToUInt16(c) + 2);
				shifted += outChar;
			}
			Assert.AreEqual("cdefghijklmnopqrstuvwxyzab", shifted);
		}
	}
}
