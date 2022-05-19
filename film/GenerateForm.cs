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
    public partial class GenerateForm : DevExpress.XtraEditors.XtraForm
    {
        public GenerateForm()
        {
            InitializeComponent();
        }

        private void GenerateForm_Load(object sender, EventArgs e)
        {
            using (var db = new MovieLottoDBEntities())
            {
                List<Genre> genres = new List<Genre>();

                foreach (var item in db.Genres)
                {
                    genres.Add(item);
                }

                GenerateGenreComboBoxEdit.Properties.Items.Add("All");

                foreach (var item in genres)
                {
                    GenerateGenreComboBoxEdit.Properties.Items.Add(item.GenreType);
                }
            }
        }

        private void SubmitSimpleButton_Click(object sender, EventArgs e)
        {
            string genre = GenerateGenreComboBoxEdit.Text;
            if (GenerateGenreComboBoxEdit.Text == "Choose genre")
            {
                MessageBox.Show("You have to choose genre!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            using (var db = new MovieLottoDBEntities())
            {
                if (db.Films.Where(x => x.DateWatch == null)
                    .FirstOrDefault(x => x.Genre.Genre1 == genre) == null && genre!="All"
                   )
                {
                    MessageBox.Show("Missing film with this genre!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            LotteryForm lottery = new LotteryForm(genre);
            if (lottery.ShowDialog() == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }

       
    }
}