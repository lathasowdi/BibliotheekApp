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
    public partial class BookEdit : Form
    {
        public BookEdit()
        {
            InitializeComponent();
        }
        public Boeken MyBook;
        private void BookEdit_Load(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                textBox1.Text = MyBook.Titel;
                numericUpDown1.Value = (int)MyBook.AantalPaginas;
                numericUpDown2.Value = (int)MyBook.Score;
                textBox2.Text = MyBook.Publicatie.ToString();
                var joinQuery1 = ctx.Boekens
                              .Join(ctx.Uitgeverijens,
                              b => b.UitgeverId,
                             p => p.UitgeverijenId,
                             (b, p) => new { b, p });
                textBox3.Text = joinQuery1.Where(x => x.b.BoekenId == MyBook.BoekenId).FirstOrDefault().p.Naam;
                var joinQuery2 = ctx.Boekens
                              .Join(ctx.BoekenAuteurs,
                              b => b.BoekenId,
                             a => a.BoekId,
                             (b, a) => new { b, a })
                               .Join(ctx.Auteurs,
                             ba => ba.a.AuteurId,
                             a2 => a2.AuteursId,
                              (ba, a2) => new { ba, a2, Voornaam = a2.Voornaam + "" + a2.Achternaam });

                listBox1.DisplayMember = "Voornaam";
                listBox1.DataSource = joinQuery2.Where(x => x.ba.b.BoekenId == MyBook.BoekenId).ToList();
                var joinQuery3 = ctx.Boekens
                              .Join(ctx.BoekenGenres,
                              b => b.BoekenId,
                             bg => bg.BoekId,
                             (b, bg) => new { b, bg })
                               .Join(ctx.Genres,
                             bbg => bbg.bg.GenreId,
                             g => g.GenreId,
                              (bbg, g) => new { bbg, g, Genre1 = g.Genre1 });
                listBox2.DisplayMember = "Genre1";
                listBox2.DataSource = joinQuery3.Where(x => x.bbg.b.BoekenId == MyBook.BoekenId).ToList();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                    string titel = "";
                    if (textBox1.Text.Trim() != "")
                    {
                        titel = textBox1.Text.Trim();
                    }
                    else
                    {
                        MessageBox.Show("Geef een Titel a.u.b");
                    }
                   int paginas=0;
                    if ((int)numericUpDown1.Value !=0)
                    {
                       paginas =(int) numericUpDown1.Value;
                    }
                    else
                    {
                        MessageBox.Show("Geef antal paginas a.u.b");
                    }

                    int score;
                    score = (int)numericUpDown2.Value;
                string pub = "";
                if (textBox2.Text.Trim() != "")
                {
                    pub = textBox2.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Geef Publicatie a.u.b");
                }
                
                ctx.Boekens.Where(p => p.BoekenId == MyBook.BoekenId).FirstOrDefault().Titel =titel;
                    ctx.Boekens.Where(p => p.BoekenId == MyBook.BoekenId).FirstOrDefault().AantalPaginas = paginas;
                    ctx.Boekens.Where(p => p.BoekenId ==MyBook.BoekenId).FirstOrDefault().Score = score;
                ctx.Boekens.Where(p => p.BoekenId == MyBook.BoekenId).FirstOrDefault().Publicatie =pub;
               ctx.Uitgeverijens.Where(p => p.UitgeverijenId== MyBook.UitgeverId).FirstOrDefault().Naam = pub;
                ctx.SaveChanges();
                //    foreach (var item in listBox1.SelectedItems)
                //    {
                //        ctx.BoekenAuteurs.Where(p => p.BoekId == MyBook.BoekenId).FirstOrDefault().AuteurId= (item as Auteur ).AuteursId;
                //        ctx.SaveChanges();
                //    }
                //foreach (var item in listBox2.SelectedItems)
                //{
                //    ctx.BoekenGenres.Where(p => p.BoekId == MyBook.BoekenId).FirstOrDefault().GenreId = (item as Genre).GenreId;
                //    ctx.SaveChanges();
                //}
                ctx.SaveChanges();
                    
                    MessageBox.Show("Boek Bewerk is gedaan");
                    ctx.SaveChanges();

            }
        }
    }
}
