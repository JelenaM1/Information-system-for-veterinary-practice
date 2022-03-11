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
using System.Configuration;

namespace VeterinarskaOrdinacija
{
    public partial class ZakazivanjePregleda : Form
    {
        int rowid;
        String ordinacijaa = Form1.name;
        String pacijent = PrijemPanel.brojkartonap;
        public ZakazivanjePregleda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ZakazivanjePregleda_Load(object sender, EventArgs e)
        {
            String ordinacijaa = Form1.name;
            String pacijent = PrijemPanel.brojkartonap;
            textBox5.Text = pacijent.ToString();
            label4.Hide();
            label6.Hide();
            label7.Hide();
            listView1.GridLines = true;
            listView1.View = View.Details;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select id,ime,prezime,jmbg from veterinar where ordinacija  = '" + ordinacijaa + "'";
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetString(2).ToString());
                lv.SubItems.Add(rd.GetString(3).ToString());

                listView1.Items.Add(lv);
            }
            rd.Close();
            cmd.Dispose();
            con.Close();


        }
 
        private void butzak_Click(object sender, EventArgs e)
        {
            String anamneza = richTextBox1.Text.ToString();
            String veterinarbr = label7.Text.ToString();
            String pacijent = PrijemPanel.brojkartonap;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into pregled (pacijent,veterinar,anamneza) values ('" + pacijent + "','" + veterinarbr + "','" + anamneza + "')";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string colunmName = listView1.Columns[0].Text;
                string colunmVal0 = listView1.SelectedItems[0].SubItems[0].Text;
                string colunmVal1 = listView1.SelectedItems[0].SubItems[1].Text;
                string colunmVal2 = listView1.SelectedItems[0].SubItems[2].Text;
              string colunmVal3 = listView1.SelectedItems[0].SubItems[3].Text;

                foreach (ListViewItem lvi in listView1.SelectedItems)
                {
                    label4.Text = colunmVal1.ToString();
                    label6.Text = colunmVal2.ToString();
                    label7.Text = colunmVal3.ToString();
                    label7.Hide();
                }
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
        //    veterinarr.Text = listView1.SelectedItems[0].SubItems[1].Text;

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
//            veterinarr.Text = listView1.SelectedItems[0].SubItems[0].Text;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

