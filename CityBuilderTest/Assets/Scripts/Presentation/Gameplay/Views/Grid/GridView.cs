using UnityEngine;

namespace Presentation.Gameplay.Views.Grid
{
    public class GridView : MonoBehaviour
    {
        // [Header("Grid Settings")]
        // [SerializeField] private float _cellSize = 1f;
        // [SerializeField] private Material _gridLineMaterial;
        // [SerializeField] private Material _highlightMaterial;
        //
        // [Header("Highlight Colors")]
        // [SerializeField] private Color _canPlaceColor = Color.green;
        // [SerializeField] private Color _cannotPlaceColor = Color.red;
        //
        // private readonly IGridService _gridService;
        // private LineRenderer[] _gridLines;
        // private GameObject _highlightQuad;
        // private MeshRenderer _highlightRenderer;
        // private Camera _camera;
        //
        // [Inject]
        // public void Construct(IGridService gridService)
        // {
        //     _gridService = gridService;
        // }
        //
        // private void Awake()
        // {
        //     _camera = Camera.main;
        //     CreateHighlightQuad();
        // }
        //
        // private void OnDestroy()
        // {
        //     if (_gridService != null)
        //     {
        //         _gridService.CellHighlightChanged -= OnCellHighlightChanged;
        //     }
        // }
        //
        // private void Update()
        // {
        //     UpdateHighlightFromMouse();
        // }
        //
        // public void Initialize()
        // {
        //     _gridService.CellHighlightChanged += OnCellHighlightChanged;
        //     
        //     CreateGridLines();
        // }
        //
        // private void UpdateHighlightFromMouse()
        // {
        //     if (_camera == null || _gridService == null) return;
        //     
        //     Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        //     
        //     // Cast ray onto Y=0 plane (assuming flat grid)
        //     if (ray.direction.y != 0)
        //     {
        //         float t = -ray.origin.y / ray.direction.y;
        //         if (t >= 0)
        //         {
        //             Vector3 hitPoint = ray.origin + t * ray.direction;
        //             GridPosition gridPos = WorldToGridPosition(hitPoint);
        //             _gridService.SetHighlightedCell(gridPos);
        //             return;
        //         }
        //     }
        //     
        //     _gridService.ClearHighlight();
        // }
        //
        // private void CreateGridLines()
        // {
        //     if (_gridService == null) return;
        //     
        //     int totalLines = (_gridService.LevelGrid.Width + 1) + (_gridService.LevelGrid.Height + 1);
        //     _gridLines = new LineRenderer[totalLines];
        //     
        //     int lineIndex = 0;
        //     
        //     // Vertical lines
        //     for (int x = 0; x <= _gridService.LevelGrid.Width; x++)
        //     {
        //         GameObject lineObj = new GameObject($"GridLine_V_{x}");
        //         lineObj.transform.SetParent(transform);
        //         
        //         LineRenderer lr = lineObj.AddComponent<LineRenderer>();
        //         lr.material = _gridLineMaterial;
        //         lr.color = Color.white;
        //         lr.startWidth = 0.02f;
        //         lr.endWidth = 0.02f;
        //         lr.positionCount = 2;
        //         
        //         Vector3 start = GridToWorldPosition(new GridPosition(x, 0));
        //         Vector3 end = GridToWorldPosition(new GridPosition(x, _gridService.LevelGrid.Height));
        //         start.x -= _cellSize * 0.5f;
        //         end.x -= _cellSize * 0.5f;
        //         
        //         lr.SetPosition(0, start);
        //         lr.SetPosition(1, end);
        //         
        //         _gridLines[lineIndex++] = lr;
        //     }
        //     
        //     // Horizontal lines
        //     for (int y = 0; y <= _gridService.LevelGrid.Height; y++)
        //     {
        //         GameObject lineObj = new GameObject($"GridLine_H_{y}");
        //         lineObj.transform.SetParent(transform);
        //         
        //         LineRenderer lr = lineObj.AddComponent<LineRenderer>();
        //         lr.material = _gridLineMaterial;
        //         lr.color = Color.white;
        //         lr.startWidth = 0.02f;
        //         lr.endWidth = 0.02f;
        //         lr.positionCount = 2;
        //         
        //         Vector3 start = GridToWorldPosition(new GridPosition(0, y));
        //         Vector3 end = GridToWorldPosition(new GridPosition(_gridService.LevelGrid.Width, y));
        //         start.z -= _cellSize * 0.5f;
        //         end.z -= _cellSize * 0.5f;
        //         
        //         lr.SetPosition(0, start);
        //         lr.SetPosition(1, end);
        //         
        //         _gridLines[lineIndex++] = lr;
        //     }
        // }
        //
        // private void CreateHighlightQuad()
        // {
        //     _highlightQuad = GameObject.CreatePrimitive(PrimitiveType.Quad);
        //     _highlightQuad.name = "CellHighlight";
        //     _highlightQuad.transform.SetParent(transform);
        //     _highlightQuad.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        //     _highlightQuad.transform.localScale = Vector3.one * _cellSize * 0.9f;
        //     
        //     // Remove collider
        //     Destroy(_highlightQuad.GetComponent<Collider>());
        //     
        //     _highlightRenderer = _highlightQuad.GetComponent<MeshRenderer>();
        //     _highlightRenderer.material = _highlightMaterial;
        //     
        //     _highlightQuad.SetActive(false);
        // }
        //
        // private void OnCellHighlightChanged(GridPosition position, bool canPlace)
        // {
        //     if (canPlace || !_gridService.LevelGrid.IsValidPosition(position))
        //     {
        //         if (_gridService.LevelGrid.IsValidPosition(position))
        //         {
        //             // Show highlight
        //             Vector3 worldPos = GridToWorldPosition(position);
        //             _highlightQuad.transform.position = worldPos;
        //             _highlightRenderer.material.color = canPlace ? _canPlaceColor : _cannotPlaceColor;
        //             _highlightQuad.SetActive(true);
        //         }
        //         else
        //         {
        //             // Hide highlight for invalid positions
        //             _highlightQuad.SetActive(false);
        //         }
        //     }
        //     else
        //     {
        //         // Show red highlight for occupied cells
        //         Vector3 worldPos = GridToWorldPosition(position);
        //         _highlightQuad.transform.position = worldPos;
        //         _highlightRenderer.material.color = _cannotPlaceColor;
        //         _highlightQuad.SetActive(true);
        //     }
        // }
        //
        // public Vector3 GridToWorldPosition(GridPosition gridPos)
        // {
        //     return new Vector3(gridPos.X * _cellSize, 0f, gridPos.Y * _cellSize);
        // }
        //
        // public GridPosition WorldToGridPosition(Vector3 worldPos)
        // {
        //     int x = Mathf.RoundToInt(worldPos.x / _cellSize);
        //     int z = Mathf.RoundToInt(worldPos.z / _cellSize);
        //     return new GridPosition(x, z);
        // }
        //
        // public float CellSize => _cellSize;
    }
}
