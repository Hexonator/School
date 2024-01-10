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
            DebugTextBox = new TextBox();
            TimeStepLabel = new Label();
            TimeStep_UpDown = new NumericUpDown();
            StartButton = new Button();
            EndButton = new Button();
            Grid_CheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)Width_UpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Height_UpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Increment_UpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TimeStep_UpDown).BeginInit();
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
            GameField.AutoScroll = true;
            GameField.Cursor = Cursors.Cross;
            GameField.Location = new Point(163, 12);
            GameField.Name = "GameField";
            GameField.Size = new Size(609, 607);
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
            Increment_UpDown.Location = new Point(92, 189);
            Increment_UpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            Increment_UpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Increment_UpDown.Name = "Increment_UpDown";
            Increment_UpDown.Size = new Size(61, 23);
            Increment_UpDown.TabIndex = 6;
            Increment_UpDown.Value = new decimal(new int[] { 7, 0, 0, 0 });
            Increment_UpDown.ValueChanged += IncrementValueChange;
            // 
            // Increment_label
            // 
            Increment_label.AutoSize = true;
            Increment_label.Location = new Point(92, 171);
            Increment_label.Name = "Increment_label";
            Increment_label.Size = new Size(65, 15);
            Increment_label.TabIndex = 7;
            Increment_label.Text = "Square size";
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
            // TimeStepLabel
            // 
            TimeStepLabel.AutoSize = true;
            TimeStepLabel.Location = new Point(4, 171);
            TimeStepLabel.Name = "TimeStepLabel";
            TimeStepLabel.Size = new Size(85, 15);
            TimeStepLabel.TabIndex = 9;
            TimeStepLabel.Text = "Time step (ms)";
            // 
            // TimeStep_UpDown
            // 
            TimeStep_UpDown.Location = new Point(12, 189);
            TimeStep_UpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            TimeStep_UpDown.Name = "TimeStep_UpDown";
            TimeStep_UpDown.Size = new Size(65, 23);
            TimeStep_UpDown.TabIndex = 10;
            TimeStep_UpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
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
            EndButton.Text = "End Simulation";
            EndButton.UseVisualStyleBackColor = true;
            EndButton.Click += EndButton_Click;
            // 
            // Grid_CheckBox
            // 
            Grid_CheckBox.AutoSize = true;
            Grid_CheckBox.Location = new Point(14, 230);
            Grid_CheckBox.Name = "Grid_CheckBox";
            Grid_CheckBox.Size = new Size(79, 19);
            Grid_CheckBox.TabIndex = 13;
            Grid_CheckBox.Text = "Show grid";
            Grid_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 631);
            Controls.Add(Grid_CheckBox);
            Controls.Add(EndButton);
            Controls.Add(StartButton);
            Controls.Add(TimeStep_UpDown);
            Controls.Add(TimeStepLabel);
            Controls.Add(DebugTextBox);
            Controls.Add(Increment_label);
            Controls.Add(Increment_UpDown);
            Controls.Add(StepButton);
            Controls.Add(GameField);
            Controls.Add(Height_UpDown);
            Controls.Add(Width_UpDown);
            Controls.Add(Height_label);
            Controls.Add(Width_label);
            KeyPreview = true;
            Name = "Form1";
            Text = "Game Of Life";
            ((System.ComponentModel.ISupportInitialize)Width_UpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Height_UpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Increment_UpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)TimeStep_UpDown).EndInit();
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
        private TextBox DebugTextBox;
        private Label TimeStepLabel;
        private NumericUpDown TimeStep_UpDown;
        private Button StartButton;
        private Button EndButton;
        private CheckBox Grid_CheckBox;
    }
}