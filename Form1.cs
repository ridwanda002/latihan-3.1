using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiSelamatDatang
{
    public partial class frmSelamatDatang : Form
    {
        public frmSelamatDatang()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnKeterangan2_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = "begitu mudahnya membuat aplikasi berbasis windows";
        }

        private void btnKeterangan1_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = "Selamat Datang di pemrograman c#";
        }
    }
}
