namespace _02.Rotate_and_Sum
{
	using System;
	using System.Linq;

	public static class RotateAndSum
	{
		public static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var numOfRotations = int.Parse(Console.ReadLine());

			var sum = new int[arr.Length];
			for (int i = 0; i < numOfRotations; i++)
			{
				RotateRight(arr);

				for (int j = 0; j < sum.Length; j++)
				{
					sum[j] += arr[j];
				}
			}

			Console.WriteLine(string.Join(" ", sum));
		}

		private static void RotateRight(int[] source)
		{
			var first = source.Last();
			Array.Copy(source, 0, source, 1, source.Length - 1);
			source[0] = first;
		}
	}
}