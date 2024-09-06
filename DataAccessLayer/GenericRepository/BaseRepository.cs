using BusinessLogicLayer.GenericRepository.IntRep;
using DataAccessLayer.Context;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.GenericRepository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {

        MyContext db;
        public BaseRepository()
        {
            db = new MyContext();   
        }

        void Kaydet()
        {
          db.SaveChanges();

        }

        public List<T> AktifleriGetir()
        {
            return Filtrele(x => x.VeriDurumu != EntityLayer.Enums.DataStatus.Silindi);
        }

        public T Bul(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> DegistirilenleriGetir()
        {
            return Filtrele(x=>x.VeriDurumu==EntityLayer.Enums.DataStatus.Guncellendi);
        }

        public void Ekle(T item)
        {
            db.Set<T>().Add(item);  
            Kaydet();   
        }

        public void TopluEkle(List<T> liste)
        {
            foreach( T item in liste)
            {
                Ekle(item); 
            }
        }

        public List<T> Filtrele(Expression<Func<T, bool>> kosul)
        {
            return db.Set<T>().Where(kosul).ToList();   
        }

        public void Guncelle(T item)
        {
            item.VeriDurumu=EntityLayer.Enums.DataStatus.Guncellendi;
            item.GuncellenmeTarihi=DateTime.Now;
            T degisecek = Bul(item.ID);
            db.Entry(degisecek).CurrentValues.SetValues(item);
            Kaydet();
        }

        public void TopluGuncelle(List<T> liste)
        {
           foreach ( T item in liste)
            {
                Guncelle(item);
            }
        }

        public bool HerhangiBiriniKontrolEt(Expression<Func<T, bool>> kosul)
        {
            return db.Set<T>().Any(kosul);  
        }

        public T IlkVeyaVarsayilan(Expression<Func<T, bool>> kosul)
        {
           return db.Set<T>().FirstOrDefault(kosul);    
        }

        public object Sec(Expression<Func<T, object>> secim)
        {
          return db.Set<T>().Select(secim);
        }

        public IQueryable<X> Sec<X>(Expression<Func<T, X>> secim)
        {
            return db.Set<T>().Where(x => x.VeriDurumu != EntityLayer.Enums.DataStatus.Silindi).Select(secim);
        }

        public void Sil(T item)
        {
            item.VeriDurumu=EntityLayer.Enums.DataStatus.Silindi;   
            item.SilinmeTarihi=DateTime.Now;
            Kaydet();
        }

        public List<T> SilinenleriGetir()
        {
            return Filtrele(x=>x.VeriDurumu == EntityLayer.Enums.DataStatus.Silindi);
        }

        public void TopluSil(List<T> liste)
        {
           foreach( T item in liste)
            {
                Sil(item);
            }
        }

        public List<T> TumunuGetir()
        {
            return db.Set<T>().ToList();
        }

        public void YokEt(T item)
        {
            db.Set<T>().Remove(item);   
        }

        public void TopluYokEt(List<T> liste)
        {
           foreach ( T item in liste)
            {
                YokEt(item);    
            }
        }
    }
}
