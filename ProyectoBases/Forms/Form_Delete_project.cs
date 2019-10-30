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
    public partial class Form_Delete_project : Form
    {
        public Form_Delete_project()
        {
            InitializeComponent();
            LlenarComboBox();
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
            comboBox_SelecProject.DataSource = projectName;
        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Models.Delete_Model(Model_information.Id);
            MessageBox.Show("Projecto borrado");
            Form_profil form_Profil = new Form_profil();
            this.Hide();
            form_Profil.Show();
        }

        private void Btn_Return_Profile_Click(object sender, EventArgs e)
        {
            Form_profil form_Profil = new Form_profil();
            this.Hide();
            form_Profil.Show();
        }

        private void comboBox_SelecProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SelecProject.Text != "Select an project")
            {
                var idProject = Models.Search_Model(comboBox_SelecProject.Text);
                Model_information.Id = idProject.id;
            }
        }
    }
}
