namespace _19.Max_Method
{
	using System;
	using System.Linq;

	public static class MaxMethod
	{
		public static void Main(string[] args)
		{
			var num1 = int.Parse(Console.ReadLine());
			var num2 = int.Parse(Console.ReadLine());
			var num3 = int.Parse(Console.ReadLine());

			Console.WriteLine(new[] { num1, num2, num3 }.Max());
		}
	}
}