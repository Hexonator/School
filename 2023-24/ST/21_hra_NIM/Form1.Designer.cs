namespace _21_hra_NIM
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
            Drawing_Panel = new Panel();
            Settings_Panel = new Panel();
            GameSize_UpDown = new NumericUpDown();
            GameSize_Label = new Label();
            GameInfo_Panel = new Panel();
            Settings_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GameSize_UpDown).BeginInit();
            SuspendLayout();
            // 
            // Drawing_Panel
            // 
            Drawing_Panel.BorderStyle = BorderStyle.FixedSingle;
            Drawing_Panel.Location = new Point(12, 118);
            Drawing_Panel.Name = "Drawing_Panel";
            Drawing_Panel.Size = new Size(776, 217);
            Drawing_Panel.TabIndex = 0;
            Drawing_Panel.Paint += Drawing_Panel_Paint;
            // 
            // Settings_Panel
            // 
            Settings_Panel.BorderStyle = BorderStyle.FixedSingle;
            Settings_Panel.Controls.Add(GameSize_UpDown);
            Settings_Panel.Controls.Add(GameSize_Label);
            Settings_Panel.Location = new Point(12, 12);
            Settings_Panel.Name = "Settings_Panel";
            Settings_Panel.Size = new Size(208, 100);
            Settings_Panel.TabIndex = 1;
            // 
            // GameSize_UpDown
            // 
            GameSize_UpDown.Location = new Point(10, 27);
            GameSize_UpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            GameSize_UpDown.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            GameSize_UpDown.Name = "GameSize_UpDown";
            GameSize_UpDown.Size = new Size(86, 23);
            GameSize_UpDown.TabIndex = 1;
            GameSize_UpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            GameSize_UpDown.ValueChanged += GameSize_ValChange;
            // 
            // GameSize_Label
            // 
            GameSize_Label.AutoSize = true;
            GameSize_Label.Location = new Point(10, 9);
            GameSize_Label.Name = "GameSize_Label";
            GameSize_Label.Size = new Size(60, 15);
            GameSize_Label.TabIndex = 0;
            GameSize_Label.Text = "Game size";
            // 
            // GameInfo_Panel
            // 
            GameInfo_Panel.BorderStyle = BorderStyle.FixedSingle;
            GameInfo_Panel.Location = new Point(226, 12);
            GameInfo_Panel.Name = "GameInfo_Panel";
            GameInfo_Panel.Size = new Size(562, 100);
            GameInfo_Panel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 348);
            Controls.Add(GameInfo_Panel);
            Controls.Add(Settings_Panel);
            Controls.Add(Drawing_Panel);
            Name = "Form1";
            Text = "Nim";
            Settings_Panel.ResumeLayout(false);
            Settings_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GameSize_UpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Drawing_Panel;
        private Panel Settings_Panel;
        private NumericUpDown GameSize_UpDown;
        private Label GameSize_Label;
        private Panel GameInfo_Panel;
    }
}