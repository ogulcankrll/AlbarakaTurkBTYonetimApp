using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.GenericRepository.IntRep
{
    internal interface IRepository<T> where T :BaseEntity
    {
        // Listeleme Komutları
        List<T> TumunuGetir(); 
        List<T> AktifleriGetir(); 
        List<T> DegistirilenleriGetir(); 
        List<T> SilinenleriGetir();


        // Değişiklik Komutları
        void Ekle(T item); 
        void TopluEkle(List<T> liste); 
        void Guncelle(T item); 
        void TopluGuncelle(List<T> liste); 
        void Sil(T item); 
        void TopluSil(List<T> liste); 
        void YokEt(T item); 
        void TopluYokEt(List<T> liste); 


        //Sorgu Komutları
        List<T> Filtrele(Expression<Func<T, bool>> kosul);
        bool HerhangiBiriniKontrolEt(Expression<Func<T, bool>> kosul);
        T IlkVeyaVarsayilan(Expression<Func<T, bool>> kosul);
        object Sec(Expression<Func<T, object>> secim);
        IQueryable<X> Sec<X>(Expression<Func<T, X>> secim);
        T Bul(int id);  


       




    }
}
