using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZHueristic : HueristicScript
{
    public GridScript gridScript;
    public float k =-3f;
    public float b =0.1f;
   
    // Start is called before the first frame update
    void Start()
    {
        
        gridScript = FindObjectOfType<GridScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public override float Hueristic(int x, int y, Vector3 start, Vector3 goal, GridScript gridScript)
    {
        GameObject[,] pos;
        pos = gridScript.GetGrid();
        float cost = gridScript.GetMovementCost(pos[x, y]);

        float hueVal = k * cost + b;



        return hueVal;
    }
    
    /*
    public  float Hueristic(int x, int y) 
    {
        GameObject[,] pos;
        pos = gridScript.GetGrid();
        float cost= gridScript.GetMovementCost(pos[x, y]);

        float hueVal = k * cost + b;



            return hueVal;
    }
    */


}
