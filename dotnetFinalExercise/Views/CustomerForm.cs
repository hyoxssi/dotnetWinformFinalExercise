using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetFinalExercise.Views
{
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        int flag = 0;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            HienThiDS();
            dis_end(false);
            binding();
        }

        public void HienThiDS()
        {
            dgvDS.DataSource = Models.CustomerMod.FillCustomerDS().Tables[0];
            dgvDS.Dock = DockStyle.Fill;
            dgvDS.BorderStyle = BorderStyle.Fixed3D;
            dgvDS.RowHeadersVisible = false;
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
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", dgvDS.DataSource, "IdKhachHang");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dgvDS.DataSource, "TenKhachHang");
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", dgvDS.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDS.DataSource, "Email");
            txtSpending.DataBindings.Clear();
            txtSpending.DataBindings.Add("Text", dgvDS.DataSource, "ChiTieu");
        }

        void dis_end(bool e)
        {
            txtName.Enabled = e;
            txtPhone.Enabled = e;
            txtEmail.Enabled = e;
            txtSpending.Enabled = e;
            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            btnAdd.Enabled = !e;
            btnUpdate.Enabled = !e;
            btnDelete.Enabled = !e;
        }

        void clearData()
        {
            txtId.Text = Models.Connection.ExcuteScalar(string.Format("select IdKhachHang=dbo.fcgetIdKhachHang()"));
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtSpending.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustomerForm_Load(sender, e);
            dis_end(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _Id = "";
            try
            {
                _Id = txtId.Text;
            }
            catch { }
            string _Name = "";
            try
            {
                _Name = txtName.Text;
            }
            catch { }
            string _Phone = "";
            try
            {
                _Phone = txtPhone.Text;
            }
            catch { }
            string _Email = "";
            try
            {
                _Email = txtEmail.Text;
            }
            catch { }
            float _Spending = 0;
            try
            {
                _Spending = (float)Convert.ToDecimal(txtSpending.Text, CultureInfo.GetCultureInfo("en-US"));
            }
            catch { }
            if (flag == 0)
            {
                if (_Id == "" || _Name == "") MessageBox.Show("Hãy nhập đầy đủ thông tin!");
                else
                {
                    int i = 0;
                    i = Controllers.CustomerCtrl.CustomerInsert(_Id, _Name, _Phone, _Email, _Spending);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        HienThiDS();
                    }
                    else MessageBox.Show("Thêm thất bại! Hãy kiểm tra lại thông tin!");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.CustomerCtrl.CustomerUpdate(_Id, _Name, _Phone, _Email, _Spending);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HienThiDS();
                }
                else MessageBox.Show("Sửa thất bại! Hãy kiểm tra lại thông tin!");
            }
            CustomerForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string _id = "";
            try
            {
                _id = txtId.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.CustomerCtrl.CustomerDelete(_id);
                if (i > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    HienThiDS();
                    CustomerForm_Load(sender, e);
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
            uctCustomerSearch uctS = new uctCustomerSearch();
            nhung(uctS);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSpending_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnSearch.Controls.Clear();
            pnSearch.BorderStyle = BorderStyle.None;
        }
    }
}