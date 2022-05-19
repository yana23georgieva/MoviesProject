using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using System.Data.Entity;

namespace film
{
    public partial class PropertiesForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int userId;

        public PropertiesForm()
        {
            InitializeComponent();
        }

        public PropertiesForm(int id) : this()
        {
            this.userId = id;
        }

        /// <summary>
        /// Default value of categoryBarEditItem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PropertiesForm_Load(object sender, EventArgs e)
        {
            CategoryBarEditItem.EditValue = "All Films";
            gridColumn5.Visible = false;
            LotteryGridControl.Visible = false;
            using (var db = new MovieLottoDBEntities())
            {
                db.Genres.Load();
                db.Users.Load();
                db.Films.Load();
                FilmGridControl.DataSource = db.Films.Where(x => x.DateWatch == null).ToList();

                User currentUser = db.Users.First(x => x.Id == userId);
                if (currentUser.Role != "admin")
                {
                    AdminRibbonPage.Visible = false;
                }

                AdminGridControl.Visible = false;
                AdminGridControl.DataSource = db.Users.ToList();
            }
        }

        /// <summary>
        /// Load sign up form with all fill gaps without changing anything.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            LotteryGridControl.Visible = false;
            gridColumn5.Visible = false;
            filmRibbonPageGroup.Enabled = true;
            voteBarButtonItem.Enabled = true;
            CategoryBarEditItemEditValue();
            SignUpForm signUp = new SignUpForm(this.userId, "MyProfile");
            signUp.Show();
        }

        /// <summary>
        /// Load sign up form with all fill gaps with changing option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            LotteryGridControl.Visible = false;
            filmRibbonPageGroup.Enabled = true;
            voteBarButtonItem.Enabled = true;
            CategoryBarEditItemEditValue();
            gridColumn5.Visible = false;            
            SignUpForm signUp = new SignUpForm(this.userId, "Edit");
            //If we click submit to reload the table.
            if (signUp.ShowDialog() == DialogResult.OK)
            {
                CategoryBarEditItemEditValue();
                UpdateUsers();
            }
        }

        /// <summary>
        /// MessageBox to conferm deleting user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridColumn5.Visible = false;
            DialogResult result = MessageBox.Show("Are you sure you want to delete " +
                " yourself?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var db = new MovieLottoDBEntities())
                {
                    User user = db.Users.First(x => x.Id == userId);
                    //First we delete list of films of current user.
                    List<Film> userFilms = db.Films.Where(x => x.UserId == user.Id)
                        .ToList();

                    foreach (var item in userFilms)
                    {
                        db.Films.Remove(item);
                    }

                    //Remove current user.
                    db.Users.Remove(user);
                    db.SaveChanges();
                    this.Close();
                    mainForm mainForm = new mainForm();
                    mainForm.Show();
                }
            }
        }

        /// <summary>
        /// Log out from properties form and load the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogOutBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridColumn5.Visible = false;
            this.Hide();
            mainForm main = new mainForm();
            main.Show();
        }

        /// <summary>
        /// Close the full application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridColumn5.Visible = false;
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// If you click "x", close the full application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PropertiesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Depending on the selected category, to visualize different types of information and 
        /// access to the given buttons is different.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryBarEditItem_EditValueChanged(object sender, EventArgs e)
        {
            LotteryGridControl.Visible = false;

            CategoryBarEditItemEditValue();
        }
        private void CategoryBarEditItemEditValue()
        {
            gridColumn5.Visible = false;
           
            if (CategoryBarEditItem.EditValue.ToString() == "All Films")
            {
                FilmDataGridViewClear();
                using (var db = new MovieLottoDBEntities())
                {
                    voteBarButtonItem.Enabled = false;
                    User userCheck = db.Users.First(x => x.Id == userId);
                    if (userCheck.Role != "admin")
                    {
                        removeFilmBarButtonItem.Enabled = false;
                        editFilmBarButtonItem.Enabled = false;
                    }
                    foreach (var item in db.Films)
                    {
                        User user = db.Users.First(x => x.Id == item.UserId);
                        string username = $"{user.FirstName} {user.LastName}";
                        Genre genre = db.Genres.First(x => x.Id == item.GenreId);
                        string genreStr = $"{genre.Genre1}";

                        FilmDataGridView.Rows.Add(item.FilmName, genreStr, item.Year,
                            item.Description, item.Size, item.AddDate, username);

                        FilmGridControl.DataSource = db.Films.Where(x=>x.DateWatch==null).ToList();
                    }
                }

            }
            else if (CategoryBarEditItem.EditValue.ToString() == "My Films")
            {
                FilmDataGridViewClear();
                using (var db = new MovieLottoDBEntities())
                {
                    foreach (var item in db.Films)
                    {
                        if (item.UserId == userId)
                        {
                            User user = db.Users.First(x => x.Id == item.UserId);
                            string username = $"{user.FirstName} {user.LastName}";
                            Genre genre = db.Genres.First(x => x.Id == item.GenreId);
                            string genreStr = $"{genre.Genre1}";

                            FilmDataGridView.Rows.Add(item.FilmName, genreStr, item.Year,
                                item.Description, item.Size, item.AddDate, username);
                            removeFilmBarButtonItem.Enabled = true;
                            editFilmBarButtonItem.Enabled = true;
                            voteBarButtonItem.Enabled = false;

                            FilmGridControl.DataSource = db.Films.Where(x => x.DateWatch == null).Where(x => x.UserId == userId).ToList();
                        }
                    }
                }

            }
            else if (CategoryBarEditItem.EditValue.ToString() == "All Films without mine")
            {
                FilmDataGridViewClear();
                using (var db = new MovieLottoDBEntities())
                {
                    foreach (var item in db.Films)
                    {
                        if (item.UserId != userId)
                        {
                            User user = db.Users.First(x => x.Id == item.UserId);
                            string username = $"{user.FirstName} {user.LastName}";
                            Genre genre = db.Genres.First(x => x.Id == item.GenreId);
                            string genreStr = $"{genre.Genre1}";

                            FilmDataGridView.Rows.Add(item.FilmName, genreStr, item.Year,
                                item.Description, item.Size, item.AddDate, username);
                            User userCheck = db.Users.First(x => x.Id == userId);
                            voteBarButtonItem.Enabled = true;
                            if (userCheck.Role != "admin")
                            {
                                removeFilmBarButtonItem.Enabled = false;
                                editFilmBarButtonItem.Enabled = false;
                            }
                            FilmGridControl.DataSource = db.Films.Where(x => x.DateWatch == null).Where(x => x.UserId != userId).ToList();


                        }
                    }
                }

            }

        }
        /// <summary>
        /// Load the form for adding new film.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addFilmBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            LotteryGridControl.Visible = false;

            AddFilm();
        }
        private void AddFilm()
        {
            gridColumn5.Visible = false;
            FilmForm filmForm = new FilmForm(userId);
            if (filmForm.ShowDialog() == DialogResult.OK)
            {
                CategoryBarEditItemEditValue();
            }
        }

        /// <summary>
        /// Clean the table.
        /// </summary>
        private void FilmDataGridViewClear()
        {
            while (FilmDataGridView.RowCount != 1)
            {
                FilmDataGridView.Rows.RemoveAt(0);
            }

            while (FilmGridView.RowCount != 0)
            {
                FilmGridView.DeleteRow(0);
            }
        }


        /// <summary>
        /// Remove the film..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeFilmBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            LotteryGridControl.Visible = false;
            RemoveFilm();
           // CategoryBarEditItemEditValue();
            
        }
        private void RemoveFilm()
        {
            gridColumn5.Visible = false;
             DialogResult result = MessageBox.Show("Are you sure you want to remove this" +
             " movie?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                using (var db = new MovieLottoDBEntities())
                {
                    Film currentFilm = GetCurrentFilm();
                    if (currentFilm != null)
                    {
                        Film film = db.Films.First(x => x.Id == currentFilm.Id);
                        db.Films.Remove(film);
                        db.SaveChanges();
                        CategoryBarEditItemEditValue();
                    }
                }
            }
        }

        /// <summary>
        /// Depending on which row is clicked, in the table we understand which movie is the 
        /// current one.
        /// </summary>
        /// <returns></returns>
        private Film GetCurrentFilm()
        {
            using (var db = new MovieLottoDBEntities())
            {
                /*int rowIndex = FilmDataGridView.SelectedCells[0].RowIndex;
                if (FilmDataGridView[0, rowIndex].Value == null)
                {
                    MessageBox.Show("You have to choose correct line!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                string filmName = FilmDataGridView[0, rowIndex].Value.ToString();
                Film currentFilm = db.Films.First(x => x.FilmName == filmName);
                return currentFilm;*/

                int row = FilmGridView.FocusedRowHandle;
                string filmName = FilmGridView.GetRowCellValue(row, "FilmName").ToString();
                Film currentFilm = db.Films.First(x => x.FilmName == filmName);
                return currentFilm;
            }
        }

        private User GetCurrentUser()
        {
            using (var db = new MovieLottoDBEntities())
            {
                int row = AdminGridView.FocusedRowHandle;
                string userName = AdminGridView.GetRowCellValue(row, "FirstName").ToString();
                User currentUser = db.Users.First(x => x.FirstName == userName);
                return currentUser;
            }
        }

        /// <summary>
        /// Depending on which row is clicked, in the table we understand which movie we will 
        /// edit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editFilmBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            LotteryGridControl.Visible = false;

            gridColumn5.Visible = false;
            using (var db = new MovieLottoDBEntities())
            {
                Film film = GetCurrentFilm();
                if (film != null)
                {
                    FilmForm filmForm = new FilmForm(film.Id, film);
                    if (filmForm.ShowDialog() == DialogResult.OK)
                    {
                        CategoryBarEditItemEditValue();
                    }
                }

            }
        }

        private void voteBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridColumn5.Visible = false;
            Film film = GetCurrentFilm();
            using (var db = new MovieLottoDBEntities())
            {
                if (film != null)
                {
                    Film filmVote = db.Films.First(x => x.Id == film.Id);
                    MessageBox.Show($"You have vote for film {filmVote.FilmName}!");
                    filmVote.Rating += 1;
                    db.SaveChanges();
                    CategoryBarEditItem_EditValueChanged(sender, e);

                }
            }
        }

        private void UpdateUsers()
        {
            using (var db = new MovieLottoDBEntities())
            {
                db.Genres.Load();
                db.Users.Load();
                db.Films.Load();
                AdminGridControl.DataSource = db.Users.ToList();
            }
        }

        private void AdminAddBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            AdminAddNewUser();
        }

        private void AdminAddNewUser()
        {
            SignUpForm signUp = new SignUpForm("Add user");
            if (signUp.ShowDialog() == DialogResult.OK)
            {
                UpdateUsers();
            }
        }

        private void AdminEditBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var db = new MovieLottoDBEntities())
            {
                User currentUser = GetCurrentUser();
                SignUpForm signUp = new SignUpForm(currentUser.Id, "Edit role");
                
                if (signUp.ShowDialog() == DialogResult.OK)
                {
                    UpdateUsers();
                }
            }
        }

        private void AdminDeletebarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            AdminDeleteUser();
        }
        private void AdminDeleteUser()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this" +
               " user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var db = new MovieLottoDBEntities())
                {
                    User currentUser = GetCurrentUser();
                    if (currentUser != null)
                    {
                        User user = db.Users.First(x => x.Id == currentUser.Id);
                        //First we delete list of films of current user.
                        List<Film> userFilms = db.Films.Where(x => x.UserId == user.Id)
                            .ToList();

                        foreach (var item in userFilms)
                        {
                            db.Films.Remove(item);
                        }

                        //Remove current user.
                        db.Users.Remove(user);
                        db.SaveChanges();
                        UpdateUsers();
                    }
                }
            }
        }
        private void ribbon_Click(object sender, EventArgs e)
        {
            LotteryGridControl.Visible = false;

            if (ribbon.SelectedPage.Name == AdminRibbonPage.Name)
            {
                AdminGridControl.Visible = true;
            }
            else if (ribbon.SelectedPage.Name == HomeRibbonPage.Name)
            {
                gridColumn5.Visible = false;
                AdminGridControl.Visible = false;
                //CategoryBarEditItemEditValue();
            }
        }

        private void generateBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            LotteryGridControl.Visible = false;

            gridColumn5.Visible = false;
            GenerateForm generate = new GenerateForm();
            CategoryBarEditItemEditValue();
            if (generate.ShowDialog() == DialogResult.OK)
            {
                CategoryBarEditItemEditValue();
            }
        }


        private void historyBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            LotteryGridControl.Visible = false;

            gridColumn5.Visible = true;
            filmRibbonPageGroup.Enabled = false;
            voteBarButtonItem.Enabled = false;
            FilmDataGridViewClear();
            using (var db = new MovieLottoDBEntities())
            {
                FilmGridControl.DataSource = db.Films.Where(x => x.DateWatch != null).ToList();
            }
        }


        private void AdminGridView_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Insert)
            {
                AdminAddNewUser();
            }
             if (e.KeyCode == Keys.Delete)
            {
                AdminDeleteUser();
            }
        }

        private void FilmGridView_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Insert)
            {
                AddFilm();
            }
             if (e.KeyCode == Keys.Delete)
            {
                RemoveFilm();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var db = new MovieLottoDBEntities())
            {
                db.Genres.Load();
                db.Users.Load();
                db.Films.Load();
                db.LotaryRoles.Load();
                db.Lotaries.Load();
                LotteryGridControl.DataSource = db.LotaryRoles.ToList();
            }
            LotteryGridControl.Visible = true;
            filmRibbonPageGroup.Enabled = false;
        }

        private void AdminGridView_DoubleClick(object sender, EventArgs e)
        {
            using (var db = new MovieLottoDBEntities())
            {
                User currentUser = GetCurrentUser();
                SignUpForm signUp = new SignUpForm(currentUser.Id, "Edit role");

                if (signUp.ShowDialog() == DialogResult.OK)
                {
                    UpdateUsers();
                }
            }
        }

        private void FilmGridView_DoubleClick(object sender, EventArgs e)
        {
            LotteryGridControl.Visible = false;

            gridColumn5.Visible = false;
            using (var db = new MovieLottoDBEntities())
            {
                Film film = GetCurrentFilm();
                if (film != null)
                {
                    FilmForm filmForm = new FilmForm(film.Id, film);
                    if (filmForm.ShowDialog() == DialogResult.OK)
                    {
                        CategoryBarEditItemEditValue();
                    }
                }

            }
        }
    }
}