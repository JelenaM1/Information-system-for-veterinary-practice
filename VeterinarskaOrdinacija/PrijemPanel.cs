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
    public partial class PrijemPanel : Form
    {
        private string id;
        int rowid;
        public static String brojkartonap = "";
        public PrijemPanel()
        {
            InitializeComponent();
        }

        private void PrijemPanel_Load(object sender, EventArgs e)
        {
            String korisnik = Prijava.korisnik;
            String ordinacijaa = Form1.name;
            panel3.Hide();
            panel1.Location = new Point(20, 129);
            panel1.Show();
           
            }
    
         private void button1_Click(object sender, EventArgs e)
         {
            brojkartonap = textBox1.Text.ToString();
            ZakazivanjePregleda zakazivanje = new ZakazivanjePregleda();
            zakazivanje.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void label23_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void preglediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPacijenataPlacanjecs listaPacijenataPlacanjecs = new ListaPacijenataPlacanjecs();
            listaPacijenataPlacanjecs.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String cipp = textBox2.Text;
            panel1.Hide();
            dataGrid.Location = new Point(491, 75);
            dataGrid.Show();
            panel3.Show();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void dodajNovogPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           panel1.Hide();
           textBox5.Clear();
           textBox6.Clear();
           textBox9.Clear();
           textBox10.Clear();
           textBox7.Clear();
           textBox8.Clear();
           textBox11.Clear();
           textBox19.Clear();
           richTextBox1.Clear();
           richTextBox2.Clear();
           textBox13.Clear();
           textBox14.Clear();
           textBox15.Clear();
           textBox16.Clear();
           textBox17.Clear();
           textBox18.Clear();
           textBox12.Clear();
           panel3.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            String brkartona = textBox5.Text;
            String ime = textBox6.Text;
            String pasos = textBox9.Text;
            String cip = textBox10.Text;
            String vrsta = textBox7.Text;
            String rasa = textBox8.Text;
            String godina = textBox11.Text;
            String boja = textBox19.Text;
            String anomalije = richTextBox1.Text;
            String srmane = richTextBox2.Text;
            String pol = "";
            String imevlasnika = textBox13.Text;
            String prezimevlasnika = textBox14.Text;
            String jmbgv = textBox15.Text;
            String telefon = textBox16.Text;
            String email = textBox17.Text;
            String adresa = textBox18.Text;

            if (comboBox3.SelectedItem == "ŽENSKI")
                 {
                    pol = "Zenski";
                }else if(comboBox3.SelectedItem == "MUŠKI")
                 {
                    pol = "Muski";
                 }   
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("select id from vlasnik where jmbg = '" + jmbgv + "'");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            bool temp = false;
            String idd = "";
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                while (sdr.Read())
                {
                    idd = sdr["id"].ToString();
                    temp = true;
                }
            }
            con.Close();
            if (temp == true)
            {
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into pacijent (ime,brkartona,brojcipa ,vrsta,rasa,pol, grodjenja,anomalije,srcanemane,vlasnik,boja,pasos) values ('" + ime + "','" + brkartona + "','" + cip + "','" + vrsta + "','" + rasa + "','" + pol + "','" + godina + "','" + anomalije + "','" + srmane + "','" + jmbgv + "','" + boja + "','" + pasos + "')"; 
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (temp == false)
            {
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into vlasnik (ime,prezime,telefon,email,adresa,jmbg) values ('" + imevlasnika + "','" + prezimevlasnika + "','" + telefon + "','" + email + "','" + adresa + "','" + jmbgv + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                SqlCommand cmdd = new SqlCommand("select id from vlasnik where jmbg = '" + jmbgv + "'");
                cmdd.CommandType = CommandType.Text;
                cmdd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmdd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        idd = sdr["id"].ToString();
                    }
                }
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into pacijent (ime,brkartona,brojcipa ,vrsta,rasa,pol, grodjenja,anomalije, srcanemane, vlasnik,boja,pasos) values ('" + ime + "','" + brkartona + "','" + cip + "','" + vrsta + "','" + rasa + "','" + pol + "','" + godina + "','" + anomalije + "','" + srmane + "','" + jmbgv + "','" + boja + "','" + pasos + "')";
         
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            string godina = DateTime.Now.Year.ToString();
            string rodjenje = textBox11.Text;
            int rezultat = Convert.ToInt32(godina) - Convert.ToInt32(rodjenje);
            textBox12.Text = rezultat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Azurirati podatke?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String brkartona = textBox5.Text;
                String ime = textBox6.Text;
                String pasos = textBox9.Text;
                String cip = textBox10.Text;
                String vrsta = textBox7.Text;
                String rasa = textBox8.Text;
                String godina = textBox11.Text;
                String boja = textBox19.Text;
                String anomalije = richTextBox1.Text;
                String srmane = richTextBox2.Text;
                String pol = "";
                String imevlasnika = textBox13.Text;
                String prezimevlasnika = textBox14.Text;
                String jmbgv = textBox15.Text;
                String telefon = textBox16.Text;
                String email = textBox17.Text;
                String adresa = textBox18.Text;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("update vlasnik set ime = '" + imevlasnika + "', prezime = '" + prezimevlasnika + "', telefon = '" + telefon + "', email = '" + email + "', adresa = '" + adresa + "' where jmbg = '" + jmbgv + "'");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "update pacijent set ime = '" + ime + "', brojcipa = '" + cip + "', vrsta = '" + vrsta + "', rasa = '" + rasa + "', pol = '" + pol + "', grodjenja = '" + godina + "', anomalije = '" + anomalije + "', srcanemane = '" + srmane + "', boja = '" + boja + "' where pasos = '" + pasos + "' or brkartona = '" +brkartona + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                String karton = textBox1.Text.ToString();
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,brkartona,ime,rasa,vlasnik,brojcipa from pacijent where brkartona LIKE '" + karton + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGrid.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,brkartona,ime,rasa,vlasnik,brojcipa from pacijent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGrid.DataSource = ds.Tables[0];
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                String cip = textBox2.Text.ToString();
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,brkartona,ime,rasa,vlasnik,brojcipa from pacijent where brojcipa LIKE '" + cip + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGrid.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,brkartona,ime,rasa,vlasnik,brojcipa from pacijent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGrid.DataSource = ds.Tables[0];
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                String JMBG = textBox3.Text.ToString();
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,brkartona,ime,rasa,vlasnik,brojcipa from pacijent where vlasnik LIKE '" + JMBG + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGrid.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,brkartona,ime,rasa,vlasnik,brojcipa from pacijent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGrid.DataSource = ds.Tables[0];
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                String IMEP = textBox4.Text.ToString();
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,brkartona,ime,rasa,vlasnik,brojcipa from pacijent where ime LIKE '" + IMEP + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGrid.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,brkartona,ime,rasa,vlasnik,brojcipa from pacijent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGrid.DataSource = ds.Tables[0];
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from pacijent where id = " + rowid + ";";
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            con.Open();

            textBox1.Text = ds2.Tables[0].Rows[0][2].ToString();
            textBox2.Text = ds2.Tables[0].Rows[0][3].ToString();
            textBox3.Text = ds2.Tables[0].Rows[0][10].ToString();
            textBox4.Text = ds2.Tables[0].Rows[0][1].ToString();

            textBox6.Text = ds2.Tables[0].Rows[0][1].ToString();
            textBox9.Text = ds2.Tables[0].Rows[0][12].ToString();
            textBox7.Text = ds2.Tables[0].Rows[0][4].ToString();
            textBox10.Text = ds2.Tables[0].Rows[0][3].ToString();
            textBox5.Text = ds2.Tables[0].Rows[0][2].ToString();

            textBox8.Text = ds2.Tables[0].Rows[0][5].ToString();
            textBox11.Text = ds2.Tables[0].Rows[0][7].ToString();
            textBox19.Text = ds2.Tables[0].Rows[0][11].ToString();
            richTextBox1.Text = ds2.Tables[0].Rows[0][8].ToString();
            richTextBox2.Text = ds2.Tables[0].Rows[0][9].ToString();

            con.Close();
            String jmbgv = textBox3.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmdd = new SqlCommand("select * from vlasnik where jmbg = '" + jmbgv + "'");
            cmdd.CommandType = CommandType.Text;
            cmdd.Connection = conn;
            conn.Open();
            String imev = "";
            String prezimev = "";
            String telefonv = "";
            String email = "";
            String adresa = "";
            String jmbg = "";
            using (SqlDataReader ssdr = cmdd.ExecuteReader())
            {
                while (ssdr.Read())
                {
                    imev = ssdr["ime"].ToString();
                    prezimev = ssdr["prezime"].ToString();
                    telefonv = ssdr["telefon"].ToString();
                    email = ssdr["email"].ToString();
                    adresa = ssdr["adresa"].ToString();
                    jmbg = ssdr["jmbg"].ToString();
                    textBox13.Text = imev;
                    textBox14.Text = prezimev;
                    textBox15.Text = jmbg;
                    textBox16.Text = telefonv;
                    textBox17.Text = email;
                    textBox18.Text = adresa;
                }
            }
            conn.Close();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {
            string godina = DateTime.Now.Year.ToString();
            string rodjenje = textBox11.Text;
            if (textBox11.Text != "")
            {
                int rezultat = Convert.ToInt32(godina) - Convert.ToInt32(rodjenje);
                textBox12.Text = rezultat.ToString();
            }

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pOČETNAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String korisnik = Prijava.korisnik;
            String ordinacijaa = Form1.name;
            panel3.Hide();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
  //          dataGrid.Location = new Point(491, 75);
 //           dataGrid.Show();
            panel1.Location = new Point(20, 129);
            panel1.Show();

        }

        private void zakažiPregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZakazivanjePregleda zakazivanjePregleda = new ZakazivanjePregleda();
            zakazivanjePregleda.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prijava prijava = new Prijava();
            prijava.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            String brkartona = textBox5.Text;
            String ime = textBox6.Text;
            String pasos = textBox9.Text;
            String cip = textBox10.Text;
            String cipp = textBox2.Text;

            String vrsta = textBox7.Text;
            String rasa = textBox8.Text;
            String godina = textBox11.Text;
            String boja = textBox19.Text;
            String anomalije = richTextBox1.Text;
            String srmane = richTextBox2.Text;
            String pol = "";
            String imevlasnika = textBox13.Text;
            String prezimevlasnika = textBox14.Text;
            String jmbgv = textBox15.Text;
            String telefon = textBox16.Text;
            String email = textBox17.Text;
            String adresa = textBox18.Text;

            if (comboBox3.SelectedItem == "ŽENSKI")
            {
                pol = "Zenski";
            }
            else if (comboBox3.SelectedItem == "MUŠKI")
            {
                pol = "Muski";
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("update pacijetn set ime = '" + ime + "', vrsta = '" + vrsta + "', brkartona = '" + brkartona + "', rasa = '" + rasa + "', pol = '" + pol + "', grodjenja = '" + godina + "', anomalije = '" + anomalije + "', srcanemane = '" + srmane + "', boja = '" + boja + "', pasos = '" + pasos + "', brojcipa = '" + cipp + "' where brojcipa = '" + cip + "'");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            SqlConnection coon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmdo = new SqlCommand("update vlasnik set ime = '" + imevlasnika + "', prezime = '" + prezimevlasnika + "', telefon = '" + telefon + "', email = '" + email + "', adresa = '" + adresa + "', jmbg = '" + jmbgv + "' where jmbg = '" + jmbgv + "'");
            cmdo.CommandType = CommandType.Text;
            cmdo.Connection = coon;
            coon.Open();
            cmdo.ExecuteNonQuery();
            coon.Close();

        }

        private void listaPacijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}