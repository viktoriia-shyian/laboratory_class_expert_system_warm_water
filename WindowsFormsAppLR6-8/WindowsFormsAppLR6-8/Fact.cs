using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    public class Fact : RuleConstituent
    {
        #region properties

        public int Id { get; set; }

        public int Value { get; set; }

        public string Description { get; set; }

        public bool LogicalNegation { get; set; }

        #endregion

        #region constructor

        public Fact()
        {

        }

        public Fact(int id, int value, string description)
        {
            Id = id;
            Value = value;
            Description = description;
        }

        public Fact(int id, int value, bool logical_negation, string description)
        {
            Id = id;
            Value = value;
            LogicalNegation = logical_negation;
            Description = description;
        }

        #endregion

        public override string ToString()
        {
            return "f" + Id;
        }

    }
}
