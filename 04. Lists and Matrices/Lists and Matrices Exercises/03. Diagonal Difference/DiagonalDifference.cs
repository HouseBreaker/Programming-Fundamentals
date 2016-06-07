namespace _03.Diagonal_Difference
{
	using System;
	using System.Linq;

	public static class DiagonalDifference
	{
		public static void Main(string[] args)
		{
			var arr = ReadSquareMatrixFromConsole();
			var rows = arr.GetLength(0);

			var leftDiagonalSum = 0;
			for (int row = 0; row < rows; row++)
			{
				leftDiagonalSum += arr[row, row];
			}

			var rightDiagonalSum = 0;
			for (int row = rows - 1; row >= 0; row--)
			{
				var currentNum = arr[row, rows - 1 - row];
				rightDiagonalSum += currentNum;
			}

			Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));
		}

		private static int[,] ReadSquareMatrixFromConsole()
		{
			var matrixSize = int.Parse(Console.ReadLine());

			var rows = matrixSize;
			var cols = matrixSize;

			var arr = new int[rows, cols];

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
