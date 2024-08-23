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
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            var tumoi = txtTuMoi.Text;
            var nghia = txtNghiaCuaTu.Text;
           lbTuMoi.Items.Add(tumoi);
            list.Add(nghia);

            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghiaCuaTu.Text = "";

            lbTuMoi.SelectedIndex = lbTuMoi.Items.Count - 1;
        }

        private void lbTuMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = lbTuMoi.SelectedIndex;

            txtNghia.Text = list[stt];


        }
    }
}
