using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.OleDb;
using UTLoginEx;

namespace RSERP_SO311
{
    public partial class frmSaleReport : Form
    {
        public frmSaleReport()
        {
            InitializeComponent();
        }

        public ReportDocument myReoprts = new ReportDocument();//myReop
        public ReportDocument myReop = new ReportDocument();
        public UTLoginEx.LoginEx iLoginEx = new LoginEx();
        public int SO_SOMain_Id;

        public string sumiquantity = "";
        public string sumIsum = "";
        public string rpt = "";
        private void frmSaleReport_Load(object sender, EventArgs e)
        {

          
            CRVReport.ReportSource = myReoprts;
          
          
            switch (rpt)
            {
                case "cR96":
                    myReoprts.DataDefinition.FormulaFields["sumiquantity"].Text = sumiquantity;
                    myReoprts.DataDefinition.FormulaFields["sumIsum"].Text = sumIsum;
                    break;
                case "CR30890":
                    myReoprts.DataDefinition.FormulaFields["sumiquantity"].Text = sumiquantity;
                    myReoprts.DataDefinition.FormulaFields["sumIsum"].Text = sumIsum;
                    break;
                case "CR30892":
                    myReoprts.DataDefinition.FormulaFields["sumiquantity"].Text = sumiquantity;
                    myReoprts.DataDefinition.FormulaFields["sumIsum"].Text = sumIsum;
                    break;
                case "CR30895":
                     myReoprts.DataDefinition.FormulaFields["sumiquantity"].Text = sumiquantity;
                    break;
                case "CR30906": 
                    myReoprts.DataDefinition.FormulaFields["sumiquantity"].Text = sumiquantity;
                    break;
                case "CR30948": 
                    myReoprts.DataDefinition.FormulaFields["sumiquantity"].Text = sumiquantity;
                    break;
            }
        
            
            crystalReportViewer1.ReportSource = myReop;


           // CRVReport.ReportSource = myReoprts;
           // myReoprts.PrintToPrinter(1, false, 0, 0);//Printtopointer
           
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CRVReport.PrintReport();

            try
            {
                OleDbConnection con = new OleDbConnection(iLoginEx.ConnString());
                con.Open();
                string sql = "select count(*) from zhrs_t_zzcSO_SOAddSeriesInfo where SO_SOMain_Id=" + SO_SOMain_Id + "";
                OleDbCommand com = new OleDbCommand(sql, con);
                int n = Convert.ToInt32(com.ExecuteScalar());
                if (n > 0)
                {
                    crystalReportViewer1.PrintReport();
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
            
           
        }

        private void tsmiclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CRVReport.ShowFirstPage();
        }

        private void tsmifrist_Click(object sender, EventArgs e)
        {
            CRVReport.ShowPreviousPage();
        }

        private void tsmiNext_Click(object sender, EventArgs e)
        {
            CRVReport.ShowNextPage();
        }

        private void tsmiLast_Click(object sender, EventArgs e)
        {
            CRVReport.ShowLastPage();
        }

        
       
    }
}
