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
    public partial class oknokonf2 : Form
    {
        oknokonf3 okno3 = new oknokonf3();
        
        oknokonf1 okno1 = new oknokonf1();
        public oknokonf2()
        {
            InitializeComponent();
        }


        public void zwrocokno(oknokonf1 okno)
        {
            okno1 = okno;
        }
        
        

        private void dodajprofil_button_Click(object sender, EventArgs e)
        {
            okno3 = new oknokonf3();
            okno3.Show();
        }

        private void wstecz_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            okno1.Visible = true;
        }

        private void dalej_button_Click(object sender, EventArgs e)
        {
            oknokonf4 okno4 = new oknokonf4();
            okno4.Show();
            this.Visible = false;
            okno4.Show();
            okno4.zwrocokno2(this);
        }
    }
}
