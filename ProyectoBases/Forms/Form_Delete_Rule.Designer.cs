namespace ProyectoBases.Forms
{
    partial class Form_Delete_Rule
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
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Return_Profile = new System.Windows.Forms.Button();
            this.comboBox_SelecProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SelectBusinessRule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.White;
            this.Btn_Delete.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(440, 256);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(108, 23);
            this.Btn_Delete.TabIndex = 34;
            this.Btn_Delete.Text = "Delete Project";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Return_Profile
            // 
            this.Btn_Return_Profile.BackColor = System.Drawing.Color.White;
            this.Btn_Return_Profile.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Return_Profile.Location = new System.Drawing.Point(245, 256);
            this.Btn_Return_Profile.Name = "Btn_Return_Profile";
            this.Btn_Return_Profile.Size = new System.Drawing.Size(108, 23);
            this.Btn_Return_Profile.TabIndex = 33;
            this.Btn_Return_Profile.Text = "Return";
            this.Btn_Return_Profile.UseVisualStyleBackColor = false;
            this.Btn_Return_Profile.Click += new System.EventHandler(this.Btn_Return_Profile_Click);
            // 
            // comboBox_SelecProject
            // 
            this.comboBox_SelecProject.FormattingEnabled = true;
            this.comboBox_SelecProject.Location = new System.Drawing.Point(374, 159);
            this.comboBox_SelecProject.Name = "comboBox_SelecProject";
            this.comboBox_SelecProject.Size = new System.Drawing.Size(174, 21);
            this.comboBox_SelecProject.TabIndex = 32;
            this.comboBox_SelecProject.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelecProject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Project:";
            // 
            // comboBox_SelectBusinessRule
            // 
            this.comboBox_SelectBusinessRule.FormattingEnabled = true;
            this.comboBox_SelectBusinessRule.Location = new System.Drawing.Point(374, 210);
            this.comboBox_SelectBusinessRule.Name = "comboBox_SelectBusinessRule";
            this.comboBox_SelectBusinessRule.Size = new System.Drawing.Size(174, 21);
            this.comboBox_SelectBusinessRule.TabIndex = 36;
            this.comboBox_SelectBusinessRule.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectBusinessRule_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Select Business Rule:";
            // 
            // Form_Delete_Rule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_SelectBusinessRule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Return_Profile);
            this.Controls.Add(this.comboBox_SelecProject);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Delete_Rule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Delete_Rule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Return_Profile;
        private System.Windows.Forms.ComboBox comboBox_SelecProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_SelectBusinessRule;
        private System.Windows.Forms.Label label2;
    }
}