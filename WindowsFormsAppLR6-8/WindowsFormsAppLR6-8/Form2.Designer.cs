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
            this.button_write_to_file = new System.Windows.Forms.Button();
            this.textBox_file_path = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_choose_folder = new System.Windows.Forms.Button();
            this.textBox_belief_system = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(12, 12);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(545, 426);
            this.textBox_result.TabIndex = 0;
            // 
            // button_write_to_file
            // 
            this.button_write_to_file.Location = new System.Drawing.Point(12, 478);
            this.button_write_to_file.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_write_to_file.Name = "button_write_to_file";
            this.button_write_to_file.Size = new System.Drawing.Size(1096, 28);
            this.button_write_to_file.TabIndex = 1;
            this.button_write_to_file.Text = "Записати в файл";
            this.button_write_to_file.UseVisualStyleBackColor = true;
            this.button_write_to_file.Click += new System.EventHandler(this.button_write_to_file_Click);
            // 
            // textBox_file_path
            // 
            this.textBox_file_path.Location = new System.Drawing.Point(12, 446);
            this.textBox_file_path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_file_path.Name = "textBox_file_path";
            this.textBox_file_path.Size = new System.Drawing.Size(1061, 22);
            this.textBox_file_path.TabIndex = 2;
            // 
            // button_choose_folder
            // 
            this.button_choose_folder.Location = new System.Drawing.Point(1081, 446);
            this.button_choose_folder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_choose_folder.Name = "button_choose_folder";
            this.button_choose_folder.Size = new System.Drawing.Size(27, 25);
            this.button_choose_folder.TabIndex = 3;
            this.button_choose_folder.Text = "...";
            this.button_choose_folder.UseVisualStyleBackColor = true;
            this.button_choose_folder.Click += new System.EventHandler(this.button_choose_folder_Click);
            // 
            // textBox_belief_system
            // 
            this.textBox_belief_system.Location = new System.Drawing.Point(563, 12);
            this.textBox_belief_system.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_belief_system.Multiline = true;
            this.textBox_belief_system.Name = "textBox_belief_system";
            this.textBox_belief_system.ReadOnly = true;
            this.textBox_belief_system.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_belief_system.Size = new System.Drawing.Size(545, 426);
            this.textBox_belief_system.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 519);
            this.Controls.Add(this.textBox_belief_system);
            this.Controls.Add(this.button_choose_folder);
            this.Controls.Add(this.textBox_file_path);
            this.Controls.Add(this.button_write_to_file);
            this.Controls.Add(this.textBox_result);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Опис алгоритму роботи вирішувача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_write_to_file;
        private System.Windows.Forms.TextBox textBox_file_path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_choose_folder;
        private System.Windows.Forms.TextBox textBox_belief_system;
    }
}