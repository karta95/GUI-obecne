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
    public partial class oknokonf4 : Form
    {
        oknobledow oknobledow = new oknobledow();
        oknokonf2 okno2 = new oknokonf2();
        public oknokonf4()
        {
            InitializeComponent();
        }

        public void zwrocokno2(oknokonf2 okno)
        {
            okno2 = okno;
        }
        private void rozpocznij_button_Click(object sender, EventArgs e)
        {
            oknobledow = new oknobledow();
            this.Visible = false;
            oknobledow.Show();
            
        }

        private void wstecz_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            okno2.Visible = true;
        }
    }
}
