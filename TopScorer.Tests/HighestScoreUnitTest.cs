using NUnit.Framework;
using System.Collections.Generic;

namespace TopScorer.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void GetAllPersonsFromFile_ValidData_ReturnsCorrectScores()
        {
            // Arrange
            List<string> data = new List<string>
            {
                "Miles, Morales,85",
                "Freddy,Krueger,78",
                "John,Wick,90"
            };

            // Act
            PersonsWithHightestScore topScorers = new PersonsWithHightestScore();

            // Assert
            Assert.AreEqual(85, topScorers.GetAllPersonsFromFile(data)["Miles Morales"]);
            Assert.AreEqual(78, topScorers.GetAllPersonsFromFile(data)["Freddy Krueger"]);
            Assert.AreEqual(90, topScorers.GetAllPersonsFromFile(data)["John Wick"]);
        }

        [Test]
        public void GetHighestScorers_MultipleHighScorers_ReturnsInAlphabeticalOrder()
        {
            // Arrange
            var scores = new Dictionary<string, int>
            {
                { "Michael Myers", 85 },
                { "Miles Morales", 78 },
                { "Freddy Krueger", 90 },
                { "Jason  Voorhees", 90 },
                { "Regan  MacNeil", 90 },
                { "Hannibal Lecter", 90 }

            };


            // Act
            PersonsWithHightestScore topScorers = new PersonsWithHightestScore();

            // Assert
            Assert.AreEqual(4, topScorers.GetHighestScorers(scores).Count);
            Assert.AreEqual("Freddy Krueger", topScorers.GetHighestScorers(scores)[0]);
            Assert.AreEqual("Hannibal Lecter", topScorers.GetHighestScorers(scores)[1]);
            Assert.AreEqual("Jason  Voorhees", topScorers.GetHighestScorers(scores)[2]);
            Assert.AreEqual("Regan  MacNeil", topScorers.GetHighestScorers(scores)[3]);

        }

        [Test]
        public void GetHighestScore_Returns_MaximumScore()
        {
            // Arrange
            Dictionary<string, int> scores = new Dictionary<string, int>
            {
                { "Michael", 80 },
                { "Chucky", 92 },
                { "Jigsaw", 75 },
                { "Leatherface ", 92 },
                { "Freddy", 88 }
            };

            // Act
            PersonsWithHightestScore maxScore = new PersonsWithHightestScore();


            // Assert
            Assert.AreEqual(92, maxScore.GetHighestScore(scores));
        }
    }
}
