using Question1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Q1
{
	public class Course
	{
		public int Id { get; set; }
		public string Name { get; set; }
		private Dictionary<Student, double> Students { get; set; }

		public delegate void NumberOfStudentChangeHandler(int oldNumber, int newNumber);
		public event NumberOfStudentChangeHandler OnNumberOfStudentChange;

		public Course(int id, string name)
		{
			Id = id;
			Name = name;
			Students = new Dictionary<Student, double>();
		}

		public void AddStudent(Student student, double grade)
		{
			int oldCount = Students.Count;
			Students.Add(student, grade);
			int newCount = Students.Count;
			OnNumberOfStudentChange?.Invoke(oldCount, newCount);
		}

		public void RemoveStudent(int studentId)
		{
			int oldCount = Students.Count;
			var student = Students.Keys.FirstOrDefault(s => s.Id == studentId);
			if (student != null)
			{
				Students.Remove(student);
				int newCount = Students.Count;
				OnNumberOfStudentChange?.Invoke(oldCount, newCount);
			}
		}

		public override string ToString()
		{
			string result = $"Course ID: {Id}, Name: {Name}\nStudents:\n";
			foreach (var student in Students)
			{
				result += $"{student.Key}, Grade: {student.Value}\n";
			}
			return result;
		}
	}
}
