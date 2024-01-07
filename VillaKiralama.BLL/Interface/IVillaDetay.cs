using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaKiralama.DLL;

namespace VillaKiralama.BLL.Interface
{
    public interface IVillaDetay
    {
        string Kaydet(int villaID, string odaSayisi, int banyoSayisi, decimal gunlukFiyat, bool havuzluMu, bool muhafazakarMı, int kisiSayisi, bool cocukHavuzuVarMi, bool denizeYakinmi, bool havuzuKorunaklimi, string aciklama);
        string Guncelle(int villaID, string odaSayisi, int banyoSayisi, decimal gunlukFiyat, bool havuzluMu, bool muhafazakarMı, int kisiSayisi, bool cocukHavuzuVarMi, bool denizeYakinmi, bool havuzuKorunaklimi, string aciklama);
        string Sil(int villaID);
        VillaDetay Bul(string villAdi); 
        IEnumerable<VillaDetay> VillaDetayListele();
    }
}
