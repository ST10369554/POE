using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10369554_POE_Part1
{
    internal class Step
    {
        public string Description { get; set; }

        //overide TOstring method to display description
        public override string ToString()
        {
            return Description;
        }
    }
}
