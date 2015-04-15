using ScrabbleWordFinder.Dictionary;
using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ScrabbleWordFinder
{
    public class DictionaryLoader
    {
        public DictionaryLoader()
        {
        }

        public StreamReader loadDictionaryTextStreamFromAssembly()
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                StreamReader textStreamReader = new StreamReader(assembly.GetManifestResourceStream("ScrabbleWordFinder.OSPD4.txt"));
                return textStreamReader;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error reading dictionary file from assembly.", e);
            }
        }

        public void loadDictionary(IWordDictionary wordDictionary)
        {
            StreamReader reader = loadDictionaryTextStreamFromAssembly();
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    line = line.Trim();

                    if (line.Length != 0)
                    {
                        String word = getWordFromLine(line);
                        String meaning = "";
                        if (line.Length > word.Length)
                            meaning = line.Substring(word.Length).Trim();

                        // Add word to dictionaries
                        wordDictionary.addWordAndMeaning(word, meaning);

                        // Read next line
                        line = reader.ReadLine();
                    }
                }
            }

        }

        ///<summary>
        ///Extract the key word on each line in the file
        ///</summary>
        private String getWordFromLine(String line)
        {
            string regexGetWordFromLine = "^[A-Z]+(?=\\s?)";
            Match match = Regex.Match(line, regexGetWordFromLine);

            if (match.Success)
                return match.Value;
            else
                throw new ApplicationException("The word on the line could not be found. Line='" + line + "', Regex='" + regexGetWordFromLine + "'");
        }

    }
}
