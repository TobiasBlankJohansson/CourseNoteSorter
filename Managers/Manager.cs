using CourseNoteSorter.Abstrect;
using CourseNoteSorter.Commands;
using CourseNoteSorter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Managers
{
    internal class Manager : ISaveable, ILoadable
    {
        private StateManager _stateManager;
        private FilePathManager _filePathManager;
        public SignaturType Signatur { get { return SignaturType.Manager; } }
        public StateManager StateManager { get { return _stateManager; } }
        public FilePathManager FilePathManager { get { return _filePathManager; } }
        public Manager(StateManager stateManager, FilePathManager filePathManager)
        {
            _stateManager = stateManager;
            _filePathManager = filePathManager;
        }
        public void Save(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(_filePathManager.FilePath("NotePath"));
        }
        public void Load(BinaryReader binaryReader)
        {
            _filePathManager.ChangePath("NotePath", binaryReader.ReadString());
        }
    }
}
