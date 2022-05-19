using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace film
{
    public partial class SignUpForm : DevExpress.XtraEditors.XtraForm
    {
        private int userId = 0;
        private string button;
        private string command = "";
        public SignUpForm()
        {
            InitializeComponent();
        }

        public SignUpForm(int userId, string button) : this()
        {
            this.userId = userId;
            this.button = button;
        }

        public SignUpForm(string command) : this()
        {
            this.command = command;
        }

        /// <summary>
        /// If you click Cancel, close this form and load main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();

            if (this.userId == 0 && command == "")
            {
                mainForm main = new mainForm();
                main.Show();
            }
        }

        /// <summary>
        /// If you click submit, validate all data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitSimpleButton_Click(object sender, EventArgs e)
        {
            if (NameTextEdit.Text != "" && LastNameTextEdit.Text != "" && AgeTextEdit.Text != ""
                && GenderComboBoxEdit.Text != "" && EmailTextEdit.Text != "" && UsernameTextEdit.Text != ""
                && PasswordTextEdit.Text != "")
            {
                char[] notAllowedSymbols = {'?', '!', '@', '$', '#', '%', '*', ';',
                ',', '.', '(', ')', '+', '-', '{', '}', '[', ']', '=', '/','>','<',':', ' '};
                int flag = 0, flagCorrect = 0;

                foreach (var item in NameTextEdit.Text)
                {
                    if (char.IsDigit(item))
                    {
                        flag = 1;
                        flagCorrect = 1;
                        MessageBox.Show("Name can not contain digit.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (flag == 1)
                    {
                        break;
                    }
                }
                if (Check(notAllowedSymbols, NameTextEdit.Text) == false)
                {
                    flag = 1;
                    flagCorrect = 1;
                    MessageBox.Show("Incorrect name! Don't use special symbols.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (NameTextEdit.Text.Length < 2)
                {
                    flag = 1;
                    flagCorrect = 1;
                    MessageBox.Show("Name must be at least 2 characters.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                foreach (var item in LastNameTextEdit.Text)
                {
                    if (char.IsDigit(item))
                    {
                        flag = 1;
                        flagCorrect = 1;
                        MessageBox.Show("Last name can not contain digit.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (flag == 1)
                {
                    NameTextEdit.Text = "";
                    flag = 0;
                }



                if (Check(notAllowedSymbols, LastNameTextEdit.Text) == false)
                {
                    MessageBox.Show("Incorrect last name! Don't use special symbols.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                    flagCorrect = 1;
                }
                if (LastNameTextEdit.Text.Length < 2)
                {
                    MessageBox.Show("Last name must be at least 2 characters.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                    flagCorrect = 1;
                }
                if (flag == 1)
                {
                    LastNameTextEdit.Text = "";
                    flag = 0;
                }



                if (int.Parse(AgeTextEdit.EditValue.ToString()) <= 12 ||
                int.Parse(AgeTextEdit.EditValue.ToString()) > 100)
                {
                    MessageBox.Show("Incorrect age!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    AgeTextEdit.Text = "";
                    flagCorrect = 1;
                }



                string pattern = @"(^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$)";

                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(EmailTextEdit.Text))
                {
                    MessageBox.Show("Incorrect email!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmailTextEdit.Text = "";
                    flagCorrect = 1;
                }



                if (Check(notAllowedSymbols, UsernameTextEdit.Text) == false)
                {
                    MessageBox.Show("Incorrect username! Don't use special symbols.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                    flagCorrect = 1;
                }
                if (UsernameTextEdit.Text.Length < 5)
                {
                    MessageBox.Show("Username must be at least 6 characters.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                    flagCorrect = 1;
                }
                if (flag == 1)
                {
                    UsernameTextEdit.Text = "";
                    flag = 0;
                }




                if (PasswordTextEdit.Text.Contains(' '))
                {
                    MessageBox.Show("Not allowed to use space in your password.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                    flagCorrect = 1;
                }

                if (PasswordTextEdit.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                    flagCorrect = 1;
                }
                if (flag == 1)
                {
                    PasswordTextEdit.Text = "";
                    flag = 0;
                }

                if (PasswordTextEdit.Text != ConfirmPasswordTextEdit.Text)
                {
                    MessageBox.Show("The password confirmation does not match.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = 1;
                    flagCorrect = 1;
                }
                if (flag == 1)
                {
                    PasswordTextEdit.Text = "";
                    ConfirmPasswordTextEdit.Text = "";
                    flag = 0;
                }

                //conect db
                using (var db = new MovieLottoDBEntities())
                {
                    User user = db.Users.FirstOrDefault(x => x.Email == EmailTextEdit.Text);
                    if (user != null && this.userId == 0)
                    {
                        MessageBox.Show("This user allready exist.", "Exist",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flagCorrect = 1;
                    }

                    //registration or change was successfull.
                    if (flagCorrect == 0)
                    {
                        if (this.userId == 0)
                        {
                            MessageBox.Show("Your registration is successfull.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("You change it successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        char[] passwordItems = PasswordTextEdit.Text.ToCharArray();
                        string password = "";

                        //decript password
                        for (int i = 0; i < passwordItems.Length; i++)
                        {
                            password += (char)((int)passwordItems[i] + 1);
                        }

                        if (userId != 0)
                        {
                            //update current user in db.
                            User currentUser = db.Users.First(x => x.Id == this.userId);
                            currentUser.FirstName = NameTextEdit.Text;
                            currentUser.LastName = LastNameTextEdit.Text;
                            currentUser.Age = int.Parse(AgeTextEdit.Text);
                            currentUser.Gender = GenderComboBoxEdit.Text;
                            currentUser.Email = EmailTextEdit.Text;
                            currentUser.Username = UsernameTextEdit.Text;
                            currentUser.Password = password;
                            if (button == "Edit role")
                            {
                                currentUser.Role = RoleComboBoxEdit.Text;
                            }
                        }
                        else
                        {

                            //Add new user in db.
                            User newUser = new User
                            {

                                FirstName = NameTextEdit.Text,
                                LastName = LastNameTextEdit.Text,
                                Age = int.Parse(AgeTextEdit.Text),
                                Gender = GenderComboBoxEdit.Text,
                                Email = EmailTextEdit.Text,
                                Username = UsernameTextEdit.Text,
                                Password = password,
                                Role = "user"
                            };
                            db.Users.Add(newUser);
                        }

                        //save the data in db.
                        db.SaveChanges();
                        //change Dialog result to OK
                        DialogResult = DialogResult.OK;

                        //close current form.
                        this.Close();
                        //If you register (not update changes) load the log in form.
                        if (userId == 0 && command == "")
                        {
                            LoginForm login = new LoginForm();
                            login.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You have to fill all gaps.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Check that name or last name does not contains forbidden characters.
        /// </summary>
        /// <param name="symbols"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        bool Check(char[] symbols, string text)
        {
            foreach (var item in symbols)
            {
                if (text.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// When you start the current form, if you are not in properties form you have to add new
        /// user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpForm_Load(object sender, EventArgs e)
        {

            StarLabelControl.Visible = false;
            this.Size = new Size(373, 650);

            RoleLabelControl.Visible = false;
            RoleComboBoxEdit.Visible = false;
            if (command == "Add user")
            {
                this.Text = "Add user";
                this.Size = new Size(373, 645);

            }
            if (button == "Edit role")
            {
                using (var db = new MovieLottoDBEntities())
                {
                    User user = db.Users.First(x => x.Id == userId);
                    StarLabelControl.Visible = true;
                    RoleLabelControl.Visible = true;
                    RoleComboBoxEdit.Visible = true;
                    CancelSimpleButton.Location = new Point(196, 592);
                    SubmitSimpleButton.Location = new Point(21, 592);
                        this.Size = new Size(373,689);

                    RoleComboBoxEdit.Text = user.Role.ToString();
                    this.Text = "Edit user";
                }

            }
            else
            {
                CancelSimpleButton.Location = new Point(196, 548);
                SubmitSimpleButton.Location = new Point(21, 548);
            }

            if (userId != 0)
            {
                using (var db = new MovieLottoDBEntities())
                {
                    User currentUser = db.Users.First(x => x.Id == this.userId);

                    char[] passwordItems = currentUser.Password.ToCharArray();
                    string password = "";

                    for (int i = 0; i < passwordItems.Length; i++)
                    {
                        password += (char)((int)passwordItems[i] - 1);
                    }

                    //Fill the information.
                    NameTextEdit.Text = currentUser.FirstName;
                    LastNameTextEdit.Text = currentUser.LastName;
                    AgeTextEdit.Text = currentUser.Age.ToString();
                    GenderComboBoxEdit.Text = currentUser.Gender;
                    EmailTextEdit.Text = currentUser.Email;
                    UsernameTextEdit.Text = currentUser.Username;
                    PasswordTextEdit.Text = password;
                    if (button != "Edit role")
                    {
                        CancelSimpleButton.Location = new Point(196, 548);
                        SubmitSimpleButton.Location = new Point(21, 548);
                        this.Size = new Size(373, 660);
                    }
                    if (button == "Edit")
                    {
                        this.Text = "Edit profile";
                    }
                }

                // If you click my profile in properties form, you can't change the information
                // only see it.
                if (this.button == "MyProfile")
                {
                    NameTextEdit.Enabled = false;
                    LastNameTextEdit.Enabled = false;
                    AgeTextEdit.Enabled = false;
                    GenderComboBoxEdit.Enabled = false;
                    EmailTextEdit.Enabled = false;
                    UsernameTextEdit.Enabled = false;
                    PasswordTextEdit.Enabled = false;
                    SubmitSimpleButton.Visible = false;
                    ConfirmPasswordTextEdit.Visible = false;
                    ConfirmPasswordlabelControl.Visible = false;
                    labelControl1.Visible = false;
                    CancelSimpleButton.Location = new Point(95, 500);
                    this.Size = new Size(373, 600);
                    this.Text = "My profile";
                }
            }
        }

        private void PasswordTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SubmitSimpleButton_Click(sender, e);
            }
        }
    }
}