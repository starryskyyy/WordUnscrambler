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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnFileManager = new System.Windows.Forms.Button();
            this.btnFileInput = new System.Windows.Forms.Button();
            this.btnManualInp = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnFileManager);
            this.panel1.Controls.Add(this.btnFileInput);
            this.panel1.Controls.Add(this.btnManualInp);
            this.panel1.Controls.Add(this.btnHomePage);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 552);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(196)))), ((int)(((byte)(211)))));
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 1);
            this.panel3.TabIndex = 6;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(196)))), ((int)(((byte)(211)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 175);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(2, 190);
            this.pnlNav.TabIndex = 8;
            // 
            // btnFileManager
            // 
            this.btnFileManager.BackColor = System.Drawing.Color.White;
            this.btnFileManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileManager.FlatAppearance.BorderSize = 0;
            this.btnFileManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileManager.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btnFileManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnFileManager.Image = ((System.Drawing.Image)(resources.GetObject("btnFileManager.Image")));
            this.btnFileManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileManager.Location = new System.Drawing.Point(0, 211);
            this.btnFileManager.Name = "btnFileManager";
            this.btnFileManager.Size = new System.Drawing.Size(228, 43);
            this.btnFileManager.TabIndex = 7;
            this.btnFileManager.Text = "Manage File ";
            this.btnFileManager.UseVisualStyleBackColor = false;
            this.btnFileManager.Click += new System.EventHandler(this.btnFileManager_Click);
            this.btnFileManager.Leave += new System.EventHandler(this.btnFileManager_Leave);
            // 
            // btnFileInput
            // 
            this.btnFileInput.BackColor = System.Drawing.Color.White;
            this.btnFileInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileInput.FlatAppearance.BorderSize = 0;
            this.btnFileInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileInput.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btnFileInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnFileInput.Image = ((System.Drawing.Image)(resources.GetObject("btnFileInput.Image")));
            this.btnFileInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileInput.Location = new System.Drawing.Point(0, 168);
            this.btnFileInput.Name = "btnFileInput";
            this.btnFileInput.Size = new System.Drawing.Size(228, 43);
            this.btnFileInput.TabIndex = 6;
            this.btnFileInput.Text = "File Input";
            this.btnFileInput.UseVisualStyleBackColor = false;
            this.btnFileInput.Click += new System.EventHandler(this.btnFileInput_Click);
            this.btnFileInput.Leave += new System.EventHandler(this.btnFileInput_Leave);
            // 
            // btnManualInp
            // 
            this.btnManualInp.BackColor = System.Drawing.Color.White;
            this.btnManualInp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManualInp.FlatAppearance.BorderSize = 0;
            this.btnManualInp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManualInp.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btnManualInp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnManualInp.Image = ((System.Drawing.Image)(resources.GetObject("btnManualInp.Image")));
            this.btnManualInp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManualInp.Location = new System.Drawing.Point(0, 125);
            this.btnManualInp.Name = "btnManualInp";
            this.btnManualInp.Size = new System.Drawing.Size(228, 43);
            this.btnManualInp.TabIndex = 5;
            this.btnManualInp.Text = "Manual Input";
            this.btnManualInp.UseVisualStyleBackColor = false;
            this.btnManualInp.Click += new System.EventHandler(this.btnManualInp_Click);
            this.btnManualInp.Leave += new System.EventHandler(this.btnManualInp_Leave);
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.White;
            this.btnHomePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btnHomePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomePage.Location = new System.Drawing.Point(0, 82);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(228, 43);
            this.btnHomePage.TabIndex = 4;
            this.btnHomePage.Text = "Home Page";
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            this.btnHomePage.Leave += new System.EventHandler(this.btnHomePage_Leave);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnExit.Location = new System.Drawing.Point(0, 509);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(228, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 82);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word \r\nUnscrambler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(228, 0);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(691, 552);
            this.PnlFormLoader.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(90)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(919, 552);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Unscrambler";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFileManager;
        private System.Windows.Forms.Button btnFileInput;
        private System.Windows.Forms.Button btnManualInp;
        private System.Windows.Forms.Button btnHomePage;
        public System.Windows.Forms.Panel PnlFormLoader;
        public System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}

