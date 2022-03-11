
namespace VeterinarskaOrdinacija
{
    partial class Prijava
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vrsta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 365);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(219, 22);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(142, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lozinka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(142, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Korisničko ime";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(361, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "NASTAVI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vrsta
            // 
            this.vrsta.FormattingEnabled = true;
            this.vrsta.Items.AddRange(new object[] {
            "PRIJEM",
            "PREGLED"});
            this.vrsta.Location = new System.Drawing.Point(322, 414);
            this.vrsta.Name = "vrsta";
            this.vrsta.Size = new System.Drawing.Size(220, 24);
            this.vrsta.TabIndex = 11;
            this.vrsta.SelectedIndexChanged += new System.EventHandler(this.vrsta_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Image = global::VeterinarskaOrdinacija.Properties.Resources.pngwing_com_19_;
            this.label4.Location = new System.Drawing.Point(109, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Image = global::VeterinarskaOrdinacija.Properties.Resources.pngwing_com_17_;
            this.label3.Location = new System.Drawing.Point(109, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "    ";
            // 
            // logo
            // 
            this.logo.Image = global::VeterinarskaOrdinacija.Properties.Resources.VetLife;
            this.logo.Location = new System.Drawing.Point(197, 13);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(381, 278);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 17;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 552);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vrsta);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Prijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox vrsta;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}