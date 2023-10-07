using CourseNoteSorter.Abstrect;
using CourseNoteSorter.Commands;
using CourseNoteSorter.Managers;
using CourseNoteSorter.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Commands
{
    internal class ChooseCourseSavePathCommand : ICommand
    {
        private Manager _manager;
        private FilePathManager _filePath;
        public ChooseCourseSavePathCommand(Manager manager)
        {
            _manager = manager;
            _filePath = _manager.FilePathManager;
        }
        public void Execute()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.Write("Folder path >");
                var filePath = UserInput.GetString();

                if (Directory.Exists(filePath))
                {
                    _manager.FilePathManager.ChangePath("NotePath", filePath);
                    new SaveToBinaryCommand(_manager, _filePath.FilePath("NotePathSave")).Execute();
                    Console.WriteLine("Path saved");
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Filepath {0} do not exist", filePath);
                }
            }
        }
    }
}
