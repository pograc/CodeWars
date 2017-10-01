using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Select program:");
			string input = Console.ReadLine();

			switch (input.ToLower())
			{
				case ("exit"):
					break;

				case ("datareverse"):
					DataReverse();
					break;

				case ("encryption1"):
					Encryption1();
					break;

				default:
					Console.WriteLine("Program not found");
					break;
			}

			Console.Write("Press any button to close");
			Console.ReadLine();
		}

		private static void DataReverse()
		{
			DataReverseChallenge c = new DataReverseChallenge();

			while (true)
			{
				try
				{
					Console.WriteLine("Specify input list of integers. The list needs to be a multiple of 8 and separated with commas. Exit will quit program.");
					string input = Console.ReadLine();
					if (string.Equals("exit", input.ToLower()))
						break;
					string[] inputSplit = Console.ReadLine().Split(',');
					if (inputSplit.Length % 8 != 0)
						throw new Exception("Legth of input must be a multiple of 8.");
					int[] data = Array.ConvertAll<string, int>(inputSplit, int.Parse);
					c.DataReverse(data);
				}
				catch (Exception ex)
				{
					Console.WriteLine(string.Format("There was an error: {0}", ex.ToString()));
					Console.WriteLine("Please try again.");
				}
			}
		}

		private static void Encryption1()
		{
			Encryption1Challenge ec = new Encryption1Challenge();

			while (true)
			{
				try
				{
					Console.WriteLine("Encrypt/Decrypt; String to use; How many times to go through. Exit will quit program.");
					string input = Console.ReadLine();
					if (string.Equals("exit", input.ToLower()))
						break;
					string[] inputSplit = input.Split(';');

					if (inputSplit.Count() != 3)
						throw new Exception("Expecting three parameters separated by ';'.");
					if (!int.TryParse(inputSplit[2], out int n))
						throw new Exception("Third parameter needs to be an int.");
					if (string.Equals("encrypt", inputSplit[0].ToLower()))
						ec.Encrypt(inputSplit[1], n);
					else if (string.Equals("decrypt", inputSplit[0].ToLower()))
						ec.Decrypt(inputSplit[1], n);
					else
						throw new Exception("First parameter needs to be either encrypt or decrypt.");
				}
				catch (Exception ex)
				{
					Console.WriteLine(string.Format("There was an error: {0}", ex.ToString()));
					Console.WriteLine("Please try again.");
				}
			}
		}
	}
}
