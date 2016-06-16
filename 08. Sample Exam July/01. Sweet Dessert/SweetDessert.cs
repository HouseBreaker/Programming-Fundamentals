namespace _01.Sweet_Dessert
{
	using System;
	using System.Collections.Generic;

	public static class SweetDessert
	{
		public static void Main(string[] args)
		{
			var cash = decimal.Parse(Console.ReadLine());
			var guestsCount = int.Parse(Console.ReadLine());
			var bananaPrice = decimal.Parse(Console.ReadLine());
			var eggsPrice = decimal.Parse(Console.ReadLine());
			var berriesPrice = decimal.Parse(Console.ReadLine());

			var totalPortions = Math.Ceiling(guestsCount / (double)6);

			var pricePerPortion = (bananaPrice * 2) + (eggsPrice * 4) + (berriesPrice * 0.2m);
			var totalPrice = (decimal)totalPortions * pricePerPortion;

			if (totalPrice <= cash)
			{
				Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
			}
			else
			{
				Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalPrice - cash:F2}lv more.");
			}
		}
	}
}