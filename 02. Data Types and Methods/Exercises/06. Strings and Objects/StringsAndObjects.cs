namespace _06.Strings_and_Objects
{
	using System;

	public static class StringsAndObjects
	{
		public static void Main(string[] args)
		{
			string str1 = "Hello";
			string str2 = "World";

			object obj = str1 + " " + str2;
			string result = (string)obj;

			Console.WriteLine(result);
		}
	}
}
