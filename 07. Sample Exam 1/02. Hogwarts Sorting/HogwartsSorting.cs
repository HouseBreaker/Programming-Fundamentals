namespace _02.Hogwarts_Sorting
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class HogwartsSorting
	{
		public static void Main(string[] args)
		{
			var numberOfStudents = int.Parse(Console.ReadLine());

			var names = new List<string>();
			for (int i = 0; i < numberOfStudents; i++)
			{
				names.Add(Console.ReadLine());
			}

			var houses = new Dictionary<int, string>
							{
								{ 0, "Gryffindor" }, 
								{ 1, "Slytherin" }, 
								{ 2, "Ravenclaw" }, 
								{ 3, "Hufflepuff" }
							};

			var houseStudentsCount = new Dictionary<string, int>
										{
											{ "Gryffindor", 0 }, 
											{ "Slytherin", 0 }, 
											{ "Ravenclaw", 0 }, 
											{ "Hufflepuff", 0 }
										};

			foreach (var name in names)
			{
				var firstLastName = name.Split();

				var nameSum = string.Join(string.Empty, firstLastName).Sum(a => a);
				var house = houses[nameSum % 4];
				var initials = $"{firstLastName[0][0]}{firstLastName[1][0]}";

				houseStudentsCount[house]++;

				Console.WriteLine($"{house} {nameSum}{initials}");
			}

			Console.WriteLine();

			foreach (var house in houseStudentsCount)
			{
				Console.WriteLine($"{house.Key}: {house.Value}");
			}
		}
	}
}