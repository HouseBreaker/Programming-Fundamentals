namespace _13.Phonebook_Upgrade
{
	using System;
	using System.Collections.Generic;

	public static class Phonebook
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var phonebook = new SortedDictionary<string, string>();

			while (input != "END")
			{
				if (input == "ListAll")
				{
					foreach (var pair in phonebook)
					{
						var contactName = pair.Key;
						var number = pair.Value;
						Console.WriteLine($"{contactName} -> {number}");
					}

					input = Console.ReadLine();
					continue;
				}

				var tokens = input.Split();
				var name = tokens[1];

				switch (tokens[0])
				{
					case "A":
						var number = tokens[2];
						phonebook[name] = number;
						break;
					case "S":
						Console.WriteLine(phonebook.ContainsKey(name) ? $"{name} -> {phonebook[name]}" : $"Contact {name} does not exist.");
						break;
				}

				input = Console.ReadLine();
			}
		}
	}
}