using BaoCao.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        data dt = new data();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            int dem = 0;
            List<User> listuser = dt.Users.ToList();
            foreach (var u in listuser)
            {
                if ((u.UserName == txtusername.Text) && (u.Password == txtpassword.Text))  
                
                {
                    dem = 1;
                    Form_Dashboard fd = new Form_Dashboard(u.UserName, u.Password,u.Name, u.MaQuyen);
                    fd.ShowDialog();
                    
                    return;
                }                                               
            }
            if (dem == 0)
            {
                MessageBox.Show("Bạn đã nhập sai!\nVui lòng nhập lại!");
            }
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
