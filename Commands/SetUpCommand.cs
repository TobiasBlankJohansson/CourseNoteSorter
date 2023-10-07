using CourseNoteSorter.Abstrect;
using CourseNoteSorter.Managers;
using CourseNoteSorter.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Commands
{
    internal class SetUpCommand : ICommand
    {
        private Manager _manager;
        public SetUpCommand(Manager manager)
        {
            _manager = manager;
        }
        public void Execute()
        {
            _manager.FilePathManager.Add("NotePath", "");

            var notePath = "NotePath";
            _manager.FilePathManager.Add("NotePathSave", notePath);
            if (!File.Exists(notePath))
            {
                File.Create(notePath).Dispose();
                new ChooseCourseSavePathCommand(_manager).Execute();
            }
            else
            {
                new LoadFromBinaryCommand(_manager, _manager.FilePathManager.FilePath("NotePathSave")).Execute();
            }

            var coureSavePath = "Course";
            if(!Directory.Exists(coureSavePath))
                Directory.CreateDirectory(coureSavePath);
            _manager.FilePathManager.Add("CoursePath", coureSavePath);
            new SwitchStateCommand(_manager, new MenuState(_manager)).Execute();
        }
    }
}
