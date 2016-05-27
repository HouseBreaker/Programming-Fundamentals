namespace _20.English_Name_оf_The_Last_Digit
{
	using System;
	using System.Collections.Generic;

	public static class EnglishLastDigit
	{
		public static void Main(string[] args)
		{
			var num = long.Parse(Console.ReadLine());

			var names = new Dictionary<int, string>
							{
								{ 0, "zero" }, 
								{ 1, "one" }, 
								{ 2, "two" }, 
								{ 3, "three" }, 
								{ 4, "four" }, 
								{ 5, "five" }, 
								{ 6, "six" }, 
								{ 7, "seven" }, 
								{ 8, "eight" }, 
								{ 9, "nine" }
							};

			var lastDigit = Math.Abs(num % 10);

			Console.WriteLine(names[(int)lastDigit]);
		}
	}
}