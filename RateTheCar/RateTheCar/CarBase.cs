namespace RateTheCar
{
    public abstract class CarBase : ICar
    {
        public CarBase()
        {
        }
        public CarBase(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }
        public string Brand { get; set; }
        public string Model { get; set; }

        public void AddScore(int raiting)
        {
            float result = raiting;
            this.AddScore(result);
        }
        public abstract void AddScore(float raiting);
        public void AddScore(string raiting)
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
        public ICar CreateCar()
        {
            Console.Write("Podaj markę samochodu: ");
            this.Brand = Console.ReadLine();
            Console.Write("podaj model samochodu: ");
            this.Model = Console.ReadLine();
            return this;
        }
        public abstract Statistics GetStatistics();
    }
}
