using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordUnscrambler
{
    public partial class ManualInput : Form
    {
        public List<string> inputList;
        public ManualInput()
        {
            InitializeComponent();
            addManualTxtBox.Text = String.Empty;
            //Initializing list  
            this.inputList = new List<string>();

        }

        private void errorAddToList_Click(object sender, EventArgs e)
        {

        }

        private void addManualTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check if user input letters only. no additional symbols or space
            if(Regex.IsMatch(addManualTxtBox.Text, @"^[a-zA-Z]+$"))
                addToList(addManualTxtBox.Text);
            else
            {
                // clear text box and print message
                addManualTxtBox.Clear();
                errorAddToList.Text = "* Incorrect input! Please, use letters only.";
            }

        }
        public void addToList(string word)
        {
            errorAddToList.Text = "";
            label1.Text = "Added Words";
            //adding to a list user input
            inputList.Add(word);
            // sorting in asc order
            inputList.Sort();
            // displaying words that been added to a list
            listAddedWords.Items.Add("\r\n" + word);
        }

        private void btnUnscrambleUserInp_Click(object sender, EventArgs e)
        {
            errorAddToList.Text = "";
            // clear text box 
            addManualTxtBox.Clear(); // clear textbox
            listAddedWords.Items.Clear(); // clear list box
            label1.Text = "Unscrambled words";
            printUnscrambledWords();
            inputList.Clear();
            btnClear.Text = "Clear";
            btnClear.ForeColor = Color.FromArgb(65, 63, 73);

        }

        private List<string> addToTempList(string fileName)
        {
            List<String> temp = new List<String>(); // temporary list
            foreach (string input in inputList) // loop with words that user added
            {
                foreach (string word in File.ReadAllLines(fileName))
                {
                   
                    if (sameChars(input, word)) // if words contain same letters 
                    {
                            temp.Add(word); // add words from file to temp list
                    }
                }
            }
            return temp;
        }

        private void printUnscrambledWords()
        {
            List<string> li = addToTempList("1000words.txt");
            foreach (string word in li) 
            {
                listAddedWords.Items.Add("\r\n" + word); // display in the list box
            }
            if (listAddedWords.Items.Count == 0) // if no words found
            {
                listAddedWords.Items.Add("\r\n" + "No words were found"); // display message
            }
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
        private void label1_Click(object sender, EventArgs e)
        {
            
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear list with words in GUI
            listAddedWords.Items.Clear();
            //clear input list
            inputList.Clear();
            label1.Text = "";
            btnClear.ForeColor = Color.FromArgb(252, 251, 255);
            btnClear.Text = "";
            errorAddToList.Text = "";
        }

        private void result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
