
namespace FinalTest
{
    partial class QAFrm
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
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.dataLayoutControl3 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.TextTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.answerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Question_IdTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForQuestion_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForText = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuestion_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.questionLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl3)).BeginInit();
            this.dataLayoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question_IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuestion_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.dataLayoutControl2);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(399, 494);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.Controls.Add(this.dataLayoutControl3);
            this.dataLayoutControl2.Location = new System.Drawing.Point(12, 12);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.Root = this.Root;
            this.dataLayoutControl2.Size = new System.Drawing.Size(375, 470);
            this.dataLayoutControl2.TabIndex = 4;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // dataLayoutControl3
            // 
            this.dataLayoutControl3.Controls.Add(this.TextTextEdit);
            this.dataLayoutControl3.Controls.Add(this.Question_IdTextEdit);
            this.dataLayoutControl3.DataSource = this.answerBindingSource;
            this.dataLayoutControl3.Location = new System.Drawing.Point(12, 12);
            this.dataLayoutControl3.Name = "dataLayoutControl3";
            this.dataLayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(603, 209, 650, 400);
            this.dataLayoutControl3.Root = this.layoutControlGroup2;
            this.dataLayoutControl3.Size = new System.Drawing.Size(351, 446);
            this.dataLayoutControl3.TabIndex = 4;
            this.dataLayoutControl3.Text = "dataLayoutControl3";
            // 
            // TextTextEdit
            // 
            this.TextTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.answerBindingSource, "Text", true));
            this.TextTextEdit.Location = new System.Drawing.Point(58, 214);
            this.TextTextEdit.Name = "TextTextEdit";
            this.TextTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTextEdit.Properties.Appearance.Options.UseFont = true;
            this.TextTextEdit.Size = new System.Drawing.Size(281, 220);
            this.TextTextEdit.StyleController = this.dataLayoutControl3;
            this.TextTextEdit.TabIndex = 4;
            // 
            // answerBindingSource
            // 
            this.answerBindingSource.DataSource = typeof(FinalTest.Answer);
            // 
            // Question_IdTextEdit
            // 
            this.Question_IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.answerBindingSource, "Question", true));
            this.Question_IdTextEdit.Location = new System.Drawing.Point(58, 12);
            this.Question_IdTextEdit.Name = "Question_IdTextEdit";
            this.Question_IdTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.Question_IdTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question_IdTextEdit.Properties.Appearance.Options.UseFont = true;
            this.Question_IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Question_IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Question_IdTextEdit.Size = new System.Drawing.Size(281, 198);
            this.Question_IdTextEdit.StyleController = this.dataLayoutControl3;
            this.Question_IdTextEdit.TabIndex = 5;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(351, 446);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AllowDrawBackground = false;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForQuestion_Id,
            this.ItemForText});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "autoGeneratedGroup0";
            this.layoutControlGroup3.Size = new System.Drawing.Size(331, 426);
            // 
            // ItemForQuestion_Id
            // 
            this.ItemForQuestion_Id.Control = this.Question_IdTextEdit;
            this.ItemForQuestion_Id.Location = new System.Drawing.Point(0, 0);
            this.ItemForQuestion_Id.Name = "ItemForQuestion_Id";
            this.ItemForQuestion_Id.Size = new System.Drawing.Size(331, 202);
            this.ItemForQuestion_Id.Text = "Question";
            this.ItemForQuestion_Id.TextSize = new System.Drawing.Size(43, 13);
            // 
            // ItemForText
            // 
            this.ItemForText.Control = this.TextTextEdit;
            this.ItemForText.Location = new System.Drawing.Point(0, 202);
            this.ItemForText.Name = "ItemForText";
            this.ItemForText.Size = new System.Drawing.Size(331, 224);
            this.ItemForText.Text = "ANSWER";
            this.ItemForText.TextSize = new System.Drawing.Size(43, 13);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(375, 470);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dataLayoutControl3;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(355, 450);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(399, 494);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataLayoutControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(379, 474);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.answerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(399, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.questionLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(513, 494);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuestion_Id,
            this.colText,
            this.colDateTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colQuestion_Id
            // 
            this.colQuestion_Id.Caption = "Question";
            this.colQuestion_Id.ColumnEdit = this.questionLookUpEdit1;
            this.colQuestion_Id.FieldName = "Question_Id";
            this.colQuestion_Id.Name = "colQuestion_Id";
            this.colQuestion_Id.Visible = true;
            this.colQuestion_Id.VisibleIndex = 2;
            // 
            // questionLookUpEdit1
            // 
            this.questionLookUpEdit1.AutoHeight = false;
            this.questionLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.questionLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Text", 31, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.questionLookUpEdit1.DataSource = this.questionBindingSource;
            this.questionLookUpEdit1.DisplayMember = "Text";
            this.questionLookUpEdit1.Name = "questionLookUpEdit1";
            this.questionLookUpEdit1.ValueMember = "Id";
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(FinalTest.Question);
            // 
            // colText
            // 
            this.colText.Caption = "Answer";
            this.colText.FieldName = "Text";
            this.colText.Name = "colText";
            this.colText.Visible = true;
            this.colText.VisibleIndex = 0;
            // 
            // colDateTime
            // 
            this.colDateTime.FieldName = "DateTime";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.Visible = true;
            this.colDateTime.VisibleIndex = 1;
            // 
            // QAFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 494);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "QAFrm";
            this.Text = "QAFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl3)).EndInit();
            this.dataLayoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question_IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuestion_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource answerBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colText;
        private DevExpress.XtraGrid.Columns.GridColumn colDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colQuestion_Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit questionLookUpEdit1;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl3;
        private DevExpress.XtraEditors.MemoEdit TextTextEdit;
        private DevExpress.XtraEditors.MemoEdit Question_IdTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQuestion_Id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForText;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}