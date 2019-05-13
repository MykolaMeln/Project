using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    public class Programs : IPrograms
    {
        public List<Program> programs = new List<Program>();//список програм
        public Programs() { }

        public void AddProgramInList(Program program)//додавання програми в список
        {
            programs.Add(program);       
        }
        public void AddProgram(Program program)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Programs(ID_Station,Name_Program,Period,Hour_Begin,Hour_End) VALUES(@namer,@namep,@per,@hourb,@houre)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@namer", program.Id_Station);
            cmd.Parameters.AddWithValue("@namep", program.Name_program);
            cmd.Parameters.AddWithValue("@per", program.Period);
            cmd.Parameters.AddWithValue("@hourb", program.Hour_begin);
            cmd.Parameters.AddWithValue("@houre", program.Hour_end);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteProgram(Program p)//видалення програми
        {
            for (int k = 0; k < programs.Count; k++)
            {
                if (programs[k].Name_program == p.Name_program && programs[k].Id_Station == p.Id_Station)
                {
                    programs.Remove(programs[k]);
                    SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True");
                    string del = "DELETE FROM Programs WHERE ID_Station=@station AND Name_Program=@program";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(del, conn);
                    cmd.Parameters.AddWithValue("@station", p.Id_Station);
                    cmd.Parameters.AddWithValue("@program", p.Name_program);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateProgram(Program p, int indx)//оновлення програми
        {
            int k = 0;
            for (int i = 0; i < programs.Count; i++)
            {
                if (programs[i].Id_Station == p.Id_Station)
                {
                    if (k == indx)
                    {
                        programs[i] = p;
                        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("UPDATE Programs SET Password = @pas WHERE Login=@log", conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@names", p.Id_Station);
                        cmd.Parameters.AddWithValue("@namep", p.Name_program);
                        cmd.Parameters.AddWithValue("@per", p.Period);
                        cmd.Parameters.AddWithValue("@namep", p.Name_program);
                        cmd.Parameters.AddWithValue("@names", p.Id_Station);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                      
                        cmd.ExecuteNonQuery();
                    }
                    else
                        k++;
                }
            }
        }
    }
}
