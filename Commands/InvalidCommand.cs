using CourseNoteSorter.Abstrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Commands
{
    internal class InvalidCommand : ICommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Invalde\n\n\n");
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
