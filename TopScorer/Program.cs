using System;
using System.Collections.Generic;
using System.IO;

namespace TopScorer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Kulani\Downloads\TestData.csv";
            List<string> file = ReadCsvFile(filePath);  // Read the contents of the CSV file

            if (file.Count > 1) // Skip header line
            {
                file.RemoveAt(0);
                PersonsWithHightestScore score = new PersonsWithHightestScore();
                Dictionary<string, int> persons = score.GetAllPersonsFromFile(file);
                List<string> topScorers = score.GetHighestScorers(persons);
                int hightScore = score.GetHighestScore(persons);

                foreach (string scorer in topScorers)
                {
                    Console.WriteLine(scorer);
                    Console.WriteLine();// Add empty lines to show output as shown on the instructions
                }
                Console.WriteLine("Score: " + hightScore);
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }

        /**
         * This  method reads the contents of the CSV file using a StreamReader
         * Shows an error message if an exception occurs while the file is read 
         */
        private static List<string> ReadCsvFile(string filePath)
        {
            List<string> lines = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading the file: " + ex.Message);
            }

            return lines;
        }

    }
}
