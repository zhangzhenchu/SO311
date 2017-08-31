namespace RSERP_SO311
{
    partial class frmSaleReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleReport));
            this.CRVReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsmifrist = new System.Windows.Forms.ToolStripButton();
            this.tsmiNext = new System.Windows.Forms.ToolStripButton();
            this.tsmiLast = new System.Windows.Forms.ToolStripButton();
            this.tsmiclose = new System.Windows.Forms.ToolStripButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CRVReport
            // 
            this.CRVReport.ActiveViewIndex = -1;
            this.CRVReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CRVReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVReport.DisplayGroupTree = false;
            this.CRVReport.DisplayToolbar = false;
            this.CRVReport.Location = new System.Drawing.Point(0, 53);
            this.CRVReport.Name = "CRVReport";
            this.CRVReport.SelectionFormula = "";
            this.CRVReport.Size = new System.Drawing.Size(942, 571);
            this.CRVReport.TabIndex = 0;
            this.CRVReport.ViewTimeSelectionFormula = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.tsmifrist,
            this.tsmiNext,
            this.tsmiLast,
            this.tsmiclose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(942, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 37);
            this.toolStripButton2.Text = "打印";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 37);
            this.toolStripButton3.Text = "首页";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsmifrist
            // 
            this.tsmifrist.Image = ((System.Drawing.Image)(resources.GetObject("tsmifrist.Image")));
            this.tsmifrist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmifrist.Name = "tsmifrist";
            this.tsmifrist.Size = new System.Drawing.Size(48, 37);
            this.tsmifrist.Text = "上一页";
            this.tsmifrist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmifrist.Click += new System.EventHandler(this.tsmifrist_Click);
            // 
            // tsmiNext
            // 
            this.tsmiNext.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNext.Image")));
            this.tsmiNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiNext.Name = "tsmiNext";
            this.tsmiNext.Size = new System.Drawing.Size(48, 37);
            this.tsmiNext.Text = "下一页";
            this.tsmiNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiNext.Click += new System.EventHandler(this.tsmiNext_Click);
            // 
            // tsmiLast
            // 
            this.tsmiLast.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLast.Image")));
            this.tsmiLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiLast.Name = "tsmiLast";
            this.tsmiLast.Size = new System.Drawing.Size(36, 37);
            this.tsmiLast.Text = "末页";
            this.tsmiLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiLast.Click += new System.EventHandler(this.tsmiLast_Click);
            // 
            // tsmiclose
            // 
            this.tsmiclose.Image = ((System.Drawing.Image)(resources.GetObject("tsmiclose.Image")));
            this.tsmiclose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiclose.Name = "tsmiclose";
            this.tsmiclose.Size = new System.Drawing.Size(36, 37);
            this.tsmiclose.Text = "退出";
            this.tsmiclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiclose.Click += new System.EventHandler(this.tsmiclose_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(325, 244);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(150, 150);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // frmSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 624);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CRVReport);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmSaleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预览报表";
            this.Load += new System.EventHandler(this.frmSaleReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVReport;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiclose;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton tsmifrist;
        private System.Windows.Forms.ToolStripButton tsmiNext;
        private System.Windows.Forms.ToolStripButton tsmiLast;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
       // private CRSale CRSale1;
    }
}