using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.IO;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarskaOrdinacija
{
    public partial class VakcIzv : Form
    {
        public VakcIzv()
        {
            InitializeComponent();
        }

        private void VakcIzv_Load(object sender, EventArgs e)
        {
            String ordinacija = Form1.name;
            int idvakc = Veterinar.idv;
            int vid = Veterinar.idv;
            String pacijent = Veterinar.pac;
            this.reportViewer1.RefreshReport();

            ReportDataSource ordinf = new ReportDataSource("MDataSet1", ordinacijaInfo());
            ReportDataSource vakinf = new ReportDataSource("MDataSet2", vakcinaInfo());
            ReportDataSource pacinf = new ReportDataSource("MDataSet3", pacijentInfo());
            ReportDataSource vetinf = new ReportDataSource("MDataSet4", veterinarInfo());
            ReportDataSource vlainf = new ReportDataSource("MDataSet5", vlasnikInfo());

            reportViewer1.LocalReport.ReportPath = @"C:\Users\Jeca\source\repos\VeterinarskaOrdinacija - Copy\VeterinarskaOrdinacija\Vakcina.rdlc";
            reportViewer1.LocalReport.DataSources.Add(ordinf);
            reportViewer1.LocalReport.DataSources.Add(vakinf);
            reportViewer1.LocalReport.DataSources.Add(pacinf);
            reportViewer1.LocalReport.DataSources.Add(vetinf);
            reportViewer1.LocalReport.DataSources.Add(vlainf);


            reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
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


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
