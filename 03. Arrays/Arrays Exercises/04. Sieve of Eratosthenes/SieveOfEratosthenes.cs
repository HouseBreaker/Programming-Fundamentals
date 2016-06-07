namespace _04.Sieve_of_Eratosthenes
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Linq;

	public static class SieveOfEratosthenes
	{
		public static void Main(string[] args)
		{
			var numOfPrimes = int.Parse(Console.ReadLine());

			var numbers = Enumerable.Range(2, numOfPrimes - 1).ToArray();
			var primes = new bool[numbers.Length].Select(a => !a).ToArray();

			for (int index = 0; index < numbers.Length; index++)
			{
				var number = numbers[index];

				if (!primes[index])
				{
					continue;
				}

				var changedPrimeStatus = false;
				for (int i = index + number; i < numbers.Length; i += number)
				{
					if (primes[i])
					{
						primes[i] = false;
						changedPrimeStatus = true;
					}
				}

				if (!changedPrimeStatus)
				{
					break;
				}
			}

			var primeNumbers = numbers.Where((t, i) => primes[i]);
			Console.WriteLine(string.Join(" ", primeNumbers));
		}
	}
}