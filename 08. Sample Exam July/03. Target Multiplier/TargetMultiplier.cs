namespace _03.Target_Multiplier
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class TargetMultiplier
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var rows = input[0];
			var cols = input[1];

			var arr = new int[rows, cols];

			for (int row = 0; row < rows; row++)
			{
				var column = Console.ReadLine().Split().Select(int.Parse).ToArray();
				for (int col = 0; col < cols; col++)
				{
					arr[row, col] = column[col];
				}
			}

			var target = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var targetRow = target[0];
			var targetCol = target[1];

			var initialNumber = arr[targetRow, targetCol];
			var sumOfNeighbors = 0;

			for (int row = targetRow - 1; row < targetRow + 2; row += 2)
			{
				for (int col = targetCol - 1; col < targetCol + 2; col++)
				{
					sumOfNeighbors += arr[row, col];
					arr[row, col] *= initialNumber;
				}
			}

			sumOfNeighbors += arr[targetRow, targetCol - 1];
			arr[targetRow, targetCol - 1] *= initialNumber;

			sumOfNeighbors += arr[targetRow, targetCol + 1];
			arr[targetRow, targetCol + 1] *= initialNumber;

			arr[targetRow, targetCol] = sumOfNeighbors * initialNumber;

			PrintMatrix(arr);
		}

		private static void PrintMatrix(int[,] arr)
		{
			var rows = arr.GetLength(0);
			var cols = arr.GetLength(1);
			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					Console.Write(arr[row, col] + " ");
				}

				Console.WriteLine();
			}
		}
	}
}