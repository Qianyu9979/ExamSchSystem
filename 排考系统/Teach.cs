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
    public partial class Teach : Form
    {
        public Teach()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialogTeach.ShowDialog() == DialogResult.OK)//显示“浏览文件夹”对话框
            {
                textBoxFile.Text = openFileDialogTeach.FileName;//返回选中的文件夹路径
            }
        }
    }
}
