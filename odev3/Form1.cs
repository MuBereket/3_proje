namespace odev3
{
    public partial class Form1 : Form
    {



        String path;
        public Form1()
        {
            path = @"kutup";
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //"Bu Editörler Arayuz  tuş menu"
            //"Gönderdiğimiz parametre, dosya yolu için yayınevin adıdır."
            Editorlar ed = new Editorlar(comboBox1.Text);
            ed.Show();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //"Bu AddEv Arayuz  tuş menu"
            //"Gönderdiğimiz parametre, dosya yolu için yayınevin adıdır."
            AddEv addEv = new AddEv();
            addEv.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //"Kutup dosyası içindeki dosyaların adları"
            //"getirilir ve comboBox yerleştirilir".
            try
            {
                string[] dosyalar = Directory.GetDirectories(path);
                foreach (string s in dosyalar)
                {
                    string[] dosyaAdi = s.Split('\\');
                    comboBox1.Items.Add(dosyaAdi[dosyaAdi.Length - 1]);
                }
                comboBox1.SelectedIndex = 0;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //"Bu Roload tuş, Kutup dosyasındaki dosya adları"
            //"alınır ve birleşik giriş kutusu yerleştirilir".

            comboBox1.Items.Clear();
            string[] dosyalar = Directory.GetDirectories(path);
            foreach (string s in dosyalar)
            {
                string[] dosyaAdi = s.Split('\\');
                comboBox1.Items.Add(dosyaAdi[dosyaAdi.Length - 1]);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //"Bu Göster tuş"
            //"Gönderdiğimiz parametre, dosya yolu için yayınevin adıdır."
            new YayinevKitaplar(comboBox1.Text).Show();
        }

        private void yazarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arayüzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //"Bu Yazarlar Arayuz  tuş menu"
            //"Gönderdiğimiz parametre, dosya yolu için yayınevin adıdır."
            Yazarlar ya = new Yazarlar(comboBox1.Text);
            ya.Show();

        }

        private void arayüzYazarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //"Bu Yazarlar Arayuz  tuş menu"
            //"Gönderdiğimiz parametre, dosya yolu için yayınevin adıdır."
            new KitapArayuz(comboBox1.Text).Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Muhammed Bereket\n 205260602");
        }
    }
}