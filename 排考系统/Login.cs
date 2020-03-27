using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 排考系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (userName == "admin" && password == "1234")
            {
                //MessageBox.Show("欢迎登录排考系统", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();//隐藏当前窗体
                Main main = new Main();
                main.Show();//显示主界面            
            }
            else
            {
                MessageBox.Show("错误", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void labelForgetPassword_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();//显示忘记密码窗体
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
