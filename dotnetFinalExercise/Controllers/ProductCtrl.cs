using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetFinalExercise.Controllers
{
    internal class ProductCtrl
    {
        public static DataSet FillDS_getSanPhamByIdSanPham(string _idSanPham)
        {
            try
            {
                Models.ProductMod Product = new Models.ProductMod(_idSanPham);
                return Product.FillDS_getSanPhamByIdSanPham();
            }
            catch { return null; }
        }
        public static int ProductInsert(string id, string name, string category, string pet, float quantity, float price)
        {
            try
            {
                Models.ProductMod Product = new Models.ProductMod(id, name, category, pet, quantity, price);
                return Product.ProductInsert();
            }
            catch { return 0; }
        }

        public static int ProductUpdate(string id, string name, string category, string pet, float quantity, float price)
        {
            try
            {
                Models.ProductMod Product = new Models.ProductMod(id, name, category, pet, quantity, price);
                return Product.ProductUpdate();
            }
            catch { return 0; }
        }

        public static int ProductDelete(string id)
        {
            try
            {
                Models.ProductMod Product = new Models.ProductMod(id);
                return Product.ProductDelete();
            }
            catch { return 0; }
        }

        public static DataSet FillDS_SearchSanPhamByIdSanPham(string id)
        {
            try
            {
                Models.ProductMod Product = new Models.ProductMod(id);
                return Product.FillDS_SearchSanPhamByIdSanPham();
            }
            catch { return null; }

        }

        public static DataSet FillDS_SearchSanPhamByTenSanPham(string name)
        {
            try
            {
                Models.ProductMod Product = new Models.ProductMod(name);
                return Product.FillDS_SearchSanPhamByTenSanPham();
            }
            catch { return null; }

        }
    }
}
