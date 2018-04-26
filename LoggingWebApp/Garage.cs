namespace LoggingWebApp
{
    public class Garage : IGarage
    {
        public ICar Car { get; }

        public Garage(ICar car)
        {
            Car = car;
        }
    }
}
