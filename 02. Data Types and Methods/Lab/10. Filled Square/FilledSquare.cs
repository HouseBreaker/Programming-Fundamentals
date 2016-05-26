namespace _10.Filled_Square
{
	using System;
	using System.Linq;

	public static class FilledSquare
	{
		public static void Main()
		{
			var size = int.Parse(Console.ReadLine());

			PrintHeaderRow(size);

			for (int i = 0; i < size - 2; i++)
			{
				PrintMiddleRow(size);
			}

			PrintHeaderRow(size);
		}

		private static void PrintMiddleRow(int size)
		{
			var slashes = string.Concat(Enumerable.Repeat(@"\/", size - 1));
			Console.WriteLine("-" + slashes + "-");
		}

		private static void PrintHeaderRow(int size)
		{
			Console.WriteLine(new string('-', size * 2));
		}
	}
}