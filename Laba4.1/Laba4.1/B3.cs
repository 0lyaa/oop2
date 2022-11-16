using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4._1
{
    internal class B3 : B
    {


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string PrintInfo()
        {
            return "It's a child class B3";
        }

        public override void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
