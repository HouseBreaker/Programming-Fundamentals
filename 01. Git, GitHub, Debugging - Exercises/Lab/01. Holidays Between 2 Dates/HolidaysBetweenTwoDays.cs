namespace _01.Holidays_Between_2_Dates
{
	using System;
	using System.Globalization;

	public static class HolidaysBetweenTwoDays
	{
		public static void Main(string[] args)
		{
			var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
			var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

			var holidaysCount = 0;
			for (var date = startDate; date <= endDate; date = date.AddDays(1))
			{
				if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
				{
					holidaysCount++;
				}
			}

			Console.WriteLine(holidaysCount);
		}
	}
}