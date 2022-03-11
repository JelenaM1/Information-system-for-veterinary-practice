using Microsoft.Reporting.WinForms;
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
    public partial class FRacun : Form
    {
        public FRacun()
        {
            InitializeComponent();
        }

        private void FRacun_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            ReportDataSource racinf = new ReportDataSource("Dataracun", racunInfo());
            ReportDataSource napinf = new ReportDataSource("Datanaplata", naplataInfo());
            ReportDataSource ordinf = new ReportDataSource("Dataordinacija", ordinacijaInfo());
            ReportDataSource vetinf = new ReportDataSource("Datavet", vetInfo());
                     
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy\VeterinarskaOrdinacija\Fracun.rdlc";
            reportViewer1.LocalReport.DataSources.Add(racinf);
            reportViewer1.LocalReport.DataSources.Add(napinf);
            reportViewer1.LocalReport.DataSources.Add(ordinf);
            reportViewer1.LocalReport.DataSources.Add(vetinf);

            reportViewer1.RefreshReport();

        }
        private DataTable ordinacijaInfo()
        {
            String ordinacija = Form1.name;

            DataTable dt = new DataTable();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from ordinacija where naziv ='" + ordinacija + "'", c);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable racunInfo()
        {
            String ordinacija = Form1.name;
            int prg = ListaPacijenataPlacanjecs.p_id;


            DataTable dt = new DataTable();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from fracun where pregled ='" + prg + "'", c);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable naplataInfo()
        {
            String ordinacija = Form1.name;
            int prg = ListaPacijenataPlacanjecs.p_id;


            DataTable dt = new DataTable();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from naplata where npregled ='" + prg + "'", c);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable vetInfo()
        {
            String ordinacija = Form1.name;
            int prg = ListaPacijenataPlacanjecs.p_id;


            DataTable dt = new DataTable();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from vettehnicar where ordinacija ='" + ordinacija + "'", c);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
    }
}
