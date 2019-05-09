using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    public class Comments :IComments
    {
        public List<Comment> comments = new List<Comment>();//список коментарів
        public Comments() { }

        public void AddComment(Comment comment)//додавання коментаря в список
        {
            comments.Add(comment);
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Comment(ID_User,Comment,Date) VALUES(@user, @comment, @date)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@user", comment.user);
            cmd.Parameters.AddWithValue("@comment", comment.comment);
            cmd.Parameters.AddWithValue("@date", comment.date);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteComment(int number)//видалення коментаря
        {

            for (int k = 1; k <= comments.Count; k++)
            {
                if (k == number)
                {
                    Comment c = comments[k];
                    comments.Remove(c);
                    SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True");
                    string del = "DELETE FROM Comments WHERE ID_User=@user AND Comment=@comment";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(del, conn);
                    cmd.Parameters.AddWithValue("@user", c.user);
                    cmd.Parameters.AddWithValue("@comment", c.comment);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
