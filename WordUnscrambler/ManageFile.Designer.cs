namespace WordUnscrambler
{
    partial class ManageFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFile));
            this.label2 = new System.Windows.Forms.Label();
            this.listAllWordsFile = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.addOrDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorTextBox = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "All Words";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listAllWordsFile
            // 
            this.listAllWordsFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.listAllWordsFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAllWordsFile.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.listAllWordsFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(145)))), ((int)(((byte)(151)))));
            this.listAllWordsFile.FormattingEnabled = true;
            this.listAllWordsFile.ItemHeight = 23;
            this.listAllWordsFile.Location = new System.Drawing.Point(36, 92);
            this.listAllWordsFile.Name = "listAllWordsFile";
            this.listAllWordsFile.Size = new System.Drawing.Size(262, 414);
            this.listAllWordsFile.TabIndex = 10;
            this.listAllWordsFile.SelectedIndexChanged += new System.EventHandler(this.listAllWordsFile_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("OCR A Extended", 13.75F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnAdd.Location = new System.Drawing.Point(365, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 34);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addOrDelete
            // 
            this.addOrDelete.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.addOrDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(145)))), ((int)(((byte)(151)))));
            this.addOrDelete.Location = new System.Drawing.Point(365, 103);
            this.addOrDelete.Multiline = true;
            this.addOrDelete.Name = "addOrDelete";
            this.addOrDelete.Size = new System.Drawing.Size(201, 30);
            this.addOrDelete.TabIndex = 12;
            this.addOrDelete.TextChanged += new System.EventHandler(this.addNewWord_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(361, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("OCR A Extended", 13.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnDelete.Location = new System.Drawing.Point(478, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 34);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorTextBox
            // 
            this.errorTextBox.AutoSize = true;
            this.errorTextBox.Font = new System.Drawing.Font("OCR A Extended", 8F);
            this.errorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(145)))), ((int)(((byte)(151)))));
            this.errorTextBox.Location = new System.Drawing.Point(368, 198);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(0, 12);
            this.errorTextBox.TabIndex = 18;
            this.errorTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorTextBox.Click += new System.EventHandler(this.errorAddWord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ManageFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(733, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.addOrDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAllWordsFile);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageFile";
            this.Text = "ManageFile";
            this.Load += new System.EventHandler(this.ManageFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listAllWordsFile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox addOrDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label errorTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}