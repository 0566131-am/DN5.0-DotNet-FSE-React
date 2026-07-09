// COMMAND PATTERN
// Encapsulates a request as an object, allowing parameterization of clients
// with different requests, queuing, and undo/redo support.
using System;
using System.Collections.Generic;

namespace Patterns.Behavioral.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class Light
    {
        public string Name { get; }
        public Light(string name) => Name = name;

        public void On() => Console.WriteLine($"{Name} light is ON");
        public void Off() => Console.WriteLine($"{Name} light is OFF");
    }

    public class LightOnCommand : ICommand
    {
        private readonly Light _light;
        public LightOnCommand(Light light) => _light = light;

        public void Execute() => _light.On();
        public void Undo() => _light.Off();
    }

    public class LightOffCommand : ICommand
    {
        private readonly Light _light;
        public LightOffCommand(Light light) => _light = light;

        public void Execute() => _light.Off();
        public void Undo() => _light.On();
    }

    // Invoker - doesn't know the details of the operation, just calls Execute/Undo
    public class RemoteControl
    {
        private readonly Stack<ICommand> _history = new();

        public void PressButton(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void PressUndo()
        {
            if (_history.Count > 0)
                _history.Pop().Undo();
            else
                Console.WriteLine("Nothing to undo.");
        }
    }

    class Program
    {
        static void Main()
        {
            var livingRoomLight = new Light("Living Room");
            var remote = new RemoteControl();

            remote.PressButton(new LightOnCommand(livingRoomLight));
            remote.PressButton(new LightOffCommand(livingRoomLight));

            remote.PressUndo(); // Undoes the OFF -> turns light back ON
            remote.PressUndo(); // Undoes the ON -> turns light back OFF
        }
    }
}
