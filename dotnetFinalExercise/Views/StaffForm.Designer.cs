namespace dotnetFinalExercise
{
    partial class StaffForm
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
            this.grStaffManage = new DevExpress.XtraEditors.GroupControl();
            this.dtStaffDOB = new DevExpress.XtraEditors.DateEdit();
            this.txtStaffEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtStaffPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtStaffName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtStaffId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSStaff = new System.Windows.Forms.DataGridView();
            this.cbStaffSex = new System.Windows.Forms.ComboBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnHide = new DevExpress.XtraEditors.SimpleButton();
            this.pnSearch = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grStaffManage)).BeginInit();
            this.grStaffManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStaffDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStaffDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffId.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // grStaffManage
            // 
            this.grStaffManage.Controls.Add(this.cbStaffSex);
            this.grStaffManage.Controls.Add(this.dtStaffDOB);
            this.grStaffManage.Controls.Add(this.txtStaffEmail);
            this.grStaffManage.Controls.Add(this.labelControl8);
            this.grStaffManage.Controls.Add(this.txtStaffPhone);
            this.grStaffManage.Controls.Add(this.labelControl7);
            this.grStaffManage.Controls.Add(this.txtStaffName);
            this.grStaffManage.Controls.Add(this.labelControl6);
            this.grStaffManage.Controls.Add(this.labelControl5);
            this.grStaffManage.Controls.Add(this.labelControl4);
            this.grStaffManage.Controls.Add(this.txtStaffId);
            this.grStaffManage.Controls.Add(this.labelControl3);
            this.grStaffManage.Location = new System.Drawing.Point(74, 161);
            this.grStaffManage.Name = "grStaffManage";
            this.grStaffManage.Size = new System.Drawing.Size(786, 530);
            this.grStaffManage.TabIndex = 0;
            // 
            // dtStaffDOB
            // 
            this.dtStaffDOB.EditValue = null;
            this.dtStaffDOB.Location = new System.Drawing.Point(161, 413);
            this.dtStaffDOB.Name = "dtStaffDOB";
            this.dtStaffDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStaffDOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStaffDOB.Size = new System.Drawing.Size(200, 40);
            this.dtStaffDOB.TabIndex = 12;
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.Location = new System.Drawing.Point(561, 256);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(200, 40);
            this.txtStaffEmail.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(454, 263);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 25);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Email";
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(561, 110);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(200, 40);
            this.txtStaffPhone.TabIndex = 5;
            this.txtStaffPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStaffPhone_KeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(454, 117);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(96, 25);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Điện thoại";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(161, 256);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(200, 40);
            this.txtStaffName.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 265);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 25);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Tên";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 420);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 25);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Ngày sinh";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(454, 421);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 25);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Giới tính";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Enabled = false;
            this.txtStaffId.Location = new System.Drawing.Point(161, 110);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(200, 40);
            this.txtStaffId.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(123, 25);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "ID Nhân viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(270, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(340, 39);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1497, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(387, 39);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(74, 759);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 60);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(379, 759);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 60);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(685, 759);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 60);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 889);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 60);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(528, 889);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 60);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSStaff);
            this.groupBox1.Location = new System.Drawing.Point(1014, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1375, 467);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // dgvDSStaff
            // 
            this.dgvDSStaff.AllowUserToAddRows = false;
            this.dgvDSStaff.AllowUserToDeleteRows = false;
            this.dgvDSStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSStaff.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDSStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSStaff.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvDSStaff.Location = new System.Drawing.Point(3, 29);
            this.dgvDSStaff.Name = "dgvDSStaff";
            this.dgvDSStaff.RowHeadersWidth = 82;
            this.dgvDSStaff.RowTemplate.Height = 33;
            this.dgvDSStaff.Size = new System.Drawing.Size(1369, 435);
            this.dgvDSStaff.TabIndex = 1;
            // 
            // cbStaffSex
            // 
            this.cbStaffSex.FormattingEnabled = true;
            this.cbStaffSex.Location = new System.Drawing.Point(561, 417);
            this.cbStaffSex.Name = "cbStaffSex";
            this.cbStaffSex.Size = new System.Drawing.Size(200, 33);
            this.cbStaffSex.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1016, 546);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 60);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(1283, 546);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(178, 60);
            this.btnHide.TabIndex = 19;
            this.btnHide.Text = "Ẩn";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.Location = new System.Drawing.Point(1001, 656);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(1385, 390);
            this.pnSearch.TabIndex = 20;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2385, 1058);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grStaffManage);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grStaffManage)).EndInit();
            this.grStaffManage.ResumeLayout(false);
            this.grStaffManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStaffDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStaffDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffId.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grStaffManage;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtStaffId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStaffEmail;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtStaffPhone;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtStaffName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtStaffDOB;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSStaff;
        private System.Windows.Forms.ComboBox cbStaffSex;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnHide;
        private System.Windows.Forms.Panel pnSearch;
    }
}