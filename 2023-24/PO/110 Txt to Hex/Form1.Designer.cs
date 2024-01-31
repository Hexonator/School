namespace _110_Txt_to_Hex
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
            openFile = new OpenFileDialog();
            BrowseFiles = new Button();
            filenameTextBox = new TextBox();
            getBinButton = new Button();
            binDisplayTextBox = new TextBox();
            SuspendLayout();
            // 
            // openFile
            // 
            openFile.DefaultExt = "txt";
            openFile.FileName = "openFile";
            // 
            // BrowseFiles
            // 
            BrowseFiles.Location = new Point(562, 7);
            BrowseFiles.Name = "BrowseFiles";
            BrowseFiles.Size = new Size(66, 30);
            BrowseFiles.TabIndex = 0;
            BrowseFiles.Text = "Find File";
            BrowseFiles.UseVisualStyleBackColor = true;
            BrowseFiles.Click += BrowseFiles_Click;
            // 
            // filenameTextBox
            // 
            filenameTextBox.Location = new Point(12, 12);
            filenameTextBox.Name = "filenameTextBox";
            filenameTextBox.Size = new Size(544, 23);
            filenameTextBox.TabIndex = 1;
            filenameTextBox.TextChanged += filenameTextBox_TextChanged;
            // 
            // getBinButton
            // 
            getBinButton.Location = new Point(12, 41);
            getBinButton.Name = "getBinButton";
            getBinButton.Size = new Size(616, 23);
            getBinButton.TabIndex = 2;
            getBinButton.Text = "GET BINARY VALUES";
            getBinButton.UseVisualStyleBackColor = true;
            getBinButton.Click += getBinButton_Click;
            // 
            // binDisplayTextBox
            // 
            binDisplayTextBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            binDisplayTextBox.Location = new Point(12, 70);
            binDisplayTextBox.MinimumSize = new Size(300, 100);
            binDisplayTextBox.Multiline = true;
            binDisplayTextBox.Name = "binDisplayTextBox";
            binDisplayTextBox.PlaceholderText = "Binary information will be displayed here";
            binDisplayTextBox.ReadOnly = true;
            binDisplayTextBox.ScrollBars = ScrollBars.Vertical;
            binDisplayTextBox.Size = new Size(616, 373);
            binDisplayTextBox.TabIndex = 3;
            binDisplayTextBox.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 455);
            Controls.Add(binDisplayTextBox);
            Controls.Add(getBinButton);
            Controls.Add(filenameTextBox);
            Controls.Add(BrowseFiles);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFile;
        private Button BrowseFiles;
        private TextBox filenameTextBox;
        private Button getBinButton;
        private TextBox binDisplayTextBox;
    }
}