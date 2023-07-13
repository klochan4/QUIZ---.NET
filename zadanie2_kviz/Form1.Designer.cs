namespace zadanie2_kviz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_spustiKviz = new System.Windows.Forms.Button();
            this.lbl_odpovede = new System.Windows.Forms.Label();
            this.btn_dalsiaOtazka = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(163, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "KVÍZ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(82, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "a)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(194, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "b)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.Location = new System.Drawing.Point(82, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "c)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button4.Location = new System.Drawing.Point(194, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "d)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_1.Location = new System.Drawing.Point(45, 59);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(291, 58);
            this.lbl_1.TabIndex = 5;
            this.lbl_1.Text = "Znenie otázky";
            this.lbl_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_spustiKviz
            // 
            this.btn_spustiKviz.BackgroundImage = global::zadanie2_kviz.Properties.Resources.zacatKvizImg;
            this.btn_spustiKviz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_spustiKviz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_spustiKviz.Location = new System.Drawing.Point(-30, 265);
            this.btn_spustiKviz.Name = "btn_spustiKviz";
            this.btn_spustiKviz.Size = new System.Drawing.Size(106, 54);
            this.btn_spustiKviz.TabIndex = 6;
            this.btn_spustiKviz.UseVisualStyleBackColor = true;
            this.btn_spustiKviz.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbl_odpovede
            // 
            this.lbl_odpovede.AutoSize = true;
            this.lbl_odpovede.BackColor = System.Drawing.Color.Transparent;
            this.lbl_odpovede.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_odpovede.Location = new System.Drawing.Point(55, 161);
            this.lbl_odpovede.Name = "lbl_odpovede";
            this.lbl_odpovede.Size = new System.Drawing.Size(80, 22);
            this.lbl_odpovede.TabIndex = 7;
            this.lbl_odpovede.Text = "Možnosti";
            // 
            // btn_dalsiaOtazka
            // 
            this.btn_dalsiaOtazka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_dalsiaOtazka.Location = new System.Drawing.Point(306, 265);
            this.btn_dalsiaOtazka.Name = "btn_dalsiaOtazka";
            this.btn_dalsiaOtazka.Size = new System.Drawing.Size(106, 54);
            this.btn_dalsiaOtazka.TabIndex = 8;
            this.btn_dalsiaOtazka.Text = "Ďalšia otázka";
            this.btn_dalsiaOtazka.UseVisualStyleBackColor = true;
            this.btn_dalsiaOtazka.Click += new System.EventHandler(this.btn_dalsiaOtazka_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_info.Location = new System.Drawing.Point(55, 117);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(169, 22);
            this.lbl_info.TabIndex = 9;
            this.lbl_info.Text = "Správne/Nesprávne";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::zadanie2_kviz.Properties.Resources.otaznik;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 431);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_dalsiaOtazka);
            this.Controls.Add(this.lbl_odpovede);
            this.Controls.Add(this.btn_spustiKviz);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kvíz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_spustiKviz;
        private System.Windows.Forms.Label lbl_odpovede;
        private System.Windows.Forms.Button btn_dalsiaOtazka;
        private System.Windows.Forms.Label lbl_info;
    }
}

