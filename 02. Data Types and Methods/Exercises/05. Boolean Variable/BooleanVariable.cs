namespace _05.Boolean_Variable
{
	using System;

	public static class BooleanVariable
	{
		public static void Main(string[] args)
		{
			var boolean = bool.Parse(Console.ReadLine());
			var result = boolean ? "Yes" : "No";

			Console.WriteLine(result);
		}
	}
}
