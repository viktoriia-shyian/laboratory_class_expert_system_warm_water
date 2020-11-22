using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    public class Rulebase
    {
        public int Id { get; set; }
        public Rule A { get; set; }
        public Rule P { get; set; }
        public string FuctionMessage { get; set; }
        public Fact FactFuctionInput { get; set; }

        public Rulebase()
        {

        }

        public Rulebase(int id, Rule a, Rule p, string fuction_message, 
            Fact fact_fuction_input)
        {
            Id = id;
            A = a;
            P = p;
            FuctionMessage = fuction_message;
            FactFuctionInput = fact_fuction_input;
        }


        public string Fuction()
        {
            foreach (RelationRow r in KnowledgeBase.RelationRows)
            {
                if (r.function_name == FuctionMessage)
                {
                    bool condition_match = true;

                    foreach (Fact f in r.startState)
                    {
                        if (KnowledgeBase.FactualBasis.ElementAt(
                            KnowledgeBase.GetIndexInListFactualBasisById(f.Id)).Value != f.Value
                            )
                            condition_match = false;
                    }

                    if (condition_match)
                    {
                        r.ApplyChanges();
                    }
                }
            }
            //KnowledgeBase.ReSetFactualBasis(changed_fact);

            return FuctionMessage + "(" + FactFuctionInput.ToString() + ")" + Environment.NewLine +
                KnowledgeBase.FactualBasisToString();
        }
    }
}
