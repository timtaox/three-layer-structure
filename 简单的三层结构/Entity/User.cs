using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class User
    {
        private string userName;
        private string pwd;

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string Pwd
        {
            get
            {
                return pwd;
            }
            set
            {
                pwd = value;
            }
        }
    }
}


