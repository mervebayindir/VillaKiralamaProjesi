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
    public class VillaKategoriManager : IVillaKategori
    {
        VillaKiralamaDBEntities db;
        Repository<VillaKategorileri> repository;
        public VillaKategoriManager()
        {
            db = new VillaKiralamaDBEntities();
            repository = new Repository<VillaKategorileri>(db);
        }
        public VillaKategorileri Bul(string katgoriAdi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int kategoriID, string kategoriAdi, string aciklama)
        {
            try
            {
                var guncellenecekVeri = repository.BulQuery(x => x.KategorilerID == kategoriID).FirstOrDefault();
                if (guncellenecekVeri == null)
                {
                    return "Kategori bulunamadı, lütfen kontrol ediniz";
                }
                guncellenecekVeri.KategoriAdi = kategoriAdi;
                guncellenecekVeri.Aciklama = aciklama;
                int sonuc = repository.Guncelle(guncellenecekVeri);
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

        public string Kaydet(string kategoriAdi, string aciklama)
        {
            db = new VillaKiralamaDBEntities();
            repository = new Repository<VillaKategorileri>(db);
            try
            {
                var varmiVillaKategori = repository.BulQuery(x => x.KategoriAdi == kategoriAdi).FirstOrDefault();
                if (varmiVillaKategori == null)
                {
                    return "Aynı kategori kayıtlı";
                }
                VillaKategorileri villaKategorileri = new VillaKategorileri();
                villaKategorileri.KategoriAdi = kategoriAdi;
                villaKategorileri.Aciklama = aciklama;
                int sonuc = repository.Kaydet(villaKategorileri);
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

        public string Sil(int kategoriID)
        {
            try
            {
                var data = repository.BulQuery(x => x.KategorilerID == kategoriID).FirstOrDefault();
                if (data == null)
                {
                    return "Kategori bulunamadı, lütfen kontrol ediniz";
                }
                int sonuc = repository.Sil(data);
                if (sonuc > 0)
                {
                    return "Kategori silme işlemi başarılı";
                }
                return "Kategori silme işlemi başarısız";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu \nHATA:" + ex.Message;
            }
        }

        public IEnumerable<VillaKategorileri> VillaKategorileriListele()
        {
            return repository.Listele();
        }
    }
}
