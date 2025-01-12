namespace ArabaYarisi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox araba;
        private System.Windows.Forms.PictureBox sagaraba;
        private System.Windows.Forms.PictureBox solaraba;
        private System.Windows.Forms.PictureBox yol;
        private System.Windows.Forms.Label label_skor;
        private System.Windows.Forms.Timer zamanlayici;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_skor = new System.Windows.Forms.Label();
            this.zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.araba = new System.Windows.Forms.PictureBox();
            this.sagaraba = new System.Windows.Forms.PictureBox();
            this.solaraba = new System.Windows.Forms.PictureBox();
            this.yol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.araba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagaraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solaraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).BeginInit();
            this.SuspendLayout();
            // 
            // label_skor
            // 
            this.label_skor.AutoSize = true;
            this.label_skor.Font = new System.Drawing.Font("Arial", 14F);
            this.label_skor.Location = new System.Drawing.Point(10, 10);
            this.label_skor.Name = "label_skor";
            this.label_skor.Size = new System.Drawing.Size(107, 27);
            this.label_skor.TabIndex = 4;
            this.label_skor.Text = "SKOR: 0";
            // 
            // zamanlayici
            // 
            this.zamanlayici.Enabled = true;
            this.zamanlayici.Interval = 20;
            this.zamanlayici.Tick += new System.EventHandler(this.zamanlayici_Tick);
            // 
            // araba
            // 
            this.araba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.araba.Image = global::ArabaYarisi.Properties.Resources.car;
            this.araba.Location = new System.Drawing.Point(167, 389);
            this.araba.Name = "araba";
            this.araba.Size = new System.Drawing.Size(50, 100);
            this.araba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba.TabIndex = 0;
            this.araba.TabStop = false;
            // 
            // sagaraba
            // 
            this.sagaraba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.sagaraba.Image = global::ArabaYarisi.Properties.Resources.car_sag;
            this.sagaraba.Location = new System.Drawing.Point(250, -100);
            this.sagaraba.Name = "sagaraba";
            this.sagaraba.Size = new System.Drawing.Size(50, 100);
            this.sagaraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sagaraba.TabIndex = 1;
            this.sagaraba.TabStop = false;
            // 
            // solaraba
            // 
            this.solaraba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.solaraba.Image = global::ArabaYarisi.Properties.Resources.car_sol;
            this.solaraba.Location = new System.Drawing.Point(50, -300);
            this.solaraba.Name = "solaraba";
            this.solaraba.Size = new System.Drawing.Size(50, 100);
            this.solaraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.solaraba.TabIndex = 2;
            this.solaraba.TabStop = false;
            // 
            // yol
            // 
            this.yol.BackColor = System.Drawing.Color.Gray;
            this.yol.Image = global::ArabaYarisi.Properties.Resources.road;
            this.yol.Location = new System.Drawing.Point(0, -621);
            this.yol.Name = "yol";
            this.yol.Size = new System.Drawing.Size(400, 1282);
            this.yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol.TabIndex = 3;
            this.yol.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.araba);
            this.Controls.Add(this.sagaraba);
            this.Controls.Add(this.solaraba);
            this.Controls.Add(this.yol);
            this.Controls.Add(this.label_skor);
            this.Name = "Form1";
            this.Text = "Dikey Araba Yarışı";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.araba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagaraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solaraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
