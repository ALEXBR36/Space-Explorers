using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
      public void Play() //called when button is pressed in game
    {
        SceneManager.LoadSceneAsync(1); //loads scene one as determined in build settings.
    }
    
}
