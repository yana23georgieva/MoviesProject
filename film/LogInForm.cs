using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace film
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If you click cancel, close current form and open main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm main = new mainForm();
            main.Show();
        }

        /// <summary>
        /// If you click submit, validate information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (usernameTextEdit.Text != "" && passwordTextEdit.Text != "")
            {
                //connect with db
                using(var db = new MovieLottoDBEntities())
                {
                    char[] passwordItems = passwordTextEdit.Text.ToCharArray();
                    string password = "";

                    //cript the password
                    for (int i = 0; i < passwordItems.Length; i++)
                    {
                        password += (char)((int)passwordItems[i] + 1);
                    }

                    //search for the current user
                    User currentUser = db.Users.Where(x => x.Username == usernameTextEdit.Text).
                        FirstOrDefault(x => x.Password == password);

                    if (currentUser == null)
                    {
                        MessageBox.Show("The password or username are incorrect.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Success log in. Load properties form with userId.
                        this.Close();
                        PropertiesForm properties = new PropertiesForm(currentUser.Id);
                        properties.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("You have to fill all gaps.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Enter)
            {
                submitButton_Click( sender,  e);
            }
        }

        private void passwordTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                submitButton_Click(sender, e);
            }
        }

    }
}