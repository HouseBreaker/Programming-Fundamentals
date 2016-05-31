namespace _07.Reverse_an_Array_of_Strings
{
	using System;
	using System.Linq;

	public static class ReverseStringArr
	{
		public static void Main(string[] args)
		{
			var arr = Console.ReadLine().Split().ToArray();
			Console.WriteLine(string.Join(" ", arr.Reverse()));
		}
	}
}