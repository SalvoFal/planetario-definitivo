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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 30);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 116);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(201, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Velocita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(201, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spostamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(201, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Massa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(201, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(511, 62);
            this.btnAggiungi.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(100, 28);
            this.btnAggiungi.TabIndex = 5;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnRimuovi
            // 
            this.btnRimuovi.Location = new System.Drawing.Point(511, 96);
            this.btnRimuovi.Margin = new System.Windows.Forms.Padding(4);
            this.btnRimuovi.Name = "btnRimuovi";
            this.btnRimuovi.Size = new System.Drawing.Size(100, 28);
            this.btnRimuovi.TabIndex = 6;
            this.btnRimuovi.Text = "Rimuovi";
            this.btnRimuovi.UseVisualStyleBackColor = true;
            this.btnRimuovi.Click += new System.EventHandler(this.btnRimuovi_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(511, 132);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 28);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtVelocita
            // 
            this.txtVelocita.Location = new System.Drawing.Point(320, 30);
            this.txtVelocita.Margin = new System.Windows.Forms.Padding(4);
            this.txtVelocita.Name = "txtVelocita";
            this.txtVelocita.Size = new System.Drawing.Size(132, 22);
            this.txtVelocita.TabIndex = 8;
            // 
            // txtSpostamento
            // 
            this.txtSpostamento.Location = new System.Drawing.Point(320, 62);
            this.txtSpostamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpostamento.Name = "txtSpostamento";
            this.txtSpostamento.Size = new System.Drawing.Size(132, 22);
            this.txtSpostamento.TabIndex = 9;
            // 
            // txtMassa
            // 
            this.txtMassa.Location = new System.Drawing.Point(320, 94);
            this.txtMassa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMassa.Name = "txtMassa";
            this.txtMassa.Size = new System.Drawing.Size(132, 22);
            this.txtMassa.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(320, 126);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 22);
            this.txtNome.TabIndex = 11;
            // 
            // cmbColore
            // 
            this.cmbColore.FormattingEnabled = true;
            this.cmbColore.Items.AddRange(new object[] {
            "Blu",
            "Giallo",
            "Rosso",
            "Verde",
            "Arancione",
            "Bianco",
            "Rosa"});
            this.cmbColore.Location = new System.Drawing.Point(487, 30);
            this.cmbColore.Margin = new System.Windows.Forms.Padding(4);
            this.cmbColore.Name = "cmbColore";
            this.cmbColore.Size = new System.Drawing.Size(160, 24);
            this.cmbColore.TabIndex = 12;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.8F);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(0, -2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(1380, 780);
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
            this.lblStart.Location = new System.Drawing.Point(545, 647);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(308, 59);
            this.lblStart.TabIndex = 14;
            this.lblStart.Text = "Click to start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 801);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

