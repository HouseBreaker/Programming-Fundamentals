namespace _03.Fold_and_Sum
{
	using System;
	using System.Linq;

	public static class FoldAndSum
	{
		public static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var quarter = arr.Length / 4;
			var half = arr.Length / 2;

			var fold = arr.Take(quarter).Reverse().Concat(arr.Reverse().Take(quarter)).ToArray();
			var middle = arr.Skip(quarter).Take(half).ToArray();

			var sum = fold.Zip(middle, (a, b) => a + b);

			Console.WriteLine(string.Join(" ", sum));
		}
	}
}
