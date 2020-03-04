namespace Dans
{
    partial class Form1
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
            this.dgvEslesme = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.clmKisi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKisi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEslesme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEslesme
            // 
            this.dgvEslesme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEslesme.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEslesme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEslesme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmKisi1,
            this.clmKisi2});
            this.dgvEslesme.Location = new System.Drawing.Point(12, 46);
            this.dgvEslesme.Name = "dgvEslesme";
            this.dgvEslesme.Size = new System.Drawing.Size(563, 392);
            this.dgvEslesme.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(12, 4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(563, 36);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // clmKisi1
            // 
            this.clmKisi1.HeaderText = "Kişi 1 ";
            this.clmKisi1.Name = "clmKisi1";
            // 
            // clmKisi2
            // 
            this.clmKisi2.HeaderText = "Kişi 2";
            this.clmKisi2.Name = "clmKisi2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvEslesme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEslesme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEslesme;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKisi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKisi2;
        private System.Windows.Forms.Button btnListele;
    }
}

