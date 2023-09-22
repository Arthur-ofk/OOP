using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Department
    {
        public string Name { get; set; }
        public Dictionary<int, List<Patient>> Rooms { get; set; }

        public Department(string name)
        {
            Name = name;
            Rooms = new Dictionary<int, List<Patient>>();
            for (int i = 1; i <= 20; i++)
                Rooms[i] = new List<Patient>();
        }
    }
}
