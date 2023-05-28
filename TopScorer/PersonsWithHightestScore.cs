using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopScorer
{
    public class PersonsWithHightestScore
    {
        /** 
        * Method takes data from CSV file and extracts name, surname and score        *  
        * Method checks for duplicate and invalid data
        * */
        public Dictionary<string, int> GetAllPersonsFromFile(List<string> values)
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();

            foreach (string item in values)
            {
                string[] parts = item.Split(',');
                if (parts.Length == 3 && int.TryParse(parts[2], out int score))
                {
                    string name = parts[0].Trim() + " " + parts[1].Trim();
                    if (!scores.ContainsKey(name))
                    {
                        scores.Add(name, score);
                    }
                    else
                    {
                        Console.WriteLine("Duplicate data found for: " + name);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid data format: " + item);
                }
            }

            return scores;
        }

        /** 
         * This methods finds the person with the highest marks
         * By iterating through the dictionary entry and adding to the list
         * List is sorted in alphabetical order
         * */
        public List<string> GetHighestScorers(Dictionary<string, int> scores)
        {
            List<string> topScorers = new List<string>();
            int maxScore = GetHighestScore(scores);

            foreach (var pair in scores)
            {
                if (pair.Value == maxScore)
                {
                    topScorers.Add(pair.Key);
                }
            }

            topScorers.Sort();
            return topScorers;
        }

        /** 
         * This methods finds the person with the highest marks
         * By iterating through the dictionary entry and adding to the list
         * List is sorted in alphabetical order
         * */
        public int GetHighestScore(Dictionary<string, int> scores)
        {
            int maxScore = int.MinValue;

            foreach (var pair in scores)
            {
                if (pair.Value > maxScore)
                {
                    maxScore = pair.Value;
                }
            }

            return maxScore;
        }
    }
}
