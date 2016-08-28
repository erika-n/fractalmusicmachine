﻿namespace SoundLabUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fractalBox = new System.Windows.Forms.PictureBox();
            this.waveFormBox = new System.Windows.Forms.PictureBox();
            this.stopAnimationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
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
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.secondsPlusButton = new System.Windows.Forms.Button();
            this.secondsMinusButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fractalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveFormBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // fractalBox
            // 
            this.fractalBox.BackColor = System.Drawing.Color.Transparent;
            this.fractalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fractalBox.Location = new System.Drawing.Point(865, 20);
            this.fractalBox.Name = "fractalBox";
            this.fractalBox.Size = new System.Drawing.Size(934, 831);
            this.fractalBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fractalBox.TabIndex = 1;
            this.fractalBox.TabStop = false;
            // 
            // waveFormBox
            // 
            this.waveFormBox.Location = new System.Drawing.Point(1018, 884);
            this.waveFormBox.Name = "waveFormBox";
            this.waveFormBox.Size = new System.Drawing.Size(610, 65);
            this.waveFormBox.TabIndex = 3;
            this.waveFormBox.TabStop = false;
            // 
            // stopAnimationButton
            // 
            this.stopAnimationButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.stopAnimationButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopAnimationButton.ForeColor = System.Drawing.Color.White;
            this.stopAnimationButton.Location = new System.Drawing.Point(488, 966);
            this.stopAnimationButton.Name = "stopAnimationButton";
            this.stopAnimationButton.Size = new System.Drawing.Size(272, 54);
            this.stopAnimationButton.TabIndex = 4;
            this.stopAnimationButton.Text = "Stop";
            this.stopAnimationButton.UseVisualStyleBackColor = false;
            this.stopAnimationButton.Click += new System.EventHandler(this.stopAnimationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Depth:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // depthTextBox
            // 
            this.depthTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.depthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthTextBox.Location = new System.Drawing.Point(225, 98);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(83, 44);
            this.depthTextBox.TabIndex = 6;
            this.depthTextBox.Text = "2";
            this.depthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.goButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.ForeColor = System.Drawing.Color.White;
            this.goButton.Location = new System.Drawing.Point(22, 262);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(341, 84);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "Generate";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seconds:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.secondsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsTextBox.Location = new System.Drawing.Point(225, 169);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(83, 44);
            this.secondsTextBox.TabIndex = 9;
            this.secondsTextBox.Text = "10";
            this.secondsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // animateButton
            // 
            this.animateButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.animateButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animateButton.ForeColor = System.Drawing.Color.White;
            this.animateButton.Location = new System.Drawing.Point(488, 858);
            this.animateButton.Name = "animateButton";
            this.animateButton.Size = new System.Drawing.Size(272, 89);
            this.animateButton.TabIndex = 2;
            this.animateButton.Text = "GO";
            this.animateButton.UseVisualStyleBackColor = false;
            this.animateButton.Click += new System.EventHandler(this.animateButton_Click);
            // 
            // generatedLabel
            // 
            this.generatedLabel.AutoSize = true;
            this.generatedLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.generatedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.generatedLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedLabel.ForeColor = System.Drawing.Color.White;
            this.generatedLabel.Location = new System.Drawing.Point(854, 975);
            this.generatedLabel.Name = "generatedLabel";
            this.generatedLabel.Size = new System.Drawing.Size(145, 37);
            this.generatedLabel.TabIndex = 12;
            this.generatedLabel.Text = "Generated.";
            this.generatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generatedLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // maxWavesTextBox
            // 
            this.maxWavesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.maxWavesTextBox.Location = new System.Drawing.Point(130, 300);
            this.maxWavesTextBox.Name = "maxWavesTextBox";
            this.maxWavesTextBox.Size = new System.Drawing.Size(72, 26);
            this.maxWavesTextBox.TabIndex = 16;
            this.maxWavesTextBox.Text = "10";
            this.maxWavesTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Max waves:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // minWavesTextBox
            // 
            this.minWavesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.minWavesTextBox.Location = new System.Drawing.Point(130, 263);
            this.minWavesTextBox.Name = "minWavesTextBox";
            this.minWavesTextBox.Size = new System.Drawing.Size(72, 26);
            this.minWavesTextBox.TabIndex = 14;
            this.minWavesTextBox.Text = "10";
            this.minWavesTextBox.TextChanged += new System.EventHandler(this.minWavesTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Min waves:";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // depthPlus
            // 
            this.depthPlus.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.depthPlus.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthPlus.ForeColor = System.Drawing.Color.White;
            this.depthPlus.Location = new System.Drawing.Point(314, 97);
            this.depthPlus.Name = "depthPlus";
            this.depthPlus.Size = new System.Drawing.Size(51, 45);
            this.depthPlus.TabIndex = 17;
            this.depthPlus.Text = "+";
            this.depthPlus.UseVisualStyleBackColor = false;
            this.depthPlus.Click += new System.EventHandler(this.depthPlus_Click);
            // 
            // presetComboBox
            // 
            this.presetComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetComboBox.FormattingEnabled = true;
            this.presetComboBox.Location = new System.Drawing.Point(21, 68);
            this.presetComboBox.Name = "presetComboBox";
            this.presetComboBox.Size = new System.Drawing.Size(349, 37);
            this.presetComboBox.TabIndex = 19;
            this.presetComboBox.Text = "latest";
            this.presetComboBox.SelectedIndexChanged += new System.EventHandler(this.presetComboBox_SelectedIndexChanged);
            // 
            // loadPresetButton
            // 
            this.loadPresetButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.loadPresetButton.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPresetButton.ForeColor = System.Drawing.Color.White;
            this.loadPresetButton.Location = new System.Drawing.Point(21, 121);
            this.loadPresetButton.Name = "loadPresetButton";
            this.loadPresetButton.Size = new System.Drawing.Size(165, 58);
            this.loadPresetButton.TabIndex = 20;
            this.loadPresetButton.Text = "Load";
            this.loadPresetButton.UseVisualStyleBackColor = false;
            this.loadPresetButton.Click += new System.EventHandler(this.loadPresetButton_Click);
            // 
            // savePresetButton
            // 
            this.savePresetButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.savePresetButton.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePresetButton.ForeColor = System.Drawing.Color.White;
            this.savePresetButton.Location = new System.Drawing.Point(205, 121);
            this.savePresetButton.Name = "savePresetButton";
            this.savePresetButton.Size = new System.Drawing.Size(165, 58);
            this.savePresetButton.TabIndex = 21;
            this.savePresetButton.Text = "Save";
            this.savePresetButton.UseVisualStyleBackColor = false;
            this.savePresetButton.Click += new System.EventHandler(this.savePresetButton_Click);
            // 
            // baseFreqTextBox
            // 
            this.baseFreqTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.baseFreqTextBox.Location = new System.Drawing.Point(19, 107);
            this.baseFreqTextBox.Name = "baseFreqTextBox";
            this.baseFreqTextBox.Size = new System.Drawing.Size(72, 26);
            this.baseFreqTextBox.TabIndex = 23;
            this.baseFreqTextBox.Text = "4";
            this.baseFreqTextBox.TextChanged += new System.EventHandler(this.baseFreqTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Frequency factor:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // s0TextBox
            // 
            this.s0TextBox.Location = new System.Drawing.Point(24, 87);
            this.s0TextBox.Name = "s0TextBox";
            this.s0TextBox.Size = new System.Drawing.Size(59, 26);
            this.s0TextBox.TabIndex = 24;
            this.s0TextBox.TextChanged += new System.EventHandler(this.s0TextBox_TextChanged);
            // 
            // e0TextBox
            // 
            this.e0TextBox.Location = new System.Drawing.Point(106, 87);
            this.e0TextBox.Name = "e0TextBox";
            this.e0TextBox.Size = new System.Drawing.Size(59, 26);
            this.e0TextBox.TabIndex = 25;
            this.e0TextBox.TextChanged += new System.EventHandler(this.e0TextBox_TextChanged);
            // 
            // f0TextBox
            // 
            this.f0TextBox.Location = new System.Drawing.Point(184, 87);
            this.f0TextBox.Name = "f0TextBox";
            this.f0TextBox.Size = new System.Drawing.Size(59, 26);
            this.f0TextBox.TabIndex = 26;
            this.f0TextBox.TextChanged += new System.EventHandler(this.f0TextBox_TextChanged);
            // 
            // f1TextBox
            // 
            this.f1TextBox.Location = new System.Drawing.Point(184, 131);
            this.f1TextBox.Name = "f1TextBox";
            this.f1TextBox.Size = new System.Drawing.Size(59, 26);
            this.f1TextBox.TabIndex = 29;
            this.f1TextBox.TextChanged += new System.EventHandler(this.f1TextBox_TextChanged);
            // 
            // e1TextBox
            // 
            this.e1TextBox.Location = new System.Drawing.Point(106, 131);
            this.e1TextBox.Name = "e1TextBox";
            this.e1TextBox.Size = new System.Drawing.Size(59, 26);
            this.e1TextBox.TabIndex = 28;
            this.e1TextBox.TextChanged += new System.EventHandler(this.e1TextBox_TextChanged);
            // 
            // s1TextBox
            // 
            this.s1TextBox.Location = new System.Drawing.Point(24, 131);
            this.s1TextBox.Name = "s1TextBox";
            this.s1TextBox.Size = new System.Drawing.Size(59, 26);
            this.s1TextBox.TabIndex = 27;
            this.s1TextBox.TextChanged += new System.EventHandler(this.s1TextBox_TextChanged);
            // 
            // f2TextBox
            // 
            this.f2TextBox.Location = new System.Drawing.Point(184, 175);
            this.f2TextBox.Name = "f2TextBox";
            this.f2TextBox.Size = new System.Drawing.Size(59, 26);
            this.f2TextBox.TabIndex = 32;
            this.f2TextBox.TextChanged += new System.EventHandler(this.f2TextBox_TextChanged);
            // 
            // e2TextBox
            // 
            this.e2TextBox.Location = new System.Drawing.Point(106, 175);
            this.e2TextBox.Name = "e2TextBox";
            this.e2TextBox.Size = new System.Drawing.Size(59, 26);
            this.e2TextBox.TabIndex = 31;
            this.e2TextBox.TextChanged += new System.EventHandler(this.e2TextBox_TextChanged);
            // 
            // s2TextBox
            // 
            this.s2TextBox.Location = new System.Drawing.Point(24, 175);
            this.s2TextBox.Name = "s2TextBox";
            this.s2TextBox.Size = new System.Drawing.Size(59, 26);
            this.s2TextBox.TabIndex = 30;
            this.s2TextBox.TextChanged += new System.EventHandler(this.s2TextBox_TextChanged);
            // 
            // f3TextBox
            // 
            this.f3TextBox.Location = new System.Drawing.Point(184, 219);
            this.f3TextBox.Name = "f3TextBox";
            this.f3TextBox.Size = new System.Drawing.Size(59, 26);
            this.f3TextBox.TabIndex = 35;
            this.f3TextBox.TextChanged += new System.EventHandler(this.f3TextBox_TextChanged);
            // 
            // e3TextBox
            // 
            this.e3TextBox.Location = new System.Drawing.Point(106, 219);
            this.e3TextBox.Name = "e3TextBox";
            this.e3TextBox.Size = new System.Drawing.Size(59, 26);
            this.e3TextBox.TabIndex = 34;
            this.e3TextBox.TextChanged += new System.EventHandler(this.e3TextBox_TextChanged);
            // 
            // s3TextBox
            // 
            this.s3TextBox.Location = new System.Drawing.Point(24, 219);
            this.s3TextBox.Name = "s3TextBox";
            this.s3TextBox.Size = new System.Drawing.Size(59, 26);
            this.s3TextBox.TabIndex = 33;
            this.s3TextBox.TextChanged += new System.EventHandler(this.s3TextBox_TextChanged);
            // 
            // f4TextBox
            // 
            this.f4TextBox.Location = new System.Drawing.Point(184, 263);
            this.f4TextBox.Name = "f4TextBox";
            this.f4TextBox.Size = new System.Drawing.Size(59, 26);
            this.f4TextBox.TabIndex = 38;
            this.f4TextBox.TextChanged += new System.EventHandler(this.f4TextBox_TextChanged);
            // 
            // e4TextBox
            // 
            this.e4TextBox.Location = new System.Drawing.Point(106, 263);
            this.e4TextBox.Name = "e4TextBox";
            this.e4TextBox.Size = new System.Drawing.Size(59, 26);
            this.e4TextBox.TabIndex = 37;
            this.e4TextBox.TextChanged += new System.EventHandler(this.e4TextBox_TextChanged);
            // 
            // s4TextBox
            // 
            this.s4TextBox.Location = new System.Drawing.Point(24, 263);
            this.s4TextBox.Name = "s4TextBox";
            this.s4TextBox.Size = new System.Drawing.Size(59, 26);
            this.s4TextBox.TabIndex = 36;
            this.s4TextBox.TextChanged += new System.EventHandler(this.s4TextBox_TextChanged);
            // 
            // f5TextBox
            // 
            this.f5TextBox.Location = new System.Drawing.Point(184, 307);
            this.f5TextBox.Name = "f5TextBox";
            this.f5TextBox.Size = new System.Drawing.Size(59, 26);
            this.f5TextBox.TabIndex = 41;
            this.f5TextBox.TextChanged += new System.EventHandler(this.f5TextBox_TextChanged);
            // 
            // e5TextBox
            // 
            this.e5TextBox.Location = new System.Drawing.Point(106, 307);
            this.e5TextBox.Name = "e5TextBox";
            this.e5TextBox.Size = new System.Drawing.Size(59, 26);
            this.e5TextBox.TabIndex = 40;
            this.e5TextBox.TextChanged += new System.EventHandler(this.e5TextBox_TextChanged);
            // 
            // s5TextBox
            // 
            this.s5TextBox.Location = new System.Drawing.Point(24, 307);
            this.s5TextBox.Name = "s5TextBox";
            this.s5TextBox.Size = new System.Drawing.Size(59, 26);
            this.s5TextBox.TabIndex = 39;
            this.s5TextBox.TextChanged += new System.EventHandler(this.s5TextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Start";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "End";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 24);
            this.label9.TabIndex = 44;
            this.label9.Text = "Freq";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // exportVideoButton
            // 
            this.exportVideoButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.exportVideoButton.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportVideoButton.ForeColor = System.Drawing.Color.White;
            this.exportVideoButton.Location = new System.Drawing.Point(845, 858);
            this.exportVideoButton.Name = "exportVideoButton";
            this.exportVideoButton.Size = new System.Drawing.Size(195, 58);
            this.exportVideoButton.TabIndex = 45;
            this.exportVideoButton.Text = "Export Video";
            this.exportVideoButton.UseVisualStyleBackColor = false;
            this.exportVideoButton.Visible = false;
            this.exportVideoButton.Click += new System.EventHandler(this.exportVideoButton_Click);
            // 
            // depthMinusButton
            // 
            this.depthMinusButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.depthMinusButton.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthMinusButton.ForeColor = System.Drawing.Color.White;
            this.depthMinusButton.Location = new System.Drawing.Point(172, 98);
            this.depthMinusButton.Name = "depthMinusButton";
            this.depthMinusButton.Size = new System.Drawing.Size(47, 45);
            this.depthMinusButton.TabIndex = 46;
            this.depthMinusButton.Text = "-\r\n";
            this.depthMinusButton.UseVisualStyleBackColor = false;
            this.depthMinusButton.Click += new System.EventHandler(this.depthMinus_click);
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.randomButton.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomButton.ForeColor = System.Drawing.Color.White;
            this.randomButton.Location = new System.Drawing.Point(24, 358);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(226, 40);
            this.randomButton.TabIndex = 47;
            this.randomButton.Text = "Randomize";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // exportTransistionVideoButton
            // 
            this.exportTransistionVideoButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.exportTransistionVideoButton.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportTransistionVideoButton.ForeColor = System.Drawing.Color.White;
            this.exportTransistionVideoButton.Location = new System.Drawing.Point(845, 796);
            this.exportTransistionVideoButton.Name = "exportTransistionVideoButton";
            this.exportTransistionVideoButton.Size = new System.Drawing.Size(262, 55);
            this.exportTransistionVideoButton.TabIndex = 48;
            this.exportTransistionVideoButton.Text = "Export Transistion Video\r\n";
            this.exportTransistionVideoButton.UseVisualStyleBackColor = false;
            this.exportTransistionVideoButton.Visible = false;
            this.exportTransistionVideoButton.Click += new System.EventHandler(this.exportTransistionVideo_click);
            // 
            // oscillatorComboBox
            // 
            this.oscillatorComboBox.FormattingEnabled = true;
            this.oscillatorComboBox.Location = new System.Drawing.Point(25, 73);
            this.oscillatorComboBox.Name = "oscillatorComboBox";
            this.oscillatorComboBox.Size = new System.Drawing.Size(349, 28);
            this.oscillatorComboBox.TabIndex = 49;
            this.oscillatorComboBox.SelectedIndexChanged += new System.EventHandler(this.oscillatorComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(111, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 36);
            this.label10.TabIndex = 50;
            this.label10.Text = "Oscillator";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 29);
            this.label11.TabIndex = 51;
            this.label11.Text = "Sample:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // sampleComboBox
            // 
            this.sampleComboBox.FormattingEnabled = true;
            this.sampleComboBox.Location = new System.Drawing.Point(22, 197);
            this.sampleComboBox.Name = "sampleComboBox";
            this.sampleComboBox.Size = new System.Drawing.Size(349, 28);
            this.sampleComboBox.TabIndex = 52;
            this.sampleComboBox.DropDown += new System.EventHandler(this.sampleComboBox_DropDown);
            this.sampleComboBox.SelectedIndexChanged += new System.EventHandler(this.sampleComboBox_SelectedIndexChanged);
            // 
            // frequencyRangeCheckbox
            // 
            this.frequencyRangeCheckbox.AutoSize = true;
            this.frequencyRangeCheckbox.Checked = true;
            this.frequencyRangeCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.frequencyRangeCheckbox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyRangeCheckbox.Location = new System.Drawing.Point(20, 163);
            this.frequencyRangeCheckbox.Name = "frequencyRangeCheckbox";
            this.frequencyRangeCheckbox.Size = new System.Drawing.Size(178, 28);
            this.frequencyRangeCheckbox.TabIndex = 53;
            this.frequencyRangeCheckbox.Text = "Frequency Range";
            this.frequencyRangeCheckbox.UseVisualStyleBackColor = true;
            this.frequencyRangeCheckbox.CheckedChanged += new System.EventHandler(this.frequencyRangeCheckbox_CheckedChanged);
            // 
            // cutoffLowTextBox
            // 
            this.cutoffLowTextBox.Location = new System.Drawing.Point(19, 202);
            this.cutoffLowTextBox.Name = "cutoffLowTextBox";
            this.cutoffLowTextBox.Size = new System.Drawing.Size(55, 26);
            this.cutoffLowTextBox.TabIndex = 54;
            this.cutoffLowTextBox.Text = "150";
            this.cutoffLowTextBox.TextChanged += new System.EventHandler(this.cutoffLowTextBox_TextChanged);
            // 
            // cutoffHighTextBox
            // 
            this.cutoffHighTextBox.Location = new System.Drawing.Point(105, 202);
            this.cutoffHighTextBox.Name = "cutoffHighTextBox";
            this.cutoffHighTextBox.Size = new System.Drawing.Size(51, 26);
            this.cutoffHighTextBox.TabIndex = 55;
            this.cutoffHighTextBox.Text = "8000";
            this.cutoffHighTextBox.TextChanged += new System.EventHandler(this.cutoffHighTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(80, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 24);
            this.label12.TabIndex = 56;
            this.label12.Text = "to";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(162, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 24);
            this.label13.TabIndex = 57;
            this.label13.Text = "Hz";
            this.label13.Click += new System.EventHandler(this.label13_Click);
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
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(95, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 36);
            this.label14.TabIndex = 58;
            this.label14.Text = "Load Fractal";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // loopCheckbox
            // 
            this.loopCheckbox.AutoSize = true;
            this.loopCheckbox.Checked = true;
            this.loopCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loopCheckbox.ForeColor = System.Drawing.Color.Black;
            this.loopCheckbox.Location = new System.Drawing.Point(830, 742);
            this.loopCheckbox.Name = "loopCheckbox";
            this.loopCheckbox.Size = new System.Drawing.Size(71, 24);
            this.loopCheckbox.TabIndex = 59;
            this.loopCheckbox.Text = "Loop";
            this.loopCheckbox.UseVisualStyleBackColor = true;
            this.loopCheckbox.Visible = false;
            this.loopCheckbox.CheckedChanged += new System.EventHandler(this.loopCheckbox_CheckedChanged);
            // 
            // starModeCheckbox
            // 
            this.starModeCheckbox.AutoSize = true;
            this.starModeCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.starModeCheckbox.ForeColor = System.Drawing.Color.Black;
            this.starModeCheckbox.Location = new System.Drawing.Point(917, 742);
            this.starModeCheckbox.Name = "starModeCheckbox";
            this.starModeCheckbox.Size = new System.Drawing.Size(82, 24);
            this.starModeCheckbox.TabIndex = 60;
            this.starModeCheckbox.Text = "Circles";
            this.starModeCheckbox.UseVisualStyleBackColor = false;
            this.starModeCheckbox.Visible = false;
            this.starModeCheckbox.CheckedChanged += new System.EventHandler(this.starModeCheckbox_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(83, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 36);
            this.label15.TabIndex = 61;
            this.label15.Text = "Notes";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(147, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(224, 20);
            this.label16.TabIndex = 62;
            this.label16.Text = "(If Sample oscillator is chosen)";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 36);
            this.label3.TabIndex = 63;
            this.label3.Text = "Controls";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(823, 708);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 20);
            this.label17.TabIndex = 64;
            this.label17.Text = "Animation type:";
            this.label17.Visible = false;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.randomButton);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.f5TextBox);
            this.panel2.Controls.Add(this.e5TextBox);
            this.panel2.Controls.Add(this.s5TextBox);
            this.panel2.Controls.Add(this.f4TextBox);
            this.panel2.Controls.Add(this.e4TextBox);
            this.panel2.Controls.Add(this.s4TextBox);
            this.panel2.Controls.Add(this.f3TextBox);
            this.panel2.Controls.Add(this.e3TextBox);
            this.panel2.Controls.Add(this.s3TextBox);
            this.panel2.Controls.Add(this.f2TextBox);
            this.panel2.Controls.Add(this.e2TextBox);
            this.panel2.Controls.Add(this.s2TextBox);
            this.panel2.Controls.Add(this.f1TextBox);
            this.panel2.Controls.Add(this.e1TextBox);
            this.panel2.Controls.Add(this.s1TextBox);
            this.panel2.Controls.Add(this.f0TextBox);
            this.panel2.Controls.Add(this.e0TextBox);
            this.panel2.Controls.Add(this.s0TextBox);
            this.panel2.Location = new System.Drawing.Point(488, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 414);
            this.panel2.TabIndex = 66;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.savePresetButton);
            this.panel3.Controls.Add(this.loadPresetButton);
            this.panel3.Controls.Add(this.presetComboBox);
            this.panel3.Location = new System.Drawing.Point(71, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 206);
            this.panel3.TabIndex = 67;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.sampleComboBox);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.oscillatorComboBox);
            this.panel4.Location = new System.Drawing.Point(71, 313);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 256);
            this.panel4.TabIndex = 68;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.secondsPlusButton);
            this.panel5.Controls.Add(this.secondsMinusButton);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.goButton);
            this.panel5.Controls.Add(this.depthMinusButton);
            this.panel5.Controls.Add(this.depthPlus);
            this.panel5.Controls.Add(this.secondsTextBox);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.depthTextBox);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(71, 642);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(391, 378);
            this.panel5.TabIndex = 69;
            // 
            // secondsPlusButton
            // 
            this.secondsPlusButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.secondsPlusButton.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsPlusButton.ForeColor = System.Drawing.Color.White;
            this.secondsPlusButton.Location = new System.Drawing.Point(314, 169);
            this.secondsPlusButton.Name = "secondsPlusButton";
            this.secondsPlusButton.Size = new System.Drawing.Size(51, 45);
            this.secondsPlusButton.TabIndex = 73;
            this.secondsPlusButton.Text = "+";
            this.secondsPlusButton.UseVisualStyleBackColor = false;
            this.secondsPlusButton.Click += new System.EventHandler(this.secondsPlusButton_Click);
            // 
            // secondsMinusButton
            // 
            this.secondsMinusButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.secondsMinusButton.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsMinusButton.ForeColor = System.Drawing.Color.White;
            this.secondsMinusButton.Location = new System.Drawing.Point(172, 168);
            this.secondsMinusButton.Name = "secondsMinusButton";
            this.secondsMinusButton.Size = new System.Drawing.Size(47, 45);
            this.secondsMinusButton.TabIndex = 72;
            this.secondsMinusButton.Text = "-\r\n";
            this.secondsMinusButton.UseVisualStyleBackColor = false;
            this.secondsMinusButton.Click += new System.EventHandler(this.secondsMinusButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(172, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 45);
            this.button1.TabIndex = 72;
            this.button1.Text = "-\r\n";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(69, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(237, 40);
            this.label18.TabIndex = 71;
            this.label18.Text = "Make Fractal";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.cutoffHighTextBox);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.cutoffLowTextBox);
            this.panel6.Controls.Add(this.frequencyRangeCheckbox);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.baseFreqTextBox);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.maxWavesTextBox);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.minWavesTextBox);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(488, 466);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(272, 364);
            this.panel6.TabIndex = 70;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(183, -395);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 24);
            this.label24.TabIndex = 44;
            this.label24.Text = "Freq";
            this.label24.Click += new System.EventHandler(this.label9_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(105, -395);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 24);
            this.label23.TabIndex = 43;
            this.label23.Text = "End";
            this.label23.Click += new System.EventHandler(this.label8_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(21, -395);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 24);
            this.label22.TabIndex = 42;
            this.label22.Text = "Start";
            this.label22.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1894, 1061);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.starModeCheckbox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.stopAnimationButton);
            this.Controls.Add(this.loopCheckbox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.animateButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exportTransistionVideoButton);
            this.Controls.Add(this.exportVideoButton);
            this.Controls.Add(this.generatedLabel);
            this.Controls.Add(this.waveFormBox);
            this.Controls.Add(this.fractalBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fractal Music Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fractalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveFormBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button secondsPlusButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button secondsMinusButton;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
    }
}

