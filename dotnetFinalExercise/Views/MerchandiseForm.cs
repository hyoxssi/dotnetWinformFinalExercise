using DevExpress.XtraEditors;
using dotnetFinalExercise.Views;
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

namespace dotnetFinalExercise
{
    public partial class MerchandiseForm : DevExpress.XtraEditors.XtraForm
    {
        int flag = 0;
        public MerchandiseForm()
        {
            InitializeComponent();
        }

        private void MerchandiseForm_Load(object sender, EventArgs e)
        {
            HienThiDSSP();
            dis_end(false);
            binding();
        }

        public void HienThiDSSP()
        {
            dgvDS.DataSource = Models.ProductMod.FillProductDS().Tables[0];
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
            txtId.DataBindings.Add("Text", dgvDS.DataSource, "IdSanPham");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dgvDS.DataSource, "TenSanPham");
            cbbCategory.DataBindings.Clear();
            cbbCategory.DataBindings.Add("Text", dgvDS.DataSource, "DanhMuc");
            cbbPet.DataBindings.Clear();
            cbbPet.DataBindings.Add("Text", dgvDS.DataSource, "ThuCung");
            txtQuantity.DataBindings.Clear();
            txtQuantity.DataBindings.Add("Text", dgvDS.DataSource, "SoLuong");
            txtPrice.DataBindings.Clear();
            txtPrice.DataBindings.Add("Text", dgvDS.DataSource, "DonGia");
        }

        void dis_end(bool e)
        {
            txtName.Enabled = e;
            txtQuantity.Enabled = e;
            txtPrice.Enabled = e;
            cbbCategory.Enabled = e;
            cbbPet.Enabled = e;
            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            btnAdd.Enabled = !e;
            btnUpdate.Enabled = !e;
            btnDelete.Enabled = !e;
        }

        void loadControl()
        {
            cbbPet.Items.Clear();
            cbbPet.Items.Add("Chó");
            cbbPet.Items.Add("Mèo");
            cbbCategory.Items.Clear();
            cbbCategory.Items.Add("Thức Ăn");
            cbbCategory.Items.Add("Quần Áo");
            cbbCategory.Items.Add("Phụ Kiện");
        }

        void clearData()
        {
            txtId.Text = Models.Connection.ExcuteScalar(string.Format("select IdSanPham=dbo.fcgetIdSanPham()"));
            txtName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            loadControl();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MerchandiseForm_Load(sender, e);
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
            string _Pet = "";
            try
            {
                _Pet = cbbPet.Text;
            }
            catch { }
            string _Category = "";
            try
            {
                _Category = cbbCategory.Text;
            }
            catch { }
            float _Quantity = 0;
            try
            {
                _Quantity = (float) Convert.ToDecimal(txtQuantity.Text, CultureInfo.GetCultureInfo("en-US"));
            }
            catch { }
            float _Price = 0;
            try
            {
                _Price = (float)Convert.ToDecimal(txtPrice.Text, CultureInfo.GetCultureInfo("en-US"));
            }
            catch { }
            if (flag == 0)
            {
                if (_Id == "" || _Name == "") MessageBox.Show("Hãy nhập đầy đủ thông tin!");
                else
                {
                    int i = 0;
                    i = Controllers.ProductCtrl.ProductInsert(_Id, _Name, _Category, _Pet, _Quantity, _Price);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        HienThiDSSP();
                    }
                    else MessageBox.Show("Thêm thất bại! Hãy kiểm tra lại thông tin!");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.ProductCtrl.ProductUpdate(_Id, _Name, _Category, _Pet, _Quantity, _Price);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HienThiDSSP();
                }
                else MessageBox.Show("Sửa thất bại! Hãy kiểm tra lại thông tin!");
            }
            MerchandiseForm_Load(sender, e);
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
                i = Controllers.ProductCtrl.ProductDelete(_id);
                if (i > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    HienThiDSSP();
                    MerchandiseForm_Load(sender, e);
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
            uctProductSearch uctS = new uctProductSearch();
            nhung(uctS);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnSearch.Controls.Clear();
            pnSearch.BorderStyle = BorderStyle.None;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}