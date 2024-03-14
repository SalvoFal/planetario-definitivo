using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classe_vettori;
using Planetario;

namespace planetario_definitivo
{
    public partial class Form1 : Form
    {
        Planetario.Planetario planetario = new Planetario.Planetario();

        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            btnStart.Height = ClientSize.Height; 
            btnStart.Width = ClientSize.Width;
        }

        
        private void btnAggiungi_Click(object sender, EventArgs e)
        {

            if (!Vettore.TryParse(txtSpostamento.Text, out Vettore spostamento) == true)
            {
                MessageBox.Show("bisogna inserire un vettore");
            }
            else
            {

                if (!Vettore.TryParse(txtVelocita.Text, out Vettore velocita) == true)
                {
                    MessageBox.Show("bisogna inserire un vettore");
                }
                else { 
                string nome = txtNome.Text;
                    if (!double.TryParse(txtMassa.Text, out double massa) == true)
                    {
                        MessageBox.Show("bisogna inserire un valore numerico");
                    }
                    else
                    {

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
                        else if (cmbColore.SelectedIndex == 6)
                        {
                            b = new SolidBrush(Color.Pink);
                        }
                        else
                        {
                            MessageBox.Show("Inserire un colore!!!");
                            return;
                        }
                        
                        listBox1.Items.Add(nome);
                        txtMassa.Clear();
                        txtSpostamento.Clear();
                        txtVelocita.Clear();
                        txtNome.Clear();
                        cmbColore.SelectedIndex = -1;
                        planetario.Pianeti.Add(new Pianeta(massa, spostamento, velocita, b, nome));

                        
                    }
                }
            }   
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

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
     
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            lblStart.Hide();
        }

        public void StampaPlanetario(Graphics g)
        {
            var g = this.CreateGraphics();
            foreach (Pianeta pianeta in planetario.Pianeti)
            {
                DisegnaPianeti(g, p);
            }
        }

        public void DisegnaPianeti(Graphics g, Pianeta p)
        {
            g.FillEllipse(p.Brush, (float)p.Spostamento.X, (float)p.Spostamento.Y, 7, 7);
        }

    }
}
