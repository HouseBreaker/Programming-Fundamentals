namespace _04.Population_Aggregation
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;

	public static class PopulationAggregation
	{
		public static void Main(string[] args)
		{
			const string Format1 = @"(?<country>[A-Z][^@#$&0-9]*?)\\(?<city>[a-z][^@#$&0-9]+?)\\(?<population>\d+)";
			const string Format2 = @"(?<city>[a-z][^@#$&0-9]*?)\\(?<country>[A-Z][^@#$&0-9]+?)\\(?<population>\d+)";

			// long array's first index is the population, the second is the times we've seen the city already
			var countryData = new SortedDictionary<string, Dictionary<string, ulong[]>>();

			var line = Console.ReadLine();
			while (line != "stop")
			{
				var data = SanitizeInput(line);

				var matchFormat1 = Regex.Match(data, Format1);
				var matchFormat2 = Regex.Match(data, Format2);

				var formatMatched = matchFormat1.Success ? matchFormat1 : matchFormat2;

				var country = formatMatched.Groups["country"].Value;
				var city = formatMatched.Groups["city"].Value;
				var population = ulong.Parse(formatMatched.Groups["population"].Value);

				if (!countryData.ContainsKey(country))
				{
					countryData[country] = new Dictionary<string, ulong[]> { [city] = new ulong[2] };
				}

				if (!countryData[country].ContainsKey(city))
				{
					countryData[country][city] = new ulong[2];
				}

				countryData[country][city][0] = population;
				countryData[country][city][1]++;

				line = Console.ReadLine();
			}

			// print countries
			foreach (var country in countryData)
			{
				Console.WriteLine($"{country.Key} -> {country.Value.Count}");
			}

			// get all towns and sort by population
			var topPopulationTowns = new List<KeyValuePair<string, ulong>>();
			foreach (var townsByCountry in countryData.Values)
			{
				topPopulationTowns.AddRange(townsByCountry.Select(town => new KeyValuePair<string, ulong>(town.Key, town.Value[0])));
			}

			topPopulationTowns = topPopulationTowns.OrderByDescending(a => a.Value).ThenBy(a => a.Key).Take(3).ToList();

			foreach (var town in topPopulationTowns)
			{
				Console.WriteLine($"{town.Key} -> {town.Value}");
			}
		}

		private static string SanitizeInput(string input)
		{
			var sb = new StringBuilder();
			var invalidChars = new[] { '@', '#', '$', '&', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
			foreach (var symbol in input.Where(symbol => !invalidChars.Contains(symbol)))
			{
				sb.Append(symbol);
			}

			foreach (var number in input.Substring(input.LastIndexOf('\\') + 1))
			{
				sb.Append(number);
			}

			return sb.ToString();
		}
	}
}