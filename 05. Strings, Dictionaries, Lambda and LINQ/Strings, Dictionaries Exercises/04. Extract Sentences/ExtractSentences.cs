namespace _04.Extract_Sentences
{
	using System;
	using System.Linq;
	using System.Text.RegularExpressions;

	public static class ExtractSentences
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var sentences = Console.ReadLine().Split('.', '!', '?');

			var keywordRegex = new Regex(@"\b" + input + @"\b");
			var matchedSentences = sentences.Where(a => keywordRegex.IsMatch(a)).Select(a => a.Trim()).ToArray();
			Console.WriteLine(string.Join(Environment.NewLine, matchedSentences));
		}
	}
}