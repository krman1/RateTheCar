namespace RateTheCar
{
    public interface ICar
    {
        string Brand { get; }
        string Model { get; }
        void AddScore(int raiting);
        void AddScore(float raiting);
        void AddScore(string raiting);
        ICar CreateCar();
        abstract Statistics GetStatistics();
    }
}
