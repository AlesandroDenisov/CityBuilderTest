using System;
using System.Collections.Generic;
using ContractsInterfaces.DomainGameplay.Grid;

namespace Domain.Gameplay.Models.Grid
{
    public class GridModel
    { 
        private readonly bool[,] _occupiedCells;
        
        public int Width { get; }
        public int Height { get; }
        
        public GridModel(int width, int height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Grid dimensions must be positive");
            
            Width = width;
            Height = height;
            _occupiedCells = new bool[width, height];
        }
        
        /// <summary>
        /// Проверяет, является ли позиция валидной
        /// </summary>
        /// <param name="position">Позиция для проверки</param>
        /// <returns>True если позиция в пределах сетки</returns>
        public bool IsValidPosition(GridPosition position)
        {
            return position.X >= 0 && position.X < Width && 
                   position.Y >= 0 && position.Y < Height;
        }
        
        /// <summary>
        /// Проверяет, занята ли позиция зданием
        /// </summary>
        /// <param name="position">Позиция для проверки</param>
        /// <returns>True если позиция занята</returns>
        public bool IsOccupied(GridPosition position)
        {
            if (!IsValidPosition(position))
                return true;
                
            return _occupiedCells[position.X, position.Y];
        }
        
        public bool CanPlaceAt(GridPosition position)
        {
            return IsValidPosition(position) && !IsOccupied(position);
        }
        
        public void SetOccupied(GridPosition position, bool occupied)
        {
            if (!IsValidPosition(position))
                throw new ArgumentException($"Invalid grid position: {position}");
                
            _occupiedCells[position.X, position.Y] = occupied;
        }
        
        public IEnumerable<GridPosition> GetOccupiedPositions()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (_occupiedCells[x, y])
                    {
                        yield return new GridPosition(x, y);
                    }
                }
            }
        }
        
        public void Clear()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    _occupiedCells[x, y] = false;
                }
            }
        }
    }
}
