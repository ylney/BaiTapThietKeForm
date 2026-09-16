using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtNghia.Text;
            listBox1.Items.Add(tu);
            list.Add(nghia);

            txtTuMoi.Focus();
            txtTuMoi.Text = " ";
            txtNghia.Text = " ";

            listBox1.SelectedIndex = listBox1.Items.Count - 1; //chọn phần tử cuối (mới thêm)
            txtHienThiNghia.Text = nghia;
        }

        //Click đôi vào listbox1
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lấy số thứ tự của từ trong Listbox
            var stt = listBox1.SelectedIndex;

            //Tra nghĩa của từ trong danh sách dựa vào số thứ tự
            txtHienThiNghia.Text = list[stt];
        }

        //Có thể cải tiến thêm 1 chút
        //1 là cho phép nhấn phím tab khi gõ cho từ mới, nghĩa và thêm mới
        //2 là sau khi nhấn thêm mới con trỏ quay lại ô từ mới để nhập tiếp
        //Xóa luôn căn bản trong 2 ô
        //Sau khi thêm từ, danh sách từ sẽ mặc định chọn vào từ mới được thêm
        //và nghĩa của từ đó xuất hiện bên khung nghĩa luôn
    }
}
