using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetFinalExercise.Controllers
{
    internal class LoginCtrl
    {
        public static string CheckDangNhap(string _user, string _pass)
        {
            try
            {
                Models.LoginMod login = new Models.LoginMod(_user, _pass);
                return login.CheckLogin();
            }
            catch
            { return ""; }
        }
    }
}
