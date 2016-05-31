namespace _05.Triple_Sum
{
	using System;
	using System.Linq;

	public static class TripleSum
	{
		public static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var containsPairs = false;
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					var a = arr[i];
					var b = arr[j];

					var sum = a + b;

					if (arr.Contains(sum))
					{
						containsPairs = true;
						Console.WriteLine($"{a} + {b} == {sum}");
					}
				}
			}

			if (!containsPairs)
			{
				Console.WriteLine("No");
			}
		}
	}
}