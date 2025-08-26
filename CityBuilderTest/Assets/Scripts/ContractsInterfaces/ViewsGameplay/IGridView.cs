using ContractsInterfaces.DomainGameplay.Grid;
using UnityEngine;

namespace ContractsInterfaces.ViewsGameplay
{
    /// <summary>
    /// Интерфейс View сетки - работает с Domain типами
    /// </summary>
    public interface IGridView
    {
        void ShowHighlight(GridPosition position, bool isValid);
        void HideHighlight();
        GridPosition WorldToGridPosition(Vector3 worldPosition);
        UnityEngine.Vector3 GridToWorldPosition(GridPosition gridPosition);
    }
}
