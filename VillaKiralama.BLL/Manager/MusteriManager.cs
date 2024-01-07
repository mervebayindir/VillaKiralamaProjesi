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
    public class MusteriManager : IMusteri
    {
        VillaKiralamaDBEntities db;
        Repository<Musteriler> repository;
        public MusteriManager()
        {
            db = new VillaKiralamaDBEntities();
            repository = new Repository<Musteriler>(db);
        }
        public Musteriler Bul(string musteriAdi, string musteriSoyadi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int musteriID, string musteriAdi, string musteriSoyadi, string adres, string telefon, string TC, string email, string cinsiyet, DateTime dogumTarihi, int ilceID)
        {
            try
            {
                var guncellenecekData = repository.BulQuery(x => x.MusterilerID == musteriID).FirstOrDefault();
                if (guncellenecekData == null)
                {
                    return "Musteri bulunamadı, lütfen kontrol ediniz";
                }
                guncellenecekData.MusteriAdi = musteriAdi;
                guncellenecekData.MusteriSoyadi = musteriSoyadi;
                guncellenecekData.MusteriAdres = adres;
                guncellenecekData.MusteriTelefon = telefon;
                guncellenecekData.MusteriTC = TC;
                guncellenecekData.Email = email;
                guncellenecekData.MusteriCinsiyet = cinsiyet;
                guncellenecekData.MusteriDogumTarihi = dogumTarihi;
                guncellenecekData.IlceID = ilceID;
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

        public string Kaydet(string musteriAdi, string musteriSoyadi, string adres, string telefon, string TC, string email, string cinsiyet, DateTime dogumTarihi, int ilceID)
        {
            db = new VillaKiralamaDBEntities();
            repository = new Repository<Musteriler>(db);
            try
            {
                var varMiMusteri = repository.BulQuery(x => x.MusteriTC == TC).FirstOrDefault();
                if (varMiMusteri != null)
                {
                    return "Aynı müşteri kayıtlı";
                }
                Musteriler musteriler = new Musteriler();
                musteriler.MusteriAdi = musteriAdi;
                musteriler.MusteriSoyadi = musteriSoyadi;
                musteriler.MusteriAdres = adres;
                musteriler.MusteriTelefon = telefon;
                musteriler.MusteriTC = TC;
                musteriler.Email = email;
                musteriler.MusteriCinsiyet = cinsiyet;
                musteriler.MusteriDogumTarihi = dogumTarihi;
                musteriler.IlceID = ilceID;
                int sonuc = repository.Kaydet(musteriler);
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

        public IEnumerable<Musteriler> MusteriListele()
        {
            return repository.Listele();
        }

        public string Sil(int musteriID)
        {
            try
            {
                var data = repository.BulQuery(x => x.MusterilerID == musteriID).FirstOrDefault();
                if (data == null)
                {
                    return "Musteri bulunamadı, lütfen kontrol ediniz";
                }
                int sonuc = repository.Sil(data);
                if (sonuc > 0)
                {
                    return "Musteri silme işlemi başarılı";
                }
                return "Musteri silme işlemi başarısız";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu \nHATA:" + ex.Message;
            }
        }
    }
}
