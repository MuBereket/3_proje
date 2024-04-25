using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3
{
    public partial class YayinevKitaplar : Form
    {
        string yer;
        YayinEvi evi;
        public YayinevKitaplar(string yer)
        {
            this.yer = yer;
            evi=new YayinEvi(yer);
            InitializeComponent();
        }

        private void YayinevKitaplar_Load(object sender, EventArgs e)
        {
            label1.Text = yer;


            
            for (int i = 0; i < evi.Kitaplar1.Count; i++)
            {
                //"Kitapİnceleme sınıfından bir nesne oluşturur ve içine bir kitap koyar."
                kitapInceleme ki = new kitapInceleme(evi.Kitaplar1[i]);
                EditorIncEnum editorIncEnum = new EditorIncEnum();

                //"Incleme kitap dosyasından import edip hangi seçeneğin"
                //"olduğunu bulmaya çalışıyoruz."
                if (evi.reader.Incleme[i] == EditorIncEnum.Onaylandi.ToString()) {
                editorIncEnum=EditorIncEnum.Onaylandi;
                }
                else if (evi.reader.Incleme[i] == EditorIncEnum.Reddedildi.ToString())
                {
                    editorIncEnum = EditorIncEnum.Reddedildi;
                }
                else if (evi.reader.Incleme[i] == EditorIncEnum.Duzenlenecek.ToString())
                {
                    editorIncEnum = EditorIncEnum.Duzenlenecek;
                }
                //"Durumu bilmek için bu işlemi yapıyoruz."
                ki.addKitapGorus(evi.Editorler1[i], evi.reader.Aciklama[i],editorIncEnum);
                evi.Kitaplar1[i].addInceleme(ki);
                String durum = evi.Kitaplar1[i].Durum.ToString();

                //"Ve tabloya koyur"
                String[] bilgi = { evi.Kitaplar1[i].Adi, evi.reader.Yazar[i],evi.reader.Editor[i],durum};

                var it = new ListViewItem(bilgi);
                listView1.Items.Add(it);
            }


        }
    }
}
