using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class p1UIClicks : MonoBehaviour
{

   


     public void ClickPlay()
    { 
        SceneManager.LoadScene("Board");

      
    }


    public void backToMainMenu()
    {
        CheckWin.oWins = 0;
        CheckWin.xWins = 0;
        SceneManager.LoadScene("Menu");


    }
    
}
