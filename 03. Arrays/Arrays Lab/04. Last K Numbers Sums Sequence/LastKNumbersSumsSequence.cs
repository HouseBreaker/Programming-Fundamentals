namespace _04.Last_K_Numbers_Sums_Sequence
{
	using System;
	using System.Linq;

	public static class LastKNumbersSumsSequence
	{
		public static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var k = int.Parse(Console.ReadLine());

			var arr = new long[n];
			arr[0] = 1;

			for (int i = 1; i < n; i++)
			{
				arr[i] = arr.Take(i).Reverse().Take(k).Sum();
			}

			Console.WriteLine(string.Join(" ", arr));
		}
	}
}