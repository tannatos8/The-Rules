using DataBaseClass.Services;
using DataBaseClass.Activities;
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
    public partial class Form_profil : Form
    {
        List<string> projectName;
        List<string> businessRules;
        List<string> filtre;

        public Form_profil()
        {
            InitializeComponent();
            Profile();
            LlenarComboBox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Profile()
        {
            var profile = Profiles_informations.Search_Profile(Profile_information.Id);
            Lbl_Profil.Text = profile.user_name;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Form1 res = new Form1();
            this.Hide();
            res.Show();
        }

        private void Btn_profile_information_Click(object sender, EventArgs e)
        {
            Form_profile_information form_Profile_Information = new Form_profile_information();
            this.Hide();
            form_Profile_Information.Show();
        }


        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Create_project form_Create_Project = new Form_Create_project();
            this.Hide();
            form_Create_Project.Show();
        }

        private void createBusinessRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reglas reglas = new Reglas();
            this.Hide();
            reglas.Show();
        }

        private void updateProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Update_Project form_Update = new Form_Update_Project();
            this.Hide();
            form_Update.Show();
        }

        private void updateBusinessRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Update_Business_Rule form_Update_Business = new Form_Update_Business_Rule();
            this.Hide();
            form_Update_Business.Show();
        }

        #region Mostrar reglas

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
            filtre = new List<string>
            {
                "Select Filtre"
            };
            var project_name = Models.GetAll(Profile_information.Id);
            foreach (var item in project_name)
            {
                projectName.Add(item.project_name);
            }
            comboBox_Filtre.DataSource = filtre;
            comboBox_SelecProject.DataSource = projectName;
            comboBox_SelectBusinessRule.DataSource = businessRules;
        }

        private void comboBox_SelecProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SelecProject.Text != "Select an project")
            {
                filtre.Clear();
                filtre = new List<string>
                {
                    "Select Filtre",
                    "All",
                    "Data Bases Oriented",
                    "Application Oriented"
                };
                comboBox_Filtre.DataSource = filtre;
            }
            else
            {
                businessRules.Clear();
                businessRules = new List<string>
                {
                    "Select an business rule"
                };
                comboBox_SelectBusinessRule.DataSource = businessRules;
                filtre.Clear();
                filtre = new List<string>
                {
                    "Select Filtre"
                };
                comboBox_Filtre.DataSource = filtre;
            }


        }
        private void comboBox_Filtre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SelecProject.Text != "Select an project" && comboBox_Filtre.Text == "All")
            {
                Rules_All();
            }
            else if (comboBox_SelecProject.Text != "Select an project" && comboBox_Filtre.Text == "Data Bases Oriented")
            {
                Data_Bases_Oriented();
            }
            else if (comboBox_SelecProject.Text != "Select an project" && comboBox_Filtre.Text == "Application Oriented")
            {
                Application_Oriented();
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

        private void Application_Oriented()
        {
            var idProject = Models.Search_Model(comboBox_SelecProject.Text);
            Model_information.Id = idProject.id;
            businessRules.Clear();
            businessRules = new List<string>
            {
                "Select an business rule"
            };
            var idApplicationOriented = Business_Rules.Filtre_Application_Oriented(1);
            foreach (var item in idApplicationOriented)
            {
                var foreKey = Business_Rules.Search_Rule_Id(item.business_rules_idbusiness_rules);
                var NameRule = Business_Rules.Search_RuleName_IdModel(foreKey.rules_name, Model_information.Id);
                if (NameRule != null)
                {
                    businessRules.Add(NameRule.rules_name);
                }
            }
            comboBox_SelectBusinessRule.DataSource = businessRules;
        }

        private void Data_Bases_Oriented()
        {
            var idProject = Models.Search_Model(comboBox_SelecProject.Text);
            Model_information.Id = idProject.id;
            businessRules.Clear();
            businessRules = new List<string>
            {
                "Select an business rule"
            };
            var idDataBasesOriented = Business_Rules.Filtre_Data_Bases_Oriented(1);
            foreach (var item in idDataBasesOriented)
            {
                var foreKey = Business_Rules.Search_Rule_Id(item.business_rules_idbusiness_rules);
                var NameRule = Business_Rules.Search_RuleName_IdModel(foreKey.rules_name, Model_information.Id);
                if (NameRule != null)
                {
                    businessRules.Add(NameRule.rules_name);
                }                
            }
            comboBox_SelectBusinessRule.DataSource = businessRules;
        }

        private void Rules_All()
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

        private void comboBox_SelectBusinessRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SelectBusinessRule.Text != "Select an business rule")
            {
                var businessRuleName = Business_Rules.Search_Rule(comboBox_SelectBusinessRule.Text);
                Rule_information.Id = businessRuleName.Id;
                Lbl_RuleName.Text = businessRuleName.rules_name;
                Logical_Elements();
                Physical_Elements();
                Relationship_Characteristics_Affected();
                Rule_Information_Text_Boxs();
                Type();
                panel_Vista.Visible = true;
            }
            else
            {
                panel_Vista.Visible = false;
            }
        }

        private void Type()
        {
            var type = Business_Rules.Search_Type(Rule_information.Id);
            checkBox_Database_Oriented.Checked = Convert.ToBoolean(type.data_base_oriented);
            checkBox_Application_Oriented.Checked = Convert.ToBoolean(type.application_oriented);
            var categories = Business_Rules.Search_Categories(type.Id);
            checkBox_Field_Specific.Checked = Convert.ToBoolean(categories.Field_specfic);
            checkBox_Relationship_Specific.Checked = Convert.ToBoolean(categories.Relationship_specific);
            var test_on = Business_Rules.Search_Test_On(type.Id);
            checkBox_Insert.Checked = Convert.ToBoolean(test_on.Inserts);
            checkBox_Update.Checked = Convert.ToBoolean(test_on.Updates);
            checkBox_Delete.Checked = Convert.ToBoolean(test_on.Deletes);

        }

        private void Rule_Information_Text_Boxs()
        {
            var rule_information_text_boxs = Business_Rules.Search_Rule_Information_Text_Boxs(Rule_information.Id);
            Lbl_statement.Text = rule_information_text_boxs.Statement;
            Lbl_constraint.Text = rule_information_text_boxs.Constraints;
            Lbl_FieldNames.Text = rule_information_text_boxs.Field_names;
            Lbl_TableNames.Text = rule_information_text_boxs.Table_names;
            Lbl_ActionTaken.Text = rule_information_text_boxs.Action_taken;
        }

        private void Relationship_Characteristics_Affected()
        {
            var relationship_characteristics_affected = Business_Rules.Search_Relationship_Characteristics_Affected(Rule_information.Id);
            checkBox_Deletion_Rule.Checked = Convert.ToBoolean(relationship_characteristics_affected.Deletion_rule);
            checkBox_Type_Participation.Checked = Convert.ToBoolean(relationship_characteristics_affected.Type_of_participation);
            checkBox_Degree_Participation.Checked = Convert.ToBoolean(relationship_characteristics_affected.Degree_of_participati);
        }

        private void Physical_Elements()
        {
            var physical_elements = Business_Rules.Search_Physical_Elements(Rule_information.Id);
            checkBox_Data_Type.Checked = Convert.ToBoolean(physical_elements.Data_type);
            checkBox_Length.Checked = Convert.ToBoolean(physical_elements.Length);
            checkBox_Decimal_Places.Checked = Convert.ToBoolean(physical_elements.Decimal_places);
            checkBox_Character_Support.Checked = Convert.ToBoolean(physical_elements.Character_support);
            checkBox_Input_Mask.Checked = Convert.ToBoolean(physical_elements.Input_mask);
            checkBox_Display_Format.Checked = Convert.ToBoolean(physical_elements.Display_format);
        }

        private void Logical_Elements()
        {
            var businessRuleLogicalElements = Business_Rules.Search_Logical_Elements(Rule_information.Id);
            checkBox_Key_Type.Checked = Convert.ToBoolean(businessRuleLogicalElements.Key_type);
            checkBox_Key_Structure.Checked = Convert.ToBoolean(businessRuleLogicalElements.Key_structure);
            checkBox_Uniqueness.Checked = Convert.ToBoolean(businessRuleLogicalElements.Uniqueness);
            checkBox_NullSupport.Checked = Convert.ToBoolean(businessRuleLogicalElements.Null_support);
            checkBox_Values_Entered_By.Checked = Convert.ToBoolean(businessRuleLogicalElements.Values_entered_by);
            checkBox_Required_Value.Checked = Convert.ToBoolean(businessRuleLogicalElements.Required_value);
            checkBox_Default_Value.Checked = Convert.ToBoolean(businessRuleLogicalElements.Default_value);
            checkBox_Ranges_Values.Checked = Convert.ToBoolean(businessRuleLogicalElements.Ranges_of_values);
            checkBox_Comparisons_Allowed.Checked = Convert.ToBoolean(businessRuleLogicalElements.Comparisons_allowed);
            checkBox_Operations_Allowed.Checked = Convert.ToBoolean(businessRuleLogicalElements.Operations_allowed);
            checkBox_Edit_Rule.Checked = Convert.ToBoolean(businessRuleLogicalElements.Edit_rule);
        }
        #endregion

        private void deleteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Delete_project form_Delete_Project = new Form_Delete_project();
            this.Hide();
            form_Delete_Project.Show();
        }

        private void deleteBusinessRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Delete_Rule form_Delete_Rule = new Form_Delete_Rule();
            this.Hide();
            form_Delete_Rule.Show();
        }


    }
}
