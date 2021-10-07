using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeClubPMS
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void 人员加入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberAdd memberAdd = new MemberAdd();
            memberAdd.ShowDialog();
        }

        private void 成员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Management member_Management = new Member_Management();
            member_Management.ShowDialog();
        }

        private void 用户加入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MemberfileAdd frm_MemberfileAdd = new frm_MemberfileAdd();
            frm_MemberfileAdd.ShowDialog();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberfileManage memberfileManage = new MemberfileManage();
            memberfileManage.ShowDialog();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
    }
}
