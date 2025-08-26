using ContractsInterfaces.DomainGameplay.Grid;
using UnityEngine;
using ContractsInterfaces.ViewsGameplay;
using Utilities;

namespace Presentation.Gameplay.Views
{
    /// <summary>
    /// Отображение сетки
    /// </summary>
    public class GridView : MonoBehaviour, IGridView
    {
        [SerializeField] private GameObject _highlightPrefab;
        [SerializeField] private Material _validMaterial;
        [SerializeField] private Material _invalidMaterial;
        [SerializeField] private float _cellSize = 1f;
        
        private GameObject _highlight;
        private MeshRenderer _highlightRenderer;
        
        private void Awake()
        {
            InitializeHighlight();
        }
        
        private void InitializeHighlight()
        {
            _highlight = Instantiate(_highlightPrefab);
            _highlightRenderer = _highlight.GetComponent<MeshRenderer>();
            _highlight.SetActive(false);
        }
        
        public void ShowHighlight(GridPosition position, bool isValid)
        {
            _highlight.SetActive(true);
            _highlight.transform.position = GridPositionConverter.GridToWorldPosition(position, _cellSize);
            _highlightRenderer.material = isValid ? _validMaterial : _invalidMaterial;
        }
        
        public void HideHighlight()
        {
            _highlight.SetActive(false);
        }
        
        public GridPosition WorldToGridPosition(Vector3 worldPosition) => GridPositionConverter.WorldToGridPosition(worldPosition, _cellSize);
        
        public Vector3 GridToWorldPosition(GridPosition gridPosition)
        {
            return GridPositionConverter.GridToWorldPosition(gridPosition, _cellSize);
        }
    }
}
