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
    public partial class ListaPacijenataPlacanjecs : Form
    {
        int order = 1;
       
        public static int idpregl;
        int s_id;
        public static int p_id;
        public ListaPacijenataPlacanjecs()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaPacijenataPlacanjecs_Load(object sender, EventArgs e)
        {
                textBox4.Hide();
            String korisnik = Prijava.korisnik;

            SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand kom = new SqlCommand();
            kom.Connection = konekcija;
            konekcija.Open();
            kom.CommandText = "select Id,ime,brkartona from pacijent";
            SqlDataAdapter daa = new SqlDataAdapter(kom);
            DataSet dss = new DataSet();
            daa.Fill(dss);

            pacijenti.DataSource = dss.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String ordinacijaa = Form1.name;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
          /*      String ime = textBox1.Text;
                String kolicina = textBox2.Text;
                String cena = textBox3.Text;
                String prg = textBox4.Text;
                String ukupno = "";
                int uk = Convert.ToInt32(cena) * Convert.ToInt32(kolicina);*/ 
                String ime = textBox1.Text;
                String kolicina = textBox2.Text;
                double cena = Convert.ToDouble(textBox3.Text);
                String prg = textBox4.Text;
                String ukupno = "";
                double uk = cena * Convert.ToInt32(kolicina);


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into fracun(cena,kolicina,ukupno,imet,pregled) values ('" + cena + "','" + kolicina + "','" + uk + "','" + ime + "','" + prg + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Podaci sačuvani", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            String prgg = textBox4.Text;

            SqlConnection ko = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand km = new SqlCommand();
            km.Connection = ko;
            ko.Open();
            km.CommandText = "select imet,cena,kolicina,ukupno from fracun where pregled='" + prgg + "'";
            SqlDataAdapter aa = new SqlDataAdapter(km);
            DataSet ss = new DataSet();
            aa.Fill(ss);

            dataGridView1.DataSource = ss.Tables[0];

            SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand kom = new SqlCommand();
            kom.Connection = konekcija;
            konekcija.Open();
            kom.CommandText = "select SUM(ukupno) from fracun where pregled='" +prgg+ "'";
            SqlDataAdapter daa = new SqlDataAdapter(kom);
            DataSet dss = new DataSet();
            daa.Fill(dss);

            textBox5.Text = dss.Tables[0].Rows[0][0].ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double uplaceno = Convert.ToDouble(textBox6.Text);
            double ukupno = Convert.ToDouble(textBox5.Text);
            String prgg = textBox4.Text;

            double kusur = uplaceno - ukupno;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "insert into naplata(nukupno,npregled,nnaplaceno,nkusur) values ('" + ukupno + "','" + prgg + "','" + uplaceno + "','" + kusur + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Podaci sačuvani", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FRacun fRacun = new FRacun();
            fRacun.Show();
            String status ="Placen";

            SqlConnection cc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand ccmd = new SqlCommand("update pregled set status = '" + status + "' where id = '" + prgg + "'");
            ccmd.CommandType = CommandType.Text;
            ccmd.Connection = cc;
            cc.Open();
            ccmd.ExecuteNonQuery();


        }

        private void pacijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pacijenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string brkart = "";

            if (pacijenti.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                s_id = int.Parse(pacijenti.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from pacijent where Id='" + s_id+ "'";
            SqlDataAdapter da4 = new SqlDataAdapter(cmd);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);

            brkart = ds4.Tables[0].Rows[0][2].ToString();
            SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand kom = new SqlCommand();
            kom.Connection = konekcija;
            konekcija.Open();
            kom.CommandText = "select Id,datum,status from pregled where pacijent='" +brkart+"'";
            SqlDataAdapter daa = new SqlDataAdapter(kom);
            DataSet dss = new DataSet();
            daa.Fill(dss);

            pregledi.DataSource = dss.Tables[0];

        }

        private void pregledi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void terapijagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double uplaceno = Convert.ToDouble(textBox6.Text);
            double ukupno = Convert.ToDouble(textBox5.Text);
            double kusur = uplaceno - ukupno;
            textBox7.Text = kusur.ToString();
                
        }

        private void pregledi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pregledi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                p_id = int.Parse(pregledi.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBox4.Text = pregledi.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select * from pregled where Id='" + p_id + "'";
            SqlDataAdapter da4 = new SqlDataAdapter(cmd);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            richTextBox1.Text = ds4.Tables[0].Rows[0][4].ToString();
            con.Close();

            SqlConnection conm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmdm = new SqlCommand();
            cmdm.Connection = conm;
            conm.Open();
            cmdm.CommandText = "select * from terapija where pregled='" + p_id + "'";
            SqlDataAdapter da4m = new SqlDataAdapter(cmdm);
            DataSet ds4m = new DataSet();
            da4m.Fill(ds4m);
            richTextBox4.Text = ds4m.Tables[0].Rows[0][1].ToString();
            conm.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
