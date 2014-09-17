namespace CardSets
{
    partial class MissingPhotoFrm
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
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colchk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFASL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(0, 0);
            this.gridControlMain.MainView = this.gridViewData;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlMain.Size = new System.Drawing.Size(693, 410);
            this.gridControlMain.TabIndex = 1;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colchk,
            this.colID,
            this.colSNAME,
            this.colSAF,
            this.colFASL,
            this.colPHONE,
            this.colUSERNAME,
            this.colIMG});
            this.gridViewData.GridControl = this.gridControlMain;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // colchk
            // 
            this.colchk.AppearanceCell.Options.UseTextOptions = true;
            this.colchk.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colchk.AppearanceHeader.Options.UseTextOptions = true;
            this.colchk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colchk.Caption = "اختر";
            this.colchk.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colchk.FieldName = "chk";
            this.colchk.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colchk.Name = "colchk";
            this.colchk.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colchk.Visible = true;
            this.colchk.VisibleIndex = 0;
            this.colchk.Width = 47;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colID
            // 
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "ID";
            this.colID.FieldName = "memberid";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            this.colID.Width = 46;
            // 
            // colSNAME
            // 
            this.colSNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colSNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colSNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSNAME.Caption = "الاسم";
            this.colSNAME.FieldName = "membername";
            this.colSNAME.Name = "colSNAME";
            this.colSNAME.OptionsColumn.AllowEdit = false;
            this.colSNAME.Visible = true;
            this.colSNAME.VisibleIndex = 2;
            this.colSNAME.Width = 206;
            // 
            // colSAF
            // 
            this.colSAF.AppearanceCell.Options.UseTextOptions = true;
            this.colSAF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSAF.AppearanceHeader.Options.UseTextOptions = true;
            this.colSAF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSAF.Caption = "الفئة";
            this.colSAF.FieldName = "titleName";
            this.colSAF.Name = "colSAF";
            this.colSAF.OptionsColumn.AllowEdit = false;
            this.colSAF.Visible = true;
            this.colSAF.VisibleIndex = 3;
            this.colSAF.Width = 70;
            // 
            // colFASL
            // 
            this.colFASL.AppearanceCell.Options.UseTextOptions = true;
            this.colFASL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL.AppearanceHeader.Options.UseTextOptions = true;
            this.colFASL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL.Caption = "الصفة النقابية";
            this.colFASL.FieldName = "sefaName";
            this.colFASL.Name = "colFASL";
            this.colFASL.OptionsColumn.AllowEdit = false;
            this.colFASL.Visible = true;
            this.colFASL.VisibleIndex = 4;
            this.colFASL.Width = 91;
            // 
            // colPHONE
            // 
            this.colPHONE.AppearanceCell.Options.UseTextOptions = true;
            this.colPHONE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHONE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE.Caption = "الفرعية";
            this.colPHONE.FieldName = "LagnaName";
            this.colPHONE.Name = "colPHONE";
            this.colPHONE.OptionsColumn.AllowEdit = false;
            this.colPHONE.Visible = true;
            this.colPHONE.VisibleIndex = 5;
            this.colPHONE.Width = 85;
            // 
            // colUSERNAME
            // 
            this.colUSERNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERNAME.Caption = "اللجنة";
            this.colUSERNAME.FieldName = "subcommite";
            this.colUSERNAME.Name = "colUSERNAME";
            this.colUSERNAME.OptionsColumn.AllowEdit = false;
            this.colUSERNAME.Visible = true;
            this.colUSERNAME.VisibleIndex = 6;
            this.colUSERNAME.Width = 104;
            // 
            // colIMG
            // 
            this.colIMG.AppearanceCell.Options.UseTextOptions = true;
            this.colIMG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIMG.AppearanceHeader.Options.UseTextOptions = true;
            this.colIMG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIMG.Caption = "الصورة";
            this.colIMG.FieldName = "imgpath";
            this.colIMG.Name = "colIMG";
            this.colIMG.OptionsColumn.AllowEdit = false;
            this.colIMG.Visible = true;
            this.colIMG.VisibleIndex = 7;
            this.colIMG.Width = 87;
            // 
            // MissingPhotoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.gridControlMain);
            this.Name = "MissingPhotoFrm";
            this.Text = "الصور المفقودة";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn colchk;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSAF;
        private DevExpress.XtraGrid.Columns.GridColumn colFASL;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colUSERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colIMG;

    }
}