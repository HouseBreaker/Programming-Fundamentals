using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Largest_Frame_In_Matrix
{
	class LargestFrameInMatrix
	{
		public static void Main(string[] args)
		{
			var matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var rows = matrixDimensions[0];
			var cols = matrixDimensions[1];
			var matrix = new int[rows, cols];
			FillInMatrix(matrix, rows, cols);

			// generate frames (top, left), (bottom, right): 0 <= left <= right <= cols && 0 <= top <= bottom <= rows
			var equalSizedFrames = new List<string>(); // equal sized frames of max size
			var maxSizeFrame = rows * cols; // max size == size matrix
			var foundFrame = false;
			while (!foundFrame)
			{
				for (var top = 0; top < rows; top++)
					for (var left = 0; left < cols; left++)
						for (var bottom = rows - 1; bottom >= top; bottom--)
							for (var right = cols - 1; right >= left; right--)
							{
								var isMaxSize = IsRequiredSize(top, left, bottom, right, maxSizeFrame);
								var hasEqualCells = isEqualCellsFrame(top, left, bottom, right, matrix);
								if (hasEqualCells && isMaxSize)
								{
									foundFrame = true;
									AddCurrentFrameToList(top, left, bottom, right, equalSizedFrames);
								}
							}

				if (!foundFrame) maxSizeFrame--;
				else break;
			}

			PrintInAscendingOrder(equalSizedFrames);
		}

		public static void FillInMatrix(int[,] matrix, int rows, int cols)
		{
			for (var row = 0; row < rows; row++)
			{
				var cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				for (var col = 0; col < cols; col++)
					matrix[row, col] = cells[col];
			}
		}

		public static bool IsRequiredSize(int top, int left, int bottom, int right, int size)
		{
			var verticalLength = bottom - top + 1;
			var horizontalLength = right - left + 1;
			var areaFrame = horizontalLength * verticalLength;
			return areaFrame == size;
		}

		public static void AddCurrentFrameToList(int top, int left, int bottom, int right, List<string> equalSizedFrames)
		{
			var verticalLength = bottom - top + 1;
			var horizontalLength = right - left + 1;
			equalSizedFrames.Add(string.Join("x", verticalLength, horizontalLength));
		}

		public static bool isEqualCellsFrame(int top, int left, int bottom, int right, int[,] matrix)
		{
			var cell = matrix[top, left];
			for (var col = left; col <= right; col++)
				if (matrix[top, col] != cell || matrix[bottom, col] != cell)
					return false;
			for (var row = top; row <= bottom; row++)
				if (matrix[row, left] != cell || matrix[row, right] != cell)
					return false;
			return true;
		}

		public static void PrintInAscendingOrder(List<string> list)
		{
			list.Sort();
			Console.Write(string.Join(", ", list));
		}
	}
}
