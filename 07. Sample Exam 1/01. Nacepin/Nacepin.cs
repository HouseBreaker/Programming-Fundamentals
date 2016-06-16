using System;
using System.Collections.Generic;

namespace _01.Nacepin
{
	using System.Linq;

	public static class Nacepin
	{
		public static void Main(string[] args)
		{
			var usPrice = decimal.Parse(Console.ReadLine());
			var usWeight = long.Parse(Console.ReadLine());
			var ukPrice = decimal.Parse(Console.ReadLine());
			var ukWeight = long.Parse(Console.ReadLine());
			var cnPrice = decimal.Parse(Console.ReadLine());
			var cnWeight = long.Parse(Console.ReadLine());

			const decimal UsToLeva = 0.58m;
			const decimal GbpToLeva = 0.41m;
			const decimal CnyToLeva = 1 / 0.27m;

			var prices = new Dictionary<string, decimal>
							{
								["US"] = usPrice / UsToLeva / usWeight, 
								["UK"] = ukPrice / GbpToLeva / ukWeight, 
								["Chinese"] = cnPrice / CnyToLeva / cnWeight
							};

			var sortedPrices = prices.OrderBy(a => a.Value);

			var highestPriceCountry = sortedPrices.Last();
			var lowestPriceCountry = sortedPrices.First();
			var difference = highestPriceCountry.Value - lowestPriceCountry.Value;

			Console.WriteLine("{0} store. {1:F2} lv/kg", lowestPriceCountry.Key, lowestPriceCountry.Value);
			Console.WriteLine("Difference {0:F2} lv/kg", difference);
		}
	}
}