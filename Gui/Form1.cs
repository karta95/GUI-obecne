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
using System.Drawing.Drawing2D;
using System.IO;

namespace Gui
{
    public partial class Form1 : Form
    {

        int ilescrolii = 0;
        oknokonf1 _okno1;
        Graphics drawarea;
        Graphics drawarea2;

        //---------Zmienne do zaznaczania wykresu-------------
        int start;
        int end;
        int width;
        int height;
        int x;
        int y;
        private Rectangle _rect;
        private StripLine _line;
       
        double maxvalue ;
        double maxpixel;
        double minvalue;
        double minpixel;
        double tmp_minpixel;
        double tmp_maxpixel;
        int cursor_postion;
        //----------------------------------------------------

        public Form1()
        {
            
            InitializeComponent() ;
            drawarea = wykres1.CreateGraphics();
            drawarea2 = wykres2.CreateGraphics();
            this.wykres1.MouseWheel += Wykres1_MouseWheel;
            this.wykres2.MouseWheel += Wykres2_MouseWheel;
            this.wykres3.MouseWheel += Wykres3_MouseWheel;
          
           
            double osOY = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum - wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
            Button pokaz_button = new Button();
         

            
            for (int i = 0; i < 10; i++)
            {
                wynikiSzczegolowe.Rows.Add(i, i+3, "Pokaż");
            }

            for (int i = 0; i < wynikiSzczegolowe.Rows.Count; i++)
            {   
               
            }

             for (double i = 0; i < 5; i += 0.01)
            {
                wykres1.Series[0].Points.AddXY(i, 3 * i);
            }

            for (double i = 0; i < 5; i += 0.01)
            {
                wykres2.Series[0].Points.AddXY(i, 3*i);
            }

            for (double i = 0; i < 5; i += 0.01)
            {
                wykres3.Series[0].Points.AddXY(i, -2*i);
            }
        }

       

        private void Form1_Resize(object sender, EventArgs e)
        {
            int wysokosc = tabPage1.Height / 3;
            int szerokosc = tabPage1.Width;
            wykres1.Height = wysokosc;
            wykres1.Width = szerokosc;
            wykres1.Location = new Point(0, 0);
            wykres2.Height = wysokosc;
            wykres2.Width = szerokosc;
            wykres2.Location = new Point(0, wysokosc);
            wykres3.Height = wysokosc;
            wykres3.Width = szerokosc;
            wykres3.Location = new Point(0, 2 * wysokosc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int wysokosc = tabPage1.Height / 3;
            int szerokosc = tabPage1.Width;
            wykres1.Height = wysokosc;
            wykres1.Width = szerokosc;
            wykres1.Location = new Point(0, 0);
            wykres2.Height = wysokosc;
            wykres2.Width = szerokosc;
            wykres2.Location = new Point(0, wysokosc);
            wykres3.Height = wysokosc;
            wykres3.Width = szerokosc;
            wykres3.Location = new Point(0, 2 * wysokosc);
            
        }
      



        //---------------ZOOMOWANIE------------------------------------
        private void Wykres1_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {

                if (e.Delta < 0 && ilescrolii > 0)
                {
                    ilescrolii = ilescrolii - 1;
                    if (ilescrolii == 0)
                    {
                        wykres1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                        wykres2.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                        wykres3.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                        return;
                    }
                    double xMin = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMaximum;


                    double posXStart = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) * 2;
                    double posXFinish = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) * 2;

                    wykres1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres3.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                   
                }


                if (e.Delta > 0)
                {
                    ilescrolii = ilescrolii + 1;

                    double xMin = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMaximum;
                    
                    double posXStart = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 2;
                    double posXFinish = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 2;

                    wykres1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres3.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                }


            }
            catch { }

        }
        private void Wykres2_MouseWheel(object sender, MouseEventArgs e)
        {
           
            try
            {
                
                if (e.Delta < 0 && ilescrolii >0)
                {
                    ilescrolii = ilescrolii -1;
                    if (ilescrolii == 0)
                    {
                        wykres1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                        wykres2.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                        wykres3.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                        return;
                    }
                    double xMin = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMaximum;
                   

                    double posXStart = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) * 2;
                    double posXFinish = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) * 2;

                    wykres1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres3.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                }
               

                if (e.Delta > 0)
                {
                    ilescrolii = ilescrolii + 1;
                   
                    double xMin = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                    double posXStart = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin)/2;
                    double posXFinish = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin)/2 ;

                    wykres1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres3.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                }

               
            }
            catch { }

        }

        private void Wykres3_MouseWheel(object sender, MouseEventArgs e)
        {

            try
            {

                if (e.Delta < 0 && ilescrolii > 0)
                {
                    ilescrolii = ilescrolii - 1;
                    if (ilescrolii == 0)
                    {
                        wykres1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                        wykres2.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                        wykres3.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                        return;
                    }
                    double xMin = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMaximum;


                    double posXStart = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) * 2;
                    double posXFinish = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) * 2;

                    wykres1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres3.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                }


                if (e.Delta > 0)
                {
                    ilescrolii = ilescrolii + 1;

                    double xMin = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = wykres2.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                    double posXStart = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 2;
                    double posXFinish = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 2;

                    wykres1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    wykres3.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                }


            }
            catch { }
        }

        //------------KONIEC Zoomowania-----------------------------

        private void Analizabutton_Click(object sender, EventArgs e)
        {
            /*if(_okno1 == null)
                _okno1 = new oknokonf1();*/
            /* _okno1 = _okno1 ?? new oknokonf1();*/

        
            _okno1 = new oknokonf1(this,toolStripTextBox1.Text, toolStripTextBox2.Text);
            _okno1.ShowDialog();
        }
                             
        //---------------WYKRES 1-----------------------------------

        private void wykres1_MouseHover(object sender, EventArgs e)
        {
            wykres1.Focus();

           // var pos = wykres1.PointToClient(MousePosition);

           // if (wykres1.ChartAreas[0].AxisX.ScaleView.IsZoomed )
           // {

           //     //MessageBox.Show(cursor_postion.ToString());
           //     if (cursor_postion>= tmp_minpixel && cursor_postion < tmp_maxpixel)
           //     {
           //        // MessageBox.Show("czemu:(");
           //         wykres1.ChartAreas[0].AxisX.ScaleView.Position -= 0.01;
           //     }

           // }
           //// MessageBox.Show(pos.ToString());


        }

      

        private void wykres1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.X;
            double max_yvalue = wykres1.ChartAreas[0].AxisY.Maximum;
            double max_ypixel = wykres1.ChartAreas[0].AxisY.ValueToPixelPosition(max_yvalue);
            maxvalue = wykres1.ChartAreas[0].AxisX.Maximum;
            maxpixel = wykres1.ChartAreas[0].AxisX.ValueToPixelPosition(maxvalue);
            minvalue = wykres1.ChartAreas[0].AxisX.Minimum;
            minpixel = wykres1.ChartAreas[0].AxisX.ValueToPixelPosition(minvalue);
            y = Convert.ToInt32(max_ypixel);

           

        }

        private void wykres1_MouseUp(object sender, MouseEventArgs e)
        {
            end = e.X; 
        }


        private void wykres1_MouseMove(object sender, MouseEventArgs e)
        {
            cursor_postion = e.X;
            if (start < minpixel || start > maxpixel)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                x = Math.Min(start, e.X);
                                
                if (e.X >= minpixel && e.X <= maxpixel)
                {
                    if (e.Y >= wykres1.ChartAreas[0].AxisY.ValueToPixelPosition(wykres1.ChartAreas[0].AxisY.Minimum))
                    {
                       return;
                    }
                                       

                    if (wykres1.ChartAreas[0].AxisX.ScaleView.IsZoomed  )
                    {
                        
                        tmp_minpixel = wykres1.ChartAreas[0].AxisX.ValueToPixelPosition(wykres1.ChartAreas[0].AxisX.ScaleView.ViewMinimum);
                        tmp_maxpixel = wykres1.ChartAreas[0].AxisX.ValueToPixelPosition(wykres1.ChartAreas[0].AxisX.ScaleView.ViewMaximum);
                       //MessageBox.Show(wykres1.ChartAreas[0].AxisX.ScaleView.ViewMaximum.ToString());
                        if (e.X <tmp_minpixel || e.X> tmp_maxpixel)
                        {
                           return;
                        }
                        if (e.X >= tmp_minpixel && e.X < tmp_minpixel + 40)
                        {
                            
                            wykres1.ChartAreas[0].AxisX.ScaleView.Position -= 0.01;
                            wykres2.ChartAreas[0].AxisX.ScaleView.Position -= 0.01;
                            wykres3.ChartAreas[0].AxisX.ScaleView.Position -= 0.01;
                        }
                        if (e.X >= tmp_maxpixel-40 && e.X <= tmp_maxpixel)
                        {

                            wykres1.ChartAreas[0].AxisX.ScaleView.Position += 0.01;
                            wykres2.ChartAreas[0].AxisX.ScaleView.Position += 0.01;
                            wykres3.ChartAreas[0].AxisX.ScaleView.Position += 0.01;
                        }

                    }

                    width = Math.Max(start, e.X) - Math.Min(start, e.X);
                    height = Convert.ToInt32(wykres1.ChartAreas[0].AxisY.ValueToPixelPosition(wykres1.ChartAreas[0].AxisY.Minimum));
                    _rect = new Rectangle(x, y, width, height - y);

                    Refresh();
                    Pen pen = new Pen(Color.Red, 2);
                    pen.DashStyle = DashStyle.Dash;

                    toolStripTextBox1.Text = wykres1.ChartAreas[0].AxisX.PixelPositionToValue(x).ToString();
                    toolStripTextBox2.Text = wykres1.ChartAreas[0].AxisX.PixelPositionToValue(x+width).ToString();

                   

                    /*if (_okno1 != null && !_okno1.Visible)
                    {
                        _okno1.BeginPoint = wykres1.ChartAreas[0].AxisX.PixelPositionToValue(x);
                        _okno1.EndPoint = wykres1.ChartAreas[0].AxisX.PixelPositionToValue(x + width);
                        _okno1.ShowMe();
                    }*/
                        

                }

            }
        }

        private void wykres1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            pen.DashStyle = DashStyle.Dash;
            e.Graphics.DrawRectangle(pen, _rect);
            
        }


        //--------------------WYKRES 2 ---------------------------------------


        private void wykres2_MouseHover(object sender, EventArgs e)
        {
            wykres2.Focus();
        }

       
        private void wykres2_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.X;
            double max_yvalue = wykres2.ChartAreas[0].AxisY.Maximum;
            double max_ypixel = wykres2.ChartAreas[0].AxisY.ValueToPixelPosition(max_yvalue);
            maxvalue = wykres2.ChartAreas[0].AxisX.Maximum;
            maxpixel = wykres2.ChartAreas[0].AxisX.ValueToPixelPosition(maxvalue);
            minvalue = wykres2.ChartAreas[0].AxisX.Minimum;
            minpixel = wykres2.ChartAreas[0].AxisX.ValueToPixelPosition(minvalue);
            y = Convert.ToInt32(max_ypixel);
        }

        private void wykres2_MouseUp(object sender, MouseEventArgs e)
        {
            end = e.X;
        }


        private void wykres2_MouseMove(object sender, MouseEventArgs e)
        {
            cursor_postion = e.X;
            if (start < minpixel || start > maxpixel)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                x = Math.Min(start, e.X);

                if (e.X >= minpixel && e.X <= maxpixel)
                {
                    if (e.Y >= wykres2.ChartAreas[0].AxisY.ValueToPixelPosition(wykres2.ChartAreas[0].AxisY.Minimum))
                    {
                        return;
                    }


                    if (wykres1.ChartAreas[0].AxisX.ScaleView.IsZoomed)
                    {

                        tmp_minpixel = wykres2.ChartAreas[0].AxisX.ValueToPixelPosition(wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum);
                        tmp_maxpixel = wykres2.ChartAreas[0].AxisX.ValueToPixelPosition(wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum);
                        //MessageBox.Show(wykres1.ChartAreas[0].AxisX.ScaleView.ViewMaximum.ToString());
                        if (e.X < tmp_minpixel || e.X > tmp_maxpixel)
                        {
                            return;
                        }
                        if (e.X >= tmp_minpixel && e.X < tmp_minpixel + 40)
                        {

                            wykres1.ChartAreas[0].AxisX.ScaleView.Position -= 0.01;
                            wykres2.ChartAreas[0].AxisX.ScaleView.Position -= 0.01;
                            wykres3.ChartAreas[0].AxisX.ScaleView.Position -= 0.01;
                        }
                        if (e.X >= tmp_maxpixel - 40 && e.X <= tmp_maxpixel)
                        {

                            wykres1.ChartAreas[0].AxisX.ScaleView.Position += 0.01;
                            wykres2.ChartAreas[0].AxisX.ScaleView.Position += 0.01;
                            wykres3.ChartAreas[0].AxisX.ScaleView.Position += 0.01;
                        }

                    }

                    width = Math.Max(start, e.X) - Math.Min(start, e.X);
                    height = Convert.ToInt32(wykres1.ChartAreas[0].AxisY.ValueToPixelPosition(wykres2.ChartAreas[0].AxisY.Minimum));
                    _rect = new Rectangle(x, y, width, height - y);

                    Refresh();
                    Pen pen = new Pen(Color.Red, 2);
                    pen.DashStyle = DashStyle.Dash;

                    toolStripTextBox1.Text = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(x).ToString();
                    toolStripTextBox2.Text = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(x + width).ToString();



                    /*if (_okno1 != null && !_okno1.Visible)
                    {
                        _okno1.BeginPoint = wykres1.ChartAreas[0].AxisX.PixelPositionToValue(x);
                        _okno1.EndPoint = wykres1.ChartAreas[0].AxisX.PixelPositionToValue(x + width);
                        _okno1.ShowMe();
                    }*/


                }

            }
        }


        private void wykres2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            pen.DashStyle = DashStyle.Dash;
            e.Graphics.DrawRectangle(pen, _rect);
        }


      
        
        //-------------------WYKRES 3 ------------------------------------------------

        private void wykres3_MouseHover(object sender, EventArgs e)
        {
            wykres3.Focus();

        }

        private void wykres3_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.X;
            double max_yvalue = wykres3.ChartAreas[0].AxisY.Maximum;
            double max_ypixel = wykres3.ChartAreas[0].AxisY.ValueToPixelPosition(max_yvalue);
            maxvalue = wykres3.ChartAreas[0].AxisX.Maximum;
            maxpixel = wykres3.ChartAreas[0].AxisX.ValueToPixelPosition(maxvalue);
            minvalue = wykres3.ChartAreas[0].AxisX.Minimum;
            minpixel = wykres3.ChartAreas[0].AxisX.ValueToPixelPosition(minvalue);
            y = Convert.ToInt32(max_ypixel);
        }

        private void wykres3_MouseUp(object sender, MouseEventArgs e)
        {
            end = e.X;
        }

        private void wykres3_MouseMove(object sender, MouseEventArgs e)
        {
            cursor_postion = e.X;
            if (start < minpixel || start > maxpixel)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                x = Math.Min(start, e.X);

                if (e.X >= minpixel && e.X <= maxpixel)
                {
                    if (e.Y >= wykres2.ChartAreas[0].AxisY.ValueToPixelPosition(wykres2.ChartAreas[0].AxisY.Minimum))
                    {
                        return;
                    }


                    if (wykres3.ChartAreas[0].AxisX.ScaleView.IsZoomed)
                    {

                        tmp_minpixel = wykres2.ChartAreas[0].AxisX.ValueToPixelPosition(wykres2.ChartAreas[0].AxisX.ScaleView.ViewMinimum);
                        tmp_maxpixel = wykres2.ChartAreas[0].AxisX.ValueToPixelPosition(wykres2.ChartAreas[0].AxisX.ScaleView.ViewMaximum);
                        //MessageBox.Show(wykres1.ChartAreas[0].AxisX.ScaleView.ViewMaximum.ToString());
                        if (e.X < tmp_minpixel || e.X > tmp_maxpixel)
                        {
                            return;
                        }
                        if (e.X >= tmp_minpixel && e.X < tmp_minpixel + 40)
                        {

                            wykres1.ChartAreas[0].AxisX.ScaleView.Position -= 0.01;
                            wykres2.ChartAreas[0].AxisX.ScaleView.Position -= 0.01;
                            wykres3.ChartAreas[0].AxisX.ScaleView.Position -= 0.01;
                        }
                        if (e.X >= tmp_maxpixel - 40 && e.X <= tmp_maxpixel)
                        {

                            wykres1.ChartAreas[0].AxisX.ScaleView.Position += 0.01;
                            wykres2.ChartAreas[0].AxisX.ScaleView.Position += 0.01;
                            wykres3.ChartAreas[0].AxisX.ScaleView.Position += 0.01;
                        }

                    }

                    width = Math.Max(start, e.X) - Math.Min(start, e.X);
                    height = Convert.ToInt32(wykres1.ChartAreas[0].AxisY.ValueToPixelPosition(wykres2.ChartAreas[0].AxisY.Minimum));
                    _rect = new Rectangle(x, y, width, height - y);

                    Refresh();
                    Pen pen = new Pen(Color.Red, 2);
                    pen.DashStyle = DashStyle.Dash;

                    toolStripTextBox1.Text = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(x).ToString();
                    toolStripTextBox2.Text = wykres2.ChartAreas[0].AxisX.PixelPositionToValue(x + width).ToString();



                    /*if (_okno1 != null && !_okno1.Visible)
                    {
                        _okno1.BeginPoint = wykres1.ChartAreas[0].AxisX.PixelPositionToValue(x);
                        _okno1.EndPoint = wykres1.ChartAreas[0].AxisX.PixelPositionToValue(x + width);
                        _okno1.ShowMe();
                    }*/


                }

            }
        }


        private void wykres3_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            pen.DashStyle = DashStyle.Dash;
            e.Graphics.DrawRectangle(pen, _rect);
         
           // e.Graphics.DrawLines

          

           
        }





        //---------------------TOOLTIPY---------------------------------------
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            SaveFileDialog windowSave = new SaveFileDialog();
            windowSave.ShowDialog();
            if (windowSave.FileName != "")
            {
                wykres1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                wykres2.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                wykres3.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                wykres1.SaveImage(windowSave.FileName + "1.png", ChartImageFormat.Png);
                wykres2.SaveImage(windowSave.FileName + "2.png", ChartImageFormat.Png);
                wykres3.SaveImage(windowSave.FileName + "3.png", ChartImageFormat.Png);
                MessageBox.Show("Wykresy zapisane pomyślnie!");
            }
          
        }

        public void ShowMe()
        {
            this.Visible = true;
        }
        private void wyświetlBrakiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var windowError = new oknobledow();
            windowError.ShowDialog();
            ShowMe();
        }

     

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oknowczytywania = new OpenFileDialog();
            oknowczytywania.ShowDialog();

            toolStripStatusLabel2.Text = oknowczytywania.FileName;
        }

     
        private void zapiszToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog oknozapisu = new SaveFileDialog();
            oknozapisu.ShowDialog();
        }

        private void wynikiSzczegolowe_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            var begin = double.Parse(toolStripTextBox1.Text);
            var end = double.Parse(toolStripTextBox2.Text);

            SaveFileDialog windowSave = new SaveFileDialog();
            windowSave.ShowDialog();
            if (windowSave.FileName != "")
            {
                SplitChart(wykres1, begin, end).SaveImage(windowSave.FileName + "_1" + ".png", ChartImageFormat.Png);
                SplitChart(wykres2, begin, end).SaveImage(windowSave.FileName + "_2" + ".png", ChartImageFormat.Png);
                SplitChart(wykres2, begin, end).SaveImage(windowSave.FileName + "_3" + ".png", ChartImageFormat.Png);
            }
        }

        private Chart SplitChart(Chart input, double begin, double end)
        {
            var stream = new MemoryStream();
            input.Serializer.Save(stream);

            var newChart = new Chart();
            newChart.Serializer.Load(stream);

            newChart.ChartAreas[0].AxisX.Interval = 0.1;
            newChart.ChartAreas[0].AxisX.Minimum = (int)begin;
            newChart.ChartAreas[0].AxisX.Maximum = Math.Round(end);

            newChart.Series[0].Points.Clear();
            var points = input.Series[0].Points.Where(p => p.XValue >= begin && p.XValue <= end).ToDictionary(t => t.XValue, t => t.YValues);
            foreach (var point in points)
                foreach (var value in point.Value)
                    newChart.Series[0].Points.AddXY(point.Key, value);

            return newChart;
        }

        private void wynikiSzczegolowe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
