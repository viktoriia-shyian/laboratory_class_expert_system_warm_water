using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    class Rule
    {
        public List<RuleConstituent> Expression { get; set; }

        public void AddConstituent(RuleConstituent constituent)
        {
            if (typeof(Fact) == constituent.GetType())
            {
                Console.WriteLine("Added fact");

            }
            else 
            if (typeof(Operator) == constituent.GetType())
            {
                Console.WriteLine("Added Operator");

            }
            else
            {
                Console.WriteLine("Doesn't work");

            }
        }

        public int Calculate()
        {
            return 0;
        }


    }
}
