using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Replace___Denemesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eski, yeni, sonuc;

            eski = textBox2.Text;
            yeni = textBox3.Text;
            sonuc = textBox1.Text.Replace(eski,yeni);
            MessageBox.Show(sonuc, "Bilgi");

        }
    }
}
