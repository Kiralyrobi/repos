using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySzoba
{
    public class Szoba
    {
        public double Hosszusag {  get; set; }
        public double Szelesseg { get; set; }
        public double Magassag { get; set; }

        public Szoba(double h, double sz, double m)
        {
            this.Hosszusag = h;
            this.Szelesseg = sz;
            this.Magassag = m;
        }

        public double Alapterulet()
        {
            return Math.Round(this.Hosszusag * this.Szelesseg, 2);
        }

        public double Terfogat()
        {
            return Math.Round(this.Hosszusag * this.Szelesseg * this.Magassag , 2);
        }

        public double FalFelulet()
        {
            double hosszuoldal = this.Hosszusag * this.Magassag * 2;
            double rovidoldal = this.Szelesseg * this.Magassag * 2;
            double plafon = this.Alapterulet();
            return Math.Round(hosszuoldal + rovidoldal + plafon, 2);
        }
    }
}
