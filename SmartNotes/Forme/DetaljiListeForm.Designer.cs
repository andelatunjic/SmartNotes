
namespace SmartNotes.Forme
{
    partial class frmDetaljiListe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.checkOmiljeno = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridPrekrizi = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridPrekrizeno = new System.Windows.Forms.DataGridView();
            this.btnPrekrizi = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.btnZatvoriPretraga = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrekrizi)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrekrizeno)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(1186, 69);
            this.label3.TabIndex = 10;
            this.label3.Text = "Detalji liste";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtDatum);
            this.groupBox1.Controls.Add(this.checkOmiljeno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNaslov);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1148, 67);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji liste";
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.Location = new System.Drawing.Point(221, 40);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(207, 22);
            this.txtDatum.TabIndex = 13;
            // 
            // checkOmiljeno
            // 
            this.checkOmiljeno.AutoSize = true;
            this.checkOmiljeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOmiljeno.ForeColor = System.Drawing.Color.White;
            this.checkOmiljeno.Location = new System.Drawing.Point(434, 39);
            this.checkOmiljeno.Name = "checkOmiljeno";
            this.checkOmiljeno.Size = new System.Drawing.Size(89, 24);
            this.checkOmiljeno.TabIndex = 20;
            this.checkOmiljeno.Text = "Omiljeno";
            this.checkOmiljeno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Naslov: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Datum:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.Location = new System.Drawing.Point(8, 40);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.ReadOnly = true;
            this.txtNaslov.Size = new System.Drawing.Size(207, 22);
            this.txtNaslov.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridPrekrizi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 410);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prekriži";
            // 
            // gridPrekrizi
            // 
            this.gridPrekrizi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrekrizi.Location = new System.Drawing.Point(6, 25);
            this.gridPrekrizi.Name = "gridPrekrizi";
            this.gridPrekrizi.Size = new System.Drawing.Size(517, 379);
            this.gridPrekrizi.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridPrekrizeno);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(631, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 410);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prekriženo";
            // 
            // gridPrekrizeno
            // 
            this.gridPrekrizeno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrekrizeno.Location = new System.Drawing.Point(6, 25);
            this.gridPrekrizeno.Name = "gridPrekrizeno";
            this.gridPrekrizeno.Size = new System.Drawing.Size(517, 379);
            this.gridPrekrizeno.TabIndex = 1;
            // 
            // btnPrekrizi
            // 
            this.btnPrekrizi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnPrekrizi.FlatAppearance.BorderSize = 0;
            this.btnPrekrizi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrekrizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrekrizi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnPrekrizi.Location = new System.Drawing.Point(548, 331);
            this.btnPrekrizi.Name = "btnPrekrizi";
            this.btnPrekrizi.Size = new System.Drawing.Size(77, 28);
            this.btnPrekrizi.TabIndex = 32;
            this.btnPrekrizi.Text = ">>>";
            this.btnPrekrizi.UseVisualStyleBackColor = false;
            this.btnPrekrizi.Click += new System.EventHandler(this.btnPrekrizi_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnVrati.FlatAppearance.BorderSize = 0;
            this.btnVrati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVrati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnVrati.Location = new System.Drawing.Point(548, 382);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(77, 28);
            this.btnVrati.TabIndex = 33;
            this.btnVrati.Text = "<<<";
            this.btnVrati.UseVisualStyleBackColor = false;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // btnZatvoriPretraga
            // 
            this.btnZatvoriPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvoriPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnZatvoriPretraga.FlatAppearance.BorderSize = 0;
            this.btnZatvoriPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvoriPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvoriPretraga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnZatvoriPretraga.Location = new System.Drawing.Point(1139, 12);
            this.btnZatvoriPretraga.Name = "btnZatvoriPretraga";
            this.btnZatvoriPretraga.Size = new System.Drawing.Size(35, 26);
            this.btnZatvoriPretraga.TabIndex = 34;
            this.btnZatvoriPretraga.Text = "X";
            this.btnZatvoriPretraga.UseVisualStyleBackColor = false;
            this.btnZatvoriPretraga.Click += new System.EventHandler(this.btnZatvoriPretraga_Click);
            // 
            // frmDetaljiListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1186, 650);
            this.Controls.Add(this.btnZatvoriPretraga);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnPrekrizi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "frmDetaljiListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji liste";
            this.Load += new System.EventHandler(this.frmDetaljiListe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrekrizi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrekrizeno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.CheckBox checkOmiljeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridPrekrizi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridPrekrizeno;
        private System.Windows.Forms.Button btnPrekrizi;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.Button btnZatvoriPretraga;
    }
}