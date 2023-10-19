namespace _8_kvadraticka_rovnice
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
            x2_textBox = new TextBox();
            x_textBox = new TextBox();
            num_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Button1 = new Button();
            errorField = new Label();
            x1_result = new Label();
            x2_result = new Label();
            CleanButton = new Button();
            SuspendLayout();
            // 
            // x2_textBox
            // 
            x2_textBox.Cursor = Cursors.Hand;
            x2_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            x2_textBox.Location = new Point(55, 30);
            x2_textBox.Name = "x2_textBox";
            x2_textBox.Size = new Size(49, 29);
            x2_textBox.TabIndex = 0;
            // 
            // x_textBox
            // 
            x_textBox.Cursor = Cursors.Hand;
            x_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            x_textBox.Location = new Point(156, 30);
            x_textBox.Name = "x_textBox";
            x_textBox.Size = new Size(56, 29);
            x_textBox.TabIndex = 1;
            // 
            // num_textBox
            // 
            num_textBox.Cursor = Cursors.Hand;
            num_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            num_textBox.Location = new Point(258, 29);
            num_textBox.Name = "num_textBox";
            num_textBox.Size = new Size(48, 29);
            num_textBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 110);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 3;
            label1.Text = "x1 = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 152);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 4;
            label2.Text = "x2 =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(110, 31);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 7;
            label3.Text = "x² +";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(218, 31);
            label4.Name = "label4";
            label4.Size = new Size(34, 21);
            label4.TabIndex = 8;
            label4.Text = "x +";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(312, 31);
            label5.Name = "label5";
            label5.Size = new Size(34, 21);
            label5.TabIndex = 9;
            label5.Text = "= 0";
            // 
            // Button1
            // 
            Button1.BackColor = Color.Silver;
            Button1.Location = new Point(55, 73);
            Button1.Name = "Button1";
            Button1.Size = new Size(140, 23);
            Button1.TabIndex = 10;
            Button1.Text = "Vypočítat x";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // errorField
            // 
            errorField.AutoSize = true;
            errorField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errorField.Location = new Point(218, 109);
            errorField.MaximumSize = new Size(150, 90);
            errorField.MinimumSize = new Size(150, 90);
            errorField.Name = "errorField";
            errorField.Size = new Size(150, 90);
            errorField.TabIndex = 12;
            // 
            // x1_result
            // 
            x1_result.AutoSize = true;
            x1_result.BackColor = SystemColors.ActiveCaption;
            x1_result.BorderStyle = BorderStyle.FixedSingle;
            x1_result.FlatStyle = FlatStyle.Popup;
            x1_result.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            x1_result.Location = new Point(93, 110);
            x1_result.MinimumSize = new Size(100, 21);
            x1_result.Name = "x1_result";
            x1_result.Size = new Size(100, 21);
            x1_result.TabIndex = 13;
            // 
            // x2_result
            // 
            x2_result.AutoSize = true;
            x2_result.BackColor = SystemColors.ActiveCaption;
            x2_result.BorderStyle = BorderStyle.FixedSingle;
            x2_result.FlatStyle = FlatStyle.Popup;
            x2_result.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            x2_result.Location = new Point(93, 154);
            x2_result.MinimumSize = new Size(100, 21);
            x2_result.Name = "x2_result";
            x2_result.Size = new Size(100, 21);
            x2_result.TabIndex = 14;
            // 
            // CleanButton
            // 
            CleanButton.BackColor = Color.Silver;
            CleanButton.Location = new Point(206, 73);
            CleanButton.Name = "CleanButton";
            CleanButton.Size = new Size(112, 23);
            CleanButton.TabIndex = 15;
            CleanButton.Text = "Vyčistit";
            CleanButton.UseVisualStyleBackColor = false;
            CleanButton.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 209);
            Controls.Add(CleanButton);
            Controls.Add(x2_result);
            Controls.Add(x1_result);
            Controls.Add(errorField);
            Controls.Add(Button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(num_textBox);
            Controls.Add(x_textBox);
            Controls.Add(x2_textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox x2_textBox;
        private TextBox x_textBox;
        private TextBox num_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Button1;
        private Label errorField;
        private Label x1_result;
        private Label x2_result;
        private Button CleanButton;
    }
}