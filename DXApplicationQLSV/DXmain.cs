using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplicationQLSV
{
    public partial class DXmain : DevExpress.XtraEditors.XtraForm
    {
        public DXmain()
        {
            InitializeComponent();
        }

        private void menukhoa_Click(object sender, EventArgs e)
        {
            DXkhoa f = new DXkhoa();
            f.MdiParent = this;
            f.Show();
        }

        private void menuSinhvien_Click(object sender, EventArgs e)
        {
            DXsinhvien f = new DXsinhvien();
            f.MdiParent = this;
            f.Show();
        }

        private void menugv_Click(object sender, EventArgs e)
        {
            DXgv f = new DXgv();
            f.MdiParent = this;
            f.Show();
        }

        private void meukq_Click(object sender, EventArgs e)
        {
            DXkq f = new DXkq();
            f.MdiParent = this;
            f.Show();
        }

        private void menukh_Click(object sender, EventArgs e)
        {
            DXkh f = new DXkh();
            f.MdiParent = this;
            f.Show();
        }

        private void menuMonhoc_Click(object sender, EventArgs e)
        {
            DXmh f = new DXmh();
            f.MdiParent = this;
            f.Show();
        }
    }
}