using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.OleDb;
using UTLoginEx;
using CrystalDecisions.Shared;
using System.Threading;

namespace RSERP_SO311
{
    public partial class frmReport : Form
    {

        //定于报表文档对象
        /// <summary>
        ///  //加载水晶报表
        /// </summary>
        private ReportDocument myReoprts = new ReportDocument();
        private ReportDocument myReop = new ReportDocument();
        
        public  UTLoginEx.LoginEx iLoginEx = new LoginEx();
       
        public int SO_SOMain_Id;

        public frmReport()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Text = "                                     正在加载报表，请稍后.....";
            iLoginEx.WriteUserProfileValue("SO311", "cboReport", cboReport.Text);
            string selectSQL = "select sq.cbustype,sq.cstname,sq.csocode,sq.ddate ,sq.ccuscode,sq.ccusdefine6,sq.cexch_name,convert(varchar(100),convert(money,sq.iexchrate),2) as iexchrate,sq.iTaxRate,sq.cdepname,sq.cpersonname,sq.ccusabbname,sq.cpayname,  \r\n";
            selectSQL += " sq.cmaker,sq.cverifier,sq.cmemo,sq.ccusphone,sq.ccusaddress,sq.ccusdefine8,sq.ccusdefine9,sq.cscname as csccode,   \r\n";
            selectSQL += " sqs.cInvCode,sqs.cInvName,sqs.cInvStd,sqs.cinvm_unit as cinvmunit,convert(varchar(100),convert(money,sqs.iquantity),1) as iquantity, convert(varchar(100),convert(money,sqs.itaxunitprice),2) as itaxunitprice , convert(varchar(100),sqs.isum,1) as isum,sqs.isosid  \r\n";
            selectSQL += " ,sqs.cinvdefine6 as SQ_cinvdefine6,sqs.cinvdefine9,sqs.cdefine33,sqs.cdefine31,sqs.cdefine22,sqs.cdefine23,sqs.irowno,sqs.cmemo as SQ_cmemo,convert(varchar, sqs.dpredate,111) as 'dpredate' ,sqs.cinvdefine4,sqs.cfree4,sqs.cinvdefine7 \r\n";
            selectSQL += "  from SaleOrderQ sq inner join SaleOrderSQ sqs on sq.id=sqs.id where  sq.id=" + SO_SOMain_Id + " order by irowno  \r\n";

            //string selectSQL = "select sq.cbustype,sq.cstname,sq.csocode,sq.ddate ,sq.ccuscode,sq.ccusdefine6,sq.cexch_name,sq.iexchrate,sq.iTaxRate,sq.cdepname,  \r\n";
            //selectSQL += " sq.cpersonname,sq.ccusabbname,sq.cpayname,sq.cmaker,sq.cverifier,sq.cmemo,sq.ccusphone,sq.ccusaddress,sq.ccusdefine8,sq.ccusdefine9,sq.cscname,  \r\n";
            //selectSQL += "   \r\n";
            //selectSQL += " sqs.cInvCode,sqs.cInvName,sqs.cInvStd,sqs.cinvm_unit,sqs.iquantity,sqs.itaxunitprice,sqs.isum,sqs.isosid,sqs.cinvdefine6 as SQ_cinvdefine6,sqs.cinvdefine9,  \r\n";
            //selectSQL += " sqs.cdefine33,sqs.cdefine31,sqs.cdefine22,sqs.cdefine23,sqs.irowno,sqs.cmemo as SQ_cmemo,sqs.dpredate,sqs.cinvdefine4,sqs.cfree4,sqs.cinvdefine7,sqs.cinvdefine8   \r\n";
            //selectSQL += "  from SaleOrderQ sq inner join SaleOrderSQ sqs on sq.id=sqs.id where  sq.id=" + SO_SOMain_Id + " order by irowno     \r\n";
            //selectSQL += "   \r\n";
            try
            {
                OLEDBHelper.iLoginEx = iLoginEx;
                string sql_as = "";
                sql_as = "if object_id('tempdb..zhrs_t_CB_SG_Info') is not null   \r\n";
                sql_as += " drop table tempdb..zhrs_t_CB_SG_Info  \r\n";
                OLEDBHelper.ExecuteNonQuery(sql_as, CommandType.Text);

                sql_as = "create table tempdb..zhrs_t_CB_SG_Info  \r\n";
                sql_as += " (  \r\n";
                sql_as += " iRow int,  \r\n";
                sql_as += " Csocode varchar(50),  \r\n";
                sql_as += " Cinvcodes varchar(50),  \r\n";
                sql_as += " Cinvcode varchar(50),  \r\n";
                sql_as += " CinvName varchar(225),  \r\n";
                sql_as += " Cinvstd varchar(225),  \r\n";
                sql_as += " CcomunitName varchar(10),  \r\n";
                sql_as += " BaseQtyND decimal(28,4),  \r\n";
                sql_as += " Ciquantity decimal(28,4),  \r\n";
                sql_as += " SiQuotedPrice decimal(28,4),  \r\n";
                sql_as += " SiSum decimal(28,4)  \r\n";
                sql_as += " )  \r\n";
                OLEDBHelper.ExecuteNonQuery(sql_as, CommandType.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误！"+ex.Message);
            }

           
           string selectSQL_CB = "select zt.iRow, zt.Csocode,zt.Cinvcodes,zt.Cinvcode,zt.CinvName,zt.Cinvstd,zt.CcomunitName,zt.BaseQtyND,zt.Ciquantity,zt.SiQuotedPrice,zt.SiSum   \r\n";
           selectSQL_CB += " from zhrs_t_zzcSO_SOAddSeriesInfo zt   \r\n";
           selectSQL_CB += " where zt.SO_SOMain_Id=" + SO_SOMain_Id + "  \r\n";
        

             int n=cboReport.SelectedIndex;
             string rpt = "";
            switch (n)
            {
                case 0: rpt = "cR96"; break;
                case 1: rpt = "CR30890"; break;
                case 2: rpt = "CR30892"; break;
                case 3: rpt = "CR30895"; break;
                case 4: rpt = "CR30906"; break;
                case 5: rpt = "CR30948"; break;
            }
            DataSet ds = new DataSet();
            OleDbConnection sqlCon = new OleDbConnection(iLoginEx.ConnString());
            sqlCon.Open();
            OleDbCommand sqlCmd = new OleDbCommand(selectSQL, sqlCon);
            try
            {
                OleDbDataAdapter sqlAd = new OleDbDataAdapter();
                sqlAd.SelectCommand = new OleDbCommand(selectSQL_CB, sqlCon);
                sqlAd.Fill(ds, "selectSQL_CB");
                sqlAd.SelectCommand = sqlCmd;
                sqlAd.Fill(ds, "sql");
              


                selectSQL = "select convert(money,sum(sqs.iquantity),1)as iquantity,sum(isum) as isum from SaleOrderSQ sqs where  sqs.id=" + SO_SOMain_Id + " group by sqs.id";
                sqlCmd.CommandText = selectSQL;
                OleDbDataReader dr = sqlCmd.ExecuteReader();
                string sumiquantity = "";
                string sumIsum = "";
                if (dr.Read())
                {
                    sumiquantity = String.Format("{0:F}", dr["iquantity"]);
                    sumIsum = dr["isum"].ToString();
                }
                dr.Close();

                sqlCon.Close();
                GC.Collect();
                //获取报表路径
              
                string path_CB = Application.StartupPath + "\\zzcReport\\CB_SG_Info.rpt";
                string path = Application.StartupPath + "\\zzcReport\\" + rpt + ".rpt";
                myReoprts.Close();
                myReop.Load(path_CB);
                myReoprts.Load(path);
                myReoprts.SetDataSource(ds.Tables["sql"]);
                myReop.SetDataSource(ds.Tables["selectSQL_CB"]);
              
           
                frmSaleReport frm = new frmSaleReport();
                frm.myReoprts = myReoprts;
                frm.myReop = myReop;
                frm.sumiquantity = sumiquantity;
                frm.sumIsum = sumIsum;
                frm.SO_SOMain_Id = SO_SOMain_Id;
                frm.iLoginEx = iLoginEx;
                frm.rpt = rpt;
                this.Close();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误！" + ex.Message);
            }
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            cboReport.Text = iLoginEx.ReadUserProfileValue("SO311", "cboReport");
         
        }
       
    }
}
