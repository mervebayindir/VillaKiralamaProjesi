using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaKiralama.DLL;

namespace VillaKiralama.BLL.Interface
{
    public interface IKiralama
    {
        string Kaydet(int villaID, int musteriID, DateTime baslamaTarihi, DateTime bitisTarihi);
        string Guncelle(int kiralamaID, int villaID, int musteriID, DateTime baslamaTarihi, DateTime bitisTarihi);
        string Sil(int kiralamaID);
        IEnumerable<Kiralamalar> KiralamaListele();
    }
}
