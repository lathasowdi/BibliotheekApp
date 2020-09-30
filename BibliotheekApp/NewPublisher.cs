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
    public partial class NewPublisher : Form
    {
        public NewPublisher()
        {
            InitializeComponent();
        }

        private void NewPublisher_Load(object sender, EventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                string naam = "";
                if (textBox1.Text.Trim() != "")
                {
                    naam = textBox1.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Geef een Voornaam a.u.b");
                }

                ctx.Uitgeverijens.Add(new Uitgeverijen() { Naam = naam });
                ctx.SaveChanges();
                MessageBox.Show("Uitgeverij Toevoegd");
            }
        }
    }
}
