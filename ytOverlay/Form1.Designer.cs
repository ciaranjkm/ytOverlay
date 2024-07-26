namespace ytOverlay
{
    partial class youtubeOverlay
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
            linkToVideoTextBox = new TextBox();
            openVideoButton = new Button();
            sizeComboBox = new ComboBox();
            label1 = new Label();
            posComboBox = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // linkToVideoTextBox
            // 
            linkToVideoTextBox.Location = new Point(12, 12);
            linkToVideoTextBox.Name = "linkToVideoTextBox";
            linkToVideoTextBox.PlaceholderText = "Link to YouTube Video";
            linkToVideoTextBox.Size = new Size(360, 23);
            linkToVideoTextBox.TabIndex = 0;
            // 
            // openVideoButton
            // 
            openVideoButton.Location = new Point(12, 41);
            openVideoButton.Name = "openVideoButton";
            openVideoButton.Size = new Size(177, 23);
            openVideoButton.TabIndex = 1;
            openVideoButton.Text = "Open/Close";
            openVideoButton.UseVisualStyleBackColor = true;
            openVideoButton.Click += openVideoButton_Click;
            // 
            // sizeComboBox
            // 
            sizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sizeComboBox.FormattingEnabled = true;
            sizeComboBox.ImeMode = ImeMode.Off;
            sizeComboBox.Items.AddRange(new object[] { "512x288", "640x360", "768x432", "896x504", "960x540" });
            sizeComboBox.Location = new Point(12, 113);
            sizeComboBox.MaxDropDownItems = 80;
            sizeComboBox.Name = "sizeComboBox";
            sizeComboBox.Size = new Size(121, 23);
            sizeComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 3;
            label1.Text = "Window Size";
            // 
            // posComboBox
            // 
            posComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            posComboBox.FormattingEnabled = true;
            posComboBox.Items.AddRange(new object[] { "Top Left", "Top Right", "Bottom Right", "Bottom Left" });
            posComboBox.Location = new Point(158, 114);
            posComboBox.Name = "posComboBox";
            posComboBox.Size = new Size(121, 23);
            posComboBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 96);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 5;
            label2.Text = "Window Position";
            // 
            // button1
            // 
            button1.Location = new Point(285, 113);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(88, 23);
            button1.TabIndex = 6;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 45);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(121, 15);
            label4.TabIndex = 8;
            label4.Text = "Hotkey To Close: END";
            // 
            // youtubeOverlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(posComboBox);
            Controls.Add(label1);
            Controls.Add(sizeComboBox);
            Controls.Add(openVideoButton);
            Controls.Add(linkToVideoTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "youtubeOverlay";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Youtube Overlay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox linkToVideoTextBox;
        private Button openVideoButton;
        private ComboBox sizeComboBox;
        private Label label1;
        private ComboBox posComboBox;
        private Label label2;
        private Button button1;
        private Label label4;
    }
}
