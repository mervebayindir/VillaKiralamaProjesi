using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VillaKiralama.BLL.Manager;

namespace VillaKiralama.UI
{
    public partial class FormVillalar : Form
    {
        public FormVillalar()
        {
            InitializeComponent();
        }
        VillaManager villalar = new VillaManager();
        VillaKategoriManager villaKatgoriMngr = new VillaKategoriManager();

        private void comboBoxIl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            string mesaj = villalar.Kaydet(
                (int)comboBoxVillaKategori.SelectedValue,
                textBoxVaillaAdi.Text,
                textBoxAdres.Text,
                (int)comboBoxIl.SelectedValue,
                (int)comboBoxIlce.SelectedValue,
                radioButtonAktif.Checked == true ? true : false
                );
            YemekListesi();
            MessageBox.Show(mesaj);
        }
        private void YemekListesi()
        {
            dataGridViewVillalar.DataSource = villalar.VillaListele();
        }

        public int villarID;
        private void dataGridViewVillalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                villarID = (int)dataGridViewVillalar.Rows[e.RowIndex].Cells["VillalarID"].Value;
                comboBoxVillaKategori.Text = dataGridViewVillalar.Rows[e.RowIndex].Cells["KategoriAdi"].Value.ToString();
                textBoxVaillaAdi.Text = dataGridViewVillalar.Rows[e.RowIndex].Cells["VillaAdi"].Value.ToString();
                textBoxAdres.Text = dataGridViewVillalar.Rows[e.RowIndex].Cells["VillaAdres"].Value.ToString();
                comboBoxIl.Text = dataGridViewVillalar.Rows[e.RowIndex].Cells["sehir"].Value.ToString();
                comboBoxIlce.Text = dataGridViewVillalar.Rows[e.RowIndex].Cells["ilce"].Value.ToString();

                bool aktifMi = (bool)dataGridViewVillalar.Rows[e.RowIndex].Cells["AktifMi"].Value;
                if (aktifMi == true)
                {
                    radioButtonAktif.Checked = true;
                    this.BackColor = SystemColors.Control;
                }
                else
                {
                    radioButtonAktifDegil.Checked = true;
                    this.BackColor = Color.RosyBrown;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu");
            }
        }

    }
}
