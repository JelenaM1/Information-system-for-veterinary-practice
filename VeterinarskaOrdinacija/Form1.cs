using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarskaOrdinacija
{
    public partial class Form1 : Form
    {
        public static String name = "";
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ordinacija.Text == "" || lozinka.Text == "")
            {
                MessageBox.Show("Popunite sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from ordinacija where naziv = '" + ordinacija.Text + "' and lozinka = '" + lozinka.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {

                    name = ordinacija.Text;
                    this.Hide();
                    Prijava pr = new Prijava();
                    pr.Show();
                }else
                {
                    MessageBox.Show("Pogrešno ime ili lozinka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ordinacija_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
