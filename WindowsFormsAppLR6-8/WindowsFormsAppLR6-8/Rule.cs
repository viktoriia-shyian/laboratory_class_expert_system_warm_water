using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    public class Rule
    {
        public List<RuleConstituent> RuleExpression = new List<RuleConstituent>();

        public void AddConstituent(RuleConstituent constituent)
        {
            /*
            if (RuleExpression.Count > 0)
            {
                RuleConstituent last = RuleExpression.Last();

                if (last.GetType() == typeof(Operator) &&
                    last.TypeOp == OperatorType.Negation)
                {
                    RuleExpression.RemoveAt(RuleExpression.Count - 1);

                    constituent.TypeOp = OperatorType.Negation;
                }
            }
            */
            RuleExpression.Add(constituent);
        }

        public int Calculate()
        {
            int sum = 0;
            int index = 0;

            if (typeof(Operator) == RuleExpression.ElementAt(0).GetType() &&
                RuleExpression.ElementAt(0).TypeOp == OperatorType.Negation &&
                    typeof(Fact) == RuleExpression.ElementAt(1).GetType())
            {
                sum = RuleExpression.ElementAt(0).Calculate(
                    KnowledgeBase.FactualBasis.ElementAt(
                        KnowledgeBase.GetIndexInListFactualBasisById(
                                    RuleExpression.ElementAt(1).Id)));
                index = 2;
            }
            else
            if (typeof(Fact) == RuleExpression.ElementAt(0).GetType())
            {
                sum =
                    KnowledgeBase.FactualBasis.ElementAt(
                                KnowledgeBase.GetIndexInListFactualBasisById(
                                    RuleExpression.ElementAt(0).Id)).Value;
                index = 1;
            }


            for (int i = index; i + 1 < RuleExpression.Count; i++)
            {
                if (
                    i + 2 < RuleExpression.Count &&
                    typeof(Operator) == RuleExpression.ElementAt(i).GetType() &&
                    typeof(Operator) == RuleExpression.ElementAt(i + 1).GetType() &&
                    RuleExpression.ElementAt(i + 1).TypeOp == OperatorType.Negation &&
                    typeof(Fact) == RuleExpression.ElementAt(i + 2).GetType())
                {
                    int after_negation = RuleExpression.ElementAt(i + 1).Calculate(
                            KnowledgeBase.FactualBasis.ElementAt(
                            KnowledgeBase.GetIndexInListFactualBasisById(RuleExpression.ElementAt(i + 2).Id)));


                    sum = RuleExpression.ElementAt(i).Calculate(
                        sum,
                        after_negation);
                    i += 2;
                    /*
                        RuleExpression.ElementAt(i + 1).Calculate(
                            KnowledgeBase.FactualBasis.ElementAt(
                            KnowledgeBase.GetIndexInListFactualBasisById(RuleExpression.ElementAt(i + 2).Id))
                            ));*/
                }
                else
                if (
                    i + 1 < RuleExpression.Count &&
                    typeof(Operator) == RuleExpression.ElementAt(i).GetType() &&
                    typeof(Fact) == RuleExpression.ElementAt(i + 1).GetType())
                {
                    sum = RuleExpression.ElementAt(i).Calculate(
                        sum,
                        KnowledgeBase.FactualBasis.ElementAt(
                            KnowledgeBase.GetIndexInListFactualBasisById(RuleExpression.ElementAt(i + 1).Id)).Value
                            );
                    i++;
                }
                
                Console.WriteLine(sum);
            }

            return sum;
        }

        public override string ToString()
        {
            string str = "";

            foreach (RuleConstituent r in RuleExpression)
            {
                str += r.ToString();
            }

            return str;
        }

    }
}
