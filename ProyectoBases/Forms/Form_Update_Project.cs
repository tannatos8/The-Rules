using DataBaseClass.Activities;
using DataBaseClass.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBases.Forms
{
    public partial class Form_Update_Project : Form
    {
        public Form_Update_Project()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void Btn_Create_project_Profile_Click(object sender, EventArgs e)
        {
            Form_profil form_Profil = new Form_profil();
            this.Hide();
            form_Profil.Show();
        }

        private void LlenarComboBox()
        {
            List<string> projectName = new List<string>
            {
                "Select an project"
            };
            var project_name = Models.GetAll(Profile_information.Id);
            foreach (var item in project_name)
            {
                projectName.Add(item.project_name);
            }
            comboBox_ProjectName.DataSource = projectName;
        }

        private void comboBox_ProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ProjectName.Text != "Select an project")
            {
                var idProject = Models.Search_Model(comboBox_ProjectName.Text);
                Model_information.Id = idProject.id;
                Txt_ProjectName.Text = idProject.project_name;
                Txt_ProjectDescription.Text = idProject.project_description;
            }
        }

        private void Btn_Update_project_Click(object sender, EventArgs e)
        {
            var update_models = Models.Update_Model(Txt_ProjectName.Text, Txt_ProjectDescription.Text, Model_information.Id);
            if (update_models.Equals(true))
            {
                MessageBox.Show("The project was updated.");
                Form_profil form_Profil = new Form_profil();
                this.Hide();
                form_Profil.Show();
            }
            else
            {
                MessageBox.Show("The project not was updated.");
            }
        }
    }
}
