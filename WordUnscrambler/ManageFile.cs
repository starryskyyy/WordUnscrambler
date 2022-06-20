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
    public partial class ManageFile : Form
    {
        public ManageFile()
        {
            InitializeComponent();
            WriteToList("1000words.txt");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ManageFile_Load(object sender, EventArgs e)
        {

        }

        private void errorAddWord_Click(object sender, EventArgs e)
        {

        }

        private void listAllWordsFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            // displays all words from the file
            WriteToList("1000words.txt");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fileName = "1000words.txt"; 

            addToAFile(fileName);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string fileName = "1000words.txt";
            deleteFromAFile(fileName);
        }

        private void addToAFile(string fileName)
        {
            var lines = File.ReadAllLines(fileName);

            // check if word that user wants to add doesnt now exists and had correct format
            if (!lines.Contains(addOrDelete.Text) && checkIfCorrectFormat())
            {

                lines = lines.Append(addOrDelete.Text).OrderBy(line => line).ToArray(); // append to a file in asc order

                File.WriteAllLines(fileName, lines);
                addOrDelete.Clear(); // clear text box 
                errorTextBox.Text = "Word was sucessfully added!"; // success message
                WriteToList("1000words.txt"); // displays updated list

            }
            else if (lines.Contains(addOrDelete.Text)) // if already exists in the file - print error message
            {
                addOrDelete.Clear();
                errorTextBox.Text = "*Word alreadt exists! Please, try again.";
            }
        }
        private void deleteFromAFile(string fileName)
        {
            var lines = File.ReadAllLines(fileName);

            //if word exists in the file and user input in correct format
            if (lines.Contains(addOrDelete.Text) && checkIfCorrectFormat())
            {
                string line = null;
                int line_number = 0; // start point 

                using (StreamReader reader = new StreamReader(fileName))
                {
                    using (StreamWriter writer = new StreamWriter("temp.txt"))
                    {
                        while ((line = reader.ReadLine()) != null) // while line is not empty
                        {
                            line_number++;

                            if (line == addOrDelete.Text) // if found word that has to be deleted
                                continue; // skip lane

                            writer.WriteLine(line); // write lanes except deleted to a temporary file
                        }
                    }
                }

                if (File.Exists("temp.txt")) // check if temporary file exists
                {
                    File.Delete(fileName); // delete original file
                    File.Move("temp.txt", fileName); // set new file name
                }

                addOrDelete.Clear();
                errorTextBox.Text = "Word was sucessfully deleted!"; // print success message
                WriteToList("1000words.txt"); // display updated list

            }
            else if (checkIfCorrectFormat() == false) { }
            else
            {
                addOrDelete.Clear();
                errorTextBox.Text = "*Word does not exist! Please, try again.";
            }
        }
        private bool checkIfCorrectFormat()
        {
            if(Regex.IsMatch(addOrDelete.Text, @"^[a-zA-Z]+$"))
                return true;
            else // if incorrect format - print error message
            {
                addOrDelete.Clear();
                errorTextBox.Text = ("*Incorrect input! Please, use letters only.");
            }
            return false;
        }
        public void WriteToList(string fileName)
        {
            listAllWordsFile.Items.Clear(); //clear list
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                listAllWordsFile.Items.Add(sr.ReadLine()); // display words in the list box
            }
            sr.Close();

        }

        private void addNewWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
