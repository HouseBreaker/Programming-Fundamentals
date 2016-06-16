namespace _07.Matrix_Generator
{
	using System;
	using System.Linq;

	public static class MatrixGenerator
	{
		public static void Main(string[] args)
		{
			var tokens = Console.ReadLine().Split().ToArray();

			var type = tokens[0];
			var rows = int.Parse(tokens[1]);
			var cols = int.Parse(tokens[2]);

			var matrix = new int[rows, cols];
			switch (type)
			{
				case "A":
					matrix = GenerateMatrixTypeA(rows, cols);
					break;
				case "B":
					matrix = GenerateMatrixTypeB(rows, cols);
					break;
				case "C":
					matrix = GenerateMatrixTypeC(rows, cols);
					break;
				case "D":
					matrix = GenerateMatrixTypeD(rows, cols);
					break;
			}
			
			PrintMatrix(matrix);
		}

		private static void PrintMatrix(int[,] matrix)
		{
			var rows = matrix.GetLength(0);
			var cols = matrix.GetLength(1);

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					Console.Write(matrix[row, col] + " ");
				}

				Console.WriteLine();
			}
		}

		private static int[,] GenerateMatrixTypeA(int rows, int cols)
		{
			var matrix = new int[rows, cols];

			var counter = 0;
			for (int col = 0; col < cols; col++)
			{
				for (int row = 0; row < rows; row++)
				{
					matrix[row, col] = ++counter;
				}
			}

			return matrix;
		}

		private static int[,] GenerateMatrixTypeB(int rows, int cols)
		{
			var matrix = new int[rows, cols];

			var counter = 0;
			for (int col = 0; col < cols; col++)
			{
				if (col % 2 == 0)
				{
					for (int row = 0; row < rows; row++)
					{
						matrix[row, col] = ++counter;
					}
				}
				else
				{
					for (int row = rows - 1; row >= 0; row--)
					{
						matrix[row, col] = ++counter;
					}
				}
			}

			return matrix;
		}

		private static int[,] GenerateMatrixTypeC(int rows, int cols)
		{
			var matrix = new int[rows, cols];

			var counter = 1;

			matrix[rows - 1, 0] = counter;

			for (int row = rows - 2; row >= 0; row--)
			{
				var currentRow = row;
				var currentCol = 0;
				var hasFreeBottomIndex = currentRow < rows;
				var hasFreeRightIndex = currentCol < cols;

				while (hasFreeRightIndex && hasFreeBottomIndex)
				{
					matrix[currentRow++, currentCol++] = ++counter;

					hasFreeBottomIndex = currentRow < rows;
					hasFreeRightIndex = currentCol < cols;
				}
			}

			matrix[0, cols - 1] = (int)matrix.LongLength;
			for (int col = 1; col < cols - 1; col++)
			{
				var currentRow = 0;
				var currentCol = col;

				var hasFreeBottomIndex = currentRow < rows;
				var hasFreeRightIndex = currentCol < cols;

				while (hasFreeRightIndex && hasFreeBottomIndex)
				{
					matrix[currentRow++, currentCol++] = ++counter;

					hasFreeBottomIndex = currentRow < rows;
					hasFreeRightIndex = currentCol < cols;
				}
			}

			return matrix;
		}

		private static int[,] GenerateMatrixTypeD(int rows, int cols)
		{
			var matrix = new int[rows, cols];

			var counter = 1;
			matrix[0, 0] = counter;

			var row = 0;
			var col = 0;

			while (counter < matrix.LongLength)
			{
				Func<bool> downIsFree = () => row + 1 < rows && matrix[row + 1, col] == 0;
				Func<bool> rightIsFree = () => col + 1 < cols && matrix[row, col + 1] == 0;
				Func<bool> upIsFree = () => row - 1 >= 0 && matrix[row - 1, col] == 0;
				Func<bool> leftIsFree = () => col - 1 >= 0 && matrix[row, col - 1] == 0;

				while (downIsFree())
				{
					row++;
					matrix[row, col] = ++counter;
				}

				while (rightIsFree())
				{
					col++;
					matrix[row, col] = ++counter;
				}

				while (upIsFree())
				{
					row--;
					matrix[row, col] = ++counter;
				}

				while (leftIsFree())
				{
					col--;
					matrix[row, col] = ++counter;
				}
			}

			return matrix;
		}
	}
}