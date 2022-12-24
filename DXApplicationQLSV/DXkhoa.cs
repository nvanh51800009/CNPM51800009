using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class DXkhoa : DevExpress.XtraEditors.XtraForm
    {
        QLSVEntities data = new QLSVEntities();
        bool action = false;
        public DXkhoa()
        {
            InitializeComponent();
        }

        private void dgkhoa_CellClick(object sender, EventArgs e)
        {
            //txtmakhoa.ReadOnly = true;
            //menuDel.Enabled = true;
            //action = true;
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                var k = new KHOA
                {
                    MAKHOA = txtmakhoa.Text.Trim(),
                    TENKHOA = txttenkhoa.Text.Trim(),
                    DIACHI = txtdiachi.Text.Trim(),
                    DIENTHOAI = int.Parse(txtsdt.Text.Trim())
                };
                data.KHOAs.Add(k);
                data.SaveChanges();
                getdata();
            }
            else
            {
                data = new QLSVEntities();
                var s = (from t in data.KHOAs
                         where t.MAKHOA == txtmakhoa.Text
                         select t
                         ).SingleOrDefault();
                var sv = data.KHOAs.FirstOrDefault(x => x.MAKHOA.Contains(txtmakhoa.Text));
                sv.TENKHOA = txttenkhoa.Text.Trim();
                sv.DIACHI = txtdiachi.Text.Trim();
                sv.DIENTHOAI = int.Parse(txtsdt.Text.Trim());
                data.SaveChanges();
                getdata();
            }
        }

        private void DXkhoa_Load(object sender, EventArgs e)
        {
            getdata();
            init();
            //txtmakhoa.ReadOnly = true;
            //menuDel.Enabled = true;
            //action = true;
        }
        void init()
        {
            menuDel.Enabled = false;
        }
        void getdata()
        {
            //List<KHOA> lst = data.KHOAs.ToList();
            //int i = 0;
            //var v = from t in lst
            //        select new
            //        {
            //            STT = ++i,
            //            Makhoa = t.MAKHOA,
            //            Tenkhoa = t.TENKHOA,
            //            Diachi = t.DIACHI,
            //            Sodienthoai = t.DIENTHOAI
            //        };
            //dgkhoa.DataSource = v.ToList();
            kHOABindingSource.DataSource = data.KHOAs.ToList();
            //var dta = data.KHOAs.ToList();
            //dgkhoa.DataSource = dta;
        }

        private void menuDel_Click(object sender, EventArgs e)
        {
            data = new QLSVEntities();
            if (MessageBox.Show("Are you sure?", "Messsage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var kh = data.SINHVIENs.FirstOrDefault(x => x.MAKHOA.Contains(txtmakhoa.Text));
                if (kh != null)
                {
                    MessageBox.Show("Không xóa được vì Khoa có SV đang học!");
                }
                else
                {
                    var s = (from t in data.KHOAs
                             where t.MAKHOA == txtmakhoa.Text
                             select t
                             ).SingleOrDefault();

                    data.KHOAs.Remove(s);
                    data.SaveChanges();
                    getdata();
                }
            }
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            action = false;
            txtmakhoa.ReadOnly = false;
            menuDel.Enabled = false;
            txtmakhoa.Clear();
            txttenkhoa.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
        }

        private void dgkhoaview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtmakhoa.ReadOnly = true;
            menuDel.Enabled = true;
            action = true;
            txtmakhoa.Text = dgkhoaview.GetFocusedRowCellValue("MAKHOA").ToString();
            txttenkhoa.Text = dgkhoaview.GetFocusedRowCellValue("TENKHOA").ToString();
            txtdiachi.Text = dgkhoaview.GetFocusedRowCellValue("DIACHI").ToString();
            txtsdt.Text = dgkhoaview.GetFocusedRowCellValue("DIENTHOAI").ToString();
        }

        private void inkhoa_Click(object sender, EventArgs e)
        {            
            XtraReportkhoa rptkhoa = new XtraReportkhoa();
            rptkhoa.DataSource = dgkhoa.DataSource;
            ReportPrintTool tool = new ReportPrintTool(rptkhoa);
            tool.ShowPreview();
        }

        private void dgkhoaview_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}