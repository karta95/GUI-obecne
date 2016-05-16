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
    public partial class oknokonf3 : Form
    {
        public string NewProfileName
        {
            get { return nazwaprofilu_textBox.Text; }
        }

        public DataGridViewRowCollection NewProfiles
        {
            get { return dataGridViewParametry.Rows; }
        }

        private readonly oknokonf2 _prev;

        public oknokonf3(oknokonf2 prev)
        {
            _prev = prev;
            InitializeComponent();
        }
        public void HideMe()
        {
            this.Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            _prev.HideMe();
        }

        private void zapiszprofil_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        int nrParametru = 0;

        private void buttonDodajParametr_Click(object sender, EventArgs e)
        {
            string parametrName = parametr1_textBox.Text;
            dataGridViewParametry.Rows.Add(nrParametru, parametrName);
            nrParametru++;
        }

      
    }
}
