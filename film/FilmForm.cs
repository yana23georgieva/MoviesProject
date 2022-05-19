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
    public partial class FilmForm : DevExpress.XtraEditors.XtraForm
    {
        private Film film = null;
        private int user;
        private int filmId;

        public FilmForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// In use to know which user what film has added.
        /// </summary>
        /// <param name="userId">User id</param>
        public FilmForm(int userId)
            : this()
        {
            this.user = userId;
        }

        /// <summary>
        /// In need of edit film information and show the data.
        /// </summary>
        /// <param name="filmId">only film id</param>
        /// <param name="currentFilm">the film with all fields</param>
        public FilmForm(int filmId, Film currentFilm) : this()
        {
            this.filmId = filmId;
            this.film = currentFilm;
        }

        /// <summary>
        /// Fill the items in comboBox and if edit was choosen fill the gaps.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilmForm_Load(object sender, EventArgs e)
        {
            if (film!=null)
            {
                this.Text = "Edit film";
            }
            using (var db = new MovieLottoDBEntities())
            {
                foreach (var item in db.Genres)
                {
                    GenreComboBoxEdit.Properties.Items.Add(item.Genre1);
                }

                if (film != null)
                {
                    nameTextEdit.Text = film.FilmName;
                    Genre genre = db.Genres.First(x => x.Id == film.GenreId);
                    GenreComboBoxEdit.Text = genre.Genre1;
                    yearTextEdit.Text = film.Year.ToString();
                    sizeTextEdit.Text = film.Size.ToString();
                    richTextBox1.Text = film.Description;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// If you click submit, make all validations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (String.IsNullOrEmpty(nameTextEdit.Text))
            {
                nameTextEdit.Text = "";
                MessageBox.Show("Film Name can not be empty!","Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                flag = true;
                DialogResult = DialogResult.None;
            }

            if (String.IsNullOrEmpty(GenreComboBoxEdit.Text))
            {
                GenreComboBoxEdit.Text = "";
                MessageBox.Show("Genre can not be empty!", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                flag = true;
                DialogResult = DialogResult.None;
            }
            if (String.IsNullOrEmpty(yearTextEdit.Text))
            {
                yearTextEdit.Text = "";
                MessageBox.Show("Year can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = true;
                DialogResult = DialogResult.None;
            }


            else if (int.Parse(yearTextEdit.Text) < 0)
            {
                yearTextEdit.Text = "";
                MessageBox.Show("Year can not be negative!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = true;
                DialogResult = DialogResult.None;
            }

            if (String.IsNullOrEmpty(sizeTextEdit.Text))
            {
                sizeTextEdit.Text = "";
                MessageBox.Show("Size can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = true;
                DialogResult = DialogResult.None;
            }

            else if (decimal.Parse(sizeTextEdit.Text) < 0)
            {
                sizeTextEdit.Text = "";
                MessageBox.Show("Size can not be negative!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = true;
                DialogResult = DialogResult.None;
            }

            if (flag == false)
            {
                using (var db = new MovieLottoDBEntities())
                {
                    Film currfilm = db.Films.FirstOrDefault(x => x.FilmName == nameTextEdit.Text);
                    if (currfilm != null && film == null)
                    {
                        MessageBox.Show("The film allready exist!", "Error", MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning);
                        nameTextEdit.Text = "";
                        DialogResult = DialogResult.None;
                        return;
                    }

                    Genre genre = db.Genres.First(x => x.Genre1 == GenreComboBoxEdit.Text);

                    //Update film information.
                    if (film != null)
                    {
                        Film editFilm = db.Films.First(x => x.Id == this.filmId);
                        editFilm.FilmName = nameTextEdit.Text;
                        editFilm.GenreId = genre.Id;
                        editFilm.Year = int.Parse(yearTextEdit.Text);
                        editFilm.Size = decimal.Parse(sizeTextEdit.Text);
                        editFilm.Description = richTextBox1.Text;

                        db.SaveChanges();
                        return;
                    }

                    //Create new film.
                    Film newFilm = new Film
                    {
                        FilmName = nameTextEdit.Text,
                        GenreId = genre.Id,
                        Year = int.Parse(yearTextEdit.Text),
                        Size = decimal.Parse(sizeTextEdit.Text),
                        Description = richTextBox1.Text,
                        AddDate = DateTime.Now,
                        DateWatch = null,
                        UserId = user,
                        Rating = 0
                    };
                    db.Films.Add(newFilm);
                    db.SaveChanges();
                    this.Close();
                }
            }

        }

        /// <summary>
        /// Load Genre form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGenreSimpleButton_Click(object sender, EventArgs e)
        {
            AddGenreForm addGenreForm = new AddGenreForm();
            if (addGenreForm.ShowDialog() == DialogResult.OK)
            {
                GenreComboBoxEditClear();
                this.FilmForm_Load(sender,e);
            }
        }

        /// <summary>
        /// Clear the data in comboBox.
        /// </summary>
        private void GenreComboBoxEditClear()
        {
            while (GenreComboBoxEdit.Properties.Items.Count != 0)
            {
                GenreComboBoxEdit.Properties.Items.RemoveAt(0);
            }
        }

    }
}