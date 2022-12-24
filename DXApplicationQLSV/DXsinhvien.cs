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
    public partial class DXsinhvien : DevExpress.XtraEditors.XtraForm
    {
        QLSVEntities data = new QLSVEntities();
        bool action = false;
        public DXsinhvien()
        {
            InitializeComponent();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                var k = new SINHVIEN
                {
                    TENSV = txtnamesv.Text.Trim(),
                    MASV = txtmssv.Text.Trim(),
                    NGAYSINH = txtngaysinh.Value,
                    PHAI = txtphai.Text.Trim(),
                    MAKHOA = txtmakh.Text.Trim(),
                    DIACHI = txtdc.Text.Trim(),
                    DIENTHOAI = int.Parse(txtdt.Text.Trim()),
                };
                data.SINHVIENs.Add(k);
                data.SaveChanges();
                getdata();
            }
            else
            {
                data = new QLSVEntities();
                var s = (from t in data.SINHVIENs
                         where t.TENSV == txtnamesv.Text
                         select t
                         ).SingleOrDefault();

                s.TENSV = txtnamesv.Text.Trim();
                s.NGAYSINH = txtngaysinh.Value;
                s.PHAI = txtphai.Text.Trim();
                s.MAKHOA = txtmakh.Text.Trim();
                s.DIACHI = txtdc.Text.Trim();
                s.DIENTHOAI = int.Parse(txtdt.Text.Trim());
                data.SaveChanges();
                getdata();
            }
        }

        private void DXsinhvien_Load(object sender, EventArgs e)
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
            sINHVIENBindingSource.DataSource = data.SINHVIENs.ToList();           
        }

        private void menuDel_Click(object sender, EventArgs e)
        {
            data = new QLSVEntities();
            if (MessageBox.Show("Are you sure?", "Messsage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var kh = data.KETQUAs.FirstOrDefault(x => x.MASV.Contains(txtmssv.Text));
                if (kh != null)
                {
                    MessageBox.Show("Không xóa được vì Khoa có SV đang học!");
                }
                else
                {
                    var s = (from t in data.SINHVIENs
                             where t.TENSV == txtnamesv.Text
                             select t
                             ).SingleOrDefault();

                    data.SINHVIENs.Remove(s);
                    data.SaveChanges();
                    getdata();
                }
            }
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            action = false;
            txtnamesv.ReadOnly = false;
            menuDel.Enabled = false;
            txtnamesv.Clear();
            txtmssv.Clear();
            txtphai.Clear();
            txtdc.Clear();
            txtdt.Clear();
        }

        private void dgsvview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtnamesv.ReadOnly = true;
            menuDel.Enabled = true;
            action = true;
            txtnamesv.Text = dgsvview.GetFocusedRowCellValue("TENSV").ToString();
            txtmssv.Text = dgsvview.GetFocusedRowCellValue("MASV").ToString();
            txtngaysinh.Text = dgsvview.GetFocusedRowCellValue("NGAYSINH").ToString();
            txtphai.Text = dgsvview.GetFocusedRowCellValue("PHAI").ToString();
            txtmakh.Text = dgsvview.GetFocusedRowCellValue("MAKHOA").ToString();
            txtdc.Text = dgsvview.GetFocusedRowCellValue("DIACHI").ToString();
            txtdt.Text = dgsvview.GetFocusedRowCellValue("DIENTHOAI").ToString();
        }

        private void dgsvview_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            XtraReportsv rptsv = new XtraReportsv();
            rptsv.DataSource = dgsv.DataSource;
            ReportPrintTool tool = new ReportPrintTool(rptsv);
            tool.ShowPreview();
        }
    }
}