using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLibrary.DataAccess {
    public static class SqlDataAccess {
        public static string GetConnectonString(string connectionName = "CarDB") {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql) {
            using (IDbConnection cnn = new SqlConnection(GetConnectonString())) {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static int SaveData<T>(string sql, T data) {
            //return number of rows inputted into the database
            using (IDbConnection cnn = new SqlConnection(GetConnectonString())) {
                return cnn.Execute(sql, data);
            }
            
        }
    }

}
