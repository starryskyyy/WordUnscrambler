using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordUnscrambler
{
    public partial class FileInput : Form
    {
        public string filename = "";
        public FileInput()
        {
            InitializeComponent();
        }

        private void selectedFileLbl_Click(object sender, EventArgs e)
        {

        }

        private void errorFileOpenLbl_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string path = pathToSelectedFile();
            openFileTextBox.Text = path;
        }

        private string pathToSelectedFile()
        {
            var loadDialog = new OpenFileDialog { Filter = "Text File|*.txt", InitialDirectory = @"C:\" };
            if (loadDialog.ShowDialog() == DialogResult.OK)
                filename = loadDialog.FileName;
            return filename;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear list with words in GUI
            listAddedWords.Items.Clear();
            label1.Text = "";
            btnClear.ForeColor = Color.FromArgb(252, 251, 255);
            btnClear.Text = "";
            

        }

        private void btnUnscrambleTxFile_Click(object sender, EventArgs e)
        {
            // clear list with words in GUI
            listAddedWords.Items.Clear();
            printUnscrambledWords();
            openFileTextBox.Text = "";
            label1.Text = "Unscrambled words";
            btnClear.Text = "Clear";
            btnClear.ForeColor = Color.FromArgb(65, 63, 73);

        }
        private List<string> addToTempList()
        {
            List<String> temp = new List<String>(); // temporary list
            foreach (string input in File.ReadAllLines(filename)) // loop with words that user added
            {
                foreach (string word in File.ReadAllLines("1000words.txt"))
                {

                    if (sameChars(input, word)) // if words contain same letters 
                    {
                        temp.Add(word); // add words from file to temp list
                    }
                }
            }
            return temp;
        }
        private static bool sameChars(string a, string b)
        {
            string str1 = string.Concat(a
                .OrderBy(c => char.ToLower(c)) // sort ignoring case
                .ThenBy(c => c));
            string str2 = string.Concat(b
                .OrderBy(c => char.ToLower(c)) // sort ignoring case
                .ThenBy(c => c));
            // check if str1 and str2 are the same
            if (str1.ToLower() == str2.ToLower())
                return true;
            return false;
        }
        private void printUnscrambledWords()
        {
            List<string> li = addToTempList();
            foreach (string word in li)
            {
                listAddedWords.Items.Add("\r\n" + word); // display in the list box
            }
            if (listAddedWords.Items.Count == 0) // if no words found
            {
                listAddedWords.Items.Add("\r\n" + "No words were found"); // display message
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
