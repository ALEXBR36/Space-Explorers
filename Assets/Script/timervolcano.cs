using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timervolcano : MonoBehaviour
{
    
    public float ChangeTime; //allows me to enter a value in the inspector which can be changed anytime

    private void Update() //when button is pressed
    {
        ChangeTime -= Time.deltaTime; //minuses a value of time each frame that can be tracked to allow the code to know when to function
        if (ChangeTime < 0) //if time is less than 0 do whats below
        {
            SceneManager.LoadSceneAsync(7); //load scene number 6 as per the build settings
        }
    }
}
//this whole script is used if the player is taking too long to speed them up