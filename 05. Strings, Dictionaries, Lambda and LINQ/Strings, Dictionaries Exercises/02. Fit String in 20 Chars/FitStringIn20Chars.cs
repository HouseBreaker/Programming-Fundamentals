namespace _02.Fit_String_in_20_Chars
{
	using System;

	public static class FitStringIn20Chars
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var result = input.Length > 20 ? input.Substring(0, 20) : input.PadRight(20, '*');
			Console.WriteLine(result);
		}
	}
}
