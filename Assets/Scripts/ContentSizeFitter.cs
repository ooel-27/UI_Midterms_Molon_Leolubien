using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class DynamicGridResizer : MonoBehaviour
{
    private GridLayoutGroup grid;
    private RectTransform rectTransform;

    void Awake()
    {
        grid = GetComponent<GridLayoutGroup>();
        rectTransform = GetComponent<RectTransform>();
    }

    void LateUpdate()
    {
        int childCount = transform.childCount;

        if (childCount == 0 || grid.constraintCount <= 0)
            return;

        int constraint = grid.constraintCount;

        if (grid.constraint == GridLayoutGroup.Constraint.FixedColumnCount)
        {
            int rows = Mathf.CeilToInt((float)childCount / constraint);
            float height = rows * (grid.cellSize.y + grid.spacing.y) - grid.spacing.y;
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
        }
        else if (grid.constraint == GridLayoutGroup.Constraint.FixedRowCount)
        {
            int columns = Mathf.CeilToInt((float)childCount / constraint);
            float width = columns * (grid.cellSize.x + grid.spacing.x) - grid.spacing.x;
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
        }
    }
}