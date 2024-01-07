using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VillaKiralama.DLL.RepositoryFolder
{
    public interface IRepository<T> where T : class
    {
        int Kaydet(T entity);
        int Guncelle(T entity);
        int Sil(T entity);
        List<T> Listele();
        T Getir(int id);
        IEnumerable<T> BulEnum(Expression<Func<T, bool>> sorgu);
        IQueryable<T> BulQuery(Expression<Func<T, bool>> sorgu);
    }
}
