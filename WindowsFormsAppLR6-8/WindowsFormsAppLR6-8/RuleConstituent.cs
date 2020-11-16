using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    public abstract class RuleConstituent
    {
        #region properties

        public int Id { get; set; }

        public int Value { get; set; }

        public string Description { get; set; }

        public OperatorType TypeOp { get; set; }

        #endregion

        #region constructor

        public RuleConstituent()
        {

        }

        public RuleConstituent(OperatorType type)
        {
            this.TypeOp = type;
        }

        public RuleConstituent(int id, int value, string description)
        {
            Id = id;
            Value = value;
            Description = description;
        }

        public RuleConstituent(int id, int value, string description, OperatorType operator_type)
        {
            Id = id;
            Value = value;
            Description = description;
            TypeOp = operator_type;
        }

        #endregion

        public virtual int Calculate(RuleConstituent a)
        {
            throw new Exception("Doesn't have implementation");
        }

        public virtual int Calculate(RuleConstituent a, RuleConstituent b)
        {
            throw new Exception("Doesn't have implementation");
        }
    }
}
