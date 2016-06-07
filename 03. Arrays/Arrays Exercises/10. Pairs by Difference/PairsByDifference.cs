namespace _10.Pairs_by_Difference
{
	using System;
	using System.Linq;

	public static class PairsByDifference
	{
		public static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var difference = int.Parse(Console.ReadLine());

			var pairsWithDifference = 0;
			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					var current = arr[i];
					var next = arr[j];
					var currentDifference = Math.Abs(current - next);

					if (currentDifference == difference)
					{
						pairsWithDifference++;
					}
				}
			}

			Console.WriteLine(pairsWithDifference);
		}
	}
}
