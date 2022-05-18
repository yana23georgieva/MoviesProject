using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace film
{
    public partial class mainForm : DevExpress.XtraEditors.XtraForm
    {
        public mainForm()
        {
            InitializeComponent();
        }

       /// <summary>
       /// Hide current form and load log in form.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form2 = new LoginForm();
            form2.Show();
        }

        /// <summary>
        /// Hide current form and load sign up form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
        }

        /// <summary>
        /// If you click "x" close the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
