using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entity;


namespace 简单的三层结构
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (txt_UserName.Text == "")
            {
                MessageBox.Show("请输入用户名");
                txt_UserName.Focus();
                return;
            }
            if (txt_PassWord.Text == "")
            {
                MessageBox.Show("请输入密码");
                txt_PassWord.Focus();
                return;
            }

            User euser = new User();
            euser.UserName = txt_UserName.Text;
            euser.Pwd = txt_PassWord.Text;
            try
            {
                BLL.LoginBLL bLogin = new BLL.LoginBLL();
                result = bLogin.BLogin(euser);
                if (result == true)
                {
                    MessageBox.Show("登陆成功");
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
