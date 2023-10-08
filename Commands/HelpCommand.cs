using CourseNoteSorter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Commands
{
    internal class HelpCommand : ICommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Help");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Load course - Creates a text file in the corect folder");
            Console.WriteLine("Add or delete course - Creates a new course that can be loaded\nor delete a course that can be loaded");
            Console.WriteLine("Settings - Change where you whant to save your notes");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n\n\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
