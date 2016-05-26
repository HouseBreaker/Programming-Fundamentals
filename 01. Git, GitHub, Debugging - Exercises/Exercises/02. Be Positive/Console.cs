namespace _02.Be_Positive
{
	using System;
	using System.IO;
	using System.Threading;

	public static class Console
	{
		private static int currentLine;

		public static string ReadLine()
		{
			var input = File.ReadAllLines("input.txt");
			try
			{
				return input[currentLine++];
			}
			catch (IndexOutOfRangeException)
			{
				return string.Empty;
			}
		}

		public static void WriteLine(string format, params object[] args)
		{
			ColorOutput(() => System.Console.WriteLine(format, args));
		}

		public static void WriteLine(object item)
		{
			ColorOutput(() => System.Console.WriteLine(item));
		}

		public static void WriteLine()
		{
			System.Console.WriteLine();
		}

		public static void Write(string format, params object[] args)
		{
			ColorOutput(() => System.Console.Write(format, args));
		}

		public static void Write(object item)
		{
			ColorOutput(() => System.Console.Write(item));
		}

		private static void ColorOutput(Action printType)
		{
			System.Console.ForegroundColor = ConsoleColor.Green;
			printType();
			System.Console.ResetColor();
		}
	}
}