namespace _02.Circle_Area__12_Digits_Precision_
{
	using System;

	public static class CircleArea
	{
		public static void Main()
		{
			var radius = double.Parse(Console.ReadLine());

			var area = Math.PI * radius * radius;

			Console.WriteLine(area.ToString("F12"));
		}
	}
}
