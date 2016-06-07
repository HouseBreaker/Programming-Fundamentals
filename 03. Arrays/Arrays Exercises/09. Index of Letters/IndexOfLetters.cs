namespace _09.Index_of_Letters
{
	using System;

	public static class IndexOfLetters
	{
		public static void Main(string[] args)
		{
			var letters = Console.ReadLine();

			foreach (var id in letters)
			{
				var letterIndex = id - 'a';
				Console.WriteLine($"{id} -> {letterIndex}");
			}
		}
	}
}
