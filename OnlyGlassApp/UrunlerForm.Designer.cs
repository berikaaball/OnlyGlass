namespace OnlyGlassApp
{
    partial class UrunlerForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.CBoxUrunRengi = new System.Windows.Forms.ComboBox();
            this.TBoxUrunTipi = new System.Windows.Forms.TextBox();
            this.CBoxUrunModeli = new System.Windows.Forms.ComboBox();
            this.CBoxUrunOzellik = new System.Windows.Forms.ComboBox();
            this.CBoxUrunMM = new System.Windows.Forms.ComboBox();
            this.CBoxUrunEbat = new System.Windows.Forms.ComboBox();
            this.DGVUrunler = new System.Windows.Forms.DataGridView();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.TBoxUrunNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBoxToplamUrun = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(159, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(138, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Rengi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(679, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Tipi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(657, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Modeli:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(656, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Özellik:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(157, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ürün MM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(672, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ürün Ebat:";
            // 
            // TBoxUrunAdi
            // 
            this.TBoxUrunAdi.Location = new System.Drawing.Point(250, 100);
            this.TBoxUrunAdi.Multiline = true;
            this.TBoxUrunAdi.Name = "TBoxUrunAdi";
            this.TBoxUrunAdi.Size = new System.Drawing.Size(356, 34);
            this.TBoxUrunAdi.TabIndex = 7;
            // 
            // CBoxUrunRengi
            // 
            this.CBoxUrunRengi.DropDownWidth = 300;
            this.CBoxUrunRengi.FormattingEnabled = true;
            this.CBoxUrunRengi.Location = new System.Drawing.Point(250, 163);
            this.CBoxUrunRengi.Name = "CBoxUrunRengi";
            this.CBoxUrunRengi.Size = new System.Drawing.Size(178, 24);
            this.CBoxUrunRengi.TabIndex = 8;
            // 
            // TBoxUrunTipi
            // 
            this.TBoxUrunTipi.Location = new System.Drawing.Point(774, 38);
            this.TBoxUrunTipi.Multiline = true;
            this.TBoxUrunTipi.Name = "TBoxUrunTipi";
            this.TBoxUrunTipi.Size = new System.Drawing.Size(356, 34);
            this.TBoxUrunTipi.TabIndex = 9;
            // 
            // CBoxUrunModeli
            // 
            this.CBoxUrunModeli.DropDownWidth = 300;
            this.CBoxUrunModeli.FormattingEnabled = true;
            this.CBoxUrunModeli.Location = new System.Drawing.Point(774, 100);
            this.CBoxUrunModeli.Name = "CBoxUrunModeli";
            this.CBoxUrunModeli.Size = new System.Drawing.Size(178, 24);
            this.CBoxUrunModeli.TabIndex = 10;
            // 
            // CBoxUrunOzellik
            // 
            this.CBoxUrunOzellik.DropDownWidth = 300;
            this.CBoxUrunOzellik.FormattingEnabled = true;
            this.CBoxUrunOzellik.Location = new System.Drawing.Point(774, 154);
            this.CBoxUrunOzellik.Name = "CBoxUrunOzellik";
            this.CBoxUrunOzellik.Size = new System.Drawing.Size(178, 24);
            this.CBoxUrunOzellik.TabIndex = 11;
            // 
            // CBoxUrunMM
            // 
            this.CBoxUrunMM.DropDownWidth = 300;
            this.CBoxUrunMM.FormattingEnabled = true;
            this.CBoxUrunMM.Location = new System.Drawing.Point(250, 219);
            this.CBoxUrunMM.Name = "CBoxUrunMM";
            this.CBoxUrunMM.Size = new System.Drawing.Size(178, 24);
            this.CBoxUrunMM.TabIndex = 12;
            // 
            // CBoxUrunEbat
            // 
            this.CBoxUrunEbat.DropDownWidth = 300;
            this.CBoxUrunEbat.FormattingEnabled = true;
            this.CBoxUrunEbat.Location = new System.Drawing.Point(774, 209);
            this.CBoxUrunEbat.Name = "CBoxUrunEbat";
            this.CBoxUrunEbat.Size = new System.Drawing.Size(178, 24);
            this.CBoxUrunEbat.TabIndex = 13;
            // 
            // DGVUrunler
            // 
            this.DGVUrunler.AllowUserToAddRows = false;
            this.DGVUrunler.AllowUserToDeleteRows = false;
            this.DGVUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUrunler.Location = new System.Drawing.Point(12, 414);
            this.DGVUrunler.Name = "DGVUrunler";
            this.DGVUrunler.ReadOnly = true;
            this.DGVUrunler.RowHeadersWidth = 51;
            this.DGVUrunler.RowTemplate.Height = 24;
            this.DGVUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUrunler.Size = new System.Drawing.Size(1439, 289);
            this.DGVUrunler.TabIndex = 14;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(455, 295);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(153, 83);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(632, 295);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(153, 83);
            this.BtnGuncelle.TabIndex = 16;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 28);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(155, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ürün No:";
            // 
            // TBoxUrunNo
            // 
            this.TBoxUrunNo.Location = new System.Drawing.Point(250, 39);
            this.TBoxUrunNo.Multiline = true;
            this.TBoxUrunNo.Name = "TBoxUrunNo";
            this.TBoxUrunNo.ReadOnly = true;
            this.TBoxUrunNo.Size = new System.Drawing.Size(126, 34);
            this.TBoxUrunNo.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1035, 740);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Toplam Ürün Sayısı:";
            // 
            // TBoxToplamUrun
            // 
            this.TBoxToplamUrun.Location = new System.Drawing.Point(1224, 738);
            this.TBoxToplamUrun.Name = "TBoxToplamUrun";
            this.TBoxToplamUrun.Size = new System.Drawing.Size(126, 22);
            this.TBoxToplamUrun.TabIndex = 21;
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1463, 804);
            this.Controls.Add(this.TBoxToplamUrun);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBoxUrunNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.DGVUrunler);
            this.Controls.Add(this.CBoxUrunEbat);
            this.Controls.Add(this.CBoxUrunMM);
            this.Controls.Add(this.CBoxUrunOzellik);
            this.Controls.Add(this.CBoxUrunModeli);
            this.Controls.Add(this.TBoxUrunTipi);
            this.Controls.Add(this.CBoxUrunRengi);
            this.Controls.Add(this.TBoxUrunAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UrunlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunlerForm";
            this.Load += new System.EventHandler(this.UrunlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBoxUrunAdi;
        private System.Windows.Forms.ComboBox CBoxUrunRengi;
        private System.Windows.Forms.TextBox TBoxUrunTipi;
        private System.Windows.Forms.ComboBox CBoxUrunModeli;
        private System.Windows.Forms.ComboBox CBoxUrunOzellik;
        private System.Windows.Forms.ComboBox CBoxUrunMM;
        private System.Windows.Forms.ComboBox CBoxUrunEbat;
        private System.Windows.Forms.DataGridView DGVUrunler;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBoxUrunNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBoxToplamUrun;
    }
}