namespace SoundLabUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fractalBox = new System.Windows.Forms.PictureBox();
            this.waveFormBox = new System.Windows.Forms.PictureBox();
            this.stopAnimationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amplitudeTextBox = new System.Windows.Forms.TextBox();
            this.playSound = new System.Windows.Forms.Button();
            this.animateButton = new System.Windows.Forms.Button();
            this.generatedLabel = new System.Windows.Forms.Label();
            this.maxWavesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minWavesTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.depthPlus = new System.Windows.Forms.Button();
            this.presetComboBox = new System.Windows.Forms.ComboBox();
            this.loadPresetButton = new System.Windows.Forms.Button();
            this.savePresetButton = new System.Windows.Forms.Button();
            this.baseFreqTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.s0TextBox = new System.Windows.Forms.TextBox();
            this.e0TextBox = new System.Windows.Forms.TextBox();
            this.f0TextBox = new System.Windows.Forms.TextBox();
            this.f1TextBox = new System.Windows.Forms.TextBox();
            this.e1TextBox = new System.Windows.Forms.TextBox();
            this.s1TextBox = new System.Windows.Forms.TextBox();
            this.f2TextBox = new System.Windows.Forms.TextBox();
            this.e2TextBox = new System.Windows.Forms.TextBox();
            this.s2TextBox = new System.Windows.Forms.TextBox();
            this.f3TextBox = new System.Windows.Forms.TextBox();
            this.e3TextBox = new System.Windows.Forms.TextBox();
            this.s3TextBox = new System.Windows.Forms.TextBox();
            this.f4TextBox = new System.Windows.Forms.TextBox();
            this.e4TextBox = new System.Windows.Forms.TextBox();
            this.s4TextBox = new System.Windows.Forms.TextBox();
            this.f5TextBox = new System.Windows.Forms.TextBox();
            this.e5TextBox = new System.Windows.Forms.TextBox();
            this.s5TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exportVideoButton = new System.Windows.Forms.Button();
            this.depthMinusButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.exportTransistionVideoButton = new System.Windows.Forms.Button();
            this.oscillatorComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sampleComboBox = new System.Windows.Forms.ComboBox();
            this.frequencyRangeCheckbox = new System.Windows.Forms.CheckBox();
            this.cutoffLowTextBox = new System.Windows.Forms.TextBox();
            this.cutoffHighTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.fractalMakerBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.videoBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.transitionVideoBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label14 = new System.Windows.Forms.Label();
            this.loopCheckbox = new System.Windows.Forms.CheckBox();
            this.starModeCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fractalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveFormBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalBox
            // 
            this.fractalBox.BackColor = System.Drawing.Color.Transparent;
            this.fractalBox.Location = new System.Drawing.Point(358, 53);
            this.fractalBox.Name = "fractalBox";
            this.fractalBox.Size = new System.Drawing.Size(972, 766);
            this.fractalBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fractalBox.TabIndex = 1;
            this.fractalBox.TabStop = false;
            // 
            // waveFormBox
            // 
            this.waveFormBox.Location = new System.Drawing.Point(1397, 900);
            this.waveFormBox.Name = "waveFormBox";
            this.waveFormBox.Size = new System.Drawing.Size(468, 65);
            this.waveFormBox.TabIndex = 3;
            this.waveFormBox.TabStop = false;
            // 
            // stopAnimationButton
            // 
            this.stopAnimationButton.BackColor = System.Drawing.Color.DimGray;
            this.stopAnimationButton.Location = new System.Drawing.Point(1397, 772);
            this.stopAnimationButton.Name = "stopAnimationButton";
            this.stopAnimationButton.Size = new System.Drawing.Size(214, 84);
            this.stopAnimationButton.TabIndex = 4;
            this.stopAnimationButton.Text = "Stop";
            this.stopAnimationButton.UseVisualStyleBackColor = false;
            this.stopAnimationButton.Click += new System.EventHandler(this.stopAnimationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1657, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Depth:";
            // 
            // depthTextBox
            // 
            this.depthTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.depthTextBox.Location = new System.Drawing.Point(1722, 32);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(72, 26);
            this.depthTextBox.TabIndex = 6;
            this.depthTextBox.Text = "2";
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.DimGray;
            this.goButton.Location = new System.Drawing.Point(1651, 406);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(214, 84);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "Generate";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1638, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seconds:";
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.secondsTextBox.Location = new System.Drawing.Point(1722, 91);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(72, 26);
            this.secondsTextBox.TabIndex = 9;
            this.secondsTextBox.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1630, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amplitude:";
            // 
            // amplitudeTextBox
            // 
            this.amplitudeTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.amplitudeTextBox.Location = new System.Drawing.Point(1722, 150);
            this.amplitudeTextBox.Name = "amplitudeTextBox";
            this.amplitudeTextBox.Size = new System.Drawing.Size(72, 26);
            this.amplitudeTextBox.TabIndex = 11;
            this.amplitudeTextBox.Text = "0.01";
            // 
            // playSound
            // 
            this.playSound.BackColor = System.Drawing.Color.DimGray;
            this.playSound.Location = new System.Drawing.Point(1397, 650);
            this.playSound.Name = "playSound";
            this.playSound.Size = new System.Drawing.Size(214, 84);
            this.playSound.TabIndex = 0;
            this.playSound.Text = "Play sound";
            this.playSound.UseVisualStyleBackColor = false;
            this.playSound.Click += new System.EventHandler(this.playSound_Click);
            // 
            // animateButton
            // 
            this.animateButton.BackColor = System.Drawing.Color.DimGray;
            this.animateButton.Location = new System.Drawing.Point(1397, 528);
            this.animateButton.Name = "animateButton";
            this.animateButton.Size = new System.Drawing.Size(214, 84);
            this.animateButton.TabIndex = 2;
            this.animateButton.Text = "Animate";
            this.animateButton.UseVisualStyleBackColor = false;
            this.animateButton.Click += new System.EventHandler(this.animateButton_Click);
            // 
            // generatedLabel
            // 
            this.generatedLabel.AutoSize = true;
            this.generatedLabel.Location = new System.Drawing.Point(1416, 999);
            this.generatedLabel.Name = "generatedLabel";
            this.generatedLabel.Size = new System.Drawing.Size(90, 20);
            this.generatedLabel.TabIndex = 12;
            this.generatedLabel.Text = "Generated.";
            this.generatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generatedLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // maxWavesTextBox
            // 
            this.maxWavesTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.maxWavesTextBox.Location = new System.Drawing.Point(1722, 268);
            this.maxWavesTextBox.Name = "maxWavesTextBox";
            this.maxWavesTextBox.Size = new System.Drawing.Size(72, 26);
            this.maxWavesTextBox.TabIndex = 16;
            this.maxWavesTextBox.Text = "10";
            this.maxWavesTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1624, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Max waves:";
            // 
            // minWavesTextBox
            // 
            this.minWavesTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.minWavesTextBox.Location = new System.Drawing.Point(1722, 209);
            this.minWavesTextBox.Name = "minWavesTextBox";
            this.minWavesTextBox.Size = new System.Drawing.Size(72, 26);
            this.minWavesTextBox.TabIndex = 14;
            this.minWavesTextBox.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1628, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Min waves:";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // depthPlus
            // 
            this.depthPlus.BackColor = System.Drawing.Color.DimGray;
            this.depthPlus.Location = new System.Drawing.Point(1397, 406);
            this.depthPlus.Name = "depthPlus";
            this.depthPlus.Size = new System.Drawing.Size(94, 84);
            this.depthPlus.TabIndex = 17;
            this.depthPlus.Text = "Depth+";
            this.depthPlus.UseVisualStyleBackColor = false;
            this.depthPlus.Click += new System.EventHandler(this.depthPlus_Click);
            // 
            // presetComboBox
            // 
            this.presetComboBox.FormattingEnabled = true;
            this.presetComboBox.Location = new System.Drawing.Point(1397, 91);
            this.presetComboBox.Name = "presetComboBox";
            this.presetComboBox.Size = new System.Drawing.Size(165, 28);
            this.presetComboBox.TabIndex = 19;
            this.presetComboBox.Text = "latest";
            // 
            // loadPresetButton
            // 
            this.loadPresetButton.Location = new System.Drawing.Point(1397, 144);
            this.loadPresetButton.Name = "loadPresetButton";
            this.loadPresetButton.Size = new System.Drawing.Size(165, 58);
            this.loadPresetButton.TabIndex = 20;
            this.loadPresetButton.Text = "Load Preset";
            this.loadPresetButton.UseVisualStyleBackColor = true;
            this.loadPresetButton.Click += new System.EventHandler(this.loadPresetButton_Click);
            // 
            // savePresetButton
            // 
            this.savePresetButton.Location = new System.Drawing.Point(1397, 228);
            this.savePresetButton.Name = "savePresetButton";
            this.savePresetButton.Size = new System.Drawing.Size(165, 58);
            this.savePresetButton.TabIndex = 21;
            this.savePresetButton.Text = "Save Preset";
            this.savePresetButton.UseVisualStyleBackColor = true;
            this.savePresetButton.Click += new System.EventHandler(this.savePresetButton_Click);
            // 
            // baseFreqTextBox
            // 
            this.baseFreqTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.baseFreqTextBox.Location = new System.Drawing.Point(1722, 327);
            this.baseFreqTextBox.Name = "baseFreqTextBox";
            this.baseFreqTextBox.Size = new System.Drawing.Size(72, 26);
            this.baseFreqTextBox.TabIndex = 23;
            this.baseFreqTextBox.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1581, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Frequency factor:";
            // 
            // s0TextBox
            // 
            this.s0TextBox.Location = new System.Drawing.Point(70, 84);
            this.s0TextBox.Name = "s0TextBox";
            this.s0TextBox.Size = new System.Drawing.Size(59, 26);
            this.s0TextBox.TabIndex = 24;
            // 
            // e0TextBox
            // 
            this.e0TextBox.Location = new System.Drawing.Point(152, 84);
            this.e0TextBox.Name = "e0TextBox";
            this.e0TextBox.Size = new System.Drawing.Size(59, 26);
            this.e0TextBox.TabIndex = 25;
            // 
            // f0TextBox
            // 
            this.f0TextBox.Location = new System.Drawing.Point(231, 84);
            this.f0TextBox.Name = "f0TextBox";
            this.f0TextBox.Size = new System.Drawing.Size(59, 26);
            this.f0TextBox.TabIndex = 26;
            // 
            // f1TextBox
            // 
            this.f1TextBox.Location = new System.Drawing.Point(231, 128);
            this.f1TextBox.Name = "f1TextBox";
            this.f1TextBox.Size = new System.Drawing.Size(59, 26);
            this.f1TextBox.TabIndex = 29;
            // 
            // e1TextBox
            // 
            this.e1TextBox.Location = new System.Drawing.Point(152, 128);
            this.e1TextBox.Name = "e1TextBox";
            this.e1TextBox.Size = new System.Drawing.Size(59, 26);
            this.e1TextBox.TabIndex = 28;
            // 
            // s1TextBox
            // 
            this.s1TextBox.Location = new System.Drawing.Point(70, 128);
            this.s1TextBox.Name = "s1TextBox";
            this.s1TextBox.Size = new System.Drawing.Size(59, 26);
            this.s1TextBox.TabIndex = 27;
            // 
            // f2TextBox
            // 
            this.f2TextBox.Location = new System.Drawing.Point(231, 172);
            this.f2TextBox.Name = "f2TextBox";
            this.f2TextBox.Size = new System.Drawing.Size(59, 26);
            this.f2TextBox.TabIndex = 32;
            // 
            // e2TextBox
            // 
            this.e2TextBox.Location = new System.Drawing.Point(152, 172);
            this.e2TextBox.Name = "e2TextBox";
            this.e2TextBox.Size = new System.Drawing.Size(59, 26);
            this.e2TextBox.TabIndex = 31;
            // 
            // s2TextBox
            // 
            this.s2TextBox.Location = new System.Drawing.Point(70, 172);
            this.s2TextBox.Name = "s2TextBox";
            this.s2TextBox.Size = new System.Drawing.Size(59, 26);
            this.s2TextBox.TabIndex = 30;
            // 
            // f3TextBox
            // 
            this.f3TextBox.Location = new System.Drawing.Point(231, 216);
            this.f3TextBox.Name = "f3TextBox";
            this.f3TextBox.Size = new System.Drawing.Size(59, 26);
            this.f3TextBox.TabIndex = 35;
            // 
            // e3TextBox
            // 
            this.e3TextBox.Location = new System.Drawing.Point(152, 216);
            this.e3TextBox.Name = "e3TextBox";
            this.e3TextBox.Size = new System.Drawing.Size(59, 26);
            this.e3TextBox.TabIndex = 34;
            // 
            // s3TextBox
            // 
            this.s3TextBox.Location = new System.Drawing.Point(70, 216);
            this.s3TextBox.Name = "s3TextBox";
            this.s3TextBox.Size = new System.Drawing.Size(59, 26);
            this.s3TextBox.TabIndex = 33;
            // 
            // f4TextBox
            // 
            this.f4TextBox.Location = new System.Drawing.Point(231, 260);
            this.f4TextBox.Name = "f4TextBox";
            this.f4TextBox.Size = new System.Drawing.Size(59, 26);
            this.f4TextBox.TabIndex = 38;
            // 
            // e4TextBox
            // 
            this.e4TextBox.Location = new System.Drawing.Point(152, 260);
            this.e4TextBox.Name = "e4TextBox";
            this.e4TextBox.Size = new System.Drawing.Size(59, 26);
            this.e4TextBox.TabIndex = 37;
            // 
            // s4TextBox
            // 
            this.s4TextBox.Location = new System.Drawing.Point(70, 260);
            this.s4TextBox.Name = "s4TextBox";
            this.s4TextBox.Size = new System.Drawing.Size(59, 26);
            this.s4TextBox.TabIndex = 36;
            // 
            // f5TextBox
            // 
            this.f5TextBox.Location = new System.Drawing.Point(231, 304);
            this.f5TextBox.Name = "f5TextBox";
            this.f5TextBox.Size = new System.Drawing.Size(59, 26);
            this.f5TextBox.TabIndex = 41;
            // 
            // e5TextBox
            // 
            this.e5TextBox.Location = new System.Drawing.Point(152, 304);
            this.e5TextBox.Name = "e5TextBox";
            this.e5TextBox.Size = new System.Drawing.Size(59, 26);
            this.e5TextBox.TabIndex = 40;
            // 
            // s5TextBox
            // 
            this.s5TextBox.Location = new System.Drawing.Point(70, 304);
            this.s5TextBox.Name = "s5TextBox";
            this.s5TextBox.Size = new System.Drawing.Size(59, 26);
            this.s5TextBox.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "End";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Freq";
            // 
            // exportVideoButton
            // 
            this.exportVideoButton.Location = new System.Drawing.Point(1651, 650);
            this.exportVideoButton.Name = "exportVideoButton";
            this.exportVideoButton.Size = new System.Drawing.Size(214, 84);
            this.exportVideoButton.TabIndex = 45;
            this.exportVideoButton.Text = "Export Video";
            this.exportVideoButton.UseVisualStyleBackColor = true;
            this.exportVideoButton.Click += new System.EventHandler(this.exportVideoButton_Click);
            // 
            // depthMinusButton
            // 
            this.depthMinusButton.BackColor = System.Drawing.Color.DimGray;
            this.depthMinusButton.Location = new System.Drawing.Point(1517, 406);
            this.depthMinusButton.Name = "depthMinusButton";
            this.depthMinusButton.Size = new System.Drawing.Size(94, 84);
            this.depthMinusButton.TabIndex = 46;
            this.depthMinusButton.Text = "Depth-\r\n";
            this.depthMinusButton.UseVisualStyleBackColor = false;
            this.depthMinusButton.Click += new System.EventHandler(this.depthMinus_click);
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.Color.DimGray;
            this.randomButton.Location = new System.Drawing.Point(1651, 528);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(214, 84);
            this.randomButton.TabIndex = 47;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // exportTransistionVideoButton
            // 
            this.exportTransistionVideoButton.Location = new System.Drawing.Point(1651, 772);
            this.exportTransistionVideoButton.Name = "exportTransistionVideoButton";
            this.exportTransistionVideoButton.Size = new System.Drawing.Size(214, 84);
            this.exportTransistionVideoButton.TabIndex = 48;
            this.exportTransistionVideoButton.Text = "Export Transistion Video\r\n";
            this.exportTransistionVideoButton.UseVisualStyleBackColor = true;
            this.exportTransistionVideoButton.Click += new System.EventHandler(this.exportTransistionVideo_click);
            // 
            // oscillatorComboBox
            // 
            this.oscillatorComboBox.FormattingEnabled = true;
            this.oscillatorComboBox.Location = new System.Drawing.Point(70, 439);
            this.oscillatorComboBox.Name = "oscillatorComboBox";
            this.oscillatorComboBox.Size = new System.Drawing.Size(216, 28);
            this.oscillatorComboBox.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Oscillator:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Sample:";
            // 
            // sampleComboBox
            // 
            this.sampleComboBox.FormattingEnabled = true;
            this.sampleComboBox.Location = new System.Drawing.Point(74, 556);
            this.sampleComboBox.Name = "sampleComboBox";
            this.sampleComboBox.Size = new System.Drawing.Size(216, 28);
            this.sampleComboBox.TabIndex = 52;
            this.sampleComboBox.DropDown += new System.EventHandler(this.sampleComboBox_DropDown);
            this.sampleComboBox.SelectedIndexChanged += new System.EventHandler(this.sampleComboBox_SelectedIndexChanged);
            // 
            // frequencyRangeCheckbox
            // 
            this.frequencyRangeCheckbox.AutoSize = true;
            this.frequencyRangeCheckbox.Location = new System.Drawing.Point(74, 654);
            this.frequencyRangeCheckbox.Name = "frequencyRangeCheckbox";
            this.frequencyRangeCheckbox.Size = new System.Drawing.Size(162, 24);
            this.frequencyRangeCheckbox.TabIndex = 53;
            this.frequencyRangeCheckbox.Text = "Frequency Range";
            this.frequencyRangeCheckbox.UseVisualStyleBackColor = true;
            // 
            // cutoffLowTextBox
            // 
            this.cutoffLowTextBox.Location = new System.Drawing.Point(74, 709);
            this.cutoffLowTextBox.Name = "cutoffLowTextBox";
            this.cutoffLowTextBox.Size = new System.Drawing.Size(55, 26);
            this.cutoffLowTextBox.TabIndex = 54;
            // 
            // cutoffHighTextBox
            // 
            this.cutoffHighTextBox.Location = new System.Drawing.Point(160, 709);
            this.cutoffHighTextBox.Name = "cutoffHighTextBox";
            this.cutoffHighTextBox.Size = new System.Drawing.Size(51, 26);
            this.cutoffHighTextBox.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(135, 712);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 20);
            this.label12.TabIndex = 56;
            this.label12.Text = "to";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(217, 715);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 20);
            this.label13.TabIndex = 57;
            this.label13.Text = "Hz";
            // 
            // fractalMakerBackgroundWorker
            // 
            this.fractalMakerBackgroundWorker.WorkerReportsProgress = true;
            this.fractalMakerBackgroundWorker.WorkerSupportsCancellation = true;
            this.fractalMakerBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fractalMakerBackgroundWorker_DoWork);
            this.fractalMakerBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.fractalMakerBackgroundWorker_ProgressChanged);
            this.fractalMakerBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.fractalMakerBackgroundWorker_RunWorkerCompleted);
            // 
            // videoBackgroundWorker
            // 
            this.videoBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.videoBackgroundWorker_DoWork);
            // 
            // transitionVideoBackgroundWorker
            // 
            this.transitionVideoBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.transitionVideoBackgroundWorker_DoWork);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1393, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 58;
            this.label14.Text = "Preset:";
            // 
            // loopCheckbox
            // 
            this.loopCheckbox.AutoSize = true;
            this.loopCheckbox.Checked = true;
            this.loopCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loopCheckbox.ForeColor = System.Drawing.Color.White;
            this.loopCheckbox.Location = new System.Drawing.Point(70, 772);
            this.loopCheckbox.Name = "loopCheckbox";
            this.loopCheckbox.Size = new System.Drawing.Size(71, 24);
            this.loopCheckbox.TabIndex = 59;
            this.loopCheckbox.Text = "Loop";
            this.loopCheckbox.UseVisualStyleBackColor = true;
            this.loopCheckbox.CheckedChanged += new System.EventHandler(this.loopCheckbox_CheckedChanged);
            // 
            // starModeCheckbox
            // 
            this.starModeCheckbox.AutoSize = true;
            this.starModeCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.starModeCheckbox.ForeColor = System.Drawing.Color.White;
            this.starModeCheckbox.Location = new System.Drawing.Point(70, 821);
            this.starModeCheckbox.Name = "starModeCheckbox";
            this.starModeCheckbox.Size = new System.Drawing.Size(126, 24);
            this.starModeCheckbox.TabIndex = 60;
            this.starModeCheckbox.Text = "Circles Mode";
            this.starModeCheckbox.UseVisualStyleBackColor = false;
            this.starModeCheckbox.CheckedChanged += new System.EventHandler(this.starModeCheckbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1902, 1028);
            this.Controls.Add(this.starModeCheckbox);
            this.Controls.Add(this.loopCheckbox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cutoffHighTextBox);
            this.Controls.Add(this.cutoffLowTextBox);
            this.Controls.Add(this.frequencyRangeCheckbox);
            this.Controls.Add(this.sampleComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.oscillatorComboBox);
            this.Controls.Add(this.exportTransistionVideoButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.depthMinusButton);
            this.Controls.Add(this.exportVideoButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.f5TextBox);
            this.Controls.Add(this.e5TextBox);
            this.Controls.Add(this.s5TextBox);
            this.Controls.Add(this.f4TextBox);
            this.Controls.Add(this.e4TextBox);
            this.Controls.Add(this.s4TextBox);
            this.Controls.Add(this.f3TextBox);
            this.Controls.Add(this.e3TextBox);
            this.Controls.Add(this.s3TextBox);
            this.Controls.Add(this.f2TextBox);
            this.Controls.Add(this.e2TextBox);
            this.Controls.Add(this.s2TextBox);
            this.Controls.Add(this.f1TextBox);
            this.Controls.Add(this.e1TextBox);
            this.Controls.Add(this.s1TextBox);
            this.Controls.Add(this.f0TextBox);
            this.Controls.Add(this.e0TextBox);
            this.Controls.Add(this.s0TextBox);
            this.Controls.Add(this.baseFreqTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.savePresetButton);
            this.Controls.Add(this.loadPresetButton);
            this.Controls.Add(this.presetComboBox);
            this.Controls.Add(this.depthPlus);
            this.Controls.Add(this.maxWavesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minWavesTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.generatedLabel);
            this.Controls.Add(this.amplitudeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopAnimationButton);
            this.Controls.Add(this.waveFormBox);
            this.Controls.Add(this.animateButton);
            this.Controls.Add(this.playSound);
            this.Controls.Add(this.fractalBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Fractal Music Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fractalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveFormBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fractalBox;
        private System.Windows.Forms.PictureBox waveFormBox;
        private System.Windows.Forms.Button stopAnimationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amplitudeTextBox;
        private System.Windows.Forms.Button playSound;
        private System.Windows.Forms.Button animateButton;
        private System.Windows.Forms.Label generatedLabel;
        private System.Windows.Forms.TextBox maxWavesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minWavesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button depthPlus;
        private System.Windows.Forms.ComboBox presetComboBox;
        private System.Windows.Forms.Button loadPresetButton;
        private System.Windows.Forms.Button savePresetButton;
        private System.Windows.Forms.TextBox baseFreqTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox s0TextBox;
        private System.Windows.Forms.TextBox e0TextBox;
        private System.Windows.Forms.TextBox f0TextBox;
        private System.Windows.Forms.TextBox f1TextBox;
        private System.Windows.Forms.TextBox e1TextBox;
        private System.Windows.Forms.TextBox s1TextBox;
        private System.Windows.Forms.TextBox f2TextBox;
        private System.Windows.Forms.TextBox e2TextBox;
        private System.Windows.Forms.TextBox s2TextBox;
        private System.Windows.Forms.TextBox f3TextBox;
        private System.Windows.Forms.TextBox e3TextBox;
        private System.Windows.Forms.TextBox s3TextBox;
        private System.Windows.Forms.TextBox f4TextBox;
        private System.Windows.Forms.TextBox e4TextBox;
        private System.Windows.Forms.TextBox s4TextBox;
        private System.Windows.Forms.TextBox f5TextBox;
        private System.Windows.Forms.TextBox e5TextBox;
        private System.Windows.Forms.TextBox s5TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button exportVideoButton;
        private System.Windows.Forms.Button depthMinusButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button exportTransistionVideoButton;
        private System.Windows.Forms.ComboBox oscillatorComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox sampleComboBox;
        private System.Windows.Forms.CheckBox frequencyRangeCheckbox;
        private System.Windows.Forms.TextBox cutoffLowTextBox;
        private System.Windows.Forms.TextBox cutoffHighTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.ComponentModel.BackgroundWorker fractalMakerBackgroundWorker;
        private System.ComponentModel.BackgroundWorker videoBackgroundWorker;
        private System.ComponentModel.BackgroundWorker transitionVideoBackgroundWorker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox loopCheckbox;
        private System.Windows.Forms.CheckBox starModeCheckbox;
    }
}

