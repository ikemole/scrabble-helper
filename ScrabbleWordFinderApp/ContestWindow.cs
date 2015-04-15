using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScrabbleWordFinderApp
{
    public partial class ContestWindow : Form
    {
        ScrabbleWordFinderSession wordFinderSession;

        public ContestWindow()
        {
            InitializeComponent();
            wordFinderSession = ScrabbleWordFinderSession.getInstance();
            resetWindow();
        }

        private void resetWindow()
        {
            outputLabel.Hide();
            meaningTextbox.Hide();
            outputLabel.BackColor = SystemColors.Control;

            outputLabel.Text = "";
            meaningTextbox.Text = "";
            userInputTextbox.Text = "";
            userInputTextbox.Focus();
        }

        private void contestWordButton_Click(object sender, EventArgs e)
        {
            string inputWord = userInputTextbox.Text.Trim();
            bool inputWordIsCorrect = wordFinderSession.isCorrectWord(inputWord);

            if (inputWordIsCorrect)
            {
                outputLabel.Text = String.Format("'{0}' is a word", inputWord);
                outputLabel.BackColor = Color.FromArgb(0, 192, 0);
                outputLabel.Show();

                string meaning = wordFinderSession.getMeaning(inputWord);
                meaningTextbox.Text = meaning;
                meaningTextbox.Show();
            }
            else
            {
                outputLabel.Text = String.Format("'{0}' is NOT a word", inputWord);
                outputLabel.BackColor = Color.Red;
                outputLabel.Show();
                meaningTextbox.Hide();
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resetWindow();
        }

        private void hide_form_on_closing(object sender, FormClosingEventArgs e)
        {
            Form form = sender as Form;
            form.Hide();        //hide form
            e.Cancel = true;    //cancel closing operation
        }

        private void showMeaningBtn_Click(object sender, EventArgs e)
        {
            string inputWord = userInputTextbox.Text.Trim();
            string meaning = wordFinderSession.getMeaning(inputWord);
            meaningTextbox.Text = meaning;
        }

    }
}
