
namespace film
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.logInButton = new DevExpress.XtraEditors.SimpleButton();
            this.signUpButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.AllowFocus = false;
            this.logInButton.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.logInButton.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInButton.Appearance.Options.UseBackColor = true;
            this.logInButton.Appearance.Options.UseFont = true;
            this.logInButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("logInButton.ImageOptions.Image")));
            this.logInButton.Location = new System.Drawing.Point(79, 39);
            this.logInButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logInButton.Name = "logInButton";
            this.logInButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.logInButton.Size = new System.Drawing.Size(182, 48);
            this.logInButton.TabIndex = 14;
            this.logInButton.Text = "Log In";
            this.logInButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.AllowFocus = false;
            this.signUpButton.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.Appearance.Options.UseBackColor = true;
            this.signUpButton.Appearance.Options.UseFont = true;
            this.signUpButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("signUpButton.ImageOptions.Image")));
            this.signUpButton.Location = new System.Drawing.Point(79, 122);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.signUpButton.Size = new System.Drawing.Size(182, 48);
            this.signUpButton.TabIndex = 15;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 206);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.logInButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mainForm.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton logInButton;
        private DevExpress.XtraEditors.SimpleButton signUpButton;
    }
}

