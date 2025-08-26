using ContractsInterfaces.DomainGameplay;
using UniRx;

namespace Domain.Gameplay.Models.Economy
{
    /// <summary>
    /// Модель экономики - только данные о ресурсах
    /// </summary>
    public class EconomyModel : IEconomyModel
    {
        public ReactiveProperty<int> Gold { get; private set; }
        public ReactiveProperty<int> IncomePerTick { get; private set; }
        
        public EconomyModel(int startingGold)
        {
            Gold = new ReactiveProperty<int>(startingGold);
            IncomePerTick = new ReactiveProperty<int>(0);
        }
        
        public void SetGold(int amount) => Gold.Value = amount;
        public void AddGold(int amount) => Gold.Value += amount;
        public void RemoveGold(int amount) => Gold.Value = UnityEngine.Mathf.Max(0, Gold.Value - amount);
        public void SetIncomePerTick(int amount) => IncomePerTick.Value = amount;
    }
}
