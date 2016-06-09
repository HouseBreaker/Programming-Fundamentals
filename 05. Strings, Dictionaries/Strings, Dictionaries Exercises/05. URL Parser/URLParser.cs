namespace _05.URL_Parser
{
	using System;
	using System.Text.RegularExpressions;

	public static class UrlParser
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var regex = new Regex(@"((?<protocol>[^\/]+):\/\/)?(?<server>[^\/]+)(\/(?<resource>.+))?");
			var matches = regex.Matches(input);

			foreach (Match match in matches)
			{
				Console.WriteLine("[protocol] = \"{0}\"", match.Groups["protocol"]);
				Console.WriteLine("[server] = \"{0}\"", match.Groups["server"]);
				Console.WriteLine("[resource] = \"{0}\"", match.Groups["resource"]);
			}
		}
	}
}
