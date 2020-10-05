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
    public partial class SortPublicatie : Form
    {
        public SortPublicatie()
        {
            InitializeComponent();
        }

        private void SortPublicatie_Load(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                listBox1.DataSource = ctx.Boekens.OrderBy(s => s.Publicatie).ToList();
                listBox1.DisplayMember = "Titel";
                listBox1.ValueMember = "Publicatie";
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                var selectedbook = (Boeken)listBox1.SelectedItem;
                textBox1.Text = selectedbook.Publicatie.ToString();
            }
        }
    }
}
