namespace RSERP_SO311
{
    partial class frmSoAddInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCsocode = new System.Windows.Forms.TextBox();
            this.txtCinvcode = new System.Windows.Forms.TextBox();
            this.dgvAddinfo = new System.Windows.Forms.DataGridView();
            this.SLbServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLbAccID = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLbAccName = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLbYear = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLbUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLBSql = new System.Windows.Forms.ToolStripStatusLabel();
            this.SLbState = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label7 = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblisum = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnDISH = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddinfo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "订单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "存货编码";
            // 
            // txtCsocode
            // 
            this.txtCsocode.Location = new System.Drawing.Point(59, 12);
            this.txtCsocode.Name = "txtCsocode";
            this.txtCsocode.ReadOnly = true;
            this.txtCsocode.Size = new System.Drawing.Size(173, 21);
            this.txtCsocode.TabIndex = 14;
            // 
            // txtCinvcode
            // 
            this.txtCinvcode.Location = new System.Drawing.Point(59, 43);
            this.txtCinvcode.Name = "txtCinvcode";
            this.txtCinvcode.ReadOnly = true;
            this.txtCinvcode.Size = new System.Drawing.Size(173, 21);
            this.txtCinvcode.TabIndex = 15;
            // 
            // dgvAddinfo
            // 
            this.dgvAddinfo.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAddinfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddinfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvAddinfo.Location = new System.Drawing.Point(0, 80);
            this.dgvAddinfo.Name = "dgvAddinfo";
            this.dgvAddinfo.ReadOnly = true;
            this.dgvAddinfo.RowTemplate.Height = 23;
            this.dgvAddinfo.Size = new System.Drawing.Size(1204, 379);
            this.dgvAddinfo.TabIndex = 25;
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
            this.SLbState});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1204, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "数量";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(288, 52);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(0, 12);
            this.lblnum.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(433, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "套装含税单价";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(516, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 35;
            this.label10.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(533, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "单价之和";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(601, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 37;
            this.label12.Text = "=";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(618, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 38;
            this.label13.Text = "剩余单价";
            // 
            // lblisum
            // 
            this.lblisum.AutoSize = true;
            this.lblisum.Location = new System.Drawing.Point(460, 45);
            this.lblisum.Name = "lblisum";
            this.lblisum.Size = new System.Drawing.Size(0, 12);
            this.lblisum.TabIndex = 39;
            // 
            // btncalc
            // 
            this.btncalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncalc.Location = new System.Drawing.Point(347, 12);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 40;
            this.btncalc.Text = "计算器";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnDISH
            // 
            this.btnDISH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDISH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDISH.Location = new System.Drawing.Point(255, 12);
            this.btnDISH.Name = "btnDISH";
            this.btnDISH.Size = new System.Drawing.Size(75, 23);
            this.btnDISH.TabIndex = 41;
            this.btnDISH.Text = "拆解";
            this.btnDISH.UseVisualStyleBackColor = true;
            this.btnDISH.Click += new System.EventHandler(this.btnDISH_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(716, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(233, 67);
            this.richTextBox1.TabIndex = 42;
            this.richTextBox1.Text = "注：套装的含税单价必须等于拆完套装的单价之和,如果有剩余单价不为零，请它将录入包材或电子配件或DVR里";
            // 
            // frmSoAddInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 488);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDISH);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.lblisum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvAddinfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCinvcode);
            this.Controls.Add(this.txtCsocode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmSoAddInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加套餐详细信息";
            this.Load += new System.EventHandler(this.frmSoAddInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddinfo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCsocode;
        private System.Windows.Forms.TextBox txtCinvcode;
        private System.Windows.Forms.DataGridView dgvAddinfo;
        private System.Windows.Forms.ToolStripStatusLabel SLbServer;
        private System.Windows.Forms.ToolStripStatusLabel SLbAccID;
        private System.Windows.Forms.ToolStripStatusLabel SLbAccName;
        private System.Windows.Forms.ToolStripStatusLabel SLbYear;
        private System.Windows.Forms.ToolStripStatusLabel SLbUser;
        private System.Windows.Forms.ToolStripStatusLabel SLBSql;
        private System.Windows.Forms.ToolStripStatusLabel SLbState;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblisum;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnDISH;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}