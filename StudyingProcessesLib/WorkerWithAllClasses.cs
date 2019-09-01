using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudyingProcessesLib
{
	public class WorkerWithAllClasses
	{
		//добавление новой группы, лектора к ней и студентов
		public void AddingNewStudentGroup()
		{
			string groupName;
			string lectorName;
			string lectorDegree = "";
			Student[] students = new Student[0];

			Console.WriteLine();
			
			//название группы
			do
			{
				Console.Write("Name of the group: ");
				groupName = Console.ReadLine();
			} while (groupName == null);

			Console.WriteLine();

			//имя лектора
			do
			{
				Console.Write("Name of the lector: ");
				lectorName = Console.ReadLine();
			} while (lectorName == null);

			//степень лектора
			Console.WriteLine();
			Console.WriteLine("Chose one of 3 degrees for the lector");
			Console.WriteLine("1 - assistant professor");
			Console.WriteLine("2 - lector");
			Console.WriteLine("3 - postgraduate");
			int degree;
			do
			{
				Console.Write("Lectors degree (digit): ");
			} while (!int.TryParse(Console.ReadLine(), out degree) || degree == 0 || degree > 3);

			if (degree == 1)
			{
				lectorDegree = "Assistant professor";
			}
			else if (degree == 2)
			{
				lectorDegree = "Lector";
			}
			else if (degree == 3)
			{
				lectorDegree = "postgraduate";
			}

			//добавление студентов основываясь на степень лектора (доцент - 20 студентов, лектор - 15 студентов, аспирант - 5)
			Console.WriteLine();
			if (degree == 1)
			{
				Array.Resize(ref students, 20);
				for (int i = 0; i < 20; i++)
				{
					string studentName;
					do
					{
						Console.Write($"Name of the {i+1}st student: ");
						studentName = Console.ReadLine();
					} while (studentName == null);
					students[i] = new Student(studentName, groupName);
				}
			}
			else if (degree == 2)
			{
				Array.Resize(ref students, 15);
				for (int i = 0; i < 15; i++)
				{
					string studentName;
					do
					{
						Console.Write($"Name of the {i+1}st student: ");
						studentName = Console.ReadLine();
					} while (studentName == null);
					students[i] = new Student(studentName, groupName);
				}
			}
			else if (degree == 3)
			{
				Array.Resize(ref students, 5);
				for (int i = 0; i < 5; i++)
				{
					string studentName;
					do
					{
						Console.Write($"Name of the {i+1}st student: ");
						studentName = Console.ReadLine();
					} while (studentName == null);
					students[i] = new Student(studentName, groupName);
				}
			}

			//добавление в темповые листы
			ListsOfClasses.Lectors.Add(new Lector(lectorName, groupName, lectorDegree));
			ListsOfClasses.Groups.Add(new Group(groupName, new Lector(lectorName, groupName, lectorDegree), students));
			foreach (var student in students)
			{
				ListsOfClasses.Students.Add(student);
			}
		}

		//вывод студенттов
		public void OutputStudents()
		{
			foreach(var student in ListsOfClasses.Students)
			{
				Console.WriteLine();
				Console.WriteLine(student.ToString());
			}
		}

		//вывод лекторов
		public void OutputLectors()
		{
			foreach (var lector in ListsOfClasses.Lectors)
			{
				Console.WriteLine();
				Console.WriteLine(lector.ToString());
			}
		}
		
		//вывод групп со студентами и лектором
		public void OutputAllGroups()
		{
			foreach (var group in ListsOfClasses.Groups)
			{
				Console.WriteLine();
				Console.WriteLine(group.ToString());
			}
		}
	}
}
