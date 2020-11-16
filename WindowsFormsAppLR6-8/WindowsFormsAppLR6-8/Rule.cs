using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    class Rule
    {
        public List<RuleConstituent> RuleExpression { get; set; }

        public void AddConstituent(RuleConstituent constituent)
        {
            RuleExpression.Add(constituent);
        }

        public int Calculate()
        {
            for (int i = 0; i < RuleExpression.Count; i++)
            {
                RuleConstituent constituent = RuleExpression.ElementAt(i);

                if (typeof(Operator) == constituent.GetType())
                {
                    if (constituent.TypeOp == OperatorType.Negation)
                    {
                        constituent.Calculate(RuleExpression.ElementAt(i + 1));
                    }
                    else
                    {
                        constituent.Calculate(RuleExpression.ElementAt(i - 1), RuleExpression.ElementAt(i + 1));
                    }
                }

//                if (typeof(Fact) == constituent.GetType())

            }

            return 0;
        }


    }
}
