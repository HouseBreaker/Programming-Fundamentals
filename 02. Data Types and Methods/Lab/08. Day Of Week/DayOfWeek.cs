namespace _08.Day_Of_Week
{
	using System;

	public static class DayOfWeek
	{
		public static void Main()
		{
			var day = int.Parse(Console.ReadLine());

			if (day < 1 || day > 7)
			{
				Console.WriteLine("error");
			}
			else
			{
				day = day == 7 ? 0 : day;
				Console.WriteLine((System.DayOfWeek)day);
			}
		}
	}
}