using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario
{
    internal class Planetario
    {
        public const double G = 5;    
        public List<Pianeta> Pianeti { get; set; }

        public Planetario()
        {

            Pianeti = new List<Pianeta>() ;
        }

    }
}
