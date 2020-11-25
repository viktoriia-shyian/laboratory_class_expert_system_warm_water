using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLR6_8
{
    public class KnowledgeBase
    {
        public static List<Fact> FactualBasis = new List<Fact>();

        public List<Rulebase> RuleBases = new List<Rulebase>();

        public static List<List<Fact>> OppositeFacts = new List<List<Fact>>();

        public static Fact TargetFact = new Fact();

        public static List<RelationRow> RelationRows = new List<RelationRow>();

        public List<Fact> FactualBasisOldState = new List<Fact>();
        
        public string Report = "";
        
        public string ReportForBeliefSystem = "";


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

        public static int GetIndexInListFactualBasisById(int id)
        {
            for (int i = 0; i < FactualBasis.Count; i++)
            {
                if (FactualBasis.ElementAt(i).Id == id)
                    return i;
            }

            throw new Exception("There is no fact with id = " + id);
        }

        public static void ReSetFactualBasis(Fact fact)
        {
            int result = 0;

            if (fact.Value == 0)
            {
                result = 1;
            }

            foreach(List<Fact> facts in OppositeFacts)
            {
                foreach (Fact f in facts)
                {
                    if (f.Id == fact.Id) {

                        for (int j = 0; j < facts.Count; j++)
                        {
                            Fact changable = facts.ElementAt(j);

                            if (changable.Id != fact.Id)
                            {
                                int index_in_factual_basis = GetIndexInListFactualBasisById(changable.Id);

                                FactualBasis.ElementAt(index_in_factual_basis).Value = result;
                            }
                        }
                    }
                }
            }
        }

        public string StartCalculations()
        {
            Report = "";
            ReportForBeliefSystem = "";

            Report += FactualBasisToString() + Environment.NewLine;
            ReportForBeliefSystem += FactualBasisStartStateToString() + Environment.NewLine;

            for (int i = 0, step = 1; i < RuleBases.Count; i++, step++)
            {
                Rulebase rulebase = RuleBases.ElementAt(i);
                Report += step + ". Продукція " + (rulebase.Id + 1) + Environment.NewLine;
                ReportForBeliefSystem += step + ". Продукція " + (rulebase.Id + 1) + Environment.NewLine;


                if (rulebase.P.Calculate() == 1)
                {
                    step++;
                    Report += step + ". P = " + rulebase.P.ToString() + " = 1" + Environment.NewLine;
                    ReportForBeliefSystem += step + ". Блок P = 1" + Environment.NewLine;

                    if (rulebase.A.Calculate() == 1)
                    {
                        step++;
                        Report += step + ". A = " + rulebase.A.ToString() + " = 1" + Environment.NewLine;
                        ReportForBeliefSystem += step + ". Переходимо до ядра продукції (оскільки Р=1) намагаємося його активувати: " +
                            "А=1 → ядро продукції " + rulebase.Id + " буде активоване." + Environment.NewLine;

                        SetOldState();
                        
                        step++;
                        Report += step + ". Функція " + rulebase.Fuction() + Environment.NewLine;// "\n";
                        ReportForBeliefSystem += step + ". " + CheckStateDifferences(rulebase.FuctionMessage);
                        i = -1;

                    }
                    else
                    {
                        step++;
                        Report += step + ". A = " + rulebase.A.ToString() + " = 0" + Environment.NewLine;
                        ReportForBeliefSystem += step + ". Переходимо до ядра продукції (оскільки Р=1) намагаємося його активувати: " +
                            "А=0 → ядро продукції " + rulebase.Id + " не буде активоване. Перехід до наступної продукції. " + Environment.NewLine;

                    }

                }
                else
                {
                    step++;
                    Report += step + ". P = " + rulebase.P.ToString() + " = 0" + Environment.NewLine;
                    ReportForBeliefSystem += step + ". Блок P = 0" + Environment.NewLine;

                }

            }

            TargetFact.Value = 1;
            ReSetFactualBasis(TargetFact);
            Report += FactualBasisToString() + Environment.NewLine;
            ReportForBeliefSystem += "Цільвий стан був досягнутий: " + TargetFact.MessageStateTrue + Environment.NewLine;

            return Report;
        }

        public static string FactualBasisToString()
        {
            string str = "";

            foreach (Fact f in FactualBasis)
            {
                str += f.ToString() + "=" + f.Value + "; ";
            }

            return str;
        }

        public static string FactualBasisStartStateToString()
        {
            string str = "Початкові умови: " + Environment.NewLine;

            foreach (Fact f in FactualBasis)
            {
                if (f.Value == 1 && f.Id != 7)
                {
                    str += f.Description + ", ";
                }
            }
            str = str.Remove(str.Length - 2, 2);

            return str;
        }

        string CheckStateDifferences(string function_name)
        {
            string str1 = "Була викликана функція " + function_name + ". ";
            str1 += "Внаслідок дії функції набули дії такі зміни:" + Environment.NewLine;
            string str = "";

            for (int i = 0; i < FactualBasis.Count; i++)
            {
                if (FactualBasisOldState.ElementAt(i).Value != FactualBasis.ElementAt(i).Value)
                {
                    if (FactualBasis.ElementAt(i).Value == 0)
                    {
                        str += FactualBasis.ElementAt(i).MessageStateFalse + Environment.NewLine; ;
                    }
                    else
                    {
                        str += FactualBasis.ElementAt(i).MessageStateTrue + Environment.NewLine;
                    }
                }
            }

            if (str.Equals(""))
            {
                str = "Без змін" + Environment.NewLine;
            }
            else
            {
                str = str1 + str;
                str.Remove(str.Length - 1, 1);
            }

            return str;
        }

        void SetOldState()
        {
            FactualBasisOldState = new List<Fact>();

            foreach(Fact f in FactualBasis)
            {
                FactualBasisOldState.Add(new Fact(f));

            }
        }



    }
}
