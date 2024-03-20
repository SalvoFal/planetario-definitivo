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
            btnStartStop.Hide();
            btnExit.Hide();
            timer.Enabled = true;
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
                        if (!double.TryParse(txtRaggio.Text, out double raggio) == true)
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
                            txtRaggio.Clear();
                            cmbColore.SelectedIndex = -1;
                            planetario.Pianeti.Add(new Pianeta(massa, spostamento, velocita, b, nome, raggio));

                        }
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
            lblRaggio.Hide();
            txtMassa.Hide();
            txtSpostamento.Hide();
            txtVelocita.Hide();
            txtNome.Hide();
            btnAggiungi.Hide();
            btnPlay.Hide();
            btnRimuovi.Hide();
            cmbColore.Hide();
            txtRaggio.Hide();
            

            StampaPlanetario();
            btnExit.Visible = true;
            btnStartStop.Visible = true;
            timer.Enabled = true;

            
            
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            planetario.Pianeti.RemoveAt(listBox1.SelectedIndex + 1);
     
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            lblStart.Hide();
            timer.Enabled = false;
        }

        public void StampaPlanetario()
        {
            Graphics graphics = this.CreateGraphics();
            foreach (Pianeta pianeta in planetario.Pianeti)
            {
                graphics.FillEllipse(pianeta.Brush, (float)(pianeta.Spostamento.X/1e9), (float)(pianeta.Spostamento.Y/1e9), (float)pianeta.Raggio, (float)pianeta.Raggio);
            }
        }

        

        private void timer_Tick(object sender, EventArgs e)
        {
            Refresh();
            btnStart.Height = ClientSize.Height;
            btnStart.Width = ClientSize.Width;
            lblStart.Location = new Point((ClientSize.Width - lblStart.Width) / 2, ClientSize.Height - 50);
            btnExit.Location = new Point(50, 20);
            btnStartStop.Location = new Point(ClientSize.Width - btnStartStop.Width - 50, 20);
            planetario.Move();
            StampaPlanetario();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            btnExit.Hide();
            btnStartStop.Hide();
            listBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            txtMassa.Visible = true;
            txtSpostamento.Visible = true;
            txtVelocita.Visible = true;
            txtNome.Visible = true;
            txtRaggio.Visible = true;
            lblRaggio.Visible = true;
            btnAggiungi.Visible = true;
            btnPlay.Visible = true;
            btnRimuovi.Visible = true;
            cmbColore.Visible = true;

            timer.Enabled= false;
            
            listBox1.Items.Clear();
            planetario.Pianeti = new List<Pianeta>();
            graphics.Clear(Color.Black);

                               
                        
        }
        int contatore = 0;
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            contatore++;
            if(contatore % 2 == 1)
            {
                btnStartStop.Text = "START";
                timer.Stop();
            }
            else
            {
                btnStartStop.Text = "STOP";
                timer.Start();
            }
              
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Graphics graphics = this.CreateGraphics();
                btnExit.Hide();
                btnStartStop.Hide();
                listBox1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                txtMassa.Visible = true;
                txtRaggio.Visible = true;
                lblRaggio.Visible = true;
                txtSpostamento.Visible = true;
                txtVelocita.Visible = true;
                txtNome.Visible = true;
                btnAggiungi.Visible = true;
                btnPlay.Visible = true;
                btnRimuovi.Visible = true;
                cmbColore.Visible = true;

                timer.Enabled = false;

                listBox1.Items.Clear();
                planetario.Pianeti = new List<Pianeta>();
                graphics.Clear(Color.Black);
            }
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            btnPlay.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            btnExit.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            label1.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            label2.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            label3.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            label4.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            txtMassa.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            txtSpostamento.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            txtVelocita.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            txtNome.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            txtRaggio.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            lblRaggio.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            btnAggiungi.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            btnStartStop.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            btnRimuovi.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
            listBox1.Size = new Size(ClientSize.Width / 5, ClientSize.Height / 4);
            cmbColore.Size = new Size(ClientSize.Width / 12, ClientSize.Height / 24);
        }
    }
}
