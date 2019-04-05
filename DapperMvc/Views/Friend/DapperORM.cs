using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DapperMvc.Views.Friend
{
    public static class DapperORM
    {
        private static string connectionString = @"Data Source=KAJIMO-PC;Initial Catalog=Friends;Integrated Security=True";

        public static void ExecuteWithoutReturn (string procedureName, DynamicParameters param)
        {
            using (SqlConnection con = new SqlConnection (connectionString))
            {
                con.Open();
                con.Execute(procedureName, param, commandType: CommandType.StoredProcedure);

            }
        }


        public static T ExecuteReturnScalar<T>(string procedureName, DynamicParameters param)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
               return(T) Convert.ChangeType (con.ExecuteScalar(procedureName, param, commandType: CommandType.StoredProcedure), typeof(T));

            }
        }
    }
}