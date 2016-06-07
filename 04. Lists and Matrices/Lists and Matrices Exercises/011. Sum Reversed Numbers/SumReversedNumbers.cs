namespace _011.Sum_Reversed_Numbers
{
	using System;
	using System.Linq;

	public static class SumReversedNumbers
	{
		public static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split().Select(a => int.Parse(new string(a.Reverse().ToArray())));

			Console.WriteLine(numbers.Sum());
		}
	}
}