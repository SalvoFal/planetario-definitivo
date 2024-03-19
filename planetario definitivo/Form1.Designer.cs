namespace planetario_definitivo
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnRimuovi = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtVelocita = new System.Windows.Forms.TextBox();
            this.txtSpostamento = new System.Windows.Forms.TextBox();
            this.txtMassa = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbColore = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.txtRaggio = new System.Windows.Forms.TextBox();
            this.lblRaggio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Navy;
            this.listBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 24);
            this.listBox1.Margin = new System.Windows.Forms.Padding(30, 32, 30, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(151, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Velocita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(151, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spostamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(151, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Massa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(151, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAggiungi.BackgroundImage")));
            this.btnAggiungi.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAggiungi.Location = new System.Drawing.Point(383, 50);
            this.btnAggiungi.Margin = new System.Windows.Forms.Padding(0);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 5;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnRimuovi
            // 
            this.btnRimuovi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRimuovi.BackgroundImage")));
            this.btnRimuovi.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRimuovi.Location = new System.Drawing.Point(383, 78);
            this.btnRimuovi.Name = "btnRimuovi";
            this.btnRimuovi.Size = new System.Drawing.Size(75, 23);
            this.btnRimuovi.TabIndex = 6;
            this.btnRimuovi.Text = "Rimuovi";
            this.btnRimuovi.UseVisualStyleBackColor = true;
            this.btnRimuovi.Click += new System.EventHandler(this.btnRimuovi_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPlay.Location = new System.Drawing.Point(383, 107);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtVelocita
            // 
            this.txtVelocita.BackColor = System.Drawing.Color.Navy;
            this.txtVelocita.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtVelocita.Location = new System.Drawing.Point(240, 24);
            this.txtVelocita.Name = "txtVelocita";
            this.txtVelocita.Size = new System.Drawing.Size(100, 20);
            this.txtVelocita.TabIndex = 8;
            // 
            // txtSpostamento
            // 
            this.txtSpostamento.BackColor = System.Drawing.Color.Navy;
            this.txtSpostamento.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSpostamento.Location = new System.Drawing.Point(240, 50);
            this.txtSpostamento.Name = "txtSpostamento";
            this.txtSpostamento.Size = new System.Drawing.Size(100, 20);
            this.txtSpostamento.TabIndex = 9;
            // 
            // txtMassa
            // 
            this.txtMassa.BackColor = System.Drawing.Color.Navy;
            this.txtMassa.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMassa.Location = new System.Drawing.Point(240, 76);
            this.txtMassa.Name = "txtMassa";
            this.txtMassa.Size = new System.Drawing.Size(100, 20);
            this.txtMassa.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Navy;
            this.txtNome.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNome.Location = new System.Drawing.Point(240, 102);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 11;
            // 
            // cmbColore
            // 
            this.cmbColore.BackColor = System.Drawing.Color.Navy;
            this.cmbColore.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbColore.FormattingEnabled = true;
            this.cmbColore.Items.AddRange(new object[] {
            "Blu",
            "Giallo",
            "Rosso",
            "Verde",
            "Arancione",
            "Bianco",
            "Rosa"});
            this.cmbColore.Location = new System.Drawing.Point(365, 24);
            this.cmbColore.Name = "cmbColore";
            this.cmbColore.Size = new System.Drawing.Size(121, 21);
            this.cmbColore.TabIndex = 12;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.8F);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(1, 2);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(746, 431);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "PLANETARIO";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F);
            this.lblStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStart.Location = new System.Drawing.Point(421, 462);
            this.lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(251, 48);
            this.lblStart.TabIndex = 14;
            this.lblStart.Text = "Click to start";
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(905, 10);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(99, 19);
            this.btnStartStop.TabIndex = 16;
            this.btnStartStop.Text = "STOP";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // txtRaggio
            // 
            this.txtRaggio.BackColor = System.Drawing.Color.Navy;
            this.txtRaggio.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRaggio.Location = new System.Drawing.Point(240, 128);
            this.txtRaggio.Name = "txtRaggio";
            this.txtRaggio.Size = new System.Drawing.Size(100, 20);
            this.txtRaggio.TabIndex = 17;
            // 
            // lblRaggio
            // 
            this.lblRaggio.AutoSize = true;
            this.lblRaggio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRaggio.Location = new System.Drawing.Point(151, 131);
            this.lblRaggio.Name = "lblRaggio";
            this.lblRaggio.Size = new System.Drawing.Size(41, 13);
            this.lblRaggio.TabIndex = 18;
            this.lblRaggio.Text = "Raggio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 730);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbColore);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMassa);
            this.Controls.Add(this.txtSpostamento);
            this.Controls.Add(this.txtVelocita);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRimuovi);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtRaggio);
            this.Controls.Add(this.lblRaggio);
            this.Name = "Form1";
            this.Text = "PLANETARIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnRimuovi;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtVelocita;
        private System.Windows.Forms.TextBox txtSpostamento;
        private System.Windows.Forms.TextBox txtMassa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbColore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.TextBox txtRaggio;
        private System.Windows.Forms.Label lblRaggio;
    }
}

