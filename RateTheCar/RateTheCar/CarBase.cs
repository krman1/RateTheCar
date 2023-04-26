namespace RateTheCar
{
    public abstract class CarBase : ICar
    {
        public CarBase(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }
        public string Brand { get; set; }
        public string Model { get; set; }

        public abstract void AddScore(int raiting);
        public abstract void AddScore(float raiting);
        public abstract void AddScore(string raiting);
        public abstract Statistics GetStatistics();

    }
}
