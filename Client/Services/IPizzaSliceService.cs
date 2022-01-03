namespace BattleGame.Client.Services
{
    public interface IPizzaSliceService
    {
        event Action OnChange;

        public int PizzaSlices { get; set; }
        
        void EatPizzaSlices(int amount);

    }
}
