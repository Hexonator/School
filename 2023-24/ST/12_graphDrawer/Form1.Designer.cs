namespace _12_graphDrawer
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
            graphField = new Panel();
            EntryBox = new TextBox();
            label1 = new Label();
            infoBox = new Label();
            SuspendLayout();
            // 
            // graphField
            // 
            graphField.Location = new Point(12, 126);
            graphField.Name = "graphField";
            graphField.Size = new Size(811, 400);
            graphField.TabIndex = 0;
            graphField.Paint += graphField_Paint;
            // 
            // EntryBox
            // 
            EntryBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EntryBox.Location = new Point(73, 39);
            EntryBox.Name = "EntryBox";
            EntryBox.Size = new Size(434, 27);
            EntryBox.TabIndex = 1;
            EntryBox.KeyDown += textBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 2;
            label1.Text = "f: y =";
            // 
            // infoBox
            // 
            infoBox.AutoSize = true;
            infoBox.Location = new Point(523, 9);
            infoBox.MinimumSize = new Size(300, 60);
            infoBox.Name = "infoBox";
            infoBox.Size = new Size(300, 60);
            infoBox.TabIndex = 3;
            infoBox.Text = "Info will display here";
            infoBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 538);
            Controls.Add(infoBox);
            Controls.Add(label1);
            Controls.Add(EntryBox);
            Controls.Add(graphField);
            MaximumSize = new Size(851, 577);
            MinimumSize = new Size(851, 577);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graph Drawer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel graphField;
        private TextBox EntryBox;
        private Label label1;
        private Label infoBox;
    }
}