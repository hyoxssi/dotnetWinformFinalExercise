using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetFinalExercise.Views
{
    public partial class uctCustomerSearch : UserControl
    {
        public uctCustomerSearch()
        {
            InitializeComponent();
        }

        void loadControl()
        {
            cbSearch.Items.Clear();
            cbSearch.Items.Add("Id Khách hàng");
            cbSearch.Items.Add("Tên Khách hàng");
        }

        private void uctCustomerSearch_Load(object sender, EventArgs e)
        {
            cbSearch.Text = "Tên Khách hàng";
            loadControl();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (cbSearch.Text == "Id Khách hàng")
                {
                    string id = tbSearch.Text;
                    DataTable dt = new DataTable();
                    dt = Controllers.CustomerCtrl.FillDS_SearchKhachHangByIdKhachHang(id).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        dgvDS.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Id " + tbSearch.Text + " không có trong dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string name = tbSearch.Text;
                    DataTable dt = new DataTable();
                    dt = Controllers.CustomerCtrl.FillDS_SearchKhachHangByTenKhachHang(name).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        dgvDS.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Tên " + tbSearch.Text + " không có trong dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Id Khách hàng")
            {
                string id = tbSearch.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.CustomerCtrl.FillDS_SearchKhachHangByIdKhachHang(id).Tables[0];
                dgvDS.DataSource = dt;
            }
            else
            {
                string name = tbSearch.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.CustomerCtrl.FillDS_SearchKhachHangByTenKhachHang(name).Tables[0];
                dgvDS.DataSource = dt;
            }
        }
    }
}
