using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3
{
    public partial class KitapArayuz : Form
    {
        String yer;
        YayinEvi evi;
        public KitapArayuz(string yer)
        {
            InitializeComponent();
            this.yer = yer;
        }

        private void KitapArayuz_Load(object sender, EventArgs e)
        {   //"Burada yazarların verilerini alıyoruz ve comboBox koyar"
            evi = new YayinEvi(yer, "y");
            comboBox1.Items.Clear();
            for (int i = 0; i < evi.Yazarlar1.Count; i++)
            {
                comboBox1.Items.Add(evi.Yazarlar1[i].Ad + " " + evi.Yazarlar1[i].Soyad);
            }
            //"Burada Editörlerin verilerini alıyoruz ve comboBox koyar"
            evi = new YayinEvi(yer, "e");
            comboBox2.Items.Clear();
            for (int i = 0; i < evi.Editorler1.Count; i++)
            {
                comboBox2.Items.Add(evi.Editorler1[i].Ad + " " + evi.Editorler1[i].Soyad);
            }
            evi = new YayinEvi(yer, "k");

            //"Burada kitapların verilerini alıyoruz ve taploda koyar"
            readF rd = new readF(yer, "KitapArayuz", 1);
            for (int i = 0; i < evi.Kitaplar1.Count; i++)
            {
                String[] bilgi = { rd.KitapIsmi[i], rd.Yazar[i], rd.Editor[i], rd.Aciklama[i], rd.Incleme[i] };

                var it = new ListViewItem(bilgi);
                listView1.Items.Add(it);
            }

            try
            {
                radioButton1.Checked = true;
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;

            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //"Bu Ekle tuş"
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurunuz");
            }
            else
            {

                string sec = "";
                if (radioButton1.Checked)
                {
                    sec = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    sec = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    sec = radioButton3.Text;
                }

                //"Burada, YayınEv sınıfının yapıcı nesnesi"
                //"aracılığıyla ad ve soyadı gönderiyoruz."
                evi.edi = comboBox2.Text;

                //"Burada, YayınEv sınıfının yapıcı nesnesi"
                //"aracılığıyla Açıklama gönderiyoruz."
                evi.acik = textBox2.Text;
                //"Burada, YayınEv sınıfının yapıcı nesnesi"
                //"aracılığıyla incelme gönderiyoruz."
                evi.incleme = sec;

                string[] k = comboBox1.Text.Split(' ');

                //"Burada veri eklemek için Function add'a gönderiyoruz"
                while (true) { 
                try {evi.addKitap(new Kitap(textBox1.Text, new Yazar(k[0], k[k.Length-1])));
                        break;
                    } 
                catch { MessageBox.Show("İsim yazımındaki bir hata düzeltildi."); 
                    }
                }

                //"Aynı zamanda bunları tabloya ekleyin"
                String[] bilgi = { textBox1.Text, comboBox1.Text, comboBox2.Text, textBox2.Text, sec };
                var it = new ListViewItem(bilgi);
                listView1.Items.Add(it);

                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Eklendi........");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //"Bu Silme tuş"
            String[] bilgi = { textBox1.Text, textBox2.Text };

            string[] k = comboBox1.Text.Split(' ');

            //"Burada veri silmek için Function remove'ye gönderiyoruz"
            evi.removeKitap(new Kitap(textBox1.Text, new Yazar(k[0], k[1])));
            bool mevcut = false;
            //"Aynı zamanda öğeyi arayın ve silin"
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                {
                    listView1.Items[i].Remove();
                    mevcut = true;
                    MessageBox.Show("Silindi.......");
                    break;
                }
            }
            if (!mevcut)
            {
                MessageBox.Show("mevcut değil....");
            }

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
            catch { }
        }
    }
}
