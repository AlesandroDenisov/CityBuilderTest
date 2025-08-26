using UnityEngine;

namespace Repositories.Gameplay
{
    /// <summary>
    /// Репозиторий игровых настроек
    /// </summary>
    [CreateAssetMenu(fileName = "GameSettings", menuName = "CityBuilder/Game Settings")]
    public class GameSettingsRepository : ScriptableObject
    {
        [Header("Grid Configuration")]
        public int GridWidth = 32;
        
        public int GridHeight = 32;
        
        [Header("Economy")]
        public int StartingGold = 200;
        public float IncomeTickInterval = 5f;
        
        [Header("Auto Save")]
        public bool EnableAutoSave = true;
        public float AutoSaveInterval = 60f;
    }
}
