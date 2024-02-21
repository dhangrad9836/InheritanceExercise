using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //child inhereits from parent class
    // Set this class to inherit from your Animal Class
    public class Bird : Animal
    {
        //constructor
        public Bird() 
        {
            Name = "Bird";
            CanSpeak = true;
            CanWalk = true;
            Eat = "Seeds";
        }
        

        // give this class 4 members that are specific to Bird
        public bool CanFly { get; set; }
        public string BeakSize { get; set; }
        public string BeakColor { get; set; }
        public string FeatherColor { get; set; }



    }
}
