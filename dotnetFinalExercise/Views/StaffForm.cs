using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using dotnetFinalExercise.Views;

namespace dotnetFinalExercise
{
    public partial class StaffForm : DevExpress.XtraEditors.XtraForm
    {
        int flag = 0;
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVien();
            dis_end(false);
            binding();
        }
        public void HienThiDSNhanVien()
        {
            dgvDSStaff.DataSource = Models.StaffMod.FillStaffDS().Tables[0];
            dgvDSStaff.Dock = DockStyle.Fill;
            dgvDSStaff.BorderStyle = BorderStyle.Fixed3D;
            dgvDSStaff.RowHeadersVisible = false;
        }

        void nhung(Control ctrl)
        {
            pnSearch.Controls.Clear();
            pnSearch.BorderStyle = BorderStyle.Fixed3D;
            ctrl.Dock = DockStyle.Fill;
            pnSearch.Controls.Add(ctrl);
            pnSearch.Show();
        }

        void binding()
        {
            txtStaffId.DataBindings.Clear();
            txtStaffId.DataBindings.Add("Text", dgvDSStaff.DataSource, "IdNhanVien");
            txtStaffName.DataBindings.Clear();
            txtStaffName.DataBindings.Add("Text", dgvDSStaff.DataSource, "Ten");
            dtStaffDOB.DataBindings.Clear();
            dtStaffDOB.DataBindings.Add("Text", dgvDSStaff.DataSource, "Ngaysinh");
            cbStaffSex.DataBindings.Clear();
            cbStaffSex.DataBindings.Add("Text", dgvDSStaff.DataSource, "GioiTinh");
            txtStaffPhone.DataBindings.Clear();
            txtStaffPhone.DataBindings.Add("Text", dgvDSStaff.DataSource, "Dienthoai");
            txtStaffEmail.DataBindings.Clear();
            txtStaffEmail.DataBindings.Add("Text", dgvDSStaff.DataSource, "Email");
        }
        void dis_end(bool e)
        {
            txtStaffName.Enabled = e;
            txtStaffEmail.Enabled = e;
            txtStaffPhone.Enabled = e;
            dtStaffDOB.Enabled = e;
            cbStaffSex.Enabled = e;
            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            btnAdd.Enabled = !e;
            btnUpdate.Enabled = !e;
            btnDelete.Enabled = !e;
        }
        void loadControl()
        {
            cbStaffSex.Items.Clear();
            cbStaffSex.Items.Add("Nam");
            cbStaffSex.Items.Add("Nữ");
        }
        void clearData()
        {
            txtStaffId.Text = Models.Connection.ExcuteScalar(string.Format("select IdNhanVien=dbo.fcgetIdNhanVien()"));
            txtStaffName.Text = "";
            txtStaffEmail.Text = "";
            txtStaffPhone.Text = "";
            loadControl();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StaffForm_Load(sender, e);
            dis_end(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            loadControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _StaffId = "";
            try
            {
                _StaffId = txtStaffId.Text;
            }
            catch { }
            string _StaffName = "";
            try
            {
                _StaffName = txtStaffName.Text;
            }
            catch { }
            DateTime _StaffDOB = dtStaffDOB.DateTime;
            try
            {
                
            }
            catch { }
            string _StaffSex = "";
            try
            {
                _StaffSex = cbStaffSex.Text;
            }
            catch { }
            string _StaffPhone = "";
            try
            {
                _StaffPhone = txtStaffPhone.Text;
            }
            catch { }
            string _StaffEmail = "";
            try
            {
                _StaffEmail = txtStaffEmail.Text;
            }
            catch { }
            if (flag == 0)
            {
                if (_StaffId == "" || _StaffName == "") MessageBox.Show("Hãy nhập đầy đủ thông tin!");
                else
                {
                    int i = 0;
                    i = Controllers.StaffCtrl.StaffInsert(_StaffId, _StaffName, _StaffSex, _StaffDOB, _StaffPhone, _StaffEmail);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        HienThiDSNhanVien();
                    }
                    else MessageBox.Show("Thêm thất bại! Hãy kiểm tra lại thông tin!");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.StaffCtrl.StaffUpdate(_StaffId, _StaffName, _StaffSex, _StaffDOB, _StaffPhone, _StaffEmail);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HienThiDSNhanVien();
                }
                else MessageBox.Show("Sửa thất bại! Hãy kiểm tra lại thông tin!");
            }
            StaffForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string _id = "";
            try
            {
                _id = txtStaffId.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.StaffCtrl.StaffDelete(_id);
                if (i > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    HienThiDSNhanVien();
                    StaffForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xoá thất bại! Hãy kiểm tra lại thông tin!");
                }
            }
            else return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uctStaffSearch uctS = new uctStaffSearch();
            nhung(uctS);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnSearch.Controls.Clear();
            pnSearch.BorderStyle = BorderStyle.None;
        }

        private void txtStaffPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}