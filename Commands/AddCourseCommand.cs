using CourseNoteSorter.Abstract;
using CourseNoteSorter.Managers;
using CourseNoteSorter.Course;
using CourseNoteSorter.Statics;

namespace CourseNoteSorter.Commands
{
    class AddCourseCommand : ICommand
    {
        private BasicCourse _Course;
        private Manager _manager;
        public AddCourseCommand(Manager manager)
        {
            _Course = new BasicCourse();
            _manager = manager;
        }
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Add course");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Name of course");
            Console.Write(">");
            var courseName = UserInput.GetString();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Description of course");
            Console.Write(">");
            var courseDescription = UserInput.GetString();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Owner of course");
            Console.Write(">");
            var courseOwner = UserInput.GetString();
            Console.WriteLine("------------------------------------");

            _Course.Name = courseName;
            _Course.Description = courseDescription;
            _Course.Owner = courseOwner;
            var filePath = string.Format(@"{0}\{1}", _manager.FilePathManager.FilePath("CoursePath"), _Course.Name);
            SaveToBinaryCommand save = new SaveToBinaryCommand(_Course, filePath);
            save.Execute();
            Console.WriteLine("Course {0} saved", _Course.Name);

        }
    }
}
