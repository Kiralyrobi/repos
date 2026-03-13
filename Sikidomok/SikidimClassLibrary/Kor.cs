using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikidimClassLibrary
{
    public class Kor
    {
        public double Sugar {  get; private set; }
        public static List<Kor> KorokListaja=new List <Kor>();


        public Kor(double sugar)
        {
            this.Sugar = sugar;
            KorokListaja.Add(this);
        }
    }
}
