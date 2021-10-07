using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AnimeClubPMS
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
            //Application.Run(new frm_login());
            
            //从登录页面跳转到主页面
            frm_login form1 = new frm_login();
            form1.ShowDialog();  //模式窗口，先运行Form1的作用
            if (form1.closeflag == false)
            {
                Application.Run(new frm_main());
                //frm_main form2 = new frm_main();
                //form2.ShowDialog();
            }




        }
    }
}
