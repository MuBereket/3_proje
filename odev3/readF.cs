using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    public class readF
    {
        String path = @"kutup\";
        StreamReader sr;
        string[] kume;
        //Veri türüne göre listeler oluşturun
        List<string> adi;
        List<string> soyad;
        List<string> yazar;
        List<string> editor;
        List<string> kitapIsmi;
        List<string> aciklama;
        List<string> incleme;

        //Bu Yapıcı, Kitaplar dosyasındaki verileri alır
        public readF(String yer, string isim, int i)
        {
            //İşte dosya yolu
            string cs = isim + ".csv";
            var fs = new FileStream(path + @yer + "\\" + cs, FileMode.OpenOrCreate);
            fs.Close();
            sr = new StreamReader(path + @yer + "\\" + cs);

            yazar = new List<string>();
            editor = new List<string>();
            kitapIsmi = new List<string>();
            aciklama = new List<string>();
            incleme = new List<string>();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                kume = line.Split(',');
                kitapIsmi.Add(kume[0]);
                yazar.Add(kume[1]);
                editor.Add(kume[2]);
                aciklama.Add(kume[3]);
                incleme.Add(kume[4]);

            }
            sr.Close();

        }

        //Bu Yapıcı, editörler veya yazarlar dosyasındaki verileri alır
        public readF(String yer, string isim)
        {
            //İşte dosya yolu
            string cs = isim + ".csv";
            var fs = new FileStream(path + @yer + "\\" + cs, FileMode.OpenOrCreate);
            fs.Close();
            sr = new StreamReader(path + @yer + "\\" + cs);

            adi = new List<string>();
            soyad = new List<string>();

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    kume = line.Split(',');
                    adi.Add(kume[0]);
                    soyad.Add(kume[1]);

                }            
            sr.Close();

        }

        public List<string> Adi { get => adi; set => adi = value; }
        public List<string> Soyad { get => soyad; set => soyad = value; }
        public List<string> Yazar { get => yazar; set => yazar = value; }
        public List<string> Editor { get => editor; set => editor = value; }
        public List<string> KitapIsmi { get => kitapIsmi; set => kitapIsmi = value; }
        public List<string> Aciklama { get => aciklama; set => aciklama = value; }
        public List<string> Incleme { get => incleme; set => incleme = value; }

        public int ara(String str)
        {
            
            return adi.IndexOf(str);

        }
       
    }
}
