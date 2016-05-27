namespace _22.Fibonacci_Numbers
{
	using System;

	public static class Fibonacci
	{
		public static void Main(string[] args)
		{
			var num = int.Parse(Console.ReadLine());

			Console.WriteLine(Fib(num));
		}

		private static long Fib(int num)
		{
			switch (num)
			{
				case 0:
					return 1;
				case 1:
					return 1;
			}

			return Fib(num - 2) + Fib(num - 1);
		}
	}
}