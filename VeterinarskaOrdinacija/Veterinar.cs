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
    public partial class Veterinar : Form
    {
        String imagelocation;
        int s_id;
        public static int idv;
        public static String pac="";
        public static String vet = "";
        public static String vla = "";
        public static int idp;
        public static int idpp;
        public Veterinar()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(320, 125);
            panel3.Show();
            panel1.Hide();
            listView3.GridLines = true;
            listView3.View = View.Details;
            String brkartona = textBox4.Text;
            pac = brkartona.ToString();
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            SqlCommand v = new SqlCommand();
            v.Connection = cn;
            v.CommandText = "select id,naziv,datum from vakcina where pacijent = '" + brkartona + "'";
            SqlDataReader rvd;
            rvd = v.ExecuteReader();
            while (rvd.Read())
            {
                ListViewItem lav = new ListViewItem(rvd.GetInt32(0).ToString());
                lav.SubItems.Add(rvd.GetString(1).ToString());
                listView3.Items.Add(lav);
            }
            rvd.Close();
            v.Dispose();
            cn.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Veterinar_Load(object sender, EventArgs e)
        {
            label31.Hide();
            // TODO: This line of code loads data into the 'vetordinacijaDataSet.slike' table. You can move, or remove it, as needed.
            //          this.slikeTableAdapter.Fill(this.vetordinacijaDataSet.slike);
            String ordinacija = Form1.name;
            String korisnik = Prijava.korisnik;
            panel4.Location = new Point(320, 125);
            panel3.Hide();
            panel1.Hide();
            panel4.Show();
            listView2.GridLines = true;
            listView2.View = View.Details;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = con;
            cmdd.CommandText = "select id,ime,prezime,jmbg,korisnickoime from veterinar where korisnickoime  = '" + korisnik + "'";
            SqlDataReader rdd;
            rdd = cmdd.ExecuteReader();
            while (rdd.Read())
            {
                label29.Text = rdd.GetString(3).ToString();
            }
            label29.Hide();
            rdd.Close();
            cmdd.Dispose();
            con.Close();

            String status1 = "Zavrsen";
            String status2 = "Placen";

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //       cmd.CommandText = "select id,pacijent from pregled where veterinar = '" +label29.Text+ "' and status !='" + status1 + "' and status !='" +status2+ "'";
            cmd.CommandText = "select id,pacijent from pregled where veterinar = '" + label29.Text + "'and status is NULL ";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                listView2.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            conn.Close();
            String brkartona = textBox4.Text;
            SqlConnection kon1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            kon1.Open();
            SqlCommand kmd1 = new SqlCommand();
            kmd1.Connection = kon1;
            kmd1.CommandText = "SELECT * FROM VAKCINA WHERE PACIJENT ='" + brkartona + "'";
            SqlDataReader p1;
            p1 = kmd1.ExecuteReader();
            while (p1.Read())
            {
                ListViewItem v1 = new ListViewItem(p1.GetInt32(0).ToString());
                v1.SubItems.Add(p1.GetString(2).ToString());
                listView3.Items.Add(v1);
            }
            p1.Close();
            kmd1.Dispose();
            kon1.Close();
            vet=label29.Text;
        }

        private void početnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel1.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String pregled = label11.Text;
            String brkartona = textBox4.Text;
            String naziv = textBox11.Text;
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
            String ddatum = dateTimePicker2.Text;

            if (textBox11.Text == "")
            {
                MessageBox.Show("Niste uneli naziv slike", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into slike (pacijent,slika, pregled,naziv ) values ('" + brkartona + "',@pic , '" + pregled + "','" + naziv + "')";
                cmd.Parameters.AddWithValue("@pic", img);
                cmd.ExecuteNonQuery();
                con.Close();

                SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand kom = new SqlCommand();
                kom.Connection = konekcija;
                konekcija.Open();
                kom.CommandText = "select id,naziv from slike where pregled = '" + pregled + "'";
                SqlDataAdapter daa = new SqlDataAdapter(kom);
                DataSet dss = new DataSet();
                daa.Fill(dss);

                dataGridView1.DataSource = dss.Tables[0];


            }




        }

        private void panelImages_Paint(object sender, PaintEventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel4.Hide();
            idp = int.Parse(label11.Text.ToString());
            String brkartona = textBox4.Text;
            textBox5.Text = brkartona.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = con;
            cmdd.CommandText = "select * from pacijent where brkartona  = '" + brkartona + "'";
            SqlDataReader rdd;
            rdd = cmdd.ExecuteReader();
            while (rdd.Read())
            {
                textBox6.Text = rdd.GetString(1).ToString();
                textBox7.Text = rdd.GetString(4).ToString();
                textBox8.Text = rdd.GetString(5).ToString(); 
                textBox9.Text = rdd.GetString(6).ToString();
                richTextBox1.Text = rdd.GetString(8).ToString();
                richTextBox2.Text = rdd.GetString(9).ToString();
                // richTextBox3.Text = rdd.GetString(9).ToString();
                textBox10.Text = rdd.GetString(7).ToString(); 
            }
            String godina = DateTime.Now.Year.ToString();
            string rodjenje = textBox10.Text;
            if (textBox10.Text != "")
            {
                int rezultat = Convert.ToInt32(godina) - Convert.ToInt32(rodjenje);
                textBox12.Text = rezultat.ToString();
            }
            label29.Hide();
            rdd.Close();
            cmdd.Dispose();
            con.Close();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cd = new SqlCommand();
            cd.Connection = conn;
            cd.CommandText = "select * from pregled where pacijent  = '" + brkartona + "' and veterinar = '" + label29.Text+ "' and id = '" + idp + "'";
            SqlDataReader d;
            d = cd.ExecuteReader();
            while (d.Read())
            {
                 richTextBox3.Text = d.GetString(3).ToString();
            }
            label29.Hide();
            label11.Hide();
            d.Close();
            cd.Dispose();
            conn.Close();
            listView1.GridLines = true;
            listView1.View = View.Details;
            String datum = DateTime.Now.ToString("dd-M-yyyy");
            SqlConnection kon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            kon.Open();
            SqlCommand kmd = new SqlCommand();
            kmd.Connection = kon;
            kmd.CommandText = "select * from pregled where pacijent ='" + brkartona + "'and status is not NULL";
            SqlDataReader p;
            p = kmd.ExecuteReader();
            while (p.Read())
            {
                ListViewItem v = new ListViewItem(p.GetInt32(0).ToString());
                v.SubItems.Add(p.GetString(6).ToString());
                v.SubItems.Add(p.GetDateTime(8).ToString());
                listView1.Items.Add(v);
            }
            p.Close();
            kmd.Dispose();
            kon.Close();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand dp = new SqlCommand();
            dp.Connection = c;
            dp.CommandText = "select v.ime,v.prezime,v.telefon, v.email,v.adresa,v.jmbg, p.vlasnik from vlasnik v, pacijent p where v.jmbg=p.vlasnik and p.brkartona  ='" + brkartona + "'";
            SqlDataReader read;
            read = dp.ExecuteReader();
            while (read.Read())
            {
                textBox13.Text = read.GetString(0).ToString();
                textBox14.Text = read.GetString(1).ToString();
                textBox16.Text = read.GetString(2).ToString();
                textBox17.Text = read.GetString(3).ToString();
                textBox18.Text = read.GetString(4).ToString();
                vla = read.GetString(5).ToString();
            }
            label29.Hide();
            read.Close();
            dp.Dispose();
            c.Close();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                string colunmName = listView2.Columns[0].Text;
                string col0 = listView2.SelectedItems[0].SubItems[0].Text;
                string col1 = listView2.SelectedItems[0].SubItems[1].Text;
                foreach (ListViewItem lvi in listView2.SelectedItems)
                {
                    label11.Text = col0.ToString();
                    textBox4.Text = col1.ToString();
                    pac = textBox4.Text;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String dijagnoza = richTextBox4.Text.ToString();
            String temperatura = textBox3.Text.ToString();
            String tezina = textBox1.Text.ToString();
            String brojkartona = textBox4.Text;
            String ddatum = dateTimePicker2.Text;
            String ddatumm= DateTime.Now.ToString("dd-MM-yyyy");
            String status = "Zavrsen";
            String terapija = richTextBox5.Text.ToString();
            String pregled = label11.Text;

            if (statuspregl.SelectedItem == "ZAVRŠEN")
            {
                status = "Zavrsen";
            }
            else if (statuspregl.SelectedItem == "PLAĆEN")
            {
                status = "Placen";
            }
            else if (statuspregl.SelectedItem == "U TOKU")
            {
                status = "U toku";
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("update pregled set temperatura = '" + temperatura + "', tezina = '" + tezina + "', dijagnoza = '" + dijagnoza + "', datum = '" + ddatumm + "', status = '" + status + "' where pacijent = '" + brojkartona + "'");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            /* cmd.CommandText = "update pacijent set ime = '" + ime + "', brojcipa = '" + cip + "', vrsta = '" + vrsta + "', rasa = '" + rasa + "', pol = '" + pol + "', grodjenja = '" + godina + "', anomalije = '" + anomalije + "', srcanemane = '" + srmane + "', boja = '" + boja + "' where pasos = '" + pasos + "' or brkartona = '" + brkartona + "'";
             cmd.Connection = con;
             con.Open();
             cmd.ExecuteNonQuery();
             con.Close();*/
            SqlConnection n = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand m = new SqlCommand("update slike set datum = '" + ddatumm + "' where pregled = '" + pregled + "'");
            m.CommandType = CommandType.Text;
            m.Connection = n;
            n.Open();
            m.ExecuteNonQuery();
            n.Close();

            SqlConnection l = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand pp = new SqlCommand();
            pp.CommandType = CommandType.Text;
           pp.CommandText = "insert into terapija (terapija,pacijent,datum,pregled) values ('" +terapija  + "','" + brojkartona + "','" + ddatumm + "','" + pregled + "')";
            pp.Connection = l;
            l.Open();
            pp.ExecuteNonQuery();
            l.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String brkartona = textBox4.Text;
            String nazivv = textBox2.Text;
         //   String ddatumm = DateTime.Now.ToString("dd-MM-yyyy");

            String ddatumm = dateTimePicker1.Text.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "insert into vakcina (pacijent,naziv, datum ) values ('" + brkartona +"','" + nazivv + "','" + ddatumm + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            SqlCommand v = new SqlCommand();
            v.Connection = cn;
            v.CommandText = "select id,naziv,datum from vakcina where pacijent = '" + brkartona + "'";
            SqlDataReader rvd;
            rvd = v.ExecuteReader();
            while (rvd.Read())
            {
                ListViewItem lav = new ListViewItem(rvd.GetInt32(0).ToString());
                lav.SubItems.Add(rvd.GetString(1).ToString());
         //       lav.SubItems.Add(rvd.GetString(2).ToString());
                listView3.Items.Add(lav);
            }
            rvd.Close();
            v.Dispose();
            cn.Close();

        }


        private void button7_Click(object sender, EventArgs e)
        {
            String pregled = label11.Text;
            if (MessageBox.Show("Da li želite da obrišete?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand kmdd = new SqlCommand();
                kmdd.Connection = cnn;

                kmdd.CommandText = "delete from slike where Id = " + s_id + "; ";
                SqlDataAdapter d2 = new SqlDataAdapter(kmdd);
                DataSet dss2 = new DataSet();
                d2.Fill(dss2);

                MessageBox.Show("Obrisano!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand kom = new SqlCommand();
                kom.Connection = konekcija;
                konekcija.Open();
                kom.CommandText = "select id,naziv from slike where pregled = '" + pregled + "'";
                SqlDataAdapter daa = new SqlDataAdapter(kom);
                DataSet dss = new DataSet();
                daa.Fill(dss);

                dataGridView1.DataSource = dss.Tables[0];
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                string colunmName = listView3.Columns[0].Text;
                string col0 = listView3.SelectedItems[0].SubItems[0].Text;
                string col1 = listView3.SelectedItems[0].SubItems[1].Text;
                foreach (ListViewItem lav in listView3.SelectedItems)
                {
                    label31.Text = col0.ToString();

                }
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //idv = int.Parse(label31.Text.ToString());
            VakcIzv vakcIzv = new VakcIzv();
            vakcIzv.Show();
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String pr = "";
            if (listView1.SelectedItems.Count > 0)
            {
                string colunmName = listView1.Columns[0].Text;
                string col0 = listView1.SelectedItems[0].SubItems[0].Text;
                string col1 = listView1.SelectedItems[0].SubItems[1].Text;
                foreach (ListViewItem lav in listView1.SelectedItems)
                { 
                    pr = col0.ToString();
                    idpp= int.Parse(pr.ToString());
                    Prethodnipr prethodnipr = new Prethodnipr();
                    prethodnipr.Show();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                s_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from slike where id = " + s_id + ";";
            SqlDataAdapter da4 = new SqlDataAdapter(cmd);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            DataTable table = new DataTable();
            da5.Fill(table);

            textBox11.Text = ds4.Tables[0].Rows[0][5].ToString();
            byte[] img = (byte[])table.Rows[0][3];
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prijava prijava = new Prijava();
            prijava.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Izvestaj izvestaj =new Izvestaj();
            izvestaj.Show();
        }

        private void uverenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(320, 125);
            panel3.Show();
            panel1.Hide();
            listView3.GridLines = true;
            listView3.View = View.Details;
            String brkartona = textBox4.Text;
            pac = brkartona.ToString();
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            SqlCommand v = new SqlCommand();
            v.Connection = cn;
            v.CommandText = "select id,naziv,datum from vakcina where pacijent = '" + brkartona + "'";
            SqlDataReader rvd;
            rvd = v.ExecuteReader();
            while (rvd.Read())
            {
                ListViewItem lav = new ListViewItem(rvd.GetInt32(0).ToString());
                lav.SubItems.Add(rvd.GetString(1).ToString());
                lav.SubItems.Add(rvd.GetString(2).ToString());
                listView3.Items.Add(lav);
            }
            rvd.Close();
            v.Dispose();
            cn.Close();

        }
    }
}
