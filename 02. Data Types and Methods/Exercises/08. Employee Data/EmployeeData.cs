﻿namespace _08.Employee_Data
{
	using System;

	public static class EmployeeData
	{
		public static void Main(string[] args)
		{
			string firstName = Console.ReadLine();
			string lastName = Console.ReadLine();
			byte age = byte.Parse(Console.ReadLine());
			char gender = char.Parse(Console.ReadLine());
			long personalId = long.Parse(Console.ReadLine());
			int employeeNumber = int.Parse(Console.ReadLine());

			Console.WriteLine("First name: " + firstName);
			Console.WriteLine("Last name: " + lastName);
			Console.WriteLine("Age: " + age);
			Console.WriteLine("Gender: " + gender);
			Console.WriteLine("Personal ID: " + personalId);
			Console.WriteLine("Unique Employee number: " + employeeNumber);
		}
	}
}