using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace film
{
    public partial class LotteryForm : DevExpress.XtraEditors.XtraForm
    {
        public LotteryForm()
        {
            InitializeComponent();
        }
        private string genreType;
        public LotteryForm(string genre) : this()
        {
            this.genreType = genre;
        }

        private void GenerateSimpleButton_Click(object sender, EventArgs e)
        {
            using (var db = new MovieLottoDBEntities())
            {
                List<Film> films = new List<Film>();
                List<Film> filmrating = new List<Film>();
                Lotary newLottery;
                foreach (var item in db.Films)
                {
                    films.Add(item);
                }

                Genre genre = db.Genres.FirstOrDefault(x => x.Genre1 == genreType);

                if (genre != null)
                {
                    films = films.Where(x => x.Genre.Genre1 == genre.Genre1).ToList();
                     newLottery = new Lotary
                    {
                        DateLotary = DateTime.Now,

                        GanreId = genre.Id

                    };
                }
                else
                {

                     newLottery = new Lotary
                    {
                        DateLotary = DateTime.Now,

                        GanreId = null

                    };


                }
                db.Lotaries.Add(newLottery);

                db.SaveChanges();

                foreach (var film in films)
                {
                    if (film.DateWatch != null)
                    {
                        continue;
                    }
                    for (int i = 0; i < film.Rating; i++)
                    {
                        filmrating.Add(film);

                    }
                    LotaryRole lotteryRow = new LotaryRole
                    {
                        FilmId = film.Id,
                        IsWinner = false,
                        LotaryId = newLottery.Id
                    };
                    db.LotaryRoles.Add(lotteryRow);
                    db.SaveChanges();
                }

                Random random = new Random();
                var randomized = filmrating.OrderBy(item => random.Next()).ToList();

                if (filmrating.Count == 0)
                {
                    MessageBox.Show("You have to vote or add film!");
                    return;
                }
                int randomNumber = random.Next(0, filmrating.Count - 1);


                Film generateFilm = randomized[randomNumber];
                MessageBox.Show($"The film is: {generateFilm.FilmName}", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LotaryRole ltRole = db.LotaryRoles.Where(x => x.LotaryId == newLottery.Id).First(x => x.FilmId == generateFilm.Id);
                ltRole.IsWinner = true;

                generateFilm.DateWatch = DateTime.Now;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void LotteryForm_Load(object sender, EventArgs e)
        {
            using (var db = new MovieLottoDBEntities())
            {
                Genre genre = db.Genres.FirstOrDefault(x => x.Genre1 == genreType);

                if (genre == null)
                {

                    db.Genres.Load();
                    db.Users.Load();
                    db.Films.Load();
                    LotteryGridControl.DataSource = db.Films.Where(x => x.DateWatch == null).Where(x => x.Rating != 0).ToList();
                }
                else
                {
                    db.Genres.Load();
                    db.Users.Load();
                    db.Films.Load();
                    LotteryGridControl.DataSource = db.Films.Where(x => x.DateWatch == null).Where(x => x.Rating != 0).Where(x => x.GenreId == genre.Id).ToList();
                }
            }
        }
    }

}