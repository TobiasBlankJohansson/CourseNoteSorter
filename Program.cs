using CourseNoteSorter.Commands;
using CourseNoteSorter.Managers;
using CourseNoteSorter.State;

Manager manager = new Manager(new StateManager(), new FilePathManager());
manager.StateManager.Run(new SetUpState(manager));