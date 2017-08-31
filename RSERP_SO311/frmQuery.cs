using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTLoginEx;

namespace RSERP_SO311
{
    public partial class frmQuery : Form
    { 
        
        public  UTLoginEx.LoginEx iLoginEx = new LoginEx();
        public frmQuery()
        {
            InitializeComponent();
        }
      
        public  string coscode = "";
        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
            coscode = txtQuery.Text;
            iLoginEx.WriteUserProfileValue("SO311_frmQuery", "txtQuery", txtQuery.Text);
            this.Close();  
        }

        private void frmQuery_Load(object sender, EventArgs e)
        {
            txtQuery.Text = iLoginEx.ReadUserProfileValue("SO311_frmQuery", "txtQuery");
        }

        private void frmQuery_MouseDown(object sender, MouseEventArgs e)
        {
            OLEDBHelper.ReleaseCapture();
            OLEDBHelper.SendMessage(this.Handle, OLEDBHelper.WM_SYSCOMMAND, OLEDBHelper.SC_MOVE + OLEDBHelper.HTCAPTION, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
