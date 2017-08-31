using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using UTLoginEx;

namespace RSERP_SO311
{
    public partial class frmSoInfo_1 : Form
    {
        public UTLoginEx.LoginEx iLoginEx = new LoginEx();
        public List<SoInfo_1> lst1 = new List<SoInfo_1>();
        public List<SoInfo_1> lst2 = new List<SoInfo_1>();
        /// <summary>
        /// //订单号
        /// </summary>
        public string Csocode = "";
        /// <summary>
        /// 母表体单标识
        /// </summary>
        public int isosid;
        /// <summary>
        /// //母件存货编码
        /// </summary>
        public string BCinvcode = "";
        /// <summary>
        /// 母件Bomid
        /// </summary>
        public int Bomid;
        /// <summary>
        /// 总含税单价
        /// </summary>
        public double colitaxunitprice;
        /// <summary>
        /// 剩余含税单价
        /// </summary>
        double lblcolsumprice;

        public frmSoInfo_1()
        {
            InitializeComponent();
        }

        #region 加载事件
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSoInfo_1_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text += "  " + System.Windows.Forms.Application.ProductVersion;
                lblcolsum.Text = "剩余含税单价：" + colitaxunitprice.ToString("####0.0000");
                string selectSQL = "";
                OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                conn.Open();
                OleDbCommand com = new OleDbCommand(selectSQL, conn);
                selectSQL = "Select distinct bom_bom.BomType, bas_part.InvCode, Inventory.cInvAddCode as InvAddCode, bom_parent.ParentId AS PartId,  \r\n";
                selectSQL += " Inventory.cInvName as InvName, Inventory.cInvStd as InvStd, bas_part.cBasEngineerFigNo as BasEngineerFigNo, bom_parent.sharingpartid as   \r\n";
                selectSQL += " SharePartId,ComputationUnit.cComUnitCode as InvUnit, ComputationUnit.cComUnitName as InvUnitName, bom_parent.ParentScrap,   \r\n";
                selectSQL += " bom_bom.Version, bom_bom.VersionDesc, bom_bom.VersionEffDate, bom_bom.IdentCode, bom_bom.IdentDesc, bom_bom.Status as BomState,   \r\n";
                selectSQL += " bom_bom.BomId, bas_part.free1 as InvFree_1, bas_part.free2 as InvFree_2, bas_part.free3 as InvFree_3, bas_part.free4 as InvFree_4,  \r\n";
                selectSQL += "  bas_part.free5 as InvFree_5, bas_part.free6 as InvFree_6, bas_part.free7 as InvFree_7, bas_part.free8 as InvFree_8,   \r\n";
                selectSQL += " bas_part.free9 as InvFree_9, bas_part.free10 as InvFree_10, Inventory.cinvdefine1 as CINVDEFINE1,Inventory.cinvdefine2 as CINVDEFINE2,  \r\n";
                selectSQL += " Inventory.cinvdefine3 as CINVDEFINE3,Inventory.cinvdefine4 as CINVDEFINE4,Inventory.cinvdefine5 as   \r\n";
                selectSQL += " CINVDEFINE5,Inventory.cinvdefine6 as CINVDEFINE6,Inventory.cinvdefine7 as CINVDEFINE7,Inventory.cinvdefine8 as CINVDEFINE8,  \r\n";
                selectSQL += " Inventory.cinvdefine9 as CINVDEFINE9,Inventory.cinvdefine10 as CINVDEFINE10,Inventory.cinvdefine11 as   \r\n";
                selectSQL += " CINVDEFINE11,Inventory.cinvdefine12 as CINVDEFINE12,Inventory.cinvdefine13 as CINVDEFINE13,Inventory.cinvdefine14 as CINVDEFINE14,  \r\n";
                selectSQL += " Inventory.cinvdefine15 as CINVDEFINE15,Inventory.cinvdefine16 as CINVDEFINE16  From bom_bom, bom_parent, bas_part, Inventory,   \r\n";
                selectSQL += " ComputationUnit  Where  bom_bom.BomType in(1,2) and bom_bom.BomId = bom_parent.BomId and (bom_parent.ParentId = bas_part.PartId) And  \r\n";
                selectSQL += "  bas_part.InvCode = Inventory.cInvCode And Inventory.cComUnitCode = ComputationUnit.cComUnitCode  and ( 1=1   And   \r\n";
                selectSQL += " ((Inventory.cInvCode >= N'" + BCinvcode + "') And (Inventory.cInvCode <= N'" + BCinvcode + "')))  Order by bom_bom.BomType, bas_part.InvCode, bom_bom.Version, bom_bom.IdentCode   \r\n";
                selectSQL += "   \r\n";
                com.CommandText = selectSQL;
                OleDbDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    Bomid = Convert.ToInt32(dr["BomId"]);
                }
                dr.Close();

                selectSQL = "select   \r\n";
                selectSQL += "  i.cInvCode as cInvCode, i.cInvName as cInvName,i.cinvstd as cinvstd,\r\n";
                selectSQL += "  c.ccomunitName as ccomunitName,    \r\n";
                selectSQL += "  (bo.BaseQtyN/bo.BaseQtyD) as Number ,i.cInvCCode as cInvCCode \r\n";
                selectSQL += "  from  Inventory i (nolock)    \r\n";
                selectSQL += "  left join bas_part bp (nolock)  on i.cInvCode=bp.InvCode     \r\n";
                selectSQL += "  left join bom_opcomponent bo (nolock) on bo.componentid=bp.partid    \r\n";
                selectSQL += "  left join ComputationUnit c (nolock)  on i.cComUnitCode = c.cComUnitCode    \r\n";
                selectSQL += "  left join bom_opcomponentopt bot (nolock) on bot.optionsid=bo.optionsid    \r\n";
                selectSQL += "  where bo.Bomid=" + Bomid + "   \r\n";

                if (lst1.Count > 0)
                {
                    lst1.Clear();
                }
                com.CommandText = selectSQL;
                OleDbDataReader drb = com.ExecuteReader();
                while (drb.Read())
                {
                    SoInfo_1 so = new SoInfo_1();
                    so.Csocode = Csocode;
                    so.BCinvcode = BCinvcode;
                    so.cInvCode = drb["cInvCode"].ToString();
                    so.cInvName = drb["cInvName"].ToString();
                    so.cinvstd = drb["cinvstd"].ToString();
                    so.ccomunitName = drb["ccomunitName"].ToString();
                    so.Number = Convert.ToDouble(drb["Number"]);
                    so.cInvCCode = drb["cInvCCode"].ToString();
                    so.Price = 0.000;
                    lst1.Add(so);
                }
                drb.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误！" + ex.Message);
            }
            finally
            {
                GC.Collect();
            }
            dgvCinvcode.DataSource = lst1;
          
            dgvCinvcode.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCinvcode.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCinvcode.Columns[8].DefaultCellStyle.Format = "#,###0.0000";
            dgvCinvcode.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            for (int i = 0; i < 8; i++)
            {
                dgvCinvcode.Columns[i].ReadOnly = true;
            }
        }
        
        #endregion

        #region 保存事件
        /// <summary>
        /// 保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lst2.Count > 0)
            {
                lst2.Clear();
            }
            if (dgvCinvcode.Rows.Count > 0)
            {
                //if (lblcolsumprice==0.00)
                //{
                //     this.DialogResult = DialogResult.Cancel;
                //     this.Close();
                //}
                for (int i = 0; i < dgvCinvcode.Rows.Count; i++)
                {
                    SoInfo_1 s = new SoInfo_1();
                    s.Csocode = Convert.ToString(dgvCinvcode.Rows[i].Cells[0].Value);
                    s.BCinvcode = dgvCinvcode.Rows[i].Cells[1].Value.ToString();
                    s.cInvCode = dgvCinvcode.Rows[i].Cells[2].Value.ToString();
                    s.cInvName = dgvCinvcode.Rows[i].Cells[3].Value.ToString();
                    s.cinvstd = dgvCinvcode.Rows[i].Cells[4].Value.ToString();
                    s.ccomunitName = dgvCinvcode.Rows[i].Cells[5].Value.ToString();
                    s.Number = Convert.ToDouble(dgvCinvcode.Rows[i].Cells[6].Value);
                    s.cInvCCode = dgvCinvcode.Rows[i].Cells[7].Value.ToString();
                    s.Price = Convert.ToDouble(dgvCinvcode.Rows[i].Cells[8].Value);
                    lst2.Add(s);
                }
                if (lblcolsumprice < 0.00)
                {
                    lblcolsum.ForeColor = Color.Red;
                    MessageBox.Show("剩余含税单价不能为负数，数据不符，请重新输入数据！\n" + lblcolsum.Text);
                    return;
                }
                try
                {
                    string sql = "delete from zhrs_t_zzcSO_SOAddSeriesInfo where isosid=" + isosid + " ";
                    OleDbConnection conn = new OleDbConnection(iLoginEx.ConnString());
                    conn.Open();
                    OleDbCommand com = new OleDbCommand(sql, conn);
                    com.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误！" + ex.Message);
                }
                finally { GC.Collect(); }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        } 
        #endregion

        #region 单元格只能输入数字
        /// <summary>
        /// 单元格只能输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCinvcode_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dgvCinvcode.CurrentCell.ColumnIndex == 8)
            {
                e.Control.KeyPress += new KeyPressEventHandler(EditingControl_KeyPress);
            }
        }
        private void EditingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.dgvCinvcode.CurrentCell.ColumnIndex == 8)
            {
                if ((e.KeyChar < 47 || e.KeyChar > 58) && (e.KeyChar != 8) && (e.KeyChar != 46))
                    e.Handled = true;
                dgvCinvcode.Columns[8].DefaultCellStyle.Format = "#,###0.0000";
                dgvCinvcode.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            else
            {
                e.Handled = false;
            }
        } 
        #endregion

        #region 单元格值改变事件
        /// <summary>
        /// 单元格值改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCinvcode_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int count = dgvCinvcode.Rows.Count;
            lblcolsumprice = Convert.ToDouble(colitaxunitprice.ToString("####0.0000"));
            for (int i = 0; i < count; i++)
            {
                lblcolsumprice -= (Convert.ToDouble(dgvCinvcode.Rows[i].Cells[8].Value) * Convert.ToDouble(dgvCinvcode.Rows[i].Cells[6].Value));
            }
            lblcolsum.Text = "剩余含税单价：" + lblcolsumprice.ToString("####0.0000");
            lblcolsumprice=Convert.ToDouble(lblcolsumprice.ToString("####0.0000"));
            if (lblcolsumprice < 0.00)
            {
                lblcolsum.ForeColor = Color.Red;
                MessageBox.Show("剩余含税单价不能为负数，数据不符，请重新输入数据！\n" + lblcolsum.Text);
            }
            else
            {
                lblcolsum.ForeColor = Color.Blue;
            }
        } 
        #endregion

        

        private void frmSoInfo_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lblcolsumprice < 0.00)
            {
                lblcolsum.ForeColor = Color.Red;
                MessageBox.Show("剩余含税单价不能为负数，数据不符，请重新输入数据！\n" + lblcolsum.Text);
                return;
            }
        }

        private void btncanle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
       
    }
}
