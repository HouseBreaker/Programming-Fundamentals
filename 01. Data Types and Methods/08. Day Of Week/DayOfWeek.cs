namespace _08.Day_Of_Week
{
	using System;

	public static class DayOfWeek
	{
		public static void Main()
		{
			var day = int.Parse(Console.ReadLine());

			day = day != 7 ? day : 0;
			Console.WriteLine((System.DayOfWeek)day);
		}
	}
}