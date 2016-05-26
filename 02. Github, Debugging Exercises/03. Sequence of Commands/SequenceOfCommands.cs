namespace _03.Sequence_of_Commands
{
	using System;
	using System.Linq;

	// using _02.Be_Positive;
	public static class SequenceOfCommands
	{
		private const char ArgumentsDelimiter = ' ';

		public static void Main()
		{
			int sizeOfArray = int.Parse(Console.ReadLine());

			long[] array = Console.ReadLine().Split(ArgumentsDelimiter).Select(long.Parse).ToArray();

			string command = Console.ReadLine();

			while (!command.Equals("stop"))
			{
				int[] args = new int[2];

				if (command.StartsWith("add") || command.StartsWith("subtract") || command.StartsWith("multiply"))
				{
					string[] stringParams = command.Split(ArgumentsDelimiter);

					var action = stringParams[0];
					args[0] = int.Parse(stringParams[1]);
					args[1] = int.Parse(stringParams[2]);

					PerformAction(array, action, args);
				}
				else if (command == "rshift")
				{
					ArrayShiftRight(array);
				}
				else if (command == "lshift")
				{
					ArrayShiftLeft(array);
				}

				PrintArray(array);
				Console.WriteLine();

				command = Console.ReadLine().Trim();
			}
		}

		public static void PerformAction(long[] array, string action, int[] args)
		{
			int pos = args[0] - 1;
			int value = args[1];

			switch (action)
			{
				case "multiply":
					array[pos] *= value;
					break;
				case "add":
					array[pos] += value;
					break;
				case "subtract":
					array[pos] -= value;
					break;
				case "lshift":
					ArrayShiftLeft(array);
					break;
				case "rshift":
					ArrayShiftRight(array);
					break;
			}
		}

		private static void ArrayShiftRight(long[] array)
		{
			var last = array[array.Length - 1];
			for (int i = array.Length - 1; i >= 1; i--)
			{
				array[i] = array[i - 1];
			}

			array[0] = last;
		}

		private static void ArrayShiftLeft(long[] array)
		{
			var last = array[0];

			for (int i = 0; i < array.Length - 1; i++)
			{
				array[i] = array[i + 1];
			}

			array[array.Length - 1] = last;
		}

		private static void PrintArray(long[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
		}
	}
}