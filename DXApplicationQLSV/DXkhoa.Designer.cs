namespace DXApplicationQLSV
{
    partial class DXkhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DXkhoa));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuSave = new System.Windows.Forms.ToolStripButton();
            this.menuDel = new System.Windows.Forms.ToolStripButton();
            this.menuCancel = new System.Windows.Forms.ToolStripButton();
            this.inkhoa = new System.Windows.Forms.ToolStripButton();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgkhoaview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.makhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenkhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgkhoa = new DevExpress.XtraGrid.GridControl();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkhoaview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgkhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.menuDel,
            this.menuCancel,
            this.inkhoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 46;
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
            // menuDel
            // 
            this.menuDel.Image = ((System.Drawing.Image)(resources.GetObject("menuDel.Image")));
            this.menuDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuDel.Name = "menuDel";
            this.menuDel.Size = new System.Drawing.Size(60, 22);
            this.menuDel.Text = "Delete";
            this.menuDel.Click += new System.EventHandler(this.menuDel_Click);
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
            // inkhoa
            // 
            this.inkhoa.Image = ((System.Drawing.Image)(resources.GetObject("inkhoa.Image")));
            this.inkhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inkhoa.Name = "inkhoa";
            this.inkhoa.Size = new System.Drawing.Size(37, 22);
            this.inkhoa.Text = "In";
            this.inkhoa.Click += new System.EventHandler(this.inkhoa_Click);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(77, 171);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(137, 21);
            this.txtsdt.TabIndex = 44;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(77, 144);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(137, 21);
            this.txtdiachi.TabIndex = 43;
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Location = new System.Drawing.Point(77, 118);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(137, 21);
            this.txttenkhoa.TabIndex = 42;
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(77, 91);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(137, 21);
            this.txtmakhoa.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tên khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-30, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "SĐT";
            // 
            // dgkhoaview
            // 
            this.dgkhoaview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.makhoa,
            this.tenkhoa,
            this.diachi,
            this.dienthoai});
            this.dgkhoaview.GridControl = this.dgkhoa;
            this.dgkhoaview.IndicatorWidth = 40;
            this.dgkhoaview.Name = "dgkhoaview";
            this.dgkhoaview.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.dgkhoaview_CustomDrawRowIndicator);
            this.dgkhoaview.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgkhoaview_FocusedRowChanged);
            this.dgkhoaview.Click += new System.EventHandler(this.dgkhoa_CellClick);
            // 
            // makhoa
            // 
            this.makhoa.Caption = "Mã khoa";
            this.makhoa.FieldName = "MAKHOA";
            this.makhoa.Name = "makhoa";
            this.makhoa.Visible = true;
            this.makhoa.VisibleIndex = 0;
            // 
            // tenkhoa
            // 
            this.tenkhoa.Caption = "Tên khoa";
            this.tenkhoa.FieldName = "TENKHOA";
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.Visible = true;
            this.tenkhoa.VisibleIndex = 1;
            // 
            // diachi
            // 
            this.diachi.Caption = "Địa chỉ";
            this.diachi.FieldName = "DIACHI";
            this.diachi.Name = "diachi";
            this.diachi.Visible = true;
            this.diachi.VisibleIndex = 2;
            // 
            // dienthoai
            // 
            this.dienthoai.Caption = "Điện thoại";
            this.dienthoai.FieldName = "DIENTHOAI";
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.Visible = true;
            this.dienthoai.VisibleIndex = 3;
            // 
            // dgkhoa
            // 
            this.dgkhoa.DataSource = this.kHOABindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.dgkhoa.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgkhoa.Location = new System.Drawing.Point(229, 91);
            this.dgkhoa.MainView = this.dgkhoaview;
            this.dgkhoa.Name = "dgkhoa";
            this.dgkhoa.Size = new System.Drawing.Size(408, 238);
            this.dgkhoa.TabIndex = 48;
            this.dgkhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgkhoaview});
            this.dgkhoa.Click += new System.EventHandler(this.dgkhoa_CellClick);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataSource = typeof(DXApplicationQLSV.KHOA);
            // 
            // kHOABindingSource1
            // 
            this.kHOABindingSource1.DataSource = typeof(DXApplicationQLSV.KHOA);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(2, 251);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(221, 25);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "51800009_NguyenVanAnh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(239, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 25);
            this.label7.TabIndex = 69;
            this.label7.Text = "QUẢN LÍ DANH MỤC KHOA";
            // 
            // DXkhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 325);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgkhoa);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenkhoa);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "DXkhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DXkhoa";
            this.Load += new System.EventHandler(this.DXkhoa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkhoaview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgkhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menuSave;
        private System.Windows.Forms.ToolStripButton menuDel;
        private System.Windows.Forms.ToolStripButton menuCancel;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenkhoa;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Views.Grid.GridView dgkhoaview;
        private DevExpress.XtraGrid.GridControl dgkhoa;
        private DevExpress.XtraGrid.Columns.GridColumn makhoa;
        private DevExpress.XtraGrid.Columns.GridColumn tenkhoa;
        private DevExpress.XtraGrid.Columns.GridColumn diachi;
        private DevExpress.XtraGrid.Columns.GridColumn dienthoai;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private System.Windows.Forms.BindingSource kHOABindingSource1;
        private System.Windows.Forms.ToolStripButton inkhoa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label7;
    }
}