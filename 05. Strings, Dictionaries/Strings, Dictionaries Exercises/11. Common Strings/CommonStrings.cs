namespace _11.Common_Strings
{
	using System;
	using System.Linq;

	static class CommonStrings
	{
		public static void Main(string[] args)
		{
			var string1 = Console.ReadLine();
			var string2 = Console.ReadLine();

			Console.WriteLine(string1.Any(ch => string2.Contains(ch.ToString())) ? "yes" : "no");
		}
	}
}