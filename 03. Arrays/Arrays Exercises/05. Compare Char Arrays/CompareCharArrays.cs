namespace _05.Compare_Char_Arrays
{
	using System;
	using System.Linq;

	public static class CompareCharArrays
	{
		public static void Main(string[] args)
		{
			var charArr1 = Console.ReadLine().Replace(" ", string.Empty);
			var charArr2 = Console.ReadLine().Replace(" ", string.Empty);

			var arr = new[] { charArr1, charArr2 }.OrderBy(a => a).ToArray();

			Console.WriteLine(string.Join(Environment.NewLine, arr));
		}
	}
}
