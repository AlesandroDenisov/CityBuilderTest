using ContractsInterfaces.DomainGameplay;
using ContractsInterfaces.DomainGameplay.Buildings;
using ContractsInterfaces.DomainGameplay.Grid;
using Domain.Gameplay.Models.Economy;
using Domain.Gameplay.Models.Grid;
using UniRx;

namespace Domain.Gameplay.Models
{
    /// <summary>
    /// Модель города/уровня
    /// </summary>
    public class CityModel : ICityModel
    {
        public GridModel Grid { get; private set; }
        public IEconomyModel Economy { get; private set; }
        public ReactiveProperty<IBuildingModel> SelectedBuilding { get; private set; }
        
        public CityModel(int gridWidth, int gridHeight, int startingGold)
        {
            Grid = new GridModel(gridWidth, gridHeight);
            Economy = new EconomyModel(startingGold);
            SelectedBuilding = new ReactiveProperty<IBuildingModel>(null);
        }
    }
}
