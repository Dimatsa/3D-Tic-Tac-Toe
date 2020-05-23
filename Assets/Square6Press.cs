using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square6Press : MonoBehaviour
{


    public GameObject x;
    public GameObject o;

    public GameObject currentLocation;




    public Vector3 location;

    public static bool nextO;

    public Button ButtonBoard;

    public void SpawnObject()
    {

        if (WhoGoesFirst.nextO == false)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            CheckWin.whatPieceSquare6 = "x";

            Instantiate(x, currentLocation.transform.position
                ,

                Quaternion.identity);
             WhoGoesFirst.nextO = true;


        }

        else if (WhoGoesFirst.nextO == true)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            CheckWin.whatPieceSquare6 = "o";

            Instantiate(o, currentLocation.transform.position
                ,

                Quaternion.identity);
            WhoGoesFirst.nextO = false;



        }
        ButtonBoard.interactable = false;
        WhoGoesFirst.moveCount++;
    }



}
