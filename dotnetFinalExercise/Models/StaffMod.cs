using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetFinalExercise.Models
{
    internal class StaffMod
    {
        protected string Id { get; set; }
        protected string Name { get; set; }
        protected string Sex { get; set; }
        protected DateTime DOB { get; set; }
        protected string Phone { get; set; }
        protected string Email { get; set; }

        public StaffMod(string _StaffId)
        {
            this.Id = _StaffId;
        }
        public StaffMod() { }
        public StaffMod(string id, string name, string sex, DateTime dOB, string phone, string email) : this(id)
        {
            Name = name;
            Sex = sex;
            DOB = dOB;
            Phone = phone;
            Email = email;
        }

        public int StaffInsert()
        {
            int i = 0;
            string [] paras = new string[6] { "@IdNhanVien", "@Ten", "@Ngaysinh", "@GioiTinh", "@DienThoai", "@Email" };
            object[] values = new object[6] { Id, Name, DOB, Sex, Phone, Email };
            i = Models.Connection.Excute_Sql("spInsertNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int StaffUpdate()
        {
            int i = 0;
            string[] paras = new string[6] { "@IdNhanVien", "@Ten", "@Ngaysinh", "@GioiTinh", "@DienThoai", "@Email" };
            object[] values = new object[6] { Id, Name, DOB, Sex, Phone, Email };
            i = Models.Connection.Excute_Sql("spUpdateNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int StaffDelete()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { Id };
            i = Models.Connection.Excute_Sql("spDeleteNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public static DataSet FillStaffDS()
        {
            return Models.Connection.FillDataSet("spgetNhanVien", CommandType.StoredProcedure);
        }
        public DataSet FillDS_getNhanVienByIdNhanVien()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { Id };
            ds = Models.Connection.FillDataSet("spgetNhanVienByIdNhanVien", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDS_SearchNhanVienByIdNhanVien()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { Id };
            ds = Models.Connection.FillDataSet("spSearchNVByIdNV", CommandType.StoredProcedure, paras, values);
            return ds;
        }

        public DataSet FillDS_SearchNhanVienByTenNhanVien()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@Ten" }; 
            object[] values = new object[1] { Id };
            ds = Models.Connection.FillDataSet("spSearchNVByTenNV", CommandType.StoredProcedure, paras, values); 
            return ds;
        }
    }
}
