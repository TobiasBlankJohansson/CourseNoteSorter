using CourseNoteSorter.Abstract;
using CourseNoteSorter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Course
{
    internal class BasicCourse : ICourse, ILoadable, ISaveable
    {
        private string _name;
        private string _description;
        private string _owner;
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Owner { get { return _owner; } set { _owner = value; } }

        public SignaturType Signatur { get { return SignaturType.Course; } }
        public void Load(BinaryReader binaryReader)
        {
            _name = binaryReader.ReadString();
            _description = binaryReader.ReadString();
            _owner = binaryReader.ReadString();
        }
        public void Save(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(_name);
            binaryWriter.Write(_description);
            binaryWriter.Write(_owner);
        }
    }
}
