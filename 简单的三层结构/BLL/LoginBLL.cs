using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        public bool BLogin(User User)
        {
            UserDAL duser = new UserDAL();
            User euser = new User();
            euser = duser.Dlogin(User);
            if (euser.Pwd == User.Pwd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
