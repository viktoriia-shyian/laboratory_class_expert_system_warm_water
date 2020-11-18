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
            this.dataGridView_rulebases = new System.Windows.Forms.DataGridView();
            this.button_update_facts = new System.Windows.Forms.Button();
            this.button_add_selected_fact_to_rule = new System.Windows.Forms.Button();
            this.button_negation = new System.Windows.Forms.Button();
            this.button_conjunction = new System.Windows.Forms.Button();
            this.button_disjunction = new System.Windows.Forms.Button();
            this.button_update_knowledge_base = new System.Windows.Forms.Button();
            this.button_describe_algorithm = new System.Windows.Forms.Button();
            this.button_update_opposite_facts = new System.Windows.Forms.Button();
            this.button_add_to_opposite_facts = new System.Windows.Forms.Button();
            this.button_set_default_data = new System.Windows.Forms.Button();
            this.dataGridView_opposite_facts = new System.Windows.Forms.DataGridView();
            this.OppositeFacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_relations = new System.Windows.Forms.DataGridView();
            this.FunctionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValuesStartState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactStartState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactEndState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add_to_relations = new System.Windows.Forms.Button();
            this.button_add_function_to_changes_table = new System.Windows.Forms.Button();
            this.button_update_relations = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetFact = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionRulebase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputFactRulebase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rulebases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_opposite_facts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_relations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_facts
            // 
            this.dataGridView_facts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_facts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_facts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value,
            this.Description,
            this.TargetFact});
            this.dataGridView_facts.Location = new System.Drawing.Point(10, 11);
            this.dataGridView_facts.Name = "dataGridView_facts";
            this.dataGridView_facts.RowHeadersWidth = 51;
            this.dataGridView_facts.Size = new System.Drawing.Size(540, 256);
            this.dataGridView_facts.TabIndex = 0;
            // 
            // dataGridView_rulebases
            // 
            this.dataGridView_rulebases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_rulebases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rulebases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.P,
            this.FunctionRulebase,
            this.InputFactRulebase});
            this.dataGridView_rulebases.Location = new System.Drawing.Point(9, 312);
            this.dataGridView_rulebases.Name = "dataGridView_rulebases";
            this.dataGridView_rulebases.RowHeadersWidth = 51;
            this.dataGridView_rulebases.Size = new System.Drawing.Size(540, 150);
            this.dataGridView_rulebases.TabIndex = 1;
            // 
            // button_update_facts
            // 
            this.button_update_facts.Location = new System.Drawing.Point(9, 271);
            this.button_update_facts.Name = "button_update_facts";
            this.button_update_facts.Size = new System.Drawing.Size(131, 35);
            this.button_update_facts.TabIndex = 2;
            this.button_update_facts.Text = "Оновити фактологічну базу";
            this.button_update_facts.UseVisualStyleBackColor = true;
            this.button_update_facts.Click += new System.EventHandler(this.button_update_facts_Click);
            // 
            // button_add_selected_fact_to_rule
            // 
            this.button_add_selected_fact_to_rule.Location = new System.Drawing.Point(146, 272);
            this.button_add_selected_fact_to_rule.Name = "button_add_selected_fact_to_rule";
            this.button_add_selected_fact_to_rule.Size = new System.Drawing.Size(131, 35);
            this.button_add_selected_fact_to_rule.TabIndex = 3;
            this.button_add_selected_fact_to_rule.Text = "Додати до правила";
            this.button_add_selected_fact_to_rule.UseVisualStyleBackColor = true;
            this.button_add_selected_fact_to_rule.Click += new System.EventHandler(this.button_add_selected_fact_to_rule_Click);
            // 
            // button_negation
            // 
            this.button_negation.Location = new System.Drawing.Point(9, 468);
            this.button_negation.Name = "button_negation";
            this.button_negation.Size = new System.Drawing.Size(21, 23);
            this.button_negation.TabIndex = 4;
            this.button_negation.Text = "¬";
            this.button_negation.UseVisualStyleBackColor = true;
            this.button_negation.Click += new System.EventHandler(this.button_negation_Click);
            // 
            // button_conjunction
            // 
            this.button_conjunction.Location = new System.Drawing.Point(36, 468);
            this.button_conjunction.Name = "button_conjunction";
            this.button_conjunction.Size = new System.Drawing.Size(21, 23);
            this.button_conjunction.TabIndex = 5;
            this.button_conjunction.Text = "∧";
            this.button_conjunction.UseVisualStyleBackColor = true;
            this.button_conjunction.Click += new System.EventHandler(this.button_conjunction_Click);
            // 
            // button_disjunction
            // 
            this.button_disjunction.Location = new System.Drawing.Point(63, 468);
            this.button_disjunction.Name = "button_disjunction";
            this.button_disjunction.Size = new System.Drawing.Size(21, 23);
            this.button_disjunction.TabIndex = 6;
            this.button_disjunction.Text = "∨";
            this.button_disjunction.UseVisualStyleBackColor = true;
            this.button_disjunction.Click += new System.EventHandler(this.button_disjunction_Click);
            // 
            // button_update_knowledge_base
            // 
            this.button_update_knowledge_base.Location = new System.Drawing.Point(90, 468);
            this.button_update_knowledge_base.Name = "button_update_knowledge_base";
            this.button_update_knowledge_base.Size = new System.Drawing.Size(140, 23);
            this.button_update_knowledge_base.TabIndex = 7;
            this.button_update_knowledge_base.Text = "Оновити базу правил";
            this.button_update_knowledge_base.UseVisualStyleBackColor = true;
            this.button_update_knowledge_base.Click += new System.EventHandler(this.button_update_knowledge_base_Click);
            // 
            // button_describe_algorithm
            // 
            this.button_describe_algorithm.Location = new System.Drawing.Point(398, 468);
            this.button_describe_algorithm.Name = "button_describe_algorithm";
            this.button_describe_algorithm.Size = new System.Drawing.Size(151, 23);
            this.button_describe_algorithm.TabIndex = 8;
            this.button_describe_algorithm.Text = "Описати алгоритм";
            this.button_describe_algorithm.UseVisualStyleBackColor = true;
            this.button_describe_algorithm.Click += new System.EventHandler(this.button_describe_algorithm_Click);
            // 
            // button_update_opposite_facts
            // 
            this.button_update_opposite_facts.Location = new System.Drawing.Point(555, 467);
            this.button_update_opposite_facts.Name = "button_update_opposite_facts";
            this.button_update_opposite_facts.Size = new System.Drawing.Size(579, 23);
            this.button_update_opposite_facts.TabIndex = 10;
            this.button_update_opposite_facts.Text = "Оновити протиставні факти";
            this.button_update_opposite_facts.UseVisualStyleBackColor = true;
            this.button_update_opposite_facts.Click += new System.EventHandler(this.button_update_opposite_facts_Click);
            // 
            // button_add_to_opposite_facts
            // 
            this.button_add_to_opposite_facts.Location = new System.Drawing.Point(418, 272);
            this.button_add_to_opposite_facts.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_to_opposite_facts.Name = "button_add_to_opposite_facts";
            this.button_add_to_opposite_facts.Size = new System.Drawing.Size(131, 35);
            this.button_add_to_opposite_facts.TabIndex = 11;
            this.button_add_to_opposite_facts.Text = "Додати до протиставних фактів";
            this.button_add_to_opposite_facts.UseVisualStyleBackColor = true;
            this.button_add_to_opposite_facts.Click += new System.EventHandler(this.button_add_to_opposite_facts_Click);
            // 
            // button_set_default_data
            // 
            this.button_set_default_data.Location = new System.Drawing.Point(9, 495);
            this.button_set_default_data.Margin = new System.Windows.Forms.Padding(2);
            this.button_set_default_data.Name = "button_set_default_data";
            this.button_set_default_data.Size = new System.Drawing.Size(1125, 23);
            this.button_set_default_data.TabIndex = 12;
            this.button_set_default_data.Text = "Використати дані за замовчуванням";
            this.button_set_default_data.UseVisualStyleBackColor = true;
            this.button_set_default_data.Click += new System.EventHandler(this.button_set_default_data_Click);
            // 
            // dataGridView_opposite_facts
            // 
            this.dataGridView_opposite_facts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_opposite_facts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_opposite_facts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OppositeFacts});
            this.dataGridView_opposite_facts.Location = new System.Drawing.Point(555, 378);
            this.dataGridView_opposite_facts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_opposite_facts.Name = "dataGridView_opposite_facts";
            this.dataGridView_opposite_facts.RowHeadersWidth = 51;
            this.dataGridView_opposite_facts.RowTemplate.Height = 24;
            this.dataGridView_opposite_facts.Size = new System.Drawing.Size(579, 84);
            this.dataGridView_opposite_facts.TabIndex = 13;
            // 
            // OppositeFacts
            // 
            this.OppositeFacts.HeaderText = "Протиставні факти";
            this.OppositeFacts.MinimumWidth = 6;
            this.OppositeFacts.Name = "OppositeFacts";
            // 
            // dataGridView_relations
            // 
            this.dataGridView_relations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_relations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_relations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FunctionName,
            this.StartState,
            this.ValuesStartState,
            this.Fact,
            this.FactStartState,
            this.FactEndState});
            this.dataGridView_relations.Location = new System.Drawing.Point(555, 11);
            this.dataGridView_relations.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_relations.Name = "dataGridView_relations";
            this.dataGridView_relations.RowHeadersWidth = 51;
            this.dataGridView_relations.RowTemplate.Height = 24;
            this.dataGridView_relations.Size = new System.Drawing.Size(579, 336);
            this.dataGridView_relations.TabIndex = 14;
            // 
            // FunctionName
            // 
            this.FunctionName.HeaderText = "Функція";
            this.FunctionName.MinimumWidth = 6;
            this.FunctionName.Name = "FunctionName";
            // 
            // StartState
            // 
            this.StartState.HeaderText = "Початкові умови";
            this.StartState.MinimumWidth = 6;
            this.StartState.Name = "StartState";
            // 
            // ValuesStartState
            // 
            this.ValuesStartState.HeaderText = "Значення початкових умов";
            this.ValuesStartState.MinimumWidth = 6;
            this.ValuesStartState.Name = "ValuesStartState";
            // 
            // Fact
            // 
            this.Fact.HeaderText = "Факт";
            this.Fact.MinimumWidth = 6;
            this.Fact.Name = "Fact";
            // 
            // FactStartState
            // 
            this.FactStartState.HeaderText = "Початковий стан змінюємого факту";
            this.FactStartState.MinimumWidth = 6;
            this.FactStartState.Name = "FactStartState";
            // 
            // FactEndState
            // 
            this.FactEndState.HeaderText = "Кінцеве значення змінюємого факту";
            this.FactEndState.MinimumWidth = 6;
            this.FactEndState.Name = "FactEndState";
            // 
            // button_add_to_relations
            // 
            this.button_add_to_relations.Location = new System.Drawing.Point(282, 272);
            this.button_add_to_relations.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_to_relations.Name = "button_add_to_relations";
            this.button_add_to_relations.Size = new System.Drawing.Size(131, 35);
            this.button_add_to_relations.TabIndex = 15;
            this.button_add_to_relations.Text = "Додати до таблиці змін";
            this.button_add_to_relations.UseVisualStyleBackColor = true;
            this.button_add_to_relations.Click += new System.EventHandler(this.button_add_to_relations_Click);
            // 
            // button_add_function_to_changes_table
            // 
            this.button_add_function_to_changes_table.Location = new System.Drawing.Point(235, 467);
            this.button_add_function_to_changes_table.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_function_to_changes_table.Name = "button_add_function_to_changes_table";
            this.button_add_function_to_changes_table.Size = new System.Drawing.Size(158, 24);
            this.button_add_function_to_changes_table.TabIndex = 16;
            this.button_add_function_to_changes_table.Text = "Додати функцію до таблиці зиін";
            this.button_add_function_to_changes_table.UseVisualStyleBackColor = true;
            this.button_add_function_to_changes_table.Click += new System.EventHandler(this.button_add_function_to_changes_table_Click);
            // 
            // button_update_relations
            // 
            this.button_update_relations.Location = new System.Drawing.Point(555, 351);
            this.button_update_relations.Margin = new System.Windows.Forms.Padding(2);
            this.button_update_relations.Name = "button_update_relations";
            this.button_update_relations.Size = new System.Drawing.Size(579, 23);
            this.button_update_relations.TabIndex = 17;
            this.button_update_relations.Text = "Оновити таблицю змін";
            this.button_update_relations.UseVisualStyleBackColor = true;
            this.button_update_relations.Click += new System.EventHandler(this.button_update_relations_Click);
            // 
            // Value
            // 
            this.Value.HeaderText = "Значення";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            // 
            // Description
            // 
            this.Description.HeaderText = "Опис";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // TargetFact
            // 
            this.TargetFact.HeaderText = "Чи є цільовим станом";
            this.TargetFact.MinimumWidth = 6;
            this.TargetFact.Name = "TargetFact";
            // 
            // A
            // 
            this.A.HeaderText = "Блок A";
            this.A.MinimumWidth = 6;
            this.A.Name = "A";
            // 
            // P
            // 
            this.P.HeaderText = "Блок P";
            this.P.MinimumWidth = 6;
            this.P.Name = "P";
            // 
            // FunctionRulebase
            // 
            this.FunctionRulebase.HeaderText = "Функція, яку слід виконати";
            this.FunctionRulebase.MinimumWidth = 6;
            this.FunctionRulebase.Name = "FunctionRulebase";
            // 
            // InputFactRulebase
            // 
            this.InputFactRulebase.HeaderText = "Факт, вхідний параметр функції";
            this.InputFactRulebase.MinimumWidth = 6;
            this.InputFactRulebase.Name = "InputFactRulebase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 530);
            this.Controls.Add(this.button_update_relations);
            this.Controls.Add(this.button_add_function_to_changes_table);
            this.Controls.Add(this.button_add_to_relations);
            this.Controls.Add(this.dataGridView_relations);
            this.Controls.Add(this.dataGridView_opposite_facts);
            this.Controls.Add(this.button_set_default_data);
            this.Controls.Add(this.button_add_to_opposite_facts);
            this.Controls.Add(this.button_update_opposite_facts);
            this.Controls.Add(this.button_describe_algorithm);
            this.Controls.Add(this.button_update_knowledge_base);
            this.Controls.Add(this.button_disjunction);
            this.Controls.Add(this.button_conjunction);
            this.Controls.Add(this.button_negation);
            this.Controls.Add(this.button_add_selected_fact_to_rule);
            this.Controls.Add(this.button_update_facts);
            this.Controls.Add(this.dataGridView_rulebases);
            this.Controls.Add(this.dataGridView_facts);
            this.Name = "Form1";
            this.Text = "Задання бази знань";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rulebases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_opposite_facts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_relations)).EndInit();
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
        private System.Windows.Forms.Button button_describe_algorithm;
        private System.Windows.Forms.Button button_update_opposite_facts;
        private System.Windows.Forms.Button button_add_to_opposite_facts;
        private System.Windows.Forms.Button button_set_default_data;
        private System.Windows.Forms.DataGridView dataGridView_opposite_facts;
        private System.Windows.Forms.DataGridViewTextBoxColumn OppositeFacts;
        private System.Windows.Forms.DataGridView dataGridView_relations;
        private System.Windows.Forms.Button button_add_to_relations;
        private System.Windows.Forms.Button button_add_function_to_changes_table;
        private System.Windows.Forms.Button button_update_relations;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValuesStartState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactStartState;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactEndState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TargetFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionRulebase;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputFactRulebase;
    }
}

