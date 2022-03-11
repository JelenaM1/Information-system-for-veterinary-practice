
namespace VeterinarskaOrdinacija
{
    partial class ZakazivanjePregleda
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PREZIME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.butzak = new System.Windows.Forms.Button();
            this.JMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Clarendon Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRIJAVA PREGLEDA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(275, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(79, 22);
            this.textBox5.TabIndex = 19;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "BROJ KARTONA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "VETERINAR";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(120, 344);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(409, 127);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "UNOS ANAMNEZE";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.IME,
            this.PREZIME,
            this.JMBG});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(120, 170);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(420, 139);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "label7";
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 53;
            // 
            // IME
            // 
            this.IME.Text = "IME";
            this.IME.Width = 103;
            // 
            // PREZIME
            // 
            this.PREZIME.Text = "PREZIME";
            this.PREZIME.Width = 149;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Image = global::VeterinarskaOrdinacija.Properties.Resources.pngwing_com_11_;
            this.label9.Location = new System.Drawing.Point(116, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 24);
            this.label9.TabIndex = 34;
            this.label9.Text = "    ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Image = global::VeterinarskaOrdinacija.Properties.Resources.pngwing_com_10_;
            this.label8.Location = new System.Drawing.Point(116, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "    ";
            // 
            // butzak
            // 
            this.butzak.BackColor = System.Drawing.Color.Turquoise;
            this.butzak.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butzak.ForeColor = System.Drawing.Color.Black;
            this.butzak.Image = global::VeterinarskaOrdinacija.Properties.Resources.pngwing_com_14_;
            this.butzak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butzak.Location = new System.Drawing.Point(239, 477);
            this.butzak.Name = "butzak";
            this.butzak.Size = new System.Drawing.Size(143, 48);
            this.butzak.TabIndex = 23;
            this.butzak.Text = "ZAKAŽI";
            this.butzak.UseCompatibleTextRendering = true;
            this.butzak.UseVisualStyleBackColor = false;
            this.butzak.Click += new System.EventHandler(this.butzak_Click);
            // 
            // JMBG
            // 
            this.JMBG.Text = "JMBG";
            this.JMBG.Width = 31;
            // 
            // ZakazivanjePregleda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 595);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butzak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "ZakazivanjePregleda";
            this.Text = "ZakazivanjePregleda";
            this.Load += new System.EventHandler(this.ZakazivanjePregleda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butzak;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader IME;
        private System.Windows.Forms.ColumnHeader PREZIME;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader JMBG;
    }
}