using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 排考系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            //Application.Run(new Main());
            //Application.Run(new About());
            //Application.Run(new CourseList());
            //Application.Run(new ExamSTable());
            Application.Run(new ConstrainedCondition()); 
        }
    }
}
