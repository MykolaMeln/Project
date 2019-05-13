using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    class Favorites : IFavorites
    {
        public string User { get; set; }
        public string Station { get; set; }
        public Favorites(string user, string station)
        {
            User = user;
            Station = station;
        }
        public void AddFavorite()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Favorites(ID_User,ID_Station) VALUES(@user, @station)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@user", User);
            cmd.Parameters.AddWithValue("@station", Station);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteFavorite()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=project;Integrated Security=True");
            string del = "DELETE FROM Favorites WHERE ID_User=@user AND ID_Station=@station";
            conn.Open();
            SqlCommand cmd = new SqlCommand(del, conn);
            cmd.Parameters.AddWithValue("@user", User);
            cmd.Parameters.AddWithValue("@station", Station);
            cmd.ExecuteNonQuery();
        }
    }
}
