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
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
        }

        private void btnauteur_Click(object sender, EventArgs e)
        {
            FilterAuteur filterAuteur = new FilterAuteur();
            if(filterAuteur.ShowDialog()==DialogResult.OK)
            {

            }
        }

        private void btnpub_Click(object sender, EventArgs e)
        {
            FilterPub filterpub = new FilterPub();
            if (filterpub.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FilterGenre filtergenre = new FilterGenre();
            if (filtergenre.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
