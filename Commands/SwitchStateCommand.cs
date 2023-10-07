using CourseNoteSorter.Abstrect;
using CourseNoteSorter.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNoteSorter.Commands
{
    internal class SwitchStateCommand : ICommand
    {
        private Manager _manager;
        private IState _state;
        public SwitchStateCommand(Manager manager, IState state) 
        {
            _manager = manager;
            _state = state;
        }
        public void Execute()
        {
            _manager.StateManager.SwitchState(_state);
        }
    }
}
