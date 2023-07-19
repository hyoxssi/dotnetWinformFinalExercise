using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetFinalExercise.Controllers
{
    internal class CustomerCtrl
    {
        public static DataSet FillDS_getKhachHangByIdKhachHang(string _idKhachHang)
        {
            try
            {
                Models.CustomerMod Customer = new Models.CustomerMod(_idKhachHang);
                return Customer.FillDS_getKhachHangByIdKhachHang();
            }
            catch { return null; }
        }
        public static int CustomerInsert(string id, string name, string phone, string email, float spending)
        {
            try
            {
                Models.CustomerMod Customer = new Models.CustomerMod(id, name, phone, email, spending);
                return Customer.CustomerInsert();
            }
            catch { return 0; }
        }

        public static int CustomerUpdate(string id, string name, string phone, string email, float spending)
        {
            try
            {
                Models.CustomerMod Customer = new Models.CustomerMod(id, name, phone, email, spending);
                return Customer.CustomerUpdate();
            }
            catch { return 0; }
        }

        public static int CustomerDelete(string id)
        {
            try
            {
                Models.CustomerMod Customer = new Models.CustomerMod(id);
                return Customer.CustomerDelete();
            }
            catch { return 0; }
        }

        public static DataSet FillDS_SearchKhachHangByIdKhachHang(string id)
        {
            try
            {
                Models.CustomerMod Customer = new Models.CustomerMod(id);
                return Customer.FillDS_SearchKhachHangByIdKhachHang();
            }
            catch { return null; }

        }

        public static DataSet FillDS_SearchKhachHangByTenKhachHang(string name)
        {
            try
            {
                Models.CustomerMod Customer = new Models.CustomerMod(name);
                return Customer.FillDS_SearchKhachHangByTenKhachHang();
            }
            catch { return null; }

        }
    }
}
