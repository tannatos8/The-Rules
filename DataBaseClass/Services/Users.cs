using Dapper;
using DataBaseClass.Connection;
using DataBaseClass.Entidades;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace DataBaseClass.Services
{
    public class Users
    {
        public static User Search(string user_name, string email)
        {
            string sql = "select idusers as id,user_name,email,password from users where user_name='"+user_name+"' or email='"+email+"';";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var user = conection.Query<User>(sql);
                return user.FirstOrDefault();
            }
        }

        public static bool Create(string user_name, string name, string last_name, string email, string password, string password_confirmation)
        {
            string sql = "INSERT INTO users (user_name, name, last_name, email, password, password_confirmation) VALUES('" + user_name+"', '"+name+"', '"+last_name+"', '"+email+"', '"+password+"', '"+password_confirmation+"'); ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {                
                try
                {
                    var user = conection.Execute(sql);
                    if (!user.Equals(0))
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

    }
}
