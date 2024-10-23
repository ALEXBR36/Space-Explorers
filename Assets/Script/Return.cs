using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    public void Returns() //called when a button is pressed in game because the gmaeobject this script is attachted to is put into the button gameobject allowing the button to call this function
    {
        SceneManager.LoadSceneAsync(0); //loads scene 0 as per the project settings
    }
}
