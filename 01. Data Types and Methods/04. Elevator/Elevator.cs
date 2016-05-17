namespace _04.Elevator
{
	using System;

	public static class Elevator
	{
		public static void Main()
		{
			var peopleCount = int.Parse(Console.ReadLine());
			var capacity = int.Parse(Console.ReadLine());

			var coursesNeeded = Math.Ceiling((double)peopleCount / capacity);
			Console.WriteLine(coursesNeeded);
		}
	}
}
