namespace _04._2x2_Squares_in_Matrix
{
	using System;
	using System.Linq;

	public static class SquaresInMatrix
	{
		public static void Main(string[] args)
		{
			var arr = ReadMatrixFromConsole();
			var rows = arr.GetLength(0);
			var cols = arr.GetLength(1);

			var numberOfSquares = 0;
			for (int row = 0; row < rows - 1; row++)
			{
				for (int col = 0; col < cols - 1; col++)
				{
					var currentChar = arr[row, col];

					var rightIsTheSame = arr[row + 1, col] == currentChar;
					var bottomIsTheSame = arr[row, col + 1] == currentChar;
					var diagonalIsTheSame = arr[row + 1, col + 1] == currentChar;

					var isEqualSquare = rightIsTheSame && bottomIsTheSame && diagonalIsTheSame;

					if (isEqualSquare)
					{
						numberOfSquares++;
					}
				}
			}

			Console.WriteLine(numberOfSquares);
		}

		private static char[,] ReadMatrixFromConsole()
		{
			var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var rows = matrixSize[0];
			var cols = matrixSize[1];

			var arr = new char[rows, cols];

			for (int row = 0; row < rows; row++)
			{
				var currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();
				for (int col = 0; col < cols; col++)
				{
					arr[row, col] = currentRow[col];
				}
			}

			return arr;
		}
	}
}