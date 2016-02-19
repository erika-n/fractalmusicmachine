using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundLabBasics;
using System.Drawing;

namespace SoundLabUI
{
    class WaveForm
    {
        private SoundBuffer _soundBuffer;
        private Bitmap _image;

        public WaveForm(SoundBuffer buffer, int width, int height)
        {
            _image = new Bitmap(width, height);
            _soundBuffer = buffer;
            drawWaveForm();
        }

        private void drawWaveForm(){
            using (Graphics g = Graphics.FromImage(_image))
            {
                Color backgroundColor = Color.FromArgb(255, 100, 100, 100);
                Brush brush = new SolidBrush(backgroundColor);
                g.FillRectangle(brush, new Rectangle(0, 0, _image.Width, _image.Height));

                using (Pen p = new Pen(Color.Black))
                {
                    float yMiddle = _image.Height / 2;

                    int numSteps = Math.Min(10000, _soundBuffer.Length);
                    int step = _soundBuffer.Length / numSteps;

                    for (int i = 0; i < _soundBuffer.Length; i+= step)
                    {
                        float x = _image.Width * i / _soundBuffer.Length;
                        float y = (float)(yMiddle - (_soundBuffer.ReadLeft(i)+_soundBuffer.ReadRight(i)) * yMiddle);
                        g.DrawLine(p, new PointF(x, yMiddle), new PointF(x, y));
                    }
                }
                
            }
        }

        public Bitmap GetImage(){return _image;}
    }
}
