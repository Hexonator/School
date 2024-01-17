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
            Increment_UpDown = new NumericUpDown();
            Increment_label = new Label();
            StartButton = new Button();
            EndButton = new Button();
            Grid_CheckBox = new CheckBox();
            DebugTextBox = new TextBox();
            panel1 = new Panel();
            SpeedLabel = new Label();
            Speed_Slider = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)Width_UpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Height_UpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Increment_UpDown).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Speed_Slider).BeginInit();
            SuspendLayout();
            // 
            // Width_label
            // 
            Width_label.AutoSize = true;
            Width_label.Location = new Point(12, 16);
            Width_label.Name = "Width_label";
            Width_label.Size = new Size(39, 15);
            Width_label.TabIndex = 0;
            Width_label.Text = "Width";
            // 
            // Height_label
            // 
            Height_label.AutoSize = true;
            Height_label.Location = new Point(12, 48);
            Height_label.Name = "Height_label";
            Height_label.Size = new Size(43, 15);
            Height_label.TabIndex = 1;
            Height_label.Text = "Height";
            // 
            // Width_UpDown
            // 
            Width_UpDown.Location = new Point(61, 12);
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
            Height_UpDown.Location = new Point(61, 44);
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
            GameField.BorderStyle = BorderStyle.FixedSingle;
            GameField.Cursor = Cursors.Cross;
            GameField.Location = new Point(188, 0);
            GameField.Name = "GameField";
            GameField.Size = new Size(596, 631);
            GameField.TabIndex = 4;
            GameField.Click += GameField_Click;
            GameField.Paint += DrawInPanel;
            // 
            // StepButton
            // 
            StepButton.Location = new Point(12, 81);
            StepButton.Name = "StepButton";
            StepButton.Size = new Size(132, 23);
            StepButton.TabIndex = 5;
            StepButton.Text = "Step";
            StepButton.UseVisualStyleBackColor = true;
            StepButton.Click += StepClick;
            // 
            // Increment_UpDown
            // 
            Increment_UpDown.Location = new Point(14, 249);
            Increment_UpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            Increment_UpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Increment_UpDown.Name = "Increment_UpDown";
            Increment_UpDown.Size = new Size(73, 23);
            Increment_UpDown.TabIndex = 6;
            Increment_UpDown.Value = new decimal(new int[] { 7, 0, 0, 0 });
            Increment_UpDown.ValueChanged += IncrementValueChange;
            // 
            // Increment_label
            // 
            Increment_label.AutoSize = true;
            Increment_label.Location = new Point(14, 231);
            Increment_label.Name = "Increment_label";
            Increment_label.Size = new Size(65, 15);
            Increment_label.TabIndex = 7;
            Increment_label.Text = "Square size";
            // 
            // StartButton
            // 
            StartButton.Location = new Point(14, 110);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(130, 23);
            StartButton.TabIndex = 11;
            StartButton.Text = "Start Simulation";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // EndButton
            // 
            EndButton.Location = new Point(14, 139);
            EndButton.Name = "EndButton";
            EndButton.Size = new Size(130, 23);
            EndButton.TabIndex = 12;
            EndButton.Text = "Pause Simulation";
            EndButton.UseVisualStyleBackColor = true;
            EndButton.Click += EndButton_Click;
            // 
            // Grid_CheckBox
            // 
            Grid_CheckBox.AutoSize = true;
            Grid_CheckBox.Location = new Point(14, 278);
            Grid_CheckBox.Name = "Grid_CheckBox";
            Grid_CheckBox.Size = new Size(79, 19);
            Grid_CheckBox.TabIndex = 13;
            Grid_CheckBox.Text = "Show grid";
            Grid_CheckBox.UseVisualStyleBackColor = true;
            Grid_CheckBox.CheckedChanged += GridCheckChanged;
            // 
            // DebugTextBox
            // 
            DebugTextBox.AcceptsReturn = true;
            DebugTextBox.BorderStyle = BorderStyle.None;
            DebugTextBox.Location = new Point(11, 355);
            DebugTextBox.Multiline = true;
            DebugTextBox.Name = "DebugTextBox";
            DebugTextBox.ScrollBars = ScrollBars.Vertical;
            DebugTextBox.Size = new Size(146, 157);
            DebugTextBox.TabIndex = 8;
            DebugTextBox.Text = "Debug info will appear here";
            // 
            // panel1
            // 
            panel1.Controls.Add(SpeedLabel);
            panel1.Controls.Add(Speed_Slider);
            panel1.Controls.Add(Grid_CheckBox);
            panel1.Controls.Add(Increment_UpDown);
            panel1.Controls.Add(Increment_label);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 631);
            panel1.TabIndex = 0;
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.Location = new Point(17, 165);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new Size(39, 15);
            SpeedLabel.TabIndex = 21;
            SpeedLabel.Text = "Speed";
            // 
            // Speed_Slider
            // 
            Speed_Slider.Location = new Point(11, 184);
            Speed_Slider.Maximum = 20;
            Speed_Slider.Name = "Speed_Slider";
            Speed_Slider.Size = new Size(145, 45);
            Speed_Slider.TabIndex = 20;
            Speed_Slider.Value = 1;
            Speed_Slider.ValueChanged += Speed_Slider_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 631);
            Controls.Add(EndButton);
            Controls.Add(StartButton);
            Controls.Add(DebugTextBox);
            Controls.Add(StepButton);
            Controls.Add(GameField);
            Controls.Add(Height_UpDown);
            Controls.Add(Width_UpDown);
            Controls.Add(Height_label);
            Controls.Add(Width_label);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Game Of Life";
            ((System.ComponentModel.ISupportInitialize)Width_UpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Height_UpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Increment_UpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Speed_Slider).EndInit();
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
        private NumericUpDown Increment_UpDown;
        private Label Increment_label;
        private Button StartButton;
        private Button EndButton;
        private CheckBox Grid_CheckBox;
        private TextBox DebugTextBox;
        private Panel panel1;
        private TrackBar Speed_Slider;
        private Label SpeedLabel;
    }
}