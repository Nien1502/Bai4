using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap04
{
    public partial class Form2 : Form
    {
        public delegate void LuuNhanVien(NhanVien nhanVien);
        public event LuuNhanVien Luu;

        private NhanVien nhanVien;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(NhanVien nv) : this()
        {
            nhanVien = nv;
            if (nhanVien != null)
            {
                txt_MSNV.Text = nhanVien.MSNV;
                txt_TenNV.Text = nhanVien.TenNV;
                txt_LuongCB.Text = nhanVien.LuongCB.ToString();
            }
        }
        private void btn_DongY_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_LuongCB.Text, out decimal luong))
            {
                nhanVien = new NhanVien
                {
                    MSNV = txt_MSNV.Text,
                    TenNV = txt_TenNV.Text,
                    LuongCB = luong
                };
                Luu?.Invoke(nhanVien);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lương cơ bản phải là số hợp lệ!", "Lỗi");
            }
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
