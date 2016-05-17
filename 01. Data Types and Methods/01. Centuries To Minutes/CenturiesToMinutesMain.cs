namespace _01.Centuries_To_Minutes
{
	using System;

	public static class CenturiesToMinutesMain
	{
		public static void Main()
		{
			var centuries = int.Parse(Console.ReadLine());

			var years = centuries * 100;
			var days = Math.Round(years * 365.242);
			var hours = days * 24;
			var minutes = hours * 60;

			Console.WriteLine(centuries);
			Console.WriteLine(years);
			Console.WriteLine(days);
			Console.WriteLine(hours);
			Console.WriteLine(minutes);
		}
	}
}