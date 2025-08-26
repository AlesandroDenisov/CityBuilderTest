using ContractsInterfaces.DomainGameplay.Grid;
using UnityEngine;

namespace Utilities
{
    /// <summary>
    /// Конвертер между Domain GridPosition и Unity Vector типами
    /// </summary>
    public static class GridPositionConverter
    {
        /// <summary>
        /// Конвертирует Unity Vector2Int в GridPosition
        /// </summary>
        /// <param name="unityPosition">Unity позиция</param>
        /// <returns>Domain позиция</returns>
        public static GridPosition ToGridPosition(this Vector2Int unityPosition)
        {
            return new GridPosition(unityPosition.x, unityPosition.y);
        }

        /// <summary>
        /// Конвертирует GridPosition в Unity Vector2Int
        /// </summary>
        /// <param name="gridPosition">Domain позиция</param>
        /// <returns>Unity позиция</returns>
        public static Vector2Int ToVector2Int(this GridPosition gridPosition)
        {
            return new Vector2Int(gridPosition.X, gridPosition.Y);
        }

        /// <summary>
        /// Конвертирует мировую позицию в GridPosition
        /// </summary>
        /// <param name="worldPosition">Мировая позиция</param>
        /// <param name="cellSize">Размер клетки</param>
        /// <returns>Позиция на сетке</returns>
        public static GridPosition WorldToGridPosition(Vector3 worldPosition, float cellSize)
        {
            return new GridPosition(
                Mathf.FloorToInt(worldPosition.x / cellSize),
                Mathf.FloorToInt(worldPosition.z / cellSize)
            );
        }

        /// <summary>
        /// Конвертирует GridPosition в мировую позицию
        /// </summary>
        /// <param name="gridPosition">Позиция на сетке</param>
        /// <param name="cellSize">Размер клетки</param>
        /// <param name="yPosition">Высота Y</param>
        /// <returns>Мировая позиция</returns>
        public static Vector3 GridToWorldPosition(GridPosition gridPosition, float cellSize, float yPosition = 0f)
        {
            return new Vector3(
                gridPosition.X * cellSize + cellSize * 0.5f,
                yPosition,
                gridPosition.Y * cellSize + cellSize * 0.5f
            );
        }
    }
}
