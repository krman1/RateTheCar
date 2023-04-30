namespace RateTheCar.Tests
{
    public class Tests
    {
        [Test]
        public void GetStatisticsMaxTest()
        {
            // arrange
            CarInMemory carInMemory = new CarInMemory("Ford", "Mustang");
            carInMemory.AddScore(5);
            carInMemory.AddScore(7);
            carInMemory.AddScore(3);
            carInMemory.AddScore(8);
            carInMemory.AddScore(1);

            // act
            var statistics = carInMemory.GetStatistics();
            var result = statistics.Max;

            // assert
            Assert.AreEqual(8, result);
        }
        [Test]
        public void GetStatisticsMinTest()
        {
            // arrange
            CarInMemory carInMemory = new CarInMemory("Ford", "Mustang");
            carInMemory.AddScore(5);
            carInMemory.AddScore(7);
            carInMemory.AddScore(3);
            carInMemory.AddScore(8);
            carInMemory.AddScore(1);

            // act
            var statistics = carInMemory.GetStatistics();
            var result = statistics.Min;

            // assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void GetStatisticsAverageTest()
        {
            // arrange
            CarInMemory carInMemory = new CarInMemory("Ford", "Mustang");
            carInMemory.AddScore(5);
            carInMemory.AddScore(7);
            carInMemory.AddScore(3);
            carInMemory.AddScore(8);
            carInMemory.AddScore(1);

            // act
            var statistics = carInMemory.GetStatistics();
            var result = Math.Round(statistics.Average);

            // assert
            Assert.AreEqual(5, result);
        }
    }
}
