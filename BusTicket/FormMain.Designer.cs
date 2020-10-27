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
            this.panelTop.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1034, 50);
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
            this.panelSideMenu.Size = new System.Drawing.Size(205, 474);
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
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(205, 50);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(829, 474);
            this.panelChildForm.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1034, 524);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSetup.ResumeLayout(false);
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
    }
}