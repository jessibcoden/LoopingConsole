//Do NOT delete until done writing class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingConsole
{
    //POCO "Plain old C# Object" = class without any methods attached

    //classes are implicitly public
    class Child
    {
       //properties are implicitly private , the following format is considerd an "auto property"
        public string Name { get; set;}
        public bool Sick { get; set; }

        public string ForgeASickNote()
        {
            if (Sick)
            {
                return $"Please excuse {Name} from class today..";
            }

            //else is implied:
                return $"{Name}, you still have to go to shcool, quit faking. Love, Mom";
        }

    }
}
