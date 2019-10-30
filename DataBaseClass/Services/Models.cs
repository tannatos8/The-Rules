using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using DataBaseClass.Entidades;
using System.Linq;
using DataBaseClass.Connection;

namespace DataBaseClass.Services
{
    public class Models
    {
        public static bool Create_Model(string project_name, string project_description, int users_idusers)
        {
            string sql = "INSERT INTO models (project_name, project_description, users_idusers) VALUES('" + project_name + "', '" + project_description + "', " + users_idusers + "); ";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                try
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
                catch (System.Exception)
                {

                    return false;
                }

            }
        }

        public static bool Update_Model(string new_project_name, string new_project_description, int id) 
        {
            string sql = "UPDATE models SET project_name = '" + new_project_name + "', project_description = '" + new_project_description + "' WHERE idmodels = " + id + "; ";
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

        public static Model Search_Model(string project_name)
        {
            string sql = "select idmodels as id, project_name,project_description from models where project_name='"+project_name+"';";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var model = conection.Query<Model>(sql);
                return model.FirstOrDefault();
            }
        }

        /// <summary>
        /// Profile_Information.Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Model> GetAll(int id)
        {
            string sql = "select project_name from models where users_idusers ='"+id+"'";
            using (var conection = new MySqlConnection(MysqlConnection.Connection))
            {
                var modelList = conection.Query<Model>(sql);
                return modelList.ToList();
            }
        }

        public static bool Delete_Model(int id)
        {
            string sql = "DELETE FROM models WHERE idmodels = " + id + "; ";
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
    }
}
