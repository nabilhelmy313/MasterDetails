
namespace FinalTest
{
    partial class EmployeeFrm
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.Phone1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForPhone1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Phone2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForPhone2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.PhotoImageEdit = new DevExpress.XtraEditors.ImageEdit();
            this.ItemForPhoto = new DevExpress.XtraLayout.LayoutControlItem();
            this.RoleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForRole = new DevExpress.XtraLayout.LayoutControlItem();
            this.Branch_IdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ItemForBranch_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.Department_IdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ItemForDepartment_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoImageEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Branch_IdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranch_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Department_IdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDepartment_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Phone1TextEdit);
            this.dataLayoutControl1.Controls.Add(this.Phone2TextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhotoImageEdit);
            this.dataLayoutControl1.Controls.Add(this.RoleTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Branch_IdLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.Department_IdLookUpEdit);
            this.dataLayoutControl1.DataSource = this.employeeBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 20);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(686, 448);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(686, 448);
            this.Root.TextVisible = false;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(FinalTest.Employee);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForPhone1,
            this.ItemForPhone2,
            this.ItemForPhoto,
            this.ItemForRole,
            this.ItemForBranch_Id,
            this.ItemForDepartment_Id,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(666, 428);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(91, 12);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(583, 22);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 4;
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(666, 26);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(67, 16);
            // 
            // Phone1TextEdit
            // 
            this.Phone1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Phone1", true));
            this.Phone1TextEdit.Location = new System.Drawing.Point(91, 38);
            this.Phone1TextEdit.Name = "Phone1TextEdit";
            this.Phone1TextEdit.Size = new System.Drawing.Size(583, 22);
            this.Phone1TextEdit.StyleController = this.dataLayoutControl1;
            this.Phone1TextEdit.TabIndex = 5;
            // 
            // ItemForPhone1
            // 
            this.ItemForPhone1.Control = this.Phone1TextEdit;
            this.ItemForPhone1.Location = new System.Drawing.Point(0, 26);
            this.ItemForPhone1.Name = "ItemForPhone1";
            this.ItemForPhone1.Size = new System.Drawing.Size(666, 26);
            this.ItemForPhone1.Text = "Phone1";
            this.ItemForPhone1.TextSize = new System.Drawing.Size(67, 16);
            // 
            // Phone2TextEdit
            // 
            this.Phone2TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Phone2", true));
            this.Phone2TextEdit.Location = new System.Drawing.Point(91, 64);
            this.Phone2TextEdit.Name = "Phone2TextEdit";
            this.Phone2TextEdit.Size = new System.Drawing.Size(583, 22);
            this.Phone2TextEdit.StyleController = this.dataLayoutControl1;
            this.Phone2TextEdit.TabIndex = 6;
            // 
            // ItemForPhone2
            // 
            this.ItemForPhone2.Control = this.Phone2TextEdit;
            this.ItemForPhone2.Location = new System.Drawing.Point(0, 52);
            this.ItemForPhone2.Name = "ItemForPhone2";
            this.ItemForPhone2.Size = new System.Drawing.Size(666, 26);
            this.ItemForPhone2.Text = "Phone2";
            this.ItemForPhone2.TextSize = new System.Drawing.Size(67, 16);
            // 
            // PhotoImageEdit
            // 
            this.PhotoImageEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Photo", true));
            this.PhotoImageEdit.Location = new System.Drawing.Point(91, 90);
            this.PhotoImageEdit.Name = "PhotoImageEdit";
            this.PhotoImageEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PhotoImageEdit.Size = new System.Drawing.Size(583, 22);
            this.PhotoImageEdit.StyleController = this.dataLayoutControl1;
            this.PhotoImageEdit.TabIndex = 7;
            // 
            // ItemForPhoto
            // 
            this.ItemForPhoto.Control = this.PhotoImageEdit;
            this.ItemForPhoto.Location = new System.Drawing.Point(0, 78);
            this.ItemForPhoto.Name = "ItemForPhoto";
            this.ItemForPhoto.Size = new System.Drawing.Size(666, 26);
            this.ItemForPhoto.Text = "Photo";
            this.ItemForPhoto.TextSize = new System.Drawing.Size(67, 16);
            // 
            // RoleTextEdit
            // 
            this.RoleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Role", true));
            this.RoleTextEdit.Location = new System.Drawing.Point(91, 116);
            this.RoleTextEdit.Name = "RoleTextEdit";
            this.RoleTextEdit.Size = new System.Drawing.Size(583, 22);
            this.RoleTextEdit.StyleController = this.dataLayoutControl1;
            this.RoleTextEdit.TabIndex = 8;
            // 
            // ItemForRole
            // 
            this.ItemForRole.Control = this.RoleTextEdit;
            this.ItemForRole.Location = new System.Drawing.Point(0, 104);
            this.ItemForRole.Name = "ItemForRole";
            this.ItemForRole.Size = new System.Drawing.Size(666, 26);
            this.ItemForRole.Text = "Role";
            this.ItemForRole.TextSize = new System.Drawing.Size(67, 16);
            // 
            // Branch_IdLookUpEdit
            // 
            this.Branch_IdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Branch_Id", true));
            this.Branch_IdLookUpEdit.Location = new System.Drawing.Point(91, 142);
            this.Branch_IdLookUpEdit.Name = "Branch_IdLookUpEdit";
            this.Branch_IdLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Branch_IdLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Branch_IdLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Branch_IdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Branch_IdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.Branch_IdLookUpEdit.Properties.DataSource = this.branchBindingSource;
            this.Branch_IdLookUpEdit.Properties.DisplayMember = "Name";
            this.Branch_IdLookUpEdit.Properties.NullText = "";
            this.Branch_IdLookUpEdit.Properties.ValueMember = "Id";
            this.Branch_IdLookUpEdit.Size = new System.Drawing.Size(583, 22);
            this.Branch_IdLookUpEdit.StyleController = this.dataLayoutControl1;
            this.Branch_IdLookUpEdit.TabIndex = 9;
            // 
            // ItemForBranch_Id
            // 
            this.ItemForBranch_Id.Control = this.Branch_IdLookUpEdit;
            this.ItemForBranch_Id.Location = new System.Drawing.Point(0, 130);
            this.ItemForBranch_Id.Name = "ItemForBranch_Id";
            this.ItemForBranch_Id.Size = new System.Drawing.Size(666, 26);
            this.ItemForBranch_Id.Text = "Branch";
            this.ItemForBranch_Id.TextSize = new System.Drawing.Size(67, 16);
            // 
            // Department_IdLookUpEdit
            // 
            this.Department_IdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Department_Id", true));
            this.Department_IdLookUpEdit.Location = new System.Drawing.Point(91, 168);
            this.Department_IdLookUpEdit.Name = "Department_IdLookUpEdit";
            this.Department_IdLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Department_IdLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Department_IdLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Department_IdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Department_IdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.Department_IdLookUpEdit.Properties.DataSource = this.departmentBindingSource;
            this.Department_IdLookUpEdit.Properties.DisplayMember = "Name";
            this.Department_IdLookUpEdit.Properties.NullText = "";
            this.Department_IdLookUpEdit.Properties.ValueMember = "Id";
            this.Department_IdLookUpEdit.Size = new System.Drawing.Size(583, 22);
            this.Department_IdLookUpEdit.StyleController = this.dataLayoutControl1;
            this.Department_IdLookUpEdit.TabIndex = 10;
            // 
            // ItemForDepartment_Id
            // 
            this.ItemForDepartment_Id.Control = this.Department_IdLookUpEdit;
            this.ItemForDepartment_Id.Location = new System.Drawing.Point(0, 156);
            this.ItemForDepartment_Id.Name = "ItemForDepartment_Id";
            this.ItemForDepartment_Id.Size = new System.Drawing.Size(666, 26);
            this.ItemForDepartment_Id.Text = "Department";
            this.ItemForDepartment_Id.TextSize = new System.Drawing.Size(67, 16);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(FinalTest.Department);
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataSource = typeof(FinalTest.Branch);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.employeeBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 194);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(662, 242);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colPhone1,
            this.colPhone2,
            this.colPhoto,
            this.colRole,
            this.colBranch_Id,
            this.colDepartment_Id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 182);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(666, 246);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 94;
            // 
            // colPhone1
            // 
            this.colPhone1.FieldName = "Phone1";
            this.colPhone1.MinWidth = 25;
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.Visible = true;
            this.colPhone1.VisibleIndex = 2;
            this.colPhone1.Width = 94;
            // 
            // colPhone2
            // 
            this.colPhone2.FieldName = "Phone2";
            this.colPhone2.MinWidth = 25;
            this.colPhone2.Name = "colPhone2";
            this.colPhone2.Visible = true;
            this.colPhone2.VisibleIndex = 3;
            this.colPhone2.Width = 94;
            // 
            // colPhoto
            // 
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.MinWidth = 25;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 4;
            this.colPhoto.Width = 94;
            // 
            // colRole
            // 
            this.colRole.FieldName = "Role";
            this.colRole.MinWidth = 25;
            this.colRole.Name = "colRole";
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 5;
            this.colRole.Width = 94;
            // 
            // colBranch_Id
            // 
            this.colBranch_Id.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colBranch_Id.FieldName = "Branch_Id";
            this.colBranch_Id.MinWidth = 25;
            this.colBranch_Id.Name = "colBranch_Id";
            this.colBranch_Id.Visible = true;
            this.colBranch_Id.VisibleIndex = 6;
            this.colBranch_Id.Width = 94;
            // 
            // colDepartment_Id
            // 
            this.colDepartment_Id.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colDepartment_Id.FieldName = "Department_Id";
            this.colDepartment_Id.MinWidth = 25;
            this.colDepartment_Id.Name = "colDepartment_Id";
            this.colDepartment_Id.Visible = true;
            this.colDepartment_Id.VisibleIndex = 7;
            this.colDepartment_Id.Width = 94;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit1.DataSource = this.departmentBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit2.DataSource = this.branchBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "Name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "Id";
            // 
            // EmployeeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 480);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "EmployeeFrm";
            this.Text = "EmployeeFrm";
            this.Load += new System.EventHandler(this.EmployeeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoImageEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Branch_IdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranch_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Department_IdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDepartment_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DevExpress.XtraEditors.TextEdit Phone1TextEdit;
        private DevExpress.XtraEditors.TextEdit Phone2TextEdit;
        private DevExpress.XtraEditors.ImageEdit PhotoImageEdit;
        private DevExpress.XtraEditors.TextEdit RoleTextEdit;
        private DevExpress.XtraEditors.LookUpEdit Branch_IdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit Department_IdLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhone1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhone2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhoto;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRole;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBranch_Id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDepartment_Id;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone2;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment_Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}