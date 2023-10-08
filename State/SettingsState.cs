using CourseNoteSorter.Abstract;
using CourseNoteSorter.Commands;
using CourseNoteSorter.Managers;
using CourseNoteSorter.Statics;

namespace CourseNoteSorter.State
{
    internal class SettingsState : IState
    {
        private Manager _manager;
        private IState _previousState;
        public SettingsState(Manager manager, IState previousState)
        {
            _manager = manager;
            _previousState = previousState;
        }
        public ICommand GetCommand()
        {
            var command = UserInput.GetString();
            
            if (command == "1")
            {
                
                return new ChooseCourseSavePathCommand(_manager);
            }
            if (command == "2")
            {
                return new SwitchStateCommand(_manager, _previousState);
            }
            return new InvalidCommand();
        }

        public void Render()
        {
            Console.Clear();
            Console.WriteLine("Settings");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[1] - Saving location lesson notes");
            Console.WriteLine("[2] - Back to menu");
            Console.WriteLine("------------------------------------");
            Console.Write(">");
        }
    }
}
