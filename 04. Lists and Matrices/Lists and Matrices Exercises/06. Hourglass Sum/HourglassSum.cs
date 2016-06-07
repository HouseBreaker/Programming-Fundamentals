namespace _06.Hourglass_Sum
{
	using System;
	using System.Linq;

	public static class HourglassSum
	{
		public static void Main(string[] args)
		{
			var arr = ReadMatrixFromConsole();
			var rows = arr.GetLength(0);
			var cols = arr.GetLength(1);

			var largestHourglassSum = long.MinValue;
			for (int row = 0; row < rows - 2; row++)
			{
				for (int col = 0; col < cols - 2; col++)
				{
					var currentSum = GetHourglassSum(arr, row, col);

					if (currentSum >= largestHourglassSum)
					{
						largestHourglassSum = currentSum;
					}
				}
			}

			Console.WriteLine(largestHourglassSum);
		}

		private static long GetHourglassSum(long[,] arr, int startRow, int startCol)
		{
			var sum = 0L;

			for (int i = 0; i < 3; i += 2)
			{
				for (int j = 0; j < 3; j++)
				{
					sum += arr[startRow + i, startCol + j];
				}
			}

			sum += arr[startRow + 1, startCol + 1];

			return sum;
		}

		private static long[,] ReadMatrixFromConsole()
		{
			const int Rows = 6;
			const int Cols = 6;

			var arr = new long[Rows, Cols];

			for (int row = 0; row < Rows; row++)
			{
				var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
				for (int col = 0; col < Cols; col++)
				{
					arr[row, col] = currentRow[col];
				}
			}

			return arr;
		}
	}
}
