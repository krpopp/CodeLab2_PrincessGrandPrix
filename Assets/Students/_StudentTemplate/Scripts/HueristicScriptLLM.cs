using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Comparers;


public class HueristicScriptLLM : HueristicScript
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /* Using just materials; grid2 = 378.9
      public override float Hueristic(int x, int y, Vector3 start, Vector3 goal, GridScript gridScript)
     {
         GameObject[,] grid = gridScript.GetGrid();

         float cost = gridScript.GetMovementCost(grid[x,y]);
         return -cost;
     } */


    /*
     using only distance; grid2 = 576.9 
    public override float Hueristic(int x, int y, Vector3 start, Vector3 goal, GridScript gridScript)
     {
         float distance = Vector3.Distance(goal, new Vector3(x, y));
         return -distance;
     } */

    
    
    public override float Hueristic(int x, int y, Vector3 start, Vector3 goal, GridScript gridScript)
    {
        GameObject[,] grid = gridScript.GetGrid();

        float cost = gridScript.GetMovementCost(grid[x, y]);
        
        float distance = Vector3.Distance(goal, new Vector3(x, y));
        Debug.Log(cost);
        Debug.Log(distance);
        Debug.Log(cost + distance);
        // return (cost + distance); //grid 1 = 280.21;
        // return (cost + distance/cost); //grid 1 = 296.35; grid2 = 184;
        // return (distance / cost); //grid1 = 211; grid2 = 208 PTT = 24
        // return ((cost + distance)/ cost); // grid2 = 202;
        //return (cost + distance); //PTT negative, g2 = 15.9588; PTT positive, 16.18;
        //return cost; //PTT 16.194;
        return (cost * distance); // PTT = 16.17
        //return (cost * (distance / 10f));

    }

}
