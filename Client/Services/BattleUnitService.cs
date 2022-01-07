using BattleGame.Shared;

namespace BattleGame.Client.Services
{
    public class BattleUnitService : IBattleUnitService
    {
        //A UNIT IS A GROUP OF SPECIFIC FIGHTERS THAT YOU CAN CREATE OR GET LIKE ARCHERS,MAGES,BRAWLERS,KNIGHTS...ETC
        public IList<BattleUnit> BattleUnits => new List<BattleUnit>
        {
            new BattleUnit{Id = 1, Title = "Knight", Attack = 10, Defense = 10, PizzaSliceCost = 100},
            new BattleUnit{Id = 2, Title = "Archer", Attack = 15, Defense=5, PizzaSliceCost = 150},
            new BattleUnit(){Id = 3, Title = "Mage", Attack = 20, Defense = 10, PizzaSliceCost=200},
        };
        public IList<UserUnit> UserUnits { get; set ; } = new List<UserUnit>();

        public void AddUnit(int unitId)
        {
            var unit = BattleUnits.First(unit => unit.Id == unitId);
            UserUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints });
        }
    }
}
