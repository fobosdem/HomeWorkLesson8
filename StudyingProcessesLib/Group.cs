using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingProcessesLib
{
	public class Group
	{
		public Group(string name, Lector lector, Student[] students)
		{
			Name = name;
			Lector = lector;
			Students = students;
		}
		public string Name { get; }
		public Lector Lector { get; }
		public Student[] Students { get; }
		public override string ToString()
		{
			string result = $"Group: {Name}\r\n\tLector:\r\n\t\t{Lector.ToString()}\r\n\t\t\tStudents:";
			foreach(Student student in Students)
			{
				result += $"\r\n\t\t\t\t{student.ToString()}";
			}
			return result;
		}
	}
}
