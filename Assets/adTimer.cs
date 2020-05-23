using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class adTimer : MonoBehaviour {

    public static float adSecondsPassed = 0;



	public void Update () {
        adSecondsPassed += Time.deltaTime;

	}

    public void Awake()
    {
        if(adSecondsPassed >= 60.0f)
        {
            adSecondsPassed = 0;
            Advertisement.Show();
            
        }


    }





}
