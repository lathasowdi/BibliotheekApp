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

        private void AddBook_Load(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                var UitgeverijQuery = ctx.Uitgeverijens.Select(g => g).ToList();
                cbuitgeverij.DisplayMember = "Naam";
                cbuitgeverij.ValueMember = "UitgeverijenId";
                cbuitgeverij.DataSource = UitgeverijQuery;
                var AuteurQuery = ctx.Auteurs.Select(a => a).ToList();
                cbauteurs.DisplayMember = "Voornaam";
                cbauteurs.ValueMember = "AuteursId";
                cbauteurs.DataSource = AuteurQuery;
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

                int uitgeverId = (int)cbuitgeverij.SelectedValue;

                ctx.Boekens.Add(new Boeken() { Titel = titel, AantalPaginas = aantalPaginas, Score = score, Publicatie = publicatie, UitgeverId = uitgeverId });
                ctx.SaveChanges();
                MessageBox.Show("Boek Toevoegd");
            }
        }
    }
}
