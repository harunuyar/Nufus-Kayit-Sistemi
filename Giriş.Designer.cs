namespace WindowsProje
{
    partial class Giriş
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
            this.buttonGiris = new System.Windows.Forms.Button();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.labelTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKullanici = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxGoster = new System.Windows.Forms.CheckBox();
            this.txtHata = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGiris
            // 
            this.buttonGiris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGiris.Location = new System.Drawing.Point(186, 146);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(75, 23);
            this.buttonGiris.TabIndex = 0;
            this.buttonGiris.TabStop = false;
            this.buttonGiris.Text = "&Giriş";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // buttonIptal
            // 
            this.buttonIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonIptal.Location = new System.Drawing.Point(267, 146);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(75, 23);
            this.buttonIptal.TabIndex = 1;
            this.buttonIptal.TabStop = false;
            this.buttonIptal.Text = "&İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelTc.Location = new System.Drawing.Point(144, 67);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(49, 13);
            this.labelTc.TabIndex = 2;
            this.labelTc.Text = "Kullanıcı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(162, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // textBoxKullanici
            // 
            this.textBoxKullanici.Location = new System.Drawing.Point(199, 64);
            this.textBoxKullanici.Name = "textBoxKullanici";
            this.textBoxKullanici.Size = new System.Drawing.Size(143, 20);
            this.textBoxKullanici.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxKullanici, "Kullanıcı adınız");
            this.textBoxKullanici.TextChanged += new System.EventHandler(this.textBoxKullanici_TextChanged);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(199, 95);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(143, 20);
            this.textBoxSifre.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxSifre, "Şifreniz");
            this.textBoxSifre.TextChanged += new System.EventHandler(this.textBoxKullanici_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsProje.Properties.Resources.turkbayrak;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 51);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = " Kullanıcı Girişi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsProje.Properties.Resources.turkbayrak;
            this.pictureBox2.Location = new System.Drawing.Point(438, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 51);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // checkBoxGoster
            // 
            this.checkBoxGoster.AutoSize = true;
            this.checkBoxGoster.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBoxGoster.Location = new System.Drawing.Point(348, 97);
            this.checkBoxGoster.Name = "checkBoxGoster";
            this.checkBoxGoster.Size = new System.Drawing.Size(88, 17);
            this.checkBoxGoster.TabIndex = 9;
            this.checkBoxGoster.Text = "Şifreyi Göster";
            this.checkBoxGoster.UseVisualStyleBackColor = false;
            this.checkBoxGoster.CheckedChanged += new System.EventHandler(this.checkBoxGoster_CheckedChanged);
            // 
            // txtHata
            // 
            this.txtHata.AutoSize = true;
            this.txtHata.BackColor = System.Drawing.Color.Transparent;
            this.txtHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHata.ForeColor = System.Drawing.Color.Red;
            this.txtHata.Location = new System.Drawing.Point(230, 121);
            this.txtHata.Name = "txtHata";
            this.txtHata.Size = new System.Drawing.Size(69, 13);
            this.txtHata.TabIndex = 10;
            this.txtHata.Text = "Hatalı Giriş";
            this.txtHata.Visible = false;
            // 
            // Giriş
            // 
            this.AcceptButton = this.buttonGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsProje.Properties.Resources.harita;
            this.CancelButton = this.buttonIptal;
            this.ClientSize = new System.Drawing.Size(491, 191);
            this.Controls.Add(this.txtHata);
            this.Controls.Add(this.checkBoxGoster);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTc);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.buttonGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Giriş";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nufus Kayıt Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Button buttonIptal;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKullanici;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxGoster;
        private System.Windows.Forms.Label txtHata;
    }
}

