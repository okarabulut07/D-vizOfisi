namespace Doviz_Ofisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDolarAlis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDolarSatis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEuroAlis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEuroSatis = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnDolarAl = new System.Windows.Forms.Button();
            this.btnDolarSat = new System.Windows.Forms.Button();
            this.btnEuroSat = new System.Windows.Forms.Button();
            this.btnEuroAl = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnSatisYap2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış: ";
            // 
            // lblDolarAlis
            // 
            this.lblDolarAlis.AutoSize = true;
            this.lblDolarAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarAlis.ForeColor = System.Drawing.Color.White;
            this.lblDolarAlis.Location = new System.Drawing.Point(113, 29);
            this.lblDolarAlis.Name = "lblDolarAlis";
            this.lblDolarAlis.Size = new System.Drawing.Size(18, 18);
            this.lblDolarAlis.TabIndex = 1;
            this.lblDolarAlis.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dolar Satış: ";
            // 
            // lblDolarSatis
            // 
            this.lblDolarSatis.AutoSize = true;
            this.lblDolarSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarSatis.ForeColor = System.Drawing.Color.White;
            this.lblDolarSatis.Location = new System.Drawing.Point(113, 67);
            this.lblDolarSatis.Name = "lblDolarSatis";
            this.lblDolarSatis.Size = new System.Drawing.Size(18, 18);
            this.lblDolarSatis.TabIndex = 3;
            this.lblDolarSatis.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Euro Alış:";
            // 
            // lblEuroAlis
            // 
            this.lblEuroAlis.AutoSize = true;
            this.lblEuroAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroAlis.ForeColor = System.Drawing.Color.White;
            this.lblEuroAlis.Location = new System.Drawing.Point(113, 99);
            this.lblEuroAlis.Name = "lblEuroAlis";
            this.lblEuroAlis.Size = new System.Drawing.Size(18, 18);
            this.lblEuroAlis.TabIndex = 5;
            this.lblEuroAlis.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Euro Satış:";
            // 
            // lblEuroSatis
            // 
            this.lblEuroSatis.AutoSize = true;
            this.lblEuroSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroSatis.ForeColor = System.Drawing.Color.White;
            this.lblEuroSatis.Location = new System.Drawing.Point(113, 137);
            this.lblEuroSatis.Name = "lblEuroSatis";
            this.lblEuroSatis.Size = new System.Drawing.Size(18, 18);
            this.lblEuroSatis.TabIndex = 7;
            this.lblEuroSatis.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSatisYap2);
            this.groupBox1.Controls.Add(this.btnSatisYap);
            this.groupBox1.Controls.Add(this.txtKalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(215, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 199);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kur:";
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(74, 19);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(159, 26);
            this.txtKur.TabIndex = 10;
            this.txtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Miktar:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(74, 51);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(159, 26);
            this.txtMiktar.TabIndex = 12;
            // 
            // btnDolarAl
            // 
            this.btnDolarAl.Location = new System.Drawing.Point(167, 27);
            this.btnDolarAl.Name = "btnDolarAl";
            this.btnDolarAl.Size = new System.Drawing.Size(37, 23);
            this.btnDolarAl.TabIndex = 9;
            this.btnDolarAl.Text = "...";
            this.btnDolarAl.UseVisualStyleBackColor = true;
            this.btnDolarAl.Click += new System.EventHandler(this.BtnDolarAl_Click);
            // 
            // btnDolarSat
            // 
            this.btnDolarSat.Location = new System.Drawing.Point(167, 62);
            this.btnDolarSat.Name = "btnDolarSat";
            this.btnDolarSat.Size = new System.Drawing.Size(37, 23);
            this.btnDolarSat.TabIndex = 10;
            this.btnDolarSat.Text = "...";
            this.btnDolarSat.UseVisualStyleBackColor = true;
            this.btnDolarSat.Click += new System.EventHandler(this.BtnDolarSat_Click);
            // 
            // btnEuroSat
            // 
            this.btnEuroSat.Location = new System.Drawing.Point(167, 135);
            this.btnEuroSat.Name = "btnEuroSat";
            this.btnEuroSat.Size = new System.Drawing.Size(37, 23);
            this.btnEuroSat.TabIndex = 11;
            this.btnEuroSat.Text = "...";
            this.btnEuroSat.UseVisualStyleBackColor = true;
            this.btnEuroSat.Click += new System.EventHandler(this.BtnEuroSat_Click);
            // 
            // btnEuroAl
            // 
            this.btnEuroAl.Location = new System.Drawing.Point(167, 97);
            this.btnEuroAl.Name = "btnEuroAl";
            this.btnEuroAl.Size = new System.Drawing.Size(37, 23);
            this.btnEuroAl.TabIndex = 12;
            this.btnEuroAl.Text = "...";
            this.btnEuroAl.UseVisualStyleBackColor = true;
            this.btnEuroAl.Click += new System.EventHandler(this.BtnEuroAl_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(74, 83);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(159, 26);
            this.txtTutar.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tutar:";
            // 
            // txtKalan
            // 
            this.txtKalan.Location = new System.Drawing.Point(74, 115);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(159, 26);
            this.txtKalan.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kalan:";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.ForeColor = System.Drawing.Color.Black;
            this.btnSatisYap.Location = new System.Drawing.Point(74, 147);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(69, 28);
            this.btnSatisYap.TabIndex = 17;
            this.btnSatisYap.Text = "İşlem 1";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // btnSatisYap2
            // 
            this.btnSatisYap2.ForeColor = System.Drawing.Color.Black;
            this.btnSatisYap2.Location = new System.Drawing.Point(164, 147);
            this.btnSatisYap2.Name = "btnSatisYap2";
            this.btnSatisYap2.Size = new System.Drawing.Size(69, 28);
            this.btnSatisYap2.TabIndex = 18;
            this.btnSatisYap2.Text = "İşlem 2";
            this.btnSatisYap2.UseVisualStyleBackColor = true;
            this.btnSatisYap2.Click += new System.EventHandler(this.BtnSatisYap2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 429);
            this.Controls.Add(this.btnEuroAl);
            this.Controls.Add(this.btnEuroSat);
            this.Controls.Add(this.btnDolarSat);
            this.Controls.Add(this.btnDolarAl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEuroSatis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEuroAlis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDolarSatis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDolarAlis);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Döviz Bürosu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDolarAlis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDolarSatis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEuroAlis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEuroSatis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDolarAl;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDolarSat;
        private System.Windows.Forms.Button btnEuroSat;
        private System.Windows.Forms.Button btnEuroAl;
        private System.Windows.Forms.Button btnSatisYap2;
    }
}

