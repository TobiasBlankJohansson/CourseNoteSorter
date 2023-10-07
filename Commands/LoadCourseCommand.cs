using CourseNoteSorter.Abstrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseNoteSorter.Managers;


namespace CourseNoteSorter.Commands
{
    internal class LoadCourseCommand : ICommand
    {
        private ICourse _courseToLoad;
        private Manager _manager;
        private string _courseName;

        public LoadCourseCommand(ICourse courseToLoad, Manager manager, string courseName) 
        {
            _courseToLoad = courseToLoad;
            _manager = manager;
            _courseName = courseName;
        }
        public void Execute()
        {
            LoadFromBinaryCommand Lb = new LoadFromBinaryCommand((ILoadable)_courseToLoad, string.Format(@"{0}\{1}", _manager.FilePathManager.FilePath("CoursePath"),_courseName));
            Lb.Execute();

            var date = DateTime.Now.ToString("yyyy - MM - dd");
            var path = string.Format(@"{0}\{1}-{2}", _manager.FilePathManager.FilePath("NotePath"), _courseToLoad.Name, _courseToLoad.Description);
            Directory.CreateDirectory(path);
            path += string.Format(@"\{0}.txt", date);

            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(File.OpenWrite(path)))
                {
                    sw.WriteLine(string.Format("{0} by {1}\t\t\tDate: {2} ", _courseToLoad.Name, _courseToLoad.Owner, date));
                    sw.WriteLine("------------------------------------------------------------");
                }
                Console.WriteLine("File created");
            }
            else
            {
                Console.WriteLine("File already exist");
            }

            Console.WriteLine("\n\n\n\nPress any key...");
            Console.ReadKey();
        }
    }
}
