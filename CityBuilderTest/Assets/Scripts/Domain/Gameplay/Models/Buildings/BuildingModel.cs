using ContractsInterfaces.DomainGameplay.Buildings;
using ContractsInterfaces.DomainGameplay.Grid;
using UniRx;

namespace Domain.Gameplay.Models.Buildings
{
    /// <summary>
    /// Модель здания
    /// </summary>
    public class BuildingModel : IBuildingModel
    {
        /// <summary>
        /// Идентификатор здания
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Тип здания
        /// </summary>
        public string TypeId { get; }
        /// <summary>
        /// Уровень прокачки здания
        /// </summary>
        public int Level { get; private set; }
        /// <summary>
        /// Позиция здания на сетке GridModel
        /// </summary>
        public GridPosition GridPosition { get; private set; }
        /// <summary>
        /// Угол поворота здания в градусах
        /// </summary>
        public float Rotation { get; private set; }
        /// <summary>
        /// Статус процесса строительства
        /// </summary>
        public ReactiveProperty<BuildingProcessStatus> ProcessStatus { get; private set; }
        /// <summary>
        /// Прогресс строительства
        /// </summary>
        public ReactiveProperty<float> ConstructionProgress { get; private set; }
    
        public BuildingModel(string id, string typeId, int level, GridPosition position, float rotation = 0f)
        {
            Id = id;
            TypeId = typeId;
            Level = level;
            GridPosition = position;
            Rotation = rotation;
            ProcessStatus = new ReactiveProperty<BuildingProcessStatus>(BuildingProcessStatus.None);
            ConstructionProgress = new ReactiveProperty<float>(0f);
        }
        
        /// <summary>
        /// Устанавливает новую позицию здания
        /// </summary>
        /// <param name="position">Новая позиция</param>
        public void SetPosition(GridPosition position) => GridPosition = position;
        /// <summary>
        /// Устанавливает уровень здания
        /// </summary>
        /// <param name="level">Новый уровень</param>
        public void SetLevel(int level) => Level = level;
        /// <summary>
        /// Устанавливает угол поворота здания
        /// </summary>
        /// <param name="rotation">Угол в градусах</param>
        public void SetRotation(float rotation) => Rotation = rotation;
        /// <summary>
        /// Устанавливает статус процесса строительства
        /// </summary>
        /// <param name="processStatus">Новый статус</param>
        public void SetProcessStatus(BuildingProcessStatus processStatus) => ProcessStatus.Value = processStatus;
        /// <summary>
        /// Устанавливает прогресс строительства
        /// </summary>
        /// <param name="progress">Прогресс от 0 до 1</param>
        public void SetProgress(float progress) => ConstructionProgress.Value = progress;
    }
}
