namespace DXApplicationQLSV
{
    partial class DXsinhvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DXsinhvien));
            this.label1 = new System.Windows.Forms.Label();
            this.dgsv = new DevExpress.XtraGrid.GridControl();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgsvview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuDel = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.txtphai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuCancel = new System.Windows.Forms.ToolStripButton();
            this.txtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtnamesv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgsvview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(232, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 94;
            this.label1.Text = "QUẢN LÍ DANH MỤC SINH VIÊN";
            // 
            // dgsv
            // 
            this.dgsv.DataSource = this.sINHVIENBindingSource;
            this.dgsv.Location = new System.Drawing.Point(232, 47);
            this.dgsv.MainView = this.dgsvview;
            this.dgsv.Name = "dgsv";
            this.dgsv.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.dgsv.Size = new System.Drawing.Size(504, 200);
            this.dgsv.TabIndex = 93;
            this.dgsv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgsvview});
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataSource = typeof(DXApplicationQLSV.SINHVIEN);
            // 
            // dgsvview
            // 
            this.dgsvview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENSV,
            this.colMASV,
            this.colNGAYSINH,
            this.colPHAI,
            this.colMAKHOA,
            this.colDIACHI,
            this.colDIENTHOAI});
            this.dgsvview.GridControl = this.dgsv;
            this.dgsvview.Name = "dgsvview";
            this.dgsvview.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.dgsvview_CustomDrawRowIndicator);
            this.dgsvview.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgsvview_FocusedRowChanged);
            // 
            // colTENSV
            // 
            this.colTENSV.Caption = "Tên Sinh Viên";
            this.colTENSV.FieldName = "TENSV";
            this.colTENSV.Name = "colTENSV";
            this.colTENSV.Visible = true;
            this.colTENSV.VisibleIndex = 0;
            this.colTENSV.Width = 104;
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã Số SV";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 1;
            this.colMASV.Width = 59;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 2;
            this.colNGAYSINH.Width = 59;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 59;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.Caption = "Mã Khoa";
            this.colMAKHOA.ColumnEdit = this.repositoryItemComboBox1;
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 4;
            this.colMAKHOA.Width = 59;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 5;
            this.colDIACHI.Width = 59;
            // 
            // colDIENTHOAI
            // 
            this.colDIENTHOAI.Caption = "Điện Thoại";
            this.colDIENTHOAI.FieldName = "DIENTHOAI";
            this.colDIENTHOAI.Name = "colDIENTHOAI";
            this.colDIENTHOAI.Visible = true;
            this.colDIENTHOAI.VisibleIndex = 6;
            this.colDIENTHOAI.Width = 69;
            // 
            // menuDel
            // 
            this.menuDel.Image = ((System.Drawing.Image)(resources.GetObject("menuDel.Image")));
            this.menuDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuDel.Name = "menuDel";
            this.menuDel.Size = new System.Drawing.Size(60, 22);
            this.menuDel.Text = "Delete";
            this.menuDel.Click += new System.EventHandler(this.menuDel_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(754, 25);
            this.toolStrip2.TabIndex = 92;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // txtphai
            // 
            this.txtphai.Location = new System.Drawing.Point(88, 125);
            this.txtphai.Name = "txtphai";
            this.txtphai.Size = new System.Drawing.Size(137, 21);
            this.txtphai.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Điện thoại";
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(88, 204);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(137, 21);
            this.txtdt.TabIndex = 89;
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(88, 178);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(137, 21);
            this.txtdc.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Mã khoa";
            // 
            // menuCancel
            // 
            this.menuCancel.Image = ((System.Drawing.Image)(resources.GetObject("menuCancel.Image")));
            this.menuCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCancel.Name = "menuCancel";
            this.menuCancel.Size = new System.Drawing.Size(63, 22);
            this.menuCancel.Text = "Cancel";
            this.menuCancel.Click += new System.EventHandler(this.menuCancel_Click);
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(89, 99);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(136, 21);
            this.txtngaysinh.TabIndex = 84;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.menuDel,
            this.menuCancel,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(754, 25);
            this.toolStrip1.TabIndex = 82;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuSave
            // 
            this.menuSave.Image = ((System.Drawing.Image)(resources.GetObject("menuSave.Image")));
            this.menuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(51, 22);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 22);
            this.toolStripButton1.Text = "In";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtnamesv
            // 
            this.txtnamesv.Location = new System.Drawing.Point(89, 47);
            this.txtnamesv.Name = "txtnamesv";
            this.txtnamesv.Size = new System.Drawing.Size(137, 21);
            this.txtnamesv.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tên sinh viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Phái";
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(89, 73);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(137, 21);
            this.txtmssv.TabIndex = 81;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(88, 151);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(137, 21);
            this.txtmakh.TabIndex = 95;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(0, 231);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(221, 25);
            this.labelControl2.TabIndex = 96;
            this.labelControl2.Text = "51800009_NguyenVanAnh";
            // 
            // DXsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 359);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgsv);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.txtphai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtnamesv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmssv);
            this.Name = "DXsinhvien";
            this.Text = "DXsinhvien";
            this.Load += new System.EventHandler(this.DXsinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgsvview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dgsv;
        private DevExpress.XtraGrid.Views.Grid.GridView dgsvview;
        private System.Windows.Forms.ToolStripButton menuDel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.TextBox txtphai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton menuCancel;
        private System.Windows.Forms.DateTimePicker txtngaysinh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menuSave;
        private System.Windows.Forms.TextBox txtnamesv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTENSV;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIENTHOAI;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.TextBox txtmakh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}