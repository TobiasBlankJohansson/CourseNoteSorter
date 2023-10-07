using CourseNoteSorter.Abstract;
using CourseNoteSorter.Commands;
using CourseNoteSorter.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.State
{
    internal class SetUpState : IState
    {
        private Manager _manager;
        public SetUpState(Manager manager) 
        {
            _manager = manager;
        }
        public ICommand GetCommand()
        {
            Console.ReadKey();
            return new SetUpCommand(_manager);
        }

        public void Render()
        {
            Console.WriteLine("Course Note Sorter by Tobias Johansson");
            Console.WriteLine("\n\n\nPress any key to continue...");
        }
    }
}
