using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string tendangnhap = user.Text;
            string matkhau = pass.Text;
            string str = "Ten dang nhap cua ban la: " + tendangnhap + "; Mat khau: " + matkhau;
            MessageBox.Show(str);
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void pass_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Ban muon thoat khong?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.ExitThread();
            } 
            else
            { }
        }
        private void passs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//test change 1
//test change 2