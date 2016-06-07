namespace _05.Max_Platform_3_x_3
{
	using System;
	using System.Linq;

	public static class MaxPlatform
	{
		public static void Main(string[] args)
		{
			var arr = ReadMatrixFromConsole();

			var rows = arr.GetLength(0);
			var cols = arr.GetLength(1);
			
			var largestSumArray = new long[3, 3];
			for (int row = rows - 3; row >= 0; row--)
			{
				for (int col = cols - 3; col >= 0; col--)
				{
					var currentArray = Get3X3Square(row, col, arr);
					if (GetSum(currentArray) >= GetSum(largestSumArray))
					{
						largestSumArray = currentArray;
					}
				}
			}

			Console.WriteLine(GetSum(largestSumArray));

			for (int row = 0; row < 3; row++)
			{
				for (int col = 0; col < 3; col++)
				{
					var currentNum = largestSumArray[row, col];
					Console.Write(currentNum + " ");
				}

				Console.WriteLine();
			}
		}

		private static long GetSum(long[,] arr)
		{
			var sum = arr.Cast<long>().Sum();

			//for (var row = 0; row < arr.GetLength(0); row++)
			//{
			//	for (var col = 0; col < arr.GetLength(1); col++)
			//	{
			//		sum += arr[row, col];
			//	}
			//}

			return sum;
		}

		private static long[,] Get3X3Square(int startingRow, int startingCol, long[,] arr)
		{
			var currentArray = new long[3, 3];

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					currentArray[i, j] = arr[startingRow + i, startingCol + j];
				}
			}

			return currentArray;
		}

		private static long[,] ReadMatrixFromConsole()
		{
			var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var rows = matrixSize[0];
			var cols = matrixSize[1];

			var arr = new long[rows, cols];

			for (int row = 0; row < rows; row++)
			{
				var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
				for (int col = 0; col < cols; col++)
				{
					arr[row, col] = currentRow[col];
				}
			}

			return arr;
		}
	}
}