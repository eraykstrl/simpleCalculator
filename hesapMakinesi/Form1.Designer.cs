namespace hesapMakinesi
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
            this.toplama = new System.Windows.Forms.Button();
            this.cikarma = new System.Windows.Forms.Button();
            this.carpma = new System.Windows.Forms.Button();
            this.sinus = new System.Windows.Forms.Button();
            this.BOLME = new System.Windows.Forms.Button();
            this.cosinus = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tanjant = new System.Windows.Forms.Button();
            this.cotanjant = new System.Windows.Forms.Button();
            this.esittir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toplama
            // 
            this.toplama.BackColor = System.Drawing.Color.Blue;
            this.toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplama.Location = new System.Drawing.Point(543, 69);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(118, 48);
            this.toplama.TabIndex = 0;
            this.toplama.Text = "+";
            this.toplama.UseVisualStyleBackColor = false;
            this.toplama.Click += new System.EventHandler(this.button1_Click);
            // 
            // cikarma
            // 
            this.cikarma.BackColor = System.Drawing.Color.Blue;
            this.cikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikarma.Location = new System.Drawing.Point(677, 69);
            this.cikarma.Name = "cikarma";
            this.cikarma.Size = new System.Drawing.Size(111, 48);
            this.cikarma.TabIndex = 1;
            this.cikarma.Text = "-";
            this.cikarma.UseVisualStyleBackColor = false;
            this.cikarma.Click += new System.EventHandler(this.cikarma_Click);
            // 
            // carpma
            // 
            this.carpma.BackColor = System.Drawing.Color.Blue;
            this.carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpma.Location = new System.Drawing.Point(543, 153);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(118, 40);
            this.carpma.TabIndex = 2;
            this.carpma.Text = "X";
            this.carpma.UseVisualStyleBackColor = false;
            this.carpma.Click += new System.EventHandler(this.carpma_Click);
            // 
            // sinus
            // 
            this.sinus.BackColor = System.Drawing.Color.Blue;
            this.sinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinus.Location = new System.Drawing.Point(543, 225);
            this.sinus.Name = "sinus";
            this.sinus.Size = new System.Drawing.Size(118, 44);
            this.sinus.TabIndex = 3;
            this.sinus.Text = "sinx";
            this.sinus.UseVisualStyleBackColor = false;
            this.sinus.Click += new System.EventHandler(this.sinus_Click);
            // 
            // BOLME
            // 
            this.BOLME.BackColor = System.Drawing.Color.Blue;
            this.BOLME.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BOLME.Location = new System.Drawing.Point(677, 153);
            this.BOLME.Name = "BOLME";
            this.BOLME.Size = new System.Drawing.Size(111, 40);
            this.BOLME.TabIndex = 4;
            this.BOLME.Text = "\\";
            this.BOLME.UseVisualStyleBackColor = false;
            this.BOLME.Click += new System.EventHandler(this.BOLME_Click);
            // 
            // cosinus
            // 
            this.cosinus.BackColor = System.Drawing.Color.Blue;
            this.cosinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cosinus.Location = new System.Drawing.Point(677, 225);
            this.cosinus.Name = "cosinus";
            this.cosinus.Size = new System.Drawing.Size(111, 44);
            this.cosinus.TabIndex = 5;
            this.cosinus.Text = "cosx";
            this.cosinus.UseVisualStyleBackColor = false;
            this.cosinus.Click += new System.EventHandler(this.cosinus_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(146, 105);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 128);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tanjant
            // 
            this.tanjant.BackColor = System.Drawing.Color.Blue;
            this.tanjant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tanjant.Location = new System.Drawing.Point(543, 300);
            this.tanjant.Name = "tanjant";
            this.tanjant.Size = new System.Drawing.Size(118, 37);
            this.tanjant.TabIndex = 6;
            this.tanjant.Text = "tanx";
            this.tanjant.UseVisualStyleBackColor = false;
            this.tanjant.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cotanjant
            // 
            this.cotanjant.BackColor = System.Drawing.Color.Blue;
            this.cotanjant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cotanjant.Location = new System.Drawing.Point(677, 300);
            this.cotanjant.Name = "cotanjant";
            this.cotanjant.Size = new System.Drawing.Size(111, 37);
            this.cotanjant.TabIndex = 7;
            this.cotanjant.Text = "cotx";
            this.cotanjant.UseVisualStyleBackColor = false;
            this.cotanjant.Click += new System.EventHandler(this.cotanjant_Click);
            // 
            // esittir
            // 
            this.esittir.BackColor = System.Drawing.Color.Blue;
            this.esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esittir.Location = new System.Drawing.Point(194, 290);
            this.esittir.Name = "esittir";
            this.esittir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.esittir.Size = new System.Drawing.Size(140, 47);
            this.esittir.TabIndex = 8;
            this.esittir.Text = "=";
            this.esittir.UseVisualStyleBackColor = false;
            this.esittir.Click += new System.EventHandler(this.esittir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.esittir);
            this.Controls.Add(this.cotanjant);
            this.Controls.Add(this.tanjant);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cosinus);
            this.Controls.Add(this.BOLME);
            this.Controls.Add(this.sinus);
            this.Controls.Add(this.carpma);
            this.Controls.Add(this.cikarma);
            this.Controls.Add(this.toplama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toplama;
        private System.Windows.Forms.Button cikarma;
        private System.Windows.Forms.Button carpma;
        private System.Windows.Forms.Button sinus;
        private System.Windows.Forms.Button BOLME;
        private System.Windows.Forms.Button cosinus;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button tanjant;
        private System.Windows.Forms.Button cotanjant;
        private System.Windows.Forms.Button esittir;
    }
}

