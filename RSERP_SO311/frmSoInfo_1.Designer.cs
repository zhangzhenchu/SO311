namespace RSERP_SO311
{
    partial class frmSoInfo_1
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
            this.dgvCinvcode = new System.Windows.Forms.DataGridView();
            this.colCsocode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBCinvcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcInvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcinvstd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colccomunitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcInvCCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblcolsum = new System.Windows.Forms.Label();
            this.btncanle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinvcode)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCinvcode
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCinvcode.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCinvcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCinvcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCinvcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCinvcode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCsocode,
            this.colBCinvcode,
            this.colcInvCode,
            this.colcInvName,
            this.colcinvstd,
            this.colccomunitName,
            this.colNumber,
            this.colcInvCCode,
            this.colPrice});
            this.dgvCinvcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCinvcode.Location = new System.Drawing.Point(1, 36);
            this.dgvCinvcode.Name = "dgvCinvcode";
            this.dgvCinvcode.RowTemplate.Height = 23;
            this.dgvCinvcode.Size = new System.Drawing.Size(1004, 249);
            this.dgvCinvcode.TabIndex = 0;
            this.dgvCinvcode.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCinvcode_CellValueChanged);
            this.dgvCinvcode.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCinvcode_EditingControlShowing);
            // 
            // colCsocode
            // 
            this.colCsocode.DataPropertyName = "Csocode";
            this.colCsocode.HeaderText = "订单号";
            this.colCsocode.Name = "colCsocode";
            // 
            // colBCinvcode
            // 
            this.colBCinvcode.DataPropertyName = "BCinvcode";
            this.colBCinvcode.HeaderText = "母件存货编码";
            this.colBCinvcode.Name = "colBCinvcode";
            // 
            // colcInvCode
            // 
            this.colcInvCode.DataPropertyName = "cInvCode";
            this.colcInvCode.HeaderText = "子件编码";
            this.colcInvCode.Name = "colcInvCode";
            // 
            // colcInvName
            // 
            this.colcInvName.DataPropertyName = "cInvName";
            this.colcInvName.HeaderText = "子件名称";
            this.colcInvName.Name = "colcInvName";
            // 
            // colcinvstd
            // 
            this.colcinvstd.DataPropertyName = "cinvstd";
            this.colcinvstd.HeaderText = "子件规格";
            this.colcinvstd.Name = "colcinvstd";
            // 
            // colccomunitName
            // 
            this.colccomunitName.DataPropertyName = "ccomunitName";
            this.colccomunitName.HeaderText = "计量单位";
            this.colccomunitName.Name = "colccomunitName";
            // 
            // colNumber
            // 
            this.colNumber.DataPropertyName = "Number";
            this.colNumber.HeaderText = "子件使用数量";
            this.colNumber.Name = "colNumber";
            // 
            // colcInvCCode
            // 
            this.colcInvCCode.DataPropertyName = "cInvCCode";
            this.colcInvCCode.HeaderText = "子件存货大类编码";
            this.colcInvCCode.Name = "colcInvCCode";
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "单价";
            this.colPrice.Name = "colPrice";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(813, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblcolsum
            // 
            this.lblcolsum.AutoSize = true;
            this.lblcolsum.ForeColor = System.Drawing.Color.Blue;
            this.lblcolsum.Location = new System.Drawing.Point(653, 12);
            this.lblcolsum.Name = "lblcolsum";
            this.lblcolsum.Size = new System.Drawing.Size(95, 12);
            this.lblcolsum.TabIndex = 2;
            this.lblcolsum.Text = "剩余含税单价：0";
            // 
            // btncanle
            // 
            this.btncanle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncanle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncanle.Location = new System.Drawing.Point(894, 7);
            this.btncanle.Name = "btncanle";
            this.btncanle.Size = new System.Drawing.Size(75, 23);
            this.btncanle.TabIndex = 3;
            this.btncanle.Text = "取消";
            this.btncanle.UseVisualStyleBackColor = true;
            this.btncanle.Click += new System.EventHandler(this.btncanle_Click);
            // 
            // frmSoInfo_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 285);
            this.Controls.Add(this.btncanle);
            this.Controls.Add(this.lblcolsum);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvCinvcode);
            this.Name = "frmSoInfo_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料清单资料";
            this.Load += new System.EventHandler(this.frmSoInfo_1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSoInfo_1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinvcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCinvcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCsocode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCinvcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcInvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcinvstd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colccomunitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcInvCCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblcolsum;
        private System.Windows.Forms.Button btncanle;
    }
}