using BaoCao.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao.Forms
{
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        data dt = new data();
        string Username, Pass, Name, Quyen;
        public Form_Dashboard(string username, string password, string name, string quyen)
        {        
            InitializeComponent();
            timertime.Start();
            PanelWidth = panelleft.Width;
            isCollapsed = false;
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
            this.Username = username;
            this.Pass = password;
            this.Name = name;
            this.Quyen = quyen;

        }

        private void btnout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelleft.Width = panelleft.Width + 10;
                if (panelleft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelleft.Width = panelleft.Width - 10;
                if (panelleft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btnthugon_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnhome);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnsanpham);
            UC_Product ucpd = new UC_Product();
            AddControlsToPanel(ucpd);
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnnhanvien);
            UCEmployee uce = new UCEmployee();
            AddControlsToPanel(uce);
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            moveSidePanel(btncustomer);
            UC_Customer ucc = new UC_Customer();
            AddControlsToPanel(ucc);
        }

        private void btnmuahang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnmuahang);
            UC_Mua ucm = new UC_Mua();
            AddControlsToPanel(ucm);
        }
        private void timertime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbltime.Text = dt.ToString("HH:MM:ss");
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnthongke);
        }

        private void btnorder_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btnorder);
            UC_CTHD uccthd = new UC_CTHD();
            AddControlsToPanel(uccthd);
        }

        private void btnbill_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnbill);
            UC_Bill ucb = new UC_Bill();
            AddControlsToPanel(ucb);
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            if (Quyen == "banhang")
            {
                btnnhanvien.Enabled = false;
                btnthongke.Enabled = false;
                btnsanpham.Enabled = false;
                btnmuahang.Enabled = false;
                btnbill.Enabled = false;
            }
        }
    }
}
