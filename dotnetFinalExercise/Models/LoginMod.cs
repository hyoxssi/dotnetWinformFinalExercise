using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetFinalExercise.Models
{
    internal class LoginMod
    {
        protected string user { get; set; }
        protected string pass { get; set; }
        protected bool status { get; set; }
        public LoginMod(string _user, string _pass)
        {
            this.user = _user;
            this.pass = _pass;
        }

        public string CheckLogin()
        {
            string str = "";
            string[] para = new string[2] { "@IdDangNhap", "@MatKhau" };
            object[] value = new object[2] { user, pass };
            str = Models.Connection.ExcuteScalar("spCheckDangNhap", CommandType.StoredProcedure, para, value);
            return str;
        }
    }
}
