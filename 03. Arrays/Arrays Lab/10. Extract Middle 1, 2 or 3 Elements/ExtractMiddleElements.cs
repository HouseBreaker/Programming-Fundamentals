namespace _10.Extract_Middle_1__2_or_3_Elements
{
	using System;
	using System.Linq;

	public static class ExtractMiddleElements
	{
		public static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

			if (arr.Length == 1)
			{
				Console.WriteLine(arr[0]);
			}
			else
			{
				var arrayIsEven = arr.Length % 2 == 0;

				var middle = arr.Skip(arr.Length / 2 - 1);
				var taken = arrayIsEven ? middle.Take(2) : middle.Take(3);

				Console.WriteLine(string.Join(" ", taken));
			}
		}
	}
}