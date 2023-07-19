using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetFinalExercise.Models
{
    internal class CustomerMod
    {
        protected string Id { get; set; }
        protected string Name { get; set; }
        protected string Phone { get; set; }
        protected string Email { get; set; }
        protected float Spending { get; set; }
        public CustomerMod(string _CustomerId)
        {
            this.Id = _CustomerId;
        }
        public CustomerMod() { }
        public CustomerMod(string id, string name, string phone, string email, float spending) : this(id)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Spending = spending;
        }

        public int CustomerInsert()
        {
            int i = 0;
            string[] paras = new string[5] { "@IdKhachHang", "@TenKhachHang", "@DienThoai", "@Email", "@ChiTieu" };
            object[] values = new object[5] { Id, Name, Phone, Email, Spending };
            i = Models.Connection.Excute_Sql("spInsertKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int CustomerUpdate()
        {
            int i = 0;
            string[] paras = new string[5] { "@IdKhachHang", "@TenKhachHang", "@DienThoai", "@Email", "@ChiTieu" };
            object[] values = new object[5] { Id, Name, Phone, Email, Spending };
            i = Models.Connection.Excute_Sql("spUpdateKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int CustomerDelete()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdKhachHang" };
            object[] values = new object[1] { Id };
            i = Models.Connection.Excute_Sql("spDeleteKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public static DataSet FillCustomerDS()
        {
            return Models.Connection.FillDataSet("spgetKhachHang", CommandType.StoredProcedure);
        }
        public DataSet FillDS_getKhachHangByIdKhachHang()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdKhachHang" };
            object[] values = new object[1] { Id };
            ds = Models.Connection.FillDataSet("spgetKhachHangByIdKhachHang", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDS_SearchKhachHangByIdKhachHang()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdKhachHang" };
            object[] values = new object[1] { Id };
            ds = Models.Connection.FillDataSet("spSearchKHByIdKH", CommandType.StoredProcedure, paras, values);
            return ds;
        }

        public DataSet FillDS_SearchKhachHangByTenKhachHang()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@TenKhachHang" };
            object[] values = new object[1] { Id };
            ds = Models.Connection.FillDataSet("spSearchKHByTenKH", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
