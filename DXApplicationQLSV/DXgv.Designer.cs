namespace DXApplicationQLSV
{
    partial class DXgv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DXgv));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuSave = new System.Windows.Forms.ToolStripButton();
            this.menuDel = new System.Windows.Forms.ToolStripButton();
            this.meuCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthv = new System.Windows.Forms.TextBox();
            this.txttengv = new System.Windows.Forms.TextBox();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dggv = new DevExpress.XtraGrid.GridControl();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dggvview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dggv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dggvview)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.menuDel,
            this.meuCancel,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(746, 25);
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
            // meuCancel
            // 
            this.meuCancel.Image = ((System.Drawing.Image)(resources.GetObject("meuCancel.Image")));
            this.meuCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.meuCancel.Name = "meuCancel";
            this.meuCancel.Size = new System.Drawing.Size(63, 22);
            this.meuCancel.Text = "Cancel";
            this.meuCancel.Click += new System.EventHandler(this.meuCancel_Click);
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
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(86, 170);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(137, 21);
            this.txtmk.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Mã khoa";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(86, 144);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(137, 21);
            this.txtsdt.TabIndex = 66;
            // 
            // txthv
            // 
            this.txthv.Location = new System.Drawing.Point(86, 121);
            this.txthv.Name = "txthv";
            this.txthv.Size = new System.Drawing.Size(137, 21);
            this.txthv.TabIndex = 65;
            // 
            // txttengv
            // 
            this.txttengv.Location = new System.Drawing.Point(86, 92);
            this.txttengv.Name = "txttengv";
            this.txttengv.Size = new System.Drawing.Size(137, 21);
            this.txttengv.TabIndex = 64;
            // 
            // txtmagv
            // 
            this.txtmagv.Location = new System.Drawing.Point(86, 65);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(137, 21);
            this.txtmagv.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Học vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Tên GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mã GV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "SĐT";
            // 
            // dggv
            // 
            this.dggv.DataSource = this.gIAOVIENBindingSource;
            this.dggv.Dock = System.Windows.Forms.DockStyle.Right;
            gridLevelNode1.RelationName = "Level1";
            this.dggv.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dggv.Location = new System.Drawing.Point(323, 25);
            this.dggv.MainView = this.dggvview;
            this.dggv.Name = "dggv";
            this.dggv.Size = new System.Drawing.Size(423, 316);
            this.dggv.TabIndex = 71;
            this.dggv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dggvview});
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataSource = typeof(DXApplicationQLSV.GIAOVIEN);
            // 
            // dggvview
            // 
            this.dggvview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colTENGV,
            this.colHOCVI,
            this.colSDT,
            this.colMAKHOA});
            this.dggvview.GridControl = this.dggv;
            this.dggvview.Name = "dggvview";
            this.dggvview.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.dggvview_CustomDrawRowIndicator);
            this.dggvview.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dggvview_FocusedRowChanged);
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã giáo viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 144;
            // 
            // colTENGV
            // 
            this.colTENGV.Caption = "Tên giáo viên";
            this.colTENGV.FieldName = "TENGV";
            this.colTENGV.Name = "colTENGV";
            this.colTENGV.Visible = true;
            this.colTENGV.VisibleIndex = 1;
            this.colTENGV.Width = 139;
            // 
            // colHOCVI
            // 
            this.colHOCVI.Caption = "Học vị";
            this.colHOCVI.FieldName = "HOCVI";
            this.colHOCVI.Name = "colHOCVI";
            this.colHOCVI.Visible = true;
            this.colHOCVI.VisibleIndex = 2;
            this.colHOCVI.Width = 145;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số điện thoại";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            this.colSDT.Width = 145;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.Caption = "Mã khoa";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 4;
            this.colMAKHOA.Width = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "QUẢN LÍ DANH MỤC GIÁO VIÊN";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(2, 291);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(221, 25);
            this.labelControl2.TabIndex = 73;
            this.labelControl2.Text = "51800009_NguyenVanAnh";
            // 
            // DXgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(746, 341);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dggv);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txthv);
            this.Controls.Add(this.txttengv);
            this.Controls.Add(this.txtmagv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "DXgv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DXgv";
            this.Load += new System.EventHandler(this.DXgv_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dggv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dggvview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menuSave;
        private System.Windows.Forms.ToolStripButton menuDel;
        private System.Windows.Forms.ToolStripButton meuCancel;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthv;
        private System.Windows.Forms.TextBox txttengv;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl dggv;
        private DevExpress.XtraGrid.Views.Grid.GridView dggvview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colTENGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}