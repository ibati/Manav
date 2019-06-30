namespace Manav
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmDomatesKilo = new System.Windows.Forms.Label();
            this.nmDomatesFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmDomKilo = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.nmToplaBiberKilo = new System.Windows.Forms.NumericUpDown();
            this.nmToplamDomKilo = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nmToplamFiyat = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.nmBiberKilo = new System.Windows.Forms.NumericUpDown();
            this.nmBiberFiyat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomKilo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplaBiberKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplamDomKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplamFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBiberKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBiberFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(221, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nmDomatesKilo
            // 
            this.nmDomatesKilo.AutoSize = true;
            this.nmDomatesKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmDomatesKilo.Location = new System.Drawing.Point(375, 41);
            this.nmDomatesKilo.Name = "nmDomatesKilo";
            this.nmDomatesKilo.Size = new System.Drawing.Size(35, 17);
            this.nmDomatesKilo.TabIndex = 4;
            this.nmDomatesKilo.Text = "Kilo";
            // 
            // nmDomatesFiyat
            // 
            this.nmDomatesFiyat.Location = new System.Drawing.Point(188, 65);
            this.nmDomatesFiyat.Name = "nmDomatesFiyat";
            this.nmDomatesFiyat.ReadOnly = true;
            this.nmDomatesFiyat.Size = new System.Drawing.Size(120, 22);
            this.nmDomatesFiyat.TabIndex = 5;
            this.nmDomatesFiyat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nmDomatesFiyat.ValueChanged += new System.EventHandler(this.nmDomatesFiyat_ValueChanged);
            // 
            // nmDomKilo
            // 
            this.nmDomKilo.Location = new System.Drawing.Point(340, 65);
            this.nmDomKilo.Name = "nmDomKilo";
            this.nmDomKilo.Size = new System.Drawing.Size(120, 22);
            this.nmDomKilo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(526, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sepete Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.nmToplaBiberKilo);
            this.groupBox1.Controls.Add(this.nmToplamDomKilo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nmToplamFiyat);
            this.groupBox1.Location = new System.Drawing.Point(141, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 139);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplam Fiyat";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(385, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 49);
            this.button3.TabIndex = 15;
            this.button3.Text = "Yeni Müşteri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nmToplaBiberKilo
            // 
            this.nmToplaBiberKilo.Location = new System.Drawing.Point(286, 76);
            this.nmToplaBiberKilo.Name = "nmToplaBiberKilo";
            this.nmToplaBiberKilo.ReadOnly = true;
            this.nmToplaBiberKilo.Size = new System.Drawing.Size(72, 22);
            this.nmToplaBiberKilo.TabIndex = 27;
            // 
            // nmToplamDomKilo
            // 
            this.nmToplamDomKilo.Location = new System.Drawing.Point(179, 76);
            this.nmToplamDomKilo.Name = "nmToplamDomKilo";
            this.nmToplamDomKilo.ReadOnly = true;
            this.nmToplamDomKilo.Size = new System.Drawing.Size(73, 22);
            this.nmToplamDomKilo.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(283, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "Biber";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(176, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 18);
            this.label12.TabIndex = 27;
            this.label12.Text = "Domates";
            // 
            // nmToplamFiyat
            // 
            this.nmToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmToplamFiyat.Location = new System.Drawing.Point(36, 37);
            this.nmToplamFiyat.Name = "nmToplamFiyat";
            this.nmToplamFiyat.ReadOnly = true;
            this.nmToplamFiyat.Size = new System.Drawing.Size(120, 36);
            this.nmToplamFiyat.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(526, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sepete Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nmBiberKilo
            // 
            this.nmBiberKilo.Location = new System.Drawing.Point(340, 150);
            this.nmBiberKilo.Name = "nmBiberKilo";
            this.nmBiberKilo.Size = new System.Drawing.Size(120, 22);
            this.nmBiberKilo.TabIndex = 13;
            this.nmBiberKilo.ValueChanged += new System.EventHandler(this.nmBiberKilo_ValueChanged);
            // 
            // nmBiberFiyat
            // 
            this.nmBiberFiyat.Location = new System.Drawing.Point(188, 150);
            this.nmBiberFiyat.Name = "nmBiberFiyat";
            this.nmBiberFiyat.ReadOnly = true;
            this.nmBiberFiyat.Size = new System.Drawing.Size(120, 22);
            this.nmBiberFiyat.TabIndex = 12;
            this.nmBiberFiyat.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(375, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kilo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(221, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(66, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Biber";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nmBiberKilo);
            this.Controls.Add(this.nmBiberFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nmDomKilo);
            this.Controls.Add(this.nmDomatesFiyat);
            this.Controls.Add(this.nmDomatesKilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Manav Engin";
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomKilo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplaBiberKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplamDomKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplamFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBiberKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBiberFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nmDomatesKilo;
        private System.Windows.Forms.NumericUpDown nmDomatesFiyat;
        private System.Windows.Forms.NumericUpDown nmDomKilo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmToplamFiyat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nmBiberKilo;
        private System.Windows.Forms.NumericUpDown nmBiberFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmToplaBiberKilo;
        private System.Windows.Forms.NumericUpDown nmToplamDomKilo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
    }
}

