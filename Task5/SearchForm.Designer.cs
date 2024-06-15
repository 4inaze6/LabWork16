namespace Task5
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchTextBox = new TextBox();
            searchLabel = new Label();
            replaceLabel = new Label();
            replaceTextBox = new TextBox();
            replaceButton = new Button();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(8, 35);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(391, 23);
            searchTextBox.TabIndex = 0;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(8, 17);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(44, 15);
            searchLabel.TabIndex = 1;
            searchLabel.Text = "Найти:";
            // 
            // replaceLabel
            // 
            replaceLabel.AutoSize = true;
            replaceLabel.Location = new Point(8, 71);
            replaceLabel.Name = "replaceLabel";
            replaceLabel.Size = new Size(79, 15);
            replaceLabel.TabIndex = 3;
            replaceLabel.Text = "Заменить на:";
            // 
            // replaceTextBox
            // 
            replaceTextBox.Location = new Point(8, 89);
            replaceTextBox.Name = "replaceTextBox";
            replaceTextBox.Size = new Size(391, 23);
            replaceTextBox.TabIndex = 2;
            // 
            // replaceButton
            // 
            replaceButton.Location = new Point(158, 145);
            replaceButton.Name = "replaceButton";
            replaceButton.Size = new Size(92, 36);
            replaceButton.TabIndex = 4;
            replaceButton.Text = "Заменить";
            replaceButton.UseVisualStyleBackColor = true;
            replaceButton.Click += replaceButton_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 193);
            Controls.Add(replaceButton);
            Controls.Add(replaceLabel);
            Controls.Add(replaceTextBox);
            Controls.Add(searchLabel);
            Controls.Add(searchTextBox);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private Label searchLabel;
        private Label replaceLabel;
        private TextBox replaceTextBox;
        private Button replaceButton;
    }
}