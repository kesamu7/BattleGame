using BattleGame.Shared;

namespace BattleGame.Client.Services
{
    public class BattleUnitService : IBattleUnitService
    {
        //A UNIT IS A GROUP OF SPECIFIC FIGHTERS THAT YOU CAN CREATE OR GET LIKE ARCHERS,MAGES,BRAWLERS,KNIGHTS...ETC
        public IList<BattleUnit> BattleUnits { get; set; }
        public IList<UserUnit> UserUnits { get; set ; }

        public void AddUnit(int UnitId)
        {
            throw new NotImplementedException();
        }
    }
}
