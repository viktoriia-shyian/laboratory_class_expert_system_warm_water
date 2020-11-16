using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    public class Operator : RuleConstituent
    {

        public Operator()
        {

        }

        public Operator(OperatorType type) : base(type)
        {

        }


        public override int Calculate(RuleConstituent a)
        {
            return TypeOp.Calculate(a);
        }

        public override int Calculate(int a, int b)
        {
            return TypeOp.Calculate(a, b);
        }

        public override string ToString()
        {
            if (TypeOp == OperatorType.Negation)
            {
                return "¬";

            }
            else
            if (TypeOp == OperatorType.Conjunction)
            {
                return "∧";

            }
            else
            if (TypeOp == OperatorType.Disjunction)
            {
                return "∨";
            }

            throw new Exception("Not so operator");
        }

    }

    public enum OperatorType
    {
        Conjunction, //∧
        Disjunction, //∨
        Negation //¬
    }

    static class Extensions
    {

        public static int Calculate(this OperatorType negation, RuleConstituent a)
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

        public static int Calculate(this OperatorType operation_type, int a, int b)
        {
            switch (operation_type)
            {
                case OperatorType.Conjunction:
                    return a & b;

                case OperatorType.Disjunction:
                    return a | b;

                default:
                    throw new Exception("Operator type doesn't have implementation");

            }
        }
    }
}
