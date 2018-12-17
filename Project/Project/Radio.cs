using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Radio
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Frequency { get; set; }
        public Radio(int id, string name, float frequency)
        {
            ID = id;
            Name = name;
            Frequency = frequency;
        }
    }
}
