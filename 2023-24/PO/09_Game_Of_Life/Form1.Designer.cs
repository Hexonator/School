﻿namespace _09_Game_Of_Life
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
            StartButton = new Button();
            Increment_UpDown = new NumericUpDown();
            Increment_label = new Label();
            ((System.ComponentModel.ISupportInitialize)Width_UpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Height_UpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Increment_UpDown).BeginInit();
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
            Width_UpDown.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            Width_UpDown.Name = "Width_UpDown";
            Width_UpDown.Size = new Size(83, 23);
            Width_UpDown.TabIndex = 2;
            Width_UpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // Height_UpDown
            // 
            Height_UpDown.Location = new Point(61, 44);
            Height_UpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Height_UpDown.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            Height_UpDown.Name = "Height_UpDown";
            Height_UpDown.Size = new Size(83, 23);
            Height_UpDown.TabIndex = 3;
            Height_UpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // GameField
            // 
            GameField.Location = new Point(163, 12);
            GameField.Name = "GameField";
            GameField.Size = new Size(871, 508);
            GameField.TabIndex = 4;
            GameField.Paint += DrawInPanel;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(12, 82);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(132, 23);
            StartButton.TabIndex = 5;
            StartButton.Text = "Start Simulation";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartClick;
            // 
            // Increment_UpDown
            // 
            Increment_UpDown.Location = new Point(83, 113);
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
            Increment_label.Location = new Point(11, 116);
            Increment_label.Name = "Increment_label";
            Increment_label.Size = new Size(65, 15);
            Increment_label.TabIndex = 7;
            Increment_label.Text = "Square size";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 532);
            Controls.Add(Increment_label);
            Controls.Add(Increment_UpDown);
            Controls.Add(StartButton);
            Controls.Add(GameField);
            Controls.Add(Height_UpDown);
            Controls.Add(Width_UpDown);
            Controls.Add(Height_label);
            Controls.Add(Width_label);
            Name = "Form1";
            Text = "Game Of Life";
            ((System.ComponentModel.ISupportInitialize)Width_UpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Height_UpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Increment_UpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Width_label;
        private Label Height_label;
        private NumericUpDown Width_UpDown;
        private NumericUpDown Height_UpDown;
        private Panel GameField;
        private Button StartButton;
        private NumericUpDown Increment_UpDown;
        private Label Increment_label;
    }
}