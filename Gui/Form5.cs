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
        private readonly oknokonf2 _prev;
        private readonly oknokonf1 _rangeWindow;
        oknobledow oknobledow = new oknobledow();
       
        public oknokonf4(oknokonf2 prev, oknokonf1 rangeWindow)
        {
            InitializeComponent();
            _prev = prev;
            _rangeWindow = rangeWindow;
        }

        private void rozpocznij_button_Click(object sender, EventArgs e)
        {
           /* oknobledow = new oknobledow();
            this.Visible = false;
            oknobledow.Show();*/
        }

        private void wstecz_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oknokonf4_Load(object sender, EventArgs e)
        {
            _prev.HideMe();
        }
    }
}
