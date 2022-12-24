namespace DXApplicationQLSV
{
    partial class DXmh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DXmh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuSave = new System.Windows.Forms.ToolStripButton();
            this.menuDel = new System.Windows.Forms.ToolStripButton();
            this.menuCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtth = new System.Windows.Forms.TextBox();
            this.txtlt = new System.Windows.Forms.TextBox();
            this.txtmamh = new System.Windows.Forms.TextBox();
            this.txttenmh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgmh = new DevExpress.XtraGrid.GridControl();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgmhview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIETLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIETTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmhview)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 54;
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
            // txtth
            // 
            this.txtth.Location = new System.Drawing.Point(88, 156);
            this.txtth.Name = "txtth";
            this.txtth.Size = new System.Drawing.Size(137, 21);
            this.txtth.TabIndex = 53;
            // 
            // txtlt
            // 
            this.txtlt.Location = new System.Drawing.Point(88, 133);
            this.txtlt.Name = "txtlt";
            this.txtlt.Size = new System.Drawing.Size(137, 21);
            this.txtlt.TabIndex = 52;
            // 
            // txtmamh
            // 
            this.txtmamh.Location = new System.Drawing.Point(88, 104);
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.Size = new System.Drawing.Size(137, 21);
            this.txtmamh.TabIndex = 51;
            // 
            // txttenmh
            // 
            this.txttenmh.Location = new System.Drawing.Point(88, 77);
            this.txttenmh.Name = "txttenmh";
            this.txttenmh.Size = new System.Drawing.Size(137, 21);
            this.txttenmh.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Số tiết LT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tên môn học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Số tiết TH";
            // 
            // dgmh
            // 
            this.dgmh.DataSource = this.mONHOCBindingSource;
            this.dgmh.Location = new System.Drawing.Point(266, 62);
            this.dgmh.MainView = this.dgmhview;
            this.dgmh.Name = "dgmh";
            this.dgmh.Size = new System.Drawing.Size(400, 200);
            this.dgmh.TabIndex = 58;
            this.dgmh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgmhview});
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataSource = typeof(DXApplicationQLSV.MONHOC);
            // 
            // dgmhview
            // 
            this.dgmhview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENMH,
            this.colMAMH,
            this.colSOTIETLT,
            this.colSOTIETTH});
            this.dgmhview.GridControl = this.dgmh;
            this.dgmhview.Name = "dgmhview";
            this.dgmhview.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.dgmhview_CustomDrawRowIndicator_1);
            this.dgmhview.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgmhview_FocusedRowChanged_1);
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colSOTIETLT
            // 
            this.colSOTIETLT.Caption = "Số tiết LT";
            this.colSOTIETLT.FieldName = "SOTIETLT";
            this.colSOTIETLT.Name = "colSOTIETLT";
            this.colSOTIETLT.Visible = true;
            this.colSOTIETLT.VisibleIndex = 2;
            // 
            // colSOTIETTH
            // 
            this.colSOTIETTH.Caption = "Số tiết TH";
            this.colSOTIETTH.FieldName = "SOTIETTH";
            this.colSOTIETTH.Name = "colSOTIETTH";
            this.colSOTIETTH.Visible = true;
            this.colSOTIETTH.VisibleIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(4, 237);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(221, 25);
            this.labelControl2.TabIndex = 59;
            this.labelControl2.Text = "51800009_NguyenVanAnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(274, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "QUẢN LÍ DANH MỤC MÔN HỌC";
            // 
            // DXmh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dgmh);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtth);
            this.Controls.Add(this.txtlt);
            this.Controls.Add(this.txtmamh);
            this.Controls.Add(this.txttenmh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "DXmh";
            this.Text = "DXmh";
            this.Load += new System.EventHandler(this.DXmh_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmhview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menuSave;
        private System.Windows.Forms.ToolStripButton menuDel;
        private System.Windows.Forms.ToolStripButton menuCancel;
        private System.Windows.Forms.TextBox txtth;
        private System.Windows.Forms.TextBox txtlt;
        private System.Windows.Forms.TextBox txtmamh;
        private System.Windows.Forms.TextBox txttenmh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl dgmh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgmhview;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIETLT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIETTH;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label1;
    }
}