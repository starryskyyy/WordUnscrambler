using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WordUnscrambler
{
    public partial class MainMenu : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public MainMenu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); // create round shape for the form
            pnlNav.Height = btnHomePage.Height;
            pnlNav.Top = btnHomePage.Top;
            pnlNav.Left = btnHomePage.Left;

            // display home page window in the main form
            this.PnlFormLoader.Controls.Clear();
            HomePage menuDisplay_Vrb = new HomePage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; 
            menuDisplay_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(menuDisplay_Vrb);
            menuDisplay_Vrb.Show();
        }
      
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // confirm if user wants to exit - pop up window
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            // add style to a button
            pnlNav.Height = btnHomePage.Height;
            pnlNav.Top = btnHomePage.Top;
            pnlNav.Left = btnHomePage.Left;

            // on button "Home" displays main page with information about app 
            this.PnlFormLoader.Controls.Clear();
            HomePage menuDisplay_Vrb = new HomePage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            menuDisplay_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(menuDisplay_Vrb);
            menuDisplay_Vrb.Show();

        }

        private void btnHomePage_Leave(object sender, EventArgs e)
        {
        }

        private void btnManualInp_Click(object sender, EventArgs e)
        {
            // add style to a button
            pnlNav.Height = btnManualInp.Height;
            pnlNav.Top = btnManualInp.Top;
            pnlNav.Left = btnManualInp.Left;
            // on button "Manual Input" displays correct window 
            this.PnlFormLoader.Controls.Clear();
            ManualInput manualInput_Vrb = new ManualInput() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            manualInput_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(manualInput_Vrb);
            manualInput_Vrb.Show();
        }

        private void btnManualInp_Leave(object sender, EventArgs e)
        {
        }

        private void btnFileInput_Click(object sender, EventArgs e)
        {
            // add style to a button
            pnlNav.Height = btnFileInput.Height;
            pnlNav.Top = btnFileInput.Top;
            pnlNav.Left = btnFileInput.Left;
            // on button "File Input" displays correct window 
            this.PnlFormLoader.Controls.Clear();
            FileInput fileInput_Vrb = new FileInput() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fileInput_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(fileInput_Vrb);
            fileInput_Vrb.Show();

        }

        private void btnFileInput_Leave(object sender, EventArgs e)
        {
        }

        private void btnFileManager_Click(object sender, EventArgs e)
        {

            // add style to a button
            pnlNav.Height = btnFileManager.Height;
            pnlNav.Top = btnFileManager.Top;
            pnlNav.Left = btnFileManager.Left;
            // on button "Manage File" displays correct window 
            this.PnlFormLoader.Controls.Clear();
            ManageFile manageFile_Vrb = new ManageFile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            manageFile_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(manageFile_Vrb);
            manageFile_Vrb.Show();
        }

        private void btnFileManager_Leave(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
