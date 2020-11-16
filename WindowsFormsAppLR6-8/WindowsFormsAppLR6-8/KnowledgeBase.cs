using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    class KnowledgeBase
    {
        public static List<Fact> FactualBasis { get; set; }

        public List<Rulebase> RuleBases { get; set; }

        public List<List<Fact>> OppositeFacts { get; set; }

        public Fact TargetFact { get; set; }

        public KnowledgeBase()
        {

        }

        public Fact FindFactById(int id)
        {
            foreach (Fact f in FactualBasis)
            {
                if (f.Id == id)
                    return f;
            }

            throw new Exception("There is no fact with id = " + id);
        }

        public static void ReSetFactualBasis(int id)
        {

        }

        public string StartCalculations()
        {
            string steps = "";

            for(int i = 0, step = 1; i < RuleBases.Count; i++, step++)
            {
                Rulebase rulebase = RuleBases.ElementAt(i);
                steps += step + ". Продукція " + rulebase.Id + "\n";
                
                if (rulebase.P.Calculate() == 1)
                {
                    steps += step + ". P = 1\n";

                    if (rulebase.A.Calculate() == 1)
                    {
                        steps += step + ". A = 1\n";

                        steps += step + ". Функція " + rulebase.Fuction() + "\n";
                        i = 0;
                    }
                    else
                    {
                        steps += step + ". A = 0\n";

                    }

                }
                else
                {
                    steps += step + ". P = 0\n";

                }

            }
            
            ReSetFactualBasis(TargetFact.Id);
        }




    }
}
