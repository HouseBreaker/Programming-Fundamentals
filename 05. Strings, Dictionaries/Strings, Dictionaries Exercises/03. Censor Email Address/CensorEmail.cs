namespace _03.Censor_Email_Address
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public static class CensorEmail
	{
		public static void Main(string[] args)
		{
			var emailToCensor = Console.ReadLine();
			var input = Console.ReadLine();

			var username = emailToCensor.Substring(0, emailToCensor.IndexOf('@'));
			var censoredEmail = emailToCensor.Replace(username, new string('*', username.Length));
			input = input.Replace(emailToCensor, censoredEmail);
			Console.WriteLine(input);
		}
	}
}
