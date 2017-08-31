using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using UTLoginEx;

namespace RSERP_SO311
{
    public partial class frmEndless : Form
    {

        public  UTLoginEx.LoginEx iLoginEx = new LoginEx();
        public frmEndless()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEndless_MouseDown(object sender, MouseEventArgs e)
        {
            btnMaximization.Text = "最大化";
            OLEDBHelper.ReleaseCapture();
            OLEDBHelper.SendMessage(this.Handle, OLEDBHelper.WM_SYSCOMMAND, OLEDBHelper.SC_MOVE + OLEDBHelper.HTCAPTION, 0);
        }

        private void btnMaximization_Click(object sender, EventArgs e)
        {
            if ( this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximization.Text = "最大化";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximization.Text = "还  原";
            }
        }

        private void btnMinimization_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmEndless_Load(object sender, EventArgs e)
        {
            SLbAccID.Text = iLoginEx.AccID();
            SLbAccName.Text = iLoginEx.AccName();
            SLbServer.Text = iLoginEx.DBServerHost();
            SLbYear.Text = iLoginEx.iYear();
            SLbUser.Text = iLoginEx.UserId() + "[" + iLoginEx.UserName() + "]";

            this.tssldateTime.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff");
            this.tirTime.Interval = 1;
            this.tirTime.Start();//backups
        }

        private void tirTime_Tick(object sender, EventArgs e)
        {
            this.tssldateTime.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff");
            string sql = "";
            int m = DateTime.Now.Hour;
            if (m == 24)
            {
                OLEDBHelper.iLoginEx = iLoginEx;
                sql = "if object_id('zhrs_t_zzcSO_SOAddSeriesInfo_backups') is not null  \r\n";
                sql += "drop table zhrs_t_zzcSO_SOAddSeriesInfo_backups \r\n";
                sql += "select * into zhrs_t_zzcSO_SOAddSeriesInfo_backups from zhrs_t_zzcSO_SOAddSeriesInfo \r\n";//开始备份数据
                OLEDBHelper.ExecuteNonQuery(sql, CommandType.Text);
                OLEDBHelper.CloseCon();
                this.tirTime.Enabled=false;
            }
        }

        private void uctSText_BtnSearchClick_Button(object sender, EventArgs e)
        {
            MessageBox.Show("我们又见面了");
        }

        private void uctSText_txtMouseDouble_Text(object sender, MouseEventArgs e)
        {
            MessageBox.Show("是啊,你老是双击我,^_^ ");
        }

       
    }
}
