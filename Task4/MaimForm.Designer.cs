namespace Task4
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
            numberButton1 = new Button();
            numberButton2 = new Button();
            numberButton3 = new Button();
            numberButton4 = new Button();
            numberButton5 = new Button();
            numberButton6 = new Button();
            numberButton7 = new Button();
            numberButton8 = new Button();
            numberButton9 = new Button();
            mainTextBox = new TextBox();
            clearButton = new Button();
            clearMinusOneButton = new Button();
            SuspendLayout();
            // 
            // numberButton1
            // 
            numberButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberButton1.Location = new Point(12, 60);
            numberButton1.Name = "numberButton1";
            numberButton1.Size = new Size(57, 47);
            numberButton1.TabIndex = 0;
            numberButton1.Text = "1";
            numberButton1.UseVisualStyleBackColor = true;
            numberButton1.Click += DigitButtonOnClick;
            // 
            // numberButton2
            // 
            numberButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberButton2.Location = new Point(75, 60);
            numberButton2.Name = "numberButton2";
            numberButton2.Size = new Size(57, 47);
            numberButton2.TabIndex = 1;
            numberButton2.Text = "2";
            numberButton2.UseVisualStyleBackColor = true;
            numberButton2.Click += DigitButtonOnClick;
            // 
            // numberButton3
            // 
            numberButton3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberButton3.Location = new Point(138, 60);
            numberButton3.Name = "numberButton3";
            numberButton3.Size = new Size(57, 47);
            numberButton3.TabIndex = 2;
            numberButton3.Text = "3";
            numberButton3.UseVisualStyleBackColor = true;
            numberButton3.Click += DigitButtonOnClick;
            // 
            // numberButton4
            // 
            numberButton4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberButton4.Location = new Point(12, 113);
            numberButton4.Name = "numberButton4";
            numberButton4.Size = new Size(57, 47);
            numberButton4.TabIndex = 3;
            numberButton4.Text = "4";
            numberButton4.UseVisualStyleBackColor = true;
            numberButton4.Click += DigitButtonOnClick;
            // 
            // numberButton5
            // 
            numberButton5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberButton5.Location = new Point(75, 113);
            numberButton5.Name = "numberButton5";
            numberButton5.Size = new Size(57, 47);
            numberButton5.TabIndex = 4;
            numberButton5.Text = "5";
            numberButton5.UseVisualStyleBackColor = true;
            numberButton5.Click += DigitButtonOnClick;
            // 
            // numberButton6
            // 
            numberButton6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberButton6.Location = new Point(138, 113);
            numberButton6.Name = "numberButton6";
            numberButton6.Size = new Size(57, 47);
            numberButton6.TabIndex = 5;
            numberButton6.Text = "6";
            numberButton6.UseVisualStyleBackColor = true;
            numberButton6.Click += DigitButtonOnClick;
            // 
            // numberButton7
            // 
            numberButton7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberButton7.Location = new Point(12, 166);
            numberButton7.Name = "numberButton7";
            numberButton7.Size = new Size(57, 47);
            numberButton7.TabIndex = 6;
            numberButton7.Text = "7";
            numberButton7.UseVisualStyleBackColor = true;
            numberButton7.Click += DigitButtonOnClick;
            // 
            // numberButton8
            // 
            numberButton8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberButton8.Location = new Point(75, 166);
            numberButton8.Name = "numberButton8";
            numberButton8.Size = new Size(57, 47);
            numberButton8.TabIndex = 7;
            numberButton8.Text = "8";
            numberButton8.UseVisualStyleBackColor = true;
            numberButton8.Click += DigitButtonOnClick;
            // 
            // numberButton9
            // 
            numberButton9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberButton9.Location = new Point(138, 166);
            numberButton9.Name = "numberButton9";
            numberButton9.Size = new Size(57, 47);
            numberButton9.TabIndex = 8;
            numberButton9.Text = "9";
            numberButton9.UseVisualStyleBackColor = true;
            numberButton9.Click += DigitButtonOnClick;
            // 
            // mainTextBox
            // 
            mainTextBox.Location = new Point(12, 12);
            mainTextBox.Multiline = true;
            mainTextBox.Name = "mainTextBox";
            mainTextBox.Size = new Size(183, 42);
            mainTextBox.TabIndex = 9;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearButton.Location = new Point(12, 219);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(183, 22);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear all";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButtonOnClick;
            // 
            // clearMinusOneButton
            // 
            clearMinusOneButton.Location = new Point(12, 247);
            clearMinusOneButton.Name = "clearMinusOneButton";
            clearMinusOneButton.Size = new Size(183, 23);
            clearMinusOneButton.TabIndex = 11;
            clearMinusOneButton.Text = "Clear";
            clearMinusOneButton.UseVisualStyleBackColor = true;
            clearMinusOneButton.Click += ClearMinusOneButtonOnClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(209, 273);
            Controls.Add(clearMinusOneButton);
            Controls.Add(clearButton);
            Controls.Add(mainTextBox);
            Controls.Add(numberButton9);
            Controls.Add(numberButton8);
            Controls.Add(numberButton7);
            Controls.Add(numberButton6);
            Controls.Add(numberButton5);
            Controls.Add(numberButton4);
            Controls.Add(numberButton3);
            Controls.Add(numberButton2);
            Controls.Add(numberButton1);
            Name = "MainForm";
            Text = "MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button numberButton1;
        private Button numberButton2;
        private Button numberButton3;
        private Button numberButton4;
        private Button numberButton5;
        private Button numberButton6;
        private Button numberButton7;
        private Button numberButton8;
        private Button numberButton9;
        private TextBox mainTextBox;
        private Button clearButton;
        private Button clearMinusOneButton;
    }
}
