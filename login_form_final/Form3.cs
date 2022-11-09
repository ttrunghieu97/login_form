using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form_final
{
    public partial class nguoi_dung : Form
    {
        public nguoi_dung()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string tendangnhap = txt_user.Text;
            string matkhau = txt_password.Text;

            string strSQL = "";
            strSQL = strSQL + "  insert into nguoidung(tendangnhap, matkhau) ";
            strSQL = strSQL + " values(N'" + tendangnhap + "', N'" + matkhau + "')";
            connection_DB cn_mh = new connection_DB();
            SqlConnection cnn_mh = cn_mh.Load_Connection();
            string x = "";
            x = cn_mh.Excute_DataTable(strSQL, cnn_mh);
            if (x == "")
            {
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }
    }
}
