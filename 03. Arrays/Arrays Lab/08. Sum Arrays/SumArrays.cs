namespace _08.Sum_Arrays
{
	using System;
	using System.Linq;

	public static class SumArrays
	{
		public static void Main(string[] args)
		{
			var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var longerArrLength = arr1.Length > arr2.Length ? arr1.Length : arr2.Length;
			var summedArr = new int[longerArrLength];

			for (int i = 0; i < summedArr.Length; i++)
			{
				var sum = arr1[i % arr1.Length] + arr2[i % arr2.Length];
				summedArr[i] = sum;
			}

			Console.WriteLine(string.Join(" ", summedArr));
		}
	}
}