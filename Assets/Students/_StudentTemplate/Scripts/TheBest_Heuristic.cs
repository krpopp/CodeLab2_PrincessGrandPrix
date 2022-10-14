using UnityEngine;
using System.Collections;
using System;

public class TheBest_Heuristic : HueristicScript
{

    public virtual float Hueristic(int x, int y, Vector3 start, Vector3 goal, GridScript gridScript)
    {
        // return priority as distance
        float goalDistance = Vector3.Distance(new Vector3(x, y), goal);
        long gdis = Convert.ToInt64(goalDistance);

        // get our distance from the start and subtract it from our distance
        float startDistance = Vector3.Distance(new Vector3(x, y), start);
        long sdis = Convert.ToInt64(startDistance);

        // return the coefficient of the goal and start
        long binCoeffx = GetBinCoeff(gdis, sdis);

        // return the total amount of combinations of the two numbers
        return binCoeffx;
    }

    // get the total number of combinations of N and K
    public long GetBinCoeff(long N, long K)
    {
        // This function gets the total number of unique combinations based upon N and K.
        // N is the total number of items. K is the size of the group. Total number of unique combinations = N! / ( K! (N - K)! ).
        long r = 1;
        long d;
        if (K > N) return 0;
        for (d = 1; d <= K; d++)
        {
            r *= N--;
            r /= d;
        }
        return r;
    }

}
