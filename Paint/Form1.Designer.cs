namespace Paint
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
            this.pbKolor = new System.Windows.Forms.PictureBox();
            this.btnOlowek = new System.Windows.Forms.Button();
            this.btnGumka = new System.Windows.Forms.Button();
            this.btnElipsa = new System.Windows.Forms.Button();
            this.btnProstokat = new System.Windows.Forms.Button();
            this.btnLinia = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.pbKarta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbKolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKarta)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKolor
            // 
            this.pbKolor.Location = new System.Drawing.Point(10, 18);
            this.pbKolor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbKolor.Name = "pbKolor";
            this.pbKolor.Size = new System.Drawing.Size(51, 47);
            this.pbKolor.TabIndex = 1;
            this.pbKolor.TabStop = false;
            this.pbKolor.Click += new System.EventHandler(this.pbKolor_Click);
            // 
            // btnOlowek
            // 
            this.btnOlowek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOlowek.Location = new System.Drawing.Point(75, 16);
            this.btnOlowek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOlowek.Name = "btnOlowek";
            this.btnOlowek.Size = new System.Drawing.Size(100, 48);
            this.btnOlowek.TabIndex = 2;
            this.btnOlowek.Text = "Ołówek";
            this.btnOlowek.UseVisualStyleBackColor = true;
            this.btnOlowek.Click += new System.EventHandler(this.btnOlowek_Click);
            // 
            // btnGumka
            // 
            this.btnGumka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGumka.Location = new System.Drawing.Point(200, 15);
            this.btnGumka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGumka.Name = "btnGumka";
            this.btnGumka.Size = new System.Drawing.Size(100, 48);
            this.btnGumka.TabIndex = 3;
            this.btnGumka.Text = "Gumka";
            this.btnGumka.UseVisualStyleBackColor = true;
            this.btnGumka.Click += new System.EventHandler(this.btnGumka_Click);
            // 
            // btnElipsa
            // 
            this.btnElipsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElipsa.Location = new System.Drawing.Point(327, 15);
            this.btnElipsa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElipsa.Name = "btnElipsa";
            this.btnElipsa.Size = new System.Drawing.Size(100, 48);
            this.btnElipsa.TabIndex = 4;
            this.btnElipsa.Text = "Elipsa";
            this.btnElipsa.UseVisualStyleBackColor = true;
            this.btnElipsa.Click += new System.EventHandler(this.btnElipsa_Click);
            // 
            // btnProstokat
            // 
            this.btnProstokat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProstokat.Location = new System.Drawing.Point(451, 16);
            this.btnProstokat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProstokat.Name = "btnProstokat";
            this.btnProstokat.Size = new System.Drawing.Size(100, 48);
            this.btnProstokat.TabIndex = 5;
            this.btnProstokat.Text = "Prostokąt";
            this.btnProstokat.UseVisualStyleBackColor = true;
            this.btnProstokat.Click += new System.EventHandler(this.btnProstokat_Click);
            // 
            // btnLinia
            // 
            this.btnLinia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLinia.Location = new System.Drawing.Point(576, 16);
            this.btnLinia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLinia.Name = "btnLinia";
            this.btnLinia.Size = new System.Drawing.Size(100, 48);
            this.btnLinia.TabIndex = 6;
            this.btnLinia.Text = "Linia";
            this.btnLinia.UseVisualStyleBackColor = true;
            this.btnLinia.Click += new System.EventHandler(this.btnLinia_Click);
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyczysc.Location = new System.Drawing.Point(823, 17);
            this.btnWyczysc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(100, 48);
            this.btnWyczysc.TabIndex = 8;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // pbKarta
            // 
            this.pbKarta.BackColor = System.Drawing.Color.White;
            this.pbKarta.Location = new System.Drawing.Point(10, 93);
            this.pbKarta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbKarta.Name = "pbKarta";
            this.pbKarta.Size = new System.Drawing.Size(921, 431);
            this.pbKarta.TabIndex = 11;
            this.pbKarta.TabStop = false;
            this.pbKarta.Paint += new System.Windows.Forms.PaintEventHandler(this.pbKarta_Paint);
            this.pbKarta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbKarta_MouseDown);
            this.pbKarta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbKarta_MouseMove);
            this.pbKarta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbKarta_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 550);
            this.Controls.Add(this.pbKarta);
            this.Controls.Add(this.btnWyczysc);
            this.Controls.Add(this.btnLinia);
            this.Controls.Add(this.btnProstokat);
            this.Controls.Add(this.btnElipsa);
            this.Controls.Add(this.btnGumka);
            this.Controls.Add(this.btnOlowek);
            this.Controls.Add(this.pbKolor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbKolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKarta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbKolor;
        private System.Windows.Forms.Button btnOlowek;
        private System.Windows.Forms.Button btnGumka;
        private System.Windows.Forms.Button btnElipsa;
        private System.Windows.Forms.Button btnProstokat;
        private System.Windows.Forms.Button btnLinia;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.PictureBox pbKarta;
    }
}

