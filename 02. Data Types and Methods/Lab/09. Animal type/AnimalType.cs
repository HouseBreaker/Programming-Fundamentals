namespace _09.Animal_type
{
	using System;

	public static class AnimalType
	{
		public static void Main()
		{
			var animal = Console.ReadLine();

			string type;
			switch (animal)
			{
				case "dog":
					type = "mammal";
					break;
				case "crocodile":
				case "tortoise":
				case "snake":
					type = "reptile";
					break;
				default:
					type = "unknown";
					break;
			}

			Console.WriteLine(type);
		}
	}
}