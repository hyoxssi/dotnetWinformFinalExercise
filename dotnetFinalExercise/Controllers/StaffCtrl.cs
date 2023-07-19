using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetFinalExercise.Controllers
{
    internal class StaffCtrl
    {
        public static DataSet FillDS_getNhanVienByIdNhanVien(string _idNhanVien)
        {
            try
            {
                Models.StaffMod staff = new Models.StaffMod(_idNhanVien);
                return staff.FillDS_getNhanVienByIdNhanVien();
            }
            catch { return null; }
        }
        public static int StaffInsert(string id, string name, string sex, DateTime dOB, string phone, string email)
        {
            try
            {
                Models.StaffMod staff = new Models.StaffMod(id, name, sex, dOB, phone, email);
                return staff.StaffInsert();
            }
            catch { return 0; }
        }

        public static int StaffUpdate(string id, string name, string sex, DateTime dOB, string phone, string email)
        {
            try
            {
                Models.StaffMod staff = new Models.StaffMod(id, name, sex, dOB, phone, email);
                return staff.StaffUpdate();
            }
            catch { return 0; }
        }

        public static int StaffDelete(string id)
        {
            try
            {
                Models.StaffMod staff = new Models.StaffMod(id);
                return staff.StaffDelete();
            }
            catch { return 0; }
        }

        public static DataSet FillDS_SearchNhanVienByIdNhanvien(string id)
        {
            try
            {
                Models.StaffMod staff = new Models.StaffMod(id); 
                return staff.FillDS_SearchNhanVienByIdNhanVien();
            }
            catch { return null; }

        }

        public static DataSet FillDS_SearchNhanVienByTenNhanvien(string name)
        {
            try
            {
                Models.StaffMod staff = new Models.StaffMod(name);
                return staff.FillDS_SearchNhanVienByTenNhanVien();
            }
            catch { return null; }

        }
    }
}
