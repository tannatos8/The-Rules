using Dapper;
using DataBaseClass.Connection;
using DataBaseClass.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseClass.Services
{
    public class Business_Rules
    {
        #region Searchs_Rules
        public static Business_Rule Search_Rule(string rules_name)
        {
            string sql = "select idbusiness_rules as id, rules_name from business_rules where rules_name='" + rules_name + "';";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var rule = conection.Query<Business_Rule>(sql);
                return rule.FirstOrDefault();
            }
        }
        
        public static List<Business_Rule> GetAll(int id)
        {
            string sql = "select rules_name from business_rules where models_idmodels ='" + id + "'";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var modelList = conection.Query<Business_Rule>(sql);
                return modelList.ToList();
            }
        }

        public static Typee Search_Type(int business_rules_idbusiness_rules)
        {
            string sql = "select idtype as id, data_base_oriented, application_oriented from type where business_rules_idbusiness_rules=" + business_rules_idbusiness_rules + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var rule = conection.Query<Typee>(sql);
                return rule.FirstOrDefault();
            }
        }

        public static Logical_Elements Search_Logical_Elements(int business_rules_idbusiness_rules)
        {
            string sql = "select idlogical_elements as id,key_type,key_structure,uniqueness,null_support,values_entered_by,required_value,default_value,ranges_of_values,comparisons_allowed,operations_allowed,edit_rule from logical_elements where business_rules_idbusiness_rules=" + business_rules_idbusiness_rules + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var rule = conection.Query<Logical_Elements>(sql);
                return rule.FirstOrDefault();
            }
        }
        public static Physical_Elements Search_Physical_Elements(int business_rules_idbusiness_rules)
        {
            string sql = "select idphysical_elements as id,data_type,length,decimal_places,character_support,input_mask,display_format from physical_elements where business_rules_idbusiness_rules=" + business_rules_idbusiness_rules + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var rule = conection.Query<Physical_Elements>(sql);
                return rule.FirstOrDefault();
            }
        }
        public static Relationship_Characteristics_Affected Search_Relationship_Characteristics_Affected(int business_rules_idbusiness_rules)
        {
            string sql = "select idrelationship_characteristics_affected as id,deletion_rule,type_of_participation,degree_of_participati from relationship_characteristics_affected where business_rules_idbusiness_rules=" + business_rules_idbusiness_rules + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var rule = conection.Query<Relationship_Characteristics_Affected>(sql);
                return rule.FirstOrDefault();
            }
        }
        public static Rule_information_text_boxs Search_Rule_Information_Text_Boxs(int business_rules_idbusiness_rules)
        {
            string sql = "select idrule_information_text_boxs as id, statement,constraints,field_names,table_names,action_taken from rule_information_text_boxs where business_rules_idbusiness_rules=" + business_rules_idbusiness_rules + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var rule = conection.Query<Rule_information_text_boxs>(sql);
                return rule.FirstOrDefault();
            }
        }
        public static Categories Search_Categories(int id)
        {
            string sql = "select idcategories as id,field_specfic,relationship_specific from categories where type_idtype=" + id + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var rule = conection.Query<Categories>(sql);
                return rule.FirstOrDefault();
            }
        }
        public static Test_On Search_Test_On(int id)
        {
            string sql = "select idtest_on as id,inserts,updates,deletes from test_on where type_idtype=" + id + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var rule = conection.Query<Test_On>(sql);
                return rule.FirstOrDefault();
            }
        }


        #endregion

        #region Creates_Rules
        public static bool Create_Rule(string rules_name, int models_idmodels)
        {
            string sql = "INSERT INTO business_rules (rules_name, models_idmodels) VALUES('" + rules_name + "', " + models_idmodels + "); ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                try
                {
                    var rule = conection.Execute(sql);
                    if (!rule.Equals(0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    return false;
                }

            }
        }
        public static bool Create_Rule_Information(string statement, string constraints, string field_names, string table_names, string action_taken, int business_rules_idbusiness_rules)
        {
            string sql = "INSERT INTO rule_information_text_boxs (statement, constraints, field_names, table_names, action_taken, business_rules_idbusiness_rules) VALUES ('" + statement + "','" + constraints + "','" + field_names + "','" + table_names + "','" + action_taken + "', " + business_rules_idbusiness_rules + "); ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                try
                {
                    //Comentarios 
                    var rule = conection.Execute(sql);
                    if (!rule.Equals(0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    return false;
                }

            }
        }
        public static bool Create_logical_elements(bool key_type, bool key_structure, bool uniqueness, bool null_support, bool values_entered_by, bool required_value, bool default_value, bool ranges_of_values, bool comparisons_allowed, bool operations_allowed, bool edit_rule, int business_rules_idbusiness_rules)
        {
            string sql = "INSERT INTO logical_elements (key_type, key_structure, uniqueness, null_support, values_entered_by, required_value, default_value, ranges_of_values, comparisons_allowed, operations_allowed, edit_rule, business_rules_idbusiness_rules) VALUES(" + key_type + "," + key_structure + "," + uniqueness + "," + null_support + "," + values_entered_by + "," + required_value + "," + default_value + "," + ranges_of_values + "," + comparisons_allowed + "," + operations_allowed + "," + edit_rule + ", " + business_rules_idbusiness_rules + "); ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                try
                {
                    var rule = conection.Execute(sql);
                    if (!rule.Equals(0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    return false;
                }

            }
        }
        public static bool Create_physical_elements(bool data_type, bool length, bool decimal_places, bool character_support, bool input_mask, bool display_format, int business_rules_idbusiness_rules)
        {
            string sql = "INSERT INTO physical_elements ( data_type, length, decimal_places, character_support, input_mask, display_format, business_rules_idbusiness_rules) VALUES(" + data_type + "," + length + "," + decimal_places + "," + character_support + "," + input_mask + "," + display_format + ", " + business_rules_idbusiness_rules + "); ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                try
                {
                    var rule = conection.Execute(sql);
                    if (!rule.Equals(0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    return false;
                }

            }
        }
        public static bool Create_relationship_characteristics_affected(bool deletion_rule, bool type_of_participation, bool degree_of_participati, int business_rules_idbusiness_rules)
        {
            string sql = "INSERT INTO relationship_characteristics_affected ( deletion_rule, type_of_participation, degree_of_participati, business_rules_idbusiness_rules) VALUES(" + deletion_rule + "," + type_of_participation + "," + degree_of_participati + ", " + business_rules_idbusiness_rules + "); ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                try
                {
                    var rule = conection.Execute(sql);
                    if (!rule.Equals(0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    return false;
                }

            }
        }
        public static bool Create_type(bool data_base_oriented, bool application_oriented, int business_rules_idbusiness_rules)
        {
            string sql = "INSERT INTO type ( data_base_oriented, application_oriented, business_rules_idbusiness_rules) VALUES(" + data_base_oriented + "," + application_oriented + ", " + business_rules_idbusiness_rules + "); ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                try
                {
                    var rule = conection.Execute(sql);
                    if (!rule.Equals(0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    return false;
                }

            }
        }
        public static bool Create_categories(bool field_specfic, bool relationship_specific, int type_idtype)
        {
            string sql = "INSERT INTO categories ( field_specfic, relationship_specific, type_idtype) VALUES(" + field_specfic + "," + relationship_specific + ", " + type_idtype + "); ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                try
                {
                    var rule = conection.Execute(sql);
                    if (!rule.Equals(0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    return false;
                }

            }
        }
        public static bool Create_test_on(bool insert, bool update, bool delete, int type_idtype)
        {
            string sql = "INSERT INTO test_on ( inserts, updates, deletes, type_idtype) VALUES(" + insert + "," + update + "," + delete + ", " + type_idtype + "); ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                try
                {
                    var rule = conection.Execute(sql);
                    if (!rule.Equals(0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    return false;
                }

            }
        }
        #endregion

        #region Update_Rules
        public static bool Update_RulesName(int id, string idbusiness_rules)
        {
            string sql = "UPDATE business_rules SET rules_name = '" + idbusiness_rules + "' WHERE idbusiness_rules = " + id + "; ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var user_profile = conection.Execute(sql);
                if (!user_profile.Equals(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool Update_Rule_Information_Text_Boxs(int id, string statement, string constraints, string field_names, string table_names, string action_taken)
        {
            string sql = "UPDATE rule_information_text_boxs SET statement = '" + statement + "', constraints = '" + constraints + "', field_names ='" + field_names + "',table_names='" + table_names + "',action_taken='" + action_taken + "' WHERE idrule_information_text_boxs = " + id + "; ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var user_profile = conection.Execute(sql);
                if (!user_profile.Equals(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool Update_Logical_Elements(bool key_type, bool key_structure, bool uniqueness, bool null_support, bool values_entered_by, bool required_value, bool default_value, bool ranges_of_values, bool comparisons_allowed, bool operations_allowed, bool edit_rule, int id)
        {
            string sql = "UPDATE logical_elements SET key_type = " + key_type + ", key_structure = " + key_structure + ", uniqueness =" + uniqueness + ",null_support=" + null_support + ",values_entered_by=" + values_entered_by + ",required_value=" + required_value + ",default_value=" + default_value + ",ranges_of_values=" + ranges_of_values + ",comparisons_allowed=" + comparisons_allowed + ",operations_allowed=" + operations_allowed + ",edit_rule=" + edit_rule + " WHERE idlogical_elements = " + id + "; ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var user_profile = conection.Execute(sql);
                if (!user_profile.Equals(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool Update_Physical_Elements(bool data_type, bool length, bool decimal_places, bool character_support, bool input_mask, bool display_format, int id)
        {
            string sql = "UPDATE physical_elements SET data_type = " + data_type + ", length = " + length + ", decimal_places =" + decimal_places + ",character_support=" + character_support + ",input_mask=" + input_mask + ",display_format=" + display_format + " WHERE idphysical_elements = " + id + "; ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var user_profile = conection.Execute(sql);
                if (!user_profile.Equals(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool Update_Relationship_Characteristics_Affected(bool deletion_rule, bool type_of_participation, bool degree_of_participati, int id)
        {
            string sql = "UPDATE relationship_characteristics_affected SET deletion_rule = " + deletion_rule + ", type_of_participation = " + type_of_participation + ", degree_of_participati =" + degree_of_participati + " WHERE idrelationship_characteristics_affected = " + id + "; ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var user_profile = conection.Execute(sql);
                if (!user_profile.Equals(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool Update_Type(bool data_base_oriented, bool application_oriented, int id)
        {
            string sql = "UPDATE type SET data_base_oriented = " + data_base_oriented + ", application_oriented = " + application_oriented + " WHERE idtype = " + id + "; ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var user_profile = conection.Execute(sql);
                if (!user_profile.Equals(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool Update_Categories(bool field_specfic, bool relationship_specific, int id)
        {
            string sql = "UPDATE categories SET field_specfic = " + field_specfic + ", relationship_specific = " + relationship_specific + " WHERE idcategories = " + id + "; ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var user_profile = conection.Execute(sql);
                if (!user_profile.Equals(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool Update_Test_On(bool insert, bool update, bool delete, int id)
        {
            string sql = "UPDATE test_on SET inserts = " + insert + ", updates = " + update + ", deletes = " + delete + " WHERE idtest_on = " + id + "; ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var user_profile = conection.Execute(sql);
                if (!user_profile.Equals(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

        #region Delete_Rules

        public static bool Delete_Rule(int id)
        {
            string sql = "DELETE FROM business_rules WHERE idbusiness_rules = " + id + "; ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var model = conection.Execute(sql);
                if (!model.Equals(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

        #region Filtre

        public static List<Typee> Filtre_Data_Bases_Oriented(int data_base_oriented)
        {
            string sql = "select business_rules_idbusiness_rules from type where data_base_oriented=" + data_base_oriented + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var modelList = conection.Query<Typee>(sql);
                return modelList.ToList();
            }
        }

        public static List<Typee> Filtre_Application_Oriented(int application_oriented)
        {
            string sql = "select business_rules_idbusiness_rules from type where application_oriented=" + application_oriented + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var modelList = conection.Query<Typee>(sql);
                return modelList.ToList();
            }
        }
        public static Business_Rule Search_Rule_Id(int id)
        {
            string sql = "select rules_name from business_rules where idbusiness_rules=" + id + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var rule = conection.Query<Business_Rule>(sql);
                return rule.FirstOrDefault();
            }
        }
        public static Business_Rule Search_RuleName_IdModel(string rules_name, int id)
        {
            string sql = "select rules_name from business_rules where rules_name='" + rules_name + "' and models_idmodels=" + id + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var rule = conection.Query<Business_Rule>(sql);
                return rule.FirstOrDefault();
            }
        }

        #endregion
    }
}
