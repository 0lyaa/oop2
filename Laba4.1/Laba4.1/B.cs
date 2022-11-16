using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4._1
{
    internal class B
    {
        public string name = "B";
        public virtual string PrintInfo()
        {
            return "It's a base class B";
        }

        public virtual void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
