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
using System.Globalization;

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
            string str_sql = "";
            str_sql = str_sql + "select * from sinhvien";

            connection_DB cn_mh = new connection_DB();
            SqlConnection cnn_mh = cn_mh.Load_Connection();
            DataTable dtb_mh = new DataTable();

            dtb_mh = cn_mh.Get_DataTable(str_sql, cnn_mh);

            dataGridView1.DataSource = dtb_mh;
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
            connection_DB cn_mh = new connection_DB();
            SqlConnection cnn_mh = cn_mh.Load_Connection();
            DataTable dtb_mh = new DataTable();
            string sql = "";
            sql = sql + "select * from sinhvien";
            dtb_mh = cn_mh.Get_DataTable(sql, cnn_mh);
            dataGridView1.DataSource = dtb_mh;
            dataGridView1.Refresh();
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            string masinhvien = txt_masv.Text;
            string hoten = txt_hoten.Text;
            string ngaysinh = calendar_ngaysinh.Text;
            int gioitinh = 0;
            if (rbt_nam.Checked == true)
            {
                gioitinh = 1;
            }
            else if (rbt_nu.Checked == true)
            {
                gioitinh = 0;
            }
            string quequan = txt_que_quan.Text;
            string sothich = "";
            if (rbt_game.Checked == true)
            {
                sothich = sothich + " ;" + rbt_game.Text;
            }
            if (rbt_phuot.Checked == true)
            {
                sothich = sothich + " ;" + rbt_phuot.Text;
            }
            if (rbt_music.Checked == true)
            {
                sothich = sothich + " ;" + rbt_music.Text;
            }
            if (rbt_thethao.Checked == true)
            {
                sothich = sothich + " ;" + rbt_thethao.Text;
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

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string masv = txt_masv.Text;
            string hoten = txt_hoten.Text;
            string ngaysinh = calendar_ngaysinh.Text;
            int gt = 0;
            if (rbt_nam.Checked==true)
            {
                gt = 1;
            }    
            else if (rbt_nu.Checked == true)
            {
                gt = 0;
            }
            string quequan = txt_que_quan.Text;
            string sothich = "";
            if (rbt_game.Checked == true)
            {
                sothich = sothich + rbt_game.Text + ";";
            }
            if (rbt_phuot.Checked == true)
            {
                sothich = sothich + " ; " + rbt_phuot.Text;
            }
            if (rbt_music.Checked == true)
            {
                sothich = sothich + " ; " + rbt_music.Text;
            }
            if (rbt_thethao.Checked == true)
            {
                sothich = sothich + " ; " + rbt_thethao.Text;
            }
            if (rbt_game .Checked==true)
            {
                sothich = sothich + rbt_game.Text;
            }    
            string str_sql = "";

            str_sql = str_sql + " update sinhvien set  hoten = N'" + hoten + "', ngaysinh = '" + ngaysinh + "', ";
            str_sql = str_sql + " gioitinh = " + gt + ", quequan = N'" + quequan + "', sothich = N'" + sothich + "', ghichu = ''";
            str_sql = str_sql + " where masv = '" + masv + "'";

            DataTable dtb_mh = new DataTable();
            connection_DB cn_mh = new connection_DB();
            SqlConnection cnn_mh = cn_mh.Load_Connection();
            string x = "";
            x = cn_mh.Excute_DataTable(str_sql, cnn_mh);
            if (x == "")
            {
                MessageBox.Show("cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("cap nhat that bai");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string masv = txt_masv.Text;

            string str_sql = "";
            str_sql = str_sql + "delete from sinhvien where masv='" + masv + "'";

            connection_DB cn_mh = new connection_DB();
            SqlConnection cnn_mh = cn_mh.Load_Connection();
            DataTable dtb_mh = new DataTable();

            string x = cn_mh.Excute_DataTable(str_sql, cnn_mh);
            if (x == "")
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            connection_DB cn_mh = new connection_DB();
            SqlConnection cnn_mh = cn_mh.Load_Connection();
            DataTable dtb_mh = new DataTable();
            string sql = "";
            sql = sql + "select * from sinhvien";
            dtb_mh = cn_mh.Get_DataTable(sql, cnn_mh);
            dataGridView1.DataSource = dtb_mh;
            dataGridView1.Refresh();
        }
    }
}
