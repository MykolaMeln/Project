using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Favorite
    {
        public string User { get; set; }
        public string Station { get; set; }
        public Favorite(string user, string station)
        {
            User = user;
            Station = station;
        }
    }
}
