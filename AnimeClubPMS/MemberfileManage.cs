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
    public partial class MemberfileManage : Form
    {
        public MemberfileManage()
        {
            InitializeComponent();
        }

        static String connetStr = "server=localhost;port=3306;user=root;password=123456; database=db_companypms;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connetStr);

        private void MoneyAdd()
        {
            string name = tbx_keywords.Text;
            int money = int.Parse(tbx_money.Text);

            string sql = "UPDATE rewardsinfo SET 本次薪资 = "+money+",总共资产 = (select rewardsinfo.总共资产 WHERE uname = '"+name+"') +"+money+" WHERE uname = '"+name+"';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader sqlDataReader = cmd.ExecuteReader();
                MessageBox.Show("薪资修改成功！");
            }
            catch(Exception e)
            {
                MessageBox.Show("薪资修改失败！\n错误信息：" + e.Message + "\n错误来源：" + e.Source);
            }
        }

        private void QueryAll()
        {
            //String connetStr = "server=localhost;port=3306;user=root;password=123456; database=db_companypms;SslMode=none";
            //MySqlConnection conn = new MySqlConnection(connetStr);
            //conn.Open();
            string sql = "SELECT * FROM userfileinfo JOIN rewardsinfo ON userfileinfo.id = rewardsinfo.id;";
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
                dataGridView1.Columns[0].HeaderText = "id";
                dataGridView1.Columns[1].HeaderText = "姓名";
                dataGridView1.Columns[2].HeaderText = "民族";
                dataGridView1.Columns[3].HeaderText = "文化程度";
                dataGridView1.Columns[4].HeaderText = "身份证";
                dataGridView1.Columns[5].HeaderText = "filename";
                dataGridView1.Columns[6].HeaderText = "工作经验";
                dataGridView1.Columns[7].HeaderText = "专业技能";
                dataGridView1.Columns[8].HeaderText = "联系电话";
                dataGridView1.Columns[9].HeaderText = "联系邮箱";
                dataGridView1.Columns[10].HeaderText = "性别";
                dataGridView1.Columns[11].HeaderText = "所属派系";
                dataGridView1.Columns[12].HeaderText = "联系地址";
                dataGridView1.Columns[13].HeaderText = "所属省份";
                dataGridView1.Columns[14].HeaderText = "id";
                dataGridView1.Columns[15].HeaderText = "userid";
                dataGridView1.Columns[16].HeaderText = "uname";
                dataGridView1.Columns[17].HeaderText = "本次薪资";
                dataGridView1.Columns[18].HeaderText = "总共资产";

                //选择第四列不显示
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].Visible = false;
                dataGridView1.Columns[15].Visible = false;
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                reader.Close();
                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("错误信息：" + err.Message + "\n错误来源：" + err.Source);
                conn.Close();
            }
        }

        private void bind()//搜索
        {
            //String connetStr = "server=localhost;port=3306;user=root;password=123456; database=db_companypms;SslMode=none";
            //MySqlConnection conn = new MySqlConnection(connetStr);
            //conn.Open();
            try
            {
                string sql = "SELECT * FROM userfileinfo JOIN rewardsinfo ON userfileinfo.id = rewardsinfo.id";

                if (tbx_keywords.Text != "")
                {
                    sql += " AND 姓名 like '%" + tbx_keywords.Text + "%';";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                                                                 //将bs的数据来源设置为reader对象
                    BindingSource bs = new BindingSource();
                    bs.DataSource = reader;
                    //将表格的数据来源设置为bs对象
                    this.dataGridView1.DataSource = bs;

                    //设置每一列的标题
                    dataGridView1.Columns[0].HeaderText = "id";
                    dataGridView1.Columns[1].HeaderText = "姓名";
                    dataGridView1.Columns[2].HeaderText = "民族";
                    dataGridView1.Columns[3].HeaderText = "文化程度";
                    dataGridView1.Columns[4].HeaderText = "身份证";
                    dataGridView1.Columns[5].HeaderText = "filename";
                    dataGridView1.Columns[6].HeaderText = "工作经验";
                    dataGridView1.Columns[7].HeaderText = "专业技能";
                    dataGridView1.Columns[8].HeaderText = "联系电话";
                    dataGridView1.Columns[9].HeaderText = "联系邮箱";
                    dataGridView1.Columns[10].HeaderText = "性别";
                    dataGridView1.Columns[11].HeaderText = "所属派系";
                    dataGridView1.Columns[12].HeaderText = "联系地址";
                    dataGridView1.Columns[13].HeaderText = "所属省份";
                    dataGridView1.Columns[14].HeaderText = "id";
                    dataGridView1.Columns[15].HeaderText = "userid";
                    dataGridView1.Columns[16].HeaderText = "uname";
                    dataGridView1.Columns[17].HeaderText = "本次薪资";
                    dataGridView1.Columns[18].HeaderText = "总共资产";

                    //选择第四列不显示
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[13].Visible = false;
                    dataGridView1.Columns[14].Visible = false;
                    dataGridView1.Columns[15].Visible = false;
                    dataGridView1.Columns[16].Visible = false;
                    dataGridView1.Columns[12].Visible = false;
                    reader.Close();
                    conn.Close();
                }
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("错误信息：" + e.Message + "\n错误来源：" + e.Source);
                conn.Close();
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (tbx_keywords.Text == "") { QueryAll(); }

            else bind();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            conn.Open();

            MoneyAdd();

            conn.Close();

        }
    }
}
