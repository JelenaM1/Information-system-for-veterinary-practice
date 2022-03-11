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
    public partial class Prethodnipr : Form
    {
        public Prethodnipr()
        {
            InitializeComponent();
        }

        private void Prethodni_pregledi_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            ReportDataSource ordinf = new ReportDataSource("PDataSet1", ordinacijaInfo());
            ReportDataSource pacinf = new ReportDataSource("PDataSet2", pacijentInfo());
            ReportDataSource preinf = new ReportDataSource("PDataSet3", pregledInfo());
            ReportDataSource sliinf = new ReportDataSource("PDataSet4", slikeInfo());
            ReportDataSource terinf = new ReportDataSource("PDataSet5", terapijaInfo());
            ReportDataSource vlainf = new ReportDataSource("PDataSet6", vlasnikInfo());
            ReportDataSource vetinf = new ReportDataSource("PDataSet7", veterinarInfo());

            reportViewer1.LocalReport.ReportPath = @"C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy\VeterinarskaOrdinacija\Pregled.rdlc";
            reportViewer1.LocalReport.DataSources.Add(ordinf);
            reportViewer1.LocalReport.DataSources.Add(pacinf);
            reportViewer1.LocalReport.DataSources.Add(preinf);
            reportViewer1.LocalReport.DataSources.Add(sliinf);
            reportViewer1.LocalReport.DataSources.Add(terinf);
            reportViewer1.LocalReport.DataSources.Add(vlainf);
            reportViewer1.LocalReport.DataSources.Add(vetinf);

            reportViewer1.RefreshReport();

        }
        private DataTable vakcinaInfo()
        {
            int idvakc = Veterinar.idv;
            String pacijent = Veterinar.pac;

            DataTable dt = new DataTable();
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija - Copy - Copy\VeterinarskaOrdinacija\vetordinacija.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from vakcina where pacijent ='" + pacijent + "'", c);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
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
            int idvakc = Veterinar.idv;
            String pacijent = Veterinar.pac;
            int pr = Veterinar.idpp;
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
            int pr = Veterinar.idpp;

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
            int pr = Veterinar.idpp;

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
