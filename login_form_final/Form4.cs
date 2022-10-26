using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;

namespace login_form_final
{
    public partial class cap_nhat : Form
    {
        public cap_nhat()
        {
            InitializeComponent();
        }

        private void cap_nhat_Load(object sender, EventArgs e)
        {
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void del_Click(object sender, EventArgs e)
        {

        }

        private void masv_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //// 
                
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            string masinhvien = txt_masv.Text;
            string hoten = txt_hoten.Text;
            string ngaysinh = dateTimePicker1.Text;
            int gioitinh = 0;
            if (rbt_nam.Checked == true)
            {
                gioitinh = 1;
            }
            else if (rbt_nu.Checked == true)
            {
                gioitinh = 0;
            }
            string quequan = que_quan.Text;
            string sothich = "";
            if (chk_game.Checked == true)
            {
                sothich = sothich + " ;" + chk_game.Text;
            }
            if (chk_phuot.Checked == true)
            {
                sothich = sothich + " ;" + chk_phuot.Text;
            }
            if (chk_music.Checked == true)
            {
                sothich = sothich + " ;" + chk_music.Text;
            }
            if (chk_thethao.Checked == true)
            {
                sothich = sothich + " ;" + chk_thethao.Text;
            }
            string ghichu = "";
            string strSQL = "";
            strSQL = strSQL + "  insert into sinhvien(masv, hoten, ngaysinh, gioitinh, ";
            strSQL = strSQL + " quequan, sothich, ghichu) ";
            strSQL = strSQL + " values('" + masinhvien + "', N'" + hoten + "', '" + ngaysinh + "', '" + gioitinh + "', ";
            strSQL = strSQL + "  N'" + quequan + "', N'" + sothich + "', '" + ghichu + "')";
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
