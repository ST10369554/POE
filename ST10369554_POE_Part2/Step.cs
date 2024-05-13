using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10369554_POE_Part2
{
     public class Step
    {
        public string Description { get; set; }

        public Step(string description)
        {
            Description = description;
        }

        //overide TOstring method to display description
        public override string ToString()
        {
            return Description;
        }
    }
}
