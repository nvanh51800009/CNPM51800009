namespace DXApplicationQLSV
{
    partial class DXkh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DXkh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuSave = new System.Windows.Forms.ToolStripButton();
            this.menuDel = new System.Windows.Forms.ToolStripButton();
            this.menuCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtngaykt = new System.Windows.Forms.DateTimePicker();
            this.txtngaybd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmamh = new System.Windows.Forms.TextBox();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgkh = new DevExpress.XtraGrid.GridControl();
            this.kHOAHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgkhview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgkhview)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(693, 25);
            this.toolStrip1.TabIndex = 67;
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 22);
            this.toolStripButton1.Text = "In";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtngaykt
            // 
            this.txtngaykt.Location = new System.Drawing.Point(95, 164);
            this.txtngaykt.Name = "txtngaykt";
            this.txtngaykt.Size = new System.Drawing.Size(131, 21);
            this.txtngaykt.TabIndex = 71;
            // 
            // txtngaybd
            // 
            this.txtngaybd.Location = new System.Drawing.Point(94, 134);
            this.txtngaybd.Name = "txtngaybd";
            this.txtngaybd.Size = new System.Drawing.Size(131, 21);
            this.txtngaybd.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Ngày kết thúc";
            // 
            // txtmamh
            // 
            this.txtmamh.Location = new System.Drawing.Point(89, 99);
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.Size = new System.Drawing.Size(137, 21);
            this.txtmamh.TabIndex = 66;
            // 
            // txtmagv
            // 
            this.txtmagv.Location = new System.Drawing.Point(89, 70);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(137, 21);
            this.txtmagv.TabIndex = 65;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(89, 43);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(137, 21);
            this.txtmakh.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Mã MH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Mã GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Mã KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // dgkh
            // 
            this.dgkh.DataSource = this.kHOAHOCBindingSource;
            this.dgkh.Location = new System.Drawing.Point(273, 43);
            this.dgkh.MainView = this.dgkhview;
            this.dgkh.Name = "dgkh";
            this.dgkh.Size = new System.Drawing.Size(400, 200);
            this.dgkh.TabIndex = 72;
            this.dgkh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgkhview});
            // 
            // kHOAHOCBindingSource
            // 
            this.kHOAHOCBindingSource.DataSource = typeof(DXApplicationQLSV.KHOAHOC);
            // 
            // dgkhview
            // 
            this.dgkhview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colMAGV,
            this.colMAMH,
            this.colNGAYBD,
            this.colNGAYKY});
            this.dgkhview.GridControl = this.dgkh;
            this.dgkhview.Name = "dgkhview";
            this.dgkhview.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.dgkhview_CustomDrawRowIndicator);
            this.dgkhview.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgkhview_FocusedRowChanged);
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã khóa học";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã giáo viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 1;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 2;
            // 
            // colNGAYBD
            // 
            this.colNGAYBD.Caption = "Ngày bắt đầu";
            this.colNGAYBD.FieldName = "NGAYBD";
            this.colNGAYBD.Name = "colNGAYBD";
            this.colNGAYBD.Visible = true;
            this.colNGAYBD.VisibleIndex = 3;
            // 
            // colNGAYKY
            // 
            this.colNGAYKY.Caption = "Ngày kết thúc";
            this.colNGAYKY.FieldName = "NGAYKY";
            this.colNGAYKY.Name = "colNGAYKY";
            this.colNGAYKY.Visible = true;
            this.colNGAYKY.VisibleIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(280, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "QUẢN LÍ DANH MỤC KHÓA HỌC";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 237);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(221, 25);
            this.labelControl2.TabIndex = 74;
            this.labelControl2.Text = "51800009_NguyenVanAnh";
            // 
            // DXkh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 356);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgkh);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtngaykt);
            this.Controls.Add(this.txtngaybd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmamh);
            this.Controls.Add(this.txtmagv);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "DXkh";
            this.Text = "DXkh";
            this.Load += new System.EventHandler(this.DXkh_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgkhview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menuSave;
        private System.Windows.Forms.ToolStripButton menuDel;
        private System.Windows.Forms.ToolStripButton menuCancel;
        private System.Windows.Forms.DateTimePicker txtngaykt;
        private System.Windows.Forms.DateTimePicker txtngaybd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmamh;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl dgkh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgkhview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kHOAHOCBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYKY;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}