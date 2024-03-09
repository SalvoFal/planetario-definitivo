﻿using System;
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
        Pianeti[] p = new Pianeti[10000000];
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
            else if (cmbColore.SelectedIndex == 6)
            {
                b = new SolidBrush(Color.Pink);
            }
            else
            {
                MessageBox.Show("Inserire un colore!!!");
                return;
            }
            p[contatore - 1] = new Pianeti(massa, spostamento, velocita, b, nome);
            listBox1.Items.Add(nome);
            txtMassa.Clear();
            txtSpostamento.Clear();
            txtVelocita.Clear();
            txtNome.Clear();
            cmbColore.SelectedIndex = -1;
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

    }
}
