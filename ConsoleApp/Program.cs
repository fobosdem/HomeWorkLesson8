using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyingProcessesLib;

namespace ConsoleApp
{
	class Program
	{
		static void Main()
		{
			do
			{
				WorkerWithAllClasses worker = new WorkerWithAllClasses();
				Console.WriteLine("Hello, here you can add Studets, Lectors and Groups and you can sum them");
				Console.WriteLine("Chose one of the menu");
				Console.WriteLine("1 - add new group with lector and students");
				Console.WriteLine("2 - show students list with groups");
				Console.WriteLine("3 - show all lectors with there groups");
				Console.WriteLine("4 - show all groups with there Lectors and Students");
				Console.WriteLine("9 - Clear console window");
				int menuNumber;
				do
				{
					Console.Write("Menu = ");
				} while (!int.TryParse(Console.ReadLine(), out menuNumber) || menuNumber == 0);
				switch (menuNumber)
				{
					case 1:
						worker.AddingNewStudentGroup();
						break;
					case 2:
						worker.OutputStudents();
						break;
					case 3:
						worker.OutputLectors();
						break;
					case 4:
						worker.OutputAllGroups();
						break;
					case 9:
						Console.Clear();
						break;
					}

				Console.WriteLine("Press any key to continue, ESC to exit programm");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}
