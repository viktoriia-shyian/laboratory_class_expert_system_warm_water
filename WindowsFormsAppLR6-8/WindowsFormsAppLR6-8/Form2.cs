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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(KnowledgeBase knowledge_base)
        {
            InitializeComponent();

            textBox_result.Text = knowledge_base.StartCalculations();
        }

        private void textBox_result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
