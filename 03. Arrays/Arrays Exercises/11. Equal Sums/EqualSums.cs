namespace _11.Equal_Sums
{
	using System;
	using System.Linq;

	public static class EqualSums
	{
		public static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var equalSumIndex = -1;
			for (int i = 0; i < arr.Length; i++)
			{
				var leftSum = 0;
				if (i != 0)
				{
					for (int j = i - 1; j >= 0; j--)
					{
						leftSum += arr[j];
					}
				}

				var rightSum = 0;
				if (i != arr.Length)
				{
					for (int j = i + 1; j < arr.Length; j++)
					{
						rightSum += arr[j];
					}
				}

				if (leftSum == rightSum)
				{
					equalSumIndex = i;
					break;
				}
			}

			if (equalSumIndex != -1)
			{
				Console.WriteLine(equalSumIndex);
			}
			else
			{
				Console.WriteLine("no");
			}
		}
	}
}