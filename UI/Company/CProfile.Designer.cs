namespace JobPortal.UI.Company
{
    partial class CProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuJpro = new System.Windows.Forms.MenuStrip();
            this.basicDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBasic1 = new JobPortal.UI.Company.CmProfile.CBasic();
            this.cmHome1 = new JobPortal.UI.Company.CmProfile.CmHome();
            this.panel1.SuspendLayout();
            this.menuJpro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 63);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(230, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Profile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(0, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cancel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuJpro
            // 
            this.menuJpro.BackColor = System.Drawing.Color.Tomato;
            this.menuJpro.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuJpro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuJpro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicDetailsToolStripMenuItem});
            this.menuJpro.Location = new System.Drawing.Point(496, 63);
            this.menuJpro.Name = "menuJpro";
            this.menuJpro.Size = new System.Drawing.Size(129, 329);
            this.menuJpro.TabIndex = 35;
            this.menuJpro.Text = "menuStrip1";
            // 
            // basicDetailsToolStripMenuItem
            // 
            this.basicDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicDetailsToolStripMenuItem1,
            this.personalDetailsToolStripMenuItem});
            this.basicDetailsToolStripMenuItem.Name = "basicDetailsToolStripMenuItem";
            this.basicDetailsToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.basicDetailsToolStripMenuItem.Text = "Profile Details";
            // 
            // basicDetailsToolStripMenuItem1
            // 
            this.basicDetailsToolStripMenuItem1.Name = "basicDetailsToolStripMenuItem1";
            this.basicDetailsToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.basicDetailsToolStripMenuItem1.Text = "Basic Details";
            this.basicDetailsToolStripMenuItem1.Click += new System.EventHandler(this.basicDetailsToolStripMenuItem1_Click);
            // 
            // personalDetailsToolStripMenuItem
            // 
            this.personalDetailsToolStripMenuItem.Name = "personalDetailsToolStripMenuItem";
            this.personalDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.personalDetailsToolStripMenuItem.Text = "Personal Details";
            // 
            // cBasic1
            // 
            this.cBasic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBasic1.Location = new System.Drawing.Point(0, 63);
            this.cBasic1.Name = "cBasic1";
            this.cBasic1.Size = new System.Drawing.Size(496, 329);
            this.cBasic1.TabIndex = 37;
            this.cBasic1.Load += new System.EventHandler(this.cBasic1_Load);
            // 
            // cmHome1
            // 
            this.cmHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmHome1.Location = new System.Drawing.Point(0, 63);
            this.cmHome1.Name = "cmHome1";
            this.cmHome1.Size = new System.Drawing.Size(496, 329);
            this.cmHome1.TabIndex = 36;
            // 
            // CProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBasic1);
            this.Controls.Add(this.cmHome1);
            this.Controls.Add(this.menuJpro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "CProfile";
            this.Size = new System.Drawing.Size(625, 417);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuJpro.ResumeLayout(false);
            this.menuJpro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuJpro;
        private System.Windows.Forms.ToolStripMenuItem basicDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personalDetailsToolStripMenuItem;
        private CmProfile.CmHome cmHome1;
        private CmProfile.CBasic cBasic1;
    }
}
