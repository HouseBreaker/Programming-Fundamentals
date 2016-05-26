namespace _12.Rectangle_Properties
{
	using System;

	public static class RectangleProperties
	{
		public static void Main(string[] args)
		{
			var width = double.Parse(Console.ReadLine());
			var height = double.Parse(Console.ReadLine());

			var perimeter = (width + height) * 2;
			var area = width * height;
			var diagonal = Math.Sqrt(width * width + height * height);

			Console.WriteLine(perimeter);
			Console.WriteLine(area);
			Console.WriteLine(diagonal);
		}
	}
}
