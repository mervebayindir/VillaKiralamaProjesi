using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaKiralama.DLL;

namespace VillaKiralama.BLL.Interface
{
    public interface IMusteri
    {
        string Kaydet(string musteriAdi, string musteriSoyadi, string adres, string telefon, string TC, string email, string cinsiyet, DateTime dogumTarihi, int ilceID);
        string Guncelle(int musteriID, string musteriAdi, string musteriSoyadi, string adres, string telefon, string TC, string email, string cinsiyet, DateTime dogumTarihi, int ilceID);
        string Sil(int musteriID);
        Musteriler Bul(string musteriAdi, string musteriSoyadi);
        IEnumerable<Musteriler> MusteriListele();
    }
}
