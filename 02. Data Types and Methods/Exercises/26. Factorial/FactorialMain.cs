namespace _26.Factorial
{
	using System;
	using System.Numerics;

	public static class FactorialMain
	{
		public static void Main(string[] args)
		{
			var num = BigInteger.Parse(Console.ReadLine());

			Console.WriteLine(CalcFactorial(num));
		}

		private static BigInteger CalcFactorial(BigInteger num)
		{
			if (num <= 1)
			{
				return 1;
			}

			return num * CalcFactorial(num - 1);
		}
	}
}