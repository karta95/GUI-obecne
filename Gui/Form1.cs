using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Gui
{
    public partial class Form1 : Form
    {
        WykresPanel nowywykres;
        int ilescrolii = 0;
        oknokonf1 okno1 = new oknokonf1();
        
        public Form1()
        {
            
            InitializeComponent() ;
            this.wykres2.MouseWheel += Wykres2_MouseWheel;
            this.MouseWheel += Form1_MouseWheel;
              double osOY = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum - wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
            //nowywykres = new WykresPanel();
            //nowywykres.Height = tabPage1.Height / 3;
            //nowywykres.Width = tabControl1.Width;
            //nowywykres.Location = new Point(0,0);
            //nowywykres.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            //tabPage1.Controls.Add(nowywykres);
            
            wykres2.Height = tabPage1.Height / 3;
            wykres2.Location = new Point(0, tabPage1.Height / 3);
            wykres3.Height = tabPage1.Height / 3;
            wykres3.Location = new Point(0, 2*tabPage1.Height / 3);

            //for (double i = 0; i < 2 * Math.PI; i += 0.01)
            //{
            //    wykres1.Series[0].Points.AddXY(i, (-2) * Math.Cos(i));
            //}

            DateTime data = Convert.ToDateTime("12-02-2012 00:12:23");
            DateTime data2 = Convert.ToDateTime("12-02-2013 00:12:27");
            //wykres1.Series[0].Points.AddXY(data, 50);
            //wykres1.Series[0].Points.AddXY(data2, 55);

            //wykres1.ChartAreas[0].CursorX.IsUserEnabled = true;
            //wykres1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            //wykres1.ChartAreas[0].CursorY.IsUserEnabled = true;
            //wykres1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            //chart1.ChartAreas.Add(chartArea1);
          
            for (double i = 0; i < 5; i += 0.01)
            {
                wykres2.Series[0].Points.AddXY(i, 3*i);
            }

            for (double i = 0; i < 5; i += 0.01)
            {
                wykres3.Series[0].Points.AddXY(i, -2*i);
            }
            
           
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {

            //try
            //{

            //    if (e.Delta < 0)
            //    {
            //        ilescrolii -= 1;
            //        double xMin = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
            //        double xMax = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
            //        double yMin = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
            //        double yMax = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMaximum;
            //        //if (ilescrolii == 0)
            //        //{
            //        //    wykres2.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            //        //    wykres2.ChartAreas[0].AxisY.ScaleView.ZoomReset();
            //        //    return;
            //        //}

            //        double posXStart = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) * 2;
            //        double posXFinish = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) * 2;
            //        double posYStart = wykres2.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y)  - (yMax - yMin) * 2;
            //        double posYFinish = wykres2.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) * 2;

            //        wykres2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
            //        wykres2.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
            //    }


            //    if (e.Delta > 0)
            //    {
            //        ilescrolii += 1;
            //        double xMin = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
            //        double xMax = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
            //        double yMin = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
            //        double yMax = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

            //        double posXStart = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 2;
            //        double posXFinish = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 2;
            //        double posYStart = wykres2.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 2;
            //        double posYFinish = wykres2.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 2;

            //        wykres2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
            //        wykres2.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
            //    }
            //}
            //catch { }

        }

        private double zwrocosOX()
        {
            double osOX = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum - wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
            return osOX;
        }
        private void Wykres2_MouseWheel(object sender, MouseEventArgs e)
        {
            double osOX = zwrocosOX();

            try
            {
                //WYKRES2-zoom
                if (e.Delta < 0)
                {
                   
                    double xMin = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMaximum;
                    //if (osOX==(xMax-xMin))
                    //{
                    //    wykres2.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    //   // wykres2.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                    //    return;
                    //}
                    
                    double posXStart = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) * 2;
                    double posXFinish = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) * 2;
                   // double posYStart = wykres2.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) * 2;
                    //double posYFinish = wykres2.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) * 2;

                    wykres2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                   // wykres2.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }
               

                if (e.Delta > 0)
                {
                    ilescrolii += 1;
                    double xMin = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                    double posXStart = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin)/2;
                    double posXFinish = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin)/2 ;
                    //double posYStart = wykres2.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin)/2 ;
                    //double posYFinish = wykres2.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin)/2;

                    wykres2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                  //  wykres2.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }

                //WYKRES3-zoom
                if (e.Delta < 0)
                {
                    double xMin = wykres3.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = wykres3.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = wykres3.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = wykres3.ChartAreas[0].AxisY.ScaleView.ViewMaximum;
                    //if (ilescrolii == 0)
                    //{
                    //    wykres2.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    //    wykres2.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                    //    return;
                    //}

                    double posXStart = wykres3.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) * 2;
                    double posXFinish = wykres3.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) * 2;
                    //double posYStart = wykres3.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) * 2;
                    //double posYFinish = wykres3.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) * 2;

                    wykres3.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                  //  wykres3.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }


                if (e.Delta > 0)
                {
                    ilescrolii += 1;
                    double xMin = wykres3.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = wykres3.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = wykres3.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = wykres3.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                    double posXStart = wykres3.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 2;
                    double posXFinish = wykres3.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 2;
                    //double posYStart = wykres3.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 2;
                    //double posYFinish = wykres3.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 2;

                    wykres3.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    //wykres3.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

             
       
       
        private void Analizabutton_Click(object sender, EventArgs e)
        {
            okno1 = new oknokonf1();
            okno1.Show();
        }

        

        private void wykres1_Resize(object sender, EventArgs e)
        {
            int wysokosc = tabPage1.Height / 3;
            int szerokosc = tabPage1.Width;
            //nowywykres.Height =wysokosc ;
            //nowywykres.Width = szerokosc;
            //nowywykres.Location = new Point(0, 0);
            wykres2.Height = wysokosc;
            wykres2.Width = szerokosc;
            wykres2.Location = new Point(0, wysokosc);
            wykres3.Height = wysokosc;
            wykres3.Width = szerokosc;
            wykres3.Location = new Point(0, 2 *wysokosc);
        }

        private void wykres1_MouseClick_1(object sender, MouseEventArgs e)
        {
            Point mousePoint = new Point(e.X, e.Y);

            okno1.wlasciwosc = mousePoint.X.ToString();
        }

        

        private void wykres2_MouseHover(object sender, EventArgs e)
        {
            wykres2.Focus();
            
        }

        private void wykres2_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePoint = new Point(e.X, e.Y);
            
        }
    }
}
