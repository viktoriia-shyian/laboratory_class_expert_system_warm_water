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
        public Fact(Fact fact) : base(fact.Id, fact.Value, fact.Description)
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
            Value = TypeOp.Calculate(KnowledgeBase.FactualBasis.ElementAt(
                KnowledgeBase.GetIndexInListFactualBasisById(Id)));

            return Value;
        }

        public override string ToString()
        {
            return "f" + (Id + 1);
        }

    }
}
