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
    public partial class Yazarlar : Form
    {
        //"Yayın Evi sınıfından bir değişken oluşturun"
        YayinEvi evi;

        public Yazarlar(String yer)
        {
            evi = new YayinEvi(yer, "y");

            InitializeComponent();
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
                //"Burada veri eklemek için Function add'a gönderiyoruz"
                evi.addYazar(new Yazar(textBox1.Text, textBox2.Text));
                //"Aynı zamanda bunları tabloya ekleyin"
                String[] bilgi = { textBox1.Text, textBox2.Text };
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

            //"Burada veri silmek için Function remove'ye gönderiyoruz"
            evi.removeYazar(new Yazar(textBox1.Text, textBox2.Text));
            //"Aynı zamanda öğeyi arayın ve silin"
            bool mevcut = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBox1.Text &&
                    listView1.Items[i].SubItems[1].Text == textBox2.Text
                    )
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
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            }
            catch { }

        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }

        private void Yazarlar_Load(object sender, EventArgs e)
        {
            //"Tabloya koymak için verileri içe aktarın"
            for (int i = 0; i < evi.Yazarlar1.Count; i++)
            {
                String[] bilgi = { evi.Yazarlar1[i].Ad, evi.Yazarlar1[i].Soyad };
                var it = new ListViewItem(bilgi);
                listView1.Items.Add(it);
            }
        }
    }
}
