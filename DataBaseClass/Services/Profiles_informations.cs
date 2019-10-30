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
    public class Profiles_informations
    {
        public static User Search_Profile(int id)
        {
            string sql = "select idusers as id,user_name,name,last_name,email from users where idusers=" + id + ";";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var user_profile = conection.Query<User>(sql);
                return user_profile.FirstOrDefault();
            }
        }

        public static bool Update_Profile(int id, string new_password, string new_password_confirmation)
        {
            string sql = "UPDATE users SET password = '" + new_password + "', password_confirmation = '" + new_password_confirmation + "' WHERE idusers = " + id + "; ";
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
    }
}
