using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using classe_vettori;

namespace Planetario
{
    internal class Pianeti
    {
        public double Massa { get; set; }
        public Vettore Spostamento { get; set; }
        public Vettore Velocita { get; set; }
        public SolidBrush Brush { get; set; }
        public string Nome { get; set; }
        public Pianeti(double massa, Vettore spostamento, Vettore velocita, SolidBrush brush, string nome)
        {
            Massa = massa;
            Spostamento = spostamento;
            Velocita = velocita;
            Brush = brush;
            Nome = nome;

        }
        public void DisegnaPianeti(Graphics g, SolidBrush brush)
        {
            g.FillEllipse(brush, (float)this.Spostamento.X, (float)this.Spostamento.Y, 7, 7);
        }
    }
}
