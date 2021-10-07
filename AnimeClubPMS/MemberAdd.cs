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
    public partial class MemberAdd : Form
    {
        public MemberAdd()
        {
            InitializeComponent();
        }

        private void tbx_uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string username = tbx_username.Text;
            string password = tbx_password.Text;
            string phone_number = tbx_phone.Text;
            string address = tbx_address.Text;
            string email = tbx_email.Text;
            string group = comboBox1.Text;

            if (username == "" || password == "" || phone_number == "" || address == "" || email == ""  )
            {
                MessageBox.Show("注册信息不能为空！");
                this.Close();
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("邮箱格式不正确！");
            }

            if(phone_number.Length != 11)
            {
                MessageBox.Show("电话格式不正确！");
            }

            String connetStr = "server=localhost;port=3306;user=root;password=123456; database=db_companypms;SslMode=none";
            MySqlConnection conn = new MySqlConnection(connetStr);
            conn.Open();

            String sql1 = "INSERT INTO userinfo(uname,upass,utel,uemail,uaddress) VALUES('" + username + "','" + password + "','" + phone_number + "','" + email + "','" + address + "');"; // 没有判断重复插入
            //String sql1_1 = "UPDATE userinfo SET deptid = last_insert_id() WHERE id = last_insert_id();";
            String sql1_1 = " UPDATE userinfo SET deptid = last_insert_id() WHERE id = last_insert_id();";
            sql1 += sql1_1;
            String sql2 = " INSERT INTO deptinfo VALUES (last_insert_id(),'" + group + "', '" + group + "', '李四', 1);";
            sql1 += sql2;
            
            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("注册成功");
            conn.Close();
            this.Close();
            return;
        }

        private void MemberAdd_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("睡觉部");//选择项1
            comboBox1.Items.Add("吃饭部");
            comboBox1.Items.Add("游乐部");
        }

        private void panelEx3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
