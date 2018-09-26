namespace DPWorkout.Creational.Builder
{
    public class Meal
    {
        public string Name { get; set; }

        public bool ForVegetarians { get; set; }

        public decimal Price { get; set; }

        public int PreparationTime { get; set; }

        public override string ToString()
        {
            return $"\r\n\t {nameof(Name)}: {Name},\r\n\t {nameof(ForVegetarians)}: {ForVegetarians},\r\n\t {nameof(Price)}: {Price},\r\n\t {nameof(PreparationTime)}: {PreparationTime}";
        }
    }
}
