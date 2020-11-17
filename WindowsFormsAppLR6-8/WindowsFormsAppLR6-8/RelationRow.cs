using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    public class RelationRow
    {
        public string function_name;
        public List<Fact> startState;
        public List<ChangeFactInfo> changeFactInfos;

        public void ApplyChanges()
        {
            foreach (ChangeFactInfo c in changeFactInfos)
            {
                KnowledgeBase.FactualBasis.ElementAt(
                    KnowledgeBase.GetIndexInListFactualBasisById(c.fact_id)).Value = c.end_state;
            }
        }

        public string StartStateToString()
        {
            string str = "";

            foreach (Fact f in startState)
            {
                str += f.ToString() + ";";
            }

            return str;
        }

        public string StartStateValuesToString()
        {
            string str = "";

            foreach (Fact f in startState)
            {
                str += f.Value + ";";
            }

            return str;
        }

        public string ChangeFactInfosToString()
        {
            string str = "";

            foreach (ChangeFactInfo c in changeFactInfos)
            {
                str += KnowledgeBase.FactualBasis.ElementAt(
                    KnowledgeBase.GetIndexInListFactualBasisById(c.fact_id)).ToString() + ";";
            }

            return str;
        }

        public string ChangeFactInfosValuesStartStateToString()
        {
            string str = "";

            foreach (ChangeFactInfo c in changeFactInfos)
            {
                str += c.start_state + ";";
            }

            return str;
        }

        public string ChangeFactInfosValuesEndStateToString()
        {
            string str = "";

            foreach (ChangeFactInfo c in changeFactInfos)
            {
                str += c.end_state + ";";
            }

            return str;
        }

        public RelationRow()
        {

        }

        public RelationRow(string function_name, List<Fact> startState, List<ChangeFactInfo> changeFactInfos)
        {
            this.function_name = function_name;
            this.startState = startState;
            this.changeFactInfos = changeFactInfos;
        }

    }
    public class ChangeFactInfo
    {
        public int fact_id;
        public int start_state;
        public int end_state;

        public ChangeFactInfo()
        {

        }

        public ChangeFactInfo(int fact_id, int start_state, int end_state)
        {
            this.fact_id = fact_id;
            this.start_state = start_state;
            this.end_state = end_state;
        }
    }

}

