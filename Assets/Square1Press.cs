﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square1Press : MonoBehaviour {


    public GameObject x;
    public GameObject o;

    public GameObject currentLocation;

    

    
    public Vector3 location;


    public Button ButtonBoard;

   // public   GameObject oTurn;
   // public   GameObject xTurn;

    public void DaCurrentTurn()
    {
        if(WhoGoesFirst.nextO == true)
        {
        //    oTurn.SetActive(true);
        //    xTurn.SetActive(false);
        }

        else if(WhoGoesFirst.nextO == false)
            {

          //  oTurn.SetActive(false);
          //  xTurn.SetActive(true);
        }

    }

    public void SpawnObject()
    {

        if (WhoGoesFirst.nextO == false)
        {
            WhoGoesFirst.nextO = true;

            CheckWin.whatPieceSquare1 = "x";
                

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            Instantiate(x, currentLocation.transform.position
                ,

                Quaternion.identity);
           

            
        }

        else if (WhoGoesFirst.nextO == true)
        {
            WhoGoesFirst.nextO = false;

            CheckWin.whatPieceSquare1 = "o";

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
