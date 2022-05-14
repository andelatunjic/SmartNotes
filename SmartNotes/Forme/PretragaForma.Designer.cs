
namespace SmartNotes
{
    partial class frmPretraga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.gridPrikaz = new System.Windows.Forms.DataGridView();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.txtNaslovPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioDogadaj = new System.Windows.Forms.RadioButton();
            this.radioLista = new System.Windows.Forms.RadioButton();
            this.radioBiljeska = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNaslovDatum = new System.Windows.Forms.ComboBox();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.radioUzlazno = new System.Windows.Forms.RadioButton();
            this.radioSilazno = new System.Windows.Forms.RadioButton();
            this.btnZatvoriPretraga = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelPretraga = new System.Windows.Forms.Panel();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.panelPrikaz = new System.Windows.Forms.Panel();
            this.btnGeneriraj = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrikaz)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelPretraga.SuspendLayout();
            this.panelPrikaz.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(814, 69);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prikaz i pretraga";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // gridPrikaz
            // 
            this.gridPrikaz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrikaz.Location = new System.Drawing.Point(10, 25);
            this.gridPrikaz.Name = "gridPrikaz";
            this.gridPrikaz.Size = new System.Drawing.Size(756, 408);
            this.gridPrikaz.TabIndex = 10;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnDetalji.FlatAppearance.BorderSize = 0;
            this.btnDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnDetalji.Location = new System.Drawing.Point(580, 451);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(108, 30);
            this.btnDetalji.TabIndex = 20;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = false;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltriraj);
            this.groupBox1.Controls.Add(this.txtNaslovPretraga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioDogadaj);
            this.groupBox1.Controls.Add(this.radioLista);
            this.groupBox1.Controls.Add(this.radioBiljeska);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.MinimumSize = new System.Drawing.Size(470, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 110);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtriranje";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnFiltriraj.FlatAppearance.BorderSize = 0;
            this.btnFiltriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltriraj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnFiltriraj.Location = new System.Drawing.Point(357, 33);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(108, 26);
            this.btnFiltriraj.TabIndex = 24;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = false;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // txtNaslovPretraga
            // 
            this.txtNaslovPretraga.Location = new System.Drawing.Point(122, 33);
            this.txtNaslovPretraga.Name = "txtNaslovPretraga";
            this.txtNaslovPretraga.Size = new System.Drawing.Size(231, 26);
            this.txtNaslovPretraga.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Naslov zapisa:";
            // 
            // radioDogadaj
            // 
            this.radioDogadaj.AutoSize = true;
            this.radioDogadaj.Location = new System.Drawing.Point(250, 73);
            this.radioDogadaj.Name = "radioDogadaj";
            this.radioDogadaj.Size = new System.Drawing.Size(90, 24);
            this.radioDogadaj.TabIndex = 27;
            this.radioDogadaj.Text = "Događaji";
            this.radioDogadaj.UseVisualStyleBackColor = true;
            this.radioDogadaj.CheckedChanged += new System.EventHandler(this.radioDogadaj_CheckedChanged);
            // 
            // radioLista
            // 
            this.radioLista.AutoSize = true;
            this.radioLista.Location = new System.Drawing.Point(183, 73);
            this.radioLista.Name = "radioLista";
            this.radioLista.Size = new System.Drawing.Size(61, 24);
            this.radioLista.TabIndex = 26;
            this.radioLista.Text = "Liste";
            this.radioLista.UseVisualStyleBackColor = true;
            this.radioLista.CheckedChanged += new System.EventHandler(this.radioLista_CheckedChanged);
            // 
            // radioBiljeska
            // 
            this.radioBiljeska.AutoSize = true;
            this.radioBiljeska.Checked = true;
            this.radioBiljeska.Location = new System.Drawing.Point(96, 73);
            this.radioBiljeska.Name = "radioBiljeska";
            this.radioBiljeska.Size = new System.Drawing.Size(81, 24);
            this.radioBiljeska.TabIndex = 25;
            this.radioBiljeska.TabStop = true;
            this.radioBiljeska.Text = "Biljeske";
            this.radioBiljeska.UseVisualStyleBackColor = true;
            this.radioBiljeska.CheckedChanged += new System.EventHandler(this.radioBiljeska_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tip zapisa:";
            // 
            // comboNaslovDatum
            // 
            this.comboNaslovDatum.FormattingEnabled = true;
            this.comboNaslovDatum.Location = new System.Drawing.Point(97, 35);
            this.comboNaslovDatum.Name = "comboNaslovDatum";
            this.comboNaslovDatum.Size = new System.Drawing.Size(200, 28);
            this.comboNaslovDatum.TabIndex = 22;
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnSortiraj.FlatAppearance.BorderSize = 0;
            this.btnSortiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortiraj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSortiraj.Location = new System.Drawing.Point(212, 74);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(85, 29);
            this.btnSortiraj.TabIndex = 23;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = false;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // radioUzlazno
            // 
            this.radioUzlazno.AutoSize = true;
            this.radioUzlazno.Checked = true;
            this.radioUzlazno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUzlazno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.radioUzlazno.Location = new System.Drawing.Point(6, 35);
            this.radioUzlazno.Name = "radioUzlazno";
            this.radioUzlazno.Size = new System.Drawing.Size(85, 24);
            this.radioUzlazno.TabIndex = 28;
            this.radioUzlazno.TabStop = true;
            this.radioUzlazno.Text = "Uzlazno";
            this.radioUzlazno.UseVisualStyleBackColor = true;
            // 
            // radioSilazno
            // 
            this.radioSilazno.AutoSize = true;
            this.radioSilazno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSilazno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.radioSilazno.Location = new System.Drawing.Point(6, 65);
            this.radioSilazno.Name = "radioSilazno";
            this.radioSilazno.Size = new System.Drawing.Size(79, 24);
            this.radioSilazno.TabIndex = 29;
            this.radioSilazno.Text = "Silazno";
            this.radioSilazno.UseVisualStyleBackColor = true;
            // 
            // btnZatvoriPretraga
            // 
            this.btnZatvoriPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvoriPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnZatvoriPretraga.FlatAppearance.BorderSize = 0;
            this.btnZatvoriPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvoriPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvoriPretraga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnZatvoriPretraga.Location = new System.Drawing.Point(767, 12);
            this.btnZatvoriPretraga.Name = "btnZatvoriPretraga";
            this.btnZatvoriPretraga.Size = new System.Drawing.Size(35, 26);
            this.btnZatvoriPretraga.TabIndex = 30;
            this.btnZatvoriPretraga.Text = "X";
            this.btnZatvoriPretraga.UseVisualStyleBackColor = false;
            this.btnZatvoriPretraga.Click += new System.EventHandler(this.btnZatvoriPretraga_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboNaslovDatum);
            this.groupBox2.Controls.Add(this.btnSortiraj);
            this.groupBox2.Controls.Add(this.radioSilazno);
            this.groupBox2.Controls.Add(this.radioUzlazno);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(499, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 109);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sortiranje";
            // 
            // panelPretraga
            // 
            this.panelPretraga.Controls.Add(this.groupBox1);
            this.panelPretraga.Controls.Add(this.groupBox2);
            this.panelPretraga.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPretraga.Location = new System.Drawing.Point(0, 69);
            this.panelPretraga.Name = "panelPretraga";
            this.panelPretraga.Size = new System.Drawing.Size(814, 124);
            this.panelPretraga.TabIndex = 32;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnPretraga.FlatAppearance.BorderSize = 0;
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnPretraga.Location = new System.Drawing.Point(694, 451);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(108, 30);
            this.btnPretraga.TabIndex = 33;
            this.btnPretraga.Text = "Traži/Sortiraj";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // panelPrikaz
            // 
            this.panelPrikaz.Controls.Add(this.groupBox3);
            this.panelPrikaz.Controls.Add(this.btnGeneriraj);
            this.panelPrikaz.Controls.Add(this.btnPretraga);
            this.panelPrikaz.Controls.Add(this.btnDetalji);
            this.panelPrikaz.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrikaz.Location = new System.Drawing.Point(0, 193);
            this.panelPrikaz.Name = "panelPrikaz";
            this.panelPrikaz.Size = new System.Drawing.Size(814, 484);
            this.panelPrikaz.TabIndex = 35;
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnGeneriraj.FlatAppearance.BorderSize = 0;
            this.btnGeneriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneriraj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnGeneriraj.Location = new System.Drawing.Point(441, 451);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(133, 30);
            this.btnGeneriraj.TabIndex = 35;
            this.btnGeneriraj.Text = "Generiraj PDF";
            this.btnGeneriraj.UseVisualStyleBackColor = false;
            this.btnGeneriraj.Click += new System.EventHandler(this.btnGeneriraj_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gridPrikaz);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(790, 439);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Moji zapisi:";
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(814, 689);
            this.Controls.Add(this.panelPrikaz);
            this.Controls.Add(this.panelPretraga);
            this.Controls.Add(this.btnZatvoriPretraga);
            this.Controls.Add(this.label3);
            this.Name = "frmPretraga";
            this.Text = "Prikaz i pretraga";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrikaz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelPretraga.ResumeLayout(false);
            this.panelPrikaz.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridPrikaz;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboNaslovDatum;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.RadioButton radioDogadaj;
        private System.Windows.Forms.RadioButton radioLista;
        private System.Windows.Forms.RadioButton radioBiljeska;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.TextBox txtNaslovPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioUzlazno;
        private System.Windows.Forms.RadioButton radioSilazno;
        private System.Windows.Forms.Button btnZatvoriPretraga;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelPretraga;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Panel panelPrikaz;
        private System.Windows.Forms.Button btnGeneriraj;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}