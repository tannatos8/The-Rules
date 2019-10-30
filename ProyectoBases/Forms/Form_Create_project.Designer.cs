namespace ProyectoBases.Forms
{
    partial class Form_Create_project
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_ProjectDescription = new System.Windows.Forms.RichTextBox();
            this.Btn_Create_project_Profile = new System.Windows.Forms.Button();
            this.Btn_Create_project = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project name";
            // 
            // Txt_ProjectName
            // 
            this.Txt_ProjectName.Location = new System.Drawing.Point(229, 118);
            this.Txt_ProjectName.Name = "Txt_ProjectName";
            this.Txt_ProjectName.Size = new System.Drawing.Size(483, 20);
            this.Txt_ProjectName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project description";
            // 
            // Txt_ProjectDescription
            // 
            this.Txt_ProjectDescription.Location = new System.Drawing.Point(229, 161);
            this.Txt_ProjectDescription.Name = "Txt_ProjectDescription";
            this.Txt_ProjectDescription.Size = new System.Drawing.Size(483, 118);
            this.Txt_ProjectDescription.TabIndex = 4;
            this.Txt_ProjectDescription.Text = "";
            // 
            // Btn_Create_project_Profile
            // 
            this.Btn_Create_project_Profile.BackColor = System.Drawing.Color.White;
            this.Btn_Create_project_Profile.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Create_project_Profile.Location = new System.Drawing.Point(84, 369);
            this.Btn_Create_project_Profile.Name = "Btn_Create_project_Profile";
            this.Btn_Create_project_Profile.Size = new System.Drawing.Size(148, 30);
            this.Btn_Create_project_Profile.TabIndex = 5;
            this.Btn_Create_project_Profile.Text = "Return";
            this.Btn_Create_project_Profile.UseVisualStyleBackColor = false;
            this.Btn_Create_project_Profile.Click += new System.EventHandler(this.Btn_Create_project_Profile_Click);
            // 
            // Btn_Create_project
            // 
            this.Btn_Create_project.BackColor = System.Drawing.Color.White;
            this.Btn_Create_project.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Create_project.Location = new System.Drawing.Point(564, 369);
            this.Btn_Create_project.Name = "Btn_Create_project";
            this.Btn_Create_project.Size = new System.Drawing.Size(148, 30);
            this.Btn_Create_project.TabIndex = 6;
            this.Btn_Create_project.Text = "Create project";
            this.Btn_Create_project.UseVisualStyleBackColor = false;
            this.Btn_Create_project.Click += new System.EventHandler(this.Btn_Create_project_Click);
            // 
            // Form_Create_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Create_project);
            this.Controls.Add(this.Btn_Create_project_Profile);
            this.Controls.Add(this.Txt_ProjectDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_ProjectName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Create_project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Create_project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Txt_ProjectDescription;
        private System.Windows.Forms.Button Btn_Create_project_Profile;
        private System.Windows.Forms.Button Btn_Create_project;
    }
}