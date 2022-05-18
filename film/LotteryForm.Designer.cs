
namespace film
{
    partial class LotteryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LotteryForm));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.GenerateButtonPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.GenerateSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.LotteryGridControl = new DevExpress.XtraGrid.GridControl();
            this.LotteryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFilmName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateButtonPanelControl)).BeginInit();
            this.GenerateButtonPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LotteryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotteryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateButtonPanelControl
            // 
            this.GenerateButtonPanelControl.Appearance.BackColor = System.Drawing.Color.Navy;
            this.GenerateButtonPanelControl.Appearance.Options.UseBackColor = true;
            this.GenerateButtonPanelControl.AutoSize = true;
            this.GenerateButtonPanelControl.Controls.Add(this.GenerateSimpleButton);
            this.GenerateButtonPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.GenerateButtonPanelControl.Location = new System.Drawing.Point(0, 0);
            this.GenerateButtonPanelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateButtonPanelControl.Name = "GenerateButtonPanelControl";
            this.GenerateButtonPanelControl.Size = new System.Drawing.Size(996, 90);
            this.GenerateButtonPanelControl.TabIndex = 0;
            // 
            // GenerateSimpleButton
            // 
            this.GenerateSimpleButton.Appearance.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateSimpleButton.Appearance.ForeColor = System.Drawing.Color.Black;
            this.GenerateSimpleButton.Appearance.Options.UseFont = true;
            this.GenerateSimpleButton.Appearance.Options.UseForeColor = true;
            this.GenerateSimpleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GenerateSimpleButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenerateSimpleButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.GenerateSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GenerateSimpleButton.ImageOptions.Image")));
            this.GenerateSimpleButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.GenerateSimpleButton.Location = new System.Drawing.Point(2, 2);
            this.GenerateSimpleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateSimpleButton.Name = "GenerateSimpleButton";
            this.GenerateSimpleButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.GenerateSimpleButton.Size = new System.Drawing.Size(992, 86);
            this.GenerateSimpleButton.TabIndex = 0;
            this.GenerateSimpleButton.Text = "GENERATE FILM";
            this.GenerateSimpleButton.Click += new System.EventHandler(this.GenerateSimpleButton_Click);
            // 
            // LotteryGridControl
            // 
            this.LotteryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LotteryGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.LotteryGridControl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Level1";
            this.LotteryGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.LotteryGridControl.Location = new System.Drawing.Point(0, 90);
            this.LotteryGridControl.MainView = this.LotteryGridView;
            this.LotteryGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LotteryGridControl.Name = "LotteryGridControl";
            this.LotteryGridControl.Size = new System.Drawing.Size(996, 251);
            this.LotteryGridControl.TabIndex = 2;
            this.LotteryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LotteryGridView});
            // 
            // LotteryGridView
            // 
            this.LotteryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFilmName,
            this.colGenre,
            this.colYear,
            this.colSize,
            this.colDescription,
            this.colAddDate,
            this.colUser,
            this.gridColumn4});
            this.LotteryGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.LotteryGridView.GridControl = this.LotteryGridControl;
            this.LotteryGridView.Name = "LotteryGridView";
            this.LotteryGridView.OptionsBehavior.Editable = false;
            this.LotteryGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colFilmName
            // 
            this.colFilmName.FieldName = "FilmName";
            this.colFilmName.Name = "colFilmName";
            this.colFilmName.OptionsColumn.ReadOnly = true;
            this.colFilmName.Visible = true;
            this.colFilmName.VisibleIndex = 0;
            // 
            // colGenre
            // 
            this.colGenre.Caption = "Genre";
            this.colGenre.FieldName = "Genre.GenreType";
            this.colGenre.Name = "colGenre";
            this.colGenre.OptionsColumn.ReadOnly = true;
            this.colGenre.Visible = true;
            this.colGenre.VisibleIndex = 2;
            // 
            // colYear
            // 
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.OptionsColumn.ReadOnly = true;
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 1;
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.OptionsColumn.ReadOnly = true;
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // colAddDate
            // 
            this.colAddDate.FieldName = "AddDate";
            this.colAddDate.Name = "colAddDate";
            this.colAddDate.OptionsColumn.ReadOnly = true;
            this.colAddDate.Visible = true;
            this.colAddDate.VisibleIndex = 5;
            // 
            // colUser
            // 
            this.colUser.Caption = "Name of user";
            this.colUser.FieldName = "User.NamesOfUser";
            this.colUser.Name = "colUser";
            this.colUser.OptionsColumn.ReadOnly = true;
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 6;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Rating";
            this.gridColumn4.FieldName = "Rating";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            // 
            // LotteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 341);
            this.Controls.Add(this.LotteryGridControl);
            this.Controls.Add(this.GenerateButtonPanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("LotteryForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LotteryForm";
            this.Text = "Lottery";
            this.Load += new System.EventHandler(this.LotteryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GenerateButtonPanelControl)).EndInit();
            this.GenerateButtonPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LotteryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotteryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl GenerateButtonPanelControl;
        private DevExpress.XtraEditors.SimpleButton GenerateSimpleButton;
        private DevExpress.XtraGrid.GridControl LotteryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView LotteryGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFilmName;
        private DevExpress.XtraGrid.Columns.GridColumn colGenre;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colAddDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}