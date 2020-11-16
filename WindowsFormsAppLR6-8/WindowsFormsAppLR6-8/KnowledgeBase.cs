using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    class KnowledgeBase
    {
        public List<Fact> FactualBasis { get; set; }

        public List<Rulebase> RuleBases { get; set; }

        public List<List<Fact>> OppositeFacts { get; set; }

        public KnowledgeBase()
        {

        }

        public Fact FindFactById(int id)
        {
            foreach (Fact f in FactualBasis)
            {
                if (f.Id == id)
                    return f;
            }

            throw new Exception("There is no fact with id = " + id);
        }



    }
}
