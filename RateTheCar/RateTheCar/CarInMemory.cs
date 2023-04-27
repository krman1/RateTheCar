namespace RateTheCar
{
    public class CarInMemory :CarBase
    {
        private List<float> score = new List<float>();
        public CarInMemory(string brand, string model)
            : base(brand, model)
        {
        }
        public override void AddScore(int raiting)
        {
            float result = raiting;
            this.AddScore(result);
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

        public override void AddScore(string raiting)
        {
            if (float.TryParse(raiting, out float result))
            {
                this.AddScore(result);
            }
            else
            {
                throw new Exception("Wrong string");
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

