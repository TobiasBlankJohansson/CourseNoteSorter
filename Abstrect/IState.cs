﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Abstrect
{
    internal interface IState
    {
        ICommand GetCommand();
        void Render();
    }
}
