using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    partial class Laboratorium
    {
        public Pristroj laboratorniPristroj1;
        public Pristroj laboratorniPristroj2;


        public void SpustVyskum()
        {
            Veduci veduci = new Veduci("Fero");


            laboratorniPristroj1 = new Mikroskop();
            laboratorniPristroj2 = new Odstredivka();

            laboratorniPristroj1.Nazov = "mik200";
            laboratorniPristroj2.Nazov = "ods300";


            IOvladanie ovladanie = (IOvladanie)laboratorniPristroj1;
            ovladanie.Zapni();

            laboratorniPristroj1.VypisDetailneInfo();
            laboratorniPristroj2.VypisDetailneInfo();

        }
    }
}
