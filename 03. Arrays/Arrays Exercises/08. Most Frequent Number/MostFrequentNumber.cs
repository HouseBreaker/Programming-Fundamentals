namespace _08.Most_Frequent_Number
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class MostFrequentNumber
	{
		public static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var occurences = new Dictionary<int, int>();

			foreach (var num in arr)
			{
				occurences[num] = occurences.ContainsKey(num) ? ++occurences[num] : 1;
			}

			var mostFrequent = occurences.Values.Max();
			var mostFrequentNumber = occurences.First(a => a.Value == mostFrequent);

			Console.WriteLine(mostFrequentNumber.Key);
		}
	}
}
