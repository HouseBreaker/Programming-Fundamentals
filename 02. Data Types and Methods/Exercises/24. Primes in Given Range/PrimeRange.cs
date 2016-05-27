namespace _24.Primes_in_Given_Range
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class PrimeRange
	{
		public static void Main(string[] args)
		{
			var startNum = int.Parse(Console.ReadLine());
			var endNum = int.Parse(Console.ReadLine());

			var primes = FindPrimesInRange(startNum, endNum);

			Console.WriteLine(string.Join(", ", primes));
		}

		private static List<int> FindPrimesInRange(int startNum, int endNum)
		{
			var primes = new List<int>();
			for (int i = startNum; i <= endNum; i++)
			{
				if (IsPrime(i))
				{
					primes.Add(i);
				}
			}
			return primes;
		}

		public static bool IsPrime(int num)
		{
			switch (num)
			{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
					return true;
			}

			for (int i = 2; i < num; i++)
			{
				if (num % i == 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}