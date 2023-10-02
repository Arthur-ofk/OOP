using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.problem2
{
    public class Ferrari : ICar
    {
        private const string Model = "488-Spider";
        private string driver;

        public Ferrari(string driver)
        {
            this.driver = driver;
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{Model}/{UseBrakes()}/{PushGasPedal()}/{driver}";
        }
    }

}
