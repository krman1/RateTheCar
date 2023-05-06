namespace RateTheCar.Tests
{
    public class FileTests
    {

        [Test]
        public void GetStatisticsMaxTest()
        {
            // arrange
            CarInFile carInFile = new CarInFile("Ford", "Mustang");
            carInFile.AddScore(5);
            carInFile.AddScore(7);
            carInFile.AddScore(3);
            carInFile.AddScore(8);
            carInFile.AddScore(1);

            // act
            var statistics = carInFile.GetStatistics();
            var result = statistics.Max;

            // assert
            Assert.AreEqual(8, result);
        }
        [Test]
        public void GetStatisticsMinTest()
        {
            // arrange
            CarInFile carInFile = new CarInFile("Ford", "Mustang");
            carInFile.AddScore(5);
            carInFile.AddScore(7);
            carInFile.AddScore(3);
            carInFile.AddScore(8);
            carInFile.AddScore(1);

            // act
            var statistics = carInFile.GetStatistics();
            var result = statistics.Min;

            // assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void GetStatisticsAverageTest()
        {
            // arrange
            CarInFile carInFile = new CarInFile("Ford", "Mustang");
            carInFile.AddScore(5);
            carInFile.AddScore(7);
            carInFile.AddScore(3);
            carInFile.AddScore(8);
            carInFile.AddScore(1);

            // act
            var statistics = carInFile.GetStatistics();
            var result = Math.Round(statistics.Average);

            // assert
            Assert.AreEqual(5, result);
        }
        [Test]
        public void GetStatisticsAverageLetterTest()
        {
            // arrange
            CarInFile carInFile = new CarInFile("Ford", "Mustang");
            carInFile.AddScore(5);
            carInFile.AddScore(7);
            carInFile.AddScore(3);
            carInFile.AddScore(8);
            carInFile.AddScore(1);

            // act
            var statistics = carInFile.GetStatistics();
            var result = statistics.AverageLetter;

            // assert
            Assert.AreEqual('C', result);
        }
    }
}

