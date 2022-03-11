
namespace VeterinarskaOrdinacija
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lozinka = new System.Windows.Forms.TextBox();
            this.ordinacija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(277, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "NASTAVI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(107, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lozinka";
            // 
            // lozinka
            // 
            this.lozinka.Location = new System.Drawing.Point(257, 184);
            this.lozinka.Name = "lozinka";
            this.lozinka.PasswordChar = '*';
            this.lozinka.Size = new System.Drawing.Size(219, 22);
            this.lozinka.TabIndex = 8;
            // 
            // ordinacija
            // 
            this.ordinacija.Location = new System.Drawing.Point(257, 129);
            this.ordinacija.Name = "ordinacija";
            this.ordinacija.Size = new System.Drawing.Size(219, 22);
            this.ordinacija.TabIndex = 7;
            this.ordinacija.TextChanged += new System.EventHandler(this.ordinacija_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(107, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ordinacija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Image = global::VeterinarskaOrdinacija.Properties.Resources.pngwing_com_19_;
            this.label4.Location = new System.Drawing.Point(76, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Image = global::VeterinarskaOrdinacija.Properties.Resources.pngwing_com_18_;
            this.label3.Location = new System.Drawing.Point(76, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "   ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.ordinacija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lozinka;
        private System.Windows.Forms.TextBox ordinacija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

