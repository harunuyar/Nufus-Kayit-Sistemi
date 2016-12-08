namespace WindowsProje
{
    partial class NüfusKayıtÖrneği
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
            this.listView = new System.Windows.Forms.ListView();
            this.columnYakınlık = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnYakınlık,
            this.columnTC});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(562, 351);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnYakınlık
            // 
            this.columnYakınlık.Text = "Yakınlık";
            this.columnYakınlık.Width = 83;
            // 
            // columnTC
            // 
            this.columnTC.Text = "TC No";
            this.columnTC.Width = 87;
            // 
            // NüfusKayıtÖrneği
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 351);
            this.Controls.Add(this.listView);
            this.Name = "NüfusKayıtÖrneği";
            this.Text = "NüfusKayıtÖrneği";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NüfusKayıtÖrneği_FormClosed);
            this.Load += new System.EventHandler(this.NüfusKayıtÖrneği_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnYakınlık;
        private System.Windows.Forms.ColumnHeader columnTC;
    }
}