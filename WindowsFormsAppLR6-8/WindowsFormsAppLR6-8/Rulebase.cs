using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    class Rulebase
    {
        public int Id { get; set; }
        public Rule A { get; set; }
        public Rule P { get; set; }
        public string FuctionMessage { get; set; }
        public Fact Fact { get; set; }

        public Rulebase()
        {

        }

        public Rulebase(int id, Rule a, Rule p, string fuction_message, Fact fact)
        {
            Id = id;
            A = a;
            P = p;
            FuctionMessage = fuction_message;
            Fact = fact;
        }


        public string Fuction()
        {
            return FuctionMessage + "(" + Fact.ToString() + ")";
        }
    }
}
