using CourseNoteSorter.Abstrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Managers
{
    internal class StateManager
    {
        private IState _state;
        public void SwitchState(IState state)
        {
            _state = state;
        }
        public void Run(IState startingState)
        {
            _state = startingState;
            while (true)
            {
                _state.Render();
                var command = _state.GetCommand();
                command.Execute();
            }
        }
    }
}
