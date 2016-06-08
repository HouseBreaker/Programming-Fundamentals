namespace _01.Count_Working_Days
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class CountWorkingDays
	{
		public static void Main(string[] args)
		{
			var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
			var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

			var holidays = new[] { "01-01", "03-03", "05-01", "05-06", "05-24", "09-06", "09-22", "11-01", "12-24", "12-25", "12-26" }.Select(DateTime.Parse).ToArray();

			var workingDays = 0;
			var dates = new List<DateTime>();

			for (var date = startDate; date <= endDate; date = date.AddDays(1))
			{
				dates.Add(date);
			}

			foreach (var date in dates)
			{
				var isWeekend = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;

				var isHoliday = holidays.Any(holiday => date.Month == holiday.Month && date.Day == holiday.Day);

				if (!isWeekend && !isHoliday)
				{
					workingDays++;
				}
			}

			Console.WriteLine(workingDays);
		}
	}
}