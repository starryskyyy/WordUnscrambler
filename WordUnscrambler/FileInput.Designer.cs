namespace WordUnscrambler
{
    partial class FileInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileInput));
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileTextBox = new System.Windows.Forms.TextBox();
            this.selectedFileLbl = new System.Windows.Forms.Label();
            this.errorFileOpenLbl = new System.Windows.Forms.Label();
            this.btnUnscrambleTxFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listAddedWords = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please select a file";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("OCR A Extended", 13.75F);
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnBrowse.Location = new System.Drawing.Point(544, 84);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(88, 34);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileTextBox
            // 
            this.openFileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.openFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openFileTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.openFileTextBox.Enabled = false;
            this.openFileTextBox.Font = new System.Drawing.Font("OCR A Extended", 10F);
            this.openFileTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(145)))), ((int)(((byte)(151)))));
            this.openFileTextBox.Location = new System.Drawing.Point(28, 84);
            this.openFileTextBox.Multiline = true;
            this.openFileTextBox.Name = "openFileTextBox";
            this.openFileTextBox.Size = new System.Drawing.Size(498, 34);
            this.openFileTextBox.TabIndex = 9;
            // 
            // selectedFileLbl
            // 
            this.selectedFileLbl.AutoSize = true;
            this.selectedFileLbl.Font = new System.Drawing.Font("Candara Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFileLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.selectedFileLbl.Location = new System.Drawing.Point(62, 241);
            this.selectedFileLbl.Name = "selectedFileLbl";
            this.selectedFileLbl.Size = new System.Drawing.Size(0, 36);
            this.selectedFileLbl.TabIndex = 11;
            this.selectedFileLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectedFileLbl.Click += new System.EventHandler(this.selectedFileLbl_Click);
            // 
            // errorFileOpenLbl
            // 
            this.errorFileOpenLbl.AutoSize = true;
            this.errorFileOpenLbl.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorFileOpenLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.errorFileOpenLbl.Location = new System.Drawing.Point(75, 178);
            this.errorFileOpenLbl.Name = "errorFileOpenLbl";
            this.errorFileOpenLbl.Size = new System.Drawing.Size(0, 19);
            this.errorFileOpenLbl.TabIndex = 12;
            this.errorFileOpenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorFileOpenLbl.Click += new System.EventHandler(this.errorFileOpenLbl_Click);
            // 
            // btnUnscrambleTxFile
            // 
            this.btnUnscrambleTxFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.btnUnscrambleTxFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnscrambleTxFile.Font = new System.Drawing.Font("OCR A Extended", 13.75F);
            this.btnUnscrambleTxFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnUnscrambleTxFile.Location = new System.Drawing.Point(28, 163);
            this.btnUnscrambleTxFile.Name = "btnUnscrambleTxFile";
            this.btnUnscrambleTxFile.Size = new System.Drawing.Size(191, 34);
            this.btnUnscrambleTxFile.TabIndex = 14;
            this.btnUnscrambleTxFile.Text = "Unscramble";
            this.btnUnscrambleTxFile.UseVisualStyleBackColor = false;
            this.btnUnscrambleTxFile.Click += new System.EventHandler(this.btnUnscrambleTxFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("OCR A Extended", 13.75F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(28, 476);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 34);
            this.btnClear.TabIndex = 24;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(24, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 23;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listAddedWords
            // 
            this.listAddedWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.listAddedWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAddedWords.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.listAddedWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(145)))), ((int)(((byte)(151)))));
            this.listAddedWords.FormattingEnabled = true;
            this.listAddedWords.ItemHeight = 23;
            this.listAddedWords.Location = new System.Drawing.Point(28, 280);
            this.listAddedWords.Name = "listAddedWords";
            this.listAddedWords.Size = new System.Drawing.Size(230, 207);
            this.listAddedWords.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FileInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(717, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAddedWords);
            this.Controls.Add(this.btnUnscrambleTxFile);
            this.Controls.Add(this.errorFileOpenLbl);
            this.Controls.Add(this.selectedFileLbl);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.openFileTextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileInput";
            this.Text = "FileInput";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox openFileTextBox;
        private System.Windows.Forms.Label selectedFileLbl;
        private System.Windows.Forms.Label errorFileOpenLbl;
        private System.Windows.Forms.Button btnUnscrambleTxFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listAddedWords;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}