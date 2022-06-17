using MoodAnalyser;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("MOOD HAPPY")]
        public void TestMethod1()
        {
            
            string message = "I am HAPPY today";
            
            string expected = "happy";
            
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
           
            string actual = moodAnalyzer.AnalyseMood();
           
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("MOOD SAD")]
        public void TestMethod2()
        {
            
            string message = "I am sad today";
            
            string expected = "sad";
            
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            
            string actual = moodAnalyzer.AnalyseMood();
            
            Assert.AreEqual(expected, actual);
        }
    }
}