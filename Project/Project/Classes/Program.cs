using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    public class Program//програма
    {
        public string Id_Station { get; set; }
        public string Name_program { get; set; }
        public string Period { get; set; }
        public string Hour_begin { get; set; }
        public string Hour_end { get; set; }

        public Program(string Id_Station, string Name_program, string Period, string Hour_begin, string Hour_end)
        {
            this.Id_Station = Id_Station;
            this.Name_program = Name_program;
            this.Period = Period;
            this.Hour_begin = Hour_begin;
            this.Hour_end = Hour_end;
        }
    }
}
