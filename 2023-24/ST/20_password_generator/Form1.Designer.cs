namespace _20_password_generator
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
            Generate_Button = new Button();
            PassLength_UpDown = new NumericUpDown();
            label1 = new Label();
            Password_TextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PassLength_UpDown).BeginInit();
            SuspendLayout();
            // 
            // Generate_Button
            // 
            Generate_Button.Location = new Point(220, 12);
            Generate_Button.Name = "Generate_Button";
            Generate_Button.Size = new Size(165, 23);
            Generate_Button.TabIndex = 0;
            Generate_Button.Text = "GENERATE PASSWORD";
            Generate_Button.UseVisualStyleBackColor = true;
            Generate_Button.Click += Generate_Button_Click;
            // 
            // PassLength_UpDown
            // 
            PassLength_UpDown.Location = new Point(112, 12);
            PassLength_UpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            PassLength_UpDown.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            PassLength_UpDown.Name = "PassLength_UpDown";
            PassLength_UpDown.Size = new Size(89, 23);
            PassLength_UpDown.TabIndex = 1;
            PassLength_UpDown.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 2;
            label1.Text = "Password length:";
            // 
            // Password_TextBox
            // 
            Password_TextBox.Location = new Point(12, 56);
            Password_TextBox.Multiline = true;
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PlaceholderText = "Password will appear here";
            Password_TextBox.ReadOnly = true;
            Password_TextBox.Size = new Size(373, 52);
            Password_TextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 120);
            Controls.Add(Password_TextBox);
            Controls.Add(label1);
            Controls.Add(PassLength_UpDown);
            Controls.Add(Generate_Button);
            Name = "Form1";
            Text = "Password Generator";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)PassLength_UpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Generate_Button;
        private NumericUpDown PassLength_UpDown;
        private Label label1;
        private TextBox Password_TextBox;
    }
}