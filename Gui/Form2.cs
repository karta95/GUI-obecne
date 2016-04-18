using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class oknokonf1 : Form
    {
        public oknokonf1()
        {
            InitializeComponent();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            poczatek.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            poczatek.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        public string wlasciwosc
        {
            get { return poczatek.Text; }
            set { poczatek.Text = value; }

        }

         private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Dalej_button_Click(object sender, EventArgs e)
        {
            
            oknokonf2 okno2 = new oknokonf2();
            okno2.Show();
            this.Visible = false;
            okno2.zwrocokno(this);
        }

        
        
    }
}
