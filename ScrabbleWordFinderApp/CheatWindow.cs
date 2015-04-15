using ScrabbleWordFinder.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ScrabbleWordFinderApp
{
    public partial class CheatWindow : Form
    {
        ScrabbleWordFinderSession wordFinderSession;

        public CheatWindow()
        {
            InitializeComponent();
            wordFinderSession = ScrabbleWordFinderSession.getInstance();
            resetWordFiltersPanel();
            resultsPanel.Hide();
            wordFilterPanel.Enabled = false;
        }

        private void hide_form_on_closing(object sender, FormClosingEventArgs e)
        {
            Form form = sender as Form;
            form.Hide();        //hide form
            e.Cancel = true;    //cancel closing operation
        }

        private void wordFiltersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wordFiltersCheckBox.Checked)
            {
                wordFilterPanel.Enabled = true;
            }
            else
            {
                resetWordFiltersPanel();
            }
        }

        private void resetWordFiltersPanel()
        {
            // Clear the textboxes
            startsWithTextbox.Text = String.Empty;
            endsWithTextbox.Text = String.Empty;
            containsTextbox.Text = String.Empty;

            // hide the panel
            wordFilterPanel.Enabled = false;

            //uncheck the main selector
            wordFiltersCheckBox.Checked = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resetWordFiltersPanel();
            userTilesTextBox.Text = "";
            userTilesTextBox.Focus();
            clearResultsTable();
            resultsPanel.Hide();
        }

        private void clearResultsTable()
        {
            resultsTable.Rows.Clear();
            resultsTable.Columns.Clear();
            resultsTable.Refresh();
            resultsLabel.Text = "RESULTS";
        }

        private void findWordsButton_Click(object sender, EventArgs e)
        {
            try
            {
                clearResultsTable();
                findAndPrintCorrectWords();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void findAndPrintCorrectWords()
        {
            /*
             * Get user-entered word
             */
            string userInput = userTilesTextBox.Text.Trim();

            /*
             * Clear the results pane first
             */
            clearResultsTable();

            try
            {
                List<String> wordsThatCanBeFormed;

                if (wordFiltersCheckBox.Checked)
                {
                    List<IWordFilter> filters = getSelectedFilters(userInput);
                    wordsThatCanBeFormed = wordFinderSession.findWords(userInput, filters);
                }
                else
                    wordsThatCanBeFormed = wordFinderSession.findWords(userInput);

                displayResults(wordsThatCanBeFormed);
                enrichResultsTable(userInput);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        private List<IWordFilter> getSelectedFilters(string userTiles)
        {
            var filters = new List<IWordFilter>(4);

            // Contains Filter
            if (!String.IsNullOrWhiteSpace(containsTextbox.Text))
                filters.Add(new ContainsFilter(containsTextbox.Text));

            // Ends With
            if (!String.IsNullOrWhiteSpace(endsWithTextbox.Text))
                filters.Add(new EndsWithFilter(endsWithTextbox.Text));

            // Starts With
            if (!String.IsNullOrWhiteSpace(startsWithTextbox.Text))
                filters.Add(new StartsWithFilter(startsWithTextbox.Text));

            return filters;
        }

        private void displayResults(List<string> correctWordsFromLetters)
        {
            if (correctWordsFromLetters.Count == 0)
            {
                MessageBox.Show("No results were found", "No results");
                resultsPanel.Hide();
                return;
            }

            // Organize words by length
            SortedList<int, List<String>> wordMap = wordFinderSession.mapWordsByLength(correctWordsFromLetters);

            // Get the array of word-lengths from the map.
            // We want longer words to appear first in the table,
            // so we reverse the list.
            int[] wordLengths = wordMap.Keys.Reverse().ToArray();

            // Create columns 
            foreach (int key in wordLengths)
            {
                // Add a column to contain words of this length
                int colIndex = resultsTable.Columns.Add("length" + key, "" + key + " tiles");

                // Disable sorting on each column
                resultsTable.Columns[colIndex].SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            // Arrange words into the columns
            arrangeWordsInTableColumns(wordMap, wordLengths);

            // show results panel
            resultsPanel.Show();
            resultsLabel.Text = correctWordsFromLetters.Count.ToString("N0") + " results";
        }

        private void arrangeWordsInTableColumns(SortedList<int, List<String>> wordMap, int[] wordLengths)
        {
            // Loop thru all lists to create a row of data
            // until all lists have been traversed
            bool thereAreMoreWordsToBePrinted = true;
            int currentIndex = 0;
            while (thereAreMoreWordsToBePrinted)
            {
                //reset flag
                thereAreMoreWordsToBePrinted = false;

                // create new row data
                String[] row = new String[wordLengths.Length];

                //for this row, go thru all lists to get values for a common index
                for (int j = 0; j < wordLengths.Length; j++)
                {
                    int thisLength = wordLengths[j];

                    List<String> wordList = wordMap[thisLength];
                    if (wordList.Count > currentIndex)
                    {
                        row[j] = wordList[currentIndex];
                        thereAreMoreWordsToBePrinted = true;
                    }
                    else
                    {
                        row[j] = "";
                    }
                }

                if (thereAreMoreWordsToBePrinted)
                {
                    addRowToTable(row);
                    currentIndex++;
                }
            }
        }

        private void addRowToTable(string[] row)
        {
            //create new row and return the index
            int n = resultsTable.Rows.Add();
            resultsTable.Rows[n].Resizable = DataGridViewTriState.False;

            for (int i = 0; i < row.Length; i++)
            {
                string word = row[i];
                resultsTable.Rows[n].Cells[i].Value = word;
            }
        }

        private void enrichResultsTable(string tiles)
        {
            DataGridViewRowCollection rows = resultsTable.Rows;
            foreach (DataGridViewRow row in rows)
            {
                DataGridViewCellCollection cells = row.Cells;
                foreach (DataGridViewCell cell in cells)
                {
                    string word = cell.Value as string;
                    if (!String.IsNullOrWhiteSpace(word))
                    {
                        // Set ToolTipText using the meaning of the word
                        cell.ToolTipText = "MEANING: " + wordFinderSession.getMeaning(word)
                            + "\nSCORE: " + wordFinderSession.calculateScore(word, tiles);


                        // Color the cell differently if word is a premium
                        if (tiles.Length == 7 && word.Length == 7)
                        {
                            cell.Style.BackColor = Color.Gold;
                            cell.Style.SelectionBackColor = Color.Gold;
                        }
                    }
                }
            }
        }

    }
}
