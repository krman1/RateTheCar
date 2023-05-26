namespace RateTheCar
{
    public class CarInMemory : CarBase
    {
        private List<float> score = new List<float>();
        public CarInMemory() { }
        public CarInMemory(string brand, string model)
            : base(brand, model)
        {
        }
        public override void AddScore(float raiting)
        {
            if (raiting >= 0 && raiting <= 10)
            {
                this.score.Add(raiting);
            }
            else
            {
                throw new Exception("Invalid data, use numbers between 0 - 10 ");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var score in this.score)
            {
                statistics.AddGrade(score);
            }

            return statistics;
        }
    }
}

