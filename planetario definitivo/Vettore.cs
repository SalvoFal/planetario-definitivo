using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_vettori
{
    internal class Vettore
    {
        public double X { get; }
        public double Y { get; }
        public Vettore(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static double operator *(Vettore v1, Vettore v2)
        {
            double prodotto = v1.X * v2.X + v1.Y * v2.Y;
            return prodotto;
        }
        public static Vettore operator *(Vettore v1, double n)
        {
            return new Vettore(v1.X * n, v1.Y * n);
        }
        public static Vettore operator *(double n, Vettore v1)
        {
            return new Vettore(v1.X * n, v1.Y * n);
        }
        public static Vettore operator +(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vettore operator +(Vettore v1)
        {
            return v1;
        }
        public static Vettore operator -(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static Vettore operator -(Vettore v1)
        {
            return new Vettore(-v1.X, -v1.Y);
        }
        public static Vettore operator /(Vettore v1, double n)
        {
            return new Vettore(v1.X / n, v1.Y / n);
        }
        public double Modulo()
        {
            return (Math.Sqrt(this.X * this.X + this.Y * this.Y));
        }
        public static bool operator ==(Vettore v1, Vettore v2)
        {
            if (v1.X == v2.X && v1.Y == v2.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Vettore v1, Vettore v2)
        {
            if (v1.X == v2.X && v1.Y == v2.Y)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return string.Format("{0};{1}", X, Y);
        }
        public static Vettore Parse(string s)
        {
            string[] parts = s.Split(';');
            return new Vettore(double.Parse(parts[0]), double.Parse(parts[1]));
        }
        public static bool TryParse(string s, out Vettore vettore)
        {
            try
            {
                vettore = Vettore.Parse(s);
                return true;
            }
            catch
            {
                vettore = null;
                return false;
            }
        }
    }
}
