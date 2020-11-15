namespace WindowsFormsAppLR6_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_facts = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_rulebases = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionRulebase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactRulebase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_update_facts = new System.Windows.Forms.Button();
            this.button_add_selected_fact_to_rule = new System.Windows.Forms.Button();
            this.button_negation = new System.Windows.Forms.Button();
            this.button_conjunction = new System.Windows.Forms.Button();
            this.button_disjunction = new System.Windows.Forms.Button();
            this.button_update_knowledge_base = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_opposite_facts = new System.Windows.Forms.DataGridView();
            this.button_update_opposite_facts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rulebases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_opposite_facts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_facts
            // 
            this.dataGridView_facts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_facts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value,
            this.Description});
            this.dataGridView_facts.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_facts.Name = "dataGridView_facts";
            this.dataGridView_facts.Size = new System.Drawing.Size(540, 150);
            this.dataGridView_facts.TabIndex = 0;
            this.dataGridView_facts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_facts_CellContentClick);
            // 
            // Value
            // 
            this.Value.HeaderText = "Значення";
            this.Value.Name = "Value";
            // 
            // Description
            // 
            this.Description.HeaderText = "Опис";
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // dataGridView_rulebases
            // 
            this.dataGridView_rulebases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rulebases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.P,
            this.FunctionRulebase,
            this.FactRulebase});
            this.dataGridView_rulebases.Location = new System.Drawing.Point(12, 382);
            this.dataGridView_rulebases.Name = "dataGridView_rulebases";
            this.dataGridView_rulebases.Size = new System.Drawing.Size(540, 150);
            this.dataGridView_rulebases.TabIndex = 1;
            // 
            // A
            // 
            this.A.HeaderText = "Блок A";
            this.A.Name = "A";
            // 
            // P
            // 
            this.P.HeaderText = "Блок P";
            this.P.Name = "P";
            // 
            // FunctionRulebase
            // 
            this.FunctionRulebase.HeaderText = "Функція, яку слід виконати";
            this.FunctionRulebase.Name = "FunctionRulebase";
            // 
            // FactRulebase
            // 
            this.FactRulebase.HeaderText = "Факт, вхідний параметр функції";
            this.FactRulebase.Name = "FactRulebase";
            // 
            // button_update_facts
            // 
            this.button_update_facts.Location = new System.Drawing.Point(12, 168);
            this.button_update_facts.Name = "button_update_facts";
            this.button_update_facts.Size = new System.Drawing.Size(270, 23);
            this.button_update_facts.TabIndex = 2;
            this.button_update_facts.Text = "Оновити фактологічну базу";
            this.button_update_facts.UseVisualStyleBackColor = true;
            this.button_update_facts.Click += new System.EventHandler(this.button_update_facts_Click);
            // 
            // button_add_selected_fact_to_rule
            // 
            this.button_add_selected_fact_to_rule.Location = new System.Drawing.Point(282, 168);
            this.button_add_selected_fact_to_rule.Name = "button_add_selected_fact_to_rule";
            this.button_add_selected_fact_to_rule.Size = new System.Drawing.Size(270, 23);
            this.button_add_selected_fact_to_rule.TabIndex = 3;
            this.button_add_selected_fact_to_rule.Text = "Додати до правила";
            this.button_add_selected_fact_to_rule.UseVisualStyleBackColor = true;
            this.button_add_selected_fact_to_rule.Click += new System.EventHandler(this.button_add_selected_fact_to_rule_Click);
            // 
            // button_negation
            // 
            this.button_negation.Location = new System.Drawing.Point(12, 538);
            this.button_negation.Name = "button_negation";
            this.button_negation.Size = new System.Drawing.Size(75, 23);
            this.button_negation.TabIndex = 4;
            this.button_negation.Text = "¬";
            this.button_negation.UseVisualStyleBackColor = true;
            this.button_negation.Click += new System.EventHandler(this.button_negation_Click);
            // 
            // button_conjunction
            // 
            this.button_conjunction.Location = new System.Drawing.Point(93, 538);
            this.button_conjunction.Name = "button_conjunction";
            this.button_conjunction.Size = new System.Drawing.Size(75, 23);
            this.button_conjunction.TabIndex = 5;
            this.button_conjunction.Text = "∧";
            this.button_conjunction.UseVisualStyleBackColor = true;
            this.button_conjunction.Click += new System.EventHandler(this.button_conjunction_Click);
            // 
            // button_disjunction
            // 
            this.button_disjunction.Location = new System.Drawing.Point(174, 538);
            this.button_disjunction.Name = "button_disjunction";
            this.button_disjunction.Size = new System.Drawing.Size(75, 23);
            this.button_disjunction.TabIndex = 6;
            this.button_disjunction.Text = "∨";
            this.button_disjunction.UseVisualStyleBackColor = true;
            this.button_disjunction.Click += new System.EventHandler(this.button_disjunction_Click);
            // 
            // button_update_knowledge_base
            // 
            this.button_update_knowledge_base.Location = new System.Drawing.Point(255, 538);
            this.button_update_knowledge_base.Name = "button_update_knowledge_base";
            this.button_update_knowledge_base.Size = new System.Drawing.Size(140, 23);
            this.button_update_knowledge_base.TabIndex = 7;
            this.button_update_knowledge_base.Text = "Оновити базу правил";
            this.button_update_knowledge_base.UseVisualStyleBackColor = true;
            this.button_update_knowledge_base.Click += new System.EventHandler(this.button_update_knowledge_base_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Описати алгоритм";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_opposite_facts
            // 
            this.dataGridView_opposite_facts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_opposite_facts.Location = new System.Drawing.Point(12, 197);
            this.dataGridView_opposite_facts.Name = "dataGridView_opposite_facts";
            this.dataGridView_opposite_facts.Size = new System.Drawing.Size(540, 150);
            this.dataGridView_opposite_facts.TabIndex = 9;
            // 
            // button_update_opposite_facts
            // 
            this.button_update_opposite_facts.Location = new System.Drawing.Point(12, 353);
            this.button_update_opposite_facts.Name = "button_update_opposite_facts";
            this.button_update_opposite_facts.Size = new System.Drawing.Size(540, 23);
            this.button_update_opposite_facts.TabIndex = 10;
            this.button_update_opposite_facts.Text = "Додати протиставні факти";
            this.button_update_opposite_facts.UseVisualStyleBackColor = true;
            this.button_update_opposite_facts.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 575);
            this.Controls.Add(this.button_update_opposite_facts);
            this.Controls.Add(this.dataGridView_opposite_facts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_update_knowledge_base);
            this.Controls.Add(this.button_disjunction);
            this.Controls.Add(this.button_conjunction);
            this.Controls.Add(this.button_negation);
            this.Controls.Add(this.button_add_selected_fact_to_rule);
            this.Controls.Add(this.button_update_facts);
            this.Controls.Add(this.dataGridView_rulebases);
            this.Controls.Add(this.dataGridView_facts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rulebases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_opposite_facts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_facts;
        private System.Windows.Forms.DataGridView dataGridView_rulebases;
        private System.Windows.Forms.Button button_update_facts;
        private System.Windows.Forms.Button button_add_selected_fact_to_rule;
        private System.Windows.Forms.Button button_negation;
        private System.Windows.Forms.Button button_conjunction;
        private System.Windows.Forms.Button button_disjunction;
        private System.Windows.Forms.Button button_update_knowledge_base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionRulebase;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactRulebase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_opposite_facts;
        private System.Windows.Forms.Button button_update_opposite_facts;
    }
}

