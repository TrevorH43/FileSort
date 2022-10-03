namespace FileSort
{
    partial class FileSortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSortForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sortedResultsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.findFileButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sortFileButton = new System.Windows.Forms.Button();
            this.selectionSortRadioButton = new System.Windows.Forms.RadioButton();
            this.insertSortRadioButton = new System.Windows.Forms.RadioButton();
            this.bubbleSortRadioButton = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.sortedListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sort Algorithm:";
            // 
            // sortedResultsLabel
            // 
            this.sortedResultsLabel.AutoSize = true;
            this.sortedResultsLabel.Location = new System.Drawing.Point(220, 256);
            this.sortedResultsLabel.Name = "sortedResultsLabel";
            this.sortedResultsLabel.Size = new System.Drawing.Size(0, 15);
            this.sortedResultsLabel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sorted Results:";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(72, 28);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(209, 23);
            this.fileNameTextBox.TabIndex = 7;
            // 
            // findFileButton
            // 
            this.findFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findFileButton.BackgroundImage")));
            this.findFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.findFileButton.Location = new System.Drawing.Point(287, 28);
            this.findFileButton.Name = "findFileButton";
            this.findFileButton.Size = new System.Drawing.Size(27, 23);
            this.findFileButton.TabIndex = 8;
            this.findFileButton.UseVisualStyleBackColor = true;
            this.findFileButton.Click += new System.EventHandler(this.findFileButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sortFileButton);
            this.panel1.Controls.Add(this.selectionSortRadioButton);
            this.panel1.Controls.Add(this.insertSortRadioButton);
            this.panel1.Controls.Add(this.bubbleSortRadioButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.findFileButton);
            this.panel1.Controls.Add(this.fileNameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(114, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 194);
            this.panel1.TabIndex = 9;
            // 
            // sortFileButton
            // 
            this.sortFileButton.Location = new System.Drawing.Point(106, 168);
            this.sortFileButton.Name = "sortFileButton";
            this.sortFileButton.Size = new System.Drawing.Size(75, 23);
            this.sortFileButton.TabIndex = 12;
            this.sortFileButton.Text = "Sort File";
            this.sortFileButton.UseVisualStyleBackColor = true;
            this.sortFileButton.Click += new System.EventHandler(this.sortFileButton_Click);
            // 
            // selectionSortRadioButton
            // 
            this.selectionSortRadioButton.AutoSize = true;
            this.selectionSortRadioButton.Location = new System.Drawing.Point(106, 133);
            this.selectionSortRadioButton.Name = "selectionSortRadioButton";
            this.selectionSortRadioButton.Size = new System.Drawing.Size(73, 19);
            this.selectionSortRadioButton.TabIndex = 11;
            this.selectionSortRadioButton.TabStop = true;
            this.selectionSortRadioButton.Text = "Selection";
            this.selectionSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // insertSortRadioButton
            // 
            this.insertSortRadioButton.AutoSize = true;
            this.insertSortRadioButton.Location = new System.Drawing.Point(106, 108);
            this.insertSortRadioButton.Name = "insertSortRadioButton";
            this.insertSortRadioButton.Size = new System.Drawing.Size(71, 19);
            this.insertSortRadioButton.TabIndex = 10;
            this.insertSortRadioButton.TabStop = true;
            this.insertSortRadioButton.Text = "Insertion";
            this.insertSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // bubbleSortRadioButton
            // 
            this.bubbleSortRadioButton.AutoSize = true;
            this.bubbleSortRadioButton.Location = new System.Drawing.Point(106, 81);
            this.bubbleSortRadioButton.Name = "bubbleSortRadioButton";
            this.bubbleSortRadioButton.Size = new System.Drawing.Size(62, 19);
            this.bubbleSortRadioButton.TabIndex = 9;
            this.bubbleSortRadioButton.TabStop = true;
            this.bubbleSortRadioButton.Text = "Bubble";
            this.bubbleSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(401, 416);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sortedListBox
            // 
            this.sortedListBox.FormattingEnabled = true;
            this.sortedListBox.ItemHeight = 15;
            this.sortedListBox.Location = new System.Drawing.Point(117, 274);
            this.sortedListBox.Name = "sortedListBox";
            this.sortedListBox.Size = new System.Drawing.Size(408, 184);
            this.sortedListBox.TabIndex = 10;
            this.sortedListBox.SelectedIndexChanged += new System.EventHandler(this.sortedListBox_SelectedIndexChanged);
            // 
            // FileSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 489);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sortedListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortedResultsLabel);
            this.Name = "FileSortForm";
            this.Text = "File Sort";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label sortedResultsLabel;
        private Label label4;
        private TextBox fileNameTextBox;
        private Button findFileButton;
        private Panel panel1;
        private Button sortFileButton;
        private RadioButton selectionSortRadioButton;
        private RadioButton insertSortRadioButton;
        private RadioButton bubbleSortRadioButton;
        private ListBox sortedListBox;
        private Button clearButton;
    }
}