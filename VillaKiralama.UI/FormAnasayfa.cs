using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillaKiralama.UI
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }
        FormVillalar frmVillalar;
        private void villalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVillalar == null)
            {
                frmVillalar = new FormVillalar();
                frmVillalar.MdiParent = this;
                frmVillalar.Show();
            }
        }
        FormVillaDetay frmVillaDetaylar;
        private void villaDetaylarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVillaDetaylar == null)
            {
                frmVillaDetaylar = new FormVillaDetay();
                frmVillaDetaylar.MdiParent = this;
                frmVillaDetaylar.Show();
            }
        }
        FormVillaKategorileri frmVillaKategoriler;
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmVillaKategoriler == null)
            {
                frmVillaKategoriler = new FormVillaKategorileri();
                frmVillaKategoriler.MdiParent = this;
                frmVillaKategoriler.Show();
            }
        }

        FormMusteriler frmMusteriler;
        private void musterilerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (frmMusteriler == null)
            {
                frmMusteriler = new FormMusteriler();
                frmMusteriler.MdiParent = this;
                frmMusteriler.Show();
            }
        }
        FormKiralamalar frmKiralamalar;
        private void kiralamlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmKiralamalar == null)
            {
                frmKiralamalar = new FormKiralamalar();
                frmKiralamalar.MdiParent = this;
                frmKiralamalar.Show();
            }
        }
    }
}
