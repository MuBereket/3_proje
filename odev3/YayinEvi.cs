using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    public class YayinEvi
    {
        string isim;
        private List<Editor> Editorler;
        private List<Kitap> Kitaplar;
        private List<Yazar> Yazarlar;

        //Kitaplar dosyasına kaydedilecek veriler
        public String acik, incleme, edi;

        //Depolama sınıfı 
        public readF reader;
        //getirme sınıfı
        private writeF writer;

        public List<Editor> Editorler1 { get => Editorler; set => Editorler = value; }
        public List<Kitap> Kitaplar1 { get => Kitaplar; set => Kitaplar = value; }
        public List<Yazar> Yazarlar1 { get => Yazarlar; set => Yazarlar = value; }

        public YayinEvi(string isim, int key)
        {
            //Bu Oluşturucunun işlevi, dosyaların oluşturulması,
            //yani Kutup dosyasında yayınevinin oluşturulması ile ilgilidir.
            this.isim = isim;
        }
        public YayinEvi(string isim)
        {
            //Bu Oluşturucunun işlevi, kitap durumu tespiti için veri getirmektir.
            this.isim = isim;
            Kitaplar = new List<Kitap>();
            Editorler = new List<Editor>();

            getkitap();
            for (int i = 0; reader.KitapIsmi.Count > i; i++)
            {
                string[] k = reader.Editor[i].Split(' ');
                Editorler.Add(new Editor(k[0], k[1]));
            }
        }
        public YayinEvi(string isim, string key)
        {
            //Bu Oluşturucunun işlevi, yazarlar ve
            //editörler ve kitaplar için dosyaları depolamak ve almaktır.
            this.isim = isim;
            Kitaplar = new List<Kitap>();
            Editorler = new List<Editor>();
            Yazarlar = new List<Yazar>();

            //Anahtar, veri türünü bilmektir
            switch (key)
            {
                case "y"
                :
                    getYazar();
                    break;
                case "e"
                :
                    getEditor();
                    break;
                case "k"
                :
                    getkitap(); break;
                default:
                    MessageBox.Show("yok");
                    break;
            }
        }


        public void addKitap(Kitap k)
        {

            getEditor();

            //editör Kitaplar klasörüne yerleştirmek için editörler klasöründe arama
            string[] f = edi.Split(' ');
            String ed = reader.Adi[reader.ara(f[0])] + " " + reader.Soyad[reader.ara(f[0])];
            //Depolama sınıfı, ekleme açısından kendi içinde çalışacak şekilde 
            setkitap();
            //Buraya depolama sınıfını ekliyoruz
            writer.ekle(k.Adi, k.Yazar.Ad + " " + k.Yazar.Soyad, ed, acik, incleme);
            Kitaplar.Add(k);

        }
        public void removeKitap(Kitap k)
        {
            ////Depolama sınıfı,Silme açısından kendi içinde çalışacak şekilde
            setkitap();
            writer.sil1(k.Adi);
            Kitaplar.Remove(k);
        }
        public void addYazar(Yazar k)
        {
            //Depolama sınıfı, ekleme açısından kendi içinde çalışacak şekilde 
            setYazar();
            writer.ekle(k.Ad, k.Soyad);
            Yazarlar.Add(k);
        }
        public void removeYazar(Yazar k)
        {
            ////Depolama sınıfı,Silme açısından kendi içinde çalışacak şekilde
            setYazar();
            writer.sil(k.Ad);
            Yazarlar.Remove(k);
        }
        public void addEditor(Editor e)
        { //Depolama sınıfı, ekleme açısından kendi içinde çalışacak şekilde 
            setEditor();
            writer.ekle(e.Ad, e.Soyad);
            Editorler.Add(e);
        }
        public void removeEditor(Editor e)
        {
            ////Depolama sınıfı,Silme açısından kendi içinde çalışacak şekilde
            setEditor();
            writer.sil(e.Ad);
            Editorler.Remove(e);
        }

        public void yayinEv()
        {
            //Bu Fonksiyonun işlevi, dosyalar oluşturmaktır.
            string str = "\\" + isim;
            String path = @"kutup" + @str;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void getkitap()
        {
            //Burada nesne, dosyasından veri getiriyor
            reader = new readF(isim, "KitapArayuz", 1);
            Kitaplar.Clear();
            for (int i = 0; reader.KitapIsmi.Count > i; i++)
            {
                string[] k = reader.Yazar[i].Split(' ');
                Kitaplar.Add(new Kitap(reader.KitapIsmi[i], new Yazar(k[0], k[1])));
            }
        }

        void setkitap()
        {
            //Burada, dosyada ekleme veya silme üzerinde çalışmak için nesne tanınır.
            writer = new writeF(isim, "KitapArayuz");
        }

        void getEditor()
        {
            //Burada nesne, dosyasından veri getiriyor
            reader = new readF(isim, "editorlar");
            Editorler.Clear();

            for (int i = 0; i < reader.Adi.Count; i++)
            {
                Editorler.Add(new Editor(reader.Adi[i], reader.Soyad[i]));
            }

        }
        void getYazar()
        {
            //Burada nesne, dosyasından veri getiriyor
            reader = new readF(isim, "yazarlar");
            Yazarlar.Clear();

            for (int i = 0; i < reader.Adi.Count; i++)
            {
                Yazarlar.Add(new Yazar(reader.Adi[i], reader.Soyad[i]));
            }
        }
        void setEditor()
        {
            //Burada, dosyada ekleme veya silme üzerinde çalışmak için nesne tanınır.
            writer = new writeF(isim, "editorlar");
        }
        void setYazar()
        {
            //Burada, dosyada ekleme veya silme üzerinde çalışmak için nesne tanınır.
            writer = new writeF(isim, "yazarlar");

        }



    }
}
