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
    public partial class Reglas : Form
    {
        public Reglas()
        {
            InitializeComponent();
            LlenarComboBox();            
        }
        #region Button Exit and Minimized
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

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

        private void Btn_Return_Business_Rules_Profile_Click(object sender, EventArgs e)
        {
            Form_profil form_Profil = new Form_profil();
            this.Hide();
            form_Profil.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ProjectName.Text != "Select an project")
            {
                var idProject = Models.Search_Model(comboBox_ProjectName.Text);
                Model_information.Id = idProject.id;
            }
        }

        private void Btn_Save_Rule_Click(object sender, EventArgs e)
        {
            var business_rule = Business_Rules.Create_Rule(Txt_RuleName.Text, Model_information.Id);
            if (business_rule.Equals(true))
            {
                if (Txt_RuleName.Text != null)
                {
                    var idRuleName = Business_Rules.Search_Rule(Txt_RuleName.Text);                    
                    Business_Rules.Create_Rule_Information(Txt_Statement.Text, Txt_Constraint.Text, Txt_Field_Names.Text, Txt_Table_Names.Text, Txt_Action_Taken.Text, idRuleName.Id);
                    Business_Rules.Create_logical_elements(checkBox_Key_Type.Checked, checkBox_Key_Structure.Checked, checkBox_Uniqueness.Checked, checkBox_NullSupport.Checked, checkBox_Values_Entered_By.Checked, checkBox_Required_Value.Checked, checkBox_Default_Value.Checked, checkBox_Ranges_Values.Checked, checkBox_Comparisons_Allowed.Checked, checkBox_Operations_Allowed.Checked, checkBox_Edit_Rule.Checked, idRuleName.Id);
                    Business_Rules.Create_relationship_characteristics_affected(checkBox_Deletion_Rule.Checked, checkBox_Type_Participation.Checked, checkBox_Degree_Participation.Checked, idRuleName.Id);
                    Business_Rules.Create_physical_elements(checkBox_Data_Type.Checked, checkBox_Length.Checked, checkBox_Decimal_Places.Checked, checkBox_Character_Support.Checked, checkBox_Input_Mask.Checked, checkBox_Display_Format.Checked, idRuleName.Id);
                    Business_Rules.Create_type(checkBox_Database_Oriented.Checked, checkBox_Application_Oriented.Checked, idRuleName.Id);
                    var idType = Business_Rules.Search_Type(idRuleName.Id);
                    Business_Rules.Create_categories(checkBox_Field_Specific.Checked, checkBox_Relationship_Specific.Checked, idType.Id);
                    Business_Rules.Create_test_on(checkBox_Insert.Checked, checkBox_Update.Checked, checkBox_Delete.Checked, idType.Id);
                    MessageBox.Show("The business rule was created.");
                    Form_profil form_Profil = new Form_profil();
                    this.Hide();
                    form_Profil.Show();
                }
                else
                {
                    MessageBox.Show("The business rule was not created without the name of the rule.");
                }

            }
            else
            {
                MessageBox.Show("The business rule was not created.");
            }

        }


    }
}
