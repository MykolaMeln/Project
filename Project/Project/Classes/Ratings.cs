using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    public class Ratings : IRatings
    {
        public List<Rating> ratings = new List<Rating>();//список рейтингів
        public Ratings() { }

        public void AddRatingInList(Rating rating)//додавання рейтингу в список
        {
            ratings.Add(rating);
        }
        public void AddRating(Rating rating)//додавання рейтингу в базу
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Ratings(ID_User,ID_Station,Rating) VALUES(@user, @name, @rat)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@name", rating.ID_Station);
            cmd.Parameters.AddWithValue("@user", rating.ID_User);
            cmd.Parameters.AddWithValue("@rat", rating.rating);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(Rating rating)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE Rating SET Rating =@rat WHERE ID_Station=@name And ID_User = @user", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@rat", rating.rating);
            cmd.Parameters.AddWithValue("@name", rating.ID_Station);
            cmd.Parameters.AddWithValue("@user", rating.ID_User);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
