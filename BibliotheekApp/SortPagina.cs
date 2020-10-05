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
    public partial class SortPagina : Form
    {
        public SortPagina()
        {
            InitializeComponent();
        }

        private void SortPagina_Load(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                listBox1.DataSource = ctx.Boekens.OrderBy(s => s.AantalPaginas).ToList();
                listBox1.DisplayMember = "Titel";
                listBox1.ValueMember = "Aantalpaginas";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                var selectedbook = (Boeken)listBox1.SelectedItem;
                textBox1.Text = selectedbook.AantalPaginas.ToString();
            }
        }
    }
}
