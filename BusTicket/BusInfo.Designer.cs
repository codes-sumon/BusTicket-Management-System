namespace BusTicket
{
    partial class BusInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBusInfo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelBusInfo = new System.Windows.Forms.Label();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.txtBusName = new System.Windows.Forms.TextBox();
            this.labelTotalSits = new System.Windows.Forms.Label();
            this.labelBusType = new System.Windows.Forms.Label();
            this.labelBusNumber = new System.Windows.Forms.Label();
            this.labelBusName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbBusSits = new System.Windows.Forms.ComboBox();
            this.cbBusType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpButtonBox = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusInfo)).BeginInit();
            this.tlpTitle.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBusInfo
            // 
            this.dgvBusInfo.AllowUserToAddRows = false;
            this.dgvBusInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBusInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBusInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusInfo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBusInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BusName,
            this.BusNumber,
            this.TotalSits,
            this.BusType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBusInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBusInfo.Location = new System.Drawing.Point(31, 177);
            this.dgvBusInfo.Name = "dgvBusInfo";
            this.dgvBusInfo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBusInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBusInfo.Size = new System.Drawing.Size(831, 289);
            this.dgvBusInfo.TabIndex = 6;
            this.dgvBusInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusInfo_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // BusName
            // 
            this.BusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BusName.DataPropertyName = "BusName";
            this.BusName.FillWeight = 160F;
            this.BusName.HeaderText = "Name";
            this.BusName.Name = "BusName";
            this.BusName.ReadOnly = true;
            // 
            // BusNumber
            // 
            this.BusNumber.DataPropertyName = "BusNumber";
            this.BusNumber.FillWeight = 160F;
            this.BusNumber.HeaderText = "Bus Number";
            this.BusNumber.Name = "BusNumber";
            this.BusNumber.ReadOnly = true;
            this.BusNumber.Width = 160;
            // 
            // TotalSits
            // 
            this.TotalSits.DataPropertyName = "TotalSits";
            this.TotalSits.FillWeight = 160F;
            this.TotalSits.HeaderText = "Total Sits";
            this.TotalSits.Name = "TotalSits";
            this.TotalSits.ReadOnly = true;
            this.TotalSits.Width = 160;
            // 
            // BusType
            // 
            this.BusType.DataPropertyName = "BusType";
            this.BusType.FillWeight = 160F;
            this.BusType.HeaderText = "Bus Type";
            this.BusType.Name = "BusType";
            this.BusType.ReadOnly = true;
            this.BusType.Width = 160;
            // 
            // labelBusInfo
            // 
            this.labelBusInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBusInfo.AutoSize = true;
            this.labelBusInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusInfo.ForeColor = System.Drawing.Color.White;
            this.labelBusInfo.Location = new System.Drawing.Point(3, 0);
            this.labelBusInfo.Name = "labelBusInfo";
            this.labelBusInfo.Size = new System.Drawing.Size(867, 22);
            this.labelBusInfo.TabIndex = 0;
            this.labelBusInfo.Text = "Bus Information";
            this.labelBusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpTitle
            // 
            this.tlpTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTitle.ColumnCount = 1;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitle.Controls.Add(this.labelBusInfo, 0, 0);
            this.tlpTitle.Location = new System.Drawing.Point(12, 12);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitle.Size = new System.Drawing.Size(873, 31);
            this.tlpTitle.TabIndex = 0;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusNumber.Location = new System.Drawing.Point(519, 3);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(328, 20);
            this.txtBusNumber.TabIndex = 1;
            // 
            // txtBusName
            // 
            this.txtBusName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusName.Location = new System.Drawing.Point(89, 3);
            this.txtBusName.Name = "txtBusName";
            this.txtBusName.Size = new System.Drawing.Size(327, 20);
            this.txtBusName.TabIndex = 1;
            // 
            // labelTotalSits
            // 
            this.labelTotalSits.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotalSits.AutoSize = true;
            this.labelTotalSits.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSits.ForeColor = System.Drawing.Color.White;
            this.labelTotalSits.Location = new System.Drawing.Point(15, 36);
            this.labelTotalSits.Name = "labelTotalSits";
            this.labelTotalSits.Size = new System.Drawing.Size(68, 19);
            this.labelTotalSits.TabIndex = 0;
            this.labelTotalSits.Text = "Total Sits:";
            // 
            // labelBusType
            // 
            this.labelBusType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBusType.AutoSize = true;
            this.labelBusType.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusType.ForeColor = System.Drawing.Color.White;
            this.labelBusType.Location = new System.Drawing.Point(446, 36);
            this.labelBusType.Name = "labelBusType";
            this.labelBusType.Size = new System.Drawing.Size(67, 19);
            this.labelBusType.TabIndex = 0;
            this.labelBusType.Text = "Bus Type:";
            // 
            // labelBusNumber
            // 
            this.labelBusNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBusNumber.AutoSize = true;
            this.labelBusNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusNumber.ForeColor = System.Drawing.Color.White;
            this.labelBusNumber.Location = new System.Drawing.Point(424, 6);
            this.labelBusNumber.Name = "labelBusNumber";
            this.labelBusNumber.Size = new System.Drawing.Size(89, 19);
            this.labelBusNumber.TabIndex = 0;
            this.labelBusNumber.Text = "Bus Number:";
            // 
            // labelBusName
            // 
            this.labelBusName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBusName.AutoSize = true;
            this.labelBusName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusName.ForeColor = System.Drawing.Color.White;
            this.labelBusName.Location = new System.Drawing.Point(34, 6);
            this.labelBusName.Name = "labelBusName";
            this.labelBusName.Size = new System.Drawing.Size(49, 19);
            this.labelBusName.TabIndex = 0;
            this.labelBusName.Text = "Name:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.25346F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.52074F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.17051F));
            this.tableLayoutPanel2.Controls.Add(this.labelBusName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelBusNumber, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelBusType, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelTotalSits, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBusName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBusNumber, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbBusSits, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbBusType, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(850, 61);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cbBusSits
            // 
            this.cbBusSits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBusSits.FormattingEnabled = true;
            this.cbBusSits.Items.AddRange(new object[] {
            "28",
            "31",
            "36",
            "40"});
            this.cbBusSits.Location = new System.Drawing.Point(89, 34);
            this.cbBusSits.Name = "cbBusSits";
            this.cbBusSits.Size = new System.Drawing.Size(327, 21);
            this.cbBusSits.TabIndex = 2;
            // 
            // cbBusType
            // 
            this.cbBusType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBusType.FormattingEnabled = true;
            this.cbBusType.Items.AddRange(new object[] {
            "AC",
            "Non-AC"});
            this.cbBusType.Location = new System.Drawing.Point(519, 34);
            this.cbBusType.Name = "cbBusType";
            this.cbBusType.Size = new System.Drawing.Size(328, 21);
            this.cbBusType.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(241, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 36);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(122, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 36);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tlpButtonBox
            // 
            this.tlpButtonBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtonBox.ColumnCount = 3;
            this.tlpButtonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonBox.Controls.Add(this.btnSave, 0, 0);
            this.tlpButtonBox.Controls.Add(this.btnDelete, 1, 0);
            this.tlpButtonBox.Controls.Add(this.btnCancel, 2, 0);
            this.tlpButtonBox.Location = new System.Drawing.Point(273, 129);
            this.tlpButtonBox.Name = "tlpButtonBox";
            this.tlpButtonBox.RowCount = 1;
            this.tlpButtonBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonBox.Size = new System.Drawing.Size(357, 42);
            this.tlpButtonBox.TabIndex = 2;
            // 
            // BusInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(892, 478);
            this.Controls.Add(this.dgvBusInfo);
            this.Controls.Add(this.tlpButtonBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tlpTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusInfo";
            this.Text = "BusInfo";
            this.Load += new System.EventHandler(this.BusInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusInfo)).EndInit();
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpButtonBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBusInfo;
        private System.Windows.Forms.Label labelBusInfo;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.TextBox txtBusName;
        private System.Windows.Forms.Label labelTotalSits;
        private System.Windows.Forms.Label labelBusType;
        private System.Windows.Forms.Label labelBusNumber;
        private System.Windows.Forms.Label labelBusName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tlpButtonBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSits;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusType;
        private System.Windows.Forms.ComboBox cbBusSits;
        private System.Windows.Forms.ComboBox cbBusType;
    }
}