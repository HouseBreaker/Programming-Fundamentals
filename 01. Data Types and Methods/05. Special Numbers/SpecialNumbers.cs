namespace _05.Special_Numbers
{
	using System;
	using System.Linq;

	public static class SpecialNumbers
	{
		public static void Main()
		{
			var count = int.Parse(Console.ReadLine());

			var range = Enumerable.Range(1, count);

			foreach (var num in range)
			{
				var numbers = num.ToString().ToArray().Select(a => int.Parse(a.ToString())).ToArray();

				var sum = numbers.Sum();

				var special = sum == 5 || sum == 7 || sum == 11;

				Console.WriteLine($"{num} -> {special}");
			}
		}
	}
}