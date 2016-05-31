namespace _3.Sum__Min__Max__First__Last__Average
{
	using System;
	using System.Linq;

	public static class SumMinMaxFirstLastAverage
	{
		public static void Main(string[] args)
		{
			var num = int.Parse(Console.ReadLine());

			var numArray = new int[num];

			for (int i = 0; i < num; i++)
			{
				numArray[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine($"Sum = {numArray.Sum()}");
			Console.WriteLine($"Min = {numArray.Min()}");
			Console.WriteLine($"Max = {numArray.Max()}");
			Console.WriteLine($"First = {numArray.First()}");
			Console.WriteLine($"Last = {numArray.Last()}");
			Console.WriteLine($"Average = {numArray.Average()}");
		}
	}
}