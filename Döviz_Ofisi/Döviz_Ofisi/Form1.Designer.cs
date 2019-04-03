namespace Döviz_Ofisi
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
            this.LblDolarAl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDolarSat = new System.Windows.Forms.Label();
            this.LblEuroSat = new System.Windows.Forms.Label();
            this.LblEuroAl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnDolarAl = new System.Windows.Forms.Button();
            this.BtnEuroSat = new System.Windows.Forms.Button();
            this.BtnEuroAl = new System.Windows.Forms.Button();
            this.BtnDolarSat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtKur = new System.Windows.Forms.TextBox();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış";
            // 
            // LblDolarAl
            // 
            this.LblDolarAl.AutoSize = true;
            this.LblDolarAl.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarAl.ForeColor = System.Drawing.Color.White;
            this.LblDolarAl.Location = new System.Drawing.Point(148, 38);
            this.LblDolarAl.Name = "LblDolarAl";
            this.LblDolarAl.Size = new System.Drawing.Size(18, 18);
            this.LblDolarAl.TabIndex = 1;
            this.LblDolarAl.Text = "0";
            this.LblDolarAl.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dolar Satış";
            // 
            // LblDolarSat
            // 
            this.LblDolarSat.AutoSize = true;
            this.LblDolarSat.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarSat.ForeColor = System.Drawing.Color.White;
            this.LblDolarSat.Location = new System.Drawing.Point(148, 74);
            this.LblDolarSat.Name = "LblDolarSat";
            this.LblDolarSat.Size = new System.Drawing.Size(18, 18);
            this.LblDolarSat.TabIndex = 3;
            this.LblDolarSat.Text = "0";
            // 
            // LblEuroSat
            // 
            this.LblEuroSat.AutoSize = true;
            this.LblEuroSat.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroSat.ForeColor = System.Drawing.Color.White;
            this.LblEuroSat.Location = new System.Drawing.Point(148, 162);
            this.LblEuroSat.Name = "LblEuroSat";
            this.LblEuroSat.Size = new System.Drawing.Size(18, 18);
            this.LblEuroSat.TabIndex = 4;
            this.LblEuroSat.Text = "0";
            // 
            // LblEuroAl
            // 
            this.LblEuroAl.AutoSize = true;
            this.LblEuroAl.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroAl.ForeColor = System.Drawing.Color.White;
            this.LblEuroAl.Location = new System.Drawing.Point(148, 126);
            this.LblEuroAl.Name = "LblEuroAl";
            this.LblEuroAl.Size = new System.Drawing.Size(18, 18);
            this.LblEuroAl.TabIndex = 5;
            this.LblEuroAl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(66, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Euro Satış";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(66, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Euro Alış";
            // 
            // BtnDolarAl
            // 
            this.BtnDolarAl.Location = new System.Drawing.Point(172, 36);
            this.BtnDolarAl.Name = "BtnDolarAl";
            this.BtnDolarAl.Size = new System.Drawing.Size(46, 23);
            this.BtnDolarAl.TabIndex = 8;
            this.BtnDolarAl.Text = "...";
            this.BtnDolarAl.UseVisualStyleBackColor = true;
            this.BtnDolarAl.Click += new System.EventHandler(this.BtnDolarAl_Click);
            // 
            // BtnEuroSat
            // 
            this.BtnEuroSat.Location = new System.Drawing.Point(172, 157);
            this.BtnEuroSat.Name = "BtnEuroSat";
            this.BtnEuroSat.Size = new System.Drawing.Size(46, 23);
            this.BtnEuroSat.TabIndex = 9;
            this.BtnEuroSat.Text = "...";
            this.BtnEuroSat.UseVisualStyleBackColor = true;
            this.BtnEuroSat.Click += new System.EventHandler(this.BtnEuroSat_Click);
            // 
            // BtnEuroAl
            // 
            this.BtnEuroAl.Location = new System.Drawing.Point(172, 124);
            this.BtnEuroAl.Name = "BtnEuroAl";
            this.BtnEuroAl.Size = new System.Drawing.Size(46, 23);
            this.BtnEuroAl.TabIndex = 10;
            this.BtnEuroAl.Text = "...";
            this.BtnEuroAl.UseVisualStyleBackColor = true;
            this.BtnEuroAl.Click += new System.EventHandler(this.BtnEuroAl_Click);
            // 
            // BtnDolarSat
            // 
            this.BtnDolarSat.Location = new System.Drawing.Point(172, 74);
            this.BtnDolarSat.Name = "BtnDolarSat";
            this.BtnDolarSat.Size = new System.Drawing.Size(46, 23);
            this.BtnDolarSat.TabIndex = 11;
            this.BtnDolarSat.Text = "...";
            this.BtnDolarSat.UseVisualStyleBackColor = true;
            this.BtnDolarSat.Click += new System.EventHandler(this.BtnDolarSat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.TxtKalan);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.TxtKur);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(268, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 216);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kur";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Miktar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tutar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "Kalan";
            // 
            // TxtKur
            // 
            this.TxtKur.Location = new System.Drawing.Point(82, 19);
            this.TxtKur.Name = "TxtKur";
            this.TxtKur.Size = new System.Drawing.Size(173, 26);
            this.TxtKur.TabIndex = 5;
            this.TxtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(82, 87);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(173, 26);
            this.TxtTutar.TabIndex = 6;
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(82, 127);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(173, 26);
            this.TxtKalan.TabIndex = 7;
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(82, 51);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(173, 26);
            this.TxtMiktar.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(82, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "işlem 1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(182, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "işlem 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDolarSat);
            this.Controls.Add(this.BtnEuroAl);
            this.Controls.Add(this.BtnEuroSat);
            this.Controls.Add(this.BtnDolarAl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblEuroAl);
            this.Controls.Add(this.LblEuroSat);
            this.Controls.Add(this.LblDolarSat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblDolarAl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "DÖVİZ BÜROSU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDolarAl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDolarSat;
        private System.Windows.Forms.Label LblEuroSat;
        private System.Windows.Forms.Label LblEuroAl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnDolarAl;
        private System.Windows.Forms.Button BtnEuroSat;
        private System.Windows.Forms.Button BtnEuroAl;
        private System.Windows.Forms.Button BtnDolarSat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.TextBox TxtKur;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

