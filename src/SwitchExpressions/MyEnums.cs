using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchExpressions
{
    public class MyEnums
    {
        public enum State
        {
            Running, Suspended, NotRunning
        };

        public enum Transition
        {
            Suspend, Resume, Terminate, Activate
        };

        public enum Ignition
        {
            On, Off
        };
    }
}
