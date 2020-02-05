namespace JobPortal.UI.Jobseeker.JsProfile
{
    partial class JBasic
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.updateLabel = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jlocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobseekerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobportalDataSet = new JobPortal.jobportalDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.txtMailToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtMailToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.jobseekerDetailsTableAdapter = new JobPortal.jobportalDataSetTableAdapters.JobseekerDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobseekerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobportalDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Information";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Tomato;
            this.labelName.Location = new System.Drawing.Point(13, 86);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.Color.Tomato;
            this.labelLocation.Location = new System.Drawing.Point(13, 194);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(70, 20);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Location";
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.ForeColor = System.Drawing.Color.Tomato;
            this.labelMobile.Location = new System.Drawing.Point(13, 159);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(55, 20);
            this.labelMobile.TabIndex = 3;
            this.labelMobile.Text = "Mobile";
            // 
            // labelmail
            // 
            this.labelmail.AutoSize = true;
            this.labelmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmail.ForeColor = System.Drawing.Color.Tomato;
            this.labelmail.Location = new System.Drawing.Point(13, 123);
            this.labelmail.Name = "labelmail";
            this.labelmail.Size = new System.Drawing.Size(48, 20);
            this.labelmail.TabIndex = 4;
            this.labelmail.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(271, 20);
            this.textBox4.TabIndex = 8;
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.ForeColor = System.Drawing.Color.Tomato;
            this.updateLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.updateLabel.LinkColor = System.Drawing.Color.Tomato;
            this.updateLabel.Location = new System.Drawing.Point(17, 271);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(89, 27);
            this.updateLabel.TabIndex = 18;
            this.updateLabel.TabStop = true;
            this.updateLabel.Text = "Update";
            this.updateLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.updateLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateLabel_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jnameDataGridViewTextBoxColumn,
            this.jmailDataGridViewTextBoxColumn,
            this.jmobileDataGridViewTextBoxColumn,
            this.jlocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jobseekerDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(436, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 213);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // jnameDataGridViewTextBoxColumn
            // 
            this.jnameDataGridViewTextBoxColumn.DataPropertyName = "j_name";
            this.jnameDataGridViewTextBoxColumn.HeaderText = "j_name";
            this.jnameDataGridViewTextBoxColumn.Name = "jnameDataGridViewTextBoxColumn";
            // 
            // jmailDataGridViewTextBoxColumn
            // 
            this.jmailDataGridViewTextBoxColumn.DataPropertyName = "j_mail";
            this.jmailDataGridViewTextBoxColumn.HeaderText = "j_mail";
            this.jmailDataGridViewTextBoxColumn.Name = "jmailDataGridViewTextBoxColumn";
            // 
            // jmobileDataGridViewTextBoxColumn
            // 
            this.jmobileDataGridViewTextBoxColumn.DataPropertyName = "j_mobile";
            this.jmobileDataGridViewTextBoxColumn.HeaderText = "j_mobile";
            this.jmobileDataGridViewTextBoxColumn.Name = "jmobileDataGridViewTextBoxColumn";
            // 
            // jlocationDataGridViewTextBoxColumn
            // 
            this.jlocationDataGridViewTextBoxColumn.DataPropertyName = "j_location";
            this.jlocationDataGridViewTextBoxColumn.HeaderText = "j_location";
            this.jlocationDataGridViewTextBoxColumn.Name = "jlocationDataGridViewTextBoxColumn";
            // 
            // jobseekerDetailsBindingSource
            // 
            this.jobseekerDetailsBindingSource.DataMember = "JobseekerDetails";
            this.jobseekerDetailsBindingSource.DataSource = this.jobportalDataSet;
            // 
            // jobportalDataSet
            // 
            this.jobportalDataSet.DataSetName = "jobportalDataSet";
            this.jobportalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtMailToolStripLabel,
            this.txtMailToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(880, 25);
            this.fillByToolStrip.TabIndex = 21;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // txtMailToolStripLabel
            // 
            this.txtMailToolStripLabel.Name = "txtMailToolStripLabel";
            this.txtMailToolStripLabel.Size = new System.Drawing.Size(63, 22);
            this.txtMailToolStripLabel.Text = "Enter Mail:";
            // 
            // txtMailToolStripTextBox
            // 
            this.txtMailToolStripTextBox.Name = "txtMailToolStripTextBox";
            this.txtMailToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.fillByToolStripButton.Text = "submit";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // jobseekerDetailsTableAdapter
            // 
            this.jobseekerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // JBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelmail);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Name = "JBasic";
            this.Size = new System.Drawing.Size(880, 382);
            this.Load += new System.EventHandler(this.JBasic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobseekerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobportalDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.LinkLabel updateLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jlocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jobseekerDetailsBindingSource;
        private jobportalDataSet jobportalDataSet;
        private jobportalDataSetTableAdapters.JobseekerDetailsTableAdapter jobseekerDetailsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel txtMailToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtMailToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}
