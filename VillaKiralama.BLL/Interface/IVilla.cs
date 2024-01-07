using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaKiralama.DLL;

namespace VillaKiralama.BLL.Interface
{
    public interface IVilla
    {
        string Kaydet(int kategoriID, string villaAdi, string villaAdres, int villaImageID, int ilceID, bool aktifMi);
        string Guncelle(int villaID, int kategoriID, string villaAdi, string villaAdres, int villaImageID, int ilceID, bool aktifMi);
        string Sil(int villaID);
        Villalar Bul(string villAdi);
        IEnumerable<Villalar> VillaListele();
    }
}
