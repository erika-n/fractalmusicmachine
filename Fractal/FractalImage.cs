using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using SoundLabBasics;
using System.IO;
using System.Diagnostics;

namespace FractalProject
{
   

    public class FractalImage:IDisposable
    {
        public static int MAX_ANIMATE_DEPTH = 3;
        public static Boolean ANIMATING = false;
       
        public const string VIDEO_FOLDER = @"C:\Users\Erika\Videos\FractalMusic\";
        private const int VIDEO_SIZE = 1080;
        private const float WIDTH_BUFFER = 0;
        private const float HEIGHT_BUFFER = 10;
        
        private Bitmap _image;
        private Bitmap _stillImage;
        private int _width;
        private int _height;
        private List<FractalRect> _score;
        private int _salt;
        private Boolean _starMode;
      //  private static Color BACKGROUND = Color.MidnightBlue;
        //private static Color FOREGROUND = Color.LightBlue;
        //private static Color HIGHLIGHT = Color.PaleGoldenrod;


       //private static Color FOREGROUND = Color.FromArgb(255, 230, 230, 230);

       
        //private static Color HIGHLIGHT = Color.Red;

       // private static Color BACKGROUND = Color.DarkGray;
      //  private static Color FOREGROUND = Color.LightGray;
      //  private static Color HIGHLIGHT = Color.Red;
        private static Color HIGHLIGHT = Color.Black;//Color.FromArgb(255, 0, 150, 0);
       private static Color SWEEPER = HIGHLIGHT;

       // Hazy blue theme
       private static Color BACKGROUND = Color.White;
       private static Color FOREGROUND = Color.FromArgb(255, 30, 30, 255);
       private static Color GRADIENT1 = Color.FromArgb(120, Color.Gray);//Color.FromArgb(200, 0, 33, 200);
       private static Color GRADIENT2 = Color.FromArgb(0, Color.LightGray);//Color.FromArgb(0, 255, 255, 255);



       private const int PEN_WIDTH = 10;
       private const int SWEEPER_WIDTH = 2;

       private double _baseFrequency;



       public const int SCORE = 0;
       public const int TRANSITION = 1;

        private static Color BOX_HIGHLIGHT = HIGHLIGHT;

        public FractalImage(int width, int height, double baseFrequency)
        {
            

            _width = width;
            _height = height;
            _score = new List<FractalRect>();
            _image = new Bitmap(_width, _height);
            _stillImage = null;
            _baseFrequency = baseFrequency;
            _salt = new Random().Next();
            _starMode = false;

        }

        public void Dispose()
        {
            if (_image != null) 
            {
                _image.Dispose();
            }
            if (_stillImage != null)
            {
                _stillImage.Dispose();
            }
            
        }

        private void drawBackground(Bitmap image)
        {
            
            using (Graphics g = Graphics.FromImage(image))
            {
                using (Brush brush = new SolidBrush(BACKGROUND))
                {
                    g.FillRectangle(brush, new Rectangle(0, 0, image.Width, image.Height));
                }
            }

           

        }



        public void add(FractalRect newRect)
        {   
            int scoreIndex = _score.FindIndex(x => newRect.start >= x.start);
            if (scoreIndex == -1)
            {
                scoreIndex = 0;
            }
            _score.Insert(scoreIndex, newRect);
        }

        public void draw(double start, double end, double ymin, double ymax, double freq, Boolean filled, double ypercent, double maxFreq, double minFreq, Bitmap image, Color color, double time=0, int depth = 1)
        {

            double yloc = ymin + (ymax - ymin) * ypercent;
            double ylocmax = ymax + (ymax - ymin) * ypercent;

            if (filled)
            {
                color = Color.FromArgb(150, color);
                if (_starMode)
                {
                    drawStar(freq, maxFreq, color, image, PEN_WIDTH, time, depth);
                }
            }

            if (!_starMode)
            {
                drawRect(start, end, yloc, ylocmax, color, image, PEN_WIDTH);
            }        

        }

        public void setStarMode(Boolean starMode)
        {
            _starMode = starMode;
            if (_starMode)
            {
                MAX_ANIMATE_DEPTH = 12;
            }
            else
            {
                MAX_ANIMATE_DEPTH = 3;
            }
        }

        private void drawStar(double freq, double ypercent, Color color, Bitmap image, int penWidth, double time, int depth)
        {
            Random rand = new Random((int)freq*_salt);
            const int THREES_COLS = 9;
            const int TWOS_ROWS = 9;
            
            int freqInt = (int) freq;
            int threes = 0;
            int twos = 0;
            // eight rows corresponding to octaves
            // nine columns corresponding to fifths
            while( freqInt % 3 == 0){
                freqInt = freqInt / 3;
                threes++;
            }
            freqInt = (int)freq;
            while((freqInt = freqInt /2) != 0){
                twos++;
            }

            //threes = threes % THREES_COLS;
            //twos = twos % TWOS_ROWS;

            double STAR_SIZE = 0.12;

            double start = 0.12 + threes * 0.8 / THREES_COLS; //0.8 * rand.NextDouble();//
            double end = start + time*STAR_SIZE;

        
            double yloc = 1 - (0.15 + (twos - depth) * 0.70 / TWOS_ROWS); //0.8 * rand.NextDouble(); //
            double ylocmax = yloc + time*STAR_SIZE;
  
            drawLine(start, end, yloc, ylocmax, color, image, penWidth, false, true);
        }

        private Boolean isAPowerOf(int number, int power)
        {
            while ((number = number % power) == 0 && number != 0) ;
            return number == 0;

        }


        private void drawLine(double start, double end, double ymin, double ymax, Color color, Bitmap image, int penWidth, Boolean rect = false, Boolean circle = false)
        {

            using (Graphics g = Graphics.FromImage(image))
            {
                // g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Pen p = new Pen(color))
                {

                    p.Width = penWidth;

                    int width = (int)(image.Width - 2 * WIDTH_BUFFER);
                    if (width < penWidth)
                    {
                        width = penWidth;
                    }
                    int height = (int)(image.Height - 2 * HEIGHT_BUFFER);
                    float x1 = (float)(WIDTH_BUFFER + (start * width));
                    float y1 = (float)(HEIGHT_BUFFER + (ymin * height));
                    float x2 = (float)(WIDTH_BUFFER + (end * width));
                    float y2 = (float)(HEIGHT_BUFFER + (ymax * height));

                    if (rect) 
                    {
                        using (Brush b = new SolidBrush(p.Color))
                        {
                            g.FillRectangle(b, x1, y1, x2 - x1, y2 - y1);
                            using (Pen border = new Pen(p.Color)) { 
                                border.Width = 1;
                                g.DrawRectangle(border, x1, y1, x2 - x1, y2 - y1);
                            }
                        }
                    }
                    else if (circle)
                    {
                        using (Brush b = new SolidBrush(p.Color))
                        {
                            // x1 y1 is the origin, so
                            // 
                            x1 = x1 - (x2 - x1) / 2;
                            y1 = y1 - (y2 - y1) / 2;
                            g.FillEllipse(b, x1, y1, x2 - x1, y2 - y1);
                        }
                    }
                    else {
                        g.DrawLine(p, x1, y1, x2, y2);
                    }

                }


            }
        }

        private void drawSweeper(double start, Bitmap newImage)
        {
            //drawLine(start - 0.01, start, 0, 1, SWEEPER, newImage, SWEEPER_WIDTH);
            start = _starMode ? 0 : start;
            drawGradientBackground(start, GRADIENT1, GRADIENT2, newImage);
        }

        private void drawGradientBackground(double where, Color color1, Color color2, Bitmap img)
        {
            if (where < 0)
            {
                where = 0;
            }
            using (Graphics g = Graphics.FromImage(img))
            {

                int pctWhere = (int)(where * img.Width);

                using (Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(new System.Drawing.Point((int)pctWhere, 0), new System.Drawing.Point((int)(pctWhere - (img.Width)), 0), color1, color2))
                {
                    g.FillRectangle(b, (int)pctWhere, 0, img.Width, img.Height);
                    g.FillRectangle(b, 0, 0, (int)pctWhere, img.Height);
                }
            }
           
        }
       
        private void drawRect(double start, double end, double ymin, double ymax, Color color, Bitmap image, int penWidth)
        {
            drawLine(start, end, ymin, ymax, color, image, penWidth, true);


        }

        public Bitmap animateTransition(double percent, int maxDepth)
        {
            if (maxDepth > MAX_ANIMATE_DEPTH || percent < 0)
            {
                return stillImage(maxDepth);
            }


            Bitmap image = new Bitmap(_width, _height); // _image;
            double maxFreq = 0;
            double minFreq = 1;
            

            foreach (FractalRect fr in _score)
            {
                if (fr.freq > maxFreq)
                {
                    maxFreq = fr.freq;
                }
                if (fr.freq < minFreq)
                {
                    minFreq = fr.freq;
                }
            }

            drawBackground(image);
            drawGradientBackground(percent, GRADIENT1, GRADIENT2, image);
            foreach (FractalRect fr in _score)
            {
                Boolean highlight = false; 
                if (Math.Abs(percent - fr.start) < 0.0001 || (percent > fr.start && percent < fr.end))
                {
                    highlight = true;
                }
                Color myColor =  Color.FromArgb((int)(255*(fr.soft)), Color.Firebrick);
                if (fr.depth == 1)
                {
                    //draw(fr.start, fr.end, fr.ymin, fr.ymax, fr.freq, false, 0, maxFreq, minFreq, image, Color.FromArgb((int)(255*(1-percent)), fr.color));
                    draw(fr.start, fr.end, fr.ymin, fr.ymax, fr.freq, false, 0, maxFreq, minFreq, image,myColor);
                
                }
                else if (fr.depth == 0)
                {
                    draw(fr.start, fr.end, fr.ymin, fr.ymax, fr.freq, highlight, 0, maxFreq, minFreq, image, myColor, Math.Abs(percent-fr.start)/(fr.end - fr.start));
                }
            }
            return image;
        }



        public Bitmap getScore(int depth)
        {
            return animateScore(-1, depth);
        }

        public Bitmap quickAnimateScore(double time, int maxDepth)
        {
            Bitmap newImage = new Bitmap(_stillImage);
            drawSweeper(time, newImage);
            
            return newImage;
        }


        public Bitmap stillImage(int maxDepth)
        {
            if (_stillImage == null)
            {
                _stillImage = animateScore(-1, maxDepth);
            }
            return new Bitmap(_stillImage);
        }


        public Bitmap animateScore(double time, int maxDepth)
        {
            return animateScoreSpecific(time, maxDepth, _width, _height);
        }


        public Bitmap animateScoreSpecific(double time, int maxDepth, int width, int height)
        {
            if (time < 0 && _stillImage != null) 
            {
                return new Bitmap(_stillImage);
            }
            if(time > -1 && (maxDepth > MAX_ANIMATE_DEPTH)){
                return quickAnimateScore(time, maxDepth);
            }

            Bitmap image = new Bitmap(width, height); //_image;
            Boolean toHighlight;
            
            drawBackground(image);
            drawSweeper(time, image);

            double maxFreq = 0;
            double minFreq = 1;
            foreach (FractalRect fr in _score)
            {
                if (fr.depth == 0 && fr.freq > maxFreq)
                {
                    maxFreq = fr.freq;
                }
                if (fr.depth == 0 && fr.freq < minFreq)
                {
                    minFreq = fr.freq;
                }
            }

            foreach (FractalRect fr in _score)
            {
                if (fr.depth == 0)
                {
                    toHighlight = (Math.Abs(time - fr.start) < 0.0001 || (time > fr.start && time < fr.end));
                    double peakTime = fr.start + (fr.end - fr.start) / 2;
                    double starTime = time > peakTime ? Math.Abs(time - fr.end) / (fr.end - fr.start) : Math.Abs(time - fr.start) / (fr.end - fr.start);
                    Color myColor = Color.FromArgb((int)(255 * (fr.soft)), Color.Firebrick);
                    draw(fr.start, fr.end, fr.ymin, fr.ymax, fr.freq, toHighlight, 0, maxFreq, minFreq, image, myColor, starTime, maxDepth);       
                }
            }
            if (time < 0)
            {
                _stillImage = image;
            }
            return image;
        }


        public void dumpScoreAnimationFrames(string fileName, double frameRate, double seconds, int maxDepth, int type = 0 )
        {
            

            int saveMaxAnimateDepth = MAX_ANIMATE_DEPTH;
            MAX_ANIMATE_DEPTH = 10;
            clearDirectory(VIDEO_FOLDER);
            int numFrames = (int) (frameRate*seconds);
            double percentPerFrame = (double)1/numFrames;
            for (int imageNum = 0; imageNum <= numFrames; imageNum++)
            {
                double time = (double)imageNum * percentPerFrame;
                
                Bitmap frame;
                if (type == TRANSITION)
                {
                    frame = animateTransition(time, maxDepth);
                }
                else
                {
                    frame = animateScoreSpecific(time, maxDepth, VIDEO_SIZE, VIDEO_SIZE);
                }
                string imageNumStr = "" + imageNum;
                while (imageNumStr.Length < 6)
                {
                    imageNumStr = "0" + imageNumStr;
                }
                // to use: ffmpeg -i image_%06d.png -c:v libx264 -pix_fmt yuv420p out.mp4

                frame.Save(VIDEO_FOLDER + "\\image_" + imageNumStr + ".png", System.Drawing.Imaging.ImageFormat.Png);
                frame.Dispose();
                System.GC.Collect();
            }
            Bitmap image = animateScoreSpecific(-1, maxDepth, VIDEO_SIZE, VIDEO_SIZE);
            image.Save(FractalImage.VIDEO_FOLDER + fileName + "_still.png");
            _image = new Bitmap(_width, _height);
            MAX_ANIMATE_DEPTH = saveMaxAnimateDepth;

            System.Diagnostics.Process.Start("C:\\Users\\Erika\\Videos\\FractalMusic\\makevideo.bat", fileName);

        }

        private void clearDirectory(string directory)
        {
            System.IO.DirectoryInfo downloadedMessageInfo = new DirectoryInfo(directory);

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                if(!file.Name.EndsWith(".bat") && !file.Name.EndsWith(".wav") && !file.Name.EndsWith(".avi") && !file.Name.EndsWith(".mp3") && !file.Name.Equals("Thumbs.db")){
                    file.Delete();
                }
                
            }
        }

    }





    public class FractalRect
    {
        public double start, end, ymin, ymax, freq, soft;
        public int depth;
        public FractalRect parent;
        public Color color;

        public FractalRect(double start, double end, double ymin, double ymax, int depth, FractalRect parent, double freq, Color color, double soft){
            if (start > end)
            {
                double tmp = end;
                end = start;
                start = tmp;
            }
            
            this.start = start;
            this.end = end;
            this.color = color;
            
            this.ymin = ymin;
            this.ymax = ymax;
            this.depth = depth;
            this.parent = parent;
            this.freq = freq;
            this.soft = soft;

        }

        public FractalRect Clone()
        {
            return new FractalRect(this.start, this.end, this.ymin, this.ymax, this.depth, this.parent, this.freq, this.color, this.soft);
        }

    }
}
