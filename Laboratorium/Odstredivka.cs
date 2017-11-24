using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    class Odstredivka : Pristroj,IOvladanie
    {
        public override void VypisDetailneInfo()
        {
            base.VypisInfo(); // base - volam funkciu z bazoveho suboru
            Console.WriteLine("Som odstredivka");
            base.VypisStav();

        }
        public void Zapni()
        {
            zapnute = true;
        }
        public void Vypni()
        {
            zapnute = false;
        }
    }
}
