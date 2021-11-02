
namespace SayiTahmin
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbSayiGirisi = new System.Windows.Forms.GroupBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lblSayi = new System.Windows.Forms.Label();
            this.tbSayi = new System.Windows.Forms.TextBox();
            this.gbSonuclar = new System.Windows.Forms.GroupBox();
            this.lblYanlisSayi = new System.Windows.Forms.Label();
            this.lblDogruSayi = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.geriSayim = new System.Windows.Forms.Timer(this.components);
            this.lblSıure = new System.Windows.Forms.Label();
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblDurumAsagiYukari = new System.Windows.Forms.Label();
            this.gbSayiGirisi.SuspendLayout();
            this.gbSonuclar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSayiGirisi
            // 
            this.gbSayiGirisi.Controls.Add(this.btnTahmin);
            this.gbSayiGirisi.Controls.Add(this.lblSayi);
            this.gbSayiGirisi.Controls.Add(this.tbSayi);
            this.gbSayiGirisi.Location = new System.Drawing.Point(31, 32);
            this.gbSayiGirisi.Name = "gbSayiGirisi";
            this.gbSayiGirisi.Size = new System.Drawing.Size(266, 137);
            this.gbSayiGirisi.TabIndex = 0;
            this.gbSayiGirisi.TabStop = false;
            this.gbSayiGirisi.Text = "Sayı Girişi";
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(142, 56);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(85, 20);
            this.btnTahmin.TabIndex = 2;
            this.btnTahmin.Text = "Tahmin";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Location = new System.Drawing.Point(6, 40);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(30, 13);
            this.lblSayi.TabIndex = 1;
            this.lblSayi.Text = "Sayı:";
            // 
            // tbSayi
            // 
            this.tbSayi.Location = new System.Drawing.Point(6, 56);
            this.tbSayi.Name = "tbSayi";
            this.tbSayi.Size = new System.Drawing.Size(100, 20);
            this.tbSayi.TabIndex = 0;
            // 
            // gbSonuclar
            // 
            this.gbSonuclar.Controls.Add(this.lblYanlisSayi);
            this.gbSonuclar.Controls.Add(this.lblDogruSayi);
            this.gbSonuclar.Controls.Add(this.lblYanlis);
            this.gbSonuclar.Controls.Add(this.lblDogru);
            this.gbSonuclar.Location = new System.Drawing.Point(349, 32);
            this.gbSonuclar.Name = "gbSonuclar";
            this.gbSonuclar.Size = new System.Drawing.Size(235, 137);
            this.gbSonuclar.TabIndex = 1;
            this.gbSonuclar.TabStop = false;
            this.gbSonuclar.Text = "Sonuçlar";
            // 
            // lblYanlisSayi
            // 
            this.lblYanlisSayi.AutoSize = true;
            this.lblYanlisSayi.Location = new System.Drawing.Point(59, 79);
            this.lblYanlisSayi.Name = "lblYanlisSayi";
            this.lblYanlisSayi.Size = new System.Drawing.Size(13, 13);
            this.lblYanlisSayi.TabIndex = 2;
            this.lblYanlisSayi.Text = "0";
            // 
            // lblDogruSayi
            // 
            this.lblDogruSayi.AutoSize = true;
            this.lblDogruSayi.Location = new System.Drawing.Point(59, 62);
            this.lblDogruSayi.Name = "lblDogruSayi";
            this.lblDogruSayi.Size = new System.Drawing.Size(13, 13);
            this.lblDogruSayi.TabIndex = 2;
            this.lblDogruSayi.Text = "0";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYanlis.Location = new System.Drawing.Point(17, 79);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(35, 13);
            this.lblYanlis.TabIndex = 1;
            this.lblYanlis.Text = "Yanlış";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDogru.Location = new System.Drawing.Point(16, 62);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(36, 13);
            this.lblDogru.TabIndex = 0;
            this.lblDogru.Text = "Doğru";
            // 
            // geriSayim
            // 
            this.geriSayim.Enabled = true;
            this.geriSayim.Interval = 1000;
            this.geriSayim.Tick += new System.EventHandler(this.geriSayim_Tick);
            // 
            // lblSıure
            // 
            this.lblSıure.AutoSize = true;
            this.lblSıure.Location = new System.Drawing.Point(605, 13);
            this.lblSıure.Name = "lblSıure";
            this.lblSıure.Size = new System.Drawing.Size(29, 13);
            this.lblSıure.TabIndex = 2;
            this.lblSıure.Text = "Süre";
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.AutoSize = true;
            this.lblKalanSure.Font = new System.Drawing.Font("Aquire", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalanSure.Location = new System.Drawing.Point(640, 5);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(33, 24);
            this.lblKalanSure.TabIndex = 3;
            this.lblKalanSure.Text = "10";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(28, 188);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(38, 13);
            this.lblDurum.TabIndex = 4;
            this.lblDurum.Text = "Durum";
            // 
            // lblDurumAsagiYukari
            // 
            this.lblDurumAsagiYukari.AutoSize = true;
            this.lblDurumAsagiYukari.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurumAsagiYukari.Location = new System.Drawing.Point(28, 214);
            this.lblDurumAsagiYukari.Name = "lblDurumAsagiYukari";
            this.lblDurumAsagiYukari.Size = new System.Drawing.Size(69, 16);
            this.lblDurumAsagiYukari.TabIndex = 5;
            this.lblDurumAsagiYukari.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 259);
            this.Controls.Add(this.lblDurumAsagiYukari);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblKalanSure);
            this.Controls.Add(this.lblSıure);
            this.Controls.Add(this.gbSonuclar);
            this.Controls.Add(this.gbSayiGirisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSayiGirisi.ResumeLayout(false);
            this.gbSayiGirisi.PerformLayout();
            this.gbSonuclar.ResumeLayout(false);
            this.gbSonuclar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSayiGirisi;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.TextBox tbSayi;
        private System.Windows.Forms.GroupBox gbSonuclar;
        private System.Windows.Forms.Label lblYanlisSayi;
        private System.Windows.Forms.Label lblDogruSayi;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Timer geriSayim;
        private System.Windows.Forms.Label lblSıure;
        private System.Windows.Forms.Label lblKalanSure;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblDurumAsagiYukari;
    }
}

