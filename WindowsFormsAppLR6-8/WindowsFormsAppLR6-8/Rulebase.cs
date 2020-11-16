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
        public Fact FactFuctionInput { get; set; }
        public Fact FactFuctionFluence { get; set; }

        public Rulebase()
        {

        }

        public Rulebase(int id, Rule a, Rule p, string fuction_message, 
            Fact fact_fuction_input, Fact fact_fuction_fluence)
        {
            Id = id;
            A = a;
            P = p;
            FuctionMessage = fuction_message;
            FactFuctionInput = fact_fuction_input;
            FactFuctionFluence = fact_fuction_fluence;
        }


        public string Fuction()
        {
            FactFuctionFluence.Value = OperatorType.Negation.Calculate(FactFuctionFluence);
            KnowledgeBase.ReSetFactualBasis();

            return FuctionMessage + "(" + FactFuctionInput.ToString() + ")";
        }
    }
}
