using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace dotnetFinalExercise.Models
{
    internal class ProductMod
    {
        protected string Id { get; set; }
        protected string Name { get; set; }
        protected string Category { get; set; }
        protected string Pet { get; set; }
        protected float Quantity { get; set; }
        protected float Price { get; set; }

        public ProductMod(string _ProductId)
        {
            this.Id = _ProductId;
        }
        public ProductMod() { }
        public ProductMod(string id, string name, string category, string pet, float quantity, float price) : this(id)
        {
            Name = name;
            Category = category;
            Pet = pet;
            Quantity = quantity;
            Price = price;
        }

        public int ProductInsert()
        {
            int i = 0;
            string[] paras = new string[6] { "@IdSanPham", "@TenSanPham", "@DanhMuc", "@ThuCung", "@SoLuong", "@DonGia" };
            object[] values = new object[6] { Id, Name, Category, Pet, Quantity, Price };
            i = Models.Connection.Excute_Sql("spInsertSanPham", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int ProductUpdate()
        {
            int i = 0;
            string[] paras = new string[6] { "@IdSanPham", "@TenSanPham", "@DanhMuc", "@ThuCung", "@SoLuong", "@DonGia" };
            object[] values = new object[6] { Id, Name, Category, Pet, Quantity, Price };
            i = Models.Connection.Excute_Sql("spUpdateSanPham", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int ProductDelete()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdSanPham" };
            object[] values = new object[1] { Id };
            i = Models.Connection.Excute_Sql("spDeleteSanPham", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public static DataSet FillProductDS()
        {
            return Models.Connection.FillDataSet("spgetSanPham", CommandType.StoredProcedure);
        }
        public DataSet FillDS_getSanPhamByIdSanPham()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdSanPham" };
            object[] values = new object[1] { Id };
            ds = Models.Connection.FillDataSet("spgetSanPhamByIdSanPham", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDS_SearchSanPhamByIdSanPham()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdSanPham" };
            object[] values = new object[1] { Id };
            ds = Models.Connection.FillDataSet("spSearchSPByIdSP", CommandType.StoredProcedure, paras, values);
            return ds;
        }

        public DataSet FillDS_SearchSanPhamByTenSanPham()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@TenSanPham" };
            object[] values = new object[1] { Id };
            ds = Models.Connection.FillDataSet("spSearchSPByTenSP", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
