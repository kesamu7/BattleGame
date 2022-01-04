namespace BattleGame.Client.Services
{
    public class PizzaSliceService : IPizzaSliceService
    {
        public event Action OnChange;

        public int PizzaSlices { get; set; } = 1000;

        public void EatPizzaSlices(int amount)
        {
            PizzaSlices -= amount;
            PizzaSlicesChanged();
        }

        void PizzaSlicesChanged() => OnChange.Invoke();

        public void AddPizzaSlices(int amount)
        {
            PizzaSlices += amount;
            PizzaSlicesChanged();
        }
    }
}
