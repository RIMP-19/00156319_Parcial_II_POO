using System.Data;
using Npgsql;

namespace Parcial_II.Modelo
{
    public static class DBConnection
    {
        private const string Username = "postgres";
        private const string Password = "081416171819";
        private const string DataBase = "Parcial_02";

        private static string ConnectionString =
            $"Host=127.0.0.1;Username={Username};Password={Password};Database={DataBase}";

        public static DataTable ExecuteQuery(string query)
        {
            var conn = new NpgsqlConnection(ConnectionString);
            var ds = new DataSet();
            
            conn.Open();
            var da = new NpgsqlDataAdapter(query,conn);
            da.Fill(ds);
            conn.Close();
            
            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string command)
        {
            var conn = new NpgsqlConnection(ConnectionString);
            
            conn.Open();
            var nc = new NpgsqlCommand(command,conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }
    }
}