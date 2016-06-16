namespace _03.Dress_Pattern
{
	using System;

	public static class DressPattern
	{
		public static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			Console.WriteLine(new string('_', 4 * n) + '.' + new string('_', 4 * n) + '.' + new string('_', 4 * n));
			for (int i = 0; i < 2 * n; i++)
			{
				Console.WriteLine(
					new string('_', 4 * n - 2 - 2 * i) + '.' + new string('*', 2 + 3 * i) + '.' + new string('_', 4 * n - 2 - 2 * i)
					+ '.' + new string('*', 2 + 3 * i) + '.' + new string('_', 4 * n - 2 - 2 * i));
			}

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine('.' + new string('*', 12 * n) + '.');
			}

			Console.WriteLine(new string('.', 3 * n) + new string('*', 6 * n + 2) + new string('.', 3 * n));
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(new string('_', 3 * n) + new string('o', 6 * n + 2) + new string('_', 3 * n));
			}

			for (int i = 0; i < 3 * n; i++)
			{
				Console.WriteLine(
					new string('_', 3 * n - 1 - i + 1) + '.' + new string('*', 6 * n + 1 + i * 2 - 1) + '.'
					+ new string('_', 3 * n - i));
			}

			Console.WriteLine(new string('.', 12 * n + 2));
		}
	}
}