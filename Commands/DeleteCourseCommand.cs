using CourseNoteSorter.Abstrect;
using CourseNoteSorter.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Commands
{
    internal class DeleteCourseCommand : ICommand
    {
        string _fileName;
        FilePathManager _filePath;
        public DeleteCourseCommand(string fileName, FilePathManager filePath)
        {
            _fileName = fileName;
            _filePath = filePath;
        }
        public void Execute()
        {
            File.Delete(string.Format(@"{0}\{1}", _filePath.FilePath("CoursePath"), _fileName));
        }
    }
}
