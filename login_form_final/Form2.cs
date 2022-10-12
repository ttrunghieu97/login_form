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
    public partial class he_thong : Form
    {
        public he_thong()
        {
            InitializeComponent();
        }

        private void he_thong_Load(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cap_nhat nForm = new cap_nhat();
            nForm.ShowDialog();
        }
    }
}
