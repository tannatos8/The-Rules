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
    public partial class Form_Delete_Rule : Form
    {
        List<string> projectName;
        List<string> businessRules;

        public Form_Delete_Rule()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            projectName = new List<string>
            {
                "Select an project"
            };
            businessRules = new List<string>
            {
                "Select an business rule"
            };
            var project_name = Models.GetAll(Profile_information.Id);
            foreach (var item in project_name)
            {
                projectName.Add(item.project_name);
            }
            comboBox_SelecProject.DataSource = projectName;
            comboBox_SelectBusinessRule.DataSource = businessRules;
        }

        private void comboBox_SelecProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SelecProject.Text != "Select an project")
            {
                var idProject = Models.Search_Model(comboBox_SelecProject.Text);
                Model_information.Id = idProject.id;
                businessRules.Clear();
                businessRules = new List<string>
                {
                    "Select an business rule"
                };
                var businessRules_name = Business_Rules.GetAll(Model_information.Id);
                foreach (var item in businessRules_name)
                {
                    businessRules.Add(item.rules_name);
                }
                comboBox_SelectBusinessRule.DataSource = businessRules;
            }
            else
            {
                businessRules.Clear();
                businessRules = new List<string>
                {
                    "Select an business rule"
                };
                comboBox_SelectBusinessRule.DataSource = businessRules;
            }
        }

        private void comboBox_SelectBusinessRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SelectBusinessRule.Text != "Select an business rule")
            {
                var businessRuleName = Business_Rules.Search_Rule(comboBox_SelectBusinessRule.Text);
                Rule_information.Id = businessRuleName.Id;
            }
        }

        private void Btn_Return_Profile_Click(object sender, EventArgs e)
        {
            Form_profil form_Profil = new Form_profil();
            this.Hide();
            form_Profil.Show();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Business_Rules.Delete_Rule(Rule_information.Id);
            MessageBox.Show("Delete Rule");
            Form_profil form_Profil = new Form_profil();
            this.Hide();
            form_Profil.Show();
        }
    }
}
