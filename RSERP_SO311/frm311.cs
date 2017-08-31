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
using CrystalDecisions.CrystalReports.Engine;

namespace RSERP_SO311
{
    public partial class frm311 : Form
    {

        DateTimePicker dtp = new DateTimePicker();  //这里实例化一个DateTimePicker控件  
        Rectangle _Rectangle;  


        private int AuthID = 29; //29：套装销售订单
        private UTLoginEx.LoginEx iLoginEx = new LoginEx();
    
        /// <summary>
        /// 增删查改变量
        /// </summary>
        private string AddRows = "";
        private string delRowa = "";
        private int FormWidth = 0, FormHeight = 0, tabPageWidth = 0, tabPageHeight = 0, dataGridViewWidth = 0, dataGridViewHeight = 0, dataGridViewWidth2 = 0, dataGridViewHeight2 = 0;
        List<SODetailsinfo> lst = new List<SODetailsinfo>();

        /// <summary>
        /// 订单号
        /// </summary>
        public string csocode = "";


        /// <summary>
        /// 销售类型编号
        /// </summary>
        public string cstcodeId = "";
        /// <summary>
        /// 部门编号
        /// </summary>
        public string cDepCodeId = "";
        /// <summary>
        /// 业务员编号
        /// </summary>
        public string cPersonCodeId = "";
        /// <summary>
        /// 客户编码
        /// </summary>
        public string cCusCodeId = "";
        /// <summary>
        /// 付款条件编码
        /// </summary>
        public string cpaycodeId = "";
        /// <summary>
        /// 汇率
        /// </summary>
        public double iexchrate;
        /// <summary>
        /// 客户名称
        /// </summary>
        public string cCusAbbName = "";
        /// <summary>
        /// 联系人
        /// </summary>
        public string cCusDefine8 = "";
        /// <summary>
        /// 获取最大的订单号
        /// </summary>
        public int Maxnumber;
        /// <summary>
        /// 预发货日期
        /// </summary>
        public string dpredatebt = "";
        /// <summary>
        /// 预完工日期
        /// </summary>
        public string dPreMoDateBT = "";
        /// <summary>
        /// 制单时间
        /// </summary>
        public string dcreatesystime = "";
        /// <summary>
        /// 修改当前日期
        /// </summary>
        public string dmoddate;




        /// <summary>
        /// 存货编码
        /// </summary>
        public string cInvCode = "";
        /// <summary>
        /// 型号规格
        /// </summary>
        public string cInvStd = "";
        /// <summary>
        /// 数量
        /// </summary>
        public double   iquantity ;
        /// <summary>
        /// 含税单价
        /// </summary>
        public double itaxunitprice ;
        /// <summary>
        /// 价税合计
        /// </summary>
        public double isum ;
        /// <summary>
        /// 税额
        /// </summary>
        public double itax ;
        /// <summary>
        /// 备注内容
        /// </summary>
        public string ctext ;
        /// <summary>
        /// 存货名称
        /// </summary>
        public string cInvName = "";
        /// <summary>
        /// 制式/开机界面自定义项值
        /// </summary>
        public string Cvalue = "";
        /// <summary>
        /// 显示语言
        /// </summary>
        public string Cvalue11 = "";
        /// <summary>
        /// LOGO
        /// </summary>
        public string Cvalue12 = "";
        /// <summary>
        /// 软件信息
        /// </summary>
        public string useQty = "";
        /// <summary>
        /// 原币无税单价 
        /// </summary>
        public double iUnitPrice ;
        /// <summary>
        /// 税率
        /// </summary>
        public double iTaxRate;
        /// <summary>
        /// 原币无税金额\合计
        /// </summary>
        public double iMoney;
        /// <summary>
        /// 主计量单位名称
        /// </summary>
        public string cComUnitName="";
        /// <summary>
        /// So_SOMain表的id号
        /// </summary>
        public int SO_SOMain_Id;
        /// <summary>
        /// SO_SODetails表的isosid号
        /// </summary>
        public int SO_SODetails_isosid;
        /// <summary>
        /// 释放日期
        /// </summary>
        public string dreleasedate = "";
        /// <summary>
        /// 行号
        /// </summary>
        public int iRows;



        public frm311(string[] args)
        {
            try
            {
                InitializeComponent();
                txtiTaxRate.Leave += new EventHandler(txtiTaxRate_Leave);  //失去焦点事件。
                OLEDBHelper.iLoginEx = iLoginEx;

                tab2_dataGridView1.Controls.Add(dtp);  //把时间控件加入DataGridView  
                dtp.Visible = false;  //先不让它显示  
                dtp.Format = DateTimePickerFormat.Custom;  //设置日期格式为2010-08-05  
                dtp.TextChanged += new EventHandler(dtp_TextChange); //为时间控件加入事件dtp_TextChange  



                iLoginEx.Initialize(args, AuthID);//必须先初始化LoginEx
            }
            catch (Exception ex)
            {
                frmMessege frmmsg = new frmMessege(ex.ToString(), "frm311()");
                frmmsg.ShowDialog(this);
            }
        }

        private void frm311_Resize(object sender, EventArgs e)
        {
            IniFile.Ini ini = new IniFile.Ini(System.Windows.Forms.Application.StartupPath.ToString() + "\\utconfig.ini");
            ini.Writue("Window", "AutoAdaptive2", "");
            if (ini.ReadValue("Window", "AutoAdaptive") != "N")
            {
                tabControl1.Width = tabPageWidth + (this.Width - FormWidth);
                tabControl1.Height = tabPageHeight + (this.Height - FormHeight);

                dgvSaleOrderList.Width = dataGridViewWidth + (this.Width - FormWidth);
                dgvSaleOrderList.Height = dataGridViewHeight + (this.Height - FormHeight);

                tab2_dataGridView1.Width = dataGridViewWidth2 + (this.Width - FormWidth);
                tab2_dataGridView1.Height = dataGridViewHeight2 + (this.Height - FormHeight);
            }
        }
        #region /*************时间控件选择时间时****************/
        /*************时间控件选择时间时****************/
        /// <summary>
        ///   /*************时间控件选择时间时****************/
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtp_TextChange(object sender, EventArgs e)
        {
            tab2_dataGridView1.CurrentCell.Value = dtp.Text.ToString();  //时间控件选择时间时，就把时间赋给所在的单元格  
        }   
        #endregion

        #region 失去焦点事件
        /// <summary>
        /// 失去焦点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtiTaxRate_Leave(object sender, EventArgs e)
        {
            if (txtiTaxRate.ReadOnly)
            {
                return;
            }
            DialogResult ret = MessageBox.Show("是否更新表体税率？", "销售管理", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (AddRows == "修改")
            {
                if (ret == DialogResult.Yes)
                {
                    int RowCounts = tab2_dataGridView1.RowCount;
                    if (RowCounts > 0)
                    {
                        for (int i = 0; i < RowCounts; i++)
                        {
                            tab2_dataGridView1.Rows[i].Cells["coliTaxRate"].Value = txtiTaxRate.Text;
                        }
                    }
                }
            }
            else if (AddRows == "添加")
            {
                if (ret == DialogResult.Yes)
                {
                    int RowCounts = tab2_dataGridView1.RowCount;
                    if (RowCounts > 0)
                    {
                        for (int i = 0; i < RowCounts; i++)
                        {
                            tab2_dataGridView1.Rows[i].Cells["coliTaxRate"].Value = txtiTaxRate.Text;
                        }
                    }
                }
            }
        }
       
        #endregion

        #region 添加事件
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolAdd_Click(object sender, EventArgs e)
        {
            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.AddNew))
            {
                iLoginEx.FormEditState(UTLoginEx.LoginEx.FormState.Edit, this, tabControl1, "tabPage2", tab2_dataGridView1);
                tab2_dDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                tab2_dataGridView1.AllowUserToAddRows = true;
                tab2_dataGridView1.DataSource = null;
                ClearText(this);

                AddRows = "添加";
                tab2_toolSave.Enabled = true;

                tab2_toolAdd.Enabled = false;
                tab2_toolDelete.Enabled = false;
                tab2_toolQuery.Enabled = false;
                tsbtnRefurbish.Enabled = false;
                tab2_toolEdit.Enabled = false;
                tsmiRowClose.Enabled = false;

                tab2_toolRowAdd.Enabled = false;
                tab2_toolRowDelete.Enabled = false;
                tab2_toolAudit.Enabled = false;
                tab2_toolNoAudit.Enabled = false;
                tab2_toolClose.Enabled = false;
                tsbEsc.Enabled = true;
                tab2_toolPrint.Enabled = false;

            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
        #endregion

        #region 重置文本框
        /// <summary>
        /// 重置文本框
        /// </summary>
        /// <param name="ctrlTop"></param>
        private void ClearText(Control ctrlTop)
        {
            if (ctrlTop.GetType() == typeof(TextBox))
            {
                ctrlTop.Text = "";
                txtiTaxRate.ReadOnly = false;
                txtiTaxRate.Text = "0.00";
                tab2_cSTCode.ReadOnly = false;
                tab2_cSOCode.ReadOnly = false;
                tab2_cexch_name.ReadOnly = false;
                tab2_dDate.Enabled = true;
                tab2_cDepCode.ReadOnly = false;
                tab2_cPersonCode.ReadOnly = false;
                tab2_cCusCode.ReadOnly = false;
                txtPayCondition.ReadOnly = false;
                tab2_iExchRate.ReadOnly = false;
                tab2_cMemo.ReadOnly = false;
            }
            else
            {
                foreach (Control ctrl in ctrlTop.Controls)
                {
                    ClearText(ctrl); //循环调用  
                }
            }
        } 
        #endregion

        #region 单击修改事件
        /// <summary>
        /// 单击修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolEdit_Click(object sender, EventArgs e)
        {
            //bool b1 = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Edit);
            //bool b2 = iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Edit);
            //MessageBox.Show(b1.ToString() + "||" + b2.ToString());

            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Edit) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Edit))
            {
                iLoginEx.FormEditState(UTLoginEx.LoginEx.FormState.Edit, this, tabControl1, "tabPage2", tab2_dataGridView1);
                tab2_dataGridView1.AllowUserToAddRows = true;
                //  tab2_dataGridView1.SelectionMode = SelectionMode.One;
                txtiTaxRate.ReadOnly = false;
                txtiTaxRate.ReadOnly = false;
                tab2_cSTCode.ReadOnly = false;
                tab2_cSOCode.ReadOnly = false;
                tab2_cexch_name.ReadOnly = false;
                tab2_dDate.Enabled = true;
                tab2_cDepCode.ReadOnly = false;
                tab2_cPersonCode.ReadOnly = false;
                tab2_cCusCode.ReadOnly = false;
                txtPayCondition.ReadOnly = false;
                tab2_iExchRate.ReadOnly = false;
                tab2_cMemo.ReadOnly = false;
                //(tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colbusecusbom"] as DataGridViewComboBoxCell).ReadOnly = true;


                tab2_toolAdd.Enabled = false;
                tab2_toolDelete.Enabled = false;
                tab2_toolQuery.Enabled = false;
                tsbtnRefurbish.Enabled = false;
                tab2_toolExit.Enabled = false;
                tab2_toolClose.Enabled = false;
                tab2_toolAudit.Enabled = false;
                tsmiRowClose.Enabled = false;

                tab2_toolSave.Enabled = true;
                tab2_toolRowAdd.Enabled = true;
                tab2_toolRowDelete.Enabled = true;
                tsbEsc.Enabled = true;
                tab2_toolPrint.Enabled = false;

                txtcmodifier.Text = iLoginEx.UserName();
                txtdmoddate.Text = DateTime.Now.ToString("yyyy-MM-dd");

                AddRows = "修改";
                OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                string upsql = "";
                try
                {
                    conn.Open();

                     OleDbCommand comm = new OleDbCommand(upsql, conn);

                     #region 创建临时表
                     upsql = "  if object_id('tempdb..so311_sale" + iLoginEx.GetMacAddress().Replace(":", "") + "')is not null  \r\n";
                     upsql += " drop table tempdb..so311_sale" + iLoginEx.GetMacAddress().Replace(":", "") + "    \r\n";
                     comm.CommandText = upsql;
                     comm.ExecuteNonQuery();
                     upsql = "create table tempdb..so311_sale" + iLoginEx.GetMacAddress().Replace(":", "") + " \r\n";
                     upsql += " (  \r\n";
                     upsql += " autoid varchar(300)null,id varchar(300)null,cinvcode varchar(300)null,bservice varchar(300)null,  \r\n";
                     upsql += " cinvname varchar(300)null,cinvaddcode varchar(300)null,body_outid varchar(300)null,cinvstd varchar(300)null,  \r\n";
                     upsql += " cunitid varchar(300)null,cinvm_unit varchar(300)null,igrouptype varchar(300)null,cgroupcode varchar(300)null,  \r\n";
                     upsql += " cinva_unit varchar(300)null,cinvdefine1 varchar(300)null,cinvdefine2 varchar(300)null,cinvdefine3 varchar(300)null,cinvdefine4 varchar(300)null,  \r\n";
                     upsql += " cinvdefine5 varchar(300)null,cinvdefine6 varchar(300)null,cinvdefine7 varchar(300)null,cinvdefine8 varchar(300)null,  \r\n";
                     upsql += " cinvdefine9 varchar(300)null,cinvdefine10 varchar(300)null,cinvdefine11 varchar(300)null,cinvdefine12 varchar(300)null,  \r\n";
                     upsql += " cinvdefine13 varchar(300)null,cinvdefine14 varchar(300)null,cinvdefine15 varchar(300)null,cinvdefine16 varchar(300)null,  \r\n";
                     upsql += " iquantity varchar(300)null,inum varchar(300)null,iquotedprice varchar(300)null,iunitprice varchar(300)null,iinvsprice varchar(300)null,iinvncost varchar(300)null,  \r\n";
                     upsql += " imoney varchar(300)null,itax varchar(300)null,isum varchar(300)null,  \r\n";
                     upsql += " inatunitprice varchar(300)null,inatmoney varchar(300)null,inattax varchar(300)null,inatsum varchar(300)null,inatdiscount varchar(300)null,idiscount varchar(300)null,  \r\n";
                     upsql += " ifhquantity varchar(300)null,ifhnum varchar(300)null,  \r\n";
                     upsql += " ifhmoney varchar(300)null,ikpquantity varchar(300)null,fsalecost varchar(300)null,fsaleprice varchar(300)null,iexchsum varchar(300)null,ikpnum varchar(300)null,ikpmoney varchar(300)null,  \r\n";
                     upsql += " dpredate varchar(300)null,cmemo varchar(300)null,cfree1 varchar(300)null,  \r\n";
                     upsql += " cfree2 varchar(300)null,iinvexchrate varchar(300)null,  \r\n";
                     upsql += " iinvlscost varchar(300)null,itaxunitprice varchar(300)null,  \r\n";
                     upsql += " bfree1 varchar(300)null,bfree2 varchar(300)null,bfree3 varchar(300)null,bfree4 varchar(300)null,bfree5 varchar(300)null,bfree6 varchar(300)null,  \r\n";
                     upsql += " bfree7 varchar(300)null,bfree8 varchar(300)null,bfree9 varchar(300)null,bfree10 varchar(300)null,bsalepricefree1 varchar(300)null,  \r\n";
                     upsql += " bsalepricefree2 varchar(300)null,bsalepricefree3 varchar(300)null,bsalepricefree4 varchar(300)null,  \r\n";
                     upsql += " bsalepricefree5 varchar(300)null,bsalepricefree6 varchar(300)null,bsalepricefree7 varchar(300)null,  \r\n";
                     upsql += " bsalepricefree8 varchar(300)null,bsalepricefree9 varchar(300)null,bsalepricefree10 varchar(300)null,binvtype varchar(300)null,itaxrate varchar(300)null,  \r\n";
                     upsql += " kl varchar(300)null,kl2 varchar(300)null,cdefine22 varchar(300)null,cdefine23 varchar(300)null,  \r\n";
                     upsql += " cdefine24 varchar(300)null,cdefine25 varchar(300)null,cdefine26 varchar(300)null,cdefine27 varchar(300)null,cdefine28 varchar(300)null,  \r\n";
                     upsql += " cdefine29 varchar(300)null,cdefine30 varchar(300)null,cdefine31 varchar(300)null,cdefine32 varchar(300)null,cdefine33 varchar(300)null,  \r\n";
                     upsql += " cdefine34 varchar(300)null,cdefine35 varchar(300)null,cdefine36 varchar(300)null,cdefine37 varchar(300)null,isosid varchar(300)null,citemcode varchar(300)null,citem_class varchar(300)null,  \r\n";
                     upsql += " dkl1 varchar(300)null,dkl2 varchar(300)null,citemname varchar(300)null,citem_cname varchar(300)null,cfree3 varchar(300)null,  \r\n";
                     upsql += " cfree4 varchar(300)null,cfree5 varchar(300)null,cfree6 varchar(300)null,cfree7 varchar(300)null,cfree8 varchar(300)null,  \r\n";
                     upsql += " cfree9 varchar(300)null,cfree10 varchar(300)null,cinvauthid varchar(300)null,cscloser varchar(300)null,irowno int null,imoquantity varchar(300)null,  \r\n";
                     upsql += " icusbomid varchar(300)null,cconfigstaus varchar(300)null,ccomunitcode varchar(300)null,  \r\n";
                     upsql += " ippartseqid varchar(300)null,ippartid varchar(300)null,ippartqty varchar(300)null,dpremodate varchar(300)null,  \r\n";
                     upsql += " iquoid varchar(300)null,cquocode varchar(300)null,cbarcode varchar(300)null,  \r\n";
                     upsql += " ccontractid varchar(300)null,ccontracttagcode varchar(300)null,  \r\n";
                     upsql += " ccontractrowguid varchar(300)null,batomodel varchar(300)null,bptomodel varchar(300)null,ccusinvcode varchar(300)null,  \r\n";
                     upsql += " ccusinvname varchar(300)null,fcuminprice varchar(300)null,borderbom varchar(300)null,  \r\n";
                     upsql += " borderbomover varchar(300)null,idemandtype varchar(300)null,cdemandcode varchar(300)null,  \r\n";
                     upsql += " cdemandmemo varchar(300)null,iprekeepquantity varchar(300)null,iprekeeptotquantity varchar(300)null,iprekeeptotnum varchar(300)null,  \r\n";
                     upsql += " busecusbom varchar(300)null,iprekeepnum varchar(300)null,binvmodel varchar(300)null,csrpolicy varchar(300)null,  \r\n";
                     upsql += " fpurquan varchar(300)null,iadvancedate varchar(300)null,  \r\n";
                     upsql += " dreleasedate varchar(300)null,fimquantity varchar(300)null,  \r\n";
                     upsql += " fomquantity varchar(300)null,bproxyforeign varchar(300)null,ballpurchase varchar(300)null,bspercialorder varchar(300)null,  \r\n";
                     upsql += " binvbatch varchar(300)null,btrack varchar(300)null,dedate varchar(300)null,  \r\n";
                     upsql += " bproductbill varchar(300)null,iaoid varchar(300)null,cpreordercode varchar(300)null,  \r\n";
                     upsql += " dbclosedate varchar(300)null,dbclosesystime varchar(300)null,iinvid varchar(300)null,finquantity varchar(300)null,foutquantity varchar(300)null,fretquantity varchar(300)null,  \r\n";
                     upsql += " fretnum varchar(300)null,iimid varchar(300)null,ccorvouchtype varchar(300)null,ccorvouchtypename varchar(300)null,icorrowno varchar(300)null,  \r\n";
                     upsql += " )  \r\n";
                     comm.CommandText = upsql;
                     comm.ExecuteNonQuery(); 
                     #endregion

                     upsql = "insert into tempdb..so311_sale" + iLoginEx.GetMacAddress().Replace(":", "") + " select * from SaleOrderSQ where id =" + SO_SOMain_Id + " \r\n";
                    comm.CommandText = upsql;
                    comm.ExecuteNonQuery();


                    tab2_toolEdit.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误！添加临时表" + ex.Message);
                }
                finally
                {
                    conn.Close();
                    GC.Collect();
                }
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
        #endregion

        #region 放弃当前编辑的单据  ESC
        /// <summary>
        /// 放弃当前编辑的单据  ESC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm311_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtiTaxRate.ReadOnly)
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                tsbEscClose();
            }
        }
        /// <summary>
        /// 放弃当前编辑的单据  ESC
        /// </summary>
        private void tsbEscClose()
        {
            DialogResult ret = MessageBox.Show("是否放弃对当前单据的编辑？", "销售管理", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (AddRows == "修改")
            {
                if (ret == DialogResult.Yes)
                {
                    tab2_toolSave.Enabled = false;
                    tab2_toolRowAdd.Enabled = false;
                    tab2_toolRowDelete.Enabled = false;

                    tab2_toolAdd.Enabled = true;
                    tab2_toolDelete.Enabled = true;
                    tab2_toolQuery.Enabled = true;
                    tsbtnRefurbish.Enabled = true;
                    tab2_toolExit.Enabled = true;
                    tsbEsc.Enabled = false;
                    tab2_toolClose.Enabled = true;
                    int upRCounts = tab2_dataGridView1.RowCount;
                    List<SODetailsinfo> lstkpso = new List<SODetailsinfo>();
                    for (int i = 0; i < upRCounts; i++)
                    {
                        SODetailsinfo kpso = new SODetailsinfo();
                        kpso.SO_SOMain_Id = Convert.ToInt32(tab2_dataGridView1.Rows[i].Cells["colSO_SOMain_Id"].Value);
                        kpso.SO_SODetails_isosid = Convert.ToInt32(tab2_dataGridView1.Rows[i].Cells["coliSOsID"].Value);
                        lstkpso.Add(kpso);
                    }
                    int kpiRowscount = 1;

                    try
                    {
                        OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                        conn.Open();
                        string readsql = "";
                        OleDbCommand comm = new OleDbCommand(readsql, conn);
                        foreach (SODetailsinfo kpitem in lstkpso)
                        {
                            readsql = " select count(*) from SO_SODetails where id =" + kpitem.SO_SOMain_Id + " and isosid=" + kpitem.SO_SODetails_isosid + " ";
                            comm.CommandText = readsql;
                            int kpicount = Convert.ToInt32(comm.ExecuteScalar());
                            switch (kpicount)
                            {
                                case 0: readsql = "update SO_SODetails set iRowNo=" + kpiRowscount + " where isosid=" + kpitem.SO_SODetails_isosid + " and Id=" + kpitem.SO_SOMain_Id + "   \r\n";
                                    break;
                                case 1: readsql = "update SO_SODetails set iRowNo=" + kpiRowscount + " where isosid=" + kpitem.SO_SODetails_isosid + " and Id=" + kpitem.SO_SOMain_Id + "   \r\n";
                                    break;
                            }
                            comm.CommandText = readsql;
                            if (0 == comm.ExecuteNonQuery())
                            {
                            }
                            else
                            {
                                kpiRowscount++;
                            }
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误！编辑的单据  ESC" + ex.Message);
                    }
                    finally
                    {
                        GC.Collect();
                    }
                    tsbtnRefurbish_Click(null, null);
                }
            }
            else if (AddRows == "添加")
            {
                if (ret == DialogResult.Yes)
                {
                    AddRows = "";

                    tab2_toolSave.Enabled = false;
                    tab2_toolRowAdd.Enabled = false;
                    tab2_toolRowDelete.Enabled = false;

                    tab2_toolAdd.Enabled = true;
                    tab2_toolDelete.Enabled = true;
                    tab2_toolQuery.Enabled = true;
                    tsbtnRefurbish.Enabled = true;
                    tab2_toolExit.Enabled = true;
                    tsbEsc.Enabled = false;

                    tsbtnRefurbish_Click(null, null);
                }
            }
        }
        #endregion

        #region 保存事件
        /// <summary>
        /// 保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolSave_Click(object sender, EventArgs e)
        {
            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Save))
            {
                if (tab2_dataGridView1.Rows.Count > 0)
                {
                    tab2_dataGridView1.CurrentCell = tab2_dataGridView1.Rows[0].Cells[1];
                }

                try
                {
                    int n = 0;
                    #region 添加处理
                    if (AddRows == "添加")
                    {
                        if (tab2_dataGridView1.AllowUserToAddRows == true)
                        {

                            int RCounts = tab2_dataGridView1.RowCount;
                              int RowsC = RCounts - 1;
                           
                          
                            if (CheckputIn_SO_SOMain())
                            {
                                
                                if (RCounts == 1)
                                {
                                    MessageBox.Show("请将表体信息填写完整！");
                                    if (!String.IsNullOrEmpty(tab2_dataGridView1.Rows[0].Cells["colcInvCode"].Value == null ? "" : tab2_dataGridView1.Rows[0].Cells["colcInvCode"].Value.ToString()))
                                    {
                                        CheckputIn_SO_SODetails(RCounts);
                                    }
                                    return;
                                }

                               
                                    if (!String.IsNullOrEmpty(tab2_dataGridView1.Rows[RowsC].Cells["colcInvCode"].Value == null ? "" : tab2_dataGridView1.Rows[RowsC].Cells["colcInvCode"].Value.ToString()))
                                    {
                                        CheckputIn_SO_SODetails(RCounts);
                                        return;
                                    }
                               
                                
                                if (CheckputIn_SO_SODetails(RowsC))
                                {

                                    #region 获取编号
                                    //try
                                    //{
                                        //OleDbConnection sqlconn = new OleDbConnection(iLoginEx.ConnString());
                                        //sqlconn.Open();
                                        //OleDbCommand cmd = new OleDbCommand();\
                                        OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());

                                        if (conn.State == ConnectionState.Open)
                                        {
                                            conn.Close();
                                        }
                                        conn.Open();
                                        OleDbCommand comm = new OleDbCommand();
                                        OleDbTransaction myTran;
                                        string sql = "";
                                        //创建一个事务
                                        myTran = conn.BeginTransaction();
                                        comm.Connection = conn;
                                        comm.CommandText = "sp_getID";
                                        comm.CommandType = CommandType.StoredProcedure;
                                        // 创建参数  
                                        IDataParameter[] param = {  
                                         new OleDbParameter("@RemoteId", OleDbType.LongVarChar,2) ,  
                                         new OleDbParameter("@cAcc_Id",OleDbType.LongVarChar,3),
                                         new OleDbParameter("@cVouchType",OleDbType.LongVarChar,50),
                                         new OleDbParameter("@iAmount",OleDbType.Integer,10),
                                         new OleDbParameter("@iFatherId",OleDbType.Integer,10),
                                         new OleDbParameter("@iChildId",OleDbType.Integer,10),
                                         };
                                        // 设置参数类型  
                                        param[0].Value = "00";
                                        param[1].Value = iLoginEx.AccID().ToString();
                                        param[2].Value = "Somain";
                                        param[3].Value = RCounts - 1;
                                        param[4].Direction = ParameterDirection.Output; // 设置为输出参数  
                                        param[5].Direction = ParameterDirection.Output;  // 设置为输出参数  
                                        // 添加参数  
                                        comm.Parameters.Add(param[0]);
                                        comm.Parameters.Add(param[1]);
                                        comm.Parameters.Add(param[2]);
                                        comm.Parameters.Add(param[3]);
                                        comm.Parameters.Add(param[4]);
                                        comm.Parameters.Add(param[5]);
                                        // 执行存储过程并返回影响的行数  
                                        comm.Connection = conn;
                                        comm.Transaction = myTran;
                                        comm.ExecuteNonQuery().ToString();
                                      //  sqlconn.Close();
                                        // 显示影响的行数和输出参数  
                                        SO_SOMain_Id = Convert.ToInt32(param[4].Value);
                                        SO_SODetails_isosid = Convert.ToInt32(param[5].Value);
                                       
                                    //}
                                    //catch (Exception ex)
                                    //{
                                    //    MessageBox.Show("错误！" + ex.Message);
                                    //}
                                    //finally
                                    //{

                                    //    GC.Collect();
                                    //}
                                    #endregion

                                    #region 添加表头数据到SO_SOMain表中
                           
                                    //OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());

                                    //if (conn.State == ConnectionState.Open)
                                    //{
                                    //    conn.Close();
                                    //}
                                    //conn.Open();
                                    //OleDbCommand comm = new OleDbCommand();
                                    //OleDbTransaction myTran;
                                    //string sql = "";
                                    //    //创建一个事务
                                    //    myTran = conn.BeginTransaction();

                                        sql = " select isnull(cNumber,0) as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL";
                                        comm = new OleDbCommand(sql, conn);
                                        comm.Connection = conn;
                                        comm.Transaction = myTran;
                                        OleDbDataReader dr = comm.ExecuteReader();
                                        if (dr.Read())
                                        {
                                            if (Maxnumber==Convert.ToInt32(dr["Maxnumber"]))
                                            {
                                                Maxnumber = Convert.ToInt32(dr["Maxnumber"]) + 1;
                                                tab2_cSOCode.Text = cstcodeId + DateTime.Now.ToString("yyyyMM") + "0" + string.Format("{0:d5}", Maxnumber);
                                            }
                                        }
                                        dr.Close();

                                        try
                                        {
                                          
                                            //useQty = tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells[9].Value.ToString();
                                            string selectSQL = "";
                                            selectSQL += " insert into   \r\n";
                                            selectSQL += " SO_SOMain(  \r\n";
                                            selectSQL += " id,ivtid,cchanger,cbustype,ccrechpname,cstcode,outid,ddate,csocode,ccuscode,cdepcode,cpersoncode,csccode,ccusoaddress,  \r\n";
                                            selectSQL += " cpaycode,cexch_name,iexchrate,itaxrate,imoney,cmemo,istatus,cmaker,cverifier,ccloser,  \r\n";
                                            selectSQL += " cdefine1,cdefine2,cdefine3,cdefine5,cdefine7,cdefine8,cdefine9,cdefine10,cdefine11,cdefine12,cdefine13,cdefine14,cdefine15,cdefine16,  \r\n";
                                            selectSQL += " dpredatebt,dpremodatebt,bdisflag,clocker,ccusname,breturnflag,ccusperson,coppcode,cmodifier,caddcode,  \r\n";
                                            selectSQL += " iflowid,cgatheringplan,iverifystate,ireturncount,icreditstate,iswfcontrolled,cchangeverifier,bcashsale,cgathingcode)   \r\n";
                                            selectSQL += " Values   \r\n";
                                            selectSQL += " ('" + SO_SOMain_Id + "','95',Null,'普通销售',Null,'" + cstcodeId + "',Null,'" + tab2_dDate.Text + "','" + tab2_cSOCode.Text + "','" + cCusCodeId + "','" + cDepCodeId + "','" + cPersonCodeId + "',Null,Null,'" + cpaycodeId + "','" + tab2_cexch_name.Text + "',convert(money,'" + tab2_iExchRate.Text + "',2),'" + txtiTaxRate.Text + "',\r\n";
                                            selectSQL += " Null,'" + tab2_cMemo.Text + "',Null,'" + iLoginEx.UserName() + "',  \r\n";
                                            selectSQL += " Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'" + tab2_dDate.Text + "','" + tab2_dDate.Text + "',0,Null,'" + cCusAbbName + "',0,'" + cCusDefine8 + "',  \r\n";
                                            selectSQL += " Null,Null,Null,Null,Null,0,Null,Null,0,Null,0,Null)  \r\n";
                                            comm = new OleDbCommand(selectSQL, conn);
                                            comm.Connection = conn;
                                            comm.Transaction = myTran;
                                            comm.ExecuteNonQuery();
                                    #endregion

                                            #region 修改VoucherHistory表的订单号的数据

                                          

                                            sql = "update VoucherHistory set cNumber='" + Maxnumber.ToString() + "' Where  CardNumber='17' and cContent is NULL";
                                            comm = new OleDbCommand(sql, conn);
                                            comm.Connection = conn;
                                            comm.Transaction = myTran;
                                            comm.ExecuteNonQuery();

                                            #endregion


                                            #region 将网格的行数据一条一条添加到集合
                                            if (tab2_dataGridView1.Rows.Count > 1)
                                            {
                                                int RCou = RCounts - 1;
                                                lst.Clear();
                                                for (int i = 0; i < RCounts - 1; i++)
                                                {
                                                    SODetailsinfo so = new SODetailsinfo();
                                                    so.cInvCode = tab2_dataGridView1.Rows[i].Cells[0].Value.ToString();
                                                    so.cInvName = tab2_dataGridView1.Rows[i].Cells[1].Value.ToString();
                                                    so.cInvStd = tab2_dataGridView1.Rows[i].Cells[2].Value.ToString();
                                                    so.cComUnitName = tab2_dataGridView1.Rows[i].Cells[3].Value.ToString();
                                                    if (String.IsNullOrEmpty(tab2_dataGridView1.Rows[i].Cells["coliquantity"].Value.ToString()))
                                                    {
                                                        MessageBox.Show("请输入大于0的数量！");
                                                        tab2_dataGridView1.Rows[i].Cells["coliquantity"].Selected = true;
                                                        tab2_dataGridView1.CurrentCell = tab2_dataGridView1.Rows[i].Cells["coliquantity"];
                                                        tab2_dataGridView1.BeginEdit(true);//设置焦点
                                                        return;
                                                    }
                                                    so.iquantity = tab2_dataGridView1.Rows[i].Cells["coliquantity"].Value == null ? 0 : Convert.ToDouble(tab2_dataGridView1.Rows[i].Cells["coliquantity"].Value);
                                                    so.itaxunitprice = Convert.ToDouble(tab2_dataGridView1.Rows[i].Cells[5].Value);
                                                    so.iTaxRate = Convert.ToDouble(tab2_dataGridView1.Rows[i].Cells[6].Value);
                                                    so.isum = so.iquantity * so.itaxunitprice; // Convert.ToDouble(tab2_dataGridView1.Rows[i].Cells[7].Value);
                                                    so.useQty = tab2_dataGridView1.Rows[i].Cells[9].Value.ToString();
                                                    so.Cvalue = tab2_dataGridView1.Rows[i].Cells[10].Value.ToString();
                                                    so.Cvalue11 = tab2_dataGridView1.Rows[i].Cells["colCvalue11"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["colCvalue11"].Value.ToString();
                                                    so.Cvalue12 = tab2_dataGridView1.Rows[i].Cells["colCvalue12"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["colCvalue12"].Value.ToString();
                                                    so.ctext = tab2_dataGridView1.Rows[i].Cells["colctext"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["colctext"].Value.ToString();
                                                    so.dpremodate = tab2_dataGridView1.Rows[i].Cells["coldpremodate"].Value.ToString();
                                                    so.dpredate = tab2_dataGridView1.Rows[i].Cells["coldpredate"].Value.ToString();
                                                    //原币
                                                    so.iUnitPrice = so.itaxunitprice * (1.00 - so.iTaxRate * 0.01);
                                                    so.iMoney = so.iUnitPrice * so.iquantity;
                                                    so.itax = so.isum - so.iMoney;

                                                    //本币
                                                    so.inatunitprice = so.iUnitPrice * Convert.ToDouble(tab2_iExchRate.Text);
                                                    so.inatmoney = so.inatunitprice * so.iquantity;
                                                    so.inatitaxunitprice = so.inatunitprice / (1.00 - so.iTaxRate * 0.01);
                                                    so.inatsum = so.inatitaxunitprice * so.iquantity;
                                                    so.inattax = so.inatsum - so.inatmoney;

                                                    so.borderbom = (tab2_dataGridView1.Rows[i].Cells["colborderbom"] as DataGridViewComboBoxCell).Value.ToString();
                                                    switch (so.borderbom)
                                                    {
                                                        case "否": so.borderbom = "0";
                                                            break;
                                                        case "是": so.borderbom = "1";
                                                            break;
                                                    }
                                                    so.busecusbom = (tab2_dataGridView1.Rows[i].Cells["colbusecusbom"] as DataGridViewComboBoxCell).Value.ToString();
                                                    switch (so.busecusbom)
                                                    {
                                                        case "否": so.busecusbom = "0";
                                                            break;
                                                        case "是": so.busecusbom = "1";
                                                            break;
                                                    }
                                                    so.idemandtype = tab2_dataGridView1.Rows[i].Cells["colidemandtype"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["colidemandtype"].Value.ToString();
                                                    if ("销售订单行号" == so.idemandtype)
                                                    {
                                                        so.idemandtype = "1";
                                                    }

                                                    so.SO_SOMain_Id = Convert.ToInt32(SO_SOMain_Id);
                                                    if (RCounts - 1 != 1)
                                                    {
                                                        so.iRowNo = RCou;
                                                        RCou = RCou - 1;
                                                        so.SO_SODetails_isosid = SO_SODetails_isosid;
                                                        SO_SODetails_isosid = SO_SODetails_isosid - 1;
                                                    }
                                                    else
                                                    {
                                                        so.iRowNo = RCounts - 1;
                                                        so.SO_SODetails_isosid = SO_SODetails_isosid;
                                                    }
                                                    lst.Add(so);
                                                }
                                            }
                                            #endregion

                                            #region 单个或批量添加表体dataGirdView行的数据到SO_SODetails表
                                            foreach (SODetailsinfo s in lst)
                                            {
                                                selectSQL = "insert into SO_SODetails(  \r\n";
                                                selectSQL += " csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,  \r\n";
                                                selectSQL += " inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,  \r\n";
                                                selectSQL += " cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,  \r\n";
                                                selectSQL += " cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,  \r\n";
                                                selectSQL += " fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,  \r\n";
                                                selectSQL += " ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,  \r\n";
                                                selectSQL += " iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid)   \r\n";
                                                selectSQL += " Values   \r\n";
                                                selectSQL += "('" + tab2_cSOCode.Text + "','" + s.cInvCode + "','" + s.dpredate + "','" + s.iquantity + "',Null,0,'" + s.iUnitPrice + "','" + s.itaxunitprice + "','" + s.iMoney + "', \r\n";
                                                selectSQL += " '" + s.itax + "','" + s.isum + "',0,'" + s.inatunitprice + "','" + s.inatmoney + "','" + s.inattax + "','" + s.inatsum + "',0,Null,\r\n";
                                                selectSQL += " Null,Null,Null,Null,Null,'" + s.ctext + "',Null,Null,'" + s.SO_SODetails_isosid + "',100,100,'" + s.cInvName + "','" + s.iTaxRate + "','" + s.Cvalue + "','" + s.Cvalue11 + "',Null,Null, \r\n";
                                                selectSQL += " Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'" + SO_SOMain_Id + "',Null,Null,Null,'" + s.Cvalue12 + "',Null,'" + s.useQty + "',Null,Null, \r\n";
                                                selectSQL += " Null,0,0,Null,Null,Null,'" + s.dpremodate + "','" + s.iRowNo + "',Null,Null,Null,Null,Null,Null,Null,\r\n";
                                                selectSQL += " Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,convert(bit,'" + s.borderbom + "'),0,convert(bit,'" + s.idemandtype + "'),Null,Null,Null,Null,Null,convert(bit,'" + s.busecusbom + "'),Null) \r\n";
                                                comm = new OleDbCommand(selectSQL, conn);
                                                comm.Connection = conn;
                                                comm.Transaction = myTran;
                                                n = comm.ExecuteNonQuery();
                                            }
                                            //提交事务
                                            myTran.Commit();

                                            if (conn.State == System.Data.ConnectionState.Open)
                                            {
                                                conn.Close();
                                            }
                                            if (n > 0)
                                            {
                                                
                                                MessageBox.Show("添加成功！");
                                                lst.Clear();
                                                tab2_toolSave.Enabled = false;
                                                tab2_toolAdd.Enabled = true;
                                                tab2_toolDelete.Enabled = true;
                                                tab2_toolQuery.Enabled = true;
                                                tsbtnRefurbish.Enabled = true;
                                                tab2_toolExit.Enabled = true;
                                                tab2_toolRowAdd.Enabled = false;
                                                tab2_toolRowDelete.Enabled = false;
                                                tsbEsc.Enabled = false;
                                                tsmiRowClose.Enabled = true;
                                                tab2_toolClose.Enabled = true;
                                                tsbtnRefurbish_Click(null, null);
                                            }
                                            else
                                            {
                                                MessageBox.Show("添加失败！");
                                            }
                                            #endregion
                                        }
                                        catch (Exception ex)
                                        {
                                            myTran.Rollback();
                                            MessageBox.Show("错误！添加SO_SODetails的数据有误！" + ex.Message);
                                        }
                                        finally
                                        {
                                            GC.Collect();
                                        }

                                }
                            }
                        }
                    }
                    #endregion

                    #region 修改处理
                    else if (AddRows == "修改")
                    {
                        if (tab2_dataGridView1.AllowUserToAddRows == true)
                        {
                            int upRCounts = tab2_dataGridView1.RowCount;
                            if (CheckputIn_SO_SOMain())
                            {
                                if (CheckputIn_SO_SODetails(upRCounts))
                                {
                                    List<SODetailsinfo> lstupdate = new List<SODetailsinfo>();
                                    OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                                    conn.Open();
                                    OleDbCommand comm = new OleDbCommand();
                                    dmoddate = DateTime.Now.ToString("yyyy-MM-dd");
                                    string selectSQL = "";

                                    selectSQL = " select isnull(cNumber,0) as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL";
                                    comm = new OleDbCommand(selectSQL, conn);
                                    OleDbDataReader drMax = comm.ExecuteReader();
                                    if (drMax.Read())
                                    {
                                        if (Maxnumber == Convert.ToInt32(drMax["Maxnumber"]))
                                        {
                                            Maxnumber = Convert.ToInt32(drMax["Maxnumber"]) + 1;
                                            tab2_cSOCode.Text = cstcodeId + DateTime.Now.ToString("yyyyMM") + "0" + string.Format("{0:d5}", Maxnumber);
                                        }
                                    }
                                    drMax.Close();

                                    #region 修改SO_SOMain表数据
                                    try
                                    {
                                        selectSQL += " Update SO_SOMain SET   \r\n";
                                        selectSQL += " id=" + SO_SOMain_Id + ",ivtid=95,cbustype=N'普通销售',cstcode=N'" + cstcodeId + "',ddate='" + tab2_dDate.Text + "',csocode=N'" + tab2_cSOCode.Text + "',ccuscode=N'" + cCusCodeId + "',cdepcode=N'" + cDepCodeId + "',  \r\n";
                                        selectSQL += " cpersoncode=N'" + cPersonCodeId + "',cpaycode=N'" + cpaycodeId + "',cexch_name=N'" + tab2_cexch_name.Text + "',iexchrate=" + tab2_iExchRate.Text + ",itaxrate=" + txtiTaxRate.Text + ",cmemo=N'" + tab2_cMemo.Text + "',cmaker=N'" + iLoginEx.UserName() + "',  \r\n";
                                        selectSQL += " dpredatebt='" + dpredatebt + "',dpremodatebt='" + dPreMoDateBT + "',bdisflag=0,ccusname=N'" + cCusAbbName + "',breturnflag=0,  \r\n";
                                        selectSQL += " ccusperson=N'" + cCusDefine8 + "',iverifystate=0,iswfcontrolled=0,dcreatesystime='" + dcreatesystime + "',bcashsale=0,ccrechpname=Null,cmodifier=N'" + iLoginEx.UserName() + "',  \r\n";
                                        selectSQL += " dmoddate='" + dmoddate + "',dmodifysystime=getdate(),iflowid=Null,cgatheringplan=Null,caddcode=Null,ccusoaddress=Null,csccode=Null   \r\n";
                                        selectSQL += " Where  ID= " + SO_SOMain_Id + "  \r\n";
                                        comm = new OleDbCommand(selectSQL, conn);
                                        comm.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("错误！修改SO_SOMain表的数据有误！  " + ex.Message);
                                    }
                                    try
                                    {   //如果订单号改变，则修改VoucherHistory表中的cNumber的值
                                        string mySelectMaxnumber = " select isnull(cNumber,0) as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL";
                                        comm = new OleDbCommand(mySelectMaxnumber, conn);
                                        OleDbDataReader dr = comm.ExecuteReader();
                                        int max=0;
                                        if (dr.Read())
                                        {
                                            max = Convert.ToInt32(dr["Maxnumber"]);
                                        }
                                        dr.Close();

                                        if (Maxnumber > max)
                                        {
                                            selectSQL = "update VoucherHistory set cNumber='" + Maxnumber.ToString() + "' Where  CardNumber='17' and cContent is NULL";
                                            comm = new OleDbCommand(selectSQL, conn);
                                            comm.ExecuteNonQuery();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("错误！最大订单号---" + ex.Message);
                                    }
                                    #endregion

                                    #region 收集SO_SODetails表的数据添加到集合
                                    if (tab2_dataGridView1.Rows.Count > 0)
                                    {
                                        for (int i = 0; i < upRCounts; i++)
                                        {
                                            SODetailsinfo sof = new SODetailsinfo();
                                            sof.cInvCode = tab2_dataGridView1.Rows[i].Cells[0].Value.ToString();
                                            sof.cInvName = tab2_dataGridView1.Rows[i].Cells[1].Value.ToString();
                                            sof.cInvStd = tab2_dataGridView1.Rows[i].Cells[2].Value.ToString();
                                            sof.cComUnitName = tab2_dataGridView1.Rows[i].Cells[3].Value.ToString();
                                            sof.iquantity = Convert.ToDouble(tab2_dataGridView1.Rows[i].Cells[4].Value);
                                            sof.itaxunitprice = Convert.ToDouble(tab2_dataGridView1.Rows[i].Cells[5].Value);

                                            sof.iTaxRate = Convert.ToDouble(tab2_dataGridView1.Rows[i].Cells[6].Value);
                                            sof.isum = sof.iquantity * sof.itaxunitprice;          //Convert.ToDouble(tab2_dataGridView1.Rows[i].Cells[7].Value);
                                            sof.dpredate = tab2_dataGridView1.Rows[i].Cells[8].Value.ToString();
                                            sof.useQty = tab2_dataGridView1.Rows[i].Cells[9].Value.ToString();
                                            sof.Cvalue = tab2_dataGridView1.Rows[i].Cells[10].Value.ToString();
                                            sof.Cvalue11 = tab2_dataGridView1.Rows[i].Cells["colCvalue11"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["colCvalue11"].Value.ToString();
                                            sof.Cvalue12 = tab2_dataGridView1.Rows[i].Cells["colCvalue12"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["colCvalue12"].Value.ToString();
                                            sof.ctext = tab2_dataGridView1.Rows[i].Cells["colctext"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["colctext"].Value.ToString();
                                            sof.dpremodate = tab2_dataGridView1.Rows[i].Cells["coldpremodate"].Value.ToString();
                                            sof.dpredate = tab2_dataGridView1.Rows[i].Cells["coldpredate"].Value.ToString();
                                            sof.borderbom = (tab2_dataGridView1.Rows[i].Cells["colborderbom"] as DataGridViewComboBoxCell).Value.ToString();

                                            sof.cclose = tab2_dataGridView1.Rows[i].Cells["colCClose"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["colCClose"].Value.ToString();

                                            switch (sof.borderbom)
                                            {
                                                case "否": sof.borderbom = "0";
                                                    break;
                                                case "是": sof.borderbom = "1";
                                                    break;
                                            }
                                            sof.busecusbom = (tab2_dataGridView1.Rows[i].Cells["colbusecusbom"] as DataGridViewComboBoxCell).Value.ToString();
                                            switch (sof.busecusbom)
                                            {
                                                case "否": sof.busecusbom = "0";
                                                    break;
                                                case "是": sof.busecusbom = "1";
                                                    break;
                                            }
                                            //value=grid.Rows[i].Cells[0].Value==null?"":grid.Rows[i].Cells[0].Value.ToString();
                                            sof.idemandtype = tab2_dataGridView1.Rows[i].Cells["colidemandtype"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["colidemandtype"].Value.ToString();
                                            if ("销售订单行号" == sof.idemandtype)
                                            {
                                                sof.idemandtype = "1";
                                            }

                                            //原币
                                            sof.iUnitPrice = sof.itaxunitprice * (1.00 - sof.iTaxRate * 0.01);
                                            sof.iMoney = sof.iUnitPrice * sof.iquantity;
                                            sof.itax = sof.isum - sof.iMoney;

                                            //本币
                                            sof.inatunitprice = sof.iUnitPrice * Convert.ToDouble(tab2_iExchRate.Text);
                                            sof.inatmoney = sof.inatunitprice * sof.iquantity;
                                            sof.inatitaxunitprice = sof.inatunitprice / (1.00 - sof.iTaxRate * 0.01);
                                            sof.inatsum = sof.inatitaxunitprice * sof.iquantity;
                                            sof.inattax = sof.inatsum - sof.inatmoney;

                                            sof.SO_SOMain_Id = Convert.ToInt32(tab2_dataGridView1.Rows[i].Cells["colSO_SOMain_Id"].Value);
                                            sof.SO_SODetails_isosid = Convert.ToInt32(tab2_dataGridView1.Rows[i].Cells["coliSOsID"].Value);
                                            sof.iRowNo = Convert.ToInt32(tab2_dataGridView1.Rows[i].Cells["colRows"].Value);
                                            lstupdate.Add(sof);
                                        }
                                    }
                                    #endregion
                                    #region 修改单个或批量SO_SODetails的表数据
                                    try
                                    {
                                        foreach (SODetailsinfo up in lstupdate)
                                        {
                                            string readsql = "select irowNo from SO_SODetails where id = " + up.SO_SOMain_Id + " and isosid =" + up.SO_SODetails_isosid + "";
                                            comm = new OleDbCommand(readsql, conn);
                                            OleDbDataReader dr = comm.ExecuteReader();
                                            if (dr.Read())
                                            {
                                                iRows = Convert.ToInt32(dr["irowNo"]);
                                            }
                                            dr.Close();
                                            if (up.iRowNo == iRows)
                                            {
                                                SO_SOMain_Id = up.SO_SOMain_Id;
                                                selectSQL = " Update SO_SODetails SET   \r\n";
                                                selectSQL += " cinvcode=N'" + up.cInvCode + "',dpredate='" + up.dpredate + "',iquantity=" + up.iquantity + ",inum=Null,iquotedprice=0,iunitprice=" + up.iUnitPrice + ",itaxunitprice=" + up.itaxunitprice + ",  \r\n";
                                                selectSQL += " imoney=" + up.iMoney + ",itax=" + up.itax + ",isum=" + up.isum + ",idiscount=0,inatunitprice=" + up.inatunitprice + ",inatmoney=" + up.inatmoney + ",inattax=" + up.inattax + ",inatsum=" + up.inatsum + ",inatdiscount=0,  \r\n";
                                                selectSQL += " cmemo=N'" + up.ctext + "',cfree1=Null,cfree2=Null,isosid=" + up.SO_SODetails_isosid + ",kl=100,kl2=100,cinvname=N'" + up.cInvName + "',itaxrate=" + up.iTaxRate + ",cdefine22=N'" + up.Cvalue + "',  \r\n";
                                                selectSQL += " cdefine23=N'" + up.Cvalue11 + "',cfree3=Null,cfree4=Null,cfree5=Null,cfree6=Null,cfree7=Null,cfree8=Null,cfree9=Null,cfree10=Null,iinvexchrate=Null,  \r\n";
                                                selectSQL += " cunitid=Null,id=" + up.SO_SOMain_Id + ",cdefine31=N'" + up.Cvalue12 + "',cdefine33=N'" + up.useQty + "',fsalecost=0,fsaleprice=0,cscloser='"+up.cclose+"',dpremodate='" + up.dpremodate + "',irowno=" + up.iRowNo + ",  \r\n";
                                                selectSQL += " icusbomid=Null,ccusinvcode=Null,ccusinvname=Null,dreleasedate='" + dreleasedate + "',fcusminprice=0,ballpurchase=0,finquantity=0,foutquantity=0,  \r\n";
                                                selectSQL += " fretquantity=0,fretnum=0,borderbom=convert(bit,'" + up.borderbom + "'),borderbomover=0,idemandtype=convert(bit,'" + up.idemandtype + "'),cdemandcode=Null,cdemandmemo=Null,busecusbom=convert(bit,'" + up.busecusbom + "'),cSOCode=N'" + tab2_cSOCode.Text + "'   \r\n";
                                                selectSQL += " Where  iSOsID= " + up.SO_SODetails_isosid + "  \r\n";
                                                comm = new OleDbCommand(selectSQL, conn);
                                                n = comm.ExecuteNonQuery();
                                            }
                                            else if (up.iRowNo != iRows)
                                            {
                                                selectSQL = "insert into SO_SODetails(  \r\n";
                                                selectSQL += " csocode,cinvcode,dpredate,iquantity,inum,iquotedprice,iunitprice,itaxunitprice,imoney,itax,isum,idiscount,inatunitprice,inatmoney,  \r\n";
                                                selectSQL += " inattax,inatsum,inatdiscount,ifhnum,ifhquantity,ifhmoney,ikpquantity,ikpnum,ikpmoney,cmemo,cfree1,cfree2,isosid,kl,kl2,cinvname,itaxrate,  \r\n";
                                                selectSQL += " cdefine22,cdefine23,cdefine24,cdefine25,cdefine26,cdefine27,citemcode,citem_class,citemname,citem_cname,cfree3,cfree4,cfree5,cfree6,cfree7,  \r\n";
                                                selectSQL += " cfree8,cfree9,cfree10,iinvexchrate,cunitid,id,cdefine28,cdefine29,cdefine30,cdefine31,cdefine32,cdefine33,cdefine34,cdefine35,fpurquan,fsalecost,  \r\n";
                                                selectSQL += " fsaleprice,cquocode,iquoid,cscloser,dpremodate,irowno,icusbomid,imoquantity,ccontractid,ccontracttagcode,ccontractrowguid,ippartseqid,ippartid,ippartqty,  \r\n";
                                                selectSQL += " ccusinvcode,ccusinvname,iprekeepquantity,iprekeepnum,iprekeeptotquantity,iprekeeptotnum,fcusminprice,fimquantity,fomquantity,ballpurchase,finquantity,foutquantity,  \r\n";
                                                selectSQL += " iexchsum,iaoids,cpreordercode,fretquantity,fretnum,borderbom,borderbomover,idemandtype,cdemandcode,cdemandmemo,iimid,ccorvouchtype,icorrowno,busecusbom,body_outid)   \r\n";
                                                selectSQL += " Values   \r\n";
                                                selectSQL += "('" + tab2_cSOCode.Text + "','" + up.cInvCode + "','" + up.dpredate + "','" + up.iquantity + "',Null,0,'" + up.iUnitPrice + "','" + up.itaxunitprice + "','" + up.iMoney + "', \r\n";
                                                selectSQL += " '" + up.itax + "','" + up.isum + "',0,'" + up.inatunitprice + "','" + up.inatmoney + "','" + up.inattax + "','" + up.inatsum + "',0,Null,\r\n";
                                                selectSQL += " Null,Null,Null,Null,Null,'" + up.ctext + "',Null,Null,'" + up.SO_SODetails_isosid + "',100,100,'" + up.cInvName + "','" + up.iTaxRate + "','" + up.Cvalue + "','" + up.Cvalue11 + "',Null,Null, \r\n";
                                                selectSQL += " Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,'" + up.SO_SOMain_Id + "',Null,Null,Null,'" + up.Cvalue12 + "',Null,'" + up.useQty + "',Null,Null, \r\n";
                                                selectSQL += " Null,0,0,Null,Null,Null,'" + up.dpremodate + "','" + up.iRowNo + "',Null,Null,Null,Null,Null,Null,Null,\r\n";
                                                selectSQL += " Null,Null,Null,Null,Null,Null,Null,0,Null,Null,0,Null,Null,Null,Null,Null,Null,Null,convert(bit,'" + up.borderbom + "'),0,convert(bit,'" + up.idemandtype + "'),Null,Null,Null,Null,Null,convert(bit,'" + up.busecusbom + "'),Null) \r\n";
                                                comm = new OleDbCommand(selectSQL, conn);
                                                n = comm.ExecuteNonQuery();
                                            }
                                        }
                                        if (conn.State == System.Data.ConnectionState.Open)
                                        {
                                            conn.Close();
                                        }
                                        if (n > 0)
                                        {
                                            MessageBox.Show("修改成功！");
                                            tab2_toolSave.Enabled = false;
                                            tab2_toolAdd.Enabled = true;
                                            tab2_toolDelete.Enabled = true;
                                            tab2_toolQuery.Enabled = true;
                                            tsbtnRefurbish.Enabled = true;
                                            tab2_toolExit.Enabled = true;
                                            tab2_toolRowAdd.Enabled = false;
                                            tab2_toolRowDelete.Enabled = false;
                                            tsbEsc.Enabled = false;
                                            tsmiRowClose.Enabled = true;
                                            tab2_toolClose.Enabled = true;
                                            tsbtnRefurbish_Click(null, null);
                                        }
                                        else
                                        {
                                            MessageBox.Show("修改失败！");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("错误！修改单个或批量SO_SODetails的表数据有误！" + ex.Message);
                                    }
                                    finally
                                    {
                                        GC.Collect();
                                    }
                                    #endregion
                                }
                            }
                        }
                    }

                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误！" + ex.Message);
                }
                finally
                {
                    GC.Collect();
                }
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
        #endregion

        #region 表头验证
        /// <summary>
        /// 表头验证
        /// </summary>
        /// <returns></returns>
        private bool CheckputIn_SO_SOMain()
        {
            if (String.IsNullOrEmpty(tab2_cSTCode.Text))
            {
                MessageBox.Show("请输入销售类型！");
                tab2_cSTCode.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(tab2_cCusCode.Text))
            {
                MessageBox.Show("请输入客户简称！");
                tab2_cCusCode.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(tab2_cDepCode.Text))
            {
                MessageBox.Show("请输入销售部门！");
                tab2_cDepCode.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(tab2_cPersonCode.Text))
            {
                MessageBox.Show("请输入业务员！");
                tab2_cPersonCode.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtPayCondition.Text))
            {
                MessageBox.Show("请输入付款条件！");
                txtPayCondition.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(tab2_cexch_name.Text))
            {
                MessageBox.Show("请输入币种！");
                tab2_cexch_name.Focus();
                return false;
            }
            return true;
        } 
        #endregion

        #region 表体验证
        /// <summary>
        /// 表体验证
        /// </summary>
        /// <param name="countLength"></param>
        /// <returns></returns>
        private bool CheckputIn_SO_SODetails(int countLength)
        {
            for (int i = 0; i < countLength; i++)
            {
               
                if (String.IsNullOrEmpty(tab2_dataGridView1.Rows[i].Cells["colcInvCode"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["colcInvCode"].Value.ToString()))//
                {
                    MessageBox.Show("请输入物料编码！");
                    tab2_dataGridView1.Rows[i].Cells["colcInvCode"].Selected = true;
                    tab2_dataGridView1.CurrentCell = tab2_dataGridView1.Rows[i].Cells["colcInvCode"];
                   // tab2_dataGridView1.BeginEdit(true);
                    return false;
                }
                if (String.IsNullOrEmpty(tab2_dataGridView1.Rows[i].Cells["coliquantity"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["coliquantity"].Value.ToString()) || Convert.ToDouble(tab2_dataGridView1.Rows[i].Cells["coliquantity"].Value)<=0.00)//
                {
                    MessageBox.Show("请输入大于0的数量！");
                    tab2_dataGridView1.Rows[i].Cells["coliquantity"].Selected = true;
                    tab2_dataGridView1.CurrentCell = tab2_dataGridView1.Rows[i].Cells["coliquantity"];
                    tab2_dataGridView1.BeginEdit(true);//设置焦点
                    return false;
                }
                if (String.IsNullOrEmpty(tab2_dataGridView1.Rows[i].Cells["coluseQty"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["coluseQty"].Value.ToString()))//
                {
                    MessageBox.Show("请输入软件信息！");
                    tab2_dataGridView1.Rows[i].Cells["coluseQty"].Selected = true;
                    tab2_dataGridView1.CurrentCell = tab2_dataGridView1.Rows[i].Cells["coluseQty"];
                    tab2_dataGridView1.BeginEdit(true);//设置焦点
                    return false;
                }
                if (String.IsNullOrEmpty(tab2_dataGridView1.Rows[i].Cells["colCvalue"].Value == null ? "" : tab2_dataGridView1.Rows[i].Cells["colCvalue"].Value.ToString()))
                {
                    MessageBox.Show("请输入制式/开机界面！");
                    tab2_dataGridView1.Rows[i].Cells["colCvalue"].Selected = true;
                    tab2_dataGridView1.CurrentCell = tab2_dataGridView1.Rows[i].Cells["colCvalue"];
                    tab2_dataGridView1.BeginEdit(true);//设置焦点
                    return false;
                }
            }

            return true;
        } 
        #endregion

        #region 退出事件
        /// <summary>
        /// 退出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolExit_Click(object sender, EventArgs e)
        {
           
            switch (AddRows)
            {
                case"添加":
                    if (txtiTaxRate.ReadOnly)
                    {
                        return;
                    }
                    else
                    {
                       tsbEscClose();
                    }
                    break;
            }
            this.Close();
        } 
        #endregion

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm311_Load(object sender, EventArgs e)
        {
            try
            {
                tab2_dataGridView1.Columns["coliSOsID"].Visible = true;
                tab2_dataGridView1.Columns["colSO_SOMain_Id"].Visible = true;
                #region 为了解决水晶报表第一次打印慢的问题
                //////为了解决水晶报表第一次打印慢的问题
                //DataTable dt = new DataTable();
                //dt.Columns.Add("temp");
                ////水晶报表对象
                //if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath.ToString() + @"\zzcReport\CR95.rpt"))
                //{
                //    try
                //    {
                //        string CRPath = System.Windows.Forms.Application.StartupPath.ToString() + @"\zzcReport\CR95.rpt";//拼接水晶报表模板路径
                //        //;//加载模板
                //        using (ReportDocument reportdocument = new ReportDocument())
                //        {
                //            reportdocument.Load(CRPath);
                //            reportdocument.SetDataSource(dt.DefaultView);
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("错误！" + ex.Message);
                //    }
                //    finally { GC.Collect(); }
                //}
                #endregion

                this.Text += "  " + System.Windows.Forms.Application.ProductVersion;  

               
                tab2_dDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                dtpend.Text = DateTime.Now.ToString("yyyy-MM-dd");
                dtpBigen.Text = iLoginEx.ReadUserProfileValue("SO311", "dtpBigen");
                txtcsocode.Text = iLoginEx.ReadUserProfileValue("SO311", "txtcsocode");
                txtcpersonname.Text = iLoginEx.ReadUserProfileValue("SO311", "txtcpersonname");
                txtccusabbname.Text = iLoginEx.ReadUserProfileValue("SO311", "txtccusabbname");
                txtCinvName.Text = iLoginEx.ReadUserProfileValue("SO311", "txtCinvName");
                tabControl1.SelectedIndex = 1;
           
                cbfind.Checked = iLoginEx.ReadUserProfileValue("SO311", "cbfind") == "1" ? true : false;
                cbsuit.Checked = iLoginEx.ReadUserProfileValue("SO311", "cbsuit") == "1" ? true : false;
                cobNumber.Text = iLoginEx.ReadUserProfileValue("SO311", "cobNumber") == "" ? "100" : iLoginEx.ReadUserProfileValue("SO311", "cobNumber");
                
                cbfind_CheckedChanged(null,null);

                this.KeyPreview = true;
                

           
                FormWidth = this.Width;
                FormHeight = this.Height;
                tabPageWidth = tabControl1.Width;
                tabPageHeight = tabControl1.Height;
                dataGridViewWidth = dgvSaleOrderList.Width;
                dataGridViewHeight = dgvSaleOrderList.Height;

                dataGridViewWidth2 = tab2_dataGridView1.Width;
                dataGridViewHeight2 = tab2_dataGridView1.Height;


                SLbAccID.Text = iLoginEx.AccID();
                SLbAccName.Text = iLoginEx.AccName();
                SLbServer.Text = iLoginEx.DBServerHost();
                SLbYear.Text = iLoginEx.iYear();
                SLbUser.Text = iLoginEx.UserId() + "[" + iLoginEx.UserName() + "]";

                iLoginEx.FormEditState(UTLoginEx.LoginEx.FormState.Initialized, null, tabControl1, "tabPage2", tab2_dataGridView1);//初始化窗口控件
               // tab2_toolEdit.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Edit) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), txtCmaker.Text, AuthID, LoginEx.FormAuthDetailType.Edit);
                //权限验证--------------------------------------------------- begin---
                tab2_toolAdd.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.AddNew) ;
                tab2_toolAudit.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Auditing) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Auditing);
                tab2_toolClose.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Close) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Closed);
                tab2_toolDelete.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Delete) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Delete);
                tab2_toolEdit.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Edit) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Edit);
                tab2_toolExit.Enabled = true;
                tab2_toolNoAudit.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.NoAudit) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.NoAudit);
                tab2_toolPrint.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Print) ;
                tab2_toolQuery.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Query) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Query);
                tab2_toolRowAdd.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.AddRow) ;
                tab2_toolRowDelete.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.DeleteRow) ;
                tab2_toolSave.Enabled = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Save);
                //权限验证--------------------------------------------------- end---
                //tsbtnRefurbish_Click(null, null);

            }
            catch (Exception ex)
            {
                frmMessege frmmsg = new frmMessege(ex.ToString(), "frm311_Load()");
                frmmsg.ShowDialog(this);
            }

            tab2_toolQuery.Enabled = true;
            tsbtnRefurbish.Enabled = true;
            tab2_toolExit.Enabled = true;
            tab2_toolAdd.Enabled = true;

            tab2_toolSave.Enabled = false;
            tab2_toolDelete.Enabled = false;
            tab2_toolRowAdd.Enabled = false;
            tab2_toolRowDelete.Enabled = false;
            tsbEsc.Enabled = false;
            tsmiRowClose.Enabled = false;
            tab2_toolClose.Enabled = false;
            tab2_toolEdit.Enabled = false;
            tab2_toolAudit.Enabled = false;
            tab2_toolNoAudit.Enabled = false;

         

          //  this.reportViewer1.RefreshReport();
        }
        
        #endregion

        #region 双击销售类型事件
        /// <summary>
        /// 双击销售类型事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_cSTCode_MouseDoubleClick(object sender, MouseEventArgs e)
        {

           
            try
            {
                if (!tab2_cSTCode.ReadOnly)
                {
                    tab2_cSTCode.Text = iLoginEx.OpenSelectWindow("销售类型", "Select cSTCode as'销售类型编码', cSTName as'销售类型名称' from Saletype (nolock)", tab2_cSTCode.Text.IndexOf("\r\n\r\n\r\n ") != -1 ? Ini.Left(tab2_cSTCode.Text, tab2_cSTCode.Text.IndexOf("\r\n\r\n\r\n ")) : tab2_cSTCode.Text, 330, 300, 2);

                    if (tab2_cSTCode.Text.IndexOf("\r\n\r\n\r\n ") != -1)
                    {
                        
                        OleDbConnection myConn = new OleDbConnection(iLoginEx.ConnString());
                        if (myConn.State == System.Data.ConnectionState.Open)
                        {
                            myConn.Close();
                        }
                        myConn.Open();
                        string mySelectQuery = "delete from zhrs_t_zzcSO_SOAddSeriesInfo where Csocode='" + tab2_cSOCode.Text.Trim() + "'";
                        OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConn);
                       myCommand.CommandText = mySelectQuery;
                        myCommand.ExecuteNonQuery();

                         mySelectQuery = " select isnull(cNumber,0) as Maxnumber From VoucherHistory  with (NOLOCK) Where  CardNumber='17' and cContent is NULL";
                         myCommand.CommandText = mySelectQuery;
                        OleDbDataReader myReader = myCommand.ExecuteReader();
                        if (myReader.Read())
                        {
                            cstcodeId = Ini.Left(tab2_cSTCode.Text, tab2_cSTCode.Text.IndexOf("\r\n\r\n\r\n "));
                            Maxnumber = Convert.ToInt32(myReader["Maxnumber"]) + 1;

                            tab2_cSOCode.Text = cstcodeId + DateTime.Now.ToString("yyyyMM") + "0" + string.Format("{0:d5}", Maxnumber);
                        }
                        else
                        {
                            tab2_cSOCode.Text = cstcodeId + DateTime.Now.ToString("yyyyMM") + "0" + string.Format("{0:d5}", 1);
                        }
                        myReader.Close();
                       
                        myReader.Dispose();

                        if (myConn.State == System.Data.ConnectionState.Open)
                        {
                            myConn.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                frmMessege frmmsg = new frmMessege(ex.ToString(), "tab2_cSTCode_MouseDoubleClick()");
                frmmsg.ShowDialog(this);
            }
        }

        #endregion

        #region 查询事件
        /// <summary>
        /// 查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolQuery_Click(object sender, EventArgs e)
        {
            //bool b1 = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Query);
            //bool b2 = iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Query);
            //MessageBox.Show(b1.ToString() + "||" + b2.ToString());

            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Query) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Query))
            {
                Query();
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Query()
        {
            frmQuery frm = new frmQuery();
            frm.iLoginEx = iLoginEx;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                AddRows = "查询";
                csocode = frm.coscode;
                string sql = "select Count(*) from SaleOrderQ where csocode='" + csocode + "'";
                int n = Convert.ToInt32(OLEDBHelper.ExecuteScalar(sql, CommandType.Text));
                if (n>0)
                {
                    tsbtnRefurbish_Click(null, null);
                }
                else
                {
                    MessageBox.Show("无此销售订单！");
                }
            }
        } 
        #endregion

        #region 双击销售部门事件
        /// <summary>
        /// 双击销售部门事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_cDepCode_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tab2_cDepCode.ReadOnly) return;
            try
            {
                string wCode = "", wName = "";
                string[] para = tab2_cDepCode.Text.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
                if (para.Length > 1)
                {
                    wCode = para[1];
                    //wName = para[0];  
                }
                else
                {
                    wCode = tab2_cDepCode.Text;
                }
                tab2_cDepCode.Text = iLoginEx.OpenSelectWindow("部门", "select cDepCode as'部门编码',cDepName as '部门名称' from Department (NOLOCK)", wCode, 330, 300, 2);
                para = tab2_cDepCode.Text.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
                if (para.Length > 1)
                {
                    wCode = para[0];
                    wName = para[1];
                    cDepCodeId = wCode;
                }
                tab2_cDepCode.Text = wName + "\r\n\r\n\r\n " + wCode;
            }
            catch (Exception ex)
            {
                frmMessege frmmsg = new frmMessege(ex.ToString(), "tab2_cDepCode_MouseDoubleClick()");
                frmmsg.ShowDialog(this);
            }
        } 
        #endregion

        #region 双击业务员事件
        /// <summary>
        /// 双击业务员事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_cPersonCode_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tab2_cPersonCode.ReadOnly) return;
            try
            {
                string wCode = "", wName = "";
                string[] para = tab2_cPersonCode.Text.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
                if (para.Length > 1)
                {
                    wCode = para[1];
                    //wName = para[0];  
                }
                else
                {
                    wCode = tab2_cPersonCode.Text;
                }

                tab2_cPersonCode.Text = iLoginEx.OpenSelectWindow("职员", "select cPersonCode as'工号',cPersonName as '姓名' from Person(NOLOCK)", wCode, 330, 300, 2);
                para = tab2_cPersonCode.Text.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
                if (para.Length > 1)
                {
                    wCode = para[0];
                    wName = para[1];
                    cPersonCodeId = wCode;
                }

                tab2_cPersonCode.Text = wName + "\r\n\r\n\r\n " + wCode;

            }
            catch (Exception ex)
            {
                frmMessege frmmsg = new frmMessege(ex.ToString(), "tab2_cPersonCode_MouseDoubleClick()");
                frmmsg.ShowDialog(this);
            }
        } 
        #endregion

        #region 双击客户事件
        /// <summary>
        /// 双击客户事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_cCusCode_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tab2_cCusCode.ReadOnly) return;
            try
            {
                string wCode = "", wName = "";
                string[] para = tab2_cCusCode.Text.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
                if (para.Length > 1)
                {
                   // wCode = para[1];
                    wName = para[0];  
                }
                else
                {
                    wName = tab2_cCusCode.Text;
                }

                tab2_cCusCode.Text = iLoginEx.OpenSelectWindow("客户", "select cCusAbbName as '客户简称',cCusCode as'客户编码',cCusDefine8 as '联系人' from  Customer", wName, 650, 450, 3);

                para = tab2_cCusCode.Text.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
                if (para.Length > 1)
                {
                    wCode = para[1];
                    wName = para[0];
                    tab2_cCusCode.Text = wName; //+ "\r\n\r\n\r\n " + wCode;

                    cCusCodeId = wCode;
                    cCusAbbName = wName;
                    cCusDefine8 = para[2];

                    OleDbConnection myConn = new OleDbConnection(iLoginEx.ConnString());
                    if (myConn.State == System.Data.ConnectionState.Open)
                    {
                        myConn.Close();
                    }
                    myConn.Open();

                    string mySelectQuery = " select cCusExch_name from  Customer  (NOLOCK)  where cCusCode='" + wCode + "'";

                    OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConn);
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        tab2_cexch_name.Text = myReader["cCusExch_name"].ToString();
                    }
                    myReader.Close();
                    myReader.Dispose();

                    DateTime dt = tab2_dDate.Value;


                    mySelectQuery = "select t1.cexch_name,t1.cexch_code,ISNULL(t2.nflat,1) AS nflat,isnull(idec,0) as idec \r\n";
                    mySelectQuery += " From (SELECT cexch_name,cexch_code,isnull(idec,0) as idec FROM ForeignCurrency  \r\n";
                    mySelectQuery += " Where cexch_name=N'" + tab2_cexch_name.Text + "' Or cexch_Code=N'" + tab2_cexch_name.Text + "') as t1 \r\n";
                    mySelectQuery += "  Left Join (select cexch_name,nflat from exch WHERE itype= 2 AND cdate='" + dt.Month.ToString() + "') as t2 on  \r\n";
                    mySelectQuery += " t1.cexch_name=t2.cexch_name \r\n";
                    myCommand.CommandText = mySelectQuery;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        tab2_iExchRate.Text = myReader["nflat"].ToString();
                    }
                    myReader.Close();
                    myReader.Dispose();

                    mySelectQuery = "SELECT isnull(Person.cPersonCode,N'') as chandler,isnull(cPersonName,N'') as cPersonName,isnull(person.cPersonCode,N'') as cpersoncode,  \r\n";
                    mySelectQuery += " isnull(department.cdepcode,N'') as cdepcode,isnull(cDepName,N'') as cDepName, cusadd.cdeliveradd as cshipaddress   \r\n";
                    mySelectQuery += " ,cusadd.caddcode,cusadd.cdeliverunit,crm.ccontactname ,crm.cmobilephone,crm.cofficephone, Customer.cCusCode, Customer.cCusName,  \r\n";
                    mySelectQuery += "  Customer.cCusAbbName, Customer.cCCCode, Customer.cDCCode, Customer.cTrade, Customer.cCusAddress, Customer.cCusPostCode,   \r\n";
                    mySelectQuery += " Customer.cCusRegCode, Customer.cCusBank, Customer.cCusAccount, Customer.dCusDevDate, Customer.cCusLPerson,  \r\n";
                    mySelectQuery += "  Customer.cCusEmail,Customer.cCusPerson, Customer.cCusPhone, Customer.cCusFax,Customer.cCusBP, Customer.cCusHand, Customer.cCusPPerson,   \r\n";
                    mySelectQuery += " Customer.iCusDisRate, Customer.cCusCreGrade, Customer.iCusCreLine,Customer.iCusCreDate, Customer.cCusPayCond,  \r\n";
                    mySelectQuery += " Customer.cCusOAddress, Customer.cCusOType,Customer.cCusHeadCode, Customer.cCusWhCode,Customer.cCusDepart, Customer.iARMoney,   \r\n";
                    mySelectQuery += " Customer.dLastDate,Customer.iLastMoney, Customer.dLRDate, Customer.iLRMoney,Customer.dEndDate, Customer.iFrequency,  \r\n";
                    mySelectQuery += "  Customer.cCusDefine1,Customer.cCusDefine2, Customer.cCusDefine3, Customer.iCostGrade,Customer.cCreatePerson,   \r\n";
                    mySelectQuery += " Customer.cModifyPerson,Customer.dModifyDate, Customer.cRelVendor, Customer.iId,Customer.cPriceGroup,Customer.cOfferGrade,  \r\n";
                    mySelectQuery += "  Customer.iOfferRate,Customer.cCusDefine4, Customer.cCusDefine5, Customer.cCusDefine6,Customer.cCusDefine7, Customer.cCusDefine8,   \r\n";
                    mySelectQuery += " Customer.cCusDefine9,Customer.cCusDefine10, Customer.cCusDefine11,Customer.cCusDefine12, Customer.cCusDefine13,  \r\n";
                    mySelectQuery += " Customer.cCusDefine14, Customer.cCusDefine15,Customer.cCusDefine16 , isnull(cPayCode,N'') as cPayCode, isnull(cPayName,N'') as cPayName,   \r\n";
                    mySelectQuery += " isnull(ShippingChoice.cSCCode,N'') as cSCCode,isnull(ShippingChoice.cSCName,N'') as cSCName,  \r\n";
                    mySelectQuery += "  customer.cCusCreditCompany as ccreditcuscode,creditcustomer.ccusname as ccreditcusname,  isnull(customer.bCreditDate,0) as   \r\n";
                    mySelectQuery += " bCreditDate,isnull(customer.cCusSAProtocol,N'') as cCusSAProtocol ,isnull(customer.ccusotherprotocol,N'') as ccusotherprotocol,  \r\n";
                    mySelectQuery += "  isnull(customer.ccusexch_name,'') as ccusexch_name  from customer  left join person on customer.cCusPPerson=person.cpersoncode left   \r\n";
                    mySelectQuery += " join department on customer.cCusDepart=department.cdepcode left join ShippingChoice on customer.cCusOType=ShippingChoice.cSCCode   \r\n";
                    mySelectQuery += " left join  PayCondition on customer.cCusPayCond=PayCondition.cPayCode left join cusdeliveradd cusadd on (cusadd.ccuscode =   \r\n";
                    mySelectQuery += " customer.ccuscode and cusadd.bdefault=1)   left join crm_contact crm on (crm.ccontactcode=cusadd.clinkperson) left join   \r\n";
                    mySelectQuery += " customer as creditcustomer on customer.cCusCreditCompany=creditcustomer.ccuscode WHERE (customer.ccusAbbName='" + cCusAbbName + "'   \r\n";
                    mySelectQuery += " OR customer.cCusCode='" + cCusAbbName + "')  and isnull(Customer.dEndDate,'9999-12-31')>getdate()  \r\n";

                    myCommand.CommandText = mySelectQuery;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        tab2_cDepCode.Text = myReader["cDepName"].ToString();
                        tab2_cPersonCode.Text = myReader["cPersonName"].ToString();
                        cPersonCodeId = myReader["cpersoncode"].ToString();
                        cDepCodeId = myReader["cdepcode"].ToString();
                    }

                    myReader.Close();
                    myReader.Dispose();

                    if (myConn.State == System.Data.ConnectionState.Open)
                    {
                        myConn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                frmMessege frmmsg = new frmMessege(ex.ToString(), "tab2_cCusCode_MouseDoubleClick()");
                frmmsg.ShowDialog(this);
            }
        } 
        #endregion

        #region 双击币种事件
        /// <summary>
        /// 双击币种事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_cexch_name_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tab2_cexch_name.ReadOnly) return;
            try
            {

                tab2_cexch_name.Text = iLoginEx.OpenSelectWindow("币种", "select cexch_name as '币种' from foreigncurrency (NOLOCK)", tab2_cexch_name.Text, 330, 300, 2);

                OleDbConnection myConn = new OleDbConnection(iLoginEx.ConnString());
                if (myConn.State == System.Data.ConnectionState.Open)
                {
                    myConn.Close();
                }
                myConn.Open();

                DateTime dt = tab2_dDate.Value;
                string mySelectQuery = "select t1.cexch_name,t1.cexch_code,ISNULL(t2.nflat,1) AS nflat,isnull(idec,0) as idec \r\n";
                mySelectQuery += " From (SELECT cexch_name,cexch_code,isnull(idec,0) as idec FROM ForeignCurrency  \r\n";
                mySelectQuery += " Where cexch_name=N'" + tab2_cexch_name.Text + "' Or cexch_Code=N'" + tab2_cexch_name.Text + "') as t1 \r\n";
                mySelectQuery += "  Left Join (select cexch_name,nflat from exch WHERE itype= 2 AND cdate='6') as t2 on  \r\n";  //" + dt.Month.ToString() + "
                mySelectQuery += " t1.cexch_name=t2.cexch_name \r\n";

                OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConn);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {
                    tab2_iExchRate.Text = myReader["nflat"].ToString();
                }
                myReader.Close();
                myReader.Dispose();


                if (myConn.State == System.Data.ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
            catch (Exception ex)
            {
                frmMessege frmmsg = new frmMessege(ex.ToString(), "tab2_cexch_name_MouseDoubleClick()");
                frmmsg.ShowDialog(this);
            }
        } 
        #endregion

        #region 测试数据
        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            //frmSoAddInfo frm = new frmSoAddInfo();
            //frm.Csocode = "H201706035598"; //Csocode;
            //frm.Cinvcode = "N61040000"; //Cinvcode;
            //frm.Siquantity = 123;
            //frm.SiQuotedPrice = 100.11;
            //frm.SiSum = frm.Siquantity * frm.SiQuotedPrice;
            //frm.iLoginEx = iLoginEx;
            //frm.ShowDialog();
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolDelete_Click(object sender, EventArgs e)
        {
            //bool b1 = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Delete);
            //bool b2 = iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Delete);
            //MessageBox.Show(b1.ToString() + "||" + b2.ToString());

            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Delete)&&iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(),iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Delete))
            {
                AddRows = "删除";
                OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                conn.Open();
                string delsql = "delete from zhrs_t_zzcSO_SOAddSeriesInfo where SO_SOMain_Id=" + SO_SOMain_Id + " \r\n";
                delsql += " DELETE  FROM SO_SODetails Where  SO_SODetails.ID= " + SO_SOMain_Id + " \r\n";
                delsql += " DELETE  FROM so_somain Where  ID= " + SO_SOMain_Id + " \r\n";
                OleDbCommand comm = new OleDbCommand(delsql, conn);
                DialogResult ret = MessageBox.Show("确实要删除本张单据吗？\n 与本张单据关联的《拆解套餐详细信息表》的数据一并删除", "销售管理", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (AddRows == "删除")
                {
                    if (ret == DialogResult.Yes)
                    {
                        comm.ExecuteNonQuery();
                        tsbtnRefurbish_Click(null, null);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
        #endregion

        #region 插行
        /// <summary>
        /// 插行变量
        /// </summary>
        public string RowsQ = "";
        /// <summary>
        /// 插行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolRowAdd_Click(object sender, EventArgs e)
        {
            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.AddRow))
            {
                if (AddRows == "修改")
                {
                    int index = tab2_dataGridView1.CurrentCell.RowIndex;
                    int RCounts = tab2_dataGridView1.RowCount;
                    int raiRows = Convert.ToInt32(tab2_dataGridView1.Rows[index].Cells["colRows"].Value);
                    string Rsql = "";
                    OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                    conn.Open();
                    Rsql = "declare @p5 int  \r\n";
                    Rsql += " set @p5=0  \r\n";
                    Rsql += " declare @p6 int  \r\n";
                    Rsql += " set @p6=0  \r\n";
                    Rsql += " exec sp_getID '00','" + iLoginEx.AccID() + "','Somain',1,@p5 output,@p6 output  \r\n";
                    Rsql += "update tempdb..so311_sale" + iLoginEx.GetMacAddress().Replace(":", "") + " set iRowNo=iRowNo+1 where iRowNo>=" + raiRows + " and Id=" + SO_SOMain_Id + "  \r\n";
                    Rsql += "update SO_SODetails set iRowNo=iRowNo+1 where iRowNo>=" + raiRows + " and Id=" + SO_SOMain_Id + "   \r\n";
                    Rsql += " insert into tempdb..so311_sale" + iLoginEx.GetMacAddress().Replace(":", "") + "(iRowNo,Id,isosid)  \r\n";
                    Rsql += " values (" + raiRows + "," + SO_SOMain_Id + ",@p6)  \r\n";
                    OleDbCommand comm = new OleDbCommand(Rsql, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    RowsQ = "插行";
                    Rsql = "select * from  tempdb..so311_sale" + iLoginEx.GetMacAddress().Replace(":", "") + " order by iRowNo";
                    RowQFind(Rsql);
                }
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
        #endregion

        #region  Copy封装信息
        /// <summary>
        /// Copy封装信息
        /// </summary>
        /// <param name="Rsql"></param>
        /// <returns></returns>
        private string RowQFind(string Rsql)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(iLoginEx.ConnString());
                con.Open();
                OleDbCommand com = new OleDbCommand(Rsql, con);
                List<SODetailsinfo> tsblst1 = new List<SODetailsinfo>();
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    SODetailsinfo s = new SODetailsinfo();
                    s.cInvCode = dr["cinvcode"].ToString();
                    s.cInvName = dr["cinvname"].ToString();
                    s.cInvStd = dr["cInvStd"].ToString();
                    s.cComUnitName = dr["cinvm_unit"].ToString();
                    s.iquantity = Convert.ToDouble(dr["iquantity"] == DBNull.Value ? "0" : dr["iquantity"].ToString());
                    s.itaxunitprice = Convert.ToDouble(dr["itaxunitprice"] == DBNull.Value ? "0" : dr["itaxunitprice"].ToString());
                    s.inatunitprice = Convert.ToDouble(dr["inatunitprice"] == DBNull.Value ? "0" : dr["inatunitprice"].ToString());
                    s.iTaxRate = Convert.ToDouble(dr["itaxrate"] == DBNull.Value ? "0" : dr["itaxrate"].ToString());
                    s.isum = Convert.ToDouble(dr["isum"] == DBNull.Value ? "0" : dr["isum"].ToString());
                    s.dpredate = (dr["dpredate"] == DBNull.Value ? "" : Convert.ToDateTime(dr["dpredate"]).ToString("yyyy-MM-dd")).ToString();
                    s.dpremodate = (dr["dpremodate"] == DBNull.Value ? "" : Convert.ToDateTime(dr["dpremodate"]).ToString("yyyy-MM-dd")).ToString();
                    s.useQty = dr["cdefine33"].ToString();
                    s.Cvalue = dr["cdefine22"].ToString();
                    s.Cvalue11 = dr["cdefine23"].ToString();
                    s.Cvalue12 = dr["cdefine31"].ToString();
                    s.ctext = dr["cmemo"].ToString();
                    s.SO_SODetails_isosid = Convert.ToInt32(dr["iSOsID"] == DBNull.Value ? "0" : dr["iSOsID"].ToString());
                    s.SO_SOMain_Id = Convert.ToInt32(dr["id"] == DBNull.Value ? "0" : dr["id"].ToString());
                    s.iRowNo = Convert.ToInt32(dr["iRowNo"]);
                    dreleasedate = dr["dreleasedate"].ToString();

                    s.borderbom = dr["borderbom"].ToString();
                    switch (dr["busecusbom"].ToString())
                    {
                        case "0": s.busecusbom = "否"; break;
                        case "1": s.borderbom = "是"; break;
                    }
                    if ("1" == dr["idemandtype"].ToString())
                    {
                        s.idemandtype = "销售订单行号";
                    }
                    LpPecSRPolicy(s.cInvCode);
                    tsblst1.Add(s);
                }
                dr.Close();
                dr.Dispose();
                con.Close();
                tab2_dataGridView1.AutoGenerateColumns = false;
                tab2_cSTCode.ReadOnly = true;
                tab2_dataGridView1.DataSource = tsblst1;
                FormatDGV(4,8);
                tab2_cSTCode.ReadOnly = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("错误！" + ex.Message);
            }
            finally
            {
                GC.Collect();
            }
            return Rsql;
        }
        /// <summary>
        /// 格式化数值
        /// </summary>
        private void FormatDGV(int coln,int colcount)
        {
            for (int i = coln; i <= colcount; i++)
            {
                if (i==4)
                {
                     tab2_dataGridView1.Columns[i].DefaultCellStyle.Format = "#,###0.000";
                }
                else if (i == 5)
                {
                    tab2_dataGridView1.Columns[i].DefaultCellStyle.Format = "#,###0.0000";
                }
                else
                {
                    tab2_dataGridView1.Columns[i].DefaultCellStyle.Format = "#,###0.00";
                }
               
                tab2_dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        } 
        #endregion

        #region 删行
        /// <summary>
        /// 删行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolRowDelete_Click(object sender, EventArgs e)
        {
            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.DeleteRow))
            {
                if (AddRows == "修改")
                {
                    int index = tab2_dataGridView1.CurrentCell.RowIndex;
                    int rliRows = Convert.ToInt32(tab2_dataGridView1.Rows[index].Cells["colRows"].Value);
                    int soiRow = rliRows + 1;
                    //if (RowsQ == "插行")
                    //{
                        if (index >= 0)
                        {
                            try
                            {
                                SO_SODetails_isosid = Convert.ToInt32(tab2_dataGridView1.Rows[index].Cells["coliSOsID"].Value);
                                SO_SOMain_Id = Convert.ToInt32(tab2_dataGridView1.Rows[index].Cells["colSO_SOMain_Id"].Value);
                                OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                                conn.Open();
                                string sqlisosid = "";
                                sqlisosid = "update tempdb..so311_sale" + iLoginEx.GetMacAddress().Replace(":", "") + " set iRowNo=iRowNo-1 where iRowNo>=" + soiRow + "  and Id=" + SO_SOMain_Id + "  \r\n";
                                sqlisosid += "update SO_SODetails set iRowNo=iRowNo-1 where iRowNo>=" + soiRow + " and Id=" + SO_SOMain_Id + "   \r\n";
                                sqlisosid += " delete from  tempdb..so311_sale" + iLoginEx.GetMacAddress().Replace(":", "") + " where isosid=" + SO_SODetails_isosid + "  \r\n";
                                sqlisosid += " delete from  SO_SODetails where isosid=" + SO_SODetails_isosid + "  \r\n";
                                sqlisosid += " delete from zhrs_t_zzcSO_SOAddSeriesInfo where isosid=" + SO_SODetails_isosid + "  \r\n";
                                OleDbCommand com = new OleDbCommand(sqlisosid, conn);
                                DialogResult ret = MessageBox.Show("确定要删除此物料吗？\n 与此物料关联的《拆解套餐详细信息表》的数据一并删除", "销售管理", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (ret == DialogResult.Yes)
                                {
                                    com.ExecuteNonQuery();
                                    RowQFind("select * from  tempdb..so311_sale" + iLoginEx.GetMacAddress().Replace(":", "") + " order by iRowNo");
                                }
                                conn.Close();
                                GC.Collect();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("错误！  " + ex.Message);
                            }
                        }
                   // }
                    //else if (RowsQ != "插行")
                    //{

                    //    if (index >= 0)
                    //    {
                    //        try
                    //        {
                    //            SO_SODetails_isosid = Convert.ToInt32(tab2_dataGridView1.Rows[index].Cells["coliSOsID"].Value);
                    //            SO_SOMain_Id = Convert.ToInt32(tab2_dataGridView1.Rows[index].Cells["colSO_SOMain_Id"].Value);
                    //            OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                    //            conn.Open();
                    //            string sqlisosid = "update SO_SODetails set iRowNo=iRowNo-1 where iRowNo>=" + soiRow + " and Id=" + SO_SOMain_Id + "   \r\n";
                    //            sqlisosid += "delete from  SO_SODetails where isosid=" + SO_SODetails_isosid + " \r\n";
                    //            sqlisosid += " delete from  tempdb..so311_sale" + iLoginEx.GetMacAddress().Replace(":", "") + " where isosid=" + SO_SODetails_isosid + "  \r\n";
                    //            OleDbCommand com = new OleDbCommand(sqlisosid, conn);
                    //            DialogResult ret = MessageBox.Show("确定要删除此物料吗？", "销售管理", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //            if (ret == DialogResult.Yes)
                    //            {
                    //                com.ExecuteNonQuery();
                    //                tsbtnRefurbish_Click(null, null);
                    //            }
                    //            conn.Close();
                    //            GC.Collect();
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            MessageBox.Show("错误！  " + ex.Message);
                    //        }
                    //    }
                    //}
                }
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
        #endregion

       
        #region 双击备注内容事件
        /// <summary>
        /// 双击备注内容事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_cMemo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tab2_cMemo.ReadOnly) return;
            string wCode = "", wName = "", sText = "";
            string[] para = sText.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
            if (para.Length > 1)
            {
                wCode = para[1];
                //wName = para[0];  
            }
            else
            {
                wCode = sText;
            }
            string selectSQL = "SELECT cid as 编号, ctext as 内容 FROM GL_bdigest ";
            sText = iLoginEx.OpenSelectWindow("常用摘要参照", selectSQL, wCode, 450, 300, 2);
            para = sText.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
            if (para.Length > 1)
            {
                wName = para[1];
                tab2_cMemo.Text = wName;

            }
        } 
        #endregion

        #region 双击付款方式事件
        /// <summary>
        /// 双击付款方式事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPayCondition_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (txtPayCondition.ReadOnly) return;
            string wCode = "", wName = "", sText = "";
            string[] para = sText.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
            if (para.Length > 1)
            {
                wCode = para[1];
                //wName = para[0];  
            }
            else
            {
                wCode = sText;
            }
            string selectSQL = "Select cpaycode as 付款条件编码,cpayname as 付款条件名称 from PayCondition ";
            sText = iLoginEx.OpenSelectWindow("付款条件基本参照", selectSQL, wCode, 450, 300, 2);
            para = sText.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
            if (para.Length > 1)
            {

                wName = para[1];
                txtPayCondition.Text = wName;
                cpaycodeId = para[0];

            }
        } 
        #endregion

        public string sql_SaleOrderQ = "";
        public string sql_SaleOrderSQ = "";
        #region 刷新事件
        /// <summary>
        /// 刷新事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnRefurbish_Click(object sender, EventArgs e)
        {

            if (AddRows == "修改")
            {
                sql_SaleOrderQ = "Select top 1 * from SaleOrderQ where  id = " + SO_SOMain_Id + "  order by id desc ";
            }
            else if (AddRows == "添加")
            {
                sql_SaleOrderQ = "Select top 1 * from SaleOrderQ where  id = " + SO_SOMain_Id + "  order by id desc ";
            }
            else if (AddRows == "删除")
            {
                if (CheckExists(SO_SOMain_Id))
                {
                    sql_SaleOrderQ = "Select * from SaleOrderQ where id=(select top 1 id from  so_somain where id> " + SO_SOMain_Id + "  order by id ASC )";
                }
                else
                {
                    sql_SaleOrderQ = "Select * from SaleOrderQ where id=(select isnull(Max(id),0) as MaxID from so_somain  WHERE id >0  )";
                    delRowa = "删除1";
                }
            }
            else if (AddRows == "审")
            {
                sql_SaleOrderQ = "Select top 1 * from SaleOrderQ where  id = " + SO_SOMain_Id + "  order by id desc ";
            }
            else if (AddRows == "查询")
            {
                sql_SaleOrderQ = "Select top 1 * from SaleOrderQ  where csocode='" + csocode + "'";
            }
            else if (AddRows == "")
            {
                sql_SaleOrderQ = "Select top 1 * from SaleOrderQ  order by id desc ";
            }
            iLoginEx.FormEditState(UTLoginEx.LoginEx.FormState.Initialized, null, tabControl1, "tabPage2", tab2_dataGridView1);//初始化窗口控件
            List<SODetailsinfo> tsblst = new List<SODetailsinfo>();
            OleDbConnection con = new OleDbConnection(iLoginEx.ConnString());
            con.Open();
            OleDbCommand com = new OleDbCommand(sql_SaleOrderQ, con);
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                tab2_dDate.Text = (Convert.ToDateTime(dr["ddate"])).ToString("yyyy-MM-dd");
                tab2_cSTCode.Text = dr["cstname"].ToString();
                tab2_cSOCode.Text = dr["csocode"].ToString();
                tab2_cDepCode.Text = dr["cdepname"].ToString();
                tab2_cPersonCode.Text = dr["cpersonname"].ToString();
                txtPayCondition.Text = dr["cpayname"].ToString();
                tab2_cCusCode.Text = dr["ccusabbname"].ToString();
                txtiTaxRate.Text = dr["itaxrate"].ToString();
                tab2_cexch_name.Text = dr["cexch_name"].ToString();
                tab2_iExchRate.Text = dr["iexchrate"].ToString();
                tab2_cMemo.Text = dr["cmemo"].ToString();
                SO_SOMain_Id = Convert.ToInt32(dr["id"]);
                cCusCodeId = dr["ccuscode"].ToString();
                cDepCodeId = dr["cDepCode"].ToString();
                cstcodeId = dr["cSTCode"].ToString();
                cPersonCodeId = dr["cpersoncode"].ToString();
                cpaycodeId = dr["cpaycode"].ToString();
                iTaxRate = Convert.ToDouble(dr["itaxrate"]);
                dpredatebt = dr["dpredatebt"].ToString();
                dPreMoDateBT = dr["dPreMoDateBT"].ToString();
                cCusAbbName = dr["ccusname"].ToString();
                cCusDefine8 = dr["ccusperson"].ToString();
                dcreatesystime = dr["dcreatesystime"].ToString();
                iexchrate = Convert.ToDouble(tab2_iExchRate.Text);
                txtdverifysystime.Text = dr["dverifysystime"].ToString();
                txtcVerifier.Text = dr["cVerifier"].ToString();
                txtCmaker.Text = dr["cmaker"].ToString();
                txtCmakerDateTime.Text = dr["dcreatesystime"].ToString();
                txtcCloser.Text = dr["ccloser"].ToString();
                if (String.IsNullOrEmpty(dr["ccloser"].ToString()))
                {
                    tab2_toolEdit.Enabled = true;
                    tab2_toolDelete.Enabled = true;
                    tab2_toolAudit.Enabled = true;
                    tab2_toolNoAudit.Enabled = true;
                    tab2_toolClose.Text = "结案";
                    tab2_toolClose.Enabled=true;
                    tsmiRowClose.Enabled = true;
                    if (String.IsNullOrEmpty(dr["cVerifier"].ToString()))
                    {
                        tab2_toolEdit.Enabled = true;
                        tab2_toolDelete.Enabled = true;
                        tab2_toolAudit.Enabled = true;
                        tab2_toolNoAudit.Enabled = false;
                    }
                    else
                    {
                        tab2_toolEdit.Enabled = false;
                        tab2_toolDelete.Enabled = false;
                        tab2_toolAudit.Enabled = false;
                        tab2_toolNoAudit.Enabled = true;
                    }
                }
                else
                {
                    tab2_toolEdit.Enabled = false ;
                    tab2_toolDelete.Enabled = false;
                    tab2_toolAudit.Enabled = false;
                    tab2_toolNoAudit.Enabled = false;
                    tab2_toolClose.Text = "反结案";
                    tab2_toolClose.Enabled = true;
                }
               
                tab2_toolSave.Enabled = false;
                tab2_toolRowAdd.Enabled = false;
                tab2_toolRowDelete.Enabled = false;
                txtcmodifier.Text = dr["cmodifier"].ToString();
                txtdmoddate.Text = dr["dmoddate"].ToString();
            }
            dr.Close();
            dr.Dispose();
            if (delRowa == "删除1")
            {
                sql_SaleOrderSQ = "Select * ,N'' as editprop From SaleOrderSQ where id = (select isnull(Max(id),0) as MaxID from so_somain  WHERE id >0 ) order by irowno";
            }
            else
            {
                sql_SaleOrderSQ = "Select * ,N'' as editprop From SaleOrderSQ where id = " + SO_SOMain_Id + " order by irowno";
            }

            com.CommandText = sql_SaleOrderSQ;
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                SODetailsinfo s = new SODetailsinfo();
                s.cInvCode = dr["cinvcode"].ToString();
                s.cInvName = dr["cinvname"].ToString();
                s.cInvStd = dr["cInvStd"].ToString();
                s.cComUnitName = dr["cinvm_unit"].ToString();
                s.iquantity = Convert.ToDouble(dr["iquantity"] == DBNull.Value ? "0" : dr["iquantity"]);
                s.itaxunitprice = Convert.ToDouble(dr["itaxunitprice"] == DBNull.Value ? "0" : dr["itaxunitprice"]);
                s.inatunitprice = Convert.ToDouble(dr["inatunitprice"] == DBNull.Value ? "0" : dr["inatunitprice"]);
                s.iTaxRate = Convert.ToDouble(dr["itaxrate"] == DBNull.Value ? "0" : dr["itaxrate"]);
                s.isum = Convert.ToDouble(dr["isum"] == DBNull.Value ? "0" : dr["isum"]);
                s.dpredate = (Convert.ToDateTime(dr["dpredate"] == DBNull.Value ? "" : dr["dpredate"])).ToString("yyyy-MM-dd");
                s.dpremodate = (Convert.ToDateTime(dr["dpremodate"] == DBNull.Value ? "" : dr["dpremodate"])).ToString("yyyy-MM-dd");
                s.useQty = dr["cdefine33"].ToString();
                s.Cvalue = dr["cdefine22"].ToString();
                s.Cvalue11 = dr["cdefine23"].ToString();
                s.Cvalue12 = dr["cdefine31"].ToString();
                s.ctext = dr["cmemo"].ToString();
                s.SO_SODetails_isosid = Convert.ToInt32(dr["iSOsID"]);
                s.SO_SOMain_Id = Convert.ToInt32(dr["id"]);
                s.iRowNo = Convert.ToInt32(dr["iRowNo"]);
                s.borderbom = dr["borderbom"].ToString();
                s.cclose = dr["cscloser"].ToString();
                switch (dr["busecusbom"].ToString())
                {
                    case "0": s.busecusbom = "否"; break;
                    case "1": s.borderbom = "是"; break;
                }
                if ("1"==dr["idemandtype"].ToString())
                {
                    s.idemandtype = "销售订单行号";
                }
                dreleasedate = (dr["dreleasedate"] == DBNull.Value ? "" : dr["dreleasedate"]).ToString();
                tsblst.Add(s);
            }
            dr.Close();
            dr.Dispose();
            con.Close();
            tab2_dataGridView1.AutoGenerateColumns = false;
            tab2_cSTCode.ReadOnly = true;
            tab2_toolPrint.Enabled = true;
            tab2_dataGridView1.DataSource = tsblst;
            tab2_dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tab2_dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            FormatDGV(4,8);

        }
        
        #endregion

        #region 检索查询返回行数
        /// <summary>
        /// 检索查询返回行数
        /// </summary>
        /// <param name="mCoding"></param>
        /// <param name="data"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool CheckExists(int so_SOMain_Id)
        {
            bool faler = false;
            try
            {
                OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                conn.Open();
                //int n = 0;
                int ss ;
                string sql = string.Format("select top 1  id from  so_somain where id> " + so_SOMain_Id + "  order by id ASC ");
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    ss = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
                if (ss >0)
                {
                    faler = true;
                   // so_SOMain_Id = ss;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误！" + ex.Message);
            }
            finally
            {
                GC.Collect();
                GC.Collect(1);
            }
            return faler;
        }
        #endregion

        #region 双击网格事件方法
        /// <summary>
        /// 双击网格事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (tab2_toolAudit.Enabled)
            //{
            if (!txtiTaxRate.ReadOnly)
            {
                // tab2_cSTCode.ReadOnly = true;
                return;
            }
            string Cinvcode = tab2_dataGridView1.CurrentRow.Cells["colcInvCode"].Value.ToString();
            string CinvcCode = "";//母件存货大类编码
            OleDbConnection conb = new OleDbConnection(iLoginEx.ConnString());
            conb.Open();
            string sql = "select cInvCCode from Inventory where cinvcode='" + Cinvcode + "'";
            OleDbCommand com = new OleDbCommand(sql, conb);
            com.CommandText = sql;
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                CinvcCode = dr["cInvCCode"].ToString();
            }
            dr.Close();
            conb.Close();
            CinvcCode = CinvcCode.Substring(0, 2).ToString();

            if (CinvcCode == "CB")
            {
                if (tab2_dataGridView1.SelectedRows.Count > 0)//tab2_dataGridView1.SelectedCells.Count
                {
                    #region MyRegion
                    //SOaddInfo s = new SOaddInfo();
                    //string Csocode = tab2_cSOCode.Text;
                    //if (String.IsNullOrEmpty(tab2_dataGridView1.CurrentRow.Cells["colitaxunitprice"].Value.ToString()))
                    //{
                    //    s.SiQuotedPrice = 0.00;
                    //}
                    //else
                    //{
                    //    s.SiQuotedPrice = Convert.ToDouble(tab2_dataGridView1.CurrentRow.Cells["colitaxunitprice"].Value);
                    //}
                    //if (String.IsNullOrEmpty(tab2_dataGridView1.CurrentRow.Cells["coliquantity"].Value.ToString()))
                    //{
                    //    s.Siquantity = 0.00;
                    //}
                    //else
                    //{
                    //    s.Siquantity = Convert.ToDouble(tab2_dataGridView1.CurrentRow.Cells["coliquantity"].Value);
                    //}
                    //if (s.SiQuotedPrice > 0.00 && s.Siquantity > 0.00)
                    //{
                    //    s.SiSum = s.Siquantity * s.SiQuotedPrice;
                    //}
                    //else
                    //{
                    //    s.SiSum = 0.00;
                    //} 
                    #endregion
                    //总的含税单价
                    double colitaxunitpricesum = Convert.ToDouble(tab2_dataGridView1.CurrentRow.Cells["colitaxunitprice"].Value);
                   
                    frmSoAddInfo frm = new frmSoAddInfo();
                    frm.Csocode = tab2_cSOCode.Text.Trim();
                    frm.Cinvcode = Cinvcode;
                    frm.iLoginEx = iLoginEx;
                    frm.Siquantity = Convert.ToDecimal(tab2_dataGridView1.CurrentRow.Cells["coliquantity"].Value);
                    frm.isosid = Convert.ToInt32(tab2_dataGridView1.CurrentRow.Cells["coliSOsID"].Value);
                    frm.iRows = Convert.ToInt32(tab2_dataGridView1.CurrentRow.Cells["colRows"].Value);
                    frm.colitaxunitprice = colitaxunitpricesum;
                    frm.SO_SOMain_Id = Convert.ToInt32(tab2_dataGridView1.CurrentRow.Cells["colSO_SOMain_Id"].Value);
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("此物料不是套装,无法进入拆解套装");
            }
            // }
        }
        #endregion

        #region 弃审
        /// <summary>
        /// 弃审
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolNoAudit_Click(object sender, EventArgs e)
        {

            //bool b1 = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.NoAudit);
            //bool b2 = iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.NoAudit);
            //MessageBox.Show(b1.ToString() + "||" + b2.ToString());

            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.NoAudit) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.NoAudit))
            {
                iLoginEx.FormEditState(UTLoginEx.LoginEx.FormState.Initialized, null, tabControl1, "tabPage2", tab2_dataGridView1);//初始化窗口控件
                try
                {
                    int t;
                    string Nosql = "UPDATE SO_SOMain SET  cVerifier=Null, iStatus=0,dverifydate=null,dverifysystime=null,cchanger=null WHERE ID = " + SO_SOMain_Id + "";
                    OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                    conn.Open();
                    OleDbCommand comm = new OleDbCommand(Nosql, conn);
                    t = comm.ExecuteNonQuery();
                    conn.Close();
                    GC.Collect();
                    if (t > 0)
                    {
                        txtcVerifier.Text = "";
                        txtdverifysystime.Text = "";
                        tab2_toolNoAudit.Enabled = false;
                        tab2_toolAudit.Enabled = true;
                        AddRows = "审";
                        tsbtnRefurbish_Click(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误！弃审有误" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
        #endregion

        #region 审核
        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolAudit_Click(object sender, EventArgs e)
        {
            //bool b1 = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Auditing);
            //bool b2 = iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Auditing);
            //MessageBox.Show(b1.ToString()+"||"+b2.ToString());

            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Auditing) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Auditing))
            {
                if (CB_item())
                {
                    iLoginEx.FormEditState(UTLoginEx.LoginEx.FormState.Initialized, null, tabControl1, "tabPage2", tab2_dataGridView1);//初始化窗口控件
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    try
                    {
                        int t;
                        string Nosql = "UPDATE SO_SOMain SET  cVerifier=N'" + iLoginEx.UserName() + "', iStatus=1,dverifydate=case when ddate>'" + date + "' then ddate else '" + date + "' end,dverifysystime=getdate(),cchanger=null WHERE ID  = " + SO_SOMain_Id + "";
                        OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                        conn.Open();
                        OleDbCommand comm = new OleDbCommand(Nosql, conn);
                        t = comm.ExecuteNonQuery();
                        conn.Close();
                        GC.Collect();
                        if (t > 0)
                        {
                            txtcVerifier.Text = iLoginEx.UserName();
                            txtdverifysystime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            tab2_toolNoAudit.Enabled = true;
                            tab2_toolAudit.Enabled = false;
                            AddRows = "审";
                            tsbtnRefurbish_Click(null, null);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误！审核有误" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("取消操作！");
                }
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #region 在审核前判断此物料是否套装和已拆解
        /// <summary>
        /// 判断此物料是否套装和已拆解
        /// </summary>
        /// <returns></returns>
        private bool CB_item()
        {
            bool falg = false;
            OleDbConnection con = new OleDbConnection(iLoginEx.ConnString());
            con.Open();
            string SOaddInfo_sql = "";
            OleDbCommand com = new OleDbCommand(SOaddInfo_sql, con);
            List<SOaddInfo> SOaddInfo_lst = new List<SOaddInfo>();
            if (SOaddInfo_lst.Count > 0)
            {
                SOaddInfo_lst.Clear();
            }
            if (tab2_dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < tab2_dataGridView1.Rows.Count; i++)
                {
                    SOaddInfo saif = new SOaddInfo();
                    saif.Cinvcode = tab2_dataGridView1.Rows[i].Cells["colcInvCode"].Value.ToString();
                    saif.SO_SODetails_isosid = Convert.ToInt32(tab2_dataGridView1.Rows[i].Cells["coliSOsID"].Value);
                    saif.Csocode = tab2_cSOCode.Text;
                    SOaddInfo_lst.Add(saif);
                }
                List<SOaddInfo> SOaddInfo_lst_item = new List<SOaddInfo>();
                if (SOaddInfo_lst_item.Count > 0)
                {
                    SOaddInfo_lst_item.Clear();
                }
                foreach (SOaddInfo SOaddInfo_item in SOaddInfo_lst)
                {
                    SOaddInfo_sql = "select cInvCCode from Inventory where cinvcode='" + SOaddInfo_item.Cinvcode + "'";
                    com.CommandText = SOaddInfo_sql;
                    OleDbDataReader SOaddInfo_dr = com.ExecuteReader();
                    if (SOaddInfo_dr.Read())
                    {
                        SOaddInfo so_item = new SOaddInfo();
                        so_item.CInvCCode = SOaddInfo_dr["cInvCCode"].ToString();
                        so_item.CInvCCode_CB = so_item.CInvCCode.Substring(0, 2).ToString();
                        if (so_item.CInvCCode_CB == "CB")
                        {
                            so_item.Cinvcode = SOaddInfo_item.Cinvcode;
                            so_item.SO_SODetails_isosid = SOaddInfo_item.SO_SODetails_isosid;
                            so_item.Csocode = SOaddInfo_item.Csocode;
                            SOaddInfo_lst_item.Add(so_item);
                        }
                    }
                    SOaddInfo_dr.Close();
                }
                SOaddInfo a_item = new SOaddInfo();
                foreach (SOaddInfo a in SOaddInfo_lst_item)
                {
                    SOaddInfo_sql = "select Count(*) from zhrs_t_zzcSO_SOAddSeriesInfo where Csocode='" + a.Csocode + "' and Cinvcodes='" + a.Cinvcode + "'  and isosid=" + a.SO_SODetails_isosid + "";
                    com.CommandText = SOaddInfo_sql;
                    int odj = Convert.ToInt32(com.ExecuteScalar());
                    if (odj > 0)
                    {
                    }
                    else
                    {
                        a_item.Cinvcode += a.Cinvcode + " ; ";
                    }
                }
                if (String.IsNullOrEmpty(a_item.Cinvcode))
                {
                    falg = true;
                }
                else
                {
                    MessageBox.Show("必须将这些物料编码：\n" + a_item.Cinvcode + "   \n进行套装拆解,否则无法进入审核环节或打印环节！");
                    falg = false;
                }
            }
            con.Close();
            GC.Collect();
            return falg;
        }  
        #endregion

        #endregion

        #region 选定单元格的编辑模式为启动时发生
        /// <summary>
        /// 选定单元格的编辑模式为启动时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                NewCellBeginEdit(e);
            }
            else if (e.ColumnIndex == 14)
            {
                NewCellBeginEdit(e);
            }
            else
            {
                dtp.Visible = false;
            }
            /////////////////////////////////////////////////////////////
            //if (tab2_cSTCode.ReadOnly)
            //{
            //    return;
            //}
            //if (this.tab2_dataGridView1.CurrentCell.ColumnIndex == 0)
            //{
            //    string wCode = "", wName = "", sText = "";
            //    string[] para = sText.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
            //    if (para.Length > 1)
            //    {
            //        wCode = para[1];
            //    }
            //    else
            //    {
            //        wCode = sText;
            //    }
            //    string selectSQL = "";
            //    selectSQL = "SELECT cInvCode as 存货编码,cInvName as 存货名称,cInvStd as 规格型号,cInvAddCode as 存货代码,cInvABC as ABC分类,dSDate as 启用日期,cGroupName as 计量单位组名称,cComUnitName as 主计量单位名称  FROM Inventory  it LEFT JOIN ComputationGroup cg ON  cg.cGroupCode = it.cGroupCode LEFT JOIN ComputationUnit cu ON cu.cComunitCode = it.cComUnitCode  \r\n";
            //    sText = iLoginEx.OpenSelectWindow("存货基本参照", selectSQL, wCode, 1030, 500, 8);
            //    para = sText.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
            //    if (para.Length > 1)
            //    {
            //        wCode = para[0];
            //        wName = para[1];
            //        cInvCode = wCode;
            //        cInvName = wName;
            //        cInvStd = para[2];
            //        cComUnitName = para[7];
            //        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colcInvCode"].Value = wCode;
            //        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colcInvName"].Value = wName;
            //        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colcInvStd"].Value = para[2];
            //        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colcComUnitName"].Value = para[7];
            //        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coldpredate"].Value = DateTime.Now.ToString("yyyy-MM-dd");
            //        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coldpremodate"].Value = DateTime.Now.ToString("yyyy-MM-dd");

            //        LpPecSRPolicy(wCode);
            //        tab2_dataGridView1.Columns["colidemandtype"].ReadOnly = true;
            //        (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colborderbom"] as DataGridViewComboBoxCell).Value = "否";
            //        (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colbusecusbom"] as DataGridViewComboBoxCell).Value = "否";
            //        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coliTaxRate"].Value = txtiTaxRate.Text;

            //        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coliquantity"].Value = ("0").ToString();
            //        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colitaxunitprice"].Value = "0.00";
            //        //tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colisum"].Value = "0.00";
            //    }
            //} 
             if (e.ColumnIndex == 11)
            {
                string selectSQL = "select cAlias as 代码,cValue as 自定义项值 from UserDefine where cID='23'";
                ColumnText(selectSQL, 11);
            }
            else if (e.ColumnIndex == 12)
            {
                string selectSQL = "SELECT Calias as 代码,Cvalue as 自定义项值  from UserDefine where cID='45'";
                ColumnText(selectSQL, 12);
            }
            else if (e.ColumnIndex == 10)
            {
                string selectSQL = "SELECT Calias as 代码,Cvalue as 自定义项值  from UserDefine where cID='22'";
                ColumnText(selectSQL, 10);
            }
            //else if (e.ColumnIndex == 13)
            //{
            //    string selectSQL = "SELECT cid as 编号, ctext as 内容 FROM GL_bdigest";
            //    ColumnText(selectSQL, 13);
            //}
            FormatDGV(4, 8);


        } 
        #endregion

        #region 在DateGirdView控件显示时间控件
        /// <summary>
        /// 在DateGirdView控件显示时间控件
        /// </summary>
        /// <param name="e"></param>
        private void NewCellBeginEdit(DataGridViewCellCancelEventArgs e)
        {
            _Rectangle = tab2_dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //得到所在单元格位置和大小  
            dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //把单元格大小赋给时间控件  
            dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //把单元格位置赋给时间控件  
            dtp.Visible = true;  //可以显示控件了  
        } 
        private void tab2_dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;  
        }
        private void tab2_dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;  
        }
       #endregion

        #region 列的索引封装
        /// <summary>
        /// 列的索引封装
        /// </summary>
        /// <param name="e"></param>
        private void NewColumnIndex(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15)
            {
                if ("否" == (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colborderbom"] as DataGridViewComboBoxCell).Value.ToString())
                {
                    (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colbusecusbom"]as DataGridViewComboBoxCell).ReadOnly = true;
                    (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colbusecusbom"]as DataGridViewComboBoxCell).Value = "否";
                }
                else if ("是" == (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colborderbom"] as DataGridViewComboBoxCell).Value.ToString())
                {
                    (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colbusecusbom"] as DataGridViewComboBoxCell).ReadOnly = false;
                }

            }
           else  if (e.ColumnIndex == 4)
            {
                if (AddRows=="修改")
                {
                    iquantity_itaxunitprice_Index_4_5_6();

                    int isosid_4 = Convert.ToInt32(tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coliSOsID"].Value);
                    try
                    {
                        OleDbConnection con = new OleDbConnection(iLoginEx.ConnString());
                        con.Open();
                        string sql = "";
                        OleDbCommand com = new OleDbCommand(sql, con);
                        sql = "delete from zhrs_t_zzcSO_SOAddSeriesInfo where isosid=" + isosid_4 + " ";
                        com.CommandText = sql;
                        DialogResult ret = MessageBox.Show("已更改此物料套装数量，则《拆解套装详细信息表》对应的此物物料数量已变动 \n已删除,待修改保存数据后，请前往此物料进行拆解套装,以便管理", "销售管理", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        if (ret == DialogResult.OK)
                        {
                            com.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("错误！", ex.Message);
                    }
                    finally { GC.Collect(); }

                }
                else
                {
                    iquantity_itaxunitprice_Index_4_5_6();
                   
                }
               
                FormatDGV(4,8);
            }
            else if (e.ColumnIndex == 5)
            {
                switch (AddRows)
                {
                    case "修改":
                        iquantity_itaxunitprice_Index_4_5_6();
                        int isosid_4 = Convert.ToInt32(tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coliSOsID"].Value);
                        try
                        {
                            OleDbConnection con = new OleDbConnection(iLoginEx.ConnString());
                            con.Open();
                            string sql = "";
                            OleDbCommand com = new OleDbCommand(sql, con);
                            sql = "delete from zhrs_t_zzcSO_SOAddSeriesInfo where isosid=" + isosid_4 + " ";
                            com.CommandText = sql;
                            DialogResult ret = MessageBox.Show("已更改此物料套装含税单价，则《拆解套装详细信息表》对应的此物物料含税单价已变动 \n已删除,待修改保存数据后，请前往此物料进行拆解套装,以便管理", "销售管理", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            if (ret == DialogResult.OK)
                            {
                                com.ExecuteNonQuery();
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("错误！", ex.Message);
                        }
                        finally { GC.Collect(); }
                        break;
                    case "添加":
                        iquantity_itaxunitprice_Index_4_5_6();
                        break;
                }
                FormatDGV(4, 8);
             
            }
            switch (e.ColumnIndex)
            {
                     
                case 8:
                    string coldpredate = tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coldpredate"].Value.ToString();
                    if (Convert.ToDateTime(tab2_dDate.Text)>Convert.ToDateTime(coldpredate))
                    {
                        MessageBox.Show("预发货日期必须在单据日期之后，请输入正确预发货日期！");
                        dtp.Text =  DateTime.Now.ToString("yyyy-MM-dd");
                        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coldpremodate"].Value = dtp.Text;
                    }
                    break;
                case 14:
                    string coldpredate14 = tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coldpredate"].Value.ToString();
                    string coldpremodate = tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coldpremodate"].Value.ToString();
                    if (Convert.ToDateTime(coldpredate14) < Convert.ToDateTime(coldpremodate) ||Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")) > Convert.ToDateTime(coldpremodate))
                    {
                        MessageBox.Show("预完工日期必须在预发货日期之前，请输入正确预完工日期！");
                        dtp.Text = coldpredate14;
                    }
                    break;
                case 4:
                    // tab2_dataGridView1_KeyPress(null,null);
                    break;
            }
          

           
        }
        #region 计算___数量*含税单价=价税合计
        /// <summary>
        /// 计算___数量*含税单价=价税合计
        /// </summary>
        private void iquantity_itaxunitprice_Index_4_5_6()
        {
            double d4 = Convert.ToDouble(tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
            iquantity = d4;
            double d5 = Convert.ToDouble(tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
            itaxunitprice = d5;
            isum = iquantity * itaxunitprice;
            tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells[7].Value = isum.ToString();
        } 
        #endregion
        
        #endregion

        #region 单元格的值更改时发生
        /// <summary>
        /// 单元格的值更改时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            switch (AddRows)
            {
                case "修改":
                    NewColumnIndex(e);
                    break;
                case "添加":
                    NewColumnIndex(e);
                    FormatDGV(4, 8);
                    break;
            }
            if (tab2_cSTCode.ReadOnly)
            {
                return;
            }
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex < 0)
            {
                return;
            }
            int CurrentRowIndex = tab2_dataGridView1.CurrentCell.RowIndex;//当前行号
            if (e.ColumnIndex == 0)
            {
                OLEDBHelper.iLoginEx = iLoginEx;
                string selectSQL = "";
                selectSQL = " select Count(*) from Inventory where cInvCode='" + tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colcInvCode"].Value + "'";
                int n = Convert.ToInt32(OLEDBHelper.ExecuteScalar(selectSQL, CommandType.Text));
              
                if (n > 0)
                {
                    selectSQL = "SELECT cInvCode ,cInvName ,cInvStd ,cInvAddCode ,cInvABC ,dSDate ,cGroupName ,cComUnitName    \r\n";
                    selectSQL += " FROM Inventory  it   \r\n";
                    selectSQL += " LEFT JOIN ComputationGroup cg ON  cg.cGroupCode = it.cGroupCode   \r\n";
                    selectSQL += " LEFT JOIN ComputationUnit cu ON cu.cComunitCode = it.cComUnitCode   \r\n";
                    selectSQL += " where cInvCode='" + tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colcInvCode"].Value + "'  \r\n";
                    OleDbDataReader dr = OLEDBHelper.ExecuteReader(selectSQL, CommandType.Text);
                    if (dr.Read())
                    {

                        cInvCode = dr["cInvCode"].ToString();
                        cInvName = dr["cInvName"].ToString();
                        cInvStd = dr["cInvStd"].ToString();
                        cComUnitName = dr["cComUnitName"].ToString();
                        tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colcInvCode"].Value = dr["cInvCode"].ToString();
                        tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colcInvName"].Value = dr["cInvName"].ToString();
                        tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colcInvStd"].Value = dr["cInvStd"].ToString();
                        tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colcComUnitName"].Value = dr["cComUnitName"].ToString();
                        tab2_dataGridView1.Rows[CurrentRowIndex].Cells["coldpredate"].Value = DateTime.Now.ToString("yyyy-MM-dd");
                        tab2_dataGridView1.Rows[CurrentRowIndex].Cells["coldpremodate"].Value = DateTime.Now.ToString("yyyy-MM-dd");

                        LpPecSRPolicy(cInvCode);
                        tab2_dataGridView1.Columns["colidemandtype"].ReadOnly = true;
                        (tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colborderbom"] as DataGridViewComboBoxCell).Value = "否";
                        (tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colbusecusbom"] as DataGridViewComboBoxCell).Value = "否";
                        tab2_dataGridView1.Rows[CurrentRowIndex].Cells["coliTaxRate"].Value = txtiTaxRate.Text;

                        tab2_dataGridView1.Rows[CurrentRowIndex].Cells["coliquantity"].Value = ("0").ToString();
                        tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colitaxunitprice"].Value = "0.00";
                    }
                    dr.Close();
                    OLEDBHelper.CloseCon();
                }
                else
                {
                   
                    tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colcInvCode"].Value = "";
                    MessageBox.Show("该物料不存在！");
                    //cInvCode = "";
                    //cInvName = "";
                    //cInvStd = "";
                    //cComUnitName = "";
                    //tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colcInvCode"].Value = "";
                    //tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colcInvName"].Value = "";
                    //tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colcInvStd"].Value = "";
                    //tab2_dataGridView1.Rows[CurrentRowIndex].Cells["colcComUnitName"].Value = "";
                   
                    
                     
                   
                    
                  
                }
            }

        } 
        #endregion

        #region 单击单元格
        /// <summary>
        /// 单击单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tab2_cSTCode.ReadOnly)
            {
                return;
            }
            switch (AddRows)
            {
                case "修改":
                    string colcInvCodeLpPe = tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colcInvCode"].Value == null ? "" : tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colcInvCode"].Value.ToString();
                    LpPecSRPolicy(colcInvCodeLpPe);
                    break;
            }
        } 
        #endregion

        #region Esc撤销编辑
        /// <summary>
        /// Esc撤销编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbEsc_Click(object sender, EventArgs e)
        {
            if (txtiTaxRate.ReadOnly)
            {
                return;
            }
            tsbEscClose();

        }
        
        #endregion

        #region 结案
        /// <summary>
        /// 结案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolClose_Click(object sender, EventArgs e)
        {
            //bool b1 = iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Close);
            //bool b2 = iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Closed);
            //MessageBox.Show(b1.ToString() + "||" + b2.ToString());

            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Close) && iLoginEx.CheckFormAuthorityDetail(iLoginEx.UserId(), iLoginEx.UserName(), AuthID, LoginEx.FormAuthDetailType.Closed))
            {
                string tsmiclose = tab2_toolClose.Text;

                string dbclosedate = DateTime.Now.ToString("yyyy-MM-dd");//关闭日期
                string sqlcClose = "";
                OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                conn.Open();
                try
                {
                    OleDbCommand comm = new OleDbCommand(sqlcClose, conn);


                    switch (tsmiclose)
                    {
                        case "结案":
                            sqlcClose = "Update SO_SODetails set cSCloser=N'" + iLoginEx.UserName() + "',dbclosedate='" + dbclosedate + "',dbclosesystime=getdate() Where Id=" + SO_SOMain_Id + " \r\n";
                            sqlcClose += "Update SO_SOMain Set cCloser=N'" + iLoginEx.UserName() + "' where id= " + SO_SOMain_Id + " \r\n";
                            comm.CommandText = sqlcClose;
                            if (comm.ExecuteNonQuery() > 0)
                            {

                                tab2_toolClose.Text = "反结案";
                                txtcCloser.Text = iLoginEx.UserName();
                                tab2_toolNoAudit.Enabled = false;
                                tsmiRowClose.Enabled = false;  

                               

                                tab2_toolEdit.Enabled = false;
                                tab2_toolDelete.Enabled = false;
                                tab2_toolAudit.Enabled = false;
                                tsbtnRefurbish_Click(null, null);
                            }
                            else
                            {
                                MessageBox.Show("整单结案失败！");
                            }
                            break;
                        case "反结案":
                            sqlcClose = "Update SO_SODetails set cSCloser=N'',dbclosedate='',dbclosesystime='' Where Id=" + SO_SOMain_Id + " \r\n";
                            sqlcClose += "Update SO_SOMain Set cCloser=N'' where id= " + SO_SOMain_Id + " \r\n";
                            comm.CommandText = sqlcClose;
                            if (comm.ExecuteNonQuery() > 0)
                            { 
                                tab2_toolClose.Text = "结案";
                                txtcCloser.Text = "";
                                tab2_toolAudit.Enabled = true;
                                tab2_toolNoAudit.Enabled = true;
                                
                                tab2_toolEdit.Enabled = true;
                                tab2_toolDelete.Enabled = true;
                            
                                tsmiRowClose.Enabled = true;
                              tsbtnRefurbish_Click(null, null);
                            }
                            else
                            {
                                MessageBox.Show("整单打开失败！");
                            }
                            break;
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误！结案" + ex.Message);
                }
                finally
                {
                    conn.Close();
                    GC.Collect();
                }
               
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
        #endregion

        #region 关闭单行
        /// <summary>
        /// 关闭单行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRowClose_Click(object sender, EventArgs e)
        {
            
        } 
        #endregion

        #region 打印单击事件

        /// <summary>
        /// 打印单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_toolPrint_Click(object sender, EventArgs e)
        {
            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.Print))
            {
                if (CB_item())
                {
                   frmReport frm = new frmReport();
                frm.iLoginEx = iLoginEx;
                frm.SO_SOMain_Id = SO_SOMain_Id;
                frm.Show();
                }
                else
                {
                    MessageBox.Show("操作取消！");
                }
               
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
        #endregion
       
        #region 销售订单列表查询
        /// <summary>
        /// 销售订单列表查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {

            try
            {
                iLoginEx.WriteUserProfileValue("SO311", "txtcsocode", txtcsocode.Text.Trim());
                iLoginEx.WriteUserProfileValue("SO311", "txtcpersonname", txtcpersonname.Text.Trim());
                iLoginEx.WriteUserProfileValue("SO311", "txtccusabbname", txtccusabbname.Text.Trim());
             
                iLoginEx.WriteUserProfileValue("SO311", "cbfind", cbfind.Checked == true ? "1" : "0");
                this.Text += "      正在查询,请稍后......";
                DataTable dt = new DataTable();
                string sqlwhere = "";
                string sqltop = "";
                string sqlend = "";
                if (cbfind.Checked)
                {
                    iLoginEx.WriteUserProfileValue("SO311", "dtpBigen", dtpBigen.Text);
                    iLoginEx.WriteUserProfileValue("SO311", "cbsuit", cbsuit.Checked == true ? "1" : "0");

                    if (String.IsNullOrEmpty(txtccusabbname.Text.Trim()) && String.IsNullOrEmpty(txtcpersonname.Text.Trim()))
                    {
                         sqlwhere = " where ((dDate >= N'" + dtpBigen.Text + "') And (dDate <= N'" + dtpend.Text + "')) ";
                    }
                    else if (!String.IsNullOrEmpty(txtccusabbname.Text.Trim()) && String.IsNullOrEmpty(txtcpersonname.Text.Trim()))//根据客户简称查询套装
                    {
                        
                        if (cbsuit.Checked)
                        {
                            sqltop = "select * from (";
                            sqlwhere = "left join Inventory i on sqs.cInvCode=i.cInvCode   \r\n";
                            sqlwhere += " where ((dDate >= N'" + dtpBigen.Text + "') And (dDate <= N'" + dtpend.Text + "')) and sq.ccusabbname like '%" + txtccusabbname.Text.Trim() + "%' and i.cInvCcode like 'CB%'   \r\n";
                            sqlend = ")a where not exists (select * from zhrs_t_zzcSO_SOAddSeriesInfo zt where a.Csocode= zt.Csocode and a.Cinvcode=zt.Cinvcodes and a.isosid=zt.isosid)";
                        }
                        else
                        {
                            sqlwhere = "left join Inventory i on sqs.cInvCode=i.cInvCode   \r\n";
                            sqlwhere += " where ((dDate >= N'" + dtpBigen.Text + "') And (dDate <= N'" + dtpend.Text + "')) and sq.ccusabbname like '%" + txtccusabbname.Text.Trim() + "%' and i.cInvCcode like 'CB%'   \r\n";
                        }
                    }
                    else if (!String.IsNullOrEmpty(txtcpersonname.Text.Trim()) && String.IsNullOrEmpty(txtccusabbname.Text.Trim()))//根据业务员查询套装
                    {
                       
                        if (cbsuit.Checked)
                        {
                            sqltop = "select * from (";
                            sqlwhere = "left join Inventory i on sqs.cInvCode=i.cInvCode   \r\n";
                            sqlwhere += " where ((dDate >= N'" + dtpBigen.Text + "') And (dDate <= N'" + dtpend.Text + "')) and sq.cpersonname like '%" + txtcpersonname.Text.Trim() + "%' and i.cInvCcode like 'CB%'   \r\n";
                            sqlend = ")a where not exists (select * from zhrs_t_zzcSO_SOAddSeriesInfo zt where a.Csocode= zt.Csocode and a.Cinvcode=zt.Cinvcodes and a.isosid=zt.isosid)";
                        }
                        else
                        {
                            sqlwhere = "left join Inventory i on sqs.cInvCode=i.cInvCode   \r\n";
                            sqlwhere += " where ((dDate >= N'" + dtpBigen.Text + "') And (dDate <= N'" + dtpend.Text + "')) and sq.cpersonname like '%" + txtcpersonname.Text.Trim() + "%' and i.cInvCcode like 'CB%'   \r\n";
                        }

                    }
                    else if (!String.IsNullOrEmpty(txtcpersonname.Text.Trim()) && !String.IsNullOrEmpty(txtccusabbname.Text.Trim()))//根据业务员和客户简称查询套装
                    {
                        if (cbsuit.Checked)
                        {
                            sqltop = "select * from (";
                            sqlwhere = "left join Inventory i on sqs.cInvCode=i.cInvCode   \r\n";
                            sqlwhere += " where ((dDate >= N'" + dtpBigen.Text + "') And (dDate <= N'" + dtpend.Text + "')) and sq.ccusabbname like '%" + txtccusabbname.Text.Trim() + "%' and sq.cpersonname like '%" + txtcpersonname.Text.Trim() + "%' and i.cInvCcode like 'CB%'   \r\n";
                            sqlend = ")a where not exists (select * from zhrs_t_zzcSO_SOAddSeriesInfo zt where a.Csocode= zt.Csocode and a.Cinvcode=zt.Cinvcodes and a.isosid=zt.isosid)";
                        }
                        else
                        {
                            sqlwhere = "left join Inventory i on sqs.cInvCode=i.cInvCode   \r\n";
                            sqlwhere += " where ((dDate >= N'" + dtpBigen.Text + "') And (dDate <= N'" + dtpend.Text + "')) and sq.ccusabbname like '%" + txtccusabbname.Text.Trim() + "%' and sq.cpersonname like '%" + txtcpersonname.Text.Trim() + "%' and i.cInvCcode like 'CB%'   \r\n";
                        }
                    }
                    else
                    {
                        sqlwhere = " where ((dDate >= N'" + dtpBigen.Text + "') And (dDate <= N'" + dtpend.Text + "')) ";
                    }       
                }
                else
                {

                    if (!String.IsNullOrEmpty(txtcsocode.Text.Trim()) && String.IsNullOrEmpty(txtcpersonname.Text.Trim()) && String.IsNullOrEmpty(txtccusabbname.Text.Trim()))
                    {
                        sqlwhere = "where sq.csocode='" + txtcsocode.Text.Trim() + "' And ((dDate >= N'" + iLoginEx.iYear() + "-01-01') And (dDate <= N'" + iLoginEx.iYear() + "-12-31'))";
                    }
                    else if (String.IsNullOrEmpty(txtcsocode.Text.Trim()) && !String.IsNullOrEmpty(txtcpersonname.Text.Trim()) && String.IsNullOrEmpty(txtccusabbname.Text.Trim()))
                    {
                        sqlwhere = "where sq.cpersonname='" + txtcpersonname.Text.Trim() + "' And ((dDate >= N'" + iLoginEx.iYear() + "-01-01') And (dDate <= N'" + iLoginEx.iYear() + "-12-31'))";
                    }
                    else if (String.IsNullOrEmpty(txtcsocode.Text.Trim()) && String.IsNullOrEmpty(txtcpersonname.Text.Trim()) && !String.IsNullOrEmpty(txtccusabbname.Text.Trim()))
                    {
                        sqlwhere = "where sq.ccusabbname like '%" + txtccusabbname.Text.Trim() + "%' And ((dDate >= N'" + iLoginEx.iYear() + "-01-01') And (dDate <= N'" + iLoginEx.iYear() + "-12-31'))";
                    }
                    else if (!String.IsNullOrEmpty(txtcsocode.Text.Trim()) && !String.IsNullOrEmpty(txtcpersonname.Text.Trim()) && String.IsNullOrEmpty(txtccusabbname.Text.Trim()))
                    {
                        sqlwhere = "where sq.csocode='" + txtcsocode.Text.Trim() + "' and sq.cpersonname='" + txtcpersonname.Text.Trim() + "' And ((dDate >= N'" + iLoginEx.iYear() + "-01-01') And (dDate <= N'" + iLoginEx.iYear() + "-12-31')) ";
                    }
                    else if (!String.IsNullOrEmpty(txtcsocode.Text.Trim()) && String.IsNullOrEmpty(txtcpersonname.Text.Trim()) && !String.IsNullOrEmpty(txtccusabbname.Text.Trim()))
                    {
                        sqlwhere = "where sq.csocode='" + txtcsocode.Text.Trim() + "' and sq.ccusabbname like '%" + txtccusabbname.Text.Trim() + "%' And ((dDate >= N'" + iLoginEx.iYear() + "-01-01') And (dDate <= N'" + iLoginEx.iYear() + "-12-31')) ";
                    }
                    else if (String.IsNullOrEmpty(txtcsocode.Text.Trim()) && !String.IsNullOrEmpty(txtcpersonname.Text.Trim()) && !String.IsNullOrEmpty(txtccusabbname.Text.Trim()))
                    {
                        sqlwhere = "where sq.cpersonname='" + txtcpersonname.Text.Trim() + "' and sq.ccusabbname like '%" + txtccusabbname.Text.Trim() + "%' And ((dDate >= N'" + iLoginEx.iYear() + "-01-01') And (dDate <= N'" + iLoginEx.iYear() + "-12-31')) ";
                    }
                    else if (!String.IsNullOrEmpty(txtcsocode.Text.Trim()) && !String.IsNullOrEmpty(txtcpersonname.Text.Trim()) && !String.IsNullOrEmpty(txtccusabbname.Text.Trim()))
                    {
                        sqlwhere = "where sq.csocode='" + txtcsocode.Text.Trim() + "' and sq.cpersonname='" + txtcpersonname.Text.Trim() + "' and sq.ccusabbname like '%" + txtccusabbname.Text.Trim() + "%' And ((dDate >= N'" + iLoginEx.iYear() + "-01-01') And (dDate <= N'" + iLoginEx.iYear() + "-12-31')) ";
                    }
                    else
                    {
                        sqlwhere = "where ((dDate >= N'" + iLoginEx.iYear() + "-01-01') And (dDate <= N'" + iLoginEx.iYear() + "-12-31')) ";
                    }
                }

                string sosqlList = " \r\n";
                sosqlList = "" + sqltop + "select sq.cbustype,sq.cstname,sq.csocode,sq.ddate ,sq.ccusabbname,sq.cexch_name,sq.iexchrate,sq.cdepname,sq.cpersonname,    \r\n";
                sosqlList += " sqs.cInvCode,sqs.cInvName,sqs.cInvStd,sqs.cinvm_unit,sqs.iquantity,sqs.itaxunitprice,sqs.iUnitPrice,sqs.iMoney,sqs.itax,sqs.isum,sqs.iTaxRate,sqs.isosid,sqs.id,sqs.irowno     \r\n";
                sosqlList += " from SaleOrderQ sq inner join SaleOrderSQ sqs on sq.id=sqs.id " + sqlwhere + "     \r\n";
                sosqlList += " " + sqlend + "  \r\n";
                dt = OLEDBHelper.GetDataTalbe(sosqlList, CommandType.Text);

                dgvSaleOrderList.AutoGenerateColumns = false;
                dgvSaleOrderList.DataSource = dt;//ds.Tables["sosqlList"];
                lblfindSum.Text = "总记录数: " + dt.Rows.Count.ToString();
                dgvSaleOrderList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvSaleOrderList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                for (int i = 12; i <= 19; i++)
                {
                    if (i == 12 || i == 14 || i == 15)
                        dgvSaleOrderList.Columns[i].DefaultCellStyle.Format = "#,###0.0000";
                    else if (i == 13)
                        dgvSaleOrderList.Columns[i].DefaultCellStyle.Format = "#,###0.000";
                    else
                    {
                        dgvSaleOrderList.Columns[i].DefaultCellStyle.Format = "#,###0.00";
                    }
                    dgvSaleOrderList.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                gbcinvNameCount.Text = "存货名称查询(可以模糊查询)";
                btnSuitFind.Text = "套装查询";
                this.Text = "套装销售订单   " + System.Windows.Forms.Application.ProductVersion;
                SuitFind_CinvName = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
        } 
        #endregion

        #region dgvSaleOrderList双击事件
        /// <summary>
        /// dgvSaleOrderList双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSaleOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            csocode = dgvSaleOrderList.CurrentRow.Cells["colcsocode"].Value.ToString();
            AddRows = "查询";
            tsbtnRefurbish_Click(null, null);
            tabControl1.SelectedIndex = 1;
        } 
        #endregion

        #region 只能输入数字
        /// <summary>
        /// 只能输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtiTaxRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberKeyPress(e);
        }

        private static void NumberKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 58) && (e.KeyChar != 8) && (e.KeyChar != 46))
                e.Handled = true;
        }

        private void frm311_FormClosing(object sender, FormClosingEventArgs e)
        {
            tsbEsc_Click(null, null);
        }

        #region MyRegion
       
        private void cbfind_CheckedChanged(object sender, EventArgs e)
        {
            if (cbfind.Checked)
            {
                dtpBigen.Enabled = true;
                dtpend.Enabled = true;
            }
            else
            {
                dtpBigen.Enabled = false;
                dtpend.Enabled = false;
            }
        }
        /// <summary>
        /// 显示用于编辑单元格触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.tab2_dataGridView1.CurrentCell.ColumnIndex == 4 || this.tab2_dataGridView1.CurrentCell.ColumnIndex == 5 || this.tab2_dataGridView1.CurrentCell.ColumnIndex == 6 )
            {
                e.Control.KeyPress += new KeyPressEventHandler(EditingControl_KeyPress);
            }
           
        }
        /// <summary>
        /// 单元格只能输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.tab2_dataGridView1.CurrentCell.ColumnIndex == 4 || this.tab2_dataGridView1.CurrentCell.ColumnIndex == 5 || this.tab2_dataGridView1.CurrentCell.ColumnIndex == 6)
            {
                if ((e.KeyChar < 47 || e.KeyChar > 58) && (e.KeyChar != 8) && (e.KeyChar != 46))
                e.Handled = true;
                FormatDGV(4, 8);
            }
            else
            {
                e.Handled = false;
            }
        }

       
        #endregion

       
        /// <summary>
        /// 识别是否BOM方法
        /// </summary>
        /// <param name="wCode"></param>
        private void LpPecSRPolicy(string wCode)
        {
            OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
            conn.Open();
            string LpEpsql = "select top 1 cSRPolicy from Inventory where cinvCode ='" + wCode + "'";
            OleDbCommand comm = new OleDbCommand(LpEpsql, conn);
            OleDbDataReader dr = comm.ExecuteReader();
            string cSRPolicy = "";
            if (dr.Read())
            {
                cSRPolicy = dr["cSRPolicy"].ToString();
            }
            dr.Close();
            conn.Close();

            switch (cSRPolicy)
            {
                case "LP":
                    (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colborderbom"] as DataGridViewComboBoxCell).ReadOnly = false;
                    tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colidemandtype"].Value = "销售订单行号";
                    break;
                case "PE":
                    (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colborderbom"] as DataGridViewComboBoxCell).ReadOnly = true;
                    (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colbusecusbom"] as DataGridViewComboBoxCell).ReadOnly = true;
                    tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colidemandtype"].Value = "";
                    break;
            }
        } 
          #endregion

        #region 各类双击触发事件
        /// <summary>
        /// 各类双击触发事件
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="i"></param>
        private void ColumnText(string sql, int i)
        {

            string wCode = "", wName = "", sText = "";
            string[] para = sText.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
            if (para.Length > 1)
            {
                wCode = para[1];
                //wName = para[0];  
            }
            else
            {
                wCode = sText;
            }
            string selectSQL = sql;
            sText = iLoginEx.OpenSelectWindow("基本参照", selectSQL, wCode, 330, 300, 2);
            para = sText.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
            if (para.Length > 1)
            {
                wName = para[1];

                if (i == 10)
                {
                    tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colCvalue"].Value = wName;
                    Cvalue = wName;
                }
                else if (i == 11)
                {
                    tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colCvalue11"].Value = wName;
                    Cvalue11 = wName;
                   
                }
                else if (i == 12)
                {
                    tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colCvalue12"].Value = wName;
                    Cvalue12 = wName;
                    
                }
                //else if (i == 13)
                //{
                //    tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colctext"].Value = wName;
                //    ctext = wName;
                    
                //}

                
            }

        }
        #endregion

        #region 转拆套装
        /// <summary>
        /// 转拆套装
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmisale_CB_SG_Click(object sender, EventArgs e)
        {
            if (txtiTaxRate.ReadOnly)
            {
                tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Selected = true;
            }
            tab2_dataGridView1_CellDoubleClick(null, null);
        } 
        #endregion

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtccusabbname.Clear();
            txtcpersonname.Clear();
            txtcsocode.Clear();
               
        }
        #region 已拆套装销售列表
     
        /// <summary>
        /// 已拆套装销售列表
        /// </summary>
        private void dgvSplitsingle_Load(int n,string str_order,int pageSize,string wsql)
        {
            iLoginEx.WriteUserProfileValue("SO311", "cobNumber", cobNumber.Text);
            DataTable dt_1_zzc = new DataTable();
            OLEDBHelper.iLoginEx = iLoginEx;
            //string Splitsingle_sql = "select Csocode as '订单号',Cinvcodes as '母件存货编码',Cinvcode as '子件存货编码',CinvName as '子件存货名称',Cinvstd as '子件规格型号',CcomunitName as '单位', \r\n";
            //Splitsingle_sql += " cInvCCode as '子件存货大类编码',COption1 as '区分手动录入或系统分配',COption2 as '业务员',SAddDate as '录入时间',BaseQtyND as '使用数量',Ciquantity as '需使用总数量',SiQuotedPrice as '单价',SiSum as '金额'  \r\n";
            //Splitsingle_sql += "from zhrs_t_zzcSO_SOAddSeriesInfo  " + wsql + " order by SAddDate desc \r\n";
            //
            //string Splitsingle_sql = "select top " + pageSize + " rownumber as '顺序编号',Csocode as '订单号',Cinvcodes as '母件存货编码',Cinvcode as '子件存货编码',CinvName as '子件存货名称',Cinvstd as '子件规格型号',CcomunitName as '单位',   \r\n";
            //Splitsingle_sql += " cInvCCode as '子件存货大类编码',COption1 as '区分手动录入或系统分配',COption2 as '业务员',SAddDate as '录入时间',BaseQtyND as '使用数量',  \r\n";
            //Splitsingle_sql += " Ciquantity as '需使用总数量',SiQuotedPrice as '单价',SiSum as '金额' from (  \r\n";
            //Splitsingle_sql += " select row_number()over(order by " + str_order + " )as rownumber, * from(  \r\n";
            //Splitsingle_sql += " select Csocode,Cinvcodes,Cinvcode,CinvName,Cinvstd ,CcomunitName,   \r\n";
            //Splitsingle_sql += " cInvCCode,COption1,COption2,SAddDate,BaseQtyND,  \r\n";
            //Splitsingle_sql += " Ciquantity,SiQuotedPrice,SiSum    \r\n";
            //Splitsingle_sql += " from zhrs_t_zzcSO_SOAddSeriesInfo) aa  \r\n";
            //Splitsingle_sql += " ) a where  rownumber>"+n+"   \r\n";

            string Splitsingle_sql = "select top " + pageSize + " * from (    \r\n";
            Splitsingle_sql += "  select row_number()over(order by " + str_order + " ) as rownumber , * from(    \r\n";
            Splitsingle_sql += "  select Csocode as '订单号',Cinvcodes as '母件存货编码',Cinvcode as '子件存货编码',CinvName as '子件存货名称',Cinvstd as '子件规格型号',CcomunitName as '单位',     \r\n";
            Splitsingle_sql += "  cInvCCode as '子件存货大类编码',COption1 as '区分手动录入或系统分配',COption2 as '拆单员',SAddDate as '录入时间',BaseQtyND as '使用数量',    \r\n";
            Splitsingle_sql += "  Ciquantity as '需使用总数量',SiQuotedPrice as '单价',SiSum as '金额'     \r\n";
            Splitsingle_sql += "  from zhrs_t_zzcSO_SOAddSeriesInfo " + wsql + ") aa    \r\n";
            Splitsingle_sql += "  ) a where  rownumber>" + n + "    \r\n";
            dt_1_zzc = OLEDBHelper.GetDataTalbe(Splitsingle_sql, CommandType.Text);
            dgvSplitsingle.DataSource = dt_1_zzc;

            //List<zhrs_t_zzcSO_SOAddSeriesInfo> getlst = new List<zhrs_t_zzcSO_SOAddSeriesInfo>();
            //OleDbDataReader getlst_dr = OLEDBHelper.ExecuteReader(Splitsingle_sql, CommandType.Text);
            //while (getlst_dr.Read())
            //{
            //    getlst.Add(new zhrs_t_zzcSO_SOAddSeriesInfo()
            //    {
            //        Csocode = getlst_dr["Csocode"].ToString(),
            //        Cinvcodes = getlst_dr["Cinvcodes"].ToString(),
            //        Cinvcode = getlst_dr["Cinvcode"].ToString(),
            //        CinvName = getlst_dr["CinvName"].ToString(),
            //        Cinvstd = getlst_dr["Cinvstd"].ToString(),
            //        CcomunitName = getlst_dr["CcomunitName"].ToString(),
            //        cInvCCode = getlst_dr["cInvCCode"].ToString(),
            //        COption1 = getlst_dr["COption1"].ToString(),
            //        COption2 = getlst_dr["COption2"].ToString(),
            //        SAddDate = Convert.ToDateTime(getlst_dr["SAddDate"]),
            //        BaseQtyND = Convert.ToDecimal(getlst_dr["BaseQtyND"]),
            //        Ciquantity = Convert.ToDecimal(getlst_dr["Ciquantity"]),
            //        SiQuotedPrice = Convert.ToDecimal(getlst_dr["SiQuotedPrice"]),
            //        SiSum = Convert.ToDecimal(getlst_dr["SiSum"]),
            //    });
            //}
            //getlst_dr.Close();
            //OLEDBHelper.CloseCon();

            
            dgvSplitsingle.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvSplitsingle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            for (int i = 11; i < 15; i++)
            {
                if (i == 10 || i == 11)
                    dgvSplitsingle.Columns[i].DefaultCellStyle.Format = "#,###0.000";
                else if (i == 12)
                    dgvSplitsingle.Columns[i].DefaultCellStyle.Format = "#,###0.0000";
                else
                {
                    dgvSplitsingle.Columns[i].DefaultCellStyle.Format = "#,###0.00";
                }
                dgvSplitsingle.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        } 
        #endregion

        private void btnEndless_Click(object sender, EventArgs e)
        {
            frmEndless frm = new frmEndless();
            frm.iLoginEx = iLoginEx;
            frm.ShowDialog();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            wsql = "";
            txtzzcCsoCode.Clear();
            homepage_Click(null, null);
        }

        #region 存货查询
        public string SuitFind_CinvName = "";

        /// <summary>
        /// 存货查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCinvName_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text += "      正在查询,请稍后......";
                DataTable dt = new DataTable();
                iLoginEx.WriteUserProfileValue("SO311", "txtCinvName", txtCinvName.Text.Trim());
                if (String.IsNullOrEmpty(txtCinvName.Text.Trim()))
                {
                    this.Text = "套装销售订单   " + System.Windows.Forms.Application.ProductVersion;
                    btnSuitFind.Text = "套装查询";
                    MessageBox.Show("请输入存货名称！");
                    txtCinvName.Focus();
                    return;
                }
                OLEDBHelper.iLoginEx = iLoginEx;
                string selectSQL = "";
                selectSQL = "select * from (select sq.cbustype,sq.cstname,sq.csocode,sq.ddate ,sq.ccusabbname,sq.cexch_name,sq.iexchrate,sq.cdepname,sq.cpersonname,    \r\n";
                selectSQL += "  sqs.cInvCode,sqs.cInvName,sqs.cInvStd,sqs.cinvm_unit,sqs.iquantity,sqs.itaxunitprice,sqs.iUnitPrice,sqs.iMoney,sqs.itax,sqs.isum,sqs.iTaxRate,sqs.isosid ,sqs.id,sqs.irowno    \r\n";
                selectSQL += "   from SaleOrderQ sq inner join SaleOrderSQ sqs on sq.id=sqs.id where  sqs.cInvName  like '%" + txtCinvName.Text.Trim() + "%'      \r\n";
                selectSQL += "   And ((dDate >= N'" + iLoginEx.iYear() + "-01-01') And (dDate <= N'" + iLoginEx.iYear() + "-12-31')))a where   \r\n";
                selectSQL += " not exists (select * from zhrs_t_zzcSO_SOAddSeriesInfo zt where a.Csocode= zt.Csocode and a.Cinvcode=zt.Cinvcodes and a.isosid=zt.isosid )    \r\n";
                dt = OLEDBHelper.GetDataTalbe(selectSQL, CommandType.Text);
                dgvSaleOrderList.AutoGenerateColumns = false;
                dgvSaleOrderList.DataSource = dt;//ds.Tables["sosqlList"];
                dgvSaleOrderList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvSaleOrderList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                for (int i = 12; i <= 19; i++)
                {
                    if (i == 12 || i == 14 || i == 15)
                        dgvSaleOrderList.Columns[i].DefaultCellStyle.Format = "#,###0.0000";
                    else if (i == 13)
                        dgvSaleOrderList.Columns[i].DefaultCellStyle.Format = "#,###0.000";
                    else
                    {
                        dgvSaleOrderList.Columns[i].DefaultCellStyle.Format = "#,###0.00";
                    }
                    dgvSaleOrderList.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                gbcinvNameCount.Text = "存货名称查询(可以模糊查询)  总记录数：" + dt.Rows.Count.ToString();
                lblfindSum.Text = "";
                btnSuitFind.Text = "套装查询";
                this.Text = "套装销售订单   " + System.Windows.Forms.Application.ProductVersion;
                SuitFind_CinvName = "存货查询";
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
        } 
        #endregion

        #region 套装查询
        /// <summary>
        /// 套装查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuitFind_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text += "                        正在查询,请稍后......";
                DataTable dt = new DataTable();
                OLEDBHelper.iLoginEx = iLoginEx;
                string selectSQL = "select * from (select sq.cbustype,sq.cstname,sq.csocode,sq.ddate ,sq.ccusabbname,sq.cexch_name,sq.iexchrate,sq.cdepname,sq.cpersonname,    \r\n";
                selectSQL += "  sqs.cInvCode,i.cInvCcode,sqs.cInvName,sqs.cInvStd,sqs.cinvm_unit,sqs.iquantity,sqs.itaxunitprice,sqs.iUnitPrice,sqs.iMoney,sqs.itax,sqs.isum,sqs.iTaxRate,sqs.isosid ,sqs.id,sqs.irowno    \r\n";
                selectSQL += "   from SaleOrderQ sq left join SaleOrderSQ sqs on sq.id=sqs.id   \r\n";
                selectSQL += " left join Inventory i on sqs.cInvCode=i.cInvCode   \r\n";
                selectSQL += " where i.cInvCcode like 'CB%'           --sqs.cInvName  like '%套装%'      \r\n";
                selectSQL += " And ((dDate >= N'" + iLoginEx.iYear() + "-01-01') And (dDate <= N'" + iLoginEx.iYear() + "-12-31')))a where   \r\n";
                selectSQL += " not exists (select * from zhrs_t_zzcSO_SOAddSeriesInfo zt where a.Csocode= zt.Csocode and a.Cinvcode=zt.Cinvcodes and a.isosid=zt.isosid )    \r\n";
                dt = OLEDBHelper.GetDataTalbe(selectSQL, CommandType.Text);
                dgvSaleOrderList.AutoGenerateColumns = false;
                dgvSaleOrderList.DataSource = dt;//ds.Tables["sosqlList"];
                dgvSaleOrderList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvSaleOrderList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                for (int i = 12; i <= 19; i++)
                {
                    if (i == 12 || i == 14 || i == 15)
                        dgvSaleOrderList.Columns[i].DefaultCellStyle.Format = "#,###0.0000";
                    else if (i == 13)
                        dgvSaleOrderList.Columns[i].DefaultCellStyle.Format = "#,###0.000";
                    else
                    {
                        dgvSaleOrderList.Columns[i].DefaultCellStyle.Format = "#,###0.00";
                    }
                    dgvSaleOrderList.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                gbcinvNameCount.Text = "存货名称查询(可以模糊查询)";
                btnSuitFind.Text = "套装查询    总记录数：" + dt.Rows.Count.ToString();
                lblfindSum.Text = "";
                this.Text = "套装销售订单   " + System.Windows.Forms.Application.ProductVersion;
                SuitFind_CinvName = "套装查询";
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
        } 
        #endregion

        #region 拆套装
        private void tsmiRemoveSuit_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSaleOrderList.Rows[dgvSaleOrderList.CurrentCell.RowIndex].Selected = true;
                if (dgvSaleOrderList.SelectedRows.Count > 0)
                {
                    string tsmi_Csocode = dgvSaleOrderList.Rows[dgvSaleOrderList.CurrentCell.RowIndex].Cells["colcsocode"].Value.ToString();
                    string colcInvCodes = dgvSaleOrderList.Rows[dgvSaleOrderList.CurrentCell.RowIndex].Cells["colcInvCodes"].Value.ToString();
                    decimal coliquantitys = Convert.ToDecimal(dgvSaleOrderList.Rows[dgvSaleOrderList.CurrentCell.RowIndex].Cells["coliquantitys"].Value);
                    double colitaxunitprices = Convert.ToDouble(dgvSaleOrderList.Rows[dgvSaleOrderList.CurrentCell.RowIndex].Cells["colitaxunitprices"].Value);
                    int isosid = Convert.ToInt32(dgvSaleOrderList.Rows[dgvSaleOrderList.CurrentCell.RowIndex].Cells["colso_isosid"].Value);
                    int iRows = Convert.ToInt32(dgvSaleOrderList.Rows[dgvSaleOrderList.CurrentCell.RowIndex].Cells["colso_iRows"].Value);
                    int SO_SOMain_Id = Convert.ToInt32(dgvSaleOrderList.Rows[dgvSaleOrderList.CurrentCell.RowIndex].Cells["colSOMain_Id"].Value);
                    RemoveSuit(tsmi_Csocode, colcInvCodes, coliquantitys, colitaxunitprices, isosid, iRows, SO_SOMain_Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
        }
        /// <summary>
        /// 拆套装,
        /// tsmi_Csocode 订单号,colcInvCodes  母存货编码,coliquantitys  数量  ,colitaxunitprices  含税单价  ,isosid  子Id,iRows  子行号,SO_SOMain_Id  母id
        /// </summary>
        /// <param name="tsmi_Csocode">订单号</param>
        /// <param name="colcInvCodes">母存货编码</param>
        /// <param name="coliquantitys">数量</param>
        /// <param name="colitaxunitprices">含税单价</param>
        /// <param name="isosid">子Id</param>
        /// <param name="iRows">子行号</param>
        /// <param name="SO_SOMain_Id">母id</param>
        private void RemoveSuit(string tsmi_Csocode, string colcInvCodes, decimal coliquantitys, double colitaxunitprices, int isosid, int iRows, int SO_SOMain_Id)
        {
            try
            {
                OLEDBHelper.iLoginEx = iLoginEx;
                string Cinvcode = colcInvCodes;
                string CinvcCode = "";//母件存货大类编码
                string sql = "select cInvCCode from Inventory where cinvcode='" + Cinvcode + "'";
                OleDbDataReader dr = OLEDBHelper.ExecuteReader(sql, CommandType.Text);
                if (dr.Read())
                {
                    CinvcCode = dr["cInvCCode"].ToString();
                }
                dr.Close();
                OLEDBHelper.CloseCon();
                CinvcCode = CinvcCode.Substring(0, 2).ToString();
                if (CinvcCode == "CB")
                {
                    if (dgvSaleOrderList.SelectedRows.Count > 0)
                    {
                        //总的含税单价
                        double colitaxunitpricesum = colitaxunitprices;
                        frmSoAddInfo frm = new frmSoAddInfo();
                        frm.Csocode = tsmi_Csocode;
                        frm.Cinvcode = Cinvcode;
                        frm.iLoginEx = iLoginEx;
                        frm.Siquantity = Convert.ToDecimal(coliquantitys.ToString("####0.000"));
                        frm.isosid = isosid;
                        frm.iRows = iRows;
                        frm.colitaxunitprice = colitaxunitpricesum;
                        frm.SO_SOMain_Id = SO_SOMain_Id;
                        frm.ShowDialog();
                        switch (SuitFind_CinvName)
                        {
                            case "套装查询": btnSuitFind_Click(null, null);
                                break;
                            case "存货查询":
                                btnCinvName_Click(null, null);
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("此物料不是套装,无法进入拆解套装");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
        } 
        #endregion

        #region 鼠标双击单元格
        /// <summary>
        /// 鼠标双击单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab2_dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (tab2_cSTCode.ReadOnly)
                {
                    return;
                }
                if (this.tab2_dataGridView1.CurrentCell.ColumnIndex == 0)
                {
                    string wCode = "", wName = "", sText = "";
                    string[] para = sText.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
                    if (para.Length > 1)
                    {
                        wCode = para[1];
                    }
                    else
                    {
                        wCode = sText;
                    }
                    string selectSQL = "";
                    selectSQL = "SELECT cInvCode as 存货编码,cInvName as 存货名称,cInvStd as 规格型号,cInvAddCode as 存货代码,cInvABC as ABC分类,dSDate as 启用日期,cGroupName as 计量单位组名称,cComUnitName as 主计量单位名称  FROM Inventory  it LEFT JOIN ComputationGroup cg ON  cg.cGroupCode = it.cGroupCode LEFT JOIN ComputationUnit cu ON cu.cComunitCode = it.cComUnitCode  \r\n";
                    sText = iLoginEx.OpenSelectWindow("存货基本参照", selectSQL, wCode, 1030, 500, 8);
                    para = sText.Split(new string[] { "\r\n\r\n\r\n " }, StringSplitOptions.None);
                    if (para.Length > 1)
                    {
                        wCode = para[0];
                        wName = para[1];
                        cInvCode = wCode;
                        cInvName = wName;
                        cInvStd = para[2];
                        cComUnitName = para[7];
                        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colcInvCode"].Value = wCode;
                        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colcInvName"].Value = wName;
                        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colcInvStd"].Value = para[2];
                        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colcComUnitName"].Value = para[7];
                        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coldpredate"].Value = DateTime.Now.ToString("yyyy-MM-dd");
                        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coldpremodate"].Value = DateTime.Now.ToString("yyyy-MM-dd");

                        LpPecSRPolicy(wCode);
                        tab2_dataGridView1.Columns["colidemandtype"].ReadOnly = true;
                        (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colborderbom"] as DataGridViewComboBoxCell).Value = "否";
                        (tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colbusecusbom"] as DataGridViewComboBoxCell).Value = "否";
                        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coliTaxRate"].Value = txtiTaxRate.Text;

                        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["coliquantity"].Value = ("0").ToString();
                        tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colitaxunitprice"].Value = "0.00";
                        //tab2_dataGridView1.Rows[tab2_dataGridView1.CurrentCell.RowIndex].Cells["colisum"].Value = "0.00";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
        } 
        #endregion

        #region 此行关闭或打开
        /// <summary>
        /// 关闭此行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRowEnd_Click(object sender, EventArgs e)
        {
            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.RowClose))
            {
                string dbclosedate = DateTime.Now.ToString("yyyy-MM-dd");//关闭日期
                int indexRow = tab2_dataGridView1.CurrentCell.RowIndex;
                string cRowSO_SOMain_Id = tab2_dataGridView1.Rows[indexRow].Cells["colSO_SOMain_Id"].Value.ToString();
                string cRowSO_SODetails_isosid = tab2_dataGridView1.Rows[indexRow].Cells["coliSOsID"].Value.ToString();
                string sqlcClose = "Update SO_SODetails set cSCloser=N'" + iLoginEx.UserName() + "',dbclosedate='" + dbclosedate + "',dbclosesystime=getdate() Where Id=" + SO_SOMain_Id + " and iSOsID=" + cRowSO_SODetails_isosid + " \r\n";
                OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                conn.Open();
                try
                {
                    OleDbCommand comm = new OleDbCommand(sqlcClose, conn);
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        tsbtnRefurbish_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("此行关闭失败！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误！此行结案" + ex.Message);
                }
                finally
                {
                    conn.Close();
                    GC.Collect();
                }
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// 打开此行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRowBegin_Click(object sender, EventArgs e)
        {
            if (iLoginEx.CheckAuthorityDetail(iLoginEx.UserId(), AuthID, LoginEx.AuthorityDetailType.RowClose))
            {
                string dbclosedate = DateTime.Now.ToString("yyyy-MM-dd");//打开日期
                int indexRow = tab2_dataGridView1.CurrentCell.RowIndex;
                string cRowSO_SOMain_Id = tab2_dataGridView1.Rows[indexRow].Cells["colSO_SOMain_Id"].Value.ToString();
                string cRowSO_SODetails_isosid = tab2_dataGridView1.Rows[indexRow].Cells["coliSOsID"].Value.ToString();
                string sqlcClose = "Update SO_SODetails set cSCloser=N'',dbclosedate='" + dbclosedate + "',dbclosesystime=getdate() Where Id=" + SO_SOMain_Id + " and iSOsID=" + cRowSO_SODetails_isosid + " \r\n";
                OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                conn.Open();
                try
                {
                    OleDbCommand comm = new OleDbCommand(sqlcClose, conn);
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        tsbtnRefurbish_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("此行关闭失败！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误！此行结案" + ex.Message);
                }
                finally
                {
                    conn.Close();
                    GC.Collect();
                }
            }
            else
            {
                MessageBox.Show(this, "无此权限", "套装销售订单", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
        #endregion

        #region 拆套装查询订单号
        /// <summary>
        /// 拆套装查询订单号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnzzCQuery_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtzzcCsoCode.Text.Trim()))
            {
                wsql = " where Csocode='" + txtzzcCsoCode.Text.Trim() + "'";
            }
            else
            {
                wsql = "";
            }
            homepage_Click(null, null);
        } 
        #endregion

        #region 分页
        int PageIndex = 1, PageSize =300;//PageIndex 页码，PageSize 页大小
        public string SortOrders = "";
        public string HeaderText = "";
        public string wsql = "";
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homepage_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                if (String.IsNullOrEmpty(iLoginEx.ReadUserProfileValue("SO311", "HeaderText")))
                {
                    str = "录入时间 desc";
                }
                else
                {
                    str = iLoginEx.ReadUserProfileValue("SO311", "HeaderText");
                }
                iLoginEx.WriteUserProfileValue("SO311", "HeaderText", str);
                PageIndex = 1;
                int n;
                int PageSum;
                PageCoun(out n, out PageSum, wsql);
                PageSize = Convert.ToInt32(cobNumber.Text);
                dgvSplitsingle_Load(0, str, PageSize, wsql);
                lblPageSum.Text = "第 " + PageIndex.ToString() + " 页  , 共 " + PageSum.ToString() + " 页 , 当前记录数：" + PageSize + " , 总记录数：" + n.ToString() + "";
                SortOrdersMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
        }

        private void SortOrdersMethod()
        {
            if (SortOrders == "Ascending")
            {
                dgvSplitsingle.Columns[HeaderText].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                dgvSplitsingle.Rows[dgvSplitsingle.CurrentCell.ColumnIndex].Cells[HeaderText].Selected = true;
                dgvSplitsingle.CurrentCell = dgvSplitsingle.Rows[dgvSplitsingle.CurrentCell.ColumnIndex].Cells[HeaderText];
            }
            else if (SortOrders == "Descending")
            {
                dgvSplitsingle.Columns[HeaderText].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                dgvSplitsingle.Rows[dgvSplitsingle.CurrentCell.ColumnIndex].Cells[HeaderText].Selected = true;
                dgvSplitsingle.CurrentCell = dgvSplitsingle.Rows[dgvSplitsingle.CurrentCell.ColumnIndex].Cells[HeaderText];
            }
        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextPage_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int PageSum;
                PageCoun(out n, out PageSum, wsql);
                PageIndex++;
                PageSize = Convert.ToInt32(cobNumber.Text);
                if (PageIndex < PageSum)
                {
                    dgvSplitsingle_Load((PageIndex - 1) * PageSize, iLoginEx.ReadUserProfileValue("SO311", "HeaderText"), PageSize, wsql);
                    lblPageSum.Text = "第 " + PageIndex.ToString() + " 页  , 共 " + PageSum.ToString() + " 页 , 当前记录数：" + PageSize + " , 总记录数：" + n.ToString() + "";
                }
                else
                {
                    PageIndex = PageSum;
                    dgvSplitsingle_Load((PageSum - 1) * PageSize, iLoginEx.ReadUserProfileValue("SO311", "HeaderText"), PageSize, wsql);
                    lblPageSum.Text = "第 " + PageSum.ToString() + " 页  , 共 " + PageSum.ToString() + " 页 , 当前记录数：" + (n - (PageSum - 1) * PageSize).ToString() + " , 总记录数：" + n.ToString() + "";
                }
                SortOrdersMethod();
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
        }

        private  void PageCoun(out int n, out int PageSum,string sqlw)
        {
            PageSize = Convert.ToInt32(cobNumber.Text);
            n = OLEDBHelper.GetCount("select Count(1) from zhrs_t_zzcSO_SOAddSeriesInfo " + sqlw + "");
            PageSum = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(n) / Convert.ToDouble(PageSize)));
        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prepage_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int PageSum;
                PageCoun(out n, out PageSum, wsql);
                PageIndex--;
                PageSize = Convert.ToInt32(cobNumber.Text);
                if (PageIndex > 0)
                {
                    dgvSplitsingle_Load((PageIndex - 1) * PageSize, iLoginEx.ReadUserProfileValue("SO311", "HeaderText"), PageSize, wsql);
                    lblPageSum.Text = "第 " + PageIndex.ToString() + " 页  , 共 " + PageSum.ToString() + " 页 , 当前记录数：" + PageSize + " , 总记录数：" + n.ToString() + "";
                }
                else
                {
                    PageIndex = 1;
                    dgvSplitsingle_Load((PageIndex - 1) * PageSize, iLoginEx.ReadUserProfileValue("SO311", "HeaderText"), PageSize, wsql);
                    lblPageSum.Text = "第 " + 1 + " 页  , 共 " + PageSum.ToString() + " 页 , 当前记录数：" + (PageIndex * PageSize).ToString() + " , 总记录数：" + n.ToString() + "";
                }
                SortOrdersMethod();
            }
            catch (Exception ex)
            {
                
               MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
        }
        /// <summary>
        /// 末页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastPage_Click(object sender, EventArgs e)
        {
            try
            {
                PageSize = Convert.ToInt32(cobNumber.Text);
                int n;
                int PageSum;
                PageCoun(out n, out PageSum, wsql);
                PageIndex = PageSum;
                dgvSplitsingle_Load((PageSum - 1) * PageSize, iLoginEx.ReadUserProfileValue("SO311", "HeaderText"), PageSize, wsql);
                lblPageSum.Text = "第 " + PageSum.ToString() + " 页  , 共 " + PageSum.ToString() + " 页 , 当前记录数：" + (n - (PageSum - 1) * PageSize).ToString() + " , 总记录数：" + n.ToString() + "";
                SortOrdersMethod();
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
        }
        private void cobNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberKeyPress(e);
        }
        public int index = 1;
        /// <summary>
        /// 分页排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSplitsingle_Sorted(object sender, EventArgs e)
        {
            try
            {
                if (dgvSplitsingle.CurrentCell.ColumnIndex == 0)
                {
                    return;
                }
                HeaderText = dgvSplitsingle.Columns[dgvSplitsingle.CurrentCell.ColumnIndex].HeaderText;
                PageIndex = 1;
                int n;
                int PageSum;
                PageCoun(out n, out PageSum, wsql);
                PageSize = Convert.ToInt32(cobNumber.Text);
                if (index % 2 == 0)
                {
                    dgvSplitsingle.Columns[HeaderText].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                    SortOrders = "Descending";
                }
                else
                {
                    dgvSplitsingle.Columns[HeaderText].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                    SortOrders = "Ascending";
                }
                index++;
                if (SortOrder.Ascending == dgvSplitsingle.Columns[dgvSplitsingle.CurrentCell.ColumnIndex].HeaderCell.SortGlyphDirection)
                {
                    iLoginEx.WriteUserProfileValue("SO311", "HeaderText", HeaderText + " asc");
                    dgvSplitsingle_Load(0, iLoginEx.ReadUserProfileValue("SO311", "HeaderText"), PageSize, wsql);
                    dgvSplitsingle.Columns[HeaderText].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                }
                else
                {
                    iLoginEx.WriteUserProfileValue("SO311", "HeaderText", HeaderText + " desc");
                    dgvSplitsingle_Load(0, iLoginEx.ReadUserProfileValue("SO311", "HeaderText"), PageSize, wsql);
                    dgvSplitsingle.Columns[HeaderText].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                }
                dgvSplitsingle.Rows[dgvSplitsingle.CurrentCell.ColumnIndex].Cells[HeaderText].Selected = true;
                dgvSplitsingle.CurrentCell = dgvSplitsingle.Rows[dgvSplitsingle.CurrentCell.ColumnIndex].Cells[HeaderText];
                lblPageSum.Text = "第 " + PageIndex.ToString() + " 页  , 共 " + PageSum.ToString() + " 页 , 当前记录数：" + PageSize + " , 总记录数：" + n.ToString() + "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误！" + ex.Message);
            }
            finally { GC.Collect(); }
        }
        #endregion


    }
}
