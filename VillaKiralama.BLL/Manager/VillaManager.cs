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
    public class VillaManager : IVilla
    {
        VillaKiralamaDBEntities db;
        Repository<Villalar> repository;
        public VillaManager()
        {
            db = new VillaKiralamaDBEntities();
            repository = new Repository<Villalar>(db);
        }
        public Villalar Bul(string villAdi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int villaID, int kategoriID, string villaAdi, string villaAdres, int villaImageID, int ilceID, bool aktifMi)
        {
            try
            {
                var guncellecekData = repository.BulQuery(x => x.VillalarID == villaID).FirstOrDefault();
                if (guncellecekData == null)
                {
                    return "Villa bulunamadı, lütfen kontrol ediniz";
                }
                guncellecekData.KategoriID = kategoriID;
                guncellecekData.VillaAdi = villaAdi;
                guncellecekData.VillaAdres = villaAdres;
                guncellecekData.VillaImageID = villaImageID;
                guncellecekData.VillaIlceID = ilceID;
                guncellecekData.AktifMi = aktifMi;
                int sonuc = repository.Guncelle(guncellecekData);
                if (sonuc > 0)
                {
                    return "Güncelleme başarılı";
                }
                return "Güncelleme başarısız";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu \nHATA:" + ex.Message;
            };
        }

        public string Kaydet(int kategoriID, string villaAdi, string villaAdres, int villaImageID, int ilceID, bool aktifMi)
        {
            db = new VillaKiralamaDBEntities();
            repository = new Repository<Villalar>(db);
            try
            {
                var varmiVilla = repository.BulQuery(x => x.VillaAdi == x.VillaAdi).FirstOrDefault();
                if (varmiVilla == null)
                {
                    return "Aynı villa kayıtlı";
                }
                Villalar villalar = new Villalar();
                villalar.KategoriID = kategoriID;
                villalar.VillaAdi = villaAdi;
                villalar.VillaAdres = villaAdres;
                villalar.VillaImageID = villaImageID;
                villalar.VillaIlceID = ilceID;
                villalar.AktifMi = aktifMi;
                int sonuc = repository.Kaydet(villalar);
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

        public string Sil(int villaID)
        {
            try
            {
                var data = repository.BulQuery(x => x.VillalarID == villaID).FirstOrDefault();
                if (data == null)
                {
                    return "Villa bulunamadı, lütfen kontrol ediniz";
                }
                int sonuc = repository.Sil(data);
                if (sonuc > 0)
                {
                    return "Villa silme işlemi başarılı";
                }
                return "Villa silme işlemi başarısız";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu \nHATA:" + ex.Message;
            }
        }

        public IEnumerable<Villalar> VillaListele()
        {
            return repository.Listele();
        }
    }
}
