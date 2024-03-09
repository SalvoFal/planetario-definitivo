using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classe_vettori;
using Planetario;

namespace planetario_definitivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graphics g = this.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

        }
        int contatore = 0;
        Vettore[] s = new Vettore[10000000];
        Vettore[] v = new Vettore[10000000];
        string[] n = new string[10000000];
        double[] m = new double[10000000];
        int[] c = new int[10000000];
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            contatore++;
            Vettore spostamento = Vettore.Parse(txtSpostamento.Text);
            Vettore velocita = Vettore.Parse(txtVelocita.Text);
            string nome = txtNome.Text;
            double massa = double.Parse(txtMassa.Text);
            SolidBrush b = new SolidBrush(Color.Black);
            if (cmbColore.SelectedIndex == 0)
            {
                b = new SolidBrush(Color.Blue);
            }
            else if (cmbColore.SelectedIndex == 1)
            {
                b = new SolidBrush(Color.Yellow);
            }
            else if (cmbColore.SelectedIndex == 2)
            {
                b = new SolidBrush(Color.Red);
            }
            else if (cmbColore.SelectedIndex == 3)
            {
                b = new SolidBrush(Color.Green);
            }
            else if (cmbColore.SelectedIndex == 4)
            {
                b = new SolidBrush(Color.Orange);
            }
            else if (cmbColore.SelectedIndex == 5)
            {
                b = new SolidBrush(Color.White);
            }
            else
            {
                b = new SolidBrush(Color.Pink);
            }
            s[contatore - 1] = Vettore.Parse(txtSpostamento.Text);
            v[contatore - 1] = Vettore.Parse(txtVelocita.Text);
            n[contatore - 1] = txtNome.Text;
            m[contatore - 1] = double.Parse(txtMassa.Text);
            c[contatore - 1] = cmbColore.SelectedIndex;
            Pianeti p1 = new Pianeti(massa, spostamento, velocita, b, nome);
            listBox1.Items.Add(nome);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            listBox1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            txtMassa.Hide();
            txtSpostamento.Hide();
            txtVelocita.Hide();
            txtNome.Hide();
            btnAggiungi.Hide();
            btnPlay.Hide();
            btnRimuovi.Hide();
            cmbColore.Hide();
        }
    }
}
