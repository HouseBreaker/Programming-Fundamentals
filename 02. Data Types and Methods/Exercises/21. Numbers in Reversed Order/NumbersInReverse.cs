namespace _21.Numbers_in_Reversed_Order
{
	using System;
	using System.Linq;

	public static class NumbersInReverse
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(new string(Console.ReadLine().Reverse().ToArray()));
		}
	}
}