using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarskaOrdinacija
{
    public partial class Admin : Form
    {
        String imagelocation;

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            String ordinacijaa = Form1.name;
            int br = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nABAVKEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zAPOSLENIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String ordinacijaa = Form1.name;
            if (textBox5.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                String ime = textBox5.Text;
                String prezime = textBox3.Text;
                String jmbg = textBox4.Text;
                String korisnickoime = textBox2.Text;
                String lozinka = textBox1.Text;
                String ord = ordinacijaa.ToString();

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                int br = 0;
                cmd.CommandText = "insert into veterinar (ime,prezime,jmbg , korisnickoime, lozinka, ordinacija) values ('" + ime + "', '" + prezime + "', '" + jmbg + "', '" + korisnickoime + "','" + lozinka + "', '" + ord + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Podaci sačuvani", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox5.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox2.Clear();
                textBox1.Clear();
                
            }
            else
            {
                MessageBox.Show("Unesite sve podatke.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ordinacijaa = Form1.name;
            if (textIme.Text != "" && textPrezime.Text != "" && textJMBG.Text != "" && textUsername.Text != "" && textPassword.Text != "")
            {
                String ime = textIme.Text;
                String prezime = textPrezime.Text;
                String jmbg = textJMBG.Text;
                String korisnickoime = textUsername.Text;
                String lozinka = textPassword.Text;
                String ord = ordinacijaa.ToString();

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into vettehnicar (ime,prezime,jmbg , korisnickoime, lozinka, ordinacija) values ('" + ime + "', '" + prezime + "', '" + jmbg + "', '" + korisnickoime + "','" + lozinka + "', '" + ord + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Podaci sačuvani", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textIme.Clear();
                textPrezime.Clear();
                textJMBG.Clear();
                textUsername.Clear();
                textPassword.Clear();
            }
            else
            {
                MessageBox.Show("Unesite sve podatke.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void izađiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Prijava pr = new Prijava();
            pr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagelocation = ofd.FileName.ToString();
                pictureBox1.ImageLocation = imagelocation;
            }
            byte[] img = null;
            FileStream Stream = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            img = brs.ReadBytes((int)Stream.Length);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            String naziv = "VetLife";
            String lozinka = "VetLife14";
            SqlCommand m = new SqlCommand("update ordinacija set naziv = '" + naziv + "', logo = @pic where lozinka = '" + lozinka + "'");

            cmd.Parameters.AddWithValue("@pic", img);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
