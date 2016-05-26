namespace _16.Print_Part_of_ASCII_table
{
	using System;
	using System.Linq;

	public static class PrintAscii
	{
		public static void Main(string[] args)
		{
			var lowerLimit = int.Parse(Console.ReadLine());
			var upperLimit = int.Parse(Console.ReadLine());

			// for fun, one line:
			// Console.WriteLine(string.Join(" ", Enumerable.Range(lowerLimit, upperLimit - lowerLimit + 1).Select(a => (char)a)));
			for (int ch = lowerLimit; ch <= upperLimit; ch++)
			{
				Console.Write((char)ch + " ");
			}
		}
	}
}