using System.Collections.Generic;
using System.Linq;
using ContractsInterfaces.DomainGameplay.Buildings;
using UnityEngine;

namespace Repositories.Gameplay
{
    /// <summary>
    /// Репозиторий конфигураций типов зданий
    /// </summary>
    [CreateAssetMenu(fileName = "BuildingTypesRepository", menuName = "CityBuilder/Building Types")]
    public class BuildingTypesRepository : ScriptableObject//, IBuildingTypesRepository
    {
        [Header("Building Types Configuration")]
        [SerializeField] private List<BuildingTypeConfig> buildingTypes;
        
        public IReadOnlyList<IBuildingType> GetAllTypes() => this.buildingTypes;
        
        public IBuildingType GetBuildingType(string typeId) => 
                        this.buildingTypes.FirstOrDefault(t => t.Id == typeId);
    }
}
