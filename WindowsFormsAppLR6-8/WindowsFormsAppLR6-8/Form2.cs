﻿using System;
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
            textBox_belief_system.Text = knowledge_base.ReportForBeliefSystem;
        }

        private void button_choose_folder_1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_file_path_1.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void button_choose_folder_2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox_file_path_2.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void button_write_to_file_1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText($"{textBox_file_path_1.Text}.txt", textBox_result.Text.ToString());
            MessageBox.Show("Файл" + $"{textBox_file_path_1.Text}.txt" + " був створений");
        }

        private void button_write_to_file_2_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText($"{textBox_file_path_2.Text}.txt", textBox_belief_system.Text.ToString());
            MessageBox.Show("Файл" + $"{textBox_file_path_2.Text}.txt" + " був створений");
        }
    }
}
