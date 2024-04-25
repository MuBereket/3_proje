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
    public partial class AddEv : Form
    {
       
        
        public AddEv()
        {
            InitializeComponent();
        }

        private void AddEv_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { //Dosya oluşturmak için gönder
            new YayinEvi(textBox1.Text,0).yayinEv();
            
            textBox1.Text = "";

        }

        private void AddEv_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            
        }
    }
}
