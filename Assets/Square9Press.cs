using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square9Press : MonoBehaviour
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
            CheckWin.whatPieceSquare9 = "x";

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            Instantiate(x, currentLocation.transform.position
                ,

                Quaternion.identity);
            WhoGoesFirst.nextO = true;
            

        }

        else if (WhoGoesFirst.nextO == true)
        {
            WhoGoesFirst.nextO = false;

            CheckWin.whatPieceSquare9 = "o";

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            Instantiate(o, currentLocation.transform.position
                ,

                Quaternion.identity);
          



        }
        ButtonBoard.interactable = false;
        WhoGoesFirst.moveCount++;
    }



}
