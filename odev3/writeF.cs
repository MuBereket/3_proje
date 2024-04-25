using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace odev3
{
    //
    public class writeF
    {
        //Bu sınıfın işlevi depolama yapmaktır
        //ya silin yada ekleyin

        //İşte dosya yolu
        String yer,cs,isim;
        String path = @"kutup\";

        StreamWriter sw;
        public bool varmi = false;

        //Burada sınıf içinde kullanılacak getirme nesnesini oluşturuyoruz.
        readF reader;
        public writeF(string yer,string isim)
        {
            //Bu Oluşturucunun işlevi, verileri getirme yolunu tanımlamaktır.
            this.isim = isim;
            this.cs = isim + ".csv";
            this.yer = yer;

            reader=new readF(yer,isim);
        }
        public void ekle(String a, String p)
        {
            //Bu Ekleme İşlevi,  dosyaya editörler ve yazarlar için ad ve soyadı ekler
            reader.Adi.Add(a);
            reader.Soyad.Add(p);
            
            
            kaydetmek();
        }
        public void ekle(String iisim, String yazar,string editor,string acik,string inceleme )
        {
            //Bu Ekleme İşlevi,  dosyaya kitaplar için veriler ekler
            reader = new readF(yer, isim,1);

            reader.KitapIsmi.Add(iisim);
            reader.Yazar.Add(yazar);
            reader.Editor.Add(editor);
            reader.Aciklama.Add(acik);
            reader.Incleme.Add(inceleme);


            kaydetmek1();
        }
        public void sil(string a)
        {
            //Bu Silme İşlevi,  dosyaya editörler ve yazarlar için ad ve soyadı siler
            int index = reader.Adi.IndexOf(a);
            if (index == -1)
            {
                varmi = false;
            }
            else
            {
                reader.Adi.RemoveAt(index);
                reader.Soyad.RemoveAt(index);
                
                kaydetmek();
                varmi = true;
            }
        }
        public void sil1(string a)
        {
            //Bu Silme İşlevi,  dosyaya kitaplar için veriler siler
            reader = new readF(yer, isim, 1);
            
            int index = reader.KitapIsmi.IndexOf(a);
            if (index == -1)
            {
                varmi = false;
            }
            else
            {
                reader.KitapIsmi.RemoveAt(index);
                reader.Yazar.RemoveAt(index);
                reader.Editor.RemoveAt(index);
                reader.Aciklama.RemoveAt(index);
                reader.Incleme.RemoveAt(index);

                kaydetmek1();
                varmi = true;
            }
        }

        private void kaydetmek()
        {
            //Bu Kaydetme İşlevi,dosyaya editörler ve yazarlar için ad ve soyadı kaydetir
            sw = new StreamWriter(path+@yer+"\\"+cs);
            for (int i = 0; i < reader.Adi.Count; i++)
            {
                sw.WriteLine("{0},{1}", reader.Adi[i], reader.Soyad[i]);
            }
            sw.Close();
        }
        private void kaydetmek1()
        {
            //Bu Kaydetme İşlevi,dosyaya kitaplar için veriler kaydetir
            sw = new StreamWriter(path + @yer + "\\" + cs);
            for (int i = 0; i < reader.KitapIsmi.Count; i++)
            {
                sw.WriteLine("{0},{1},{2},{3},{4}", 
                    reader.KitapIsmi[i], reader.Yazar[i], reader.Editor[i],
                    reader.Aciklama[i], reader.Incleme[i]);
            }
            sw.Close();
        }
    }
}
