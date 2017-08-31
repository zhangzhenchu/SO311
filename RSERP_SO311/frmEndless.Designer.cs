namespace RSERP_SO311
{
    partial class frmEndless
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximization = new System.Windows.Forms.Button();
            this.btnMinimization = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SLbServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLbAccID = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLbAccName = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLbYear = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLbUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLBSql = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLbState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssldateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tirTime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(1065, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximization
            // 
            this.btnMaximization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaximization.Location = new System.Drawing.Point(1010, 0);
            this.btnMaximization.Name = "btnMaximization";
            this.btnMaximization.Size = new System.Drawing.Size(54, 23);
            this.btnMaximization.TabIndex = 1;
            this.btnMaximization.Text = "最大化";
            this.btnMaximization.UseVisualStyleBackColor = true;
            this.btnMaximization.Click += new System.EventHandler(this.btnMaximization_Click);
            // 
            // btnMinimization
            // 
            this.btnMinimization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimization.Location = new System.Drawing.Point(955, 0);
            this.btnMinimization.Name = "btnMinimization";
            this.btnMinimization.Size = new System.Drawing.Size(54, 23);
            this.btnMinimization.TabIndex = 2;
            this.btnMinimization.Text = "最小化";
            this.btnMinimization.UseVisualStyleBackColor = true;
            this.btnMinimization.Click += new System.EventHandler(this.btnMinimization_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SLbServer,
            this.SLbAccID,
            this.SLbAccName,
            this.SLbYear,
            this.SLbUser,
            this.SLBSql,
            this.SLbState,
            this.tssldateTime});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 523);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1107, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SLbServer
            // 
            this.SLbServer.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.SLbServer.Name = "SLbServer";
            this.SLbServer.Size = new System.Drawing.Size(48, 21);
            this.SLbServer.Text = "服务器";
            this.SLbServer.ToolTipText = "服务器";
            // 
            // SLbAccID
            // 
            this.SLbAccID.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.SLbAccID.Name = "SLbAccID";
            this.SLbAccID.Size = new System.Drawing.Size(48, 21);
            this.SLbAccID.Spring = true;
            this.SLbAccID.Text = "帐套号";
            this.SLbAccID.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // SLbAccName
            // 
            this.SLbAccName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.SLbAccName.Name = "SLbAccName";
            this.SLbAccName.Size = new System.Drawing.Size(60, 21);
            this.SLbAccName.Text = "帐套名称";
            // 
            // SLbYear
            // 
            this.SLbYear.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.SLbYear.Name = "SLbYear";
            this.SLbYear.Size = new System.Drawing.Size(36, 21);
            this.SLbYear.Text = "年度";
            // 
            // SLbUser
            // 
            this.SLbUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.SLbUser.Name = "SLbUser";
            this.SLbUser.Size = new System.Drawing.Size(48, 21);
            this.SLbUser.Text = "用户名";
            // 
            // SLBSql
            // 
            this.SLBSql.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.SLBSql.Name = "SLBSql";
            this.SLBSql.Size = new System.Drawing.Size(4, 21);
            // 
            // SLbState
            // 
            this.SLbState.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.SLbState.Name = "SLbState";
            this.SLbState.Size = new System.Drawing.Size(4, 21);
            // 
            // tssldateTime
            // 
            this.tssldateTime.Name = "tssldateTime";
            this.tssldateTime.Size = new System.Drawing.Size(56, 21);
            this.tssldateTime.Text = "当前时间";
            // 
            // tirTime
            // 
            this.tirTime.Enabled = true;
            this.tirTime.Tick += new System.EventHandler(this.tirTime_Tick);
            // 
            // frmEndless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 549);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnMinimization);
            this.Controls.Add(this.btnMaximization);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEndless";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEndless";
            this.Load += new System.EventHandler(this.frmEndless_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEndless_MouseDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximization;
        private System.Windows.Forms.Button btnMinimization;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SLbServer;
        private System.Windows.Forms.ToolStripStatusLabel SLbAccID;
        private System.Windows.Forms.ToolStripStatusLabel SLbAccName;
        private System.Windows.Forms.ToolStripStatusLabel SLbYear;
        private System.Windows.Forms.ToolStripStatusLabel SLbUser;
        private System.Windows.Forms.ToolStripStatusLabel SLBSql;
        private System.Windows.Forms.ToolStripStatusLabel SLbState;
        private System.Windows.Forms.ToolStripStatusLabel tssldateTime;
        private System.Windows.Forms.Timer tirTime;
    }
}