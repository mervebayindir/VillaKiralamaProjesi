using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaKiralama.DLL;

namespace VillaKiralama.BLL.Interface
{
    public interface IVillaKategori
    {
        string Kaydet(string kategoriAdi, string aciklama);
        string Guncelle(int kategoriID, string kategoriAdi, string aciklama);
        string Sil(int kategoriID);
        VillaKategorileri Bul(string katgoriAdi);
        IEnumerable<VillaKategorileri> VillaKategorileriListele();
    }
}
