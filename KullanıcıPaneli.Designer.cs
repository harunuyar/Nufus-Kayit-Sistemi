namespace WindowsProje
{
    partial class KullanıcıPaneli
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBabaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnneAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDogumYeri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDogTar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKayitliL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKayitliLce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMah = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCilt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSira = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc No:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(51, 36);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 2;
            this.txtAd.TextChanged += new System.EventHandler(this.allTexts_TextChanged);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(399, 36);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 3;
            this.txtTc.TextChanged += new System.EventHandler(this.allTexts_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(203, 36);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 4;
            this.txtSoyad.TextChanged += new System.EventHandler(this.allTexts_TextChanged);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTC,
            this.columnAd,
            this.columnSoyad,
            this.columnBabaAdi,
            this.columnAnneAdi,
            this.columnCinsiyet,
            this.columnDogumYeri,
            this.columnDogTar,
            this.columnMed,
            this.columnDin,
            this.columnKan,
            this.columnKayitliL,
            this.columnKayitliLce,
            this.columnMah,
            this.columnCilt,
            this.columnAile,
            this.columnSira});
            this.listView.Location = new System.Drawing.Point(12, 69);
            this.listView.Name = "listView";
            this.listView.RightToLeftLayout = true;
            this.listView.Size = new System.Drawing.Size(626, 218);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // columnTC
            // 
            this.columnTC.Text = "TC Kimlik No";
            this.columnTC.Width = 80;
            // 
            // columnAd
            // 
            this.columnAd.Text = "Ad";
            // 
            // columnSoyad
            // 
            this.columnSoyad.Text = "Soyad";
            // 
            // columnBabaAdi
            // 
            this.columnBabaAdi.Text = "Baba Adı";
            this.columnBabaAdi.Width = 69;
            // 
            // columnAnneAdi
            // 
            this.columnAnneAdi.Text = "Anne Adı";
            this.columnAnneAdi.Width = 71;
            // 
            // columnCinsiyet
            // 
            this.columnCinsiyet.Text = "Cinsiyet";
            this.columnCinsiyet.Width = 48;
            // 
            // columnDogumYeri
            // 
            this.columnDogumYeri.Text = "Doğum Yeri";
            this.columnDogumYeri.Width = 78;
            // 
            // columnDogTar
            // 
            this.columnDogTar.Text = "Doğum Tarihi";
            this.columnDogTar.Width = 78;
            // 
            // columnMed
            // 
            this.columnMed.Text = "Medeni Hali";
            this.columnMed.Width = 68;
            // 
            // columnDin
            // 
            this.columnDin.Text = "Dini";
            this.columnDin.Width = 43;
            // 
            // columnKan
            // 
            this.columnKan.Text = "Kan Grubu";
            this.columnKan.Width = 66;
            // 
            // columnKayitliL
            // 
            this.columnKayitliL.Text = "Kayıtlı Olduğu İl";
            this.columnKayitliL.Width = 88;
            // 
            // columnKayitliLce
            // 
            this.columnKayitliLce.Text = "Kayıtlı Olduğu İlçe";
            this.columnKayitliLce.Width = 96;
            // 
            // columnMah
            // 
            this.columnMah.Text = "Mahalle/Köy";
            this.columnMah.Width = 72;
            // 
            // columnCilt
            // 
            this.columnCilt.Text = "Cilt No";
            this.columnCilt.Width = 43;
            // 
            // columnAile
            // 
            this.columnAile.Text = "Aile Sıra No";
            this.columnAile.Width = 67;
            // 
            // columnSira
            // 
            this.columnSira.Text = "Sıra No";
            this.columnSira.Width = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad:";
            // 
            // buttonAra
            // 
            this.buttonAra.Enabled = false;
            this.buttonAra.Location = new System.Drawing.Point(543, 27);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(95, 36);
            this.buttonAra.TabIndex = 7;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // KullanıcıPaneli
            // 
            this.AcceptButton = this.buttonAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 314);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullanıcıPaneli";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Paneli";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtTc, 0);
            this.Controls.SetChildIndex(this.txtSoyad, 0);
            this.Controls.SetChildIndex(this.listView, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.buttonAra, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnTC;
        private System.Windows.Forms.ColumnHeader columnAd;
        private System.Windows.Forms.ColumnHeader columnSoyad;
        private System.Windows.Forms.ColumnHeader columnBabaAdi;
        private System.Windows.Forms.ColumnHeader columnAnneAdi;
        private System.Windows.Forms.ColumnHeader columnCinsiyet;
        private System.Windows.Forms.ColumnHeader columnDogumYeri;
        private System.Windows.Forms.ColumnHeader columnDogTar;
        private System.Windows.Forms.ColumnHeader columnMed;
        private System.Windows.Forms.ColumnHeader columnDin;
        private System.Windows.Forms.ColumnHeader columnKan;
        private System.Windows.Forms.ColumnHeader columnKayitliL;
        private System.Windows.Forms.ColumnHeader columnKayitliLce;
        private System.Windows.Forms.ColumnHeader columnMah;
        private System.Windows.Forms.ColumnHeader columnCilt;
        private System.Windows.Forms.ColumnHeader columnAile;
        private System.Windows.Forms.ColumnHeader columnSira;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAra;
    }
}