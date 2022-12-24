using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class DXkq : DevExpress.XtraEditors.XtraForm
    {
        QLSVEntities data = new QLSVEntities();
        bool action = false;
        public DXkq()
        {
            InitializeComponent();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                var k = new KETQUA
                {
                    MASV = txtmasv.Text.Trim(),
                    MAMH = txtmamh.Text.Trim(),
                    LANTHI = int.Parse(txtlanthi.Text.Trim()),
                    DIEM = int.Parse(txtdiem.Text.Trim())
                };
                data.KETQUAs.Add(k);
                data.SaveChanges();
                getdata();
            }
            else
            {
                data = new QLSVEntities();
                var s = (from t in data.KETQUAs
                         where t.MASV == txtmasv.Text
                         select t
                         ).SingleOrDefault();


                s.DIEM = int.Parse(txtdiem.Text.Trim());
                data.SaveChanges();
                getdata();
            }
        }

        private void DXkq_Load(object sender, EventArgs e)
        {
            getdata();
            init();
        }
        void init()
        {
            menuDel.Enabled = false;
        }
        void getdata()
        {
            kETQUABindingSource.DataSource = data.KETQUAs.ToList();
        }

        private void menuDel_Click(object sender, EventArgs e)
        {
            data = new QLSVEntities();
            if (MessageBox.Show("Are you sure?", "Messsage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var kh = data.SINHVIENs.FirstOrDefault(x => x.MASV.Contains(txtmasv.Text));
                if (kh != null)
                {
                    MessageBox.Show("Không xóa được vì SV đang học!");
                }
                else
                {
                    var s = (from t in data.KETQUAs
                             where t.MASV == txtmasv.Text
                             select t
                         ).SingleOrDefault();

                    data.KETQUAs.Remove(s);
                    data.SaveChanges();
                    getdata();
                }
            }
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            txtmasv.ReadOnly = false;
            menuDel.Enabled = false;
            action = false;
            txtmasv.Clear();
            txtmamh.Clear();
            txtlanthi.Clear();
            txtdiem.Clear();
        }

        private void dgkqview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtmasv.ReadOnly = true;
            menuDel.Enabled = true;
            action = true;
            txtmasv.Text = dgkqview.GetFocusedRowCellValue("MASV").ToString();
            txtmamh.Text = dgkqview.GetFocusedRowCellValue("MAMH").ToString();
            txtlanthi.Text = dgkqview.GetFocusedRowCellValue("LANTHI").ToString();
            txtdiem.Text = dgkqview.GetFocusedRowCellValue("DIEM").ToString();
        }

        private void dgkqview_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            XtraReportkq rptkq = new XtraReportkq();
            rptkq.DataSource = dgkq.DataSource;
            ReportPrintTool tool = new ReportPrintTool(rptkq);
            tool.ShowPreview();
        }
    }
}