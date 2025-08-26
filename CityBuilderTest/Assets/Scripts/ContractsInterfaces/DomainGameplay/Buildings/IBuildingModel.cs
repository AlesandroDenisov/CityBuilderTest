using ContractsInterfaces.DomainGameplay.Grid;
using UniRx;

namespace ContractsInterfaces.DomainGameplay.Buildings
{
    /// <summary>
    /// Интерфейс для модели здания
    /// </summary>
    public interface IBuildingModel
    {
        /// <summary>
        /// Уникальный идентификатор здания
        /// </summary>
        string Id { get; }
        /// <summary>
        /// Идентификатор типа здания
        /// </summary>
        string TypeId { get; }
        /// <summary>
        /// Текущий уровень здания
        /// </summary>
        int Level { get; }
        /// <summary>
        /// Позиция здания на сетке
        /// </summary>
        GridPosition GridPosition { get; }
        /// <summary>
        /// Угол поворота здания в градусах
        /// </summary>
        float Rotation { get; }
        /// <summary>
        /// Статус процесса строительства
        /// </summary>
        ReactiveProperty<BuildingProcessStatus> ProcessStatus { get; }
        /// <summary>
        /// Прогресс строительства от 0 до 1
        /// </summary>
        ReactiveProperty<float> ConstructionProgress { get; }
        
        /// <summary>
        /// Устанавливает новую позицию здания
        /// </summary>
        /// <param name="position">Новая позиция</param>
        void SetPosition(GridPosition position);
        /// <summary>
        /// Устанавливает уровень здания
        /// </summary>
        /// <param name="level">Новый уровень</param>
        void SetLevel(int level);
        /// <summary>
        /// Устанавливает угол поворота здания
        /// </summary>
        /// <param name="rotation">Угол в градусах</param>
        /// <summary>
        void SetRotation(float rotation);
        /// Устанавливает статус процесса строительства
        /// </summary>
        /// <param name="processStatus">Новый статус</param>
        void SetProcessStatus(BuildingProcessStatus processStatus);
        /// <summary>
        /// Устанавливает прогресс строительства
        /// </summary>
        /// <param name="progress">Прогресс от 0 до 1</param>
        void SetProgress(float progress);
    }
}
