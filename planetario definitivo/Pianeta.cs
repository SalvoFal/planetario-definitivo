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
    internal class Pianeta
    {
        public double Massa { get; set; }
        public Vettore Spostamento { get; set; }
        public Vettore Velocita { get; set; }
        public SolidBrush Brush { get; set; }
        public string Nome { get; set; }
        public Vettore Forza { get; set; }
        public Vettore Accelerazione { get; set; }
        public double Raggio { get; set; }
        public Pianeta(double massa, Vettore spostamento, Vettore velocita, SolidBrush brush, string nome, double raggio)
        {
            Massa = massa;
            Spostamento = spostamento;
            Velocita = velocita;
            Brush = brush;
            Nome = nome;
            Raggio = raggio;
        }

        public override string ToString()
        {
            return string.Format("{0}; {1}; {2}; {3}; {4}", Massa, Spostamento.X, Spostamento.Y, Velocita.X, Velocita.Y);
        }
    }
}
