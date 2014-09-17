namespace Cards
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
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFASL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(0, 41);
            this.gridControlMain.MainView = this.gridViewData;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(800, 369);
            this.gridControlMain.TabIndex = 1;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSNAME,
            this.colSAF,
            this.colFASL,
            this.colPHONE,
            this.colUSERNAME,
            this.colPASSWORD,
            this.colIMG,
            this.colEdara,
            this.colGov});
            this.gridViewData.GridControl = this.gridControlMain;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 55;
            // 
            // colSNAME
            // 
            this.colSNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colSNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colSNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSNAME.Caption = "الاسم";
            this.colSNAME.FieldName = "SNAME";
            this.colSNAME.Name = "colSNAME";
            this.colSNAME.Visible = true;
            this.colSNAME.VisibleIndex = 1;
            this.colSNAME.Width = 206;
            // 
            // colSAF
            // 
            this.colSAF.AppearanceCell.Options.UseTextOptions = true;
            this.colSAF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSAF.AppearanceHeader.Options.UseTextOptions = true;
            this.colSAF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSAF.Caption = "الصف";
            this.colSAF.FieldName = "SAF";
            this.colSAF.Name = "colSAF";
            this.colSAF.Visible = true;
            this.colSAF.VisibleIndex = 2;
            this.colSAF.Width = 70;
            // 
            // colFASL
            // 
            this.colFASL.AppearanceCell.Options.UseTextOptions = true;
            this.colFASL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL.AppearanceHeader.Options.UseTextOptions = true;
            this.colFASL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFASL.Caption = "الفصل";
            this.colFASL.FieldName = "FASL";
            this.colFASL.Name = "colFASL";
            this.colFASL.Visible = true;
            this.colFASL.VisibleIndex = 3;
            this.colFASL.Width = 52;
            // 
            // colPHONE
            // 
            this.colPHONE.AppearanceCell.Options.UseTextOptions = true;
            this.colPHONE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHONE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE.Caption = "التليفون";
            this.colPHONE.FieldName = "PHONE";
            this.colPHONE.Name = "colPHONE";
            this.colPHONE.Visible = true;
            this.colPHONE.VisibleIndex = 4;
            this.colPHONE.Width = 56;
            // 
            // colUSERNAME
            // 
            this.colUSERNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colUSERNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colUSERNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUSERNAME.Caption = "اسم المستخدم";
            this.colUSERNAME.FieldName = "USERNAME";
            this.colUSERNAME.Name = "colUSERNAME";
            this.colUSERNAME.Visible = true;
            this.colUSERNAME.VisibleIndex = 5;
            this.colUSERNAME.Width = 104;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.AppearanceCell.Options.UseTextOptions = true;
            this.colPASSWORD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPASSWORD.AppearanceHeader.Options.UseTextOptions = true;
            this.colPASSWORD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPASSWORD.Caption = "الرقم السري";
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.Name = "colPASSWORD";
            this.colPASSWORD.Visible = true;
            this.colPASSWORD.VisibleIndex = 6;
            this.colPASSWORD.Width = 77;
            // 
            // colIMG
            // 
            this.colIMG.AppearanceCell.Options.UseTextOptions = true;
            this.colIMG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIMG.AppearanceHeader.Options.UseTextOptions = true;
            this.colIMG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIMG.FieldName = "IMG";
            this.colIMG.Name = "colIMG";
            // 
            // colEdara
            // 
            this.colEdara.AppearanceCell.Options.UseTextOptions = true;
            this.colEdara.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdara.AppearanceHeader.Options.UseTextOptions = true;
            this.colEdara.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdara.Caption = "الادارة";
            this.colEdara.FieldName = "Edara";
            this.colEdara.Name = "colEdara";
            this.colEdara.Visible = true;
            this.colEdara.VisibleIndex = 7;
            // 
            // colGov
            // 
            this.colGov.AppearanceCell.Options.UseTextOptions = true;
            this.colGov.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGov.AppearanceHeader.Options.UseTextOptions = true;
            this.colGov.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGov.Caption = "المحافظه";
            this.colGov.FieldName = "Gov";
            this.colGov.Name = "colGov";
            this.colGov.Visible = true;
            this.colGov.VisibleIndex = 8;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(651, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "طباعة و تصدير";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // MissingPhotoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gridControlMain);
            this.Name = "MissingPhotoFrm";
            this.Text = "الصور المفقودة";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSAF;
        private DevExpress.XtraGrid.Columns.GridColumn colFASL;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colUSERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD;
        private DevExpress.XtraGrid.Columns.GridColumn colIMG;
        private DevExpress.XtraGrid.Columns.GridColumn colEdara;
        private DevExpress.XtraGrid.Columns.GridColumn colGov;
        private DevExpress.XtraEditors.SimpleButton btnPrint;


    }
}