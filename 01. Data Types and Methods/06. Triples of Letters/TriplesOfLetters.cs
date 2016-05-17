namespace _06.Triples_of_Letters
{
	using System;
	using System.Linq;

	public static class TriplesOfLetters
	{
		public static void Main()
		{
			var count = int.Parse(Console.ReadLine());

			var letters = Enumerable.Range('a', count).Select(a => (char)a).ToArray();

			var letterCount = letters.Length;
			for (int first = 0; first < letterCount; first++)
			{
				for (int second = 0; second < letterCount; second++)
				{
					for (int third = 0; third < letterCount; third++)
					{
						Console.WriteLine("{0}{1}{2}", letters[first], letters[second], letters[third]);
					}
				}
			}
		}
	}
}