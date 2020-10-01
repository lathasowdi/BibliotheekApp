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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        public Boeken niewBook = new Boeken();
        private void AddBook_Load(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                var UitgeverijQuery = ctx.Uitgeverijens.Select(g => g).ToList();
                cbuitgeverij.DisplayMember = "Naam";
                cbuitgeverij.ValueMember = "UitgeverijenId";
                cbuitgeverij.DataSource = UitgeverijQuery;
                var AuteurQuery = ctx.Auteurs.Select(a => a).ToList();
               lbauteurs.DisplayMember = "Voornaam";
               lbauteurs.ValueMember = "AuteursId";
                lbauteurs.DataSource = AuteurQuery;
                var GenresQuery = ctx.Genres.Select(g => g).ToList();
                lbgenres.DisplayMember = "Genre1";
                lbgenres.ValueMember = "GenreId";
                lbgenres.DataSource = GenresQuery;

            }

        }

        private void btnadd_Click(object sender, EventArgs e)
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
                int aantalPaginas = 0;
                if (numericUpDown1.Value != 0)
                {
                    aantalPaginas = (int)numericUpDown1.Value;
                }
                else
                {
                    MessageBox.Show("Geef een AantalPaginas a.u.b");
                }

                int score = 0;
                if (numericUpDown2.Value != 0)
                {
                    score = (int)numericUpDown1.Value;
                }
                else
                {
                    MessageBox.Show("Geef een Score a.u.b");
                }
                string publicatie = "";
                if (dateTimePicker1.Value.ToString() != "")
                {
                    publicatie = dateTimePicker1.Value.ToString();
                }
                else
                {
                    MessageBox.Show("Geef een Publicatie a.u.b");
                }
              
                niewBook.Titel = titel;
                niewBook.AantalPaginas = aantalPaginas;
                niewBook.Score = score;
                niewBook.Publicatie = publicatie;
                niewBook.UitgeverId = (int)cbuitgeverij.SelectedValue;
                ctx.Boekens.Add(niewBook);
                ctx.SaveChanges();
                MessageBox.Show("Boek Toevoegd");
               
                foreach (var item in lbauteurs.SelectedItems)
                {
                    ctx.BoekenAuteurs.Add(new BoekenAuteur() { BoekId = niewBook.BoekenId,AuteurId = (item as Auteur).AuteursId });
                    ctx.SaveChanges();
                }
                ctx.SaveChanges();
                MessageBox.Show("Auteurs Toevoegd");
                foreach (var item in lbgenres.SelectedItems)
                {
                    ctx.BoekenGenres.Add(new BoekenGenre() { BoekId = niewBook.BoekenId, GenreId = (item as Genre).GenreId });
                    ctx.SaveChanges();
                }
                ctx.SaveChanges();
                MessageBox.Show("Genre Toevoegd");



            }
        }
    }
}
