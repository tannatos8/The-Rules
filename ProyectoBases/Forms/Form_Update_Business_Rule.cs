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
    public partial class Form_Update_Business_Rule : Form
    {
        List<string> projectName;
        List<string> businessRules;

        public Form_Update_Business_Rule()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void Btn_Return_Update_Business_Rules_Profile_Click(object sender, EventArgs e)
        {
            Form_profil form_Profil = new Form_profil();
            this.Hide();
            form_Profil.Show();
        }

        #region Mostrar regla
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
                Txt_RuleName.Text = businessRuleName.rules_name;
                Logical_Elements();
                Physical_Elements();
                Relationship_Characteristics_Affected();
                Rule_Information_Text_Boxs();
                Type();
            }
            else
            {
                Txt_RuleName.Clear();
                Logical_Elements_Reset();
                Physical_Elements_Reset();
                Relationship_Characteristics_Affected_Reset();
                Rule_Information_Text_Boxs_Reset();
                Type_Reset();

            }
        }

        private void Type_Reset()
        {
            checkBox_Database_Oriented.Checked = false;
            checkBox_Application_Oriented.Checked = false;
            checkBox_Field_Specific.Checked = false;
            checkBox_Relationship_Specific.Checked = false;
            checkBox_Insert.Checked = false;
            checkBox_Update.Checked = false;
            checkBox_Delete.Checked = false;
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

        private void Rule_Information_Text_Boxs_Reset()
        {
            Txt_Statement.Clear();
            Txt_Constraint.Clear();
            Txt_Field_Names.Clear();
            Txt_Table_Names.Clear();
            Txt_Action_Taken.Clear();
        }

        private void Rule_Information_Text_Boxs()
        {
            var rule_information_text_boxs = Business_Rules.Search_Rule_Information_Text_Boxs(Rule_information.Id);
            Txt_Statement.Text = rule_information_text_boxs.Statement;
            Txt_Constraint.Text = rule_information_text_boxs.Constraints;
            Txt_Field_Names.Text = rule_information_text_boxs.Field_names;
            Txt_Table_Names.Text = rule_information_text_boxs.Table_names;
            Txt_Action_Taken.Text = rule_information_text_boxs.Action_taken;
        }

        private void Relationship_Characteristics_Affected_Reset()
        {
            checkBox_Deletion_Rule.Checked = false;
            checkBox_Type_Participation.Checked = false;
            checkBox_Degree_Participation.Checked = false;
        }

        private void Relationship_Characteristics_Affected()
        {
            var relationship_characteristics_affected = Business_Rules.Search_Relationship_Characteristics_Affected(Rule_information.Id);
            checkBox_Deletion_Rule.Checked = Convert.ToBoolean(relationship_characteristics_affected.Deletion_rule);
            checkBox_Type_Participation.Checked = Convert.ToBoolean(relationship_characteristics_affected.Type_of_participation);
            checkBox_Degree_Participation.Checked = Convert.ToBoolean(relationship_characteristics_affected.Degree_of_participati);
        }

        private void Physical_Elements_Reset()
        {
            checkBox_Data_Type.Checked = false;
            checkBox_Length.Checked = false;
            checkBox_Decimal_Places.Checked = false;
            checkBox_Character_Support.Checked = false;
            checkBox_Input_Mask.Checked = false;
            checkBox_Display_Format.Checked = false;
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

        private void Logical_Elements_Reset()
        {
            checkBox_Key_Type.Checked = false;
            checkBox_Key_Structure.Checked = false;
            checkBox_Uniqueness.Checked = false;
            checkBox_NullSupport.Checked = false;
            checkBox_Values_Entered_By.Checked = false;
            checkBox_Required_Value.Checked = false;
            checkBox_Default_Value.Checked = false;
            checkBox_Ranges_Values.Checked = false;
            checkBox_Comparisons_Allowed.Checked = false;
            checkBox_Operations_Allowed.Checked = false;
            checkBox_Edit_Rule.Checked = false;
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

        #region Update Rule
        private void Update_Rule()
        {
            Business_Rules.Update_RulesName(Rule_information.Id, Txt_RuleName.Text);
            var textBox = Business_Rules.Search_Rule_Information_Text_Boxs(Rule_information.Id);
            Business_Rules.Update_Rule_Information_Text_Boxs(textBox.Id, Txt_Statement.Text, Txt_Constraint.Text, Txt_Field_Names.Text, Txt_Table_Names.Text, Txt_Action_Taken.Text);
            var logical_elements = Business_Rules.Search_Logical_Elements(Rule_information.Id);
            Business_Rules.Update_Logical_Elements(checkBox_Key_Type.Checked, checkBox_Key_Structure.Checked, checkBox_Uniqueness.Checked, checkBox_NullSupport.Checked, checkBox_Values_Entered_By.Checked, checkBox_Required_Value.Checked, checkBox_Default_Value.Checked, checkBox_Ranges_Values.Checked, checkBox_Comparisons_Allowed.Checked, checkBox_Operations_Allowed.Checked, checkBox_Edit_Rule.Checked, logical_elements.Id);
            var physical_elements = Business_Rules.Search_Physical_Elements(Rule_information.Id);
            Business_Rules.Update_Physical_Elements(checkBox_Data_Type.Checked, checkBox_Length.Checked, checkBox_Decimal_Places.Checked, checkBox_Character_Support.Checked, checkBox_Input_Mask.Checked, checkBox_Display_Format.Checked, physical_elements.Id);
            var relationship_characteristics_affected = Business_Rules.Search_Relationship_Characteristics_Affected(Rule_information.Id);
            Business_Rules.Update_Relationship_Characteristics_Affected(checkBox_Deletion_Rule.Checked, checkBox_Type_Participation.Checked, checkBox_Degree_Participation.Checked, relationship_characteristics_affected.Id);
            var type = Business_Rules.Search_Type(Rule_information.Id);
            Business_Rules.Update_Type(checkBox_Database_Oriented.Checked, checkBox_Application_Oriented.Checked, type.Id);
            var categories = Business_Rules.Search_Categories(type.Id);
            Business_Rules.Update_Categories(checkBox_Field_Specific.Checked, checkBox_Relationship_Specific.Checked, categories.Id);
            var test_on = Business_Rules.Search_Test_On(type.Id);
            Business_Rules.Update_Test_On(checkBox_Insert.Checked, checkBox_Update.Checked, checkBox_Delete.Checked, test_on.Id);
        }
        private void Btn_Update_Rule_Click(object sender, EventArgs e)
        {
            Update_Rule();
            MessageBox.Show("Update Business Rule");
            Form_profil form_Profil = new Form_profil();
            this.Hide();
            form_Profil.Show();
        }
        #endregion
    }
}
