using CourseNoteSorter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Abstract
{
    internal interface ILoadable
    {
        public SignaturType Signatur { get; }
        public void Load(BinaryReader binaryReader);
    }
}
