using System;
using ContractsInterfaces.DomainGameplay.Buildings;
using UnityEngine;

namespace Repositories.Gameplay
{
    /// <summary>
    /// Конфигурация типа здания
    /// </summary>
    [Serializable]
    public class BuildingTypeConfig : IBuildingType
    {
        [Header("Base Properties")]
        [SerializeField] private string _id;
        [SerializeField] private string _name;
        [SerializeField] private GameObject _prefab;
        
        [Header("Economy")]
        [SerializeField] private int _baseCost = 100;
        [SerializeField] private int _baseIncome = 10;
        
        [Header("Progression")]
        [SerializeField] private int _maxLevel = 3;
        [SerializeField] private float _costMultiplier = 1.5f;
        [SerializeField] private float _incomeMultiplier = 1.25f;
        
        [Header("Construction")]
        [SerializeField] private float _baseConstructionTime = 5f;
        [SerializeField] private float _constructionTimeMultiplier = 1.2f;
        private IBuildingType _buildingTypeImplementation;

        public string Id => _id;
        public string Name => _name;
        public int BaseCost => this._buildingTypeImplementation.BaseCost;

        public int BaseIncome => this._buildingTypeImplementation.BaseIncome;

        public int MaxLevel => this._buildingTypeImplementation.MaxLevel;

        public float BaseConstructionTime => this._buildingTypeImplementation.BaseConstructionTime;

        public GameObject Prefab => _prefab;
        
        public int GetCostForLevel(int level) => Mathf.RoundToInt(_baseCost * Mathf.Pow(_costMultiplier, level - 1));
        
        public int GetIncomeForLevel(int level) => Mathf.RoundToInt(_baseIncome * Mathf.Pow(_incomeMultiplier, level - 1));
        
        public float GetConstructionTimeForLevel(int level) => _baseConstructionTime * Mathf.Pow(_constructionTimeMultiplier, level - 1);
    }
}
