using System;
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
    [field: SerializeField] public GameObject HexPrefab { get; private set; }
    //TODO: Create a grid of hexes
    //TODO: Store the individual tiles in an array
    //TODO: Methods to get, change, add, and remove tiles
    //TODO: Gizmo for drawing the grid in the editor

    private void OnDrawGizmos()
    {
        for (int z = 0; z < Height; z++)
        {
            for (int x = 0; x < Width; x++)
            {
                Vector3 centerPosition = HexMetrics.Center(HexSize, x, z, Orientation) + transform.position;

                /*
                int pointsAmount = (Width * Height) * 4;

                Vector3[] points = new Vector3[pointsAmount];

                for (int s = 0; s < HexMetrics.Corners(HexSize, Orientation).Length; s++)
                {
                    points[s] = centerPosition + HexMetrics.Corners(HexSize, Orientation)[s % 6];
                    points[s + 1] = centerPosition + HexMetrics.Corners(HexSize, Orientation)[(s + 1) % 6];
                }

                Vector3[] newPoints = RemoveEverySeventhElement(points, 7);

                static Vector3[] RemoveEverySeventhElement(Vector3[] inputArray, int step)
                {
                    int newSize = inputArray.Length;

                    // Count the number of elements to remove
                    int elementsToRemove = newSize / step;

                    // Create a new array with the adjusted size
                    Vector3[] newArray = new Vector3[newSize - elementsToRemove];

                    int newArrayIndex = 0;

                    // Copy elements to the new array, skipping the first occurrence of every 7th element
                    for (int i = 0; i < newSize; i++)
                    {
                        if (i % step != 0 || i == 0) // Exclude the first occurrence of every 7th element
                        {
                            newArray[newArrayIndex] = inputArray[i];
                            newArrayIndex++;
                        }
                    }

                    return newArray;
                }

                /*
                Vector3[] points2 = RemoveFirstElement(points);

                static Vector3[] RemoveFirstElement(Vector3[] inputArray)
                {
                        // Create a new array with size one less than the original
                        Vector3[] newArray = new Vector3[inputArray.Length - 2];

                        // Copy the elements starting from index 1 of the original array to the new array
                        Array.Copy(inputArray, 1, newArray, 0, newArray.Length);

                        return newArray;
                }
                Gizmos.DrawLineStrip(newPoints, false);
                */

                for (int s = 0; s < HexMetrics.Corners(HexSize, Orientation).Length; s++)
                {
                    Gizmos.DrawLine(
                        centerPosition + HexMetrics.Corners(HexSize, Orientation)[s % 6],
                        centerPosition + HexMetrics.Corners(HexSize, Orientation)[(s + 1) % 6]
                        );
                }
                
            }
        }
    }
}

public enum HexOrientation
{
    FlatTop,
    PointyTop
}