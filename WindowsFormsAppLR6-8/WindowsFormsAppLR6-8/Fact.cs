using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    public class Fact : RuleConstituent
    {
        #region constructor

        public Fact()
        {

        }

        public Fact(int id, int value, string description) : base(id, value, description)
        {

        }

        public Fact(int id, int value, OperatorType operator_type, string description) : base(id, value, description, operator_type)
        {

        }

        #endregion

        public override int Calculate()
        {
            return TypeOp.Calculate(this);
        }

        public override string ToString()
        {
            return "f" + Id;
        }

    }
}
