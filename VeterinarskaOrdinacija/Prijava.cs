using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace VeterinarskaOrdinacija
{
    public partial class Prijava : Form
    {
        public static String korisnik = "";
        
        public Prijava()
        {
            InitializeComponent();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            String ordinacijaa = Form1.name;
           
        }
        private void admin_Click(object sender, EventArgs e)
        {
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object selectedItem = vrsta.SelectedItem;
            String ordinacijaa = Form1.name;

            if (selectedItem == null || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Popunite sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBox1.Text == "admin" || textBox2.Text == "admin")
            {
                korisnik = "admin";
                this.Hide();
                Admin ap = new Admin();
                ap.Show();
            }
            else if (selectedItem.ToString() == "PRIJEM")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from vettehnicar where korisnickoime = '" + textBox1.Text + "' and lozinka = '" + textBox2.Text + "'  and ordinacija = '" + ordinacijaa + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    korisnik = textBox1.Text;
                    this.Hide();
                    PrijemPanel panel = new PrijemPanel();
                    panel.Show();

                }
                else
                {
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectedItem.ToString() == "PREGLED")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from veterinar where korisnickoime = '" + textBox1.Text + "' and lozinka = '" + textBox2.Text + "'  and ordinacija = '" + ordinacijaa + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    korisnik = textBox1.Text;
                    this.Hide();
                    Veterinar vt = new Veterinar();
                    vt.Show();
                }
                else
                {
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void vrsta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }
}
