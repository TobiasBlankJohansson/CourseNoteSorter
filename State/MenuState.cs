using CourseNoteSorter.Abstrect;
using CourseNoteSorter.Commands;
using CourseNoteSorter.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.State
{
    internal class MenuState : IState
    {
        private Manager _manager;
        public MenuState(Manager manager)
        {
            _manager = manager;
        }

        public ICommand GetCommand()
        {
            var command = Console.ReadLine();
            if (command == "1")
            {
                return new SwitchStateCommand(_manager, new LoadCourseState(_manager, this));
            }
            if (command == "2")
            {
                return new SwitchStateCommand(_manager, new AddOrDeleteCourseState(_manager, this));
            }
            if (command == "3")
            {
                return new SwitchStateCommand(_manager, new SettingsState(_manager, this));
            }
            if (command == "4")
            {

            }
            return new InvalidCommand();
        }

        public void Render()
        {
            Console.Clear();
            Console.WriteLine("Course note sorter menu");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] - Load course");
            Console.WriteLine("[2] - Add or delete course");
            Console.WriteLine("[3] - Settings");
            Console.WriteLine("[4] - Help");
            Console.WriteLine("------------------------------------");
            Console.Write(">");
        }
    }
}
