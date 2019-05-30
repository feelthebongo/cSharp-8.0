using System;
using System.Collections.Generic;
using System.Drawing;

namespace TargetTypedNewExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> musicians = new Dictionary<string, List<string>>
            {
                { "John", new List<string>() { "guitar", "bass" } }
            };
            //Dictionary<string, List<string>> musicians = new ()
            //{
            //    { "John", new () { "guitar", "bass" } }
            //};

            var ps = new[] { new Point(1, 2), new Point(2, 2), new Point(2, 4) };
            //Point[] ps = { new (1, 4), new (3,-2), new (9, 5) }; // all Points
        }
    }
}
