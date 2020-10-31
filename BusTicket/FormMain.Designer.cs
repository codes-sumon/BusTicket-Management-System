namespace BusTicket
{
    partial class FormMain
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSetup = new System.Windows.Forms.Panel();
            this.btnTripSetup = new System.Windows.Forms.Button();
            this.btnRoutSetup = new System.Windows.Forms.Button();
            this.btnSuperVisor = new System.Windows.Forms.Button();
            this.btnDriverInfo = new System.Windows.Forms.Button();
            this.btnCounterInfo = new System.Windows.Forms.Button();
            this.btnBusInfo = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.dgvFindBus = new System.Windows.Forms.DataGridView();
            this.btnFindBus = new System.Windows.Forms.Button();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datDate = new System.Windows.Forms.DateTimePicker();
            this.colTripID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRouteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelSetup.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindBus)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 50);
            this.panelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUS TICKET";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panelSetup);
            this.panelSideMenu.Controls.Add(this.btnSetup);
            this.panelSideMenu.Controls.Add(this.btnDashboard);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 50);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(205, 461);
            this.panelSideMenu.TabIndex = 1;
            // 
            // panelSetup
            // 
            this.panelSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSetup.Controls.Add(this.btnTripSetup);
            this.panelSetup.Controls.Add(this.btnRoutSetup);
            this.panelSetup.Controls.Add(this.btnSuperVisor);
            this.panelSetup.Controls.Add(this.btnDriverInfo);
            this.panelSetup.Controls.Add(this.btnCounterInfo);
            this.panelSetup.Controls.Add(this.btnBusInfo);
            this.panelSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSetup.Location = new System.Drawing.Point(0, 90);
            this.panelSetup.Name = "panelSetup";
            this.panelSetup.Size = new System.Drawing.Size(205, 246);
            this.panelSetup.TabIndex = 3;
            // 
            // btnTripSetup
            // 
            this.btnTripSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTripSetup.FlatAppearance.BorderSize = 0;
            this.btnTripSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTripSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTripSetup.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTripSetup.Location = new System.Drawing.Point(0, 200);
            this.btnTripSetup.Name = "btnTripSetup";
            this.btnTripSetup.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnTripSetup.Size = new System.Drawing.Size(205, 40);
            this.btnTripSetup.TabIndex = 5;
            this.btnTripSetup.Text = "Trip Setup";
            this.btnTripSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTripSetup.UseVisualStyleBackColor = true;
            this.btnTripSetup.Click += new System.EventHandler(this.btnTripSetup_Click);
            // 
            // btnRoutSetup
            // 
            this.btnRoutSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoutSetup.FlatAppearance.BorderSize = 0;
            this.btnRoutSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoutSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoutSetup.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRoutSetup.Location = new System.Drawing.Point(0, 160);
            this.btnRoutSetup.Name = "btnRoutSetup";
            this.btnRoutSetup.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnRoutSetup.Size = new System.Drawing.Size(205, 40);
            this.btnRoutSetup.TabIndex = 3;
            this.btnRoutSetup.Text = "Route Setup";
            this.btnRoutSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoutSetup.UseVisualStyleBackColor = true;
            this.btnRoutSetup.Click += new System.EventHandler(this.btnRoutSetup_Click);
            // 
            // btnSuperVisor
            // 
            this.btnSuperVisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuperVisor.FlatAppearance.BorderSize = 0;
            this.btnSuperVisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuperVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuperVisor.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSuperVisor.Location = new System.Drawing.Point(0, 120);
            this.btnSuperVisor.Name = "btnSuperVisor";
            this.btnSuperVisor.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSuperVisor.Size = new System.Drawing.Size(205, 40);
            this.btnSuperVisor.TabIndex = 4;
            this.btnSuperVisor.Text = "Super Visor Info";
            this.btnSuperVisor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuperVisor.UseVisualStyleBackColor = true;
            this.btnSuperVisor.Click += new System.EventHandler(this.btnSuperVisor_Click);
            // 
            // btnDriverInfo
            // 
            this.btnDriverInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDriverInfo.FlatAppearance.BorderSize = 0;
            this.btnDriverInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriverInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriverInfo.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDriverInfo.Location = new System.Drawing.Point(0, 80);
            this.btnDriverInfo.Name = "btnDriverInfo";
            this.btnDriverInfo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDriverInfo.Size = new System.Drawing.Size(205, 40);
            this.btnDriverInfo.TabIndex = 2;
            this.btnDriverInfo.Text = "Driver Information";
            this.btnDriverInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDriverInfo.UseVisualStyleBackColor = true;
            this.btnDriverInfo.Click += new System.EventHandler(this.btnDriverInfo_Click);
            // 
            // btnCounterInfo
            // 
            this.btnCounterInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCounterInfo.FlatAppearance.BorderSize = 0;
            this.btnCounterInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCounterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounterInfo.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCounterInfo.Location = new System.Drawing.Point(0, 40);
            this.btnCounterInfo.Name = "btnCounterInfo";
            this.btnCounterInfo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCounterInfo.Size = new System.Drawing.Size(205, 40);
            this.btnCounterInfo.TabIndex = 1;
            this.btnCounterInfo.Text = "Counter Information";
            this.btnCounterInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCounterInfo.UseVisualStyleBackColor = true;
            this.btnCounterInfo.Click += new System.EventHandler(this.btnCounterInfo_Click);
            // 
            // btnBusInfo
            // 
            this.btnBusInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusInfo.FlatAppearance.BorderSize = 0;
            this.btnBusInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusInfo.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBusInfo.Location = new System.Drawing.Point(0, 0);
            this.btnBusInfo.Name = "btnBusInfo";
            this.btnBusInfo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnBusInfo.Size = new System.Drawing.Size(205, 40);
            this.btnBusInfo.TabIndex = 0;
            this.btnBusInfo.Text = "Bus Information";
            this.btnBusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusInfo.UseVisualStyleBackColor = true;
            this.btnBusInfo.Click += new System.EventHandler(this.btnBusInfo_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetup.FlatAppearance.BorderSize = 0;
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetup.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.Location = new System.Drawing.Point(0, 45);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSetup.Size = new System.Drawing.Size(205, 45);
            this.btnSetup.TabIndex = 2;
            this.btnSetup.Text = "Setup";
            this.btnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDashboard.Size = new System.Drawing.Size(205, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.dgvFindBus);
            this.panelChildForm.Controls.Add(this.btnFindBus);
            this.panelChildForm.Controls.Add(this.cmbTo);
            this.panelChildForm.Controls.Add(this.cmbFrom);
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.label3);
            this.panelChildForm.Controls.Add(this.label5);
            this.panelChildForm.Controls.Add(this.datDate);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(205, 50);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(779, 461);
            this.panelChildForm.TabIndex = 2;
            // 
            // dgvFindBus
            // 
            this.dgvFindBus.AllowUserToAddRows = false;
            this.dgvFindBus.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFindBus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFindBus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFindBus.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFindBus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFindBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindBus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTripID,
            this.colDate,
            this.colSeats,
            this.colAvailable,
            this.colRouteName,
            this.colFare,
            this.colBuy});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFindBus.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFindBus.Location = new System.Drawing.Point(6, 130);
            this.dgvFindBus.Name = "dgvFindBus";
            this.dgvFindBus.ReadOnly = true;
            this.dgvFindBus.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFindBus.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFindBus.RowTemplate.Height = 30;
            this.dgvFindBus.Size = new System.Drawing.Size(761, 319);
            this.dgvFindBus.TabIndex = 12;
            // 
            // btnFindBus
            // 
            this.btnFindBus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindBus.ForeColor = System.Drawing.Color.Black;
            this.btnFindBus.Location = new System.Drawing.Point(538, 61);
            this.btnFindBus.Name = "btnFindBus";
            this.btnFindBus.Size = new System.Drawing.Size(219, 36);
            this.btnFindBus.TabIndex = 6;
            this.btnFindBus.Text = "Find Bus";
            this.btnFindBus.UseVisualStyleBackColor = true;
            this.btnFindBus.Click += new System.EventHandler(this.btnFindBus_Click);
            // 
            // cmbTo
            // 
            this.cmbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(220, 69);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(223, 24);
            this.cmbTo.TabIndex = 5;
            // 
            // cmbFrom
            // 
            this.cmbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(220, 26);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(223, 24);
            this.cmbFrom.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "To*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(449, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Date*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(170, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "From*";
            // 
            // datDate
            // 
            this.datDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datDate.Location = new System.Drawing.Point(538, 26);
            this.datDate.Name = "datDate";
            this.datDate.Size = new System.Drawing.Size(219, 22);
            this.datDate.TabIndex = 1;
            // 
            // colTripID
            // 
            this.colTripID.HeaderText = "Coach";
            this.colTripID.Name = "colTripID";
            this.colTripID.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colSeats
            // 
            this.colSeats.HeaderText = "Seats";
            this.colSeats.Name = "colSeats";
            this.colSeats.ReadOnly = true;
            // 
            // colAvailable
            // 
            this.colAvailable.HeaderText = "Available";
            this.colAvailable.Name = "colAvailable";
            this.colAvailable.ReadOnly = true;
            // 
            // colRouteName
            // 
            this.colRouteName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRouteName.HeaderText = "Route Name";
            this.colRouteName.Name = "colRouteName";
            this.colRouteName.ReadOnly = true;
            // 
            // colFare
            // 
            this.colFare.HeaderText = "Fare";
            this.colFare.Name = "colFare";
            this.colFare.ReadOnly = true;
            // 
            // colBuy
            // 
            this.colBuy.HeaderText = "Buy";
            this.colBuy.Name = "colBuy";
            this.colBuy.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSetup.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindBus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSetup;
        private System.Windows.Forms.Button btnRoutSetup;
        private System.Windows.Forms.Button btnDriverInfo;
        private System.Windows.Forms.Button btnCounterInfo;
        private System.Windows.Forms.Button btnBusInfo;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnTripSetup;
        private System.Windows.Forms.Button btnSuperVisor;
        private System.Windows.Forms.DateTimePicker datDate;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFindBus;
        private System.Windows.Forms.DataGridView dgvFindBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTripID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRouteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFare;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuy;
    }
}