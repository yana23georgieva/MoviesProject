
namespace film
{
    partial class AddGenreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGenreForm));
            this.genreLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.AddSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.GenreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddGenrePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GenreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddGenrePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // genreLabelControl
            // 
            this.genreLabelControl.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreLabelControl.Appearance.Options.UseFont = true;
            this.genreLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.genreLabelControl.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.genreLabelControl.Location = new System.Drawing.Point(30, 76);
            this.genreLabelControl.Name = "genreLabelControl";
            this.genreLabelControl.Size = new System.Drawing.Size(58, 27);
            this.genreLabelControl.TabIndex = 5;
            this.genreLabelControl.Text = "Genre:";
            // 
            // AddSimpleButton
            // 
            this.AddSimpleButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddSimpleButton.Location = new System.Drawing.Point(12, 123);
            this.AddSimpleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddSimpleButton.Name = "AddSimpleButton";
            this.AddSimpleButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.AddSimpleButton.Size = new System.Drawing.Size(111, 38);
            this.AddSimpleButton.TabIndex = 25;
            this.AddSimpleButton.Text = "Add";
            this.AddSimpleButton.Click += new System.EventHandler(this.AddSimpleButton_Click);
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Location = new System.Drawing.Point(145, 123);
            this.CancelSimpleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.CancelSimpleButton.Size = new System.Drawing.Size(111, 38);
            this.CancelSimpleButton.TabIndex = 26;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // GenreTextEdit
            // 
            this.GenreTextEdit.Location = new System.Drawing.Point(106, 80);
            this.GenreTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenreTextEdit.Name = "GenreTextEdit";
            this.GenreTextEdit.Size = new System.Drawing.Size(150, 20);
            this.GenreTextEdit.TabIndex = 27;
            // 
            // AddGenrePictureBox
            // 
            this.AddGenrePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AddGenrePictureBox.Image")));
            this.AddGenrePictureBox.InitialImage = null;
            this.AddGenrePictureBox.Location = new System.Drawing.Point(72, 11);
            this.AddGenrePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddGenrePictureBox.Name = "AddGenrePictureBox";
            this.AddGenrePictureBox.Size = new System.Drawing.Size(128, 53);
            this.AddGenrePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddGenrePictureBox.TabIndex = 28;
            this.AddGenrePictureBox.TabStop = false;
            // 
            // AddGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 172);
            this.Controls.Add(this.AddGenrePictureBox);
            this.Controls.Add(this.GenreTextEdit);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.AddSimpleButton);
            this.Controls.Add(this.genreLabelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddGenreForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "AddGenreForm";
            this.Text = "Add Genre";
            ((System.ComponentModel.ISupportInitialize)(this.GenreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddGenrePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl genreLabelControl;
        private DevExpress.XtraEditors.SimpleButton AddSimpleButton;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.TextEdit GenreTextEdit;
        private System.Windows.Forms.PictureBox AddGenrePictureBox;
    }
}