namespace Construction_workers.UI.Employees
{
    partial class frmEmployeesList
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSerch = new System.Windows.Forms.Button();
            this.txtSerchName = new System.Windows.Forms.TextBox();
            this.txtSerch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFIrstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmntype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(371, 347);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(452, 347);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "افزودن ";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(290, 347);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(75, 23);
            this.btnDelet.TabIndex = 5;
            this.btnDelet.Text = "حذف";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.txtSerchName);
            this.groupBox1.Controls.Add(this.txtSerch);
            this.groupBox1.Location = new System.Drawing.Point(452, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "بر اساس نام ونام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "بر اساس کد ملی";
            // 
            // btnSerch
            // 
            this.btnSerch.Location = new System.Drawing.Point(6, 19);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(75, 46);
            this.btnSerch.TabIndex = 2;
            this.btnSerch.Text = "جستجو";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // txtSerchName
            // 
            this.txtSerchName.Location = new System.Drawing.Point(110, 45);
            this.txtSerchName.Name = "txtSerchName";
            this.txtSerchName.Size = new System.Drawing.Size(161, 20);
            this.txtSerchName.TabIndex = 1;
            // 
            // txtSerch
            // 
            this.txtSerch.Location = new System.Drawing.Point(110, 19);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.Size = new System.Drawing.Size(161, 20);
            this.txtSerch.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnID,
            this.clmnFIrstName,
            this.clmnLastname,
            this.clmnTell,
            this.clmnCell,
            this.clmnNationalCode,
            this.clmntype,
            this.clmnTime});
            this.dataGridView1.Location = new System.Drawing.Point(7, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(894, 258);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmnID
            // 
            this.clmnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnID.DataPropertyName = "ID";
            this.clmnID.HeaderText = "شناسه";
            this.clmnID.Name = "clmnID";
            // 
            // clmnFIrstName
            // 
            this.clmnFIrstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnFIrstName.DataPropertyName = "name";
            this.clmnFIrstName.HeaderText = "نام";
            this.clmnFIrstName.Name = "clmnFIrstName";
            // 
            // clmnLastname
            // 
            this.clmnLastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnLastname.DataPropertyName = "lastname";
            this.clmnLastname.HeaderText = "نام خانوادگی";
            this.clmnLastname.Name = "clmnLastname";
            // 
            // clmnTell
            // 
            this.clmnTell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnTell.DataPropertyName = "tell";
            this.clmnTell.HeaderText = "تلفن";
            this.clmnTell.Name = "clmnTell";
            // 
            // clmnCell
            // 
            this.clmnCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnCell.DataPropertyName = "cell";
            this.clmnCell.HeaderText = "موبایل";
            this.clmnCell.Name = "clmnCell";
            // 
            // clmnNationalCode
            // 
            this.clmnNationalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnNationalCode.DataPropertyName = "Ntiolecode";
            this.clmnNationalCode.HeaderText = "کدملی";
            this.clmnNationalCode.Name = "clmnNationalCode";
            // 
            // clmntype
            // 
            this.clmntype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmntype.DataPropertyName = "type";
            this.clmntype.HeaderText = "تخصص کارمند";
            this.clmntype.Name = "clmntype";
            // 
            // clmnTime
            // 
            this.clmnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnTime.DataPropertyName = "time";
            this.clmnTime.HeaderText = "ساعت کار";
            this.clmnTime.Name = "clmnTime";
            // 
            // frmEmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 374);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEmployeesList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کارمندان";
            this.Load += new System.EventHandler(this.frmEmployeesList_Load);
            this.Shown += new System.EventHandler(this.frmEmployeesList_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.TextBox txtSerchName;
        private System.Windows.Forms.TextBox txtSerch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFIrstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTell;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmntype;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTime;
    }
}