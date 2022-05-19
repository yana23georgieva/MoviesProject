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
    public partial class AddGenreForm : DevExpress.XtraEditors.XtraForm
    {
        public AddGenreForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If you click add, if the current ganre does not exist add it to db.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSimpleButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(GenreTextEdit.Text))
            {
                using (var db = new MovieLottoDBEntities())
                {
                    Genre currGenre = db.Genres.FirstOrDefault(x => x.Genre1 == GenreTextEdit.Text);
                    if (currGenre != null)
                    {
                        MessageBox.Show("Genre allready exist!");
                        return;
                    }
                    
                    Genre genre = new Genre
                    {
                        Genre1=GenreTextEdit.Text
                    };
                    db.Genres.Add(genre);
                    db.SaveChanges();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Genre can not be empty!");
            }
        }

        /// <summary>
        /// Close the current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}