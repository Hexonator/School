namespace _09_Game_Of_Life
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Width_label = new Label();
            Height_label = new Label();
            Width_UpDown = new NumericUpDown();
            Height_UpDown = new NumericUpDown();
            GameField = new Panel();
            StepButton = new Button();
            Increment_label = new Label();
            StartButton = new Button();
            EndButton = new Button();
            Grid_CheckBox = new CheckBox();
            panel1 = new Panel();
            SaveFileButton = new Button();
            LoadFileButton = new Button();
            Increment_Slider = new TrackBar();
            RefreshButton = new Button();
            SpeedLabel = new Label();
            Speed_Slider = new TrackBar();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            RandomFill_Label = new Label();
            RandomFill_Slider = new TrackBar();
            RandomFill_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)Width_UpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Height_UpDown).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Increment_Slider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Speed_Slider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RandomFill_Slider).BeginInit();
            SuspendLayout();
            // 
            // Width_label
            // 
            Width_label.AutoSize = true;
            Width_label.Location = new Point(19, 26);
            Width_label.Name = "Width_label";
            Width_label.Size = new Size(39, 15);
            Width_label.TabIndex = 0;
            Width_label.Text = "Width";
            // 
            // Height_label
            // 
            Height_label.AutoSize = true;
            Height_label.Location = new Point(19, 58);
            Height_label.Name = "Height_label";
            Height_label.Size = new Size(43, 15);
            Height_label.TabIndex = 1;
            Height_label.Text = "Height";
            // 
            // Width_UpDown
            // 
            Width_UpDown.Location = new Point(68, 22);
            Width_UpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Width_UpDown.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            Width_UpDown.Name = "Width_UpDown";
            Width_UpDown.Size = new Size(83, 23);
            Width_UpDown.TabIndex = 2;
            Width_UpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            Width_UpDown.ValueChanged += Width_ValueChange;
            // 
            // Height_UpDown
            // 
            Height_UpDown.Location = new Point(68, 54);
            Height_UpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Height_UpDown.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            Height_UpDown.Name = "Height_UpDown";
            Height_UpDown.Size = new Size(83, 23);
            Height_UpDown.TabIndex = 3;
            Height_UpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            Height_UpDown.ValueChanged += Height_ValueChanged;
            // 
            // GameField
            // 
            GameField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            GameField.AutoScroll = true;
            GameField.BackColor = SystemColors.ActiveCaptionText;
            GameField.BorderStyle = BorderStyle.FixedSingle;
            GameField.Cursor = Cursors.Cross;
            GameField.Location = new Point(189, 0);
            GameField.Name = "GameField";
            GameField.Size = new Size(751, 631);
            GameField.TabIndex = 4;
            GameField.Click += GameField_Click;
            GameField.Paint += DrawInPanel;
            // 
            // StepButton
            // 
            StepButton.Location = new Point(19, 91);
            StepButton.Name = "StepButton";
            StepButton.Size = new Size(132, 23);
            StepButton.TabIndex = 5;
            StepButton.Text = "Step";
            StepButton.UseVisualStyleBackColor = true;
            StepButton.Click += StepClick;
            // 
            // Increment_label
            // 
            Increment_label.AutoSize = true;
            Increment_label.Location = new Point(14, 255);
            Increment_label.Name = "Increment_label";
            Increment_label.Size = new Size(39, 15);
            Increment_label.TabIndex = 7;
            Increment_label.Text = "Zoom";
            // 
            // StartButton
            // 
            StartButton.Location = new Point(19, 147);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(132, 23);
            StartButton.TabIndex = 11;
            StartButton.Text = "Start Simulation";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // EndButton
            // 
            EndButton.Location = new Point(19, 176);
            EndButton.Name = "EndButton";
            EndButton.Size = new Size(132, 23);
            EndButton.TabIndex = 12;
            EndButton.Text = "Pause Simulation";
            EndButton.UseVisualStyleBackColor = true;
            EndButton.Click += EndButton_Click;
            // 
            // Grid_CheckBox
            // 
            Grid_CheckBox.AutoSize = true;
            Grid_CheckBox.Location = new Point(14, 318);
            Grid_CheckBox.Name = "Grid_CheckBox";
            Grid_CheckBox.Size = new Size(79, 19);
            Grid_CheckBox.TabIndex = 13;
            Grid_CheckBox.Text = "Show grid";
            Grid_CheckBox.UseVisualStyleBackColor = true;
            Grid_CheckBox.CheckedChanged += GridCheckChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(SaveFileButton);
            panel1.Controls.Add(LoadFileButton);
            panel1.Controls.Add(Increment_Slider);
            panel1.Controls.Add(RefreshButton);
            panel1.Controls.Add(SpeedLabel);
            panel1.Controls.Add(Speed_Slider);
            panel1.Controls.Add(Grid_CheckBox);
            panel1.Controls.Add(Increment_label);
            panel1.Location = new Point(7, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 384);
            panel1.TabIndex = 0;
            // 
            // SaveFileButton
            // 
            SaveFileButton.Anchor = AnchorStyles.None;
            SaveFileButton.Location = new Point(89, 349);
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(66, 23);
            SaveFileButton.TabIndex = 24;
            SaveFileButton.Text = "Save file";
            SaveFileButton.UseVisualStyleBackColor = true;
            // 
            // LoadFileButton
            // 
            LoadFileButton.Anchor = AnchorStyles.None;
            LoadFileButton.Location = new Point(11, 349);
            LoadFileButton.Name = "LoadFileButton";
            LoadFileButton.Size = new Size(70, 23);
            LoadFileButton.TabIndex = 23;
            LoadFileButton.Text = "Load file";
            LoadFileButton.UseVisualStyleBackColor = true;
            LoadFileButton.Click += LoadFile_Pressed;
            // 
            // Increment_Slider
            // 
            Increment_Slider.Location = new Point(11, 273);
            Increment_Slider.Maximum = 20;
            Increment_Slider.Name = "Increment_Slider";
            Increment_Slider.Size = new Size(144, 45);
            Increment_Slider.TabIndex = 20;
            Increment_Slider.Value = 1;
            Increment_Slider.ValueChanged += IncrementSliderValChange;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(12, 108);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(132, 23);
            RefreshButton.TabIndex = 22;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.Location = new Point(17, 194);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new Size(39, 15);
            SpeedLabel.TabIndex = 21;
            SpeedLabel.Text = "Speed";
            // 
            // Speed_Slider
            // 
            Speed_Slider.Location = new Point(11, 213);
            Speed_Slider.Maximum = 20;
            Speed_Slider.Name = "Speed_Slider";
            Speed_Slider.Size = new Size(144, 45);
            Speed_Slider.TabIndex = 20;
            Speed_Slider.Value = 1;
            Speed_Slider.ValueChanged += Speed_Slider_ValueChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "txt";
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.Title = "Load Gamestate";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Title = "Save Gamestate";
            // 
            // RandomFill_Label
            // 
            RandomFill_Label.AutoSize = true;
            RandomFill_Label.Location = new Point(12, 408);
            RandomFill_Label.Name = "RandomFill_Label";
            RandomFill_Label.Size = new Size(70, 15);
            RandomFill_Label.TabIndex = 13;
            RandomFill_Label.Text = "Random Fill";
            // 
            // RandomFill_Slider
            // 
            RandomFill_Slider.Location = new Point(7, 438);
            RandomFill_Slider.Maximum = 100;
            RandomFill_Slider.Name = "RandomFill_Slider";
            RandomFill_Slider.Size = new Size(173, 45);
            RandomFill_Slider.TabIndex = 14;
            RandomFill_Slider.Value = 50;
            // 
            // RandomFill_Button
            // 
            RandomFill_Button.Location = new Point(12, 480);
            RandomFill_Button.Name = "RandomFill_Button";
            RandomFill_Button.Size = new Size(168, 23);
            RandomFill_Button.TabIndex = 15;
            RandomFill_Button.Text = "Random Fill";
            RandomFill_Button.UseVisualStyleBackColor = true;
            RandomFill_Button.Click += RandomFill_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 631);
            Controls.Add(RandomFill_Button);
            Controls.Add(RandomFill_Slider);
            Controls.Add(RandomFill_Label);
            Controls.Add(EndButton);
            Controls.Add(StartButton);
            Controls.Add(StepButton);
            Controls.Add(GameField);
            Controls.Add(Height_UpDown);
            Controls.Add(Width_UpDown);
            Controls.Add(Height_label);
            Controls.Add(Width_label);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Game Of Life";
            HelpRequested += Form1_HelpRequested;
            ((System.ComponentModel.ISupportInitialize)Width_UpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Height_UpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Increment_Slider).EndInit();
            ((System.ComponentModel.ISupportInitialize)Speed_Slider).EndInit();
            ((System.ComponentModel.ISupportInitialize)RandomFill_Slider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Width_label;
        private Label Height_label;
        private NumericUpDown Width_UpDown;
        private NumericUpDown Height_UpDown;
        private Panel GameField;
        private Button StepButton;
        private Label Increment_label;
        private Button StartButton;
        private Button EndButton;
        private CheckBox Grid_CheckBox;
        private Panel panel1;
        private TrackBar Speed_Slider;
        private Label SpeedLabel;
        private Button RefreshButton;
        private TrackBar Increment_Slider;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button SaveFileButton;
        private Button LoadFileButton;
        private Label RandomFill_Label;
        private TrackBar RandomFill_Slider;
        private Button RandomFill_Button;
    }
}