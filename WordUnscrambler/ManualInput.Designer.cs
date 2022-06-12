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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualInput));
            this.label1 = new System.Windows.Forms.Label();
            this.enter_words = new System.Windows.Forms.Label();
            this.input_words = new System.Windows.Forms.TextBox();
            this.add_word = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.display_words_manual = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unscrumble_manual = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manual Input";
            // 
            // enter_words
            // 
            this.enter_words.AutoSize = true;
            this.enter_words.Font = new System.Drawing.Font("Candara Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_words.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.enter_words.Location = new System.Drawing.Point(12, 83);
            this.enter_words.Name = "enter_words";
            this.enter_words.Size = new System.Drawing.Size(316, 45);
            this.enter_words.TabIndex = 2;
            this.enter_words.Text = "Please enter words";
            // 
            // input_words
            // 
            this.input_words.BackColor = System.Drawing.Color.White;
            this.input_words.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_words.Location = new System.Drawing.Point(20, 155);
            this.input_words.Multiline = true;
            this.input_words.Name = "input_words";
            this.input_words.Size = new System.Drawing.Size(206, 39);
            this.input_words.TabIndex = 3;
            // 
            // add_word
            // 
            this.add_word.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.add_word.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_word.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.add_word.Location = new System.Drawing.Point(261, 155);
            this.add_word.Name = "add_word";
            this.add_word.Size = new System.Drawing.Size(124, 37);
            this.add_word.TabIndex = 4;
            this.add_word.Text = "Add";
            this.add_word.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, -35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // display_words_manual
            // 
            this.display_words_manual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.display_words_manual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display_words_manual.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_words_manual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.display_words_manual.FormattingEnabled = true;
            this.display_words_manual.ItemHeight = 26;
            this.display_words_manual.Location = new System.Drawing.Point(20, 297);
            this.display_words_manual.Name = "display_words_manual";
            this.display_words_manual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.display_words_manual.Size = new System.Drawing.Size(311, 208);
            this.display_words_manual.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "Words list";
            // 
            // unscrumble_manual
            // 
            this.unscrumble_manual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.unscrumble_manual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.unscrumble_manual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unscrumble_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unscrumble_manual.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unscrumble_manual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.unscrumble_manual.Location = new System.Drawing.Point(401, 387);
            this.unscrumble_manual.Name = "unscrumble_manual";
            this.unscrumble_manual.Size = new System.Drawing.Size(141, 36);
            this.unscrumble_manual.TabIndex = 8;
            this.unscrumble_manual.Text = "Unscramble";
            this.unscrumble_manual.UseVisualStyleBackColor = false;
            // 
            // ManualInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(743, 589);
            this.Controls.Add(this.unscrumble_manual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.display_words_manual);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.add_word);
            this.Controls.Add(this.input_words);
            this.Controls.Add(this.enter_words);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManualInput";
            this.Text = "Word Unscrambler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enter_words;
        private System.Windows.Forms.TextBox input_words;
        private System.Windows.Forms.Button add_word;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox display_words_manual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button unscrumble_manual;
    }
}