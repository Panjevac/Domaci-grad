namespace grad.domaci
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.txt_brstanovnika = new System.Windows.Forms.TextBox();
            this.txt_povrsina = new System.Windows.Forms.TextBox();
            this.txt_drzava = new System.Windows.Forms.TextBox();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.btn_izbrisi = new System.Windows.Forms.Button();
            this.btn_pocetak = new System.Windows.Forms.Button();
            this.btn_prethodni = new System.Windows.Forms.Button();
            this.btn_sledeci = new System.Windows.Forms.Button();
            this.btn_kraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj stanovnika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Povrsina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Drzava";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(159, 31);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 5;
            // 
            // txt_naziv
            // 
            this.txt_naziv.Location = new System.Drawing.Point(159, 100);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(100, 22);
            this.txt_naziv.TabIndex = 6;
            // 
            // txt_brstanovnika
            // 
            this.txt_brstanovnika.Location = new System.Drawing.Point(210, 175);
            this.txt_brstanovnika.Name = "txt_brstanovnika";
            this.txt_brstanovnika.Size = new System.Drawing.Size(100, 22);
            this.txt_brstanovnika.TabIndex = 7;
            // 
            // txt_povrsina
            // 
            this.txt_povrsina.Location = new System.Drawing.Point(564, 31);
            this.txt_povrsina.Name = "txt_povrsina";
            this.txt_povrsina.Size = new System.Drawing.Size(100, 22);
            this.txt_povrsina.TabIndex = 8;
            // 
            // txt_drzava
            // 
            this.txt_drzava.Location = new System.Drawing.Point(564, 100);
            this.txt_drzava.Name = "txt_drzava";
            this.txt_drzava.Size = new System.Drawing.Size(100, 22);
            this.txt_drzava.TabIndex = 9;
            this.txt_drzava.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(223, 370);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_dodaj.TabIndex = 10;
            this.btn_dodaj.Text = "dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Location = new System.Drawing.Point(347, 370);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(75, 23);
            this.btn_izmeni.TabIndex = 11;
            this.btn_izmeni.Text = "izmeni";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // btn_izbrisi
            // 
            this.btn_izbrisi.Location = new System.Drawing.Point(459, 370);
            this.btn_izbrisi.Name = "btn_izbrisi";
            this.btn_izbrisi.Size = new System.Drawing.Size(75, 23);
            this.btn_izbrisi.TabIndex = 12;
            this.btn_izbrisi.Text = "izbrisi";
            this.btn_izbrisi.UseVisualStyleBackColor = true;
            this.btn_izbrisi.Click += new System.EventHandler(this.btn_izbrisi_Click);
            // 
            // btn_pocetak
            // 
            this.btn_pocetak.Location = new System.Drawing.Point(77, 296);
            this.btn_pocetak.Name = "btn_pocetak";
            this.btn_pocetak.Size = new System.Drawing.Size(75, 23);
            this.btn_pocetak.TabIndex = 13;
            this.btn_pocetak.Text = "<<";
            this.btn_pocetak.UseVisualStyleBackColor = true;
            this.btn_pocetak.Click += new System.EventHandler(this.btn_pocetak_Click);
            // 
            // btn_prethodni
            // 
            this.btn_prethodni.Location = new System.Drawing.Point(223, 296);
            this.btn_prethodni.Name = "btn_prethodni";
            this.btn_prethodni.Size = new System.Drawing.Size(75, 23);
            this.btn_prethodni.TabIndex = 14;
            this.btn_prethodni.Text = "<";
            this.btn_prethodni.UseVisualStyleBackColor = true;
            this.btn_prethodni.Click += new System.EventHandler(this.btn_prethodni_Click);
            // 
            // btn_sledeci
            // 
            this.btn_sledeci.Location = new System.Drawing.Point(459, 296);
            this.btn_sledeci.Name = "btn_sledeci";
            this.btn_sledeci.Size = new System.Drawing.Size(75, 23);
            this.btn_sledeci.TabIndex = 15;
            this.btn_sledeci.Text = ">";
            this.btn_sledeci.UseVisualStyleBackColor = true;
            this.btn_sledeci.Click += new System.EventHandler(this.btn_sledeci_Click);
            // 
            // btn_kraj
            // 
            this.btn_kraj.Location = new System.Drawing.Point(589, 296);
            this.btn_kraj.Name = "btn_kraj";
            this.btn_kraj.Size = new System.Drawing.Size(75, 23);
            this.btn_kraj.TabIndex = 16;
            this.btn_kraj.Text = ">>";
            this.btn_kraj.UseVisualStyleBackColor = true;
            this.btn_kraj.Click += new System.EventHandler(this.btn_kraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kraj);
            this.Controls.Add(this.btn_sledeci);
            this.Controls.Add(this.btn_prethodni);
            this.Controls.Add(this.btn_pocetak);
            this.Controls.Add(this.btn_izbrisi);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.txt_drzava);
            this.Controls.Add(this.txt_povrsina);
            this.Controls.Add(this.txt_brstanovnika);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.TextBox txt_brstanovnika;
        private System.Windows.Forms.TextBox txt_povrsina;
        private System.Windows.Forms.TextBox txt_drzava;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.Button btn_izbrisi;
        private System.Windows.Forms.Button btn_pocetak;
        private System.Windows.Forms.Button btn_prethodni;
        private System.Windows.Forms.Button btn_sledeci;
        private System.Windows.Forms.Button btn_kraj;
    }
}

