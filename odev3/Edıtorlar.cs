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
    public partial class Editorlar : Form
    {
        YayinEvi evi;    
        public Editorlar(string yer)
        {
            //"Yayın Evi sınıfından bir değişken oluşturun"
            evi = new YayinEvi(yer, "e");
            InitializeComponent();
        }

        private void Edıtorlar_Load(object sender, EventArgs e)
        {
            //"Tabloya koymak için verileri içe aktarın"
            for (int i = 0; i < evi.Editorler1.Count; i++)
            {
                String[] bilgi = { evi.Editorler1[i].Ad, evi.Editorler1[i].Soyad };
                var it = new ListViewItem(bilgi);
                listView1.Items.Add(it);
            }
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
                evi.addEditor(new Editor(textBox1.Text, textBox2.Text));
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
            evi.removeEditor(new Editor(textBox1.Text, textBox2.Text));
            bool mevcut = false;
            //"Aynı zamanda öğeyi arayın ve silin"
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
    }
}
