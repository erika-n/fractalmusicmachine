using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
        private WaveForm _waveForm;
        private Fractal _fractal, _buildingFractal;
        private string _soundFile = SoundUtil.SAVE_FOLDER + "\\fractal.wav";
        private System.Timers.Timer _timer;
        private static double TIMER_INTERVAL = 30;
        private double _totalTime;
        private Stopwatch _stopWatch;
        private Stopwatch _fractalStopwatch;
        private System.Media.SoundPlayer _sound;
        private Boolean _scoreAnimating;
        private Boolean _transitionAnimating;
        private Boolean _doTransitionAnimate = false;
        private FractalPresets _fractalVariables;
        private const int GRAPHICS = 0, NO_GRAPHICS = 1, SINGLE_FRAME = 2;
        private Bitmap _fractalBitmap;
        private Boolean _looping = true;
        private Boolean _starMode = false;
        private const int VIDEO_FRAME_RATE = 30;
        private const int MIN_SECONDS = 1;
        private const int MAX_SECONDS = 100000;

        public Form1()
        {

            InitializeComponent();

            _fractalVariables = FractalPresets.samplePresets();
            _fractalVariables.transformations = FractalPresets.sampleTransformations();
            _scoreAnimating = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            loadPresetComboBox();
            loadSampleComboBox();
            loadOscillatorComboBox();
            loadTextBoxes(_fractalVariables);
            loadFractal();
            this.WindowState = FormWindowState.Maximized;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

        }


        // Load fractal from current variables. 
        private void loadFractal()
        {

            _fractalStopwatch = new Stopwatch();
            _fractalStopwatch.Start();

            
            _buildingFractal = new Fractal(_fractalVariables);
            
            
            generatedLabel.Visible = true;
            generatedLabel.Text = "Generating depth " + _fractalVariables.depth + " fractal...";
            if (fractalMakerBackgroundWorker.IsBusy)
            {
                fractalMakerBackgroundWorker.CancelAsync();
            }
            else
            {
                goButton.Text = "Cancel";
                fractalMakerBackgroundWorker.RunWorkerAsync();
            }
  
        }

        ////
        //// Async stuff

        private void fractalMakerBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            System.GC.Collect();
            
            Stack<FractalStackObject> theStack = _buildingFractal.run(1);

            int steps = _buildingFractal.totalSteps();


            int stepsPerBlock = 50;
            int blocks = 1 + (steps / stepsPerBlock);
            theStack = _buildingFractal.run(1);
            for (int i = 0; i < blocks && !fractalMakerBackgroundWorker.CancellationPending; i++)
            {
                theStack = _buildingFractal.partialStackRun(theStack, stepsPerBlock);
                fractalMakerBackgroundWorker.ReportProgress((int)(100 * i /blocks ));
                if (fractalMakerBackgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

            }
            _buildingFractal.finish();
            _waveForm = new SoundLabUI.WaveForm(_buildingFractal.getSound(), waveFormBox.Width, waveFormBox.Height);
           
            _fractalBitmap = _buildingFractal.getImage();
            fractalMakerBackgroundWorker.ReportProgress(99);
            WavFile.Save(_soundFile, _buildingFractal.getSound());

            if (fractalMakerBackgroundWorker.CancellationPending)
            {
                e.Cancel = true;
            }
            fractalMakerBackgroundWorker.ReportProgress(100);
            


        }


        private void fractalMakerBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            if (e.Cancelled)
            {
                generatedLabel.Text = "Canceled.";
                goButton.Text = "Generate";
                _transitionAnimating = false;
                return;
            }
            if (_doTransitionAnimate)
            {
                _doTransitionAnimate = false;
                _transitionAnimating = false;
                transitionAnimate();
            }
            else
            {
                stopAnimation(false);
                fractalBox.Image = _fractalBitmap;
            }
            Debug.Write(_buildingFractal.frequencyHist());
            goButton.Text = "Generate";

            Fractal oldFractal = _fractal;
            
            _fractal = _buildingFractal;
            _fractal.setStarMode(_starMode);


            _totalTime = _fractal.getSound().getMilliseconds();





            waveFormBox.Image = _waveForm.GetImage();
            _fractalStopwatch.Stop();
            if (oldFractal != null)
            {
                oldFractal.Dispose();
            }
            Console.WriteLine("Elapsed time: " + _fractalStopwatch.ElapsedMilliseconds / 1000);
            generatedLabel.Text = "Generated.";

        }
        private void fractalMakerBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 98)
            {
                generatedLabel.Text = "Finishing...";
            }
            else
            {
                generatedLabel.Text = "Generating depth " + _fractalVariables.depth + " fractal... " + e.ProgressPercentage + "% done.";
            }
        }


/////
//// Load stuff from file or screen
/////

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
            //amplitudeTextBox.Text = "" + fp.amplitude;
            maxWavesTextBox.Text = "" + fp.maxWaves;
            minWavesTextBox.Text = "" + fp.minWaves;
            baseFreqTextBox.Text = "" + fp.baseFreq;
            oscillatorComboBox.Text = "" + oscillatorComboBox.Items[fp.oscillator];
            sampleComboBox.SelectedIndex = -1;
            sampleComboBox.Text = "" + fp.sample;
            loadTransformationsFromPresets(fp.transformations);
            frequencyRangeCheckbox.Checked = fp.earProtection;
            cutoffHighTextBox.Text = "" + fp.cutoffHigh;
            cutoffLowTextBox.Text = "" + fp.cutoffLow;
        }

        private void loadPresetComboBox()
        {
            loadFileComboBox(SoundLabBasics.SoundUtil.PRESETS_FOLDER, ".xml", presetComboBox);
        }

        private void loadSampleComboBox()
        {
            loadFileComboBox(SoundLabBasics.SoundUtil.SAMPLES_FOLDER, ".wav", sampleComboBox);
            //loadFileComboBox(SoundLabBasics.SoundUtil.SAMPLES_FOLDER, ".m4a", sampleComboBox);

        }

        private void loadFileComboBox(string dir, string extension, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            string[] files = Directory.GetFiles(dir);
            foreach(string file in files)
            {
                if (file.EndsWith(extension))
                {
                    int dirlen = dir.Length + 1; // add 1 for \
                    comboBox.Items.Add(file.Substring(dirlen, file.Length - (dirlen + 4))); // add 4 for .xml
                }
            }
        }


        private void loadOscillatorComboBox()
        {
      
            //NOTE: this depends on the fractal constants being contiguous.
            oscillatorComboBox.Items.Insert(Fractal.SINE, "Sine");
            oscillatorComboBox.Items.Insert(Fractal.SQUARE, "Square");
            oscillatorComboBox.Items.Insert(Fractal.SAWTOOTH,"Sawtooth");
            oscillatorComboBox.Items.Insert(Fractal.SAMPLE, "Sample");
            //oscillatorComboBox.Items.Insert(Fractal.SYNTHSTRING,"Synth String");
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
               if (!System.Double.TryParse(freqTextBoxes[i].Text, out freq) )
               {
                   MessageBox.Show("Invalid frequency parameter: " + freqTextBoxes[i].Text);
               }

               Color c = Color.Gray;
               if (i == 0)
               {
                   c = Color.FromArgb(255, 0x33, 0x99, 0x99);
               }
               if (i == 1)
               {
                   c = Color.FromArgb(255, 0x66, 0x66, 0xcc);
               }
               if (i == 2)
               {
                   c = Color.FromArgb(255, 0x00, 0x66, 0xcc);

               }
               if (i == 3)
               {
                   c = Color.FromArgb(255, 0x33, 0x99, 0x99);
               }
               if(i == 4)
               {
                   c = Color.FromArgb(255, 0x33, 0x66, 0x99);
               }
               if(i == 5){
                   c = Color.FromArgb(255, 0x33, 0x00, 0x99);
               }
                
               transformations[i] = new Transformation(start, end, freq, c);
           }

           return transformations;
       }

       private Boolean loadVariablesFromForm()
       {


           int seconds, depth, minWaves, maxWaves, cutoffHigh, cutoffLow, oscillator;
           double baseFreq;
           string sampleFile = "", sampleFileName = "";
           if (!System.Int32.TryParse(secondsTextBox.Text, out seconds) || seconds < MIN_SECONDS || seconds > MAX_SECONDS)
           {
               MessageBox.Show("Invalid input for seconds: " + secondsTextBox.Text);
               return false;
           }
           if (!System.Int32.TryParse(depthTextBox.Text, out depth) || depth > 15 || depth < 0)
           {
               MessageBox.Show("Invalid input for depth: " + depthTextBox.Text);
               return false;
           }
          // if (!System.Double.TryParse(amplitudeTextBox.Text, out amplitude) || amplitude > 100 || amplitude <= 0)
        //   {
         //      MessageBox.Show("Invalid amplitude: " + amplitudeTextBox.Text);
         //  }
           if (!System.Int32.TryParse(minWavesTextBox.Text, out minWaves) || minWaves < 0)
           {
               MessageBox.Show("Invalid input for min waves: " + minWavesTextBox.Text);
               return false;
           }
           if (!System.Int32.TryParse(maxWavesTextBox.Text, out maxWaves) || maxWaves < 0)
           {
               MessageBox.Show("Invalid input for max waves: " + maxWavesTextBox.Text);
               return false;

           }
           if (!System.Double.TryParse(baseFreqTextBox.Text, out baseFreq) || baseFreq < 0)
           {
               MessageBox.Show("Invalid input for frequency factor: " + baseFreqTextBox.Text);
               return false;
           }
           if (!System.Int32.TryParse(cutoffHighTextBox.Text, out cutoffHigh) || cutoffHigh < 0)
           {

               MessageBox.Show("Invalid input for high frequency cutoff: " + cutoffHighTextBox.Text);
               return false;
           }
           if (!System.Int32.TryParse(cutoffLowTextBox.Text, out cutoffLow) || cutoffLow < 0)
           {
               MessageBox.Show("Invalid input for low frequency cutoff: " + cutoffLowTextBox.Text);
               return false;
           }
           oscillator = oscillatorComboBox.SelectedIndex;
           if (sampleComboBox.SelectedItem != null || sampleComboBox.Text != "")
           {
               sampleFileName = sampleComboBox.Text;
               sampleFile = SoundUtil.SAMPLES_FOLDER + "\\" + sampleFileName + ".wav";
               if (!File.Exists(sampleFile))
               {
                   
                   sampleFileName = "";
                   sampleComboBox.SelectedIndex = -1;
                   if (oscillator == Fractal.SAMPLE){
                       MessageBox.Show("Sample file " + sampleFile + " not found");
                       return false;
                   }
               }

           }
           
           if(oscillator == Fractal.SAMPLE && sampleFileName == "")
           {
               MessageBox.Show("No sample found for sample fractal.");
               return false;
           }

           _fractalVariables.sample = sampleFileName;
           _fractalVariables.seconds = seconds;
           _fractalVariables.depth = depth;
         //  _fractalVariables.amplitude = amplitude;
           _fractalVariables.maxWaves = maxWaves;
           _fractalVariables.minWaves = minWaves;
           _fractalVariables.baseFreq = baseFreq;
           _fractalVariables.transformations = loadTransformationsFromForm();
           _fractalVariables.oscillator = oscillator;

           _fractalVariables.earProtection = frequencyRangeCheckbox.Checked;
           _fractalVariables.cutoffHigh = cutoffHigh;
           _fractalVariables.cutoffLow = cutoffLow;
           _fractalVariables.name = presetComboBox.Text;
           FractalPresets.Save(_fractalVariables, "latest");
           return true;
       }
       private void loadAll()
       {
           if (loadVariablesFromForm())
           {
               loadFractal();
           }
           
       }

       private void loadAllImages()
       {
  
           fractalBox.Image = _fractal.getScoreAnimation(-1);
           waveFormBox.Image = _waveForm.GetImage();
           generatedLabel.Visible = true;
       }


////////////////////////////
////Animation
///////////////
       private void animate()
       {

           if (!_scoreAnimating)
           {
               stopAnimation();
               
               startTimer();
               playTheSound();
           }
           _scoreAnimating = true;
           _transitionAnimating = false;


       }

       private void transitionAnimate()
       {
           if (!_transitionAnimating)
           {
               stopAnimation();
               startTimer();
           }
           _scoreAnimating = false;
           _transitionAnimating = true;
       }

       private void stopAnimation(Boolean stopSound = true)
       {
           _scoreAnimating = false;
           _transitionAnimating = false;

           if (_sound != null && stopSound)
           {
               _sound.Stop();
           }
           if (_timer != null)
           {
               _timer.Stop();
               _timer.Dispose();
           }
           if (_stopWatch != null)
           {
               _stopWatch.Stop();
               _stopWatch.Reset();
           }

       }

       private void stopSound()
       {

       }

       private void startTimer()
       {
           _timer = new System.Timers.Timer(TIMER_INTERVAL);
           _timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
           _timer.Enabled = true;
           _stopWatch = new Stopwatch();
           _stopWatch.Start();
       }

       private void OnTimedEvent(object sender, System.Timers.ElapsedEventArgs e)
       {
           double scoreTime = 1 - (_totalTime - _stopWatch.ElapsedMilliseconds % _totalTime) / _totalTime; // go on and on
           double transistionTime = 1 - (_totalTime - _stopWatch.ElapsedMilliseconds) / _totalTime; // go around just once.
           if (!_looping)
           {
               // TODO: suddenly it's not looping and it needs to finish this round even though it's already finished one.
               scoreTime = transistionTime;
           }
           if (transistionTime >= 1 && (_transitionAnimating || (_scoreAnimating && !_looping)))
           {
                 _transitionAnimating = false;
                 _scoreAnimating = false;
                 stopAnimation();
           }
           
           else if (fractalBox.InvokeRequired)
           {
               Action act = () => {};

               if (_transitionAnimating)
               {
                   act = () => { fractalBox.Image.Dispose();  fractalBox.Image = _fractal.getTransitionAnimation(transistionTime); };
               }
               else if (_scoreAnimating)
               {
                   act = () => { fractalBox.Image.Dispose();  fractalBox.Image = _fractal.getScoreAnimation(scoreTime); };
               }
               fractalBox.Invoke(act);
           }

       }





        //// Sound

       private void playSound_Click(object sender, EventArgs e)
       {
           playTheSound();

       }

       private void playTheSound()
       {
           if (_sound != null)
           {
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


/////////////////
////Button click handlers
////////
       // Animation buttons
       private void animateButton_Click(object sender, EventArgs e)
       {
           animate();
       }

       private void stopAnimationButton_Click(object sender, EventArgs e)
       {
           stopAnimation();
       }

       // Preset buttons
       private void loadPresetButton_Click(object sender, EventArgs e)
       {
           try
           {
               _fractalVariables = FractalPresets.Load(presetComboBox.Text);
               loadTextBoxes(_fractalVariables);
               loadAll();
           }
           catch(FileNotFoundException)
           {
               MessageBox.Show("Preset file not found: " + presetComboBox.Text);
           }
           

    
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
           WavFile.Save(SoundUtil.SAVE_FOLDER + "\\" + fileName + ".wav", _fractal.getSound());
           presetComboBox.Items.Add(fileName);
         
       }


   
       //Generate button
       private void goButton_Click(object sender, EventArgs e)
       {
           if (!fractalMakerBackgroundWorker.IsBusy)
           {
               loadAll();
           }
           else
           {
               fractalMakerBackgroundWorker.CancelAsync();
           }
       }
       
       // Export video buttons
       private void exportVideoButton_Click(object sender, EventArgs e)
       {
           videoBackgroundWorker.RunWorkerAsync();
       }

       private void exportTransistionVideo_click(object sender, EventArgs e)
       {
           transitionVideoBackgroundWorker.RunWorkerAsync();    
       }

       private void videoBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
       {
          _fractal.dumpScoreAnimationsToFiles("" + _fractalVariables.name + "_d" + _fractalVariables.depth + "_s" + _fractalVariables.seconds, VIDEO_FRAME_RATE);
       }
       private void transitionVideoBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
       {
           _fractal.dumpTransitionAnimationsToFiles("" + _fractalVariables.name + "_transition_d" + _fractalVariables.depth + "_s" + _fractalVariables.seconds, _fractalVariables.seconds, VIDEO_FRAME_RATE);
   
       }

       
       // Depth plus and minus buttons
       private void depthPlus_Click(object sender, EventArgs e)
       {


           _fractalVariables.depth++;
           if (_fractalVariables.depth <= FractalImage.MAX_ANIMATE_DEPTH)
           {
               //stopAnimation();
                _doTransitionAnimate = true;
           }
           //_fractalVariables.seconds = TRANSITION_TIME;

           loadFractal();

           Action act = () => depthTextBox.Text = "" + _fractalVariables.depth;
           fractalBox.Invoke(act);
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

       //Random button
       private void randomButton_Click(object sender, EventArgs e)
       {
           for(int i = 0; i < _fractalVariables.transformations.Length; i++)
           {
               _fractalVariables.transformations[i] = FractalPresets.randomTransformation();
           }
           loadTransformationsFromPresets(_fractalVariables.transformations);
           loadAll();
       }





       private void sampleComboBox_DropDown(object sender, EventArgs e)
       {
           loadSampleComboBox();
       }

       private void sampleComboBox_SelectedIndexChanged(object sender, EventArgs e)
       {
           //System.Diagnostics.Process.Start(SoundLabBasics.SoundUtil.SAMPLES_FOLDER + "\\converttowav.bat", "\"" + sampleComboBox.SelectedItem + "\""); 
       }

       private void loopCheckbox_CheckedChanged(object sender, EventArgs e)
       {
           _looping = loopCheckbox.Checked;
       }

       private void starModeCheckbox_CheckedChanged(object sender, EventArgs e)
       {
           _starMode = starModeCheckbox.Checked;
       }



       private void secondsPlusButton_Click(object sender, EventArgs e)
       {
           loadVariablesFromForm();
           _fractalVariables.seconds *= 2;
           if (_fractalVariables.seconds > MAX_SECONDS)
           {
               _fractalVariables.seconds = MAX_SECONDS;
           }
           secondsTextBox.Text = "" + _fractalVariables.seconds;
       }

       private void secondsMinusButton_Click(object sender, EventArgs e)
       {
         
           loadVariablesFromForm();
           _fractalVariables.seconds /= 2;
           if (_fractalVariables.seconds < MIN_SECONDS)
           {
               _fractalVariables.seconds = MIN_SECONDS;
           }
           secondsTextBox.Text = "" + _fractalVariables.seconds;
       }
        


    }
}
