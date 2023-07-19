using DevExpress.XtraEditors;
using dotnetFinalExercise.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dotnetFinalExercise
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string user;
        public static string idLogin;
        public Form1()
        {
            InitializeComponent();
            DisEndMenuLogin(true, idLogin);
        }

        public void DisEndMenuLogin(bool e, string _idLogin)
        {
            btnLogin.Enabled = e;
            btnLogout.Enabled = !e;
            btnCustomer.Enabled = !e;
            btnMerchandise.Enabled = !e;
            if (_idLogin == "1")
            {
                btnStaff.Enabled = e;
            }
            else
            {
                btnStaff.Enabled = !e;
            }
        }

        void OpenForm(Type typeForm)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeForm) 
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form) Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(StaffForm));
        }

        private void btnMerchandise_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(MerchandiseForm));
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn Thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // OpenForm(typeof(LoginForm));

            LoginForm login = null;
            Check_Login:
            if (login == null || login.IsDisposed) 
            {
                login = new LoginForm();
            }
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.txtUserID.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập vào User Name!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    goto Check_Login;
                }
                if (login.txtPass.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập vào Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    goto Check_Login;
                }
                string check = "";
                user = login.txtUserID.Text;
                // string password = Models.UserControl.SHA256(login.txtPass.Text);
                string password = login.txtPass.Text;
                check = Controllers.LoginCtrl.CheckDangNhap(user, password);
                if (check == "")
                {
                    XtraMessageBox.Show("Đăng nhập thất bại. Hãy kiểm tra lại thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto Check_Login;
                }
                else
                {
                    if (user == "admin") DisEndMenuLogin(false, idLogin);
                    else DisEndMenuLogin(false, "1");
                }
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn Đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DisEndMenuLogin(true, idLogin);
                //close all tab
                documentManager1.View.Controller.CloseAll();
                btnLogin_ItemClick(sender, e);
            }
        }

        private void btnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(CustomerForm));
        }
    }
}
