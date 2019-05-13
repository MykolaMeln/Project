using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    public class Rating
    {
        public string ID_User;
        public string ID_Station;
        public int rating;
        public Rating(string ID_User, string ID_Station, int rating)
        {
            this.ID_User = ID_User;
            this.ID_Station = ID_Station;
            this.rating = rating;
        }
    }
}
