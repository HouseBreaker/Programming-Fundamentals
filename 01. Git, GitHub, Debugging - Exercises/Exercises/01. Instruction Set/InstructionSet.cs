namespace _01.Instruction_Set
{
	using System;

	public static class InstructionSet
	{
		public static void Main(string[] args)
		{
			var opCode = Console.ReadLine();

			while (opCode != "END")
			{
				string[] codeArgs = opCode.Split(' ');

				long result = 0;
				switch (codeArgs[0])
				{
					case "INC":
						{
							int operandOne = int.Parse(codeArgs[1]);
							result = (long)operandOne + 1;
							break;
						}
					case "DEC":
						{
							int operandOne = int.Parse(codeArgs[1]);
							result = (long)operandOne - 1;
							break;
						}
					case "ADD":
						{
							int operandOne = int.Parse(codeArgs[1]);
							int operandTwo = int.Parse(codeArgs[2]);
							result = (long)operandOne + operandTwo;
							break;
						}
					case "MLA":
						{
							int operandOne = int.Parse(codeArgs[1]);
							int operandTwo = int.Parse(codeArgs[2]);
							result = (long)operandOne * operandTwo;
							break;
						}
				}

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine(result);
				Console.ResetColor();
				opCode = Console.ReadLine();
			}
		}
	}
}
