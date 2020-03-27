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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.MdiParent = this;
            changePassword.Show();

        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//关闭所有应用程序
        }

        //数据导入
        private void ToolStripMenuItemCourseList_Click(object sender, EventArgs e)
        {
            CourseList courseList = new CourseList();
            courseList.MdiParent = this;
            courseList.Show();

        }

        private void ToolStripMenuItemTeach_Click(object sender, EventArgs e)
        {
            Teach teach = new Teach();
            teach.MdiParent = this;
            teach.Show();

        }

        private void ToolStripMenuItemRoom_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.MdiParent = this;
            room.Show();

        }

        //排考设置
        private void ToolStripMenuItemConstrainedCondition_Click(object sender, EventArgs e)
        {
            ConstrainedCondition constrained = new ConstrainedCondition();
            constrained.MdiParent = this;
            constrained.Show();
        }

        //排考
        private void ETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamTimeArrange examTimeArrange = new ExamTimeArrange();
            examTimeArrange.MdiParent = this;
            examTimeArrange.Show();
        }

        private void EPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamPlaceArrange examPlaceArrange = new ExamPlaceArrange();
            examPlaceArrange.MdiParent = this;
            examPlaceArrange.Show();
        }

        private void IAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvigilatorArrange invigilatorArrange = new InvigilatorArrange();
            invigilatorArrange.MdiParent = this;
            invigilatorArrange.Show();
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.MdiParent = this;
            start.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultCheck resultCheck = new ResultCheck();
            resultCheck.MdiParent = this;
            resultCheck.Show();
        }

        //结果查询
        private void ToolStripMenuItemExamSTable_Click(object sender, EventArgs e)
        {
            ExamSTable examSTable = new ExamSTable();
            examSTable.MdiParent = this;
            examSTable.Show();
        }

        private void ToolStripMenuItemInvigilator_Click(object sender, EventArgs e)
        {
            InvigilatorTable invigilatorTable = new InvigilatorTable();
            invigilatorTable.MdiParent = this;
            invigilatorTable.Show();
        }

        private void ToolStripMenuItemClassroomTable_Click(object sender, EventArgs e)
        {
            ExamPlaceATable examPlaceATable = new ExamPlaceATable();
            examPlaceATable.MdiParent = this;
            examPlaceATable.Show();
        }

        private void ToolStripMenuItemClassExamTable_Click(object sender, EventArgs e)
        {
            ClassATable classATable = new ClassATable();
            classATable.MdiParent = this;
            classATable.Show();
        }


        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            About about = new About();  //创建“关于”子窗体对象
            about.ShowDialog();         //打开子窗体对象

        }
    }
}
