namespace ContractsInterfaces.DomainGameplay.Buildings
{
    /// <summary>
    /// Интерфейс конфигурации типа здания
    /// </summary>
    public interface IBuildingType
    {
        string Id { get; }
        string Name { get; }
        int BaseCost { get; }
        int BaseIncome { get; }
        int MaxLevel { get; }
        float BaseConstructionTime { get; }
        
        int GetCostForLevel(int level);
        int GetIncomeForLevel(int level);
        float GetConstructionTimeForLevel(int level);
    }
}
