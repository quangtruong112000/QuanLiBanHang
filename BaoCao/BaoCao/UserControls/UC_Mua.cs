using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao.UserControls
{
    public partial class UC_Mua : UserControl
    {
        public UC_Mua()
        {
            InitializeComponent();
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            F_Sanphammoi sp = new F_Sanphammoi();
            sp.Show();
        }
    }
}
