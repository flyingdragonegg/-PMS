
namespace AnimeClubPMS
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.人员信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员加入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户加入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人员信息管理ToolStripMenuItem,
            this.用户信息管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 人员信息管理ToolStripMenuItem
            // 
            this.人员信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人员加入ToolStripMenuItem,
            this.成员管理ToolStripMenuItem});
            this.人员信息管理ToolStripMenuItem.Name = "人员信息管理ToolStripMenuItem";
            this.人员信息管理ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.人员信息管理ToolStripMenuItem.Text = "登陆账号管理";
            // 
            // 人员加入ToolStripMenuItem
            // 
            this.人员加入ToolStripMenuItem.Name = "人员加入ToolStripMenuItem";
            this.人员加入ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.人员加入ToolStripMenuItem.Text = "成员加入";
            this.人员加入ToolStripMenuItem.Click += new System.EventHandler(this.人员加入ToolStripMenuItem_Click);
            // 
            // 成员管理ToolStripMenuItem
            // 
            this.成员管理ToolStripMenuItem.Name = "成员管理ToolStripMenuItem";
            this.成员管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.成员管理ToolStripMenuItem.Text = "成员管理";
            this.成员管理ToolStripMenuItem.Click += new System.EventHandler(this.成员管理ToolStripMenuItem_Click);
            // 
            // 用户信息管理ToolStripMenuItem
            // 
            this.用户信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户加入ToolStripMenuItem,
            this.用户管理ToolStripMenuItem});
            this.用户信息管理ToolStripMenuItem.Name = "用户信息管理ToolStripMenuItem";
            this.用户信息管理ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.用户信息管理ToolStripMenuItem.Text = "用户信息管理";
            // 
            // 用户加入ToolStripMenuItem
            // 
            this.用户加入ToolStripMenuItem.Name = "用户加入ToolStripMenuItem";
            this.用户加入ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.用户加入ToolStripMenuItem.Text = "用户加入";
            this.用户加入ToolStripMenuItem.Click += new System.EventHandler(this.用户加入ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.用户管理ToolStripMenuItem.Text = "薪资管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 28);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(982, 525);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.BackgroundImage = global::AnimeClubPMS.Properties.Resources.sagamodo_main;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            this.panelEx1.Click += new System.EventHandler(this.panelEx1_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "主页面";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 人员信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员加入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成员管理ToolStripMenuItem;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.ToolStripMenuItem 用户信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户加入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
    }
}