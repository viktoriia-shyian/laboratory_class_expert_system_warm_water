using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLR6_8
{
    class Operator : RuleConstituent
    {
        OperatorType type;

        public Operator()
        {

        }

        public Operator(OperatorType type)
        {
            this.type = type;
        }

        public int Calculate(Fact a)
        {
            return type.Calculate(a);
        }

        public int Calculate(Fact a, Fact b)
        {
            return type.Calculate(a, b);
        }

    }

    enum OperatorType
    {
        Conjunction, //∧
        Disjunction, //∨
        Negation //¬
    }

    static class Extensions
    {
        
        public static int Calculate(this OperatorType negation, Fact a)
        {
            if (negation == OperatorType.Negation)
            {
                if (a.Value == 0)
                {
                    return 1;
                }
                else
                if (a.Value == 1)
                {
                    return 0;
                }
            }

            throw new Exception("Operator type isn't negation");
        }

        public static int Calculate(this OperatorType operation_type, Fact a, Fact b)
        {
            switch (operation_type)
            {
                case OperatorType.Conjunction:
                    return a.Value * b.Value;

                case OperatorType.Disjunction:
                    int disjunction = a.Value + b.Value;
                    if (disjunction == 2)
                    {
                        return 1;
                    }
                    
                    return a.Value + b.Value;

                default:
                    throw new Exception("Operator type doesn't have implementation");

            }
        }
    }

}
