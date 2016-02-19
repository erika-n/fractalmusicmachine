using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoundLabBasics;
using FractalProject;
using System.Media;
using System.Diagnostics;
using System.IO;

namespace SoundLabUI
{
    public partial class Form1 : Form
    {
        static int TRANSITION_TIME = 1;

        
        private WaveForm _waveForm;
        private Fractal _fractal;
        private string _soundFile = "fractal.wav";
        private string _presetFile = "birds";
        private System.Timers.Timer _timer;
        private static double TIMER_INTERVAL = 25.0;
        private double _totalTime;
        private Stopwatch _stopWatch;
        private SoundPlayer _sound;
        private Boolean _scoreAnimating;
        private Boolean _transitionAnimating;
        private FractalPresets _fractalVariables;

        public Form1()
        {

            InitializeComponent();


            _fractalVariables = Fractal.samplePresets();
  

            _fractalVariables.transformations = Fractal.sampleTransformations();
            loadFractal();

            _scoreAnimating = false;

        }

        private void loadFractal()
        {
            if (_scoreAnimating|| _transitionAnimating)
            {
               stopAnimation();
            }

            //FractalPresets.Save(_presets, _presetFile);

            _fractal = new Fractal(_fractalVariables);
            _fractal.run();

            WavFile.Save("fractal.wav", _fractal.getSound());
            _fractal.getScore();

            _totalTime = _fractal.getSound().getMilliseconds();
            _waveForm = new SoundLabUI.WaveForm(SoundLabBasics.WavFile.Open(_soundFile), waveFormBox.Width, waveFormBox.Height);
  
        }

  


        private void Form1_Load(object sender, EventArgs e)
        {
            
            waveFormBox.Image = _waveForm.GetImage();
            fractalBox.Image = _fractal.getScore();
            generatedLabel.Visible = false;
            loadTextBoxes(_fractalVariables);
            loadPresetComboBox();

            this.WindowState = FormWindowState.Maximized;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
           
        }

        private void loadTransformationsFromPresets(Transformation[] transformations)
        {
            TextBox[] startTextBoxes = { s0TextBox, s1TextBox, s2TextBox, s3TextBox, s4TextBox, s5TextBox };
            TextBox[] endTextBoxes = { e0TextBox, e1TextBox, e2TextBox, e3TextBox, e4TextBox, e5TextBox };
            TextBox[] frequencyTextBoxes = { f0TextBox, f1TextBox, f2TextBox, f3TextBox, f4TextBox, f5TextBox};
            for (int i = 0; i < 6; i++)
            {
                startTextBoxes[i].Text = "";
                endTextBoxes[i].Text = "" ;
                frequencyTextBoxes[i].Text = "";
            } 
            
            for (int i = 0; i < 6 && i < transformations.Length; i++)
            {
                startTextBoxes[i].Text = "" + transformations[i].start;
                endTextBoxes[i].Text = "" + transformations[i].end;
                frequencyTextBoxes[i].Text = "" + transformations[i].multFrequency;
            }
        }

        private void loadTextBoxes(FractalPresets fp)
        {
            secondsTextBox.Text = "" + fp.seconds;
            depthTextBox.Text = "" + fp.depth;
            amplitudeTextBox.Text = "" + fp.amplitude;
            maxWavesTextBox.Text = "" + fp.maxWaves;
            minWavesTextBox.Text = "" + fp.minWaves;
            baseFreqTextBox.Text = "" + fp.baseFreq;
            loadTransformationsFromPresets(fp.transformations);
        }

        private void loadPresetComboBox()
        {
            string[] files = Directory.GetFiles(".");
            foreach(string file in files)
            {
                if (file.EndsWith(".xml"))
                {
                    presetComboBox.Items.Add(file.Substring(2, file.Length - 6));
                }
            }
        }

        private void playSound_Click(object sender, EventArgs e)
        {
            playTheSound();
            generatedLabel.Visible = false;

        }

        private void playTheSound()
        {
            if (_sound != null) {
                _sound.Stop();
            }
            else
            {
                SoundBuffer soundBuffer = _fractal.getSound();
                WavFile.Save(_soundFile, soundBuffer);
                _sound = new SoundPlayer(_soundFile);
            }
            _sound.PlayLooping();
        }

        private void playTheSoundAgain()
        {
            _sound.Play();
        }

        private void animate()
        {
          
            if (!_scoreAnimating)
            {
                playTheSound();
                

                _timer = new System.Timers.Timer(TIMER_INTERVAL);
                _timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
                _timer.Enabled = true;
                _stopWatch = new Stopwatch();
                _stopWatch.Start();
            }
            _scoreAnimating = true;
            _transitionAnimating = false;
 

        }

        private void OnTimedEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            double time = 1 - (_totalTime - _stopWatch.ElapsedMilliseconds) / _totalTime;
            if (!_scoreAnimating && !_transitionAnimating)
            {
                time = -1; //TODO: shut down timer cleanly
            }
            if (time > 1)
            {
                if (_scoreAnimating)
                {
                    _stopWatch.Reset();
                    _stopWatch.Start();
                    time = 0;
                    playTheSoundAgain();
                }
                else if (_transitionAnimating)
                {
                    stopAnimation();
                    if (fractalBox.InvokeRequired)
                    {
                        Action act = () => loadAll();
                        this.Invoke(act);
                    }
                    
                    time = -1;
                }
            }
           if (fractalBox.InvokeRequired)
            {
                Action act;
                
                if(_transitionAnimating)
                {
                    act = () => fractalBox.Image = _fractal.getTransitionAnimation(time);
                }
                else
                {
                    act = () => fractalBox.Image = _fractal.getScoreAnimation(time);
                }
                fractalBox.Invoke(act);
           }

        }



        private void animateButton_Click(object sender, EventArgs e)
        {
            animate();
            generatedLabel.Visible = false;
        }

        private void stopAnimationButton_Click(object sender, EventArgs e)
        {
            stopAnimation();
        }

        private void stopAnimation()
        {
            _scoreAnimating = false;
            _transitionAnimating = false;

            if (_sound != null)
            {
                _sound.Stop();
            }
            if (_timer != null)
            {
                _timer.Stop();
            }

           // TMP loadFractal(_presets.depth, _presets.seconds, _presets.amplitude, _presets.minWaves, _presets.maxWaves);
            fractalBox.Image = _fractal.getScore();

        }



       private void goButton_Click(object sender, EventArgs e)
       {
           loadAll();
       }

       private Transformation[] loadTransformationsFromForm()
       {
           TextBox[] startTextBoxes = { s0TextBox, s1TextBox, s2TextBox, s3TextBox, s4TextBox, s5TextBox };
           TextBox[] endTextBoxes = { e0TextBox, e1TextBox, e2TextBox, e3TextBox, e4TextBox, e5TextBox };
           TextBox[] freqTextBoxes = { f0TextBox, f1TextBox, f2TextBox, f3TextBox, f4TextBox, f5TextBox };

           int i = 0;
           for (; i < 6;i++ ){
               if (startTextBoxes[i].Text == "") 
               {
                   break;
               }
           }
    
           Transformation[] transformations = new Transformation[i];

           for (i = 0; i < transformations.Length; i++)
           {
               
               double start, end, freq;
               if (!System.Double.TryParse(startTextBoxes[i].Text, out start) || start > 1 || start < 0)
               {
                   MessageBox.Show("Invalid start parameter: " + startTextBoxes[i].Text);
               }
               if (!System.Double.TryParse(endTextBoxes[i].Text, out end) || end > 1 || end < 0)
               {
                   MessageBox.Show("Invalid end parameter: " + endTextBoxes[i].Text);
               }
               if (!System.Double.TryParse(freqTextBoxes[i].Text, out freq)  || freq < 0)
               {
                   MessageBox.Show("Invalid frequency parameter: " + freqTextBoxes[i].Text);
               }

               Color c = Color.Gray;
               if (i == 0)
               {
                   c = Color.Red;
               }
               if (i == 1)
               {
                   c = Color.Blue;
               }
               if (i == 2)
               {
                   c = Color.Green;

               }
               if (i == 3)
               {
                   c = Color.Yellow;
               }
               if(i == 4)
               {
                   c = Color.Purple;
               }
               if(i == 5){
                   c = Color.White;
               }
               transformations[i] = new Transformation(start, end, freq, c);
           }

           return transformations;
       }

       private void loadVariablesFromForm()
       {


           int seconds, depth, minWaves, maxWaves;
           double amplitude, baseFreq;
           if (!System.Int32.TryParse(secondsTextBox.Text, out seconds) || seconds < 1)
           {
               MessageBox.Show("Invalid input for seconds: " + secondsTextBox.Text);
               return;
           }
           if (!System.Int32.TryParse(depthTextBox.Text, out depth) || depth > 15 || depth < 0)
           {
               MessageBox.Show("Invalid input for depth: " + depthTextBox.Text);
               return;
           }
           if (!System.Double.TryParse(amplitudeTextBox.Text, out amplitude) || amplitude > 100 || amplitude <= 0)
           {
               MessageBox.Show("Invalid amplitude: " + amplitudeTextBox.Text);
           }
           if (!System.Int32.TryParse(minWavesTextBox.Text, out minWaves) || minWaves < 0)
           {
               MessageBox.Show("Invalid input for min waves: " + minWavesTextBox.Text);
               return;
           }
           if (!System.Int32.TryParse(maxWavesTextBox.Text, out maxWaves) || maxWaves < 0)
           {
               MessageBox.Show("Invalid input for max waves: " + maxWavesTextBox.Text);
               return;

           }
           if (!System.Double.TryParse(baseFreqTextBox.Text, out baseFreq) || baseFreq < 0)
           {
               MessageBox.Show("Invalid input for frequency factor: " + baseFreqTextBox.Text);
               return;
           }


           _fractalVariables.seconds = seconds;
           _fractalVariables.depth = depth;
           _fractalVariables.amplitude = amplitude;
           _fractalVariables.maxWaves = maxWaves;
           _fractalVariables.minWaves = minWaves;
           _fractalVariables.baseFreq = baseFreq;
           _fractalVariables.transformations = loadTransformationsFromForm();

       }
       private void loadAll()
       {
           loadVariablesFromForm();
           loadFractal();
           loadAllImages();
           
       }

       private void loadAllImages()
       {
  
           fractalBox.Image = _fractal.getScoreAnimation(-1);
           waveFormBox.Image = _waveForm.GetImage();
           generatedLabel.Visible = true;
       }

       private void loadImages()
       {
           fractalBox.Image = _fractal.getScoreAnimation(-1);
           waveFormBox.Image = _waveForm.GetImage();
           generatedLabel.Visible = true;
       }



       private void depthPlus_Click(object sender, EventArgs e)
       {

    
           _fractalVariables.depth++;
           _fractalVariables.seconds = TRANSITION_TIME;
           loadFractal();
           transitionAnimate();
           Action act = () => depthTextBox.Text = ""+ _fractalVariables.depth;
           fractalBox.Invoke(act);


       }


       private void transitionAnimate()
       {
           if (!_transitionAnimating)
           {

               _timer = new System.Timers.Timer(TIMER_INTERVAL);
               _timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
               _timer.Enabled = true;
               _stopWatch = new Stopwatch();
               _stopWatch.Start();
           }
           _scoreAnimating = false;
           _transitionAnimating = true;
       }
        

       
       private void loadPresetButton_Click(object sender, EventArgs e)
       {
           _fractalVariables = FractalPresets.Load(presetComboBox.Text);
           loadTextBoxes(_fractalVariables);
           loadAll();
           loadFractal();
       }


       private void fractalBox_Click(object sender, EventArgs e)
       {

       }



       private void textBox1_TextChanged(object sender, EventArgs e)
       {

       }

       private void depthTextBox_TextChanged(object sender, EventArgs e)
       {

       }

       private void label1_Click(object sender, EventArgs e)
       {

       }

       private void label4_Click(object sender, EventArgs e)
       {

       }

       private void textBox1_TextChanged_1(object sender, EventArgs e)
       {

       }

       private void savePresetButton_Click(object sender, EventArgs e)
       {
           
           string fileName = presetComboBox.Text;
           if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
           {
               MessageBox.Show("Invalid characters in name: " + fileName);
               return;
           }
           FractalPresets.Save(_fractalVariables, fileName);
           presetComboBox.Items.Add(fileName);
         
       }

       private void exportVideoButton_Click(object sender, EventArgs e)
       {
          _fractal.dumpScoreAnimationsToFiles("" + presetComboBox.Text + "_d" + _fractalVariables.depth + "_s" + _fractalVariables.seconds, 25);
       }

       private void exportTransistionVideo_click(object sender, EventArgs e)
       {
           
           _fractal.dumpTransitionAnimationsToFiles("" + presetComboBox.Text + "_transition_d" + _fractalVariables.depth + "_s"  + TRANSITION_TIME, TRANSITION_TIME, 25);
       }

       private void depthMinus_click(object sender, EventArgs e)
       {
           _fractalVariables.depth--;
           if (_fractalVariables.depth < 0)
           {
               _fractalVariables.depth = 0;
           }

           Action act = () => depthTextBox.Text = "" + _fractalVariables.depth;
           this.Invoke(act);

           loadAll();
       }

       private void randomButton_Click(object sender, EventArgs e)
       {
           for(int i = 0; i < _fractalVariables.transformations.Length; i++)
           {
               _fractalVariables.transformations[i] = Fractal.randomTransformation();
           }
           loadTransformationsFromPresets(_fractalVariables.transformations);
           loadAll();
       }

       private void f5TextBox_TextChanged(object sender, EventArgs e)
       {

       }

       private void f4TextBox_TextChanged(object sender, EventArgs e)
       {

       }

       private void f3TextBox_TextChanged(object sender, EventArgs e)
       {

       }

       private void f2TextBox_TextChanged(object sender, EventArgs e)
       {

       }

       private void f1TextBox_TextChanged(object sender, EventArgs e)
       {

       }

       private void f0TextBox_TextChanged(object sender, EventArgs e)
       {

       }





        

    }
}
