using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLR6_8
{
    public partial class Form1 : Form
    {
        KnowledgeBase knowledge_base = new KnowledgeBase();

        public Form1()
        {
            InitializeComponent();
        }

        /*
        private void dataGridView_facts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_opposite_facts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        */

        private void button_update_facts_Click(object sender, EventArgs e)
        {
            KnowledgeBase.FactualBasis = new List<Fact>();

            for (int i = 0; i < dataGridView_facts.Rows.Count - 1; i++)
            {
                KnowledgeBase.FactualBasis.Add(ConvertRowToFact(dataGridView_facts.Rows[i]));
            }
        }

        private void button_add_selected_fact_to_rule_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell_fact in dataGridView_facts.SelectedCells)
            {
                int fact_index_row = cell_fact.RowIndex;

                foreach (DataGridViewCell cell in dataGridView_rulebases.SelectedCells)
                {
                    if (cell.Value == null)
                    {
                        cell.Value = "";
                    }

                    cell.Value += ConvertRowToFact(dataGridView_facts.Rows[fact_index_row]).ToString();
                }
            }
        }

        private Fact ConvertRowToFact(DataGridViewRow row)
        {
            Fact fact = new Fact(
                    Convert.ToInt32(row.Index),
                    Convert.ToInt32(row.Cells[0].Value),
                    row.Cells[1].Value.ToString());

            DataGridViewCell cell = row.Cells[2];
            if (cell.Value != null && cell.Value.Equals(CheckState.Checked))//CheckState.Checked
            {
                KnowledgeBase.TargetFact = fact;
            }

            return fact;
        }

        private void button_negation_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView_rulebases.SelectedCells)
            {
                cell.Value += "¬";
            }
        }

        private void button_conjunction_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView_rulebases.SelectedCells)
            {
                cell.Value += "∧";
            }
        }

        private void button_disjunction_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView_rulebases.SelectedCells)
            {
                cell.Value += "∨";
            }
        }

        private void button_update_knowledge_base_Click(object sender, EventArgs e)
        {
            if (KnowledgeBase.FactualBasis.Count == 0)
            {
                button_update_facts_Click(sender, e);
            }

            knowledge_base.RuleBases = new List<Rulebase>();

            for (int i = 0; i < dataGridView_rulebases.Rows.Count - 1; i++)
            {
                knowledge_base.RuleBases.Add(
                    ConvertRowToRulebase(dataGridView_rulebases.Rows[i])
                    );
            }
        }

        private Rulebase ConvertRowToRulebase(DataGridViewRow row)
        {
            return
                new Rulebase(
                    Convert.ToInt32(row.Index),
                    ConvertCellToRule(row.Cells[0]),
                    ConvertCellToRule(row.Cells[1]),
                    row.Cells[2].Value.ToString(),
                    ConvertCellToFact(row.Cells[3])
                    );
        }

        private Rule ConvertCellToRule(DataGridViewCell cell)
        {
            string temp = cell.Value.ToString();
            Rule rule = new Rule();

            for (int i = 0; i < temp.Length; i++)
            {
                switch (temp.ElementAt(i))
                {
                    case '¬':
                        rule.AddConstituent(new Operator(OperatorType.Negation));
                        break;
                    case '∧':
                        rule.AddConstituent(new Operator(OperatorType.Conjunction));
                        break;
                    case '∨':
                        rule.AddConstituent(new Operator(OperatorType.Disjunction));
                        break;
                    case 'f':
                        string id = temp.ElementAt(i + 1).ToString();
                        i += 2;

                        while (i < temp.Length && temp.ElementAt(i) != '¬' && temp.ElementAt(i) != '∧' && temp.ElementAt(i) != '∨')
                        {
                            id += temp.ElementAt(i);

                            i++;
                        }

                        i--;

                        rule.AddConstituent(knowledge_base.FindFactById(Convert.ToInt32(id) - 1));
                        break;
                }
            }

            return rule;
        }

        private Fact ConvertCellToFact(DataGridViewCell cell)
        {
            if (cell.Value == null)
            {
                return null;
            }

            string temp = cell.Value.ToString();
            temp = temp.Remove(0, 1);

            return knowledge_base.FindFactById(Convert.ToInt32(temp) - 1);
        }

        private void button_update_opposite_facts_Click(object sender, EventArgs e)
        {
            KnowledgeBase.OppositeFacts = new List<List<Fact>>();

            List<List<Fact>> list = new List<List<Fact>>();
            for (int i = 0; i < dataGridView_opposite_facts.Rows.Count - 1; i++)
            {
                string temp_str = dataGridView_opposite_facts.Rows[i].Cells[0].Value.ToString();
                List<Fact> temp_list = new List<Fact>();

                for (int j = 0; j < temp_str.Length; j++)
                {
                    if (temp_str.ElementAt(j).Equals("f"))
                    {
                        string val = "";
                        j++;

                        while (!temp_str.ElementAt(j).Equals(";"))
                        {
                            val += temp_str.ElementAt(j);

                            j++;
                        }

                        temp_list.Add(ConvertRowToFact(dataGridView_facts.Rows[Convert.ToInt32(val) - 1]));
                    }
                }

                list.Add(temp_list);
            }

            KnowledgeBase.OppositeFacts = list;
        }

        private void button_describe_algorithm_Click(object sender, EventArgs e)//next
        {
            KnowledgeBase.FactualBasis.ElementAt(0).MessageStateTrue = "вентиль гарячої води відкритий";
            KnowledgeBase.FactualBasis.ElementAt(0).MessageStateTrue = "вентиль гарячої води закритий";
            KnowledgeBase.FactualBasis.ElementAt(1).MessageStateTrue = "вентиль холодної води відкритий";
            KnowledgeBase.FactualBasis.ElementAt(1).MessageStateTrue = "вентиль холодної води закритий";
            KnowledgeBase.FactualBasis.ElementAt(2).MessageStateTrue = "вентиль гарячої води повністю відкритий";
            KnowledgeBase.FactualBasis.ElementAt(2).MessageStateTrue = "вентиль гарячої води не повністю відкритий";
            KnowledgeBase.FactualBasis.ElementAt(3).MessageStateTrue = "вентиль холодної води повністю відкритий";
            KnowledgeBase.FactualBasis.ElementAt(3).MessageStateTrue = "вентиль холодної води не повністю відкритий";
            KnowledgeBase.FactualBasis.ElementAt(4).MessageStateTrue = "вода стала гарячою";
            KnowledgeBase.FactualBasis.ElementAt(4).MessageStateTrue = "";
            KnowledgeBase.FactualBasis.ElementAt(5).MessageStateTrue = "вода стала холодною";
            KnowledgeBase.FactualBasis.ElementAt(5).MessageStateTrue = "";
            KnowledgeBase.FactualBasis.ElementAt(6).MessageStateTrue = "вода стала теплою";
            KnowledgeBase.FactualBasis.ElementAt(6).MessageStateTrue = "";

            KnowledgeBase.TargetFact.MessageStateTrue = "вода стала теплою";
            KnowledgeBase.TargetFact.MessageStateFalse = "";

            Form2 form = new Form2(knowledge_base);
            form.Show();
        }

        private void button_add_to_opposite_facts_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_facts.SelectedRows)
            {
                foreach (DataGridViewCell cell in dataGridView_opposite_facts.SelectedCells)
                {
                    if (cell.Value == null)
                    {
                        cell.Value = "";
                    }

                    cell.Value += "f" + (row.Index + 1).ToString() + ";";
                }
            }
        }

        private void button_set_default_data_Click(object sender, EventArgs e)
        {
            SetDefaultKnowledgeBase();

            dataGridView_facts.Rows.Clear();
            dataGridView_opposite_facts.Rows.Clear();
            dataGridView_rulebases.Rows.Clear();
            dataGridView_relations.Rows.Clear();


            for (int i = 0; i < KnowledgeBase.FactualBasis.Count; i++)
            {
                dataGridView_facts.Rows.Add();
                Fact fact = KnowledgeBase.FactualBasis.ElementAt(i);

                int index = dataGridView_facts.Rows.Count - 1;
                dataGridView_facts.Rows[i].Cells[0].Value = fact.Value;
                dataGridView_facts.Rows[i].Cells[1].Value = fact.Description;

                if (fact.Id == KnowledgeBase.TargetFact.Id)
                {
                    dataGridView_facts.Rows[i].Cells[2].Value = CheckState.Checked;
                }
            }

            for (int i = 0; i < KnowledgeBase.OppositeFacts.Count; i++)
            {
                dataGridView_opposite_facts.Rows.Add();
                List<Fact> facts_list = KnowledgeBase.OppositeFacts.ElementAt(i);
                string temp_str = "";

                for (int j = 0; j < facts_list.Count; j++)
                {
                    temp_str += facts_list.ElementAt(j).ToString() + ";";
                }

                int index = dataGridView_opposite_facts.Rows.Count - 1;
                dataGridView_opposite_facts.Rows[i].Cells[0].Value = temp_str;
            }

            for (int i = 0; i < knowledge_base.RuleBases.Count; i++)
            {
                dataGridView_rulebases.Rows.Add();
                Rulebase rulebase = knowledge_base.RuleBases.ElementAt(i);

                int index = dataGridView_rulebases.Rows.Count - 1;
                dataGridView_rulebases.Rows[i].Cells[0].Value = rulebase.A.ToString();
                dataGridView_rulebases.Rows[i].Cells[1].Value = rulebase.P.ToString();
                dataGridView_rulebases.Rows[i].Cells[2].Value = rulebase.FuctionMessage;
                if (rulebase.FactFuctionInput != null)
                {
                    dataGridView_rulebases.Rows[i].Cells[3].Value = rulebase.FactFuctionInput.ToString();
                }
//                dataGridView_rulebases.Rows[i].Cells[4].Value = rulebase.FactFuctionFluence.ToString();
            }

            for (int i = 0; i < KnowledgeBase.RelationRows.Count; i++)
            {
                dataGridView_relations.Rows.Add();

                RelationRow relation_row = KnowledgeBase.RelationRows.ElementAt(i);

                dataGridView_relations.Rows[i].Cells[0].Value = relation_row.function_name;
                dataGridView_relations.Rows[i].Cells[1].Value = relation_row.StartStateToString();
                dataGridView_relations.Rows[i].Cells[2].Value = relation_row.StartStateValuesToString();
                dataGridView_relations.Rows[i].Cells[3].Value = relation_row.ChangeFactInfosToString();
                dataGridView_relations.Rows[i].Cells[4].Value = relation_row.ChangeFactInfosValuesStartStateToString();
                dataGridView_relations.Rows[i].Cells[5].Value = relation_row.ChangeFactInfosValuesEndStateToString();
            }
        }

        private void SetDefaultKnowledgeBase()
        {
            Fact f1 = new Fact(0, 1, "вентиль гарячої води відкритий");
            f1.MessageStateTrue = "вентиль гарячої води відкритий";
            f1.MessageStateFalse = "вентиль гарячої води закритий";
            Fact f2 = new Fact(1, 1, "вентиль холодної води відкритий");
            f2.MessageStateTrue = "вентиль холодної води відкритий";
            f2.MessageStateFalse = "вентиль холодної води закритий";
            Fact f3 = new Fact(2, 0, "вентиль гарячої води повністю відкритий");
            f3.MessageStateTrue = "вентиль гарячої води повністю відкритий";
            f3.MessageStateFalse = "вентиль гарячої води не повністю відкритий";
            Fact f4 = new Fact(3, 0, "вентиль холодної води повністю відкритий");
            f4.MessageStateTrue = "вентиль холодної води повністю відкритий";
            f4.MessageStateFalse = "вентиль холодної води не повністю відкритий";
            Fact f5 = new Fact(4, 0, "вода гаряча");
            f5.MessageStateTrue = "вода стала гарячою";
            f5.MessageStateFalse = "";
            Fact f6 = new Fact(5, 1, "вода холодна");
            f6.MessageStateTrue = "вода стала холодною";
            f6.MessageStateFalse = "";
            Fact f7 = new Fact(6, 0, "вода тепла");
            f7.MessageStateTrue = "вода стала теплою";
            f7.MessageStateFalse = "";
            Fact f8 = new Fact(7, 1, "крок відкриття вентиля");
            f8.MessageStateTrue = "";
            f8.MessageStateFalse = "";


            KnowledgeBase.FactualBasis = new List<Fact>();
            KnowledgeBase.FactualBasis.Add(f1);
            KnowledgeBase.FactualBasis.Add(f2);
            KnowledgeBase.FactualBasis.Add(f3);
            KnowledgeBase.FactualBasis.Add(f4);
            KnowledgeBase.FactualBasis.Add(f5);
            KnowledgeBase.FactualBasis.Add(f6);
            KnowledgeBase.FactualBasis.Add(f7);
            KnowledgeBase.FactualBasis.Add(f8);

            KnowledgeBase.TargetFact = f7;


            //OppositeFacts
            KnowledgeBase.OppositeFacts = new List<List<Fact>>();

            List<Fact> opposite_facts_list = new List<Fact>();
            opposite_facts_list.Add(f5);
            opposite_facts_list.Add(f6);
            opposite_facts_list.Add(f7);

            KnowledgeBase.OppositeFacts.Add(opposite_facts_list);
            


            Operator conjunction = new Operator(OperatorType.Conjunction);
            Operator disjunction = new Operator(OperatorType.Disjunction);
            Operator negation = new Operator(OperatorType.Negation);

            knowledge_base.RuleBases = new List<Rulebase>();


            //< 1, «f1∧f5», «¬f4∧¬f7», «ВідкритиВентильХолодноїВодиНа(f8)»>
            Rule rule1_a = new Rule();
            rule1_a.RuleExpression = new List<RuleConstituent>();
            rule1_a.AddConstituent(f1);
            rule1_a.AddConstituent(conjunction);
            rule1_a.AddConstituent(f5);

            Rule rule1_p = new Rule();
            rule1_p.RuleExpression = new List<RuleConstituent>();
            rule1_p.AddConstituent(negation);
            rule1_p.AddConstituent(f4);
            rule1_p.AddConstituent(conjunction);
            rule1_p.AddConstituent(negation);
            rule1_p.AddConstituent(f7);

            Rulebase rulebase1 = new Rulebase(0, rule1_a, rule1_p, "ВідкритиВентильХолодноїВодиНа", f8);


            //< 2, «f2∧f6», «¬f3∧¬f7», «ВідкритиВентильГарячоїВодиНа(f8)»>
            Rule rule2_a = new Rule();
            rule2_a.RuleExpression = new List<RuleConstituent>();
            rule2_a.AddConstituent(f2);
            rule2_a.AddConstituent(conjunction);
            rule2_a.AddConstituent(f6);

            Rule rule2_p = new Rule();
            rule2_p.RuleExpression = new List<RuleConstituent>();
            rule2_p.AddConstituent(negation);
            rule2_p.AddConstituent(f3);
            rule2_p.AddConstituent(conjunction);
            rule2_p.AddConstituent(negation);
            rule2_p.AddConstituent(f7);

            Rulebase rulebase2 = new Rulebase(1, rule2_a, rule2_p, "ВідкритиВентильГарячоїВодиНа", f8);


            //< 3, «f1∧f2∧f5», «f3∧¬f7», «ЗакритиВентильГарячоїВоди()»>
            Rule rule3_a = new Rule();
            rule3_a.RuleExpression = new List<RuleConstituent>();
            rule3_a.AddConstituent(f1);
            rule3_a.AddConstituent(conjunction);
            rule3_a.AddConstituent(f2);
            rule3_a.AddConstituent(conjunction);
            rule3_a.AddConstituent(f5);

            Rule rule3_p = new Rule();
            rule3_p.RuleExpression = new List<RuleConstituent>();
            rule3_p.AddConstituent(f3);
            rule3_p.AddConstituent(conjunction);
            rule3_p.AddConstituent(negation);
            rule3_p.AddConstituent(f7);

            Rulebase rulebase3 = new Rulebase(2, rule3_a, rule3_p, "ЗакритиВентильГарячоїВоди", null);


            //< 4, «f1∧f2∧f6», «f4∧¬f7», «ЗакритиВентильХолодноїВоди()»>
            Rule rule4_a = new Rule();
            rule4_a.RuleExpression = new List<RuleConstituent>();
            rule4_a.AddConstituent(f1);
            rule4_a.AddConstituent(conjunction);
            rule4_a.AddConstituent(f2);
            rule4_a.AddConstituent(conjunction);
            rule4_a.AddConstituent(f6);

            Rule rule4_p = new Rule();
            rule4_p.RuleExpression = new List<RuleConstituent>();
            rule4_p.AddConstituent(f4);
            rule4_p.AddConstituent(conjunction);
            rule4_p.AddConstituent(negation);
            rule4_p.AddConstituent(f7);

            Rulebase rulebase4 = new Rulebase(3, rule4_a, rule4_p, "ЗакритиВентильХолодноїВоди", null);


            knowledge_base.RuleBases.Add(rulebase1);
            knowledge_base.RuleBases.Add(rulebase2);
            knowledge_base.RuleBases.Add(rulebase3);
            knowledge_base.RuleBases.Add(rulebase4);


            //1
            //1_1
            KnowledgeBase.RelationRows = new List<RelationRow>();

            List<Fact> start_state1_1 = new List<Fact>();
            Fact fact2 = new Fact(f2); fact2.Value = 0; start_state1_1.Add(fact2);

            List<ChangeFactInfo> change_fact_infos1_1 = new List<ChangeFactInfo>();
            ChangeFactInfo change_fact_info1_1_1 = new ChangeFactInfo(1, 0, 1); change_fact_infos1_1.Add(change_fact_info1_1_1);

            RelationRow relation1_1 = new RelationRow("ВідкритиВентильХолодноїВодиНа", start_state1_1, change_fact_infos1_1);
            KnowledgeBase.RelationRows.Add(relation1_1);

            //1_2
            List<Fact> start_state1_2 = new List<Fact>();
            fact2.Value = 1; start_state1_2.Add(fact2);

            List<ChangeFactInfo> change_fact_infos1_2 = new List<ChangeFactInfo>();
            ChangeFactInfo change_fact_info1_2_1 = new ChangeFactInfo(3, 0, 1); change_fact_infos1_2.Add(change_fact_info1_2_1);

            RelationRow relation1_2 = new RelationRow("ВідкритиВентильХолодноїВодиНа", start_state1_2, change_fact_infos1_2);
            KnowledgeBase.RelationRows.Add(relation1_2);


            //2
            //2_1
            List<Fact> start_state2_1 = new List<Fact>();
            Fact fact1 = new Fact(f1); fact1.Value = 0; start_state2_1.Add(fact1);

            List<ChangeFactInfo> change_fact_infos2_1 = new List<ChangeFactInfo>();
            ChangeFactInfo change_fact_info2_1_1 = new ChangeFactInfo(0, 0, 1); change_fact_infos2_1.Add(change_fact_info2_1_1);

            RelationRow relation2_1 = new RelationRow("ВідкритиВентильГарячоїВодиНа", start_state2_1, change_fact_infos2_1);
            KnowledgeBase.RelationRows.Add(relation2_1);

            //2_2
            List<Fact> start_state2_2 = new List<Fact>();
            fact1.Value = 1; start_state2_2.Add(fact1);

            List<ChangeFactInfo> change_fact_infos2_2 = new List<ChangeFactInfo>();
            ChangeFactInfo change_fact_info2_2_1 = new ChangeFactInfo(2, 0, 1); change_fact_infos2_2.Add(change_fact_info2_2_1);

            RelationRow relation2_2 = new RelationRow("ВідкритиВентильГарячоїВодиНа", start_state2_2, change_fact_infos2_2);
            KnowledgeBase.RelationRows.Add(relation2_2);


            //3
            List<Fact> start_state3 = new List<Fact>();

            List<ChangeFactInfo> change_fact_infos3 = new List<ChangeFactInfo>();
            ChangeFactInfo change_fact_info3_1 = new ChangeFactInfo(0, 1, 0); change_fact_infos3.Add(change_fact_info3_1);
            ChangeFactInfo change_fact_info3_2 = new ChangeFactInfo(2, 1, 0); change_fact_infos3.Add(change_fact_info3_2);

            RelationRow relation3 = new RelationRow("ЗакритиВентильХолодноїВоди", start_state3, change_fact_infos3);
            KnowledgeBase.RelationRows.Add(relation3);


            //4
            List<Fact> start_state4 = new List<Fact>();

            List<ChangeFactInfo> change_fact_infos4 = new List<ChangeFactInfo>();
            ChangeFactInfo change_fact_info4_1 = new ChangeFactInfo(1, 1, 0); change_fact_infos4.Add(change_fact_info4_1);
            ChangeFactInfo change_fact_info4_2 = new ChangeFactInfo(3, 1, 0); change_fact_infos4.Add(change_fact_info4_2);

            RelationRow relation4 = new RelationRow("ЗакритиВентильХолодноїВоди", start_state4, change_fact_infos4);
            KnowledgeBase.RelationRows.Add(relation4);

        }

        private void button_add_to_relations_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell_fact in dataGridView_facts.SelectedCells)
            {
                int row_index_fact = cell_fact.RowIndex;

                foreach (DataGridViewCell cell in dataGridView_relations.SelectedCells)
                {
                    int row_index_table = cell.RowIndex;
                    int column_index_table = cell.RowIndex;

                    if (cell.Value == null)
                    {
                        cell.Value = "";
                        dataGridView_relations.Rows[row_index_table].Cells[column_index_table].Value = "";
                    }

                    cell.Value += "f" + (row_index_fact + 1) + ";";
                    dataGridView_relations.Rows[row_index_table].Cells[column_index_table].Value += cell_fact.Value.ToString() + ";";
                }
            }
        }

        private void button_add_function_to_changes_table_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell_func in dataGridView_rulebases.SelectedCells)
            {
                int row_index_rulebase = cell_func.RowIndex;

                foreach (DataGridViewCell cell in dataGridView_relations.SelectedCells)
                {
                    int row_index_table = cell.RowIndex;

                    dataGridView_relations.Rows[row_index_table].Cells[0].Value =
                        dataGridView_rulebases.Rows[row_index_rulebase].Cells[2].Value;
                }
            }
        }

        private void button_update_relations_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_relations.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView_relations.Rows[i];

                string function_name = row.Cells[0].Value.ToString();

                string start_state_fact = row.Cells[1].Value.ToString();
                string start_state_fact_value = row.Cells[2].Value.ToString();
                List<Fact> startState = GetFactsFromStrings(start_state_fact, start_state_fact_value);

                string fact_str = row.Cells[3].Value.ToString();
                string fact_start_state = row.Cells[4].Value.ToString();
                string fact_end_state = row.Cells[5].Value.ToString();
                List<ChangeFactInfo> changeFactInfos = GetChangeFactInfoFromStrs(fact_str, fact_start_state, fact_end_state);


                RelationRow relation_row = new RelationRow(function_name, startState, changeFactInfos);
                KnowledgeBase.RelationRows.Add(relation_row);
            }
        }

        private List<Fact> GetFactsFromStrings(string start_state_fact, string start_state_fact_value)
        {
            List<Fact> startState = new List<Fact>();


            if(start_state_fact.Equals("") || start_state_fact_value.Equals(""))
            {
                return startState;
            }
            else

            if (start_state_fact.IndexOf(";") == -1)
            {
                start_state_fact = start_state_fact.Remove(0, 1);

                Fact fact = KnowledgeBase.FactualBasis.ElementAt(
                    KnowledgeBase.GetIndexInListFactualBasisById(
                        Convert.ToInt32(start_state_fact)
                        )
                    );

                fact.Value = Convert.ToInt32(start_state_fact_value);

                startState.Add(fact);
            }
            else
            {
                for (int j = 0; j < start_state_fact.Length; j++)
                {
                    if (start_state_fact.ElementAt(j).Equals("f"))
                    {
                        j++;

                        string val = "";

                        while (j < start_state_fact.Length && start_state_fact.ElementAt(j).Equals(";"))
                        {
                            val += start_state_fact.ElementAt(j);
                            j++;
                        }

                        int fact_index = Convert.ToInt32(val);


                        val = start_state_fact_value.ElementAt(0).ToString();
                        start_state_fact_value = start_state_fact_value.Remove(0, 1);

                        if (start_state_fact_value.ElementAt(0).Equals(";"))
                        {
                            start_state_fact_value = start_state_fact_value.Remove(0, 1);
                        }

                        int fact_value = Convert.ToInt32(val);


                        Fact fact = KnowledgeBase.FactualBasis.ElementAt(
                            KnowledgeBase.GetIndexInListFactualBasisById(
                                Convert.ToInt32(fact_index)
                                )
                            );

                        fact.Value = Convert.ToInt32(fact_value);

                        startState.Add(fact);
                    }
                }
            }

            return startState;
        }

        private List<ChangeFactInfo> GetChangeFactInfoFromStrs(string fact_str, string fact_start_state, string fact_end_state)
        {
            List<ChangeFactInfo> changeFactInfos = new List<ChangeFactInfo>();

            if (fact_str.IndexOf(";") == -1)
            {
                ChangeFactInfo change_fact_info = new ChangeFactInfo(
                    Convert.ToInt32(fact_str.Remove(0, 1)),
                    Convert.ToInt32(fact_start_state.Remove(1, 1)),
                    Convert.ToInt32(fact_end_state.Remove(1, 1)));

                changeFactInfos.Add(change_fact_info);
            }
            else
            {
                for (int i = 0; i < fact_str.Length; i++)
                {
                    if (fact_str.ElementAt(i).Equals("f"))
                    {
                        i++;

                        string val = "";

                        while (i < fact_str.Length && fact_str.ElementAt(i).Equals(";"))
                        {
                            val += fact_str.ElementAt(i);
                            i++;
                        }

                        int fact_index = Convert.ToInt32(val);


                        int fact_start_state_value = Convert.ToInt32(fact_start_state.ElementAt(0));
                        int fact_end_state_value = Convert.ToInt32(fact_end_state.ElementAt(0));


                        fact_start_state = fact_start_state.Remove(0, 1);

                        if (fact_start_state.ElementAt(0).Equals(";"))
                        {
                            fact_start_state = fact_start_state.Remove(0, 1);
                        }


                        fact_end_state = fact_end_state.Remove(0, 1);

                        if (fact_end_state.ElementAt(0).Equals(";"))
                        {
                            fact_end_state = fact_end_state.Remove(0, 1);
                        }


                        ChangeFactInfo change_fact_info = new ChangeFactInfo(
                            fact_index,
                            fact_start_state_value,
                            fact_end_state_value);

                        changeFactInfos.Add(change_fact_info);
                    }
                }
            }

            return changeFactInfos;
        }

    }
}
