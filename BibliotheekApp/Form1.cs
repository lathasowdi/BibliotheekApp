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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(LibrarycentrumEntities ctx= new LibrarycentrumEntities())
            {
                var query = ctx.Boekens.Select(x => x).ToList();
                lbBoeken.DisplayMember = "Titel";
                lbBoeken.ValueMember = "BoekenId";
                lbBoeken.DataSource = query;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedBook = (Boeken)lbBoeken.SelectedItem;
            BookDetails Details = new BookDetails();
            Details.MyBook = selectedBook;
            if(Details.ShowDialog()==DialogResult.OK)
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBook book = new AddBook();
            if (book.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnaddauthor_Click(object sender, EventArgs e)
        {
            NewAuthor newauthor = new NewAuthor();
            if (newauthor.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnaddpub_Click(object sender, EventArgs e)
        {
            NewPublisher newPublisher = new NewPublisher();
            if (newPublisher.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void btnaddgenre_Click(object sender, EventArgs e)
        {
            NewGenre newGenre = new NewGenre();
            if (newGenre.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
