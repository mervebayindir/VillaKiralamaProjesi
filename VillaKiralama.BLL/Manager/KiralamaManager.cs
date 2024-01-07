using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaKiralama.BLL.Interface;
using VillaKiralama.DLL;
using VillaKiralama.DLL.RepositoryFolder;

namespace VillaKiralama.BLL.Manager
{
    public class KiralamaManager : IKiralama
    {
        VillaKiralamaDBEntities db;
        Repository<Kiralamalar> repository;
        public KiralamaManager()
        {
            db = new VillaKiralamaDBEntities();
            repository = new Repository<Kiralamalar>(db);
        }
        public string Guncelle(int kiralamaID, int villaID, int musteriID, DateTime baslamaTarihi, DateTime bitisTarihi)
        {
            try
            {
                var guncellenecekData = repository.BulQuery(x => x.KiralamalarID == kiralamaID).FirstOrDefault();
                if (guncellenecekData == null)
                {
                    return "Kiralama bulunamadı, lütfen kontrol ediniz";
                }
                guncellenecekData.VillaID = villaID;
                guncellenecekData.MusteriD = musteriID;
                guncellenecekData.BaslamaTarihi = baslamaTarihi;
                guncellenecekData.BitisTarihi = bitisTarihi;
                int sonuc = repository.Guncelle(guncellenecekData);
                if (sonuc > 0)
                {
                    return "Güncelleme başarılı";
                }
                return "Güncelleme başarısız";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu \nHATA:" + ex.Message;
            }
        }

        public string Kaydet(int villaID, int musteriID, DateTime baslamaTarihi, DateTime bitisTarihi)
        {
            db = new VillaKiralamaDBEntities();
            repository = new Repository<Kiralamalar>(db);
            try
            {
                var varMiVilla = repository.BulQuery(x => x.VillaID == villaID).FirstOrDefault();
                if (varMiVilla != null)
                {
                    return "Aynı tarih de kayıt vardır.";
                }
                Kiralamalar kiralamalar = new Kiralamalar();
                kiralamalar.VillaID = villaID;
                kiralamalar.MusteriD = musteriID;
                kiralamalar.BaslamaTarihi = baslamaTarihi;
                kiralamalar.BitisTarihi = bitisTarihi;
                int sonuc = repository.Kaydet(kiralamalar);
                if (sonuc > 0)
                {
                    return "Kayıt başarılı";
                }
                return "Kayıt başarısız";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu \nHATA:" + ex.Message;
            }
        }

        public IEnumerable<Kiralamalar> KiralamaListele()
        {
            return repository.Listele();
        }

        public string Sil(int kiralamaID)
        {
            try
            {
                var data = repository.BulQuery(x => x.KiralamalarID == kiralamaID).FirstOrDefault();
                if (data == null)
                {
                    return "Kiralama bulunamadı, lütfen kontrol ediniz";
                }
                int sonuc = repository.Sil(data);
                if (sonuc > 0)
                {
                    return "Kiralama silme işlemi başarılı";
                }
                return "Kiralama silme işlemi başarılı";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu \nHATA:" + ex.Message;
            }

        }
    }
}
