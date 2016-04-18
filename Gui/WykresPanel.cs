using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Gui
{
    class WykresPanel:Panel
    {
        Color kolorTla = Color.Aqua;
        double przyblizenie = 1;

        Label osOx1;

        public WykresPanel ():base()
        {
            osOx1 = new Label();
           this.Controls.Add(osOx1);

            osOx1.Text = "00";
            osOx1.Height = 15;
            BackColor = kolorTla;
        }

        public void RysujOsie(PaintEventArgs e)
        {
            Pen linecolor = new Pen(Color.Black, 2);
            
            e.Graphics.DrawLine(linecolor, new Point(20, 5), new Point(20, 160));
            e.Graphics.DrawLine(linecolor, new Point(20, 80), new Point(400, 80));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            RysujOsie(e);
            Przerysuj(e);
            base.OnPaint(e);
        }

        protected void Przerysuj(PaintEventArgs e)
        {
            Pen linecolor = Pens.Black;
            
            e.Graphics.DrawLine(linecolor, new Point(10, 10), new Point( Convert.ToInt32(30 * przyblizenie),  Convert.ToInt32(100 * przyblizenie)));
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (e.Delta > 0)
                przyblizenie += 0.1;
            else if (e.Delta < 0)
                przyblizenie -= 0.1;

            Refresh();

            base.OnMouseWheel(e);
        }

    }

}
