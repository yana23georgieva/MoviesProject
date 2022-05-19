
namespace film
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usernameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.passwordLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.usernameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.submitButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.LogInPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabelControl
            // 
            this.usernameLabelControl.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabelControl.Appearance.Options.UseFont = true;
            this.usernameLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.usernameLabelControl.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLabelControl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("usernameLabelControl.ImageOptions.Image")));
            this.usernameLabelControl.Location = new System.Drawing.Point(23, 107);
            this.usernameLabelControl.Name = "usernameLabelControl";
            this.usernameLabelControl.Size = new System.Drawing.Size(136, 31);
            this.usernameLabelControl.TabIndex = 0;
            this.usernameLabelControl.Text = "           Username:";
            // 
            // passwordLabelControl
            // 
            this.passwordLabelControl.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabelControl.Appearance.Options.UseFont = true;
            this.passwordLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.passwordLabelControl.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordLabelControl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("passwordLabelControl.ImageOptions.Image")));
            this.passwordLabelControl.Location = new System.Drawing.Point(23, 162);
            this.passwordLabelControl.Name = "passwordLabelControl";
            this.passwordLabelControl.Size = new System.Drawing.Size(136, 31);
            this.passwordLabelControl.TabIndex = 1;
            this.passwordLabelControl.Text = "            Password:";
            // 
            // usernameTextEdit
            // 
            this.usernameTextEdit.Location = new System.Drawing.Point(165, 115);
            this.usernameTextEdit.Name = "usernameTextEdit";
            this.usernameTextEdit.Size = new System.Drawing.Size(157, 20);
            this.usernameTextEdit.TabIndex = 2;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(165, 170);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '●';
            this.passwordTextEdit.Size = new System.Drawing.Size(157, 20);
            this.passwordTextEdit.TabIndex = 3;
            this.passwordTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextEdit_KeyPress);
            // 
            // submitButton
            // 
            this.submitButton.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Appearance.Options.UseFont = true;
            this.submitButton.Location = new System.Drawing.Point(12, 225);
            this.submitButton.Name = "submitButton";
            this.submitButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.submitButton.Size = new System.Drawing.Size(125, 29);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Appearance.Options.UseFont = true;
            this.cancelButton.Location = new System.Drawing.Point(199, 225);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cancelButton.Size = new System.Drawing.Size(125, 29);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LogInPictureBox
            // 
            this.LogInPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogInPictureBox.Image")));
            this.LogInPictureBox.Location = new System.Drawing.Point(105, 11);
            this.LogInPictureBox.Name = "LogInPictureBox";
            this.LogInPictureBox.Size = new System.Drawing.Size(123, 73);
            this.LogInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogInPictureBox.TabIndex = 6;
            this.LogInPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 268);
            this.ControlBox = false;
            this.Controls.Add(this.LogInPictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordTextEdit);
            this.Controls.Add(this.usernameTextEdit);
            this.Controls.Add(this.passwordLabelControl);
            this.Controls.Add(this.usernameLabelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LoginForm.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl usernameLabelControl;
        private DevExpress.XtraEditors.LabelControl passwordLabelControl;
        private DevExpress.XtraEditors.TextEdit usernameTextEdit;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.SimpleButton submitButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private System.Windows.Forms.PictureBox LogInPictureBox;
    }
}