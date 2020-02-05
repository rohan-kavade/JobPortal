namespace JobPortal.UI.Jobseeker
{
    partial class JDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mangageAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appliedJobReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.applyJob1 = new JobPortal.UI.Jobseeker.ApplyJob();
            this.jApplied1 = new JobPortal.UI.Jobseeker.JApplied();
            this.jChangePass1 = new JobPortal.UI.Jobseeker.JChangePass();
            this.jProfile1 = new JobPortal.UI.Jobseeker.JProfile();
            this.jHome1 = new JobPortal.UI.Jobseeker.JHome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.LogoutLink);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LogoutLink
            // 
            this.LogoutLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLink.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LogoutLink.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.LogoutLink.Location = new System.Drawing.Point(727, 12);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(60, 18);
            this.LogoutLink.TabIndex = 5;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Logout";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(556, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(332, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jobseeker";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(140, 29);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Controls.Add(this.menuStrip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 417);
            this.panel2.TabIndex = 5;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mangageAccountToolStripMenuItem,
            this.postJobToolStripMenuItem,
            this.appliedJobReportToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(174, 417);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // mangageAccountToolStripMenuItem
            // 
            this.mangageAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.mangageAccountToolStripMenuItem.Name = "mangageAccountToolStripMenuItem";
            this.mangageAccountToolStripMenuItem.Size = new System.Drawing.Size(161, 25);
            this.mangageAccountToolStripMenuItem.Text = "Mangage Account";
            this.mangageAccountToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.updateProfileToolStripMenuItem.Text = "Update Profile";
            this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.updateProfileToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // postJobToolStripMenuItem
            // 
            this.postJobToolStripMenuItem.Name = "postJobToolStripMenuItem";
            this.postJobToolStripMenuItem.Size = new System.Drawing.Size(161, 25);
            this.postJobToolStripMenuItem.Text = "Apply For Job";
            this.postJobToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postJobToolStripMenuItem.Click += new System.EventHandler(this.postJobToolStripMenuItem_Click);
            // 
            // appliedJobReportToolStripMenuItem
            // 
            this.appliedJobReportToolStripMenuItem.Name = "appliedJobReportToolStripMenuItem";
            this.appliedJobReportToolStripMenuItem.Size = new System.Drawing.Size(161, 25);
            this.appliedJobReportToolStripMenuItem.Text = "Mangage Applied Job";
            this.appliedJobReportToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appliedJobReportToolStripMenuItem.Click += new System.EventHandler(this.appliedJobReportToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.applyJob1);
            this.panel3.Controls.Add(this.jApplied1);
            this.panel3.Controls.Add(this.jChangePass1);
            this.panel3.Controls.Add(this.jProfile1);
            this.panel3.Controls.Add(this.jHome1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(175, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 417);
            this.panel3.TabIndex = 6;
            // 
            // applyJob1
            // 
            this.applyJob1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyJob1.Location = new System.Drawing.Point(0, 0);
            this.applyJob1.Name = "applyJob1";
            this.applyJob1.Size = new System.Drawing.Size(625, 417);
            this.applyJob1.TabIndex = 4;
            // 
            // jApplied1
            // 
            this.jApplied1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jApplied1.Location = new System.Drawing.Point(0, 0);
            this.jApplied1.Name = "jApplied1";
            this.jApplied1.Size = new System.Drawing.Size(625, 417);
            this.jApplied1.TabIndex = 3;
            // 
            // jChangePass1
            // 
            this.jChangePass1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jChangePass1.Location = new System.Drawing.Point(0, 0);
            this.jChangePass1.Name = "jChangePass1";
            this.jChangePass1.Size = new System.Drawing.Size(625, 417);
            this.jChangePass1.TabIndex = 2;
            // 
            // jProfile1
            // 
            this.jProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jProfile1.Location = new System.Drawing.Point(0, 0);
            this.jProfile1.Name = "jProfile1";
            this.jProfile1.Size = new System.Drawing.Size(625, 417);
            this.jProfile1.TabIndex = 1;
            // 
            // jHome1
            // 
            this.jHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jHome1.Location = new System.Drawing.Point(0, 0);
            this.jHome1.Name = "jHome1";
            this.jHome1.Size = new System.Drawing.Size(625, 417);
            this.jHome1.TabIndex = 0;
            // 
            // JDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JDashboard";
            this.Text = "Jobseeker Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mangageAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appliedJobReportToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private JApplied jApplied1;
        private JChangePass jChangePass1;
        private JProfile jProfile1;
        private JHome jHome1;
        private ApplyJob applyJob1;
        //private JsProfile.Jpass jpass1;
    }
}