using MoodAnalyzerProblem;
namespace MoodAnalyserTesting
{
   
    public class UnitTest1
    {
       

        [Test]
        public void GivenSadMoodReturnSad()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyse= new MoodAnalyser(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [Test]
        public void GivenHappyMoodReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [Test]
       
        public void GivenNullMoodReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = null;
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [Test]

        public void GivenNullMoodShouldThrowMoodAnalysisException()
        {
            //Arrange
            try
            {
                //string expected = "HAPPY";
                string message = "";
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);

                //Act
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyzerCustumException e)
            {

                //Assert
                Assert.AreEqual("Mood should not be Empty",e.Message);
            }
        }

    }
}