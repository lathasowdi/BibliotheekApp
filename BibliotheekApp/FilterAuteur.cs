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
    public partial class FilterAuteur : Form
    {
        public FilterAuteur()
        {
            InitializeComponent();
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                var joinQuery2 = ctx.Boekens
                             .Join(ctx.BoekenAuteurs,
                             b => b.BoekenId,
                            a => a.BoekId,
                            (b, a) => new { b, a })
                              .Join(ctx.Auteurs,
                            ba => ba.a.AuteurId,
                            a2 => a2.AuteursId,
                             (ba, a2) => new { ba, a2, Titel = ba.b.Titel });

                listBox1.DisplayMember = "Titel";
               listBox1.DataSource = joinQuery2.Where(x => x.a2.Voornaam == textBox1.Text).ToList();
                
            }
        }

        private void FilterAuteur_Load(object sender, EventArgs e)
        {

        }
    }
}
