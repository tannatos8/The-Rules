namespace ProyectoBases.Forms
{
    partial class Form_Delete_project
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
            this.comboBox_SelecProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Return_Profile = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_SelecProject
            // 
            this.comboBox_SelecProject.FormattingEnabled = true;
            this.comboBox_SelecProject.Location = new System.Drawing.Point(339, 173);
            this.comboBox_SelecProject.Name = "comboBox_SelecProject";
            this.comboBox_SelecProject.Size = new System.Drawing.Size(174, 21);
            this.comboBox_SelecProject.TabIndex = 28;
            this.comboBox_SelecProject.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelecProject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Select Project:";
            // 
            // Btn_Return_Profile
            // 
            this.Btn_Return_Profile.BackColor = System.Drawing.Color.White;
            this.Btn_Return_Profile.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Return_Profile.Location = new System.Drawing.Point(231, 218);
            this.Btn_Return_Profile.Name = "Btn_Return_Profile";
            this.Btn_Return_Profile.Size = new System.Drawing.Size(108, 23);
            this.Btn_Return_Profile.TabIndex = 29;
            this.Btn_Return_Profile.Text = "Return";
            this.Btn_Return_Profile.UseVisualStyleBackColor = false;
            this.Btn_Return_Profile.Click += new System.EventHandler(this.Btn_Return_Profile_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.White;
            this.Btn_Delete.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(405, 218);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(108, 23);
            this.Btn_Delete.TabIndex = 30;
            this.Btn_Delete.Text = "Delete Project";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Form_Delete_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Return_Profile);
            this.Controls.Add(this.comboBox_SelecProject);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Delete_project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Delete_project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_SelecProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Return_Profile;
        private System.Windows.Forms.Button Btn_Delete;
    }
}