using System;
using static SwitchExpressions.MyEnums;

namespace SwitchExpressions
{
    class Program
    {
        private static Transition transition = Transition.Resume;
        private static State state = State.Suspended;
        private static Ignition ignition = Ignition.On;

        static void Main(string[] args)
        {
            tupleSwitch();
            Console.ReadKey();

            switchExpression();
            Console.ReadKey();
        }

        static void tupleSwitch()
        {
            Console.WriteLine($"initial state: {Enum.GetName(typeof(State), state)}");

            switch (state, transition, ignition)
            {
                case (State.Running, Transition.Suspend, Ignition.On):
                    state = State.Suspended;
                    break;
                case (State.Suspended, Transition.Resume, Ignition.On):
                    state = State.Running;
                    break;
                case (State.Suspended, Transition.Terminate, Ignition.Off):
                    state = State.NotRunning;
                    break;
                case (State.NotRunning, Transition.Activate, Ignition.On):
                    state = State.Running;
                    break;
                default:
                    throw new InvalidOperationException();

            }

            Console.WriteLine($"state after tuple switch: {Enum.GetName(typeof(State), state)}");
        }

        static void switchExpression()
        {
            state = State.Suspended;
            transition = Transition.Terminate;
            ignition = Ignition.Off;

            Console.WriteLine($"initial state: {Enum.GetName(typeof(State), state)}");

            state = (state, transition, ignition) switch
            {
                (State.Running, Transition.Suspend, Ignition.On) => State.Suspended,
                (State.Suspended, Transition.Resume, Ignition.On) => State.Running,
                (State.Suspended, Transition.Terminate, Ignition.Off) => State.NotRunning,
                (State.NotRunning, Transition.Activate, Ignition.On) => ,
                _ => throw new InvalidOperationException()
            };

            Console.WriteLine($"state after tuple switch: {Enum.GetName(typeof(State), state)}");
        }
    }
}
