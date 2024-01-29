using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGrid : MonoBehaviour
{
    //Amazing source for hexagonal grid games: https://www.redblobgames.com/
    //TODO: Add properties for grid size, hex size, and hex prefab
    [field:SerializeField] public HexOrientation Orientation { get; private set; }
    [field:SerializeField] public int Width { get; private set; }
    [field: SerializeField] public int Height { get; private set; }
    [field: SerializeField] public float HexSize { get; private set; }
    //TODO: Create a grid of hexes
    //TODO: Store the individual tiles in an array
    //TODO: Methods to get, change, add, and remove tiles
    //TODO: Gizmo for drawing the grid in the editor
}

public enum HexOrientation
{
    FlatTop,
    PointyTop
}