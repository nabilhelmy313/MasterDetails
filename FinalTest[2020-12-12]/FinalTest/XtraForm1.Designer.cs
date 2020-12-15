
namespace FinalTest
{
    partial class XtraForm1
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.keywordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Category_IdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForWord = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategory_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_IdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.simpleButton2);
            this.dataLayoutControl1.Controls.Add(this.simpleButton1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.WordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Category_IdLookUpEdit);
            this.dataLayoutControl1.DataSource = this.keywordBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(793, 508);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(398, 471);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(383, 25);
            this.simpleButton2.StyleController = this.dataLayoutControl1;
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "new";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(12, 471);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(382, 25);
            this.simpleButton1.StyleController = this.dataLayoutControl1;
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.keywordBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 66);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(769, 401);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // keywordBindingSource
            // 
            this.keywordBindingSource.DataSource = typeof(FinalTest.Keyword);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWord,
            this.colCategory_Id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colWord
            // 
            this.colWord.FieldName = "Word";
            this.colWord.Name = "colWord";
            this.colWord.Visible = true;
            this.colWord.VisibleIndex = 0;
            // 
            // colCategory_Id
            // 
            this.colCategory_Id.FieldName = "Category.Name";
            this.colCategory_Id.Name = "colCategory_Id";
            this.colCategory_Id.Visible = true;
            this.colCategory_Id.VisibleIndex = 1;
            // 
            // WordTextEdit
            // 
            this.WordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.keywordBindingSource, "Word", true));
            this.WordTextEdit.Location = new System.Drawing.Point(94, 12);
            this.WordTextEdit.Name = "WordTextEdit";
            this.WordTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordTextEdit.Properties.Appearance.Options.UseFont = true;
            this.WordTextEdit.Size = new System.Drawing.Size(687, 26);
            this.WordTextEdit.StyleController = this.dataLayoutControl1;
            this.WordTextEdit.TabIndex = 5;
            // 
            // Category_IdLookUpEdit
            // 
            this.Category_IdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.keywordBindingSource, "Category_Id", true));
            this.Category_IdLookUpEdit.Location = new System.Drawing.Point(94, 42);
            this.Category_IdLookUpEdit.Name = "Category_IdLookUpEdit";
            this.Category_IdLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Category_IdLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Category_IdLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Category_IdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Category_IdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.Category_IdLookUpEdit.Properties.DataSource = this.categoryBindingSource;
            this.Category_IdLookUpEdit.Properties.DisplayMember = "Name";
            this.Category_IdLookUpEdit.Properties.NullText = "";
            this.Category_IdLookUpEdit.Properties.ValueMember = "Id";
            this.Category_IdLookUpEdit.Size = new System.Drawing.Size(687, 20);
            this.Category_IdLookUpEdit.StyleController = this.dataLayoutControl1;
            this.Category_IdLookUpEdit.TabIndex = 8;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(FinalTest.Category);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(793, 508);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForWord,
            this.ItemForCategory_Id,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(773, 488);
            // 
            // ItemForWord
            // 
            this.ItemForWord.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemForWord.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForWord.Control = this.WordTextEdit;
            this.ItemForWord.Location = new System.Drawing.Point(0, 0);
            this.ItemForWord.Name = "ItemForWord";
            this.ItemForWord.Size = new System.Drawing.Size(773, 30);
            this.ItemForWord.Text = "Word";
            this.ItemForWord.TextSize = new System.Drawing.Size(79, 20);
            // 
            // ItemForCategory_Id
            // 
            this.ItemForCategory_Id.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemForCategory_Id.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForCategory_Id.Control = this.Category_IdLookUpEdit;
            this.ItemForCategory_Id.Location = new System.Drawing.Point(0, 30);
            this.ItemForCategory_Id.Name = "ItemForCategory_Id";
            this.ItemForCategory_Id.Size = new System.Drawing.Size(773, 24);
            this.ItemForCategory_Id.Text = "Category_Id";
            this.ItemForCategory_Id.TextSize = new System.Drawing.Size(79, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(773, 405);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 459);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(386, 29);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.Location = new System.Drawing.Point(386, 459);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(387, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 508);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_IdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource keywordBindingSource;
        private DevExpress.XtraEditors.TextEdit WordTextEdit;
        private DevExpress.XtraEditors.LookUpEdit Category_IdLookUpEdit;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWord;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategory_Id;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colWord;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory_Id;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}