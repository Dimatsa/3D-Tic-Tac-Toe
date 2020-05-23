using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckWin : MonoBehaviour {

   public static string whatPieceSquare1 = " ";
   public static string whatPieceSquare2 = " ";
   public static string whatPieceSquare3 = " ";
   public static string whatPieceSquare4 = " ";
   public static string whatPieceSquare5 = " ";
   public static string whatPieceSquare6 = " ";
   public static string whatPieceSquare7 = " ";
   public static string whatPieceSquare8 = " ";
   public static string whatPieceSquare9 = " ";



   public static int xWins = 0;
   public static int oWins = 0;
    public static string xtext;
    public static string otext;

    public static string winner;

    public GameObject diagWin1;
    public GameObject diagWin2;

    public GameObject vertWin1;
    public GameObject vertWin2;
    public GameObject vertWin3;

    public GameObject horzWin1;
    public GameObject horzWin2;
    public GameObject horzWin3;

    public GameObject tieWin;

    public Text xWinText;
    public Text oWinText;


    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;
    public Button b5;
    public Button b6;
    public Button b7;
    public Button b8;
    public Button b9;

    void Start()
    {
        PlayerPrefs.SetInt("dengis", 0);
        xWinText.text = xtext;
        oWinText.text = otext;

        xtext = xWins.ToString();
        xWinText.text = xtext;

        otext = oWins.ToString();
        oWinText.text = otext;
    }

    void ChangeInvoke()
    {
        Invoke("ChangeScene", 1.5F); 


    }

     void ChangeScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);


    }


    public void ChecksWin()
    {

      


        if (whatPieceSquare1 == "x" && whatPieceSquare2 == "x" && whatPieceSquare3 == "x")

        {
            winner = "x";
            Instantiate(horzWin1);

        }
        else if (whatPieceSquare4 == "x" && whatPieceSquare5 == "x" && whatPieceSquare6 == "x")

        {

            winner = "x";
            Instantiate(horzWin2);

        }
         else if (whatPieceSquare7 == "x" && whatPieceSquare8 == "x" && whatPieceSquare9 == "x")
        {
            winner = "x";
            Instantiate(horzWin3);

        }

             if (whatPieceSquare1 == "x" && whatPieceSquare5 == "x" && whatPieceSquare9 == "x")
        {
            winner = "x";
            Instantiate(diagWin2);
        }


           if (whatPieceSquare3 == "x" && whatPieceSquare5 == "x" && whatPieceSquare7 == "x" )
        {
            winner = "x";
            Instantiate(diagWin1);

        }


        else if (whatPieceSquare1 == "x" && whatPieceSquare4 == "x" && whatPieceSquare7 == "x")
        {
            winner = "x";
            Instantiate(vertWin1);
        }

        else if (whatPieceSquare2 == "x" && whatPieceSquare5 == "x" && whatPieceSquare8 == "x")
        {
            winner = "x";
            Instantiate(vertWin2);
        }

       else  if (whatPieceSquare3 == "x" && whatPieceSquare6 == "x" && whatPieceSquare9 == "x")
        {
            winner = "x";
            Instantiate(vertWin3);
        }

        /////Winner O

       else if (whatPieceSquare1 == "o" && whatPieceSquare2 == "o" && whatPieceSquare3 == "o")
        {
            winner = "o";
            Instantiate(horzWin1);
        }

        else if (whatPieceSquare4 == "o" && whatPieceSquare5 == "o" && whatPieceSquare6 == "o")
            {
            winner = "o";
            Instantiate(horzWin2);
        }

       else if (whatPieceSquare7 == "o" && whatPieceSquare8 == "o" && whatPieceSquare9 == "o")
        {
            winner = "o";
            Instantiate(horzWin3);
        }

        
        if (whatPieceSquare1 == "o" && whatPieceSquare5 == "o" && whatPieceSquare9 == "o")
        {
            winner = "o";
            Instantiate(diagWin2);
            
        }
        if (whatPieceSquare3 == "o" && whatPieceSquare5 == "o" && whatPieceSquare7 == "o")
        {
            winner = "o";
            Instantiate(diagWin1);
        }

       else if(whatPieceSquare1 == "o" && whatPieceSquare4 == "o" && whatPieceSquare7 == "o")
        {
            winner = "o";
            Instantiate(vertWin1);
        }

        else if(whatPieceSquare2 == "o" && whatPieceSquare5 == "o" && whatPieceSquare8 == "o")
        {
            winner = "o";
            Instantiate(vertWin2);
        }

        else if (whatPieceSquare3 == "o" && whatPieceSquare6 == "o" && whatPieceSquare9 == "o")
        {
            winner = "o";
            Instantiate(vertWin3);
        }

        if (winner == "o" || winner == "x")
        {
            whatPieceSquare1 = " ";
            whatPieceSquare2 = " ";
            whatPieceSquare3 = " ";
            whatPieceSquare4 = " ";
            whatPieceSquare5 = " ";
            whatPieceSquare6 = " ";
            whatPieceSquare7 = " ";
            whatPieceSquare8 = " ";
            whatPieceSquare9 = " ";

            if (winner == "o")
            {
                oWins++;
                otext = oWins.ToString();

                oWinText.text = otext;
                PlayerPrefs.SetInt("dengis", PlayerPrefs.GetInt("dengis") + 5);

            }

            if (winner == "x")
            {
                xWins++;
                xtext = xWins.ToString();

                xWinText.text = xtext;

                PlayerPrefs.SetInt("dengis", PlayerPrefs.GetInt("dengis") + 5);
                
            }

            winner = " ";

            b1.interactable = false;
            b2.interactable = false;
            b3.interactable = false;
            b4.interactable = false;
            b5.interactable = false;
            b6.interactable = false;
            b7.interactable = false;
            b8.interactable = false;
            b9.interactable = false;

            ChangeInvoke();
      



        }

        else if (whatPieceSquare1 != " " && whatPieceSquare2 != " " &
                 whatPieceSquare3 != " " && whatPieceSquare4 != " " &
                 whatPieceSquare5 != " " && whatPieceSquare6 != " " &
                 whatPieceSquare7 != " " && whatPieceSquare8 != " " &
                 whatPieceSquare9 != " ")
        {
            whatPieceSquare1 = " ";
            whatPieceSquare2 = " ";
            whatPieceSquare3 = " ";
            whatPieceSquare4 = " ";
            whatPieceSquare5 = " ";
            whatPieceSquare6 = " ";
            whatPieceSquare7 = " ";
            whatPieceSquare8 = " ";
            whatPieceSquare9 = " ";
            winner = " ";

            Instantiate(tieWin);

            ChangeInvoke();
 

        }
    }
    

}
