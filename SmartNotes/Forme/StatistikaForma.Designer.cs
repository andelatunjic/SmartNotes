
namespace SmartNotes
{
    partial class frmStatistika
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZatvoriStatistika = new System.Windows.Forms.Button();
            this.chartZapisi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pickerDatumOd = new System.Windows.Forms.DateTimePicker();
            this.pickerDatumDo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUkupnaStatistika = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridUkupanBrojZapisa = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridTaskovi = new System.Windows.Forms.DataGridView();
            this.chartTaskovi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartZapisi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUkupanBrojZapisa)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTaskovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTaskovi)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(1101, 60);
            this.label3.TabIndex = 10;
            this.label3.Text = "Statistika";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnZatvoriStatistika
            // 
            this.btnZatvoriStatistika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvoriStatistika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnZatvoriStatistika.FlatAppearance.BorderSize = 0;
            this.btnZatvoriStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvoriStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvoriStatistika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnZatvoriStatistika.Location = new System.Drawing.Point(1037, 12);
            this.btnZatvoriStatistika.Name = "btnZatvoriStatistika";
            this.btnZatvoriStatistika.Size = new System.Drawing.Size(35, 26);
            this.btnZatvoriStatistika.TabIndex = 31;
            this.btnZatvoriStatistika.Text = "X";
            this.btnZatvoriStatistika.UseVisualStyleBackColor = false;
            this.btnZatvoriStatistika.Click += new System.EventHandler(this.btnZatvoriStatistika_Click);
            // 
            // chartZapisi
            // 
            chartArea3.Name = "ChartArea1";
            this.chartZapisi.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartZapisi.Legends.Add(legend3);
            this.chartZapisi.Location = new System.Drawing.Point(566, 15);
            this.chartZapisi.Name = "chartZapisi";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Zapisi";
            this.chartZapisi.Series.Add(series4);
            this.chartZapisi.Size = new System.Drawing.Size(474, 318);
            this.chartZapisi.TabIndex = 32;
            this.chartZapisi.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Početak razdoblja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Završetak razdoblja:";
            // 
            // pickerDatumOd
            // 
            this.pickerDatumOd.Location = new System.Drawing.Point(180, 37);
            this.pickerDatumOd.Name = "pickerDatumOd";
            this.pickerDatumOd.Size = new System.Drawing.Size(278, 26);
            this.pickerDatumOd.TabIndex = 42;
            // 
            // pickerDatumDo
            // 
            this.pickerDatumDo.Location = new System.Drawing.Point(180, 75);
            this.pickerDatumDo.Name = "pickerDatumDo";
            this.pickerDatumDo.Size = new System.Drawing.Size(278, 26);
            this.pickerDatumDo.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnUkupnaStatistika);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Controls.Add(this.pickerDatumOd);
            this.groupBox1.Controls.Add(this.pickerDatumDo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(8, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 122);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Razdoblje za prikaz statistike";
            // 
            // btnUkupnaStatistika
            // 
            this.btnUkupnaStatistika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnUkupnaStatistika.FlatAppearance.BorderSize = 0;
            this.btnUkupnaStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUkupnaStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkupnaStatistika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnUkupnaStatistika.Location = new System.Drawing.Point(622, 75);
            this.btnUkupnaStatistika.Name = "btnUkupnaStatistika";
            this.btnUkupnaStatistika.Size = new System.Drawing.Size(197, 26);
            this.btnUkupnaStatistika.TabIndex = 47;
            this.btnUkupnaStatistika.Text = "Prikaži ukupnu statistiku";
            this.btnUkupnaStatistika.UseVisualStyleBackColor = false;
            this.btnUkupnaStatistika.Click += new System.EventHandler(this.btnUkupnaStatistika_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnReset.Location = new System.Drawing.Point(478, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 26);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnPrikazi.FlatAppearance.BorderSize = 0;
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnPrikazi.Location = new System.Drawing.Point(478, 75);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(126, 26);
            this.btnPrikazi.TabIndex = 45;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridUkupanBrojZapisa);
            this.groupBox2.Controls.Add(this.chartZapisi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1050, 339);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ukupan broj zapisa";
            // 
            // gridUkupanBrojZapisa
            // 
            this.gridUkupanBrojZapisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUkupanBrojZapisa.Location = new System.Drawing.Point(6, 25);
            this.gridUkupanBrojZapisa.Name = "gridUkupanBrojZapisa";
            this.gridUkupanBrojZapisa.Size = new System.Drawing.Size(534, 308);
            this.gridUkupanBrojZapisa.TabIndex = 33;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.gridTaskovi);
            this.groupBox4.Controls.Add(this.chartTaskovi);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.groupBox4.Location = new System.Drawing.Point(8, 550);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1050, 339);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistika taskova liste";
            // 
            // gridTaskovi
            // 
            this.gridTaskovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTaskovi.Location = new System.Drawing.Point(6, 25);
            this.gridTaskovi.Name = "gridTaskovi";
            this.gridTaskovi.Size = new System.Drawing.Size(534, 308);
            this.gridTaskovi.TabIndex = 33;
            // 
            // chartTaskovi
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTaskovi.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTaskovi.Legends.Add(legend4);
            this.chartTaskovi.Location = new System.Drawing.Point(566, 15);
            this.chartTaskovi.Name = "chartTaskovi";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Prekriženo";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Nije prekriženo";
            this.chartTaskovi.Series.Add(series5);
            this.chartTaskovi.Series.Add(series6);
            this.chartTaskovi.Size = new System.Drawing.Size(474, 318);
            this.chartTaskovi.TabIndex = 32;
            this.chartTaskovi.Text = "chart2";
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1118, 831);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnZatvoriStatistika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStatistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.frmStatistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartZapisi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUkupanBrojZapisa)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTaskovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTaskovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZatvoriStatistika;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZapisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker pickerDatumOd;
        private System.Windows.Forms.DateTimePicker pickerDatumDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnUkupnaStatistika;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridUkupanBrojZapisa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView gridTaskovi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTaskovi;
    }
}