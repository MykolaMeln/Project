using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    public class Comment
    {
        public string user { get; set; }
        public string comment { get; set; }
        public DateTime date { get; set; }
        public Comment(string user, string comment, DateTime date)
        {
            this.user = user;
            this.comment = comment;
            this.date = date;
        }      
    }
}
