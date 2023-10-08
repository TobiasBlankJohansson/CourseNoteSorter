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
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Load course - Creates a new file of the chosen course");
            Console.WriteLine("Add and delete course - Creates a new course or\ndelete an existing one");
            Console.WriteLine("Settings - Change where the notes are saved");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("\n\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
