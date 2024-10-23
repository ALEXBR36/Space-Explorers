using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public void Option() //is called when button is pressed
    {
        SceneManager.LoadSceneAsync(2); //loads scene 2 in the build settings
    }
  
}
