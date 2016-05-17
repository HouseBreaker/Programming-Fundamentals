namespace _03.Exact_Sum_of_Real_Numbers
{
	using System;
	using System.Linq;

	public static class ExactSum
	{
		public static void Main()
		{
			var count = int.Parse(Console.ReadLine());
			
			var numbers = new decimal[count];
			for (int i = 0; i < count; i++)
			{
				numbers[i] = decimal.Parse(Console.ReadLine());
			}

			var sum = numbers.Sum();
			Console.WriteLine(sum);
		}
	}
}
