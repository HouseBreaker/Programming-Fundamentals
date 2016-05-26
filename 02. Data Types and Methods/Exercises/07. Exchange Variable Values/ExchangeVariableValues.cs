namespace _07.Exchange_Variable_Values
{
	using System;

	public static class ExchangeVariableValues
	{
		public static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());

			Console.WriteLine("Before:");
			Console.WriteLine($"a = {a}");
			Console.WriteLine($"b = {b}");

			a ^= b;
			b ^= a;
			a ^= b;

			Console.WriteLine("After:");
			Console.WriteLine($"a = {a}");
			Console.WriteLine($"b = {b}");
		}
	}
}
