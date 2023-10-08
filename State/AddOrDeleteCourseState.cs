using CourseNoteSorter.Abstract;
using CourseNoteSorter.Commands;
using CourseNoteSorter.Managers;
using CourseNoteSorter.Statics;
using System.Xml.Linq;

namespace CourseNoteSorter.State
{
    class AddOrDeleteCourseState : IState
    {
        private Manager _manager;
        private IState _previus;
        public AddOrDeleteCourseState(Manager manager, IState previus)
        {
            _manager = manager;
            _previus = previus;
        }
        public ICommand GetCommand()
        {
            var command = UserInput.GetString();

            if (command == "1")
            {
                return new AddCourseCommand(_manager);
            }
            if (command == "2")
            {
                return new SwitchStateCommand(_manager, new DeleteCourseState(_manager,this));
            }
            if (command == "3")
            {
                return new SwitchStateCommand(_manager,_previus);
            }

            return new InvalidCommand();
        }

        public void Render()
        {
            Console.Clear();
            Console.WriteLine("Add or change course");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] - Add course");
            Console.WriteLine("[2] - Delete course");
            Console.WriteLine("[3] - Back");
            Console.WriteLine("------------------------------------");
            Console.Write(">");
        }
    }
}
