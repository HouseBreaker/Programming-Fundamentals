namespace _17.Different_Integers_Size
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Numerics;

	public static class DifferentIntegersSize
	{
		public static void Main(string[] args)
		{
			var limits = new Dictionary<string, Limit>
							{
								{ "sbyte", new Limit(sbyte.MinValue, sbyte.MaxValue) }, 
								{ "byte", new Limit(byte.MinValue, byte.MaxValue) }, 
								{ "short", new Limit(short.MinValue, short.MaxValue) }, 
								{ "ushort", new Limit(ushort.MinValue, ushort.MaxValue) }, 
								{ "int", new Limit(int.MinValue, int.MaxValue) }, 
								{ "uint", new Limit(uint.MinValue, uint.MaxValue) }, 
								{ "long", new Limit(long.MinValue, long.MaxValue) }
							};

			var number = BigInteger.Parse(Console.ReadLine());

			var types =
				limits.Where(n => number >= n.Value.LowerLimit && number <= n.Value.UpperLimit).Select(a => a.Key).ToArray();

			if (types.Any())
			{
				Console.WriteLine(number + " can fit in:");
				foreach (var type in types)
				{
					Console.WriteLine($"* {type}");
				}
			}
			else
			{
				Console.WriteLine($"{number} can't fit in any type");
			}
		}
	}

	public class Limit
	{
		public Limit(BigInteger lowerLimit, BigInteger upperLimit)
		{
			this.LowerLimit = lowerLimit;
			this.UpperLimit = upperLimit;
		}

		public BigInteger LowerLimit { get; }

		public BigInteger UpperLimit { get; }
	}
}