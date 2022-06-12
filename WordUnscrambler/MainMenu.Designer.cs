namespace WordUnscrambler
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.manualInput = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(146, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word Unscrambler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // manualInput
            // 
            this.manualInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.manualInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.manualInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manualInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualInput.Font = new System.Drawing.Font("Candara Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.manualInput.Location = new System.Drawing.Point(238, 189);
            this.manualInput.Name = "manualInput";
            this.manualInput.Size = new System.Drawing.Size(235, 57);
            this.manualInput.TabIndex = 2;
            this.manualInput.Text = "Manual Input";
            this.manualInput.UseVisualStyleBackColor = false;
            this.manualInput.Click += new System.EventHandler(this.manualInput_Click);
            // 
            // selectFile
            // 
            this.selectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.selectFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFile.Font = new System.Drawing.Font("Candara Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.selectFile.Location = new System.Drawing.Point(238, 272);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(235, 57);
            this.selectFile.TabIndex = 3;
            this.selectFile.Text = "Select a File";
            this.selectFile.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(575, -15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(743, 589);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.manualInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.Text = "Word Unscrambler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button manualInput;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

