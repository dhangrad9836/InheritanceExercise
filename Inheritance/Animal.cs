using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        //default constructor
        public Animal() { }

        //properties        
        public string Name { get; set; }
        public bool CanSpeak { get; set; }
        public bool CanWalk { get; set; }
        public string Eat { get; set; }

    }
}
