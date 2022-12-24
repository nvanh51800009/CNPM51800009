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
    public partial class DXmh : DevExpress.XtraEditors.XtraForm
    {
        QLSVEntities data = new QLSVEntities();
        bool action = false;
        public DXmh()
        {
            InitializeComponent();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                var k = new MONHOC
                {
                    TENMH = txttenmh.Text.Trim(),
                    MAMH = txtmamh.Text.Trim(),
                    SOTIETLT = int.Parse(txtlt.Text.Trim()),
                    SOTIETTH = int.Parse(txtth.Text.Trim())
                };
                data.MONHOCs.Add(k);
                data.SaveChanges();
                getdata();
            }
            else
            {
                data = new QLSVEntities();
                var s = (from t in data.MONHOCs
                         where t.TENMH == txttenmh.Text
                         select t
                         ).SingleOrDefault();

                s.SOTIETLT = int.Parse(txtlt.Text.Trim());
                s.SOTIETTH = int.Parse(txtth.Text.Trim());
                data.SaveChanges();
                getdata();
            }
        }

        private void DXmh_Load(object sender, EventArgs e)
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
            mONHOCBindingSource.DataSource = data.MONHOCs.ToList();
        }

        private void menuDel_Click(object sender, EventArgs e)
        {
            data = new QLSVEntities();
            if (MessageBox.Show("Are you sure?", "Messsage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var kh = data.MONHOCs.FirstOrDefault(x => x.MAMH.Contains(txtmamh.Text));
                if (kh != null)
                {
                    MessageBox.Show("Không xóa được vì môn học đã có trong khóa học!");
                }
                else
                {
                    var s = (from t in data.MONHOCs
                             where t.TENMH == txttenmh.Text
                             select t
                         ).SingleOrDefault();

                    data.MONHOCs.Remove(s);
                    data.SaveChanges();
                    getdata();
                }
            }
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            action = false;
            txttenmh.ReadOnly = false;
            menuDel.Enabled = false;
            txttenmh.Clear();
            txtmamh.Clear();
            txtlt.Clear();
            txtth.Clear();
        }
        private void dgmhview_CustomDrawRowIndicator_1(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void dgmhview_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txttenmh.ReadOnly = true;
            menuDel.Enabled = true;
            action = true;
            txttenmh.Text = dgmhview.GetFocusedRowCellValue("TENMH").ToString();
            txtmamh.Text = dgmhview.GetFocusedRowCellValue("MAMH").ToString();
            txtlt.Text = dgmhview.GetFocusedRowCellValue("SOTIETLT").ToString();
            txtth.Text = dgmhview.GetFocusedRowCellValue("SOTIETTH").ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            XtraReportmh rptmh = new XtraReportmh();
            rptmh.DataSource = dgmh.DataSource;
            ReportPrintTool tool = new ReportPrintTool(rptmh);
            tool.ShowPreview();
        }
    }
}