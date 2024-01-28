namespace DuplicateImageSelectorProj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            selectFolderButton = new Button();
            selectDuplicatesButton = new Button();
            currentFolderTextBoxLabel = new Label();
            infoTextBox = new TextBox();
            infoTextBoxLabel = new Label();
            currentFolderTextBox = new TextBox();
            groupBox1 = new GroupBox();
            tifCheckbox = new CheckBox();
            allCheckbox = new CheckBox();
            gifCheckbox = new CheckBox();
            bmpCheckbox = new CheckBox();
            pngCheckbox = new CheckBox();
            jpgCheckbox = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // selectFolderButton
            // 
            selectFolderButton.Location = new Point(677, 32);
            selectFolderButton.Margin = new Padding(4, 5, 4, 5);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(148, 31);
            selectFolderButton.TabIndex = 0;
            selectFolderButton.Text = "Select Folder";
            selectFolderButton.UseVisualStyleBackColor = true;
            selectFolderButton.Click += selectFolderClick;
            // 
            // selectDuplicatesButton
            // 
            selectDuplicatesButton.Location = new Point(677, 187);
            selectDuplicatesButton.Name = "selectDuplicatesButton";
            selectDuplicatesButton.Size = new Size(160, 34);
            selectDuplicatesButton.TabIndex = 2;
            selectDuplicatesButton.Text = "Select Duplicates";
            selectDuplicatesButton.UseVisualStyleBackColor = true;
            selectDuplicatesButton.Click += selectDuplicatesClick;
            // 
            // currentFolderTextBoxLabel
            // 
            currentFolderTextBoxLabel.AutoSize = true;
            currentFolderTextBoxLabel.Location = new Point(41, 9);
            currentFolderTextBoxLabel.Name = "currentFolderTextBoxLabel";
            currentFolderTextBoxLabel.Size = new Size(134, 25);
            currentFolderTextBoxLabel.TabIndex = 3;
            currentFolderTextBoxLabel.Text = "Current Folder :";
            // 
            // infoTextBox
            // 
            infoTextBox.BackColor = SystemColors.ControlLight;
            infoTextBox.BorderStyle = BorderStyle.None;
            infoTextBox.Location = new Point(41, 197);
            infoTextBox.Name = "infoTextBox";
            infoTextBox.Size = new Size(603, 24);
            infoTextBox.TabIndex = 4;
            // 
            // infoTextBoxLabel
            // 
            infoTextBoxLabel.AutoSize = true;
            infoTextBoxLabel.Location = new Point(41, 164);
            infoTextBoxLabel.Name = "infoTextBoxLabel";
            infoTextBoxLabel.Size = new Size(44, 25);
            infoTextBoxLabel.TabIndex = 5;
            infoTextBoxLabel.Text = "Info";
            // 
            // currentFolderTextBox
            // 
            currentFolderTextBox.BackColor = SystemColors.ControlLight;
            currentFolderTextBox.BorderStyle = BorderStyle.None;
            currentFolderTextBox.Location = new Point(41, 39);
            currentFolderTextBox.Margin = new Padding(4, 5, 4, 5);
            currentFolderTextBox.Name = "currentFolderTextBox";
            currentFolderTextBox.ReadOnly = true;
            currentFolderTextBox.Size = new Size(605, 24);
            currentFolderTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tifCheckbox);
            groupBox1.Controls.Add(allCheckbox);
            groupBox1.Controls.Add(gifCheckbox);
            groupBox1.Controls.Add(bmpCheckbox);
            groupBox1.Controls.Add(pngCheckbox);
            groupBox1.Controls.Add(jpgCheckbox);
            groupBox1.Location = new Point(41, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 77);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Image Types";
            // 
            // tifCheckbox
            // 
            tifCheckbox.AutoSize = true;
            tifCheckbox.Location = new Point(669, 30);
            tifCheckbox.Name = "tifCheckbox";
            tifCheckbox.Size = new Size(58, 29);
            tifCheckbox.TabIndex = 8;
            tifCheckbox.Text = ".tif";
            tifCheckbox.UseVisualStyleBackColor = true;
            tifCheckbox.CheckedChanged += tifCheckbox_CheckedChanged;
            // 
            // allCheckbox
            // 
            allCheckbox.AutoSize = true;
            allCheckbox.Checked = true;
            allCheckbox.CheckState = CheckState.Checked;
            allCheckbox.Location = new Point(10, 30);
            allCheckbox.Name = "allCheckbox";
            allCheckbox.Size = new Size(109, 29);
            allCheckbox.TabIndex = 7;
            allCheckbox.Text = "Select All";
            allCheckbox.UseVisualStyleBackColor = true;
            allCheckbox.CheckedChanged += allCheckbox_CheckedChanged;
            // 
            // gifCheckbox
            // 
            gifCheckbox.AutoSize = true;
            gifCheckbox.Location = new Point(543, 30);
            gifCheckbox.Name = "gifCheckbox";
            gifCheckbox.Size = new Size(63, 29);
            gifCheckbox.TabIndex = 3;
            gifCheckbox.Text = ".gif";
            gifCheckbox.UseVisualStyleBackColor = true;
            gifCheckbox.CheckedChanged += gifCheckbox_CheckedChanged;
            // 
            // bmpCheckbox
            // 
            bmpCheckbox.AutoSize = true;
            bmpCheckbox.Location = new Point(411, 30);
            bmpCheckbox.Name = "bmpCheckbox";
            bmpCheckbox.Size = new Size(80, 29);
            bmpCheckbox.TabIndex = 2;
            bmpCheckbox.Text = ".bmp";
            bmpCheckbox.UseVisualStyleBackColor = true;
            bmpCheckbox.CheckedChanged += bmpCheckbox_CheckedChanged;
            // 
            // pngCheckbox
            // 
            pngCheckbox.AutoSize = true;
            pngCheckbox.Location = new Point(284, 30);
            pngCheckbox.Name = "pngCheckbox";
            pngCheckbox.Size = new Size(74, 29);
            pngCheckbox.TabIndex = 1;
            pngCheckbox.Text = ".png";
            pngCheckbox.UseVisualStyleBackColor = true;
            pngCheckbox.CheckedChanged += pngCheckbox_CheckedChanged;
            // 
            // jpgCheckbox
            // 
            jpgCheckbox.AutoSize = true;
            jpgCheckbox.Location = new Point(163, 30);
            jpgCheckbox.Name = "jpgCheckbox";
            jpgCheckbox.Size = new Size(68, 29);
            jpgCheckbox.TabIndex = 0;
            jpgCheckbox.Text = ".jpg";
            jpgCheckbox.UseVisualStyleBackColor = true;
            jpgCheckbox.CheckedChanged += jpgCheckbox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 244);
            Controls.Add(groupBox1);
            Controls.Add(infoTextBoxLabel);
            Controls.Add(infoTextBox);
            Controls.Add(currentFolderTextBoxLabel);
            Controls.Add(selectDuplicatesButton);
            Controls.Add(currentFolderTextBox);
            Controls.Add(selectFolderButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Duplicate Image Selector";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectFolderButton;
        private Button selectDuplicatesButton;
        private Label currentFolderTextBoxLabel;
        private TextBox infoTextBox;
        private Label infoTextBoxLabel;
        private TextBox currentFolderTextBox;
        private GroupBox groupBox1;
        private CheckBox gifCheckbox;
        private CheckBox bmpCheckbox;
        private CheckBox pngCheckbox;
        private CheckBox jpgCheckbox;
        private CheckBox allCheckbox;
        private CheckBox tifCheckbox;
    }
}