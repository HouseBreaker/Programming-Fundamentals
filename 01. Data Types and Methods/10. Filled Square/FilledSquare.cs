namespace _10.Filled_Square
{
	using System;
	using System.Linq;

	public static class FilledSquare
	{
		public static void Main()
		{
			var size = int.Parse(Console.ReadLine());

			Console.WriteLine(new string('-', size * 2));

			for (int i = 0; i < size / 2; i++)
			{
				var slashes = string.Concat(Enumerable.Repeat(@"\/", size - 1));
				Console.WriteLine("-" + slashes + "-");
			}

			Console.WriteLine(new string('-', size * 2));
		}
	}
}