namespace _23.Prime_Checker
{
	using System;

	public static class PrimeChecker
	{
		public static void Main(string[] args)
		{
			var num = long.Parse(Console.ReadLine());

			Console.WriteLine(IsPrime(num));
		}

		private static bool IsPrime(long num)
		{
			if (num < 2)
			{
				return false;
			}

			for (var i = 2; i < num; i++)
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