using BattleGame.Shared;

namespace BattleGame.Client.Services
{
    public interface IBattleUnitService
    {
        IList<BattleUnit> BattleUnits { get; }
        IList<UserUnit> UserUnits { get; set; }

        void AddUnit(int UnitId);


    }
}
