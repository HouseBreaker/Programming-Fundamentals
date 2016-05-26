namespace _14.Integer_to_Hex_and_Binary
{
	using System;

	public static class IntegerToHexAndBinary
	{
		public static void Main(string[] args)
		{
			var input = int.Parse(Console.ReadLine());

			Console.WriteLine(input.ToString("X"));
			Console.WriteLine(Convert.ToString(input, 2));
		}
	}
}