using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTLoginEx;
using System.Data.OleDb;

namespace RSERP_SO311
{
    public partial class frmSoAddInfo : Form
    {
      
        /// <summary>
        /// //订单号
        /// </summary>
        public  string Csocode = "";
        /// <summary>
        /// //母件存货编码
        /// </summary>
        public  string Cinvcode = "";
        /// <summary>
        /// 行号
        /// </summary>
        public int iRows;
        /// <summary>
        /// /总的含税单价
        /// </summary>
       public double colitaxunitprice;
        ///// <summary>
        ///// //子件存货编码
        ///// </summary>
        //public string Cinvcodes = "";
        ///// <summary>
        ///// 子件存货大类编码
        ///// </summary>
        //public string cInvCCode = "";
        ///// <summary>
        ///// 子件存货名称
        ///// </summary>
        //public string CinvName = "";
        ///// <summary>
        ///// 子件规格型号
        ///// </summary>
        //public string Cinvstd = "";
        ///// <summary>
        ///// 子件单位
        ///// </summary>
        //public string CcomunitName = "";
        ///// <summary>
        ///// 使用数量
        ///// </summary>
        //public decimal BaseQtyND;
        /// <summary>
        /// 需子件总数量
        /// </summary>
        public double Ciquantity;
        /// <summary>
        /// //单价
        /// </summary>
        public decimal SiQuotedPrice;
        /// <summary>
        /// //母件数量
        /// </summary>
        public decimal Siquantity ;
        /// <summary>
        /// //合计
        /// </summary>
        public decimal SiSums ;
        ///// <summary>
        ///// 选项一
        ///// </summary>
        //public string COption1 = "";

        ///// <summary>
        ///// //总子金额
        ///// </summary>
        public decimal SiSumprice;

        public  UTLoginEx.LoginEx iLoginEx = new LoginEx();
        public List<SoInfo_1> lst = new List<SoInfo_1>();
       
        /// <summary>
        /// 母表体单标识
        /// </summary>
        public int isosid;
        /// <summary>
        /// 母表头单标识
        /// </summary>
        public int SO_SOMain_Id;
       
        
         /// <summary>
         /// 初始化
         /// </summary>

        public frmSoAddInfo()
        {
            
                InitializeComponent();
            

        }
        private void frmSoAddInfo_Load(object sender, EventArgs e)
        {
            this.Text += "  " + System.Windows.Forms.Application.ProductVersion;  

            SLbAccID.Text = iLoginEx.AccID();
            SLbAccName.Text = iLoginEx.AccName();
            SLbServer.Text = iLoginEx.DBServerHost();
            SLbYear.Text = iLoginEx.iYear();
            SLbUser.Text = iLoginEx.UserId() + "[" + iLoginEx.UserName() + "]";
            txtCinvcode.Text = Cinvcode;
            txtCsocode.Text = Csocode;
            lblnum.Text = Siquantity.ToString();
      
            LoadDataGridView();
          
         
        }


        #region 加载网格数据
        public void LoadDataGridView()
        {

            string sql = "select SId as 编号, Csocode as 订单号,Cinvcodes as 母件存货编码,Cinvcode as 子件存货编码,cInvCCode as 子件存货大类编码,CinvName as 子件存货名称,Cinvstd as 子件规格型号, CcomunitName as 子件单位,BaseQtyND as 使用数量,Ciquantity as 需子件总数量,SiQuotedPrice as 单价,SiSum as 金额  from zhrs_t_zzcSO_SOAddSeriesInfo where Csocode='" + Csocode + "' and Cinvcodes='" + Cinvcode + "' and isosid=" + isosid + " ";
            DataSet ds = new DataSet();
            OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
            conn.Open();
            OleDbCommand comm = new OleDbCommand(sql,conn);
            OleDbDataAdapter dat = new OleDbDataAdapter();
            dat.SelectCommand = comm;
            dat.Fill(ds, "sql");
            conn.Close();
            
            dgvAddinfo.DataSource = ds.Tables["sql"];
            dgvAddinfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvAddinfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAddinfo.Columns[0].Visible = false;
            FormatDGV(dgvAddinfo, 7, 11);
            dgvAddInfoHeaderText();
           
          
        }
       
        
        #endregion

     

        #region 格式化数值
        /// <summary>
        /// 格式化数值
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="coln"></param>
        /// <param name="colcount"></param>
        private void FormatDGV(DataGridView dgv, int coln, int colcount)
        {
            for (int i = coln; i <= colcount; i++)
            {
                if (i==8||i==9)
                {
                    dgv.Columns[i].DefaultCellStyle.Format = "#,###0.000";
                }
                else if (i==10)
                {
                    dgv.Columns[i].DefaultCellStyle.Format = "#,###0.0000";
                }
                else
                {
                    dgv.Columns[i].DefaultCellStyle.Format = "#,###0.00";
                }
                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }  
        #endregion

        #region 求剩余合计
        /// <summary>
        /// 求剩余合计
        /// </summary>
        private void dgvAddInfoHeaderText()
        {
            //dgvAddinfo.Columns["Csocode"].HeaderText = "订单号";
         

            OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
            conn.Open();
            string sql = "select * from zhrs_t_zzcSO_SOAddSeriesInfo where Csocode='" + Csocode + "' and Cinvcodes='" + Cinvcode + "' and isosid=" + isosid + " ";
            OleDbCommand comm = new OleDbCommand(sql,conn);
            OleDbDataReader dr = comm.ExecuteReader();
            SiSumprice = 0;
            while (dr.Read())
            {
                SiSumprice += Convert.ToDecimal(dr["SiQuotedPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["SiQuotedPrice"]) * Convert.ToDecimal(dr["BaseQtyND"]));
            }
            dr.Close();
            conn.Close();
            GC.Collect();
            lblisum.Text = Convert.ToDecimal(colitaxunitprice).ToString("####0.0000") + " - " + SiSumprice.ToString("####0.0000") + " = " + (Convert.ToDecimal(colitaxunitprice) - SiSumprice).ToString("####0.0000");
        }
        #endregion

        #region 删除事件
        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmidelete_Click(object sender, EventArgs e)
        {
            try
            {
                int sid = Convert.ToInt32(dgvAddinfo.Rows[dgvAddinfo.CurrentCell.RowIndex].Cells[0].Value);
                string sql = "delete from zhrs_t_zzcSO_SOAddSeriesInfo where Sid=" + sid + " ";
                OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                conn.Open();
                OleDbCommand comm = new OleDbCommand(sql, conn);
                DialogResult ret = MessageBox.Show("是否删除？", "删除套餐详细信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                GC.Collect();
                MessageBox.Show("frmSoaddinfo错误！" + ex.Message);
            }
        } 
        #endregion
      
        #region 计算器
        /// <summary>
        /// 计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        } 
        #endregion

        private void btnDISH_Click(object sender, EventArgs e)
        {
            frmSoInfo_1 frm = new frmSoInfo_1();
            frm.iLoginEx = iLoginEx;
            frm.Csocode = Csocode;
            frm.BCinvcode = Cinvcode;
            frm.colitaxunitprice = colitaxunitprice;
            frm.isosid = isosid;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                lst = frm.lst2;
                OleDbConnection con = new OleDbConnection(iLoginEx.ConnString());
                con.Open();
                string sql = "";
                OleDbCommand com = new OleDbCommand(sql, con);
                double agvP=0.00;//记录累加的单价
                double Num = 0.00;//记录累加数量（剩下配件或单价为零的存货）
                foreach (SoInfo_1 agvPrice in lst)
                {
                    agvP += agvPrice.Price * agvPrice.Number;//记录累加的单价
                    if (agvPrice.Price<=0.00)
                    {
                        Num += agvPrice.Number;//记录累加数量
                    }
                }
                double psums = agvP;
                agvP = colitaxunitprice - agvP;//总的含税单价-累加的单价 = 剩下配件或单价为零的存货
                agvP = agvP / Num;             //剩下配件或单价为零的存货平均分配给单价
                //if (agvP == 0.00)
                //{
                //    MessageBox.Show("配件单价不能为0,操作取消！\n请重新拆解！");
                //}
                //else
                //{
              
                    foreach (SoInfo_1 item in lst)
                    {
                        if (item.Price > 0.00)//有单价的添加数据
                        {
                            Ciquantity = item.Number * Convert.ToDouble(Siquantity);//子件总数量
                            decimal SiSumpri = Convert.ToDecimal(Ciquantity) * Convert.ToDecimal(item.Price);//子金额
                            sql = "insert into zhrs_t_zzcSO_SOAddSeriesInfo(Csocode,Cinvcodes,Cinvcode,CinvName,Cinvstd,CcomunitName,BaseQtyND,Ciquantity,SiQuotedPrice,SiSum,SAddDate,isosid,iRow,cInvCCode,SO_SOMain_Id,COption1,COption2)  \r\n";
                            sql += " values('" + item.Csocode + "','" + item.BCinvcode + "','" + item.cInvCode + "','" + item.cInvName + "','" + item.cinvstd + "','" + item.ccomunitName + "'," + item.Number + "," + Ciquantity + "," + item.Price + "," + SiSumpri + ",getdate()," + isosid + "," + iRows + ",'" + item.cInvCCode + "'," + SO_SOMain_Id + ",'1','" + iLoginEx.UserName() + "')  \r\n";
                            com.CommandText = sql;
                            com.ExecuteNonQuery();
                        }
                        else  //无单价，则平均分配单价，添加数据，既能保证报表那边的数据
                        {
                            Ciquantity = item.Number * Convert.ToDouble(Siquantity);//子件总数量
                            decimal SiSumpri = Convert.ToDecimal(Ciquantity) * Convert.ToDecimal(agvP.ToString("####0.000"));//子金额
                            sql = "insert into zhrs_t_zzcSO_SOAddSeriesInfo(Csocode,Cinvcodes,Cinvcode,CinvName,Cinvstd,CcomunitName,BaseQtyND,Ciquantity,SiQuotedPrice,SiSum,SAddDate,isosid,iRow,cInvCCode,SO_SOMain_Id,COption1,COption2)  \r\n";
                            sql += " values('" + item.Csocode + "','" + item.BCinvcode + "','" + item.cInvCode + "','" + item.cInvName + "','" + item.cinvstd + "','" + item.ccomunitName + "'," + item.Number + "," + Ciquantity + "," + agvP + "," + SiSumpri + ",getdate()," + isosid + "," + iRows + ",'" + item.cInvCCode + "'," + SO_SOMain_Id + ",'0','" + iLoginEx.UserName() + "')  \r\n";
                            com.CommandText = sql;
                            com.ExecuteNonQuery();
                        }
                    }
               
               // }
                con.Close();
                LoadDataGridView();
            }
           
        }
    }
}
