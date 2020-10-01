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
    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }
        public Boeken MyBook;
        private void BookDetails_Load(object sender, EventArgs e)
        {
            using(LibrarycentrumEntities ctx=new LibrarycentrumEntities())
            {
                textBox1.Text = MyBook.Titel;
                textBox2.Text = MyBook.AantalPaginas.ToString();
                textBox3.Text = MyBook.Score.ToString();
                textBox4.Text = MyBook.Publicatie;
                var joinQuery1 = ctx.Boekens
                              .Join(ctx.Uitgeverijens,
                              b => b.UitgeverId,
                             p => p.UitgeverijenId,
                             (b, p) => new { b, p });
                textBox5.Text = joinQuery1.Where(x => x.b.BoekenId == MyBook.BoekenId).FirstOrDefault().p.Naam;
                var joinQuery2 = ctx.Boekens
                              .Join(ctx.BoekenAuteurs,
                              b => b.BoekenId,
                             a => a.BoekId,
                             (b,a) => new { b,a })
                               .Join(ctx.Auteurs,
                             ba => ba.a.AuteurId,
                             a2 => a2.AuteursId,
                              (ba, a2) => new { ba, a2,Voornaam=a2.Voornaam+""+a2.Achternaam }); 

                lbauteur.DisplayMember = "Voornaam";
               lbauteur.DataSource = joinQuery2.Where(x => x.ba.b.BoekenId == MyBook.BoekenId).ToList();
                var joinQuery3 = ctx.Boekens
                              .Join(ctx.BoekenGenres,
                              b => b.BoekenId,
                             bg => bg.BoekId,
                             (b, bg) => new { b, bg })
                               .Join(ctx.Genres,
                             bbg => bbg.bg.GenreId,
                             g => g.GenreId,
                              (bbg, g) => new { bbg, g, Genre1=g.Genre1 });
               lbgenre.DisplayMember = "Genre1";
                lbgenre.DataSource = joinQuery3.Where(x => x.bbg.b.BoekenId == MyBook.BoekenId).ToList();

            }
        }
    }
}
