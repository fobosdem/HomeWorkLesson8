using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyingProcessesLib;

namespace StudyingProcessesLib
{
	public class Lector
	{
		public Lector(string name, string group, string degree)
		{
			Name = name;
			Group = group;
			Degree = degree;
		}

		public string Name { get; }
		public string Group { get; }
		public string Degree { get; }

		public override string ToString()
		{
			return $"Lector: {Name}; Degree: {Degree}; Group: {Group}";
		}
	}
}
