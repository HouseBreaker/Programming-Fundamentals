namespace _09.Condense_Array_to_Number
{
	using System;
	using System.Linq;

	public static class CondenseArrayToNumber
	{
		public static void Main(string[] args)
		{
			var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

			while (nums.Length != 1)
			{
				var condensed = new int[nums.Length];
				for (int i = 0; i < nums.Length - 1; i++)
				{
					condensed[i] = nums[i] + nums[i + 1];
				}

				nums = condensed.Take(nums.Length - 1).ToArray();
			}

			Console.WriteLine(nums[0]);
		}
	}
}