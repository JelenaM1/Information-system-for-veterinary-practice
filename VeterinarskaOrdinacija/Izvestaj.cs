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
    public partial class Izvestaj : Form
    {
        public Izvestaj()
        {
            InitializeComponent();
        }

        private void Izvestaj_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            ReportDataSource ordinf = new ReportDataSource("IDataSet1", ordinacijaInfo());
            ReportDataSource pacinf = new ReportDataSource("IDataSet2", pacijentInfo());
            ReportDataSource preinf = new ReportDataSource("IDataSet3", pregledInfo());
            ReportDataSource sliinf = new ReportDataSource("IDataSet4", slikeInfo());
            ReportDataSource terinf = new ReportDataSource("IDataSet5", terapijaInfo());
            ReportDataSource vlainf = new ReportDataSource("IDataSet6", vlasnikInfo());
            ReportDataSource vetinf = new ReportDataSource("IDataSet7", veterinarInfo());

            reportViewer1.LocalReport.ReportPath = @"C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy\VeterinarskaOrdinacija\Izvestaj.rdlc";
            reportViewer1.LocalReport.DataSources.Add(ordinf);
            reportViewer1.LocalReport.DataSources.Add(pacinf);
            reportViewer1.LocalReport.DataSources.Add(preinf);
            reportViewer1.LocalReport.DataSources.Add(sliinf);
            reportViewer1.LocalReport.DataSources.Add(terinf);
            reportViewer1.LocalReport.DataSources.Add(vlainf);
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
        private DataTable pacijentInfo()
        {
            String pacijent = Veterinar.pac;

            DataTable dt = new DataTable();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from pacijent where brkartona ='" + pacijent + "'", c);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable veterinarInfo()
        {
            String vet = Veterinar.vet;

            DataTable dt = new DataTable();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from veterinar where jmbg ='" + vet + "'", c);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable vlasnikInfo()
        {
            String vla = Veterinar.vla;

            DataTable dt = new DataTable();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from vlasnik where jmbg ='" + vla + "'", c);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }

        private DataTable pregledInfo()
        {
            String pacijent = Veterinar.pac;
            int pr = Veterinar.idp;
            DataTable dt = new DataTable();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from pregled where Id ='" + pr + "'", c);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable slikeInfo()
        {
            int idvakc = Veterinar.idv;
            String pacijent = Veterinar.pac;
            int pr = Veterinar.idp;

            DataTable dt = new DataTable();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from slike where pregled ='" + pr + "'", c);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        private DataTable terapijaInfo()
        {
            int idvakc = Veterinar.idv;
            String pacijent = Veterinar.pac;
            int pr = Veterinar.idp;

            DataTable dt = new DataTable();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from terapija where pregled ='" + pr + "'", c);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
    }
}
