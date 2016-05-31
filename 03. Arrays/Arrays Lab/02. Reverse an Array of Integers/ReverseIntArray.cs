namespace _02.Reverse_an_Array_of_Integers
{
	using System;
	using System.Linq;

	public static class ReverseIntArray
	{
		public static void Main(string[] args)
		{
			var num = int.Parse(Console.ReadLine());

			var numArray = new int[num];

			for (int i = 0; i < num; i++)
			{
				numArray[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine(string.Join(" ", numArray.Reverse()));
		}
	}
}
