namespace _01.Day_of_Week
{
	using System;

	public static class DayOfWeek
	{
		public static void Main(string[] args)
		{
			var days = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

			var day = int.Parse(Console.ReadLine());

			var dayIndex = day - 1;

			if (dayIndex >= 0 && dayIndex <= 6)
			{
				Console.WriteLine(days[dayIndex]);
			}
			else
			{
				Console.WriteLine("Invalid Day!");
			}
		}
	}
}