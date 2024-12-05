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
    public partial class Form1 : Form
    {
        private List<NhanVien> danhSachNhanVien = new List<NhanVien>();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            if (dgv_NhanVien.Columns.Count == 0)
            {
                dgv_NhanVien.Columns.Add("MSNV", "Mã Số NV");
                dgv_NhanVien.Columns.Add("TenNV", "Tên NV");
                dgv_NhanVien.Columns.Add("LuongCB", "Lương Cơ Bản");
            }

            dgv_NhanVien.Rows.Clear();
            foreach (var nv in danhSachNhanVien)
            {
                dgv_NhanVien.Rows.Add(nv.MSNV, nv.TenNV, nv.LuongCB);
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Luu += (NhanVien nv) =>
            {
                danhSachNhanVien.Add(nv); 
                LoadData();               
            };

            form2.ShowDialog();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_NhanVien.CurrentRow != null)
            {
                int index = dgv_NhanVien.CurrentRow.Index;
                danhSachNhanVien.RemoveAt(index);
                LoadData(); 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_NhanVien.CurrentRow != null)
            {
                int index = dgv_NhanVien.CurrentRow.Index;
                NhanVien selectedNhanVien = danhSachNhanVien[index];
                Form2 form2 = new Form2(selectedNhanVien);
                form2.Luu += (NhanVien nv) =>
                {
                    danhSachNhanVien[index] = nv;
                    LoadData();                  
                };
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!", "Thông báo");
            }
        }
      

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn đóng hay không?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
