namespace ProyectoBases.Forms
{
    partial class Form_Update_Project
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
            this.comboBox_ProjectName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Update_project = new System.Windows.Forms.Button();
            this.Btn_Create_project_Profile = new System.Windows.Forms.Button();
            this.Txt_ProjectDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_ProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_ProjectName
            // 
            this.comboBox_ProjectName.FormattingEnabled = true;
            this.comboBox_ProjectName.Location = new System.Drawing.Point(234, 52);
            this.comboBox_ProjectName.Name = "comboBox_ProjectName";
            this.comboBox_ProjectName.Size = new System.Drawing.Size(205, 21);
            this.comboBox_ProjectName.TabIndex = 0;
            this.comboBox_ProjectName.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProjectName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Project:";
            // 
            // Btn_Update_project
            // 
            this.Btn_Update_project.BackColor = System.Drawing.Color.White;
            this.Btn_Update_project.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update_project.Location = new System.Drawing.Point(568, 339);
            this.Btn_Update_project.Name = "Btn_Update_project";
            this.Btn_Update_project.Size = new System.Drawing.Size(148, 23);
            this.Btn_Update_project.TabIndex = 12;
            this.Btn_Update_project.Text = "Update project";
            this.Btn_Update_project.UseVisualStyleBackColor = false;
            this.Btn_Update_project.Click += new System.EventHandler(this.Btn_Update_project_Click);
            // 
            // Btn_Create_project_Profile
            // 
            this.Btn_Create_project_Profile.BackColor = System.Drawing.Color.White;
            this.Btn_Create_project_Profile.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Create_project_Profile.Location = new System.Drawing.Point(88, 339);
            this.Btn_Create_project_Profile.Name = "Btn_Create_project_Profile";
            this.Btn_Create_project_Profile.Size = new System.Drawing.Size(148, 23);
            this.Btn_Create_project_Profile.TabIndex = 11;
            this.Btn_Create_project_Profile.Text = "Return";
            this.Btn_Create_project_Profile.UseVisualStyleBackColor = false;
            this.Btn_Create_project_Profile.Click += new System.EventHandler(this.Btn_Create_project_Profile_Click);
            // 
            // Txt_ProjectDescription
            // 
            this.Txt_ProjectDescription.Location = new System.Drawing.Point(234, 131);
            this.Txt_ProjectDescription.Name = "Txt_ProjectDescription";
            this.Txt_ProjectDescription.Size = new System.Drawing.Size(482, 118);
            this.Txt_ProjectDescription.TabIndex = 10;
            this.Txt_ProjectDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Project description:";
            // 
            // Txt_ProjectName
            // 
            this.Txt_ProjectName.Location = new System.Drawing.Point(234, 88);
            this.Txt_ProjectName.Name = "Txt_ProjectName";
            this.Txt_ProjectName.Size = new System.Drawing.Size(482, 20);
            this.Txt_ProjectName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project name:";
            // 
            // Form_Update_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Update_project);
            this.Controls.Add(this.Btn_Create_project_Profile);
            this.Controls.Add(this.Txt_ProjectDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_ProjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Update_Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Update_Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Update_project;
        private System.Windows.Forms.Button Btn_Create_project_Profile;
        private System.Windows.Forms.RichTextBox Txt_ProjectDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_ProjectName;
        private System.Windows.Forms.Label label3;
    }
}