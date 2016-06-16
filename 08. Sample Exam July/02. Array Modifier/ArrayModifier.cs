using System;
using System.Collections.Generic;

namespace _02.Array_Modifier
{
	using System.Linq;

	public static class ArrayModifier
	{
		public static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split().Select(long.Parse).ToArray();

			var line = Console.ReadLine();
			while (line != "end")
			{
				var tokens = line.Split();
				var command = tokens[0];
				switch (command)
				{
					case "swap":
						SwapElements(tokens, arr);
						break;
					case "multiply":
						MultiplyElements(tokens, arr);
						break;
					case "decrease":
						for (int i = 0; i < arr.Length; i++)
						{
							arr[i]--;
						}

						break;
				}

				line = Console.ReadLine();
			}

			Console.WriteLine(string.Join(", ", arr));
		}

		private static void MultiplyElements(string[] tokens, long[] arr)
		{
			var firstIndex = int.Parse(tokens[1]);
			var secondIndex = int.Parse(tokens[2]);
			arr[firstIndex] *= arr[secondIndex];
		}

		private static void SwapElements(string[] tokens, long[] arr)
		{
			var firstIndex = int.Parse(tokens[1]);
			var secondIndex = int.Parse(tokens[2]);

			arr[firstIndex] ^= arr[secondIndex];
			arr[secondIndex] ^= arr[firstIndex];
			arr[firstIndex] ^= arr[secondIndex];
		}
	}
}