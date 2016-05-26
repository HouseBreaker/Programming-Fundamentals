namespace _04.Variable_in_Hex_Format
{
	using System;

	public static class VariableInHex
	{
		public static void Main(string[] args)
		{
			var hex = Console.ReadLine();
			var dec = Convert.ToInt32(hex, 16);

			Console.WriteLine(dec);
		}
	}
}
