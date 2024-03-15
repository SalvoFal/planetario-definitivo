using classe_vettori;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Planetario
{
    internal class Planetario
    {
        public const double G = 5;    
        public List<Pianeta> Pianeti { get; set; }

        public Planetario()
        {

            Pianeti = new List<Pianeta>();
        }
        public void Move()
        {
            foreach (Pianeta p in Pianeti) 
            {
                foreach (Pianeta p1 in Pianeti)
                {
                    if (p != p1)
                    {
                        Vettore raggio = p1.Spostamento - p.Spostamento;
                        p.Forza += (G * p.Massa * p1.Massa) / (raggio * raggio) * (raggio / raggio.Modulo());
                    }
                }
                p.Accelerazione = p.Forza / p.Massa;
                p.Velocita += p.Velocita * 0.001;
            }
            
        }
    }
}
