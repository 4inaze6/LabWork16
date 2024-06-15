namespace Task5
{
    partial class MainForm
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
            mainTextBox = new TextBox();
            mainButton = new Button();
            SuspendLayout();
            // 
            // mainTextBox
            // 
            mainTextBox.Location = new Point(12, 12);
            mainTextBox.Multiline = true;
            mainTextBox.Name = "mainTextBox";
            mainTextBox.Size = new Size(776, 397);
            mainTextBox.TabIndex = 0;
            // 
            // mainButton
            // 
            mainButton.Location = new Point(12, 415);
            mainButton.Name = "mainButton";
            mainButton.Size = new Size(113, 23);
            mainButton.TabIndex = 1;
            mainButton.Text = "Замена";
            mainButton.UseVisualStyleBackColor = true;
            mainButton.Click += mainButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainButton);
            Controls.Add(mainTextBox);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mainTextBox;
        private Button mainButton;
    }
}
