using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingProcessesLib
{
    public class Student
    {
		public Student(string name, string group)
		{
			Name = name;
			Group = group;
		}
		public string Name { get; }
		public string Group { get; }
		public override string ToString()
		{
			return $"Student: {Name}; Group: {Group}";
		}
	}
}
