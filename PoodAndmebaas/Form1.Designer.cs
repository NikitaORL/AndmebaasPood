namespace PoodAndmebaas
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
            this.Toode = new System.Windows.Forms.Label();
            this.Kogus = new System.Windows.Forms.Label();
            this.Hind = new System.Windows.Forms.Label();
            this.Kategooriad = new System.Windows.Forms.Label();
            this.Kat_Box = new System.Windows.Forms.ComboBox();
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.Toode_txt = new System.Windows.Forms.TextBox();
            this.Toode_pb = new System.Windows.Forms.PictureBox();
            this.Lisa_Kat_btn = new System.Windows.Forms.Button();
            this.kustuta_btn = new System.Windows.Forms.Button();
            this.Lisa_btn = new System.Windows.Forms.Button();
            this.Uuenda_btn = new System.Windows.Forms.Button();
            this.Kustuta = new System.Windows.Forms.Button();
            this.Puhasta = new System.Windows.Forms.Button();
            this.OtsiFail = new System.Windows.Forms.Button();
            this.Maksta = new System.Windows.Forms.Button();
            this.Valin = new System.Windows.Forms.Button();
            this.Ostan = new System.Windows.Forms.Button();
            this.SaadaArve = new System.Windows.Forms.Button();
            this.Pood = new System.Windows.Forms.Button();
            this.textBoxPood = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Toode
            // 
            this.Toode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Toode.Location = new System.Drawing.Point(16, 18);
            this.Toode.Name = "Toode";
            this.Toode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Toode.Size = new System.Drawing.Size(100, 64);
            this.Toode.TabIndex = 0;
            this.Toode.Text = "Toode";
            this.Toode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Toode.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kogus
            // 
            this.Kogus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Kogus.Location = new System.Drawing.Point(12, 82);
            this.Kogus.Name = "Kogus";
            this.Kogus.Size = new System.Drawing.Size(116, 27);
            this.Kogus.TabIndex = 1;
            this.Kogus.Text = "Kogus:";
            this.Kogus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Kogus.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Hind
            // 
            this.Hind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Hind.Location = new System.Drawing.Point(40, 120);
            this.Hind.Name = "Hind";
            this.Hind.Size = new System.Drawing.Size(100, 23);
            this.Hind.TabIndex = 2;
            this.Hind.Text = "Hind:";
            this.Hind.Click += new System.EventHandler(this.Hind_Click);
            // 
            // Kategooriad
            // 
            this.Kategooriad.AutoSize = true;
            this.Kategooriad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Kategooriad.Location = new System.Drawing.Point(40, 161);
            this.Kategooriad.Name = "Kategooriad";
            this.Kategooriad.Size = new System.Drawing.Size(99, 20);
            this.Kategooriad.TabIndex = 3;
            this.Kategooriad.Text = "Kategooriad:";
            // 
            // Kat_Box
            // 
            this.Kat_Box.FormattingEnabled = true;
            this.Kat_Box.Location = new System.Drawing.Point(145, 160);
            this.Kat_Box.Name = "Kat_Box";
            this.Kat_Box.Size = new System.Drawing.Size(121, 21);
            this.Kat_Box.TabIndex = 4;
            this.Kat_Box.SelectedIndexChanged += new System.EventHandler(this.Kat_Box_SelectedIndexChanged);
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Location = new System.Drawing.Point(122, 82);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(100, 20);
            this.Kogus_txt.TabIndex = 5;
            // 
            // Hind_txt
            // 
            this.Hind_txt.Location = new System.Drawing.Point(122, 120);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(100, 20);
            this.Hind_txt.TabIndex = 6;
            // 
            // Toode_txt
            // 
            this.Toode_txt.Location = new System.Drawing.Point(122, 42);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.Size = new System.Drawing.Size(100, 20);
            this.Toode_txt.TabIndex = 7;
            // 
            // Toode_pb
            // 
            this.Toode_pb.Location = new System.Drawing.Point(555, 31);
            this.Toode_pb.Name = "Toode_pb";
            this.Toode_pb.Size = new System.Drawing.Size(428, 207);
            this.Toode_pb.TabIndex = 8;
            this.Toode_pb.TabStop = false;
            // 
            // Lisa_Kat_btn
            // 
            this.Lisa_Kat_btn.Location = new System.Drawing.Point(44, 271);
            this.Lisa_Kat_btn.Name = "Lisa_Kat_btn";
            this.Lisa_Kat_btn.Size = new System.Drawing.Size(156, 23);
            this.Lisa_Kat_btn.TabIndex = 9;
            this.Lisa_Kat_btn.Text = "Lisa kategooriat";
            this.Lisa_Kat_btn.UseVisualStyleBackColor = true;
            this.Lisa_Kat_btn.Click += new System.EventHandler(this.Lisa_Kat_btn_Click);
            // 
            // kustuta_btn
            // 
            this.kustuta_btn.Location = new System.Drawing.Point(206, 271);
            this.kustuta_btn.Name = "kustuta_btn";
            this.kustuta_btn.Size = new System.Drawing.Size(149, 23);
            this.kustuta_btn.TabIndex = 10;
            this.kustuta_btn.Text = "Kustuta kategooriat";
            this.kustuta_btn.UseVisualStyleBackColor = true;
            // 
            // Lisa_btn
            // 
            this.Lisa_btn.Location = new System.Drawing.Point(44, 310);
            this.Lisa_btn.Name = "Lisa_btn";
            this.Lisa_btn.Size = new System.Drawing.Size(75, 23);
            this.Lisa_btn.TabIndex = 11;
            this.Lisa_btn.Text = "Lisa";
            this.Lisa_btn.UseVisualStyleBackColor = true;
            this.Lisa_btn.Click += new System.EventHandler(this.Lisa_btn_Click);
            // 
            // Uuenda_btn
            // 
            this.Uuenda_btn.Location = new System.Drawing.Point(122, 310);
            this.Uuenda_btn.Name = "Uuenda_btn";
            this.Uuenda_btn.Size = new System.Drawing.Size(71, 23);
            this.Uuenda_btn.TabIndex = 12;
            this.Uuenda_btn.Text = "Uuenda";
            this.Uuenda_btn.UseVisualStyleBackColor = true;
            this.Uuenda_btn.Click += new System.EventHandler(this.Uuenda_btn_Click);
            // 
            // Kustuta
            // 
            this.Kustuta.Location = new System.Drawing.Point(199, 310);
            this.Kustuta.Name = "Kustuta";
            this.Kustuta.Size = new System.Drawing.Size(75, 23);
            this.Kustuta.TabIndex = 13;
            this.Kustuta.Text = "Kustuta";
            this.Kustuta.UseVisualStyleBackColor = true;
            this.Kustuta.Click += new System.EventHandler(this.Kustuta_Click);
            // 
            // Puhasta
            // 
            this.Puhasta.Location = new System.Drawing.Point(280, 310);
            this.Puhasta.Name = "Puhasta";
            this.Puhasta.Size = new System.Drawing.Size(75, 23);
            this.Puhasta.TabIndex = 14;
            this.Puhasta.Text = "Puhasta";
            this.Puhasta.UseVisualStyleBackColor = true;
            this.Puhasta.Click += new System.EventHandler(this.Puhasta_Click);
            // 
            // OtsiFail
            // 
            this.OtsiFail.Location = new System.Drawing.Point(554, 271);
            this.OtsiFail.Name = "OtsiFail";
            this.OtsiFail.Size = new System.Drawing.Size(104, 23);
            this.OtsiFail.TabIndex = 15;
            this.OtsiFail.Text = "Otsi fail";
            this.OtsiFail.UseVisualStyleBackColor = true;
            this.OtsiFail.Click += new System.EventHandler(this.otsi_fail_btn_Click);
            // 
            // Maksta
            // 
            this.Maksta.Location = new System.Drawing.Point(555, 310);
            this.Maksta.Name = "Maksta";
            this.Maksta.Size = new System.Drawing.Size(103, 23);
            this.Maksta.TabIndex = 16;
            this.Maksta.Text = "Maksta";
            this.Maksta.UseVisualStyleBackColor = true;
            // 
            // Valin
            // 
            this.Valin.Location = new System.Drawing.Point(664, 271);
            this.Valin.Name = "Valin";
            this.Valin.Size = new System.Drawing.Size(106, 23);
            this.Valin.TabIndex = 17;
            this.Valin.Text = "Valin";
            this.Valin.UseVisualStyleBackColor = true;
            // 
            // Ostan
            // 
            this.Ostan.Location = new System.Drawing.Point(776, 271);
            this.Ostan.Name = "Ostan";
            this.Ostan.Size = new System.Drawing.Size(105, 23);
            this.Ostan.TabIndex = 18;
            this.Ostan.Text = "Ostan";
            this.Ostan.UseVisualStyleBackColor = true;
            // 
            // SaadaArve
            // 
            this.SaadaArve.Location = new System.Drawing.Point(887, 271);
            this.SaadaArve.Name = "SaadaArve";
            this.SaadaArve.Size = new System.Drawing.Size(95, 23);
            this.SaadaArve.TabIndex = 19;
            this.SaadaArve.Text = "Saada arve";
            this.SaadaArve.UseVisualStyleBackColor = true;
            // 
            // Pood
            // 
            this.Pood.Location = new System.Drawing.Point(664, 310);
            this.Pood.Name = "Pood";
            this.Pood.Size = new System.Drawing.Size(134, 23);
            this.Pood.TabIndex = 20;
            this.Pood.Text = "Pood";
            this.Pood.UseVisualStyleBackColor = true;
            this.Pood.Click += new System.EventHandler(this.Pood_Click);
            // 
            // textBoxPood
            // 
            this.textBoxPood.Location = new System.Drawing.Point(804, 312);
            this.textBoxPood.Name = "textBoxPood";
            this.textBoxPood.Size = new System.Drawing.Size(179, 20);
            this.textBoxPood.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(938, 288);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1157, 659);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxPood);
            this.Controls.Add(this.Pood);
            this.Controls.Add(this.SaadaArve);
            this.Controls.Add(this.Ostan);
            this.Controls.Add(this.Valin);
            this.Controls.Add(this.Maksta);
            this.Controls.Add(this.OtsiFail);
            this.Controls.Add(this.Puhasta);
            this.Controls.Add(this.Kustuta);
            this.Controls.Add(this.Uuenda_btn);
            this.Controls.Add(this.Lisa_btn);
            this.Controls.Add(this.kustuta_btn);
            this.Controls.Add(this.Lisa_Kat_btn);
            this.Controls.Add(this.Toode_pb);
            this.Controls.Add(this.Toode_txt);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.Kat_Box);
            this.Controls.Add(this.Kategooriad);
            this.Controls.Add(this.Hind);
            this.Controls.Add(this.Kogus);
            this.Controls.Add(this.Toode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Toode;
        private System.Windows.Forms.Label Kogus;
        private System.Windows.Forms.Label Hind;
        private System.Windows.Forms.Label Kategooriad;
        private System.Windows.Forms.ComboBox Kat_Box;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.TextBox Toode_txt;
        private System.Windows.Forms.PictureBox Toode_pb;
        private System.Windows.Forms.Button Lisa_Kat_btn;
        private System.Windows.Forms.Button kustuta_btn;
        private System.Windows.Forms.Button Lisa_btn;
        private System.Windows.Forms.Button Uuenda_btn;
        private System.Windows.Forms.Button Kustuta;
        private System.Windows.Forms.Button Puhasta;
        private System.Windows.Forms.Button OtsiFail;
        private System.Windows.Forms.Button Maksta;
        private System.Windows.Forms.Button Valin;
        private System.Windows.Forms.Button Ostan;
        private System.Windows.Forms.Button SaadaArve;
        private System.Windows.Forms.Button Pood;
        private System.Windows.Forms.TextBox textBoxPood;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

