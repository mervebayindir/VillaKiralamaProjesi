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
    public class VillaDetayManager : IVillaDetay
    {
        VillaKiralamaDBEntities db;
        Repository<VillaDetay> repository;
        public VillaDetayManager()
        {
            db = new VillaKiralamaDBEntities();
            repository = new Repository<VillaDetay>(db);
        }
        public VillaDetay Bul(string villAdi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int villaID, string odaSayisi, int banyoSayisi, decimal gunlukFiyat, bool havuzluMu, bool muhafazakarMı, int kisiSayisi, bool cocukHavuzuVarMi, bool denizeYakinmi, bool havuzuKorunaklimi, string aciklama)
        {
            try
            {
                var guncellenecekData = repository.BulQuery(x => x.VillaID == villaID).FirstOrDefault();
                if (guncellenecekData == null)
                {
                    return "Villa bulunamadı, lütfen kontrol ediniz";
                }
                guncellenecekData.OdaSayisi = odaSayisi;
                guncellenecekData.BanyoSayısı = banyoSayisi;
                guncellenecekData.GunlukFiyat = gunlukFiyat;
                guncellenecekData.HavuzluMu = havuzluMu;
                guncellenecekData.MuhafazakarMı = muhafazakarMı;
                guncellenecekData.KişiSayisi = kisiSayisi;
                guncellenecekData.ÇocukHavuzuVarmi = cocukHavuzuVarMi;
                guncellenecekData.DenizeYakinMi = denizeYakinmi;
                guncellenecekData.HavuzuKorunakliMi = havuzuKorunaklimi;
                guncellenecekData.Aciklama = aciklama;
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

        public string Kaydet(int villaID, string odaSayisi, int banyoSayisi, decimal gunlukFiyat, bool havuzluMu, bool muhafazakarMı, int kisiSayisi, bool cocukHavuzuVarMi, bool denizeYakinmi, bool havuzuKorunaklimi, string aciklama)
        {
            db = new VillaKiralamaDBEntities();
            repository = new Repository<VillaDetay>(db);
            try
            {
                var varmiVillaDetay = repository.BulQuery(x => x.VillaID == villaID).FirstOrDefault();
                if (varmiVillaDetay == null)
                {
                    return "Aynı villa kayıtlı";
                }
                VillaDetay villaDetay = new VillaDetay();
                villaDetay.OdaSayisi = odaSayisi;
                villaDetay.BanyoSayısı = banyoSayisi;
                villaDetay.GunlukFiyat = gunlukFiyat;
                villaDetay.HavuzluMu = havuzluMu;
                villaDetay.MuhafazakarMı = muhafazakarMı;
                villaDetay.KişiSayisi = kisiSayisi;
                villaDetay.ÇocukHavuzuVarmi = cocukHavuzuVarMi;
                villaDetay.DenizeYakinMi = denizeYakinmi;
                villaDetay.HavuzuKorunakliMi = havuzuKorunaklimi;
                villaDetay.Aciklama = aciklama;
                int sonuc = repository.Kaydet(villaDetay);
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
                var data = repository.BulQuery(x => x.VillaID == villaID).FirstOrDefault();
                if (data == null)
                {
                    return "Villa detay bulunamadı, lütfen kontrol ediniz";
                }
                int sonuc = repository.Sil(data);
                if (sonuc > 0)
                {
                    return "Villa detay silme işlemi başarılı";
                }
                return "Villa detay silme işlemi başarısız";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu \nHATA:" + ex.Message;
            }
        }

        public IEnumerable<VillaDetay> VillaDetayListele()
        {
            return repository.Listele();
        }
    }
}
