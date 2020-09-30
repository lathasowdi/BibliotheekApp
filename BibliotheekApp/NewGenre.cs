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
    public partial class NewGenre : Form
    {
        public NewGenre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                string genre = "";
                if (textBox1.Text.Trim() != "")
                {
                    genre = textBox1.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Geef een GENRE a.u.b");
                }
                

                ctx.Genres.Add(new Genre() { Genre1 = genre});
                ctx.SaveChanges();
                MessageBox.Show("Genre Toevoegd");
            }
        }
    }
}
