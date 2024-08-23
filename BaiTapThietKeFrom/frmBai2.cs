﻿using System;
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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            var item = listBox2.SelectedItem;
            listBox2.Items.Remove(item);
            
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int SoTien = 0;

            foreach (string hang in listBox2.Items) 
            {
            switch (hang)              
               {
                    case "chuot":
                        SoTien += 100000;
                        break;
                    case "ban phim":
                        SoTien += 150000;
                        break;
                    case "may in":
                        SoTien += 2000000;
                        break;
                    case "USB Kingmax":
                        SoTien += 200000;
                        break;
                }
            }
            lbThanhToan.Text=SoTien.ToString();
        }

        private void lbThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
