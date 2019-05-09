using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Radio
    {
        public string Name { get; set; }//назва станції
        public float Frequency { get; set; }//частота відтворення
        public int Rating { get; set; }//рейтинг
        public Radio(string name, float frequency, int rating)
        {
            Name = name;
            Frequency = frequency;
            Rating = rating;
        }
    }
}
