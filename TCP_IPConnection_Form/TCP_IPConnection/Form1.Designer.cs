namespace TCP_IPConnection
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txthost = new System.Windows.Forms.TextBox();
            this.txtport = new System.Windows.Forms.TextBox();
            this.btncon = new System.Windows.Forms.Button();
            this.btndis = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPlank = new System.Windows.Forms.TextBox();
            this.txtQtt = new System.Windows.Forms.TextBox();
            this.txtTIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtGV = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port :";
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(63, 33);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(100, 22);
            this.txthost.TabIndex = 2;
            this.txthost.Text = "192.168.0.107";
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(217, 33);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(100, 22);
            this.txtport.TabIndex = 3;
            this.txtport.Text = "34567";
            // 
            // btncon
            // 
            this.btncon.Location = new System.Drawing.Point(323, 33);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(75, 23);
            this.btncon.TabIndex = 4;
            this.btncon.Text = "Connect";
            this.btncon.UseVisualStyleBackColor = true;
            this.btncon.Click += new System.EventHandler(this.btncon_Click);
            // 
            // btndis
            // 
            this.btndis.Location = new System.Drawing.Point(404, 33);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(104, 23);
            this.btndis.TabIndex = 5;
            this.btndis.Text = "Disconnect";
            this.btndis.UseVisualStyleBackColor = true;
            this.btndis.Click += new System.EventHandler(this.btndis_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(15, 61);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtstatus.Size = new System.Drawing.Size(493, 579);
            this.txtstatus.TabIndex = 6;
            this.txtstatus.TextChanged += new System.EventHandler(this.txtstatus_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(620, 47);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(218, 32);
            this.txtID.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(620, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtPlank
            // 
            this.txtPlank.Location = new System.Drawing.Point(620, 85);
            this.txtPlank.Name = "txtPlank";
            this.txtPlank.ReadOnly = true;
            this.txtPlank.Size = new System.Drawing.Size(218, 22);
            this.txtPlank.TabIndex = 9;
            // 
            // txtQtt
            // 
            this.txtQtt.Location = new System.Drawing.Point(620, 141);
            this.txtQtt.Name = "txtQtt";
            this.txtQtt.Size = new System.Drawing.Size(218, 22);
            this.txtQtt.TabIndex = 10;
            // 
            // txtTIn
            // 
            this.txtTIn.Location = new System.Drawing.Point(620, 169);
            this.txtTIn.Name = "txtTIn";
            this.txtTIn.ReadOnly = true;
            this.txtTIn.Size = new System.Drawing.Size(218, 22);
            this.txtTIn.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Classified ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Plank :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Time IN :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Company :";
            // 
            // cbCompany
            // 
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Items.AddRange(new object[] {
            "Mỹ",
            "Úc",
            "Nga",
            "Hàn Quốc",
            "Nhật Bản"});
            this.cbCompany.Location = new System.Drawing.Point(620, 197);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(218, 24);
            this.cbCompany.TabIndex = 19;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(620, 241);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(82, 32);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtGV
            // 
            this.dtGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV.Location = new System.Drawing.Point(524, 279);
            this.dtGV.Name = "dtGV";
            this.dtGV.RowTemplate.Height = 24;
            this.dtGV.Size = new System.Drawing.Size(666, 361);
            this.dtGV.TabIndex = 21;
            this.dtGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1115, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(620, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(218, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(563, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Status :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 652);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtGV);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTIn);
            this.Controls.Add(this.txtQtt);
            this.Controls.Add(this.txtPlank);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.btndis);
            this.Controls.Add(this.btncon);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.txthost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP Connection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Button btncon;
        private System.Windows.Forms.Button btndis;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPlank;
        private System.Windows.Forms.TextBox txtQtt;
        private System.Windows.Forms.TextBox txtTIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dtGV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label9;
    }
}

