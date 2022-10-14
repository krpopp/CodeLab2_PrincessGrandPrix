using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MALHeuristic : HueristicScript
{
    public override float Hueristic(int x, int y, Vector3 start, Vector3 goal, GridScript gridScript)
    {

        GameObject[,] grid = gridScript.GetGrid();

        // start
        float startCost = 0;
        for (int i = (int)start.x; i < x; i++)
        {
            for (int j = (int)start.y; j < y; j++)
            {
                startCost += gridScript.GetMovementCost(grid[i, j]);
            }
        }

        // goal
        float goalCost = 0;
        for (int i = x; i < (int)goal.x; i++)
        {
            for (int j = y; j < (int)goal.y; j++)
            {
                goalCost += gridScript.GetMovementCost(grid[i, j]);
            }
        }

        return startCost + goalCost;
    }
}
