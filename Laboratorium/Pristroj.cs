using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    abstract class Pristroj
    {
        protected bool zapnute;
        public string Nazov;
        public abstract void VypisDetailneInfo();
        public virtual void VypisInfo()
        {
            Console.WriteLine("Pristroj ktoreho nazov je {0}", Nazov); 
        }
        protected void VypisStav()
        {
            Console.WriteLine("Zapnute: {0}", zapnute);
        }

    }
}
