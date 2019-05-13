using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    public class Favorites : IFavorites
    {
        public List<Favorite> favorites = new List<Favorite>();//список програм
        public Favorites() { }
        public string AddFavorite(Favorite favorite)
        {
            int k = 0;
            string res = "";
            foreach(Favorite fav in favorites)
            {
                if((fav.User == favorite.User) &&(fav.Station == favorite.Station))
                {
                    k++;
                }
            }

            if (k == 0)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Favorites(ID_User,ID_Station) VALUES(@user, @station)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@user", favorite.User);
                cmd.Parameters.AddWithValue("@station", favorite.Station);
                cmd.ExecuteNonQuery();
                conn.Close();
                res = favorite.Station+" added.";
            }
            else
            {
                DeleteFavorite(favorite);
                res = favorite.Station + " deleted.";
            }
            return res;
        }
        public void AddFavoriteInList(Favorite favorite)
        {
            favorites.Add(favorite);
        }
        public void DeleteFavorite(Favorite favorite)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True");
            string del = "DELETE FROM Favorites WHERE ID_User=@user AND ID_Station=@station";
            conn.Open();
            SqlCommand cmd = new SqlCommand(del, conn);
            cmd.Parameters.AddWithValue("@user", favorite.User);
            cmd.Parameters.AddWithValue("@station", favorite.Station);
            cmd.ExecuteNonQuery();
        }

    }
}
