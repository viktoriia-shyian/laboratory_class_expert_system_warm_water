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

            RuleExpression.Add(constituent);
        }

        public int Calculate()
        {
            int sum = RuleExpression.ElementAt(0).Calculate();

            for (int i = 1; i + 1 < RuleExpression.Count; i++)
            {
                RuleConstituent constituent_pos_oper = RuleExpression.ElementAt(i);
                RuleConstituent constituent_pos_fact = RuleExpression.ElementAt(i + 1);

                if (typeof(Operator) == constituent_pos_oper.GetType() && 
                    typeof(Fact) == constituent_pos_fact.GetType())
                {

                    if (constituent_pos_fact.TypeOp != OperatorType.Negation)
                    {
                        sum = constituent_pos_oper.Calculate(
                            sum,
                            KnowledgeBase.FactualBasis.ElementAt(
                                KnowledgeBase.GetIndexInListFactualBasisById(constituent_pos_fact.Id)).Value
                                );

                    }
                    else
                    {
                        sum = constituent_pos_oper.Calculate(
                            sum,
                            constituent_pos_fact.Calculate());
                    }
                }
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
