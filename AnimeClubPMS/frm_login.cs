using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AnimeClubPMS
{
    public partial class frm_login : Form
    {
        public bool closeflag = true;
        public frm_login()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username, password;
            username = tbx_uname.Text;
            password = tbx_upass.Text;

            String connetStr = "server=localhost;port=3306;user=root;password=123456; database=db_companypms;SslMode=none";
            MySqlConnection conn = new MySqlConnection(connetStr);
            conn.Open();

            String sql = "select uname,upass from userinfo where uname='" + username + "'and upass='" + password + "'";//SQL语句实现表数据的读取
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader sqlDataReader = cmd.ExecuteReader();

            if (sqlDataReader.HasRows)  //如果能查到，说明该用户密码存在
            {
                MessageBox.Show("登陆成功");

                closeflag = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("账号或密码错误或未注册");
            }
            conn.Close();
        }
    }
    
}
