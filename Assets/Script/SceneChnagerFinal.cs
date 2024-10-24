using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChnagerFinal : MonoBehaviour
{
    public float ChangeTime; //creates float (decimal) variable which can be changed in inspector as it is public
    public string SceneName; //creates string which can be changed in inspector as it is public

    private void Update() //when button is pressed
    {
        ChangeTime -= Time.deltaTime; //minuses a value of time each frame that can be tracked to allow the code to know when to function

        if (ChangeTime < 0) //if the time is less than zero
            SceneManager.LoadScene(SceneName); //laod scene as per the scenename string in inspector
    }
    //script allows same script to be used in different scenes
}
