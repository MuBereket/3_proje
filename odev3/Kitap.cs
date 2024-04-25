namespace odev3
{
    public class kitapInceleme
    {
        private List<EditorKitapG> gorusler;
        private Kitap kitap;

        public kitapInceleme(Kitap kitap)
        {
            gorusler = new List<EditorKitapG>();
            this.kitap = kitap;

        }
        public void addKitapGorus(Editor editor, string aciklama, EditorIncEnum karar)
        {
            gorusler.Add(new EditorKitapG(editor, aciklama, karar));
        }

        public EditorIncEnum getKarar()
        {

            EditorIncEnum sonuc = 0;
            int red = 0, onya = 0, duzen = 0;
            for (int i = 0; i < gorusler.Count; i++)
            {
                EditorIncEnum karar = gorusler[i].Karar;
                if (karar == EditorIncEnum.Reddedildi) { red++; }
                else if (karar == EditorIncEnum.Onaylandi) { onya++; }
                else { duzen++; }
            }
            if (red > 0)
            {
                sonuc = EditorIncEnum.Reddedildi;
            }
            else if (duzen > 0)
            {
                sonuc = EditorIncEnum.Duzenlenecek;
            }
            else if (onya > 0 && onya == gorusler.Count)
            {
                sonuc = EditorIncEnum.Onaylandi;
            }
            return sonuc;


        }
    }

    public enum KitapDurumEnum
    {
        Yayinlandi, Reddedildi, Inclemede
    }
    public class Kitap
    {
        private Yazar yazar;
        private List<kitapInceleme> incelmeler;
        private KitapDurumEnum durum;
        private string adi;

        public Kitap(string adi , Yazar yazar)
        {
            this.yazar = yazar;
            this.adi = adi;
            incelmeler = new List<kitapInceleme>();
        }

        public Yazar Yazar
        {
            get { return yazar; }
        }
        public String Adi
        {
            get { return adi; }
        }

        public KitapDurumEnum Durum
        {
            get { return durum; }
        }
        public void addInceleme(kitapInceleme inceleme)
        {
            incelmeler.Add(inceleme);
            KitapdurumGunceleme();
        }
        public void removeInceleme(kitapInceleme inceleme)
        {
            incelmeler.Remove(inceleme);
            KitapdurumGunceleme();
        }
        public void KitapdurumGunceleme()
        {
            kitapInceleme sonInceleme = incelmeler[incelmeler.Count - 1];
            if (sonInceleme.getKarar() == EditorIncEnum.Reddedildi)
            {
                durum = KitapDurumEnum.Reddedildi;
            }
            else if (sonInceleme.getKarar() == EditorIncEnum.Duzenlenecek)
            {
                durum = KitapDurumEnum.Inclemede;
            }
            else if (sonInceleme.getKarar() == EditorIncEnum.Onaylandi)
            {
                durum = KitapDurumEnum.Yayinlandi;
            }

        }

    }
}
