using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

using System.Security.Cryptography;

namespace login_form_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private connection_DB con;
        private void login_Click(object sender, EventArgs e)
        {
            string tendangnhap = user.Text;
            string matkhau = pass.Text;

            connection_DB cn_mh = new connection_DB();
            SqlConnection cnn_mh = cn_mh.Load_Connection();
            DataTable dtb_mh = new DataTable();

            string strmain = "select * from nguoidung where tendangnhap='" + tendangnhap + "' and matkhau='" + matkhau + "'";

            dtb_mh = cn_mh.Get_DataTable(strmain, cnn_mh);
            string tenmh = "";
            if (dtb_mh.Rows.Count > 0)
            {
                he_thong ht = new he_thong();
                ht.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your login details are incorrect");
            }
            // lựa chọn dữ liêu trong select * form nguoidung
            // where tendangnhap = "+tendangnhap+" and matkhau = "+matkhau+"
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

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//change