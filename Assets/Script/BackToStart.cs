using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour
{
    public void BTS() //called when button is pressed in game
    {
        SceneManager.LoadSceneAsync(0); //loads scene one as determined in build settings.
    }

}
