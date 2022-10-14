using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamNateHueristic : HueristicScript
{
    public override float Hueristic(int x, int y, Vector3 start, Vector3 goal, GridScript gridScript)
    {
        //creates a new vector3 that tracks the current grid position
        Vector3 current = new Vector3(x, y);
        //creates a distance value based on the distance from the current node to goal. 
        float distance = Vector3.Distance(current, goal);

        //creates a reference in the heuristic 
        GameObject[,] array = gridScript.GetGrid();
        return (gridScript.GetMovementCost(array[x, y]) + distance);
    }
}
