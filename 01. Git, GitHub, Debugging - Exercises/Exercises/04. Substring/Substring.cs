﻿namespace _04.Substring
{
	using System;

	// using Console = _02.Be_Positive.Console;

	public static class Substring
	{
		public static void Main(string[] args)
		{
			string text = Console.ReadLine();
			int jump = int.Parse(Console.ReadLine());

			const char Search = 'p';
			bool hasMatch = false;

			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == Search)
				{
					hasMatch = true;

					int endIndex = jump + 1;

					if (i + endIndex > text.Length)
					{
						endIndex -= (i + endIndex) - text.Length;
					}

					string matchedString = text.Substring(i, endIndex);
					Console.WriteLine(matchedString);
					i += jump;
				}
			}

			if (!hasMatch)
			{
				Console.WriteLine("no");
			}
		}
	}
}