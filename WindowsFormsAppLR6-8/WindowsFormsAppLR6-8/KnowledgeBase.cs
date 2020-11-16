using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    public class KnowledgeBase
    {
        public static List<Fact> FactualBasis = new List<Fact>();

        public List<Rulebase> RuleBases = new List<Rulebase>();

        public static List<List<Fact>> OppositeFacts = new List<List<Fact>>();

        public static Fact TargetFact = new Fact();

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

        public static int GetIndexInListFactualBasisById(int id)
        {
            for (int i = 0; i < FactualBasis.Count; i++)
            {
                if (FactualBasis.ElementAt(i).Id == id)
                    return i;
            }

            throw new Exception("There is no fact with id = " + id);
        }

        public static void ReSetFactualBasis(Fact fact)
        {
            int result = 0;

            if (fact.Value == 0)
            {
                result = 1;
            }

            foreach(List<Fact> facts in OppositeFacts)
            {
                foreach (Fact f in facts)
                {
                    if (f.Id == fact.Id) {

                        for (int j = 0; j < facts.Count; j++)
                        {
                            Fact changable = facts.ElementAt(j);

                            if (changable.Id != fact.Id)
                            {
                                int index_in_factual_basis = GetIndexInListFactualBasisById(changable.Id);

                                FactualBasis.ElementAt(index_in_factual_basis).Value = result;
                            }
                        }
                    }
                }
            }
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

            TargetFact.Value = 1;
            ReSetFactualBasis(TargetFact);

            return steps;
        }




    }
}
