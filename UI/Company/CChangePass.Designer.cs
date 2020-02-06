namespace JobPortal.UI.Company
{
    partial class CChangePass
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPassCon = new System.Windows.Forms.TextBox();
            this.updateLabel = new System.Windows.Forms.LinkLabel();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(230, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(290, 158);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(222, 20);
            this.txtPass.TabIndex = 65;
            // 
            // txtPassCon
            // 
            this.txtPassCon.Location = new System.Drawing.Point(290, 206);
            this.txtPassCon.Name = "txtPassCon";
            this.txtPassCon.Size = new System.Drawing.Size(222, 20);
            this.txtPassCon.TabIndex = 64;
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.ForeColor = System.Drawing.Color.Tomato;
            this.updateLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.updateLabel.LinkColor = System.Drawing.Color.Tomato;
            this.updateLabel.Location = new System.Drawing.Point(116, 270);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(89, 27);
            this.updateLabel.TabIndex = 63;
            this.updateLabel.TabStop = true;
            this.updateLabel.Text = "Update";
            this.updateLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.updateLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateLabel_LinkClicked);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(290, 119);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(222, 20);
            this.txtMail.TabIndex = 62;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.Tomato;
            this.labelGender.Location = new System.Drawing.Point(112, 156);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(113, 20);
            this.labelGender.TabIndex = 61;
            this.labelGender.Text = "New Password";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.Tomato;
            this.labelAddress.Location = new System.Drawing.Point(112, 206);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(172, 20);
            this.labelAddress.TabIndex = 60;
            this.labelAddress.Text = "Confirm New Password";
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDob.ForeColor = System.Drawing.Color.Tomato;
            this.labelDob.Location = new System.Drawing.Point(112, 119);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(126, 20);
            this.labelDob.TabIndex = 59;
            this.labelDob.Text = "Enter Username";
            // 
            // CChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtPassCon);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.panel1);
            this.Name = "CChangePass";
            this.Size = new System.Drawing.Size(625, 417);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPassCon;
        private System.Windows.Forms.LinkLabel updateLabel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelDob;
    }
}
