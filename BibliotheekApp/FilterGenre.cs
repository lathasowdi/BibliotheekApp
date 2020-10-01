using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotheekApp
{
    public partial class FilterGenre : Form
    {
        public FilterGenre()
        {
            InitializeComponent();
        }

        private void FilterGenre_Load(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                var GenresQuery = ctx.Genres.Select(g => g).ToList();
                listBox1.DisplayMember = "Genre1";
                listBox1.ValueMember = "GenreId";
                listBox1.DataSource = GenresQuery;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                var joinQuery3 = ctx.Boekens
                             .Join(ctx.BoekenGenres,
                             b => b.BoekenId,
                            bg => bg.BoekId,
                            (b, bg) => new { b, bg })
                              .Join(ctx.Genres,
                            bbg => bbg.bg.GenreId,
                            g => g.GenreId,
                             (bbg, g) => new { bbg, g, titel = bbg.b.Titel});
                listBox2.DisplayMember = "titel";
                var selectedgenre = (Genre)listBox1.SelectedItem;
                listBox2.DataSource = joinQuery3.Where(x => x.g.Genre1 == selectedgenre.Genre1).ToList();
                
            }
        }
    }
}
