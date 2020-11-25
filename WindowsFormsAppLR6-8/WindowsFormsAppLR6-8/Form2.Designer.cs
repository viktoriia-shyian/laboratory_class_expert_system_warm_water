namespace WindowsFormsAppLR6_8
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_write_to_file_1 = new System.Windows.Forms.Button();
            this.textBox_file_path_1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_choose_folder_1 = new System.Windows.Forms.Button();
            this.textBox_belief_system = new System.Windows.Forms.TextBox();
            this.button_choose_folder_2 = new System.Windows.Forms.Button();
            this.textBox_file_path_2 = new System.Windows.Forms.TextBox();
            this.button_write_to_file_2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(9, 10);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(410, 434);
            this.textBox_result.TabIndex = 0;
            // 
            // button_write_to_file_1
            // 
            this.button_write_to_file_1.Location = new System.Drawing.Point(9, 475);
            this.button_write_to_file_1.Name = "button_write_to_file_1";
            this.button_write_to_file_1.Size = new System.Drawing.Size(410, 23);
            this.button_write_to_file_1.TabIndex = 1;
            this.button_write_to_file_1.Text = "Записати в файл";
            this.button_write_to_file_1.UseVisualStyleBackColor = true;
            this.button_write_to_file_1.Click += new System.EventHandler(this.button_write_to_file_1_Click);
            // 
            // textBox_file_path_1
            // 
            this.textBox_file_path_1.Location = new System.Drawing.Point(9, 449);
            this.textBox_file_path_1.Name = "textBox_file_path_1";
            this.textBox_file_path_1.Size = new System.Drawing.Size(384, 20);
            this.textBox_file_path_1.TabIndex = 2;
            // 
            // button_choose_folder_1
            // 
            this.button_choose_folder_1.Location = new System.Drawing.Point(399, 449);
            this.button_choose_folder_1.Name = "button_choose_folder_1";
            this.button_choose_folder_1.Size = new System.Drawing.Size(20, 20);
            this.button_choose_folder_1.TabIndex = 3;
            this.button_choose_folder_1.Text = "...";
            this.button_choose_folder_1.UseVisualStyleBackColor = true;
            this.button_choose_folder_1.Click += new System.EventHandler(this.button_choose_folder_1_Click);
            // 
            // textBox_belief_system
            // 
            this.textBox_belief_system.Location = new System.Drawing.Point(422, 10);
            this.textBox_belief_system.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_belief_system.Multiline = true;
            this.textBox_belief_system.Name = "textBox_belief_system";
            this.textBox_belief_system.ReadOnly = true;
            this.textBox_belief_system.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_belief_system.Size = new System.Drawing.Size(410, 433);
            this.textBox_belief_system.TabIndex = 4;
            // 
            // button_choose_folder_2
            // 
            this.button_choose_folder_2.Location = new System.Drawing.Point(812, 448);
            this.button_choose_folder_2.Name = "button_choose_folder_2";
            this.button_choose_folder_2.Size = new System.Drawing.Size(20, 20);
            this.button_choose_folder_2.TabIndex = 7;
            this.button_choose_folder_2.Text = "...";
            this.button_choose_folder_2.UseVisualStyleBackColor = true;
            this.button_choose_folder_2.Click += new System.EventHandler(this.button_choose_folder_2_Click);
            // 
            // textBox_file_path_2
            // 
            this.textBox_file_path_2.Location = new System.Drawing.Point(422, 448);
            this.textBox_file_path_2.Name = "textBox_file_path_2";
            this.textBox_file_path_2.Size = new System.Drawing.Size(384, 20);
            this.textBox_file_path_2.TabIndex = 6;
            // 
            // button_write_to_file_2
            // 
            this.button_write_to_file_2.Location = new System.Drawing.Point(422, 474);
            this.button_write_to_file_2.Name = "button_write_to_file_2";
            this.button_write_to_file_2.Size = new System.Drawing.Size(410, 23);
            this.button_write_to_file_2.TabIndex = 5;
            this.button_write_to_file_2.Text = "Записати в файл";
            this.button_write_to_file_2.UseVisualStyleBackColor = true;
            this.button_write_to_file_2.Click += new System.EventHandler(this.button_write_to_file_2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 508);
            this.Controls.Add(this.button_choose_folder_2);
            this.Controls.Add(this.textBox_file_path_2);
            this.Controls.Add(this.button_write_to_file_2);
            this.Controls.Add(this.textBox_belief_system);
            this.Controls.Add(this.button_choose_folder_1);
            this.Controls.Add(this.textBox_file_path_1);
            this.Controls.Add(this.button_write_to_file_1);
            this.Controls.Add(this.textBox_result);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Опис алгоритму роботи вирішувача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_write_to_file_1;
        private System.Windows.Forms.TextBox textBox_file_path_1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_choose_folder_1;
        private System.Windows.Forms.TextBox textBox_belief_system;
        private System.Windows.Forms.Button button_choose_folder_2;
        private System.Windows.Forms.TextBox textBox_file_path_2;
        private System.Windows.Forms.Button button_write_to_file_2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}