namespace _01.Largest_Common_End
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class LargestCommonEnd
	{
		public static void Main(string[] args)
		{
			var arr1 = Console.ReadLine().Split();
			var arr2 = Console.ReadLine().Split();

			var shorterArrayLength = Math.Min(arr1.Length, arr2.Length);

			var leftArr1 = arr1.Take(shorterArrayLength).ToArray();
			var leftArr2 = arr2.Take(shorterArrayLength).ToArray();
			var longerLeft = new List<string>();

			for (int i = 0; i < shorterArrayLength; i++)
			{
				if (leftArr1[i] == leftArr2[i])
				{
					longerLeft.Add(arr1[i]);
				}
			}

			var rightArr1 = arr1.Reverse().Take(shorterArrayLength).ToArray();
			var rightArr2 = arr2.Reverse().Take(shorterArrayLength).ToArray();
			var longerRight = new List<string>();

			for (int i = 0; i < shorterArrayLength; i++)
			{
				if (rightArr1[i] == rightArr2[i])
				{
					longerRight.Add(arr1[i]);
				}
			}

			Console.WriteLine(Math.Max(longerLeft.Count, longerRight.Count));
		}
	}
}