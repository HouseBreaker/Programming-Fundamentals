using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
	public static class AverageGrades
	{
		public static void Main(string[] args)
		{
			var numberOfStudents = int.Parse(Console.ReadLine());

			var students = new List<Student>();
			for (int i = 0; i < numberOfStudents; i++)
			{
				var student = ReadStudentDetails();
				students.Add(student);
			}

			students = students.Where(a => a.AverageGrade >= 5.00).OrderBy(a => a.Name).ThenByDescending(a => a.AverageGrade).ToList();

			foreach (var student in students)
			{
				Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
			}
		}

		private static Student ReadStudentDetails()
		{
			var studentInput = Console.ReadLine().Split();
			var name = studentInput[0];
			var grades = studentInput.Skip(1).Select(double.Parse).ToArray();

			var student = new Student(name, grades);
			return student;
		}
	}

	public class Student
	{
		private List<double> grades;

		public Student(string name, IEnumerable<double> grades)
		{
			this.Name = name;
			this.Grades = grades;
		}

		public string Name { get; set; }

		public IEnumerable<double> Grades
		{
			get
			{
				return new List<double>(this.grades);
			}

			set
			{
				this.grades = new List<double>(value);
			}
		}

		public double AverageGrade => this.Grades.Average();
	}
}