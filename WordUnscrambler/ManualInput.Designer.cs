namespace WordUnscrambler
{
    partial class ManualInput
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualInput));
            this.label2 = new System.Windows.Forms.Label();
            this.addManualTxtBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listAddedWords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnscrambleUserInp = new System.Windows.Forms.Button();
            this.errorAddToList = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please Enter a Word";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addManualTxtBox
            // 
            this.addManualTxtBox.Font = new System.Drawing.Font("OCR A Extended", 13.75F);
            this.addManualTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.addManualTxtBox.Location = new System.Drawing.Point(38, 104);
            this.addManualTxtBox.Multiline = true;
            this.addManualTxtBox.Name = "addManualTxtBox";
            this.addManualTxtBox.Size = new System.Drawing.Size(207, 30);
            this.addManualTxtBox.TabIndex = 7;
            this.addManualTxtBox.TextChanged += new System.EventHandler(this.addManualTxtBox_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("OCR A Extended", 13.75F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnAdd.Location = new System.Drawing.Point(268, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listAddedWords
            // 
            this.listAddedWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.listAddedWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAddedWords.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.listAddedWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(145)))), ((int)(((byte)(151)))));
            this.listAddedWords.FormattingEnabled = true;
            this.listAddedWords.ItemHeight = 23;
            this.listAddedWords.Location = new System.Drawing.Point(38, 294);
            this.listAddedWords.Name = "listAddedWords";
            this.listAddedWords.Size = new System.Drawing.Size(259, 184);
            this.listAddedWords.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(34, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 10;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUnscrambleUserInp
            // 
            this.btnUnscrambleUserInp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.btnUnscrambleUserInp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnscrambleUserInp.Font = new System.Drawing.Font("OCR A Extended", 13.75F);
            this.btnUnscrambleUserInp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnUnscrambleUserInp.Location = new System.Drawing.Point(38, 184);
            this.btnUnscrambleUserInp.Name = "btnUnscrambleUserInp";
            this.btnUnscrambleUserInp.Size = new System.Drawing.Size(173, 34);
            this.btnUnscrambleUserInp.TabIndex = 12;
            this.btnUnscrambleUserInp.Text = "Unscramble";
            this.btnUnscrambleUserInp.UseVisualStyleBackColor = false;
            this.btnUnscrambleUserInp.Click += new System.EventHandler(this.btnUnscrambleUserInp_Click);
            // 
            // errorAddToList
            // 
            this.errorAddToList.AutoSize = true;
            this.errorAddToList.Font = new System.Drawing.Font("OCR A Extended", 8F);
            this.errorAddToList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(145)))), ((int)(((byte)(151)))));
            this.errorAddToList.Location = new System.Drawing.Point(43, 147);
            this.errorAddToList.Name = "errorAddToList";
            this.errorAddToList.Size = new System.Drawing.Size(0, 12);
            this.errorAddToList.TabIndex = 19;
            this.errorAddToList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorAddToList.Click += new System.EventHandler(this.errorAddToList_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("OCR A Extended", 13.75F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(38, 484);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 34);
            this.btnClear.TabIndex = 21;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(394, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ManualInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(733, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.errorAddToList);
            this.Controls.Add(this.btnUnscrambleUserInp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAddedWords);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.addManualTxtBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManualInput";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addManualTxtBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listAddedWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnscrambleUserInp;
        private System.Windows.Forms.Label errorAddToList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}