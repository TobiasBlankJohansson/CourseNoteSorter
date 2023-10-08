using CourseNoteSorter.Abstract;
using CourseNoteSorter.Commands;
using CourseNoteSorter.Managers;
using CourseNoteSorter.Course;
using CourseNoteSorter.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.State
{
    internal class LoadCourseState : IState
    {
        private Manager _manager;
        private IState _previus;
        private int _index;
        private List<string> _fileName;
        public LoadCourseState(Manager manager, IState state) 
        {
            _manager = manager;
            _previus = state;
            _fileName = new List<string>();
        }
        public ICommand GetCommand()
        {
            var command = UserInput.GetString();
            for (int i = 1; i < _index; i++)
            {
                if (command == i.ToString())
                {
                    return new LoadCourseCommand(new BasicCourse(), _manager, _fileName[i-1]);
                }
            }
            if (command == _index.ToString())
            {
                return new SwitchStateCommand(_manager, _previus);
            }
            return new InvalidCommand();
        }

        public void Render()
        {
            _index = 1;
            _fileName.Clear();

            Console.Clear();
            Console.WriteLine("Choose course to load");
            Console.WriteLine("------------------------------------");

            foreach (var item in new DirectoryInfo("Course").GetFiles())
            {
                Console.WriteLine("[{0}] - {1}", _index, item.Name);
                _fileName.Add(item.Name);
                _index++;
            }

            Console.WriteLine("\n\n\n------------------------------------");
            Console.WriteLine("[{0}] - Back", _index);
            Console.Write(">");
        }
    }
}
