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
    public partial class Member_Management : Form
    {
        public Member_Management()
        {
            InitializeComponent();
        }

        private void Member_Management_Load(object sender, EventArgs e)
        {

        }

        static String connetStr = "server=localhost;port=3306;user=root;password=123456; database=db_companypms;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connetStr);
        

        private void bind()//搜索
        {
            //String connetStr = "server=localhost;port=3306;user=root;password=123456; database=db_companypms;SslMode=none";
            //MySqlConnection conn = new MySqlConnection(connetStr);
            //conn.Open();
            try
            {
                string sql = "SELECT * FROM userinfo JOIN deptinfo ON userinfo.deptid = deptinfo.id";

                if (tbx_keywords.Text != "")
                {
                    sql += " AND uname like '%" + tbx_keywords.Text + "%';";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                                                                 //将bs的数据来源设置为reader对象
                    BindingSource bs = new BindingSource();
                    bs.DataSource = reader;
                    //将表格的数据来源设置为bs对象
                    this.dataGridView1.DataSource = bs;

                    //设置每一列的标题
                    dataGridView1.Columns[0].HeaderText = "身份码";
                    dataGridView1.Columns[1].HeaderText = "姓名";
                    dataGridView1.Columns[2].HeaderText = "密码";
                    dataGridView1.Columns[3].HeaderText = "电话";
                    dataGridView1.Columns[4].HeaderText = "邮箱";
                    dataGridView1.Columns[5].HeaderText = "地址";
                    dataGridView1.Columns[6].HeaderText = "员工编号";
                    dataGridView1.Columns[7].HeaderText = "职权";
                    dataGridView1.Columns[8].HeaderText = "工号";
                    dataGridView1.Columns[9].HeaderText = "dname";
                    dataGridView1.Columns[10].HeaderText = "dinfo";
                    dataGridView1.Columns[11].HeaderText = "dleader";
                    dataGridView1.Columns[12].HeaderText = "dnum";

                    //选择第四列不显示
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    reader.Close();
                    conn.Close();
                }
            }catch(ArgumentException e)
            {
                MessageBox.Show("错误信息：" + e.Message + "\n错误来源：" + e.Source);
                conn.Close();
            }

        }

        private void QueryAll()
        {
            //String connetStr = "server=localhost;port=3306;user=root;password=123456; database=db_companypms;SslMode=none";
            //MySqlConnection conn = new MySqlConnection(connetStr);
            //conn.Open();
            string sql = "SELECT * FROM userinfo JOIN deptinfo ON userinfo.deptid = deptinfo.id;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                // DataSet ds = new DataSet();
                MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                //将bs的数据来源设置为reader对象
                BindingSource bs = new BindingSource();
                bs.DataSource = reader;
                //将表格的数据来源设置为bs对象
                this.dataGridView1.DataSource = bs;

                //设置每一列的标题
                dataGridView1.Columns[0].HeaderText = "身份码";
                dataGridView1.Columns[1].HeaderText = "姓名";
                dataGridView1.Columns[2].HeaderText = "密码";
                dataGridView1.Columns[3].HeaderText = "电话";
                dataGridView1.Columns[4].HeaderText = "邮箱";
                dataGridView1.Columns[5].HeaderText = "地址";
                dataGridView1.Columns[6].HeaderText = "员工编号";
                dataGridView1.Columns[7].HeaderText = "职权";
                dataGridView1.Columns[8].HeaderText = "工号";
                dataGridView1.Columns[9].HeaderText = "dname";
                dataGridView1.Columns[10].HeaderText = "dinfo";
                dataGridView1.Columns[11].HeaderText = "dleader";
                dataGridView1.Columns[12].HeaderText = "dnum";

                //选择第四列不显示
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                reader.Close();
                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("错误信息：" + err.Message + "\n错误来源：" + err.Source);
                conn.Close();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)//搜索功能
        {
            conn.Open();
            if (tbx_keywords.Text == "") { QueryAll(); }

            else bind();

           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)//删除功能
        {
            conn.Open();
            string id = tbx_keywords.Text;
            //int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();  //选中行的第1行，第2列
            //数据库连接串

            try
            {
                //MySqlConnection conn = new MySqlConnection(connStr);
                string sql = "delete from userinfo where id=" + id;
                //填充占位符
                //创建命令执行器对象
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //执行SQL语句
                cmd.ExecuteNonQuery();
                //弹出消息提示删除成功
                MessageBox.Show("删除成功！");
                //调用查询全部的方法，刷新DataGridView控件中的数据
                QueryAll();
            }
            catch (Exception err)
            {
                MessageBox.Show("错误信息：" + err.Message + "\n错误来源：" + err.Source);
                conn.Close();
            }
            conn.Close();
        }
    }
}
