using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Abstract
{
    internal interface ICourse
    {
        string Name { get; }
        string Description { get; }
        string Owner { get; }
    }
}
