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
    public partial class SortScore : Form
    {
        public SortScore()
        {
            InitializeComponent();
        }

        private void SortScore_Load(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                listBox1.DataSource = ctx.Boekens.OrderBy(s => s.Score).ToList();
                listBox1.DisplayMember = "Titel";
                listBox1.ValueMember = "Score";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                var selectedbook = (Boeken)listBox1.SelectedItem;
                textBox1.Text = selectedbook.Score.ToString();
            }
        }
    }
}
