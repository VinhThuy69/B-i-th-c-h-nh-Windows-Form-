using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeFrom
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int so;
            for(int i = 0; i < 10; i++) 
            {
                so = random.Next(1,100);
                lbSo.Items.Add(so);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int TimSo = int.Parse(tbNhapSo.Text);

            foreach (int so in lbSo.Items) 
            {
                if (so == TimSo)
                    lbKetQua.Text = "Tim duoc ket qua";
                else
                    lbKetQua.Text = "Khong tim duoc ket qua";
                
            }
        }
    }
}
