namespace _07.Student_Groups
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text.RegularExpressions;

	public static class StudentGroups
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine();
			
			var towns = new Dictionary<string, Town>();
			Town currentTown = null;
			while (input != "End")
			{
				const string TownRegex = @"(?<town>.+) => (?<seatsCount>\d+) seats";
				const string StudentRegex = @"(?<name>.+?) *\| *(?<email>.+?) *\| *(?<registrationDate>.+)";

				var townInfo = Regex.Match(input, TownRegex);
				var studentInfo = Regex.Match(input, StudentRegex);
				
				if (townInfo.Success)
				{
					var townName = townInfo.Groups["town"].Value;
					var seatsCount = int.Parse(townInfo.Groups["seatsCount"].Value);

					currentTown = new Town(townName, seatsCount);
					towns[currentTown.Name] = currentTown;

					input = Console.ReadLine();
					continue;
				}

				if (studentInfo.Success)
				{
					var name = studentInfo.Groups["name"].Value;
					var email = studentInfo.Groups["email"].Value;
					var registrationDate = DateTime.ParseExact(studentInfo.Groups["registrationDate"].Value, "d-MMM-yyyy", null);

					var student = new Student(name, email, registrationDate);
					towns[currentTown.Name].Students.Add(student);
				}

				input = Console.ReadLine();
			}

			var groupsByTown = new SortedDictionary<string, List<Group>>(); 
			foreach (var townData in towns)
			{
				var townName = townData.Key;
				var town = townData.Value;

				var seats = townData.Value.SeatsCount;
				townData.Value.Students = townData.Value.Students.OrderBy(a => a.RegistrationDate).ThenBy(a => a.Name).ThenBy(a => a.Email).ToList();
				
				groupsByTown[townName] = new List<Group>();

				for (int i = 0; i < townData.Value.Students.Count; i += seats)
				{
					
					var studentsInGroup = town.Students.Skip(i).Take(seats).ToArray();
					var group = new Group(town, studentsInGroup);
					groupsByTown[townName].Add(group);
				}
			}

			Console.ForegroundColor = ConsoleColor.Green;

			var groupCount = groupsByTown.Values.Sum(a => a.Count);

			Console.WriteLine("Created {0} groups in {1} towns:", groupCount, groupsByTown.Count);
			foreach (var townGroup in groupsByTown)
			{
				var town = townGroup.Key;
				var groups = townGroup.Value;

				foreach (var group in groups)
				{
					var emails = group.Students.Select(b => b.Email);
					Console.WriteLine($"{town} => {string.Join(", ", emails)}");
				}
			}
		}
	}

	public class Student
	{
		public Student(string name, string email, DateTime registrationDate)
		{
			this.Name = name;
			this.Email = email;
			this.RegistrationDate = registrationDate;
		}

		public string Name { get; set; }

		public string Email { get; set; }

		public DateTime RegistrationDate { get; set; }
	}

	public class Town
	{
		public Town(string name, int seatsCount)
		{
			this.Name = name;
			this.SeatsCount = seatsCount;
			this.Students = new List<Student>();
		}

		public string Name { get; set; }
		
		public int SeatsCount { get; set; }

		public List<Student> Students { get; set; }
	}

	public class Group
	{
		public Group(Town town, IEnumerable<Student> students)
		{
			this.Town = town;
			this.Students = students.ToList();
		}

		public Town Town { get; set; }

		public List<Student> Students { get; set; } 
	}
}
