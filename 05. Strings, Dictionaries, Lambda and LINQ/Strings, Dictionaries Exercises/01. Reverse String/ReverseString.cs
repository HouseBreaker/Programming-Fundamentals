namespace _01.Reverse_String
{
	using System;
	using System.Linq;

	public static class ReverseString
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine();
			Console.WriteLine(new string(input.Reverse().ToArray()));
		}
	}
}