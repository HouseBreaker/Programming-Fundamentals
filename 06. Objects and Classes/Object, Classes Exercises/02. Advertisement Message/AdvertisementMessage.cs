namespace _02.Advertisement_Message
{
	using System;

	public static class AdvertisementMessage
	{
		public static void Main(string[] args)
		{
			var numberOfAds = int.Parse(Console.ReadLine());

			var phrases = new[]
							{
								"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", 
								"Exceptional product.", "I can’t live without this product."
							};

			var events = new[]
							{
								"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", 
								"I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
							};

			var authors = new[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
			var cities = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

			var rand = new Random();

			for (int i = 0; i < numberOfAds; i++)
			{
				var ad = GenerateRandomTestimonial(phrases, rand, events, authors, cities);
				Console.WriteLine(ad);
			}
		}

		private static string GenerateRandomTestimonial(string[] phrases, Random rand, string[] events, string[] authors, string[] cities)
		{
			const string TestimonialFormat = "{0} {1} {2} – {3}";
			var randomPhrase = phrases[rand.Next(0, phrases.Length)];
			var randomEvent = events[rand.Next(0, events.Length)];
			var randomAuthor = authors[rand.Next(0, authors.Length)];
			var randomCity = cities[rand.Next(0, cities.Length)];

			var ad = string.Format(TestimonialFormat, randomPhrase, randomEvent, randomAuthor, randomCity);
			return ad;
		}
	}
}