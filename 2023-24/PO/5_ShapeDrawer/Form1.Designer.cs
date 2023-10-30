namespace _5_ShapeDrawer
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
            RadioButtonSquare = new RadioButton();
            RadioButtonCircle = new RadioButton();
            UpDownSize = new NumericUpDown();
            RadioButtonText = new RadioButton();
            TextLabel = new Label();
            TextInputBox = new TextBox();
            ButtonDeleteSelected = new Button();
            ButtonClearAll = new Button();
            label1 = new Label();
            ColorComboBox = new ComboBox();
            RadioButtonSelect = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)UpDownSize).BeginInit();
            SuspendLayout();
            // 
            // RadioButtonSquare
            // 
            RadioButtonSquare.AutoSize = true;
            RadioButtonSquare.Checked = true;
            RadioButtonSquare.Location = new Point(12, 12);
            RadioButtonSquare.Name = "RadioButtonSquare";
            RadioButtonSquare.Size = new Size(61, 19);
            RadioButtonSquare.TabIndex = 0;
            RadioButtonSquare.TabStop = true;
            RadioButtonSquare.Text = "Square";
            RadioButtonSquare.UseVisualStyleBackColor = true;
            RadioButtonSquare.CheckedChanged += RadioButtonSquare_CheckedChanged;
            // 
            // RadioButtonCircle
            // 
            RadioButtonCircle.AutoSize = true;
            RadioButtonCircle.Location = new Point(12, 37);
            RadioButtonCircle.Name = "RadioButtonCircle";
            RadioButtonCircle.Size = new Size(55, 19);
            RadioButtonCircle.TabIndex = 1;
            RadioButtonCircle.Text = "Circle";
            RadioButtonCircle.UseVisualStyleBackColor = true;
            RadioButtonCircle.CheckedChanged += RadioButtonCircle_CheckedChanged;
            // 
            // UpDownSize
            // 
            UpDownSize.Location = new Point(12, 134);
            UpDownSize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            UpDownSize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            UpDownSize.Name = "UpDownSize";
            UpDownSize.Size = new Size(61, 23);
            UpDownSize.TabIndex = 3;
            UpDownSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // RadioButtonText
            // 
            RadioButtonText.AutoSize = true;
            RadioButtonText.Location = new Point(12, 62);
            RadioButtonText.Name = "RadioButtonText";
            RadioButtonText.Size = new Size(46, 19);
            RadioButtonText.TabIndex = 4;
            RadioButtonText.Text = "Text";
            RadioButtonText.UseVisualStyleBackColor = true;
            RadioButtonText.CheckedChanged += RadioButtonText_CheckedChanged;
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.Location = new Point(12, 160);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(28, 15);
            TextLabel.TabIndex = 5;
            TextLabel.Text = "Text";
            // 
            // TextInputBox
            // 
            TextInputBox.Location = new Point(12, 178);
            TextInputBox.Name = "TextInputBox";
            TextInputBox.Size = new Size(104, 23);
            TextInputBox.TabIndex = 6;
            // 
            // ButtonDeleteSelected
            // 
            ButtonDeleteSelected.Location = new Point(12, 240);
            ButtonDeleteSelected.Name = "ButtonDeleteSelected";
            ButtonDeleteSelected.Size = new Size(104, 37);
            ButtonDeleteSelected.TabIndex = 7;
            ButtonDeleteSelected.Text = "Delete selected";
            ButtonDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // ButtonClearAll
            // 
            ButtonClearAll.Location = new Point(12, 283);
            ButtonClearAll.Name = "ButtonClearAll";
            ButtonClearAll.Size = new Size(104, 37);
            ButtonClearAll.TabIndex = 8;
            ButtonClearAll.Text = "Clear all";
            ButtonClearAll.UseVisualStyleBackColor = true;
            ButtonClearAll.Click += ButtonClearAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 9;
            label1.Text = "Size";
            // 
            // ColorComboBox
            // 
            ColorComboBox.FormattingEnabled = true;
            ColorComboBox.Items.AddRange(new object[] { "Green", "Red", "Blue", "Black", "White" });
            ColorComboBox.Location = new Point(12, 211);
            ColorComboBox.Name = "ColorComboBox";
            ColorComboBox.Size = new Size(104, 23);
            ColorComboBox.TabIndex = 10;
            // 
            // RadioButtonSelect
            // 
            RadioButtonSelect.AutoSize = true;
            RadioButtonSelect.Location = new Point(12, 87);
            RadioButtonSelect.Name = "RadioButtonSelect";
            RadioButtonSelect.Size = new Size(56, 19);
            RadioButtonSelect.TabIndex = 11;
            RadioButtonSelect.Text = "Select";
            RadioButtonSelect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 515);
            Controls.Add(RadioButtonSelect);
            Controls.Add(ColorComboBox);
            Controls.Add(label1);
            Controls.Add(ButtonClearAll);
            Controls.Add(ButtonDeleteSelected);
            Controls.Add(TextInputBox);
            Controls.Add(TextLabel);
            Controls.Add(RadioButtonText);
            Controls.Add(UpDownSize);
            Controls.Add(RadioButtonCircle);
            Controls.Add(RadioButtonSquare);
            Name = "Form1";
            Text = "Shape drawer";
            Paint += PaintInWindow;
            MouseDown += ClickOnWindow;
            ((System.ComponentModel.ISupportInitialize)UpDownSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RadioButtonSquare;
        private RadioButton RadioButtonCircle;
        private NumericUpDown UpDownSize;
        private RadioButton RadioButtonText;
        private Label TextLabel;
        private TextBox TextInputBox;
        private Button ButtonDeleteSelected;
        private Button ButtonClearAll;
        private Label label1;
        private ComboBox ColorComboBox;
        private RadioButton RadioButtonSelect;
    }
}