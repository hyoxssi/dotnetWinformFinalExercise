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
    public partial class uctProductSearch : UserControl
    {
        public uctProductSearch()
        {
            InitializeComponent();
        }

        void loadControl()
        {
            cbSearch.Items.Clear();
            cbSearch.Items.Add("Id Sản phẩm");
            cbSearch.Items.Add("Tên Sản phẩm");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (cbSearch.Text == "Id Sản phẩm")
                {
                    string id = tbSearch.Text;
                    DataTable dt = new DataTable();
                    dt = Controllers.ProductCtrl.FillDS_SearchSanPhamByIdSanPham(id).Tables[0];
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
                    dt = Controllers.ProductCtrl.FillDS_SearchSanPhamByTenSanPham(name).Tables[0];
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

        private void uctProductSearch_Load(object sender, EventArgs e)
        {
            cbSearch.Text = "Tên Sản phẩm";
            loadControl();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Id Sản phẩm")
            {
                string id = tbSearch.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.ProductCtrl.FillDS_SearchSanPhamByIdSanPham(id).Tables[0];
                dgvDS.DataSource = dt;
            }
            else
            {
                string name = tbSearch.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.ProductCtrl.FillDS_SearchSanPhamByTenSanPham(name).Tables[0];
                dgvDS.DataSource = dt;
            }
        }
    }
}
