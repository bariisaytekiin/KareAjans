using KareAjans.Entity.Entities;
using KareAjans.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.DAL.Seed
{
    internal class MankenSeed
    {
        public static List<Manken> mankenler = new List<Manken>()
        {
            new Manken() {Id=1,Ad="Ayşe",Soyad="Alev",TelefonNo="905058529632",TelefonNo2="905328547896",Adres="Yeni Mah. Pendik/İstanbul",Cinsiyet=Cinsiyet.Kadın,AyakkabıNo=AyakkabıNo.Size36,Beden=Beden.S,Kilo=45,Boy=160,SacRengi=SacRengi.Siyah,GozRengi = GozRengi.Mavi,SehirDisiCalisma=true,Ehliyet= false,Özellik="Girişken",YabanciDil="İngilizce,Almanca",Kategori=MankenKategori.Kategori1,DogumTarihi=new DateTime(2010,10,10),Email="a@gmail.com" },

            new Manken() {Id=2,Ad="Ahmet",Soyad="Can",TelefonNo="905529529632",TelefonNo2="905368548596",Adres="Eski Mah. Kadıköy/İstanbul",Cinsiyet=Cinsiyet.Erkek,AyakkabıNo=AyakkabıNo.Size41,Beden=Beden.L,Kilo=75,Boy=180,SacRengi=SacRengi.Siyah,GozRengi = GozRengi.Kahverengi,SehirDisiCalisma=true,Ehliyet= true,Özellik="Girişken",YabanciDil="İngilizce",Kategori=MankenKategori.Kategori2,DogumTarihi=new DateTime(1995,02,10),Email="b@gmail.com" },

            new Manken() {Id=3,Ad="Fatma",Soyad="Kalyon",TelefonNo="905638512632",TelefonNo2="905985647896",Adres="Güzel Mah. Ümraniye/İstanbul",Cinsiyet=Cinsiyet.Kadın,AyakkabıNo=AyakkabıNo.Size37,Beden=Beden.S,Kilo=55,Boy=170,SacRengi=SacRengi.Gri,GozRengi = GozRengi.Siyah,SehirDisiCalisma=false,Ehliyet= false,Özellik="Girişken",YabanciDil="İspanyolca" ,Kategori=MankenKategori.Kategori3,DogumTarihi=new DateTime(1997,10,10),Email="c@gmail.com"},

            new Manken() {Id=4,Ad="Ayşegül",Soyad="Ay",TelefonNo="905075329632",TelefonNo2="905328253496",Adres="Yeni Mah. Levent/İstanbul",Cinsiyet=Cinsiyet.Kadın,AyakkabıNo=AyakkabıNo.Size37,Beden=Beden.M,Kilo=45,Boy=165,SacRengi=SacRengi.Siyah,GozRengi = GozRengi.Ela,SehirDisiCalisma=true,Ehliyet= true,Özellik="Sıcak Kanlı",YabanciDil="",Kategori=MankenKategori.Kategori3,DogumTarihi=new DateTime(2018,10,10),Email="d@gmail.com" }
        };
    }
}
