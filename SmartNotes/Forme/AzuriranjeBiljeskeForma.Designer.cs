
namespace SmartNotes.Forme
{
    partial class frmAzuriranjeBiljeske
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.azurianje = new System.Windows.Forms.GroupBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.checkOmiljeno = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaslovBiljeske = new System.Windows.Forms.TextBox();
            this.biljeskaHelp = new System.Windows.Forms.HelpProvider();
            this.azurianje.SuspendLayout();
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
            this.label3.Size = new System.Drawing.Size(669, 60);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ažuriranje bilješke";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnOdustani.Location = new System.Drawing.Point(566, 392);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(91, 30);
            this.btnOdustani.TabIndex = 40;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnAzuriraj.FlatAppearance.BorderSize = 0;
            this.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnAzuriraj.Location = new System.Drawing.Point(469, 392);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(91, 30);
            this.btnAzuriraj.TabIndex = 39;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // azurianje
            // 
            this.azurianje.Controls.Add(this.txtOpis);
            this.azurianje.Controls.Add(this.checkOmiljeno);
            this.azurianje.Controls.Add(this.label2);
            this.azurianje.Controls.Add(this.txtNaslovBiljeske);
            this.azurianje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azurianje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.azurianje.Location = new System.Drawing.Point(14, 75);
            this.azurianje.Name = "azurianje";
            this.azurianje.Size = new System.Drawing.Size(643, 311);
            this.azurianje.TabIndex = 38;
            this.azurianje.TabStop = false;
            this.azurianje.Text = "Ažuriranje:";
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOpis.Location = new System.Drawing.Point(10, 68);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpis.Size = new System.Drawing.Size(627, 227);
            this.txtOpis.TabIndex = 41;
            // 
            // checkOmiljeno
            // 
            this.checkOmiljeno.AutoSize = true;
            this.checkOmiljeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOmiljeno.ForeColor = System.Drawing.Color.White;
            this.checkOmiljeno.Location = new System.Drawing.Point(391, 27);
            this.checkOmiljeno.Name = "checkOmiljeno";
            this.checkOmiljeno.Size = new System.Drawing.Size(89, 24);
            this.checkOmiljeno.TabIndex = 36;
            this.checkOmiljeno.Text = "Omiljeno";
            this.checkOmiljeno.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Naslov bilješke:";
            // 
            // txtNaslovBiljeske
            // 
            this.txtNaslovBiljeske.Location = new System.Drawing.Point(128, 25);
            this.txtNaslovBiljeske.Name = "txtNaslovBiljeske";
            this.txtNaslovBiljeske.Size = new System.Drawing.Size(257, 26);
            this.txtNaslovBiljeske.TabIndex = 29;
            // 
            // frmAzuriranjeBiljeske
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(669, 445);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.azurianje);
            this.Controls.Add(this.label3);
            this.MinimumSize = new System.Drawing.Size(433, 244);
            this.Name = "frmAzuriranjeBiljeske";
            this.biljeskaHelp.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ažuriranje bilješke";
            this.Load += new System.EventHandler(this.frmAzuriranjeBiljeske_Load);
            this.azurianje.ResumeLayout(false);
            this.azurianje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.GroupBox azurianje;
        private System.Windows.Forms.CheckBox checkOmiljeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaslovBiljeske;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.HelpProvider biljeskaHelp;
    }
}