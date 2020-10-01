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
    public partial class FilterPub : Form
    {
        public FilterPub()
        {
            InitializeComponent();
        }

        private void FilterPub_Load(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                var UitgeverijQuery = ctx.Uitgeverijens.Select(g => g).ToList();
                listBox1.DisplayMember = "Naam";
                listBox1.ValueMember = "UitgeverijenId";
                listBox1.DataSource = UitgeverijQuery;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LibrarycentrumEntities ctx = new LibrarycentrumEntities())
            {
                var joinQuery11 = ctx.Boekens
                             .Join(ctx.Uitgeverijens,
                             b => b.UitgeverId,
                            p => p.UitgeverijenId,
                            (b, p) => new { b, p,titel=b.Titel });
                var selectedpub = (Uitgeverijen)listBox1.SelectedItem;
                lbboeken.DataSource = joinQuery11.Where(x => x.p.Naam== selectedpub.Naam).ToList();
                lbboeken.DisplayMember = "titel";
              
            }
        }
    }
}
