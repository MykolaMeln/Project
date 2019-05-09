using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    class Rating : IRating
    {
        public void Update(string name)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE Radio_Stations SET Rating+=@rat WHERE Name_Station=@name",conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@rat", 1);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
            conn.Close();       
        }
    }
}
