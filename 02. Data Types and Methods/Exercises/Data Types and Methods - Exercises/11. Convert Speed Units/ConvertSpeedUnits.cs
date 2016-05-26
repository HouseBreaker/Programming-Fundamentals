namespace _11.Convert_Speed_Units
{
	using System;

	public static class ConvertSpeedUnits
	{
		public static void Main(string[] args)
		{
			var meters = float.Parse(Console.ReadLine());
			var hours = float.Parse(Console.ReadLine());
			var minutes = float.Parse(Console.ReadLine());
			var seconds = float.Parse(Console.ReadLine());

			var secondsTaken = hours * 3600 + minutes * 60 + seconds;
			var hoursTaken = hours + minutes / 60f + seconds / 3600f;

			var km = meters / 1000f;
			var mi = meters / 1609f;
			
			var mps = (float)meters / secondsTaken;
			var kmh = km / hoursTaken;
			var mph = mi / hoursTaken;

			Console.WriteLine(mps);
			Console.WriteLine(kmh);
			Console.WriteLine(mph);
		}
	}
}
