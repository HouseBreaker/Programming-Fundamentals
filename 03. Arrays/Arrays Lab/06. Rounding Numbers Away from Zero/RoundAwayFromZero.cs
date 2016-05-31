namespace _06.Rounding_Numbers_Away_from_Zero
{
	using System;
	using System.Linq;

	public static class RoundAwayFromZero
	{
		public static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

			foreach (var num in arr)
			{
				var rounded = Math.Round(num, MidpointRounding.AwayFromZero);
				Console.WriteLine($"{num} => {rounded}");
			}
		}
	}
}