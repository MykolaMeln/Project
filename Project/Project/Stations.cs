using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Stations
    {
        public List<Radio> stations = new List<Radio>();
        public Stations() { }
        public void AddRadio(Radio station)
        {
            stations.Add(station);
        }
    }
}
