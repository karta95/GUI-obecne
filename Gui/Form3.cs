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
        private readonly oknokonf1 _prev;

        public oknokonf2(oknokonf1 prev)
        {
            InitializeComponent();
            _prev = prev;
        }

        public object SelectedProfile
        {
            get
            {
                return llistaprofili_listBox.SelectedItem != null ? llistaprofili_listBox.SelectedItem.ToString() : "Brak wybranego profilu";
            }
        }


        private void dodajprofil_button_Click(object sender, EventArgs e)
        {
            var profileWindow = new oknokonf3(this);
            if (profileWindow.ShowDialog() == DialogResult.Yes)
            {
                llistaprofili_listBox.Items.Add(profileWindow.NewProfileName);
                var newParameters = profileWindow.NewProfiles;
            }
            ShowMe();
        }

        private void wstecz_button_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void dalej_button_Click(object sender, EventArgs e)
        {
            var nextStep = new oknokonf4(this, this._prev);
            nextStep.ShowDialog();
            ShowMe();
        }

        private void llistaprofili_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = llistaprofili_listBox.SelectedIndex;
            string selectedText = llistaprofili_listBox.Items[selected].ToString();

            IListaProfili listaProfili = new ListaProfiliFake();
            listaparametro_listBox.Items.Clear();
            foreach (string parametr in listaProfili.PobierzListeProfili(selectedText))
            {
                listaparametro_listBox.Items.Add(parametr);
            }
        }

        public interface IListaProfili
        {
            /// <summary>
            /// Ta metoda ma zwracać listę parametrów dla profilu w 
            /// zależności od nazwy profilu podanego w parametrze.
            /// </summary>
            /// <param name="nazwaProfilu">Nazwa profilu dla którego zostaną zwrócone parametry.</param>
            /// <returns>Kolekcja parametrów dla odpowiedniego profilu.</returns>
            List<string> PobierzListeProfili(string nazwaProfilu);

            void StworzNowyProfil();
        }

        public class ListaProfiliFake : IListaProfili
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="nazwaProfilu"></param>
            /// <returns></returns>
            public List<string> PobierzListeProfili(string nazwaProfilu)
            {
                switch (nazwaProfilu)
                {
                    case "Profil1": return new List<string>() { "P1", "P2", "P3" };
                    case "Profil2": return new List<string>() { "P4" };
                    default:
                        return new List<string>();
                }
            }

            public void StworzNowyProfil()
            {
                throw new NotImplementedException();
            }
        }

        private void oknokonf2_Load(object sender, EventArgs e)
        {
            _prev.HideMe();
        }


        public void HideMe()
        {
            this.Visible = false;
        }

        public void ShowMe()
        {
            this.Visible = true;
        }
    }
}
