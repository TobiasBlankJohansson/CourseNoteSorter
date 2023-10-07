using CourseNoteSorter.Abstrect;
using CourseNoteSorter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Commands
{
    internal class LoadFromBinaryCommand : ICommand
    {
        private ILoadable _loadTo;
        private string _file;
        public LoadFromBinaryCommand(ILoadable loadTo, string file)
        {
            _loadTo = loadTo;
            _file = file;
        }
        public void Execute()
        {
            using(BinaryReader br = new BinaryReader(File.Open(_file, FileMode.Open)))
            {
                var signatur = (SignaturType)br.ReadInt32();
                if (_loadTo.Signatur != signatur)
                    throw new ArgumentException("Wrong signatur type");
                _loadTo.Load(br);
            }
        }
    }
}
