namespace odev3
{
    public class Kisi
    {
        private string ad;
        private string soyad;

        public Kisi(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }

        public String Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public String Soyad
        {
            get { return soyad; }
            set { ad = value; }

        }
    }
}
