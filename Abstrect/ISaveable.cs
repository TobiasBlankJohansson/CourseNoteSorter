using CourseNoteSorter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Abstrect
{
    internal interface ISaveable
    {
        public SignaturType Signatur { get; }
        public void Save(BinaryWriter binaryWriter);
    }
}
