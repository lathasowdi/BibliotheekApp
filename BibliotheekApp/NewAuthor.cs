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
    public partial class NewAuthor : Form
    {
        public NewAuthor()
        {
            InitializeComponent();
        }

        private void NewAuthor_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                string voornaam = "";
                if (textBox1.Text.Trim() != "")
                {
                    voornaam = textBox1.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Geef een Voornaam a.u.b");
                }
                string achternaam = "";
                if (textBox2.Text.Trim() != "")
                {
                    achternaam = textBox2.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Geef een Achternaam a.u.b");
                }

                ctx.Auteurs.Add(new Auteur() { Voornaam = voornaam, Achternaam = achternaam});
                ctx.SaveChanges();
                MessageBox.Show("Auteur Toevoegd");
            }
        }
    }
}
