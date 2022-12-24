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
    public partial class DXkh : DevExpress.XtraEditors.XtraForm
    {
        QLSVEntities data = new QLSVEntities();
        bool action = false;
        public DXkh()
        {
            InitializeComponent();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                var k = new KHOAHOC
                {
                    MAKH = txtmakh.Text.Trim(),
                    MAGV = txtmagv.Text.Trim(),
                    MAMH = txtmamh.Text.Trim(),
                    NGAYBD = txtngaybd.Value,
                    NGAYKY = txtngaykt.Value,
                };
                data.KHOAHOCs.Add(k);
                data.SaveChanges();
                getdata();
            }
            else
            {
                data = new QLSVEntities();
                var s = (from t in data.KHOAHOCs
                         where t.MAKH == txtmakh.Text
                         select t
                         ).SingleOrDefault();

                s.MAGV = txtmagv.Text.Trim();
                s.MAMH = txtmamh.Text.Trim();
                s.NGAYBD = txtngaybd.Value;
                s.NGAYKY = txtngaykt.Value;
                data.SaveChanges();
                getdata();
            }
        }

        private void DXkh_Load(object sender, EventArgs e)
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
            kHOAHOCBindingSource.DataSource = data.KHOAHOCs.ToList();
        }

        private void menuDel_Click(object sender, EventArgs e)
        {
            data = new QLSVEntities();
            if (MessageBox.Show("Are you sure?", "Messsage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var kh = data.GIAOVIENs.FirstOrDefault(x => x.MAGV.Contains(txtmagv.Text));
                if (kh != null)
                {
                    MessageBox.Show("Không xóa được vì Khóa học đang trong HK!");
                }
                else
                {
                    var s = (from t in data.KHOAHOCs
                             where t.MAKH == txtmakh.Text
                             select t
                         ).SingleOrDefault();

                    data.KHOAHOCs.Remove(s);
                    data.SaveChanges();
                    getdata();
                }
            }
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            action = false;
            txtmakh.ReadOnly = false;
            menuDel.Enabled = false;
            txtmakh.Clear();
            txtmagv.Clear();
            txtmamh.Clear();
        }

        private void dgkhview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtmakh.ReadOnly = true;
            menuDel.Enabled = true;
            action = true;
            txtmakh.Text = dgkhview.GetFocusedRowCellValue("MAKH").ToString();
            txtmagv.Text = dgkhview.GetFocusedRowCellValue("MAGV").ToString();
            txtmamh.Text = dgkhview.GetFocusedRowCellValue("MAMH").ToString();            
        }

        private void dgkhview_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            XtraReportkh rptkh = new XtraReportkh();
            rptkh.DataSource = dgkh.DataSource;
            ReportPrintTool tool = new ReportPrintTool(rptkh);
            tool.ShowPreview();
        }
    }
}