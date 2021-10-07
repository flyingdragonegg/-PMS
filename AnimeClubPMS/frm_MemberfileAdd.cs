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

using Microsoft.Office.Interop.Word;

namespace AnimeClubPMS
{
    public partial class frm_MemberfileAdd : Form
    {
        public frm_MemberfileAdd()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string username = tbx_name.Text;//姓名
            string nation = tbx_nation.Text;//民族
            string education = tbx_education.Text;//文化程度
            string phone_number = tbx_phone.Text;//联系电话
            string address = tbx_address.Text;//联系地址
            string email = tbx_email.Text;//联系邮箱
            string sex = comb_sex.Text;//性别
            string group = comb_dept.Text;//所属派系
            string uid = tbx_deptid.Text;//员工码
            string idcard = tbx_ucardid.Text;//身份证号
            string province = tbx_uprovince.Text;//所属省份 

            string workexp = tbx_workexp.Text;//工作经验
            string workpro = tbx_workpro.Text;//专业技能

            if (username == "" || nation == "" || education == "" || phone_number == "" || address == "" || email == "" || sex == ""|| group == "" || uid == "" || idcard == "" || province == "" || workexp == "" || workpro == ""  )
            {
                MessageBox.Show("添加信息不能为空！");
                this.Close();
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("邮箱格式不正确！");
            }

            if (phone_number.Length != 11)
            {
                MessageBox.Show("电话格式不正确！");
            }

            String connetStr = "server=localhost;port=3306;user=root;password=123456; database=db_companypms;SslMode=none";
            MySqlConnection conn = new MySqlConnection(connetStr);
            conn.Open();

            String sql1 = "INSERT INTO userfileinfo(姓名,民族,文化程度,成员码,工作经验,专业技能,联系电话,联系邮箱,性别,所属派系,联系地址,所属省份) VALUES('" + username + "','" + nation + "','" + education + "','" + idcard + "','" + workexp + "','" + workpro + "','" + phone_number + "','" + email + "','" + sex + "','" + group + "','" + address + "','" + province + "'); "; // 没有判断重复插入
            //String sql1_1 = "UPDATE userinfo SET deptid = last_insert_id() WHERE id = last_insert_id();";
            //String sql1_1 = " UPDATE userinfo SET deptid = last_insert_id() WHERE id = last_insert_id();";
            //sql1 += sql1_1;//复用代码，自写太累
            string sql2 = " INSERT INTO rewardsinfo(id) VAlUES(last_insert_id());";
            sql1 += sql2;
            string sql3 = "UPDATE userfileinfo,rewardsinfo set userid = userfileinfo.id WHERE userfileinfo.id = rewardsinfo.id;";
            sql1 += sql3;
            string sql4 = "UPDATE userfileinfo,rewardsinfo set uname = userfileinfo.姓名 WHERE userfileinfo.id = rewardsinfo.id;";
            sql1 += sql4;

            MySqlCommand cmd = new MySqlCommand(sql1, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("成员增加成功");
            conn.Close();
            
            return;
        }

        private void comb_sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comb_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void frm_MemberfileAdd_Load(object sender, EventArgs e)
        {
            comb_sex.Items.Add("男");
            comb_sex.Items.Add("女"); 
            comb_dept.Items.Add("吃饭部");
            comb_dept.Items.Add("睡觉部");
            comb_dept.Items.Add("游乐部");
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            //创建一个Word应用程序实例
            Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application();
            //设置为不可见
            oWord.Visible = false;
            //模板文件地址，这里假设在X盘根目录
            object oTemplate = "C://Users//ASUS//Desktop//试试就逝世//information.doc";
            //以模板为基础生成文档
            Microsoft.Office.Interop.Word._Document oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);
            //声明书签数组
            object[] oBookMark = new object[11];
            //赋值书签名
            oBookMark[0] = "uname";
            oBookMark[1] = "id";
            oBookMark[2] = "deptname";
            oBookMark[3] = "usex";
            oBookMark[4] = "ucardid";
            oBookMark[5] = "uprovince";
            oBookMark[6] = "uemail";
            oBookMark[7] = "uaddress";
            oBookMark[8] = "utel";
            oBookMark[9] = "workexp";
            oBookMark[10] = "workpro";            
            //赋值任意数据到书签的位置
            oDoc.Bookmarks.get_Item(ref oBookMark[0]).Range.Text = tbx_name.Text;
            oDoc.Bookmarks.get_Item(ref oBookMark[1]).Range.Text = tbx_deptid.Text;
            oDoc.Bookmarks.get_Item(ref oBookMark[2]).Range.Text = comb_dept.Text;
            oDoc.Bookmarks.get_Item(ref oBookMark[3]).Range.Text = comb_sex.Text;
            oDoc.Bookmarks.get_Item(ref oBookMark[4]).Range.Text = tbx_ucardid.Text;
            oDoc.Bookmarks.get_Item(ref oBookMark[5]).Range.Text = tbx_uprovince.Text;
            oDoc.Bookmarks.get_Item(ref oBookMark[6]).Range.Text = tbx_email.Text;
            oDoc.Bookmarks.get_Item(ref oBookMark[7]).Range.Text = tbx_address.Text;
            oDoc.Bookmarks.get_Item(ref oBookMark[8]).Range.Text = tbx_phone.Text;
            oDoc.Bookmarks.get_Item(ref oBookMark[9]).Range.Text = tbx_workexp.Text;
            oDoc.Bookmarks.get_Item(ref oBookMark[10]).Range.Text = tbx_workpro.Text;
            //弹出保存文件对话框，保存生成的Word
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Document(*.doc)|*.doc";
            sfd.DefaultExt = "Word Document(*.doc)|*.doc";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                object filename = sfd.FileName;

                oDoc.SaveAs(ref filename, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);
                oDoc.Close(ref oMissing, ref oMissing, ref oMissing);
                //关闭word
                oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
            }
        }
    }
}
