using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

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
    }
}
