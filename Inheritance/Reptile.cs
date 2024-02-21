using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        //constructor
        public Reptile() 
        {
            Name = "Reptile";
            CanSpeak = false;
            CanWalk = true;
            Eat = "non-vegetarian";
        }

        // give this class 4 members that are specific to Reptile
        //auto properties
        public string ColdBlooded { get; set; }
        public bool HasDrySkin { get; set; }
        public bool HasMoreThanOneLung { get; set; }        
        public bool LayEggs { get; set; }

    }
}
