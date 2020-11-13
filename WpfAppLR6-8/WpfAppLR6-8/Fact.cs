using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLR6_8
{
    public class Fact : RuleConstituent
    {
        #region fields

        int id;
        bool value;
        bool logical_negation;
        string description;

        #endregion

        #region properties

        public int Id { get; set; }

        public int Value { get; set; }
        
        public string Description { get; set; }

        #endregion

        #region constructor

        public Fact()
        {

        }

        public Fact(int id, bool value, bool logical_negation, string description)
        {
            this.id = id;
            this.value = value;
            this.logical_negation = logical_negation;
            this.description = description;
        }

        #endregion

        public override string ToString()
        {
            return "f" + Id;
        }

    }
}
