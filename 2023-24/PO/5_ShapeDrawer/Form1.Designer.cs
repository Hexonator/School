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
            // 
            // UpDownSize
            // 
            UpDownSize.Location = new Point(12, 62);
            UpDownSize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            UpDownSize.Name = "UpDownSize";
            UpDownSize.Size = new Size(61, 23);
            UpDownSize.TabIndex = 3;
            UpDownSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}