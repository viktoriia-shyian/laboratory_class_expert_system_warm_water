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

        private void dataGridView_facts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_facts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void button_update_facts_Click(object sender, EventArgs e)
        {
            knowledge_base.FactualBasis = new List<Fact>();

            for (int i = 0; i < dataGridView_facts.Rows.Count - 1; i++)
            {
                knowledge_base.FactualBasis.Add(ConvertRowToFact(dataGridView_facts.Rows[i]));
            }
        }

        private void button_add_selected_fact_to_rule_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_facts.SelectedRows)
            {
                foreach (DataGridViewCell cell in dataGridView_rulebases.SelectedCells)
                {
                    if (cell.Value == null)
                    {
                        cell.Value = "";
                    }

                    cell.Value += ConvertRowToFact(row).ToString();
                }
            }
        }

        private Fact ConvertRowToFact(DataGridViewRow row)
        {
            return
                new Fact(
                    Convert.ToInt32(row.Index + 1),
                    Convert.ToInt32(row.Cells[0].Value),
                    row.Cells[1].Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            if (knowledge_base.FactualBasis == null)
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
                    Convert.ToInt32(row.Index + 1),
                    ConvertCellToRule(row.Cells[0]),
                    ConvertCellToRule(row.Cells[1]),
                    row.Cells[2].Value.ToString(),
                    ConvertCellToFact(row.Cells[3]));
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

                        rule.AddConstituent(knowledge_base.FindFactById(Convert.ToInt32(id)));
                        break;
                }
            }
         
            return rule;
        }

        private Fact ConvertCellToFact(DataGridViewCell cell)
        {
            string temp = cell.Value.ToString();
            //temp = temp.Remove(0);
            temp = temp.Remove(0, 1);

            return knowledge_base.FindFactById(Convert.ToInt32(temp));
        }

        private void button2_Click(object sender, EventArgs e)//opposite facts
        {
            knowledge_base.OppositeFacts = new List<List<Fact>>();

            List<List<Fact>> list = new List<List<Fact>>();
            List<Fact> temp_list;
            for (int i = 0; i < dataGridView_opposite_facts.Rows.Count - 1; i++)
            {
                string temp_str = dataGridView_opposite_facts.Rows[i].Cells[0].Value.ToString();
                temp_list = new List<Fact>();

                for (int j = 0; j < temp_str.Length; j++)
                {
                    if (temp_list.ElementAt(j).Equals("f"))
                    {
                        string val = "";

                        while (!temp_list.ElementAt(j + 1).Equals(";"))
                        {
                            j++;

                            val += temp_list.ElementAt(j);
                        }

                        temp_list.Add(ConvertRowToFact(dataGridView_facts.Rows[Convert.ToInt32(val) - 1]));
                    }
                }

                list.Add(temp_list);
            }

            knowledge_base.OppositeFacts = list; 
        }

        private void button1_Click(object sender, EventArgs e)//next
        {

        }

        private void button_add_to_opposite_facts_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_facts.SelectedCells)
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

        }
    }
}
