namespace _06.Reverse_the_Words_in_a_Sentence
{
	using System;
	using System.Linq;
	using System.Text.RegularExpressions;

	public static class ReverseWordsInSentence
	{
		public static void Main(string[] args)
		{
			var sentence = Console.ReadLine();

			var reversedWords = Regex.Matches(sentence, @"[^.,:;=()&\[\]""\'\\\/\!\? ]+").Cast<Match>().Select(a => a.Value).Reverse().ToArray();
			var separators = Regex.Matches(sentence, @"[.,:;=()&\[\]""\'\\\/\!\? ]+").Cast<Match>().Select(a => a.Value).ToArray();
			
			var reconstructed = reversedWords.Zip(separators, (word, separator) => word + separator);
			Console.WriteLine(string.Join(string.Empty, reconstructed));
		}
	}
}