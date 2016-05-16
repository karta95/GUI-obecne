using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class oknokonf1 : Form
    {
        private readonly Form1 _prev;
        private string _beginPoint;
        private string _endPoint;

        public string BeginPoint
        {
            get { return _beginPoint; }
            set
            {
                _beginPoint = value;
                poczatek.Text = _beginPoint.ToString(CultureInfo.InvariantCulture);
            }
        }

        //public bool IsSelectedAll
        //{
        //    get { return radioButton1.Checked; }
        //}

        public string EndPoint
        {
            get { return _endPoint; }
            set
            {
                _endPoint = value;
                koniec.Text = _endPoint.ToString(CultureInfo.InvariantCulture);
            }
        }


        public oknokonf1(Form1 prev, string start, string stop)
        {
            InitializeComponent();
            _prev = prev;
            BeginPoint = start;
            EndPoint = stop;
        }

        public void HideMe()
        {
            this.Visible = false;
        }

        public void ShowMe()
        {
            this.Visible = true;
        }

 
        private void Dalej_button_Click(object sender, EventArgs e)
        {
            var nextStep = new oknokonf2(this);
            nextStep.ShowDialog();
            ShowMe();
        }

        private void Anuluj_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            poczatek.Enabled = false;
            koniec.Enabled = false;
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            poczatek.Enabled = true;
            koniec.Enabled = true;
        }
    }
}
