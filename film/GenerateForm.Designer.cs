
namespace film
{
    partial class GenerateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateForm));
            this.SubmitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.GenerateGenreComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateGenreComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitSimpleButton
            // 
            this.SubmitSimpleButton.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitSimpleButton.Appearance.Options.UseFont = true;
            this.SubmitSimpleButton.Location = new System.Drawing.Point(70, 462);
            this.SubmitSimpleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitSimpleButton.Name = "SubmitSimpleButton";
            this.SubmitSimpleButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.SubmitSimpleButton.Size = new System.Drawing.Size(155, 41);
            this.SubmitSimpleButton.TabIndex = 1;
            this.SubmitSimpleButton.Text = "Click";
            this.SubmitSimpleButton.Click += new System.EventHandler(this.SubmitSimpleButton_Click);
            // 
            // GenerateGenreComboBoxEdit
            // 
            this.GenerateGenreComboBoxEdit.EditValue = "Choose genre";
            this.GenerateGenreComboBoxEdit.Location = new System.Drawing.Point(54, 399);
            this.GenerateGenreComboBoxEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateGenreComboBoxEdit.Name = "GenerateGenreComboBoxEdit";
            this.GenerateGenreComboBoxEdit.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateGenreComboBoxEdit.Properties.Appearance.Options.UseFont = true;
            this.GenerateGenreComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GenerateGenreComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.GenerateGenreComboBoxEdit.Size = new System.Drawing.Size(199, 28);
            this.GenerateGenreComboBoxEdit.TabIndex = 2;
            
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(26, 38);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(240, 69);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "           If you don\'t know \n              what to watch,\n                click " +
    "below!";
            this.richTextBox1.UseWaitCursor = true;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(309, 516);
            this.pictureEdit1.TabIndex = 5;
            // 
            // GenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 516);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.GenerateGenreComboBoxEdit);
            this.Controls.Add(this.SubmitSimpleButton);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("GenerateForm.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateForm";
            this.Text = "GenerateFilm";
            this.Load += new System.EventHandler(this.GenerateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GenerateGenreComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton SubmitSimpleButton;
        private DevExpress.XtraEditors.ComboBoxEdit GenerateGenreComboBoxEdit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}