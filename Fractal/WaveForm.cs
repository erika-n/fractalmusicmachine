using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundLabBasics;
using System.Drawing;

namespace FractalProject

{
    class WaveForm
    {
        private SoundBuffer _soundBuffer;
        private Bitmap _image;
        private Color _foregroundColor;
        private Color _backgroundColor;

        public WaveForm(SoundBuffer buffer, int width, int height, Color foreground, Color background)
        {
            _image = new Bitmap(width, height);
            _soundBuffer = buffer;
            _foregroundColor = foreground;
            _backgroundColor = background;
            drawWaveForm();
        }

        private void drawWaveForm(){
            using (Graphics g = Graphics.FromImage(_image))
            {

                Brush brush = new SolidBrush(_backgroundColor);
                g.FillRectangle(brush, new Rectangle(0, 0, _image.Width, _image.Height));

                using (Pen p = new Pen(_foregroundColor))
                {
                    float yMiddle = _image.Height / 2;
                    int numPoints = Math.Min(1000, _soundBuffer.Length);
                    int step = _soundBuffer.Length / numPoints;

                    for (int i = 0; i < _soundBuffer.Length; i+= step)
                    {
                        float x = _image.Width * i / _soundBuffer.Length;
                        float y = (float)(yMiddle - ((_soundBuffer.ReadLeft(i) + _soundBuffer.ReadRight(i))/2) * yMiddle);
                        g.DrawLine(p, new PointF(x, yMiddle), new PointF(x, y));
                    }
                }
                
            }
        }

        public Bitmap GetImage(){return _image;}
    }
}
