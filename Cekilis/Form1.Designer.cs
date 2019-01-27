namespace Cekilis
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
            this.components = new System.ComponentModel.Container();
            this.tbKisiEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbEfekt = new System.Windows.Forms.PictureBox();
            this.lstbOduller = new System.Windows.Forms.ListBox();
            this.lstbKisiler = new System.Windows.Forms.ListBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblCekilecekEsya = new System.Windows.Forms.Label();
            this.tmrGif = new System.Windows.Forms.Timer(this.components);
            this.tmrFirework = new System.Windows.Forms.Timer(this.components);
            this.bgwGifGoster = new System.ComponentModel.BackgroundWorker();
            this.btnOdulBelirle = new System.Windows.Forms.Button();
            this.tbOdul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstbKazananlar = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOdulEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbEfekt)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKisiEkle
            // 
            this.tbKisiEkle.Location = new System.Drawing.Point(15, 418);
            this.tbKisiEkle.Margin = new System.Windows.Forms.Padding(4);
            this.tbKisiEkle.Name = "tbKisiEkle";
            this.tbKisiEkle.Size = new System.Drawing.Size(184, 24);
            this.tbKisiEkle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kişi Ekleyin";
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiEkle.Location = new System.Drawing.Point(15, 449);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(184, 25);
            this.btnKisiEkle.TabIndex = 3;
            this.btnKisiEkle.Text = "Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çekilişe Katılan Kişiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(439, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kalan Ödüller";
            // 
            // pbEfekt
            // 
            this.pbEfekt.Location = new System.Drawing.Point(216, 114);
            this.pbEfekt.Name = "pbEfekt";
            this.pbEfekt.Size = new System.Drawing.Size(206, 178);
            this.pbEfekt.TabIndex = 4;
            this.pbEfekt.TabStop = false;
            // 
            // lstbOduller
            // 
            this.lstbOduller.FormattingEnabled = true;
            this.lstbOduller.ItemHeight = 18;
            this.lstbOduller.Location = new System.Drawing.Point(442, 83);
            this.lstbOduller.Name = "lstbOduller";
            this.lstbOduller.Size = new System.Drawing.Size(184, 292);
            this.lstbOduller.TabIndex = 5;
            // 
            // lstbKisiler
            // 
            this.lstbKisiler.FormattingEnabled = true;
            this.lstbKisiler.ItemHeight = 18;
            this.lstbKisiler.Location = new System.Drawing.Point(15, 83);
            this.lstbKisiler.Name = "lstbKisiler";
            this.lstbKisiler.Size = new System.Drawing.Size(184, 292);
            this.lstbKisiler.TabIndex = 5;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(216, 83);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(100, 25);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblCekilecekEsya
            // 
            this.lblCekilecekEsya.AutoSize = true;
            this.lblCekilecekEsya.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekilecekEsya.Location = new System.Drawing.Point(19, 17);
            this.lblCekilecekEsya.Name = "lblCekilecekEsya";
            this.lblCekilecekEsya.Size = new System.Drawing.Size(0, 22);
            this.lblCekilecekEsya.TabIndex = 1;
            // 
            // bgwGifGoster
            // 
            this.bgwGifGoster.WorkerReportsProgress = true;
            this.bgwGifGoster.WorkerSupportsCancellation = true;
            this.bgwGifGoster.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGifGoster_DoWork);
            // 
            // btnOdulBelirle
            // 
            this.btnOdulBelirle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdulBelirle.Location = new System.Drawing.Point(322, 83);
            this.btnOdulBelirle.Name = "btnOdulBelirle";
            this.btnOdulBelirle.Size = new System.Drawing.Size(100, 25);
            this.btnOdulBelirle.TabIndex = 7;
            this.btnOdulBelirle.Text = "Ödül Seç";
            this.btnOdulBelirle.UseVisualStyleBackColor = true;
            this.btnOdulBelirle.Click += new System.EventHandler(this.btnOdulBelirle_Click);
            // 
            // tbOdul
            // 
            this.tbOdul.Location = new System.Drawing.Point(442, 418);
            this.tbOdul.Margin = new System.Windows.Forms.Padding(4);
            this.tbOdul.Name = "tbOdul";
            this.tbOdul.Size = new System.Drawing.Size(184, 24);
            this.tbOdul.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(439, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ödül Ekleyin";
            // 
            // lstbKazananlar
            // 
            this.lstbKazananlar.FormattingEnabled = true;
            this.lstbKazananlar.ItemHeight = 18;
            this.lstbKazananlar.Location = new System.Drawing.Point(216, 326);
            this.lstbKazananlar.Name = "lstbKazananlar";
            this.lstbKazananlar.Size = new System.Drawing.Size(206, 148);
            this.lstbKazananlar.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(213, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kazananlar";
            // 
            // btnOdulEkle
            // 
            this.btnOdulEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdulEkle.Location = new System.Drawing.Point(442, 450);
            this.btnOdulEkle.Name = "btnOdulEkle";
            this.btnOdulEkle.Size = new System.Drawing.Size(184, 25);
            this.btnOdulEkle.TabIndex = 10;
            this.btnOdulEkle.Text = "Ekle";
            this.btnOdulEkle.UseVisualStyleBackColor = true;
            this.btnOdulEkle.Click += new System.EventHandler(this.btnOdulEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.btnOdulEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstbKazananlar);
            this.Controls.Add(this.btnOdulBelirle);
            this.Controls.Add(this.lstbKisiler);
            this.Controls.Add(this.lstbOduller);
            this.Controls.Add(this.pbEfekt);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnKisiEkle);
            this.Controls.Add(this.lblCekilecekEsya);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOdul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKisiEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(657, 547);
            this.MinimumSize = new System.Drawing.Size(657, 506);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çekiliş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEfekt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKisiEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbEfekt;
        private System.Windows.Forms.ListBox lstbOduller;
        private System.Windows.Forms.ListBox lstbKisiler;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblCekilecekEsya;
        private System.Windows.Forms.Timer tmrGif;
        private System.Windows.Forms.Timer tmrFirework;
        private System.ComponentModel.BackgroundWorker bgwGifGoster;
        private System.Windows.Forms.Button btnOdulBelirle;
        private System.Windows.Forms.TextBox tbOdul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstbKazananlar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOdulEkle;
    }
}

