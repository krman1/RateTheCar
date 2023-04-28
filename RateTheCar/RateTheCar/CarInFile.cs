namespace RateTheCar
{
    public class CarInFile :CarBase
    {
        private List<float> scoreInFile = new List<float>();
        private const string fileName = "grades.txt";
        public CarInFile() { }
        public CarInFile(string brand, string model)
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
                using (var writen = File.AppendText(fileName))
                {
                    writen.WriteLine(raiting);
                }
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

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var number = float.Parse(line);
                        statistics.AddGrade(number);
                    }
                }
            }
            return statistics;
        }
        
    }
}

