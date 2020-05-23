using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhoGoesFirst : MonoBehaviour {


    public static bool randomChoice;
    public static bool nextO;

    public static int moveCount = 0;

    public void playerXorO()
    {

    

        if (moveCount == 0)
        {
            int rr = Random.Range(0, 2);




            if (rr == 1)
            {
                nextO = true;
             
            }
            if (rr == 2)
            {

                nextO = false;
              
            }

           
        }
    }
    }



