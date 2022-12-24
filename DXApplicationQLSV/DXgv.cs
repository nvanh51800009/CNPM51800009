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
    public partial class DXgv : DevExpress.XtraEditors.XtraForm
    {
        QLSVEntities data = new QLSVEntities();
        bool action = false;
        public DXgv()
        {
            InitializeComponent();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                var k = new GIAOVIEN
                {
                    MAGV = txtmagv.Text.Trim(),
                    TENGV = txttengv.Text.Trim(),
                    HOCVI = txthv.Text.Trim(),
                    SDT = int.Parse(txtsdt.Text.Trim()),
                    MAKHOA = txtmk.Text.Trim()
                };
                data.GIAOVIENs.Add(k);
                data.SaveChanges();
                getdata();
            }
            else
            {
                var s = (from t in data.GIAOVIENs
                         where t.MAGV == txtmagv.Text
                         select t
                         ).SingleOrDefault();

                s.TENGV = txttengv.Text.Trim();
                s.HOCVI = txthv.Text.Trim();
                s.SDT = int.Parse(txtsdt.Text.Trim());
                s.MAKHOA = txtmk.Text.Trim();
                data.SaveChanges();
                getdata();
            }
        }

        private void DXgv_Load(object sender, EventArgs e)
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
            gIAOVIENBindingSource.DataSource = data.GIAOVIENs.ToList();
        }

        private void menuDel_Click(object sender, EventArgs e)
        {
            data = new QLSVEntities();
            if (MessageBox.Show("Are you sure?", "Messsage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var kh = data.KHOAs.FirstOrDefault(x => x.MAKHOA.Contains(txtmk.Text));
                if (kh != null)
                {
                    MessageBox.Show("Không xóa được vì Giáo viên còn hợp đồng!");
                }
                else
                {
                    var s = (from t in data.GIAOVIENs
                             where t.MAGV == txtmagv.Text
                             select t
                         ).SingleOrDefault();

                    data.GIAOVIENs.Remove(s);
                    data.SaveChanges();
                    getdata();
                }
            }
        }

        private void meuCancel_Click(object sender, EventArgs e)
        {
            action = false;
            txtmagv.ReadOnly = false;
            menuDel.Enabled = false;
            txtmagv.Clear();
            txttengv.Clear();
            txthv.Clear();
            txtsdt.Clear();
            txtmk.Clear();
        }

        private void dggvview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtmagv.ReadOnly = true;
            menuDel.Enabled = true;
            action = true;
            txtmagv.Text = dggvview.GetFocusedRowCellValue("MAGV").ToString();
            txttengv.Text = dggvview.GetFocusedRowCellValue("TENGV").ToString();
            txthv.Text = dggvview.GetFocusedRowCellValue("HOCVI").ToString();
            txtsdt.Text = dggvview.GetFocusedRowCellValue("SDT").ToString();
            txtmk.Text = dggvview.GetFocusedRowCellValue("MAKHOA").ToString();
        }

        private void dggvview_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            XtraReportgv rptgv = new XtraReportgv();
            rptgv.DataSource = dggv.DataSource;
            ReportPrintTool tool = new ReportPrintTool(rptgv);
            tool.ShowPreview();
        }
    }
}